using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altair_1000.devices.CPU
{
    /// <summary>
    /// Центральный процессор
    /// </summary>
    public class CPU
    {
        // Управление питанием
        public Power PowerDevice;

        // Список команд
        private Commands.CommandsList Cmds = null;

        // ==============  РЕГИСТРЫ  ==============

        /// <summary>
        /// Указатель на текущий адрес исполняемой инструкции
        /// </summary>
        public Register AddrPointer => _AddrPointer;
        private Register _AddrPointer = new Register("PTR", 8, true);

        /// <summary>
        /// Аккумулятор
        /// </summary>
        public Register Accumulator => _Accumulator;
        private Register _Accumulator = new Register("ACC", 8, false);

        /// <summary>
        /// Флаг переноса
        /// </summary>
        public Register Carry => _Carry;
        private Register _Carry = new Register("CLC", 1, false);

        /// <summary>
        /// Банк регистров общего назначения
        /// </summary>
        public RegistersList Regular => _Regular;
        private RegistersList _Regular;

        /// <summary>
        /// Стэк
        /// </summary>
        public RegistersList Stack => _Stack;
        private RegistersList _Stack;
        private Byte StackDelay = 0;
        public Byte CurStackIndex => getCurStackIndex();

        /// <summary>
        /// Кол-во регистров общего назначения
        /// </summary>
        public static Byte RegularRegistersCount = 16;
        public static Byte StackSize = 3;        

        /// <summary>
        /// Кол-во выполненных тактов
        /// </summary>
        UInt32 CyclesCnt = 0;
        
        public RAM RAM = null;

        public CPU(Power PowerDevice, RAM RAM)
        {
            this.PowerDevice = PowerDevice;

            // Инициализация регистров общего назначения
            _Regular = new RegistersList("R", CWord.MaxCapacity);

            for (int i = 0; i < (RegularRegistersCount - 3); i++)
                _Regular.Add(false);

            for (int i = 0; i < 3; i++)
                _Regular.Add(true);

            // Инициализация регистров стэка
            _Stack = new RegistersList(String.Empty, CWord.MaxCapacity);
            for (int i = 0; i < StackSize; i++)
                _Stack.Add(true);

            // Инициализация ОЗУ
            this.RAM = RAM;
            if ((RAM == null) || (RAM.Size <= 0))
            {
                PowerDevice.Fatal("Не удалось подключиться к устройству оперативной памяти");
                return;
            }

            // Инициализация списка команд
            Cmds = new Commands.CommandsList(this);
        }

        /// <summary>
        /// Выполнение такта (цикла) процессора
        /// </summary>
        public void Clock()
        {
            if (Cmds == null)
            {
                PowerDevice.Fatal("Отсутствует таблица команд");
                return;
            } else if ( !PowerDevice.RegStatus.Data.Data[3] )
            {
                throw new Exception("Процессор не может выполнить такт - машина не в штатном режиме работы");
            }

            Boolean isNewCmd = false;

            // Нет задержки стека
            if (StackDelay == 0)
            {
                // Стек пуст - значит это новая команда
                if ( _Stack.isEmpty )
                {
                    isNewCmd = true;
                    _Stack.List[0].Data = RAM.getByCWord(AddrPointer.Data);
                }

                // Поиск команды в таблице комманд
                Commands.Command foundCmd = Cmds.findByCWord(_Stack.List[0].Data);
                if (foundCmd == null)
                {
                    PowerDevice.Fatal(String.Format("Неизвестная команда в адресе {0}.\nКоманда: {1}", AddrPointer.Data.asHex, _Stack.List[0].Data.ToString()));
                    return;
                }

                // Это команда в 1 слово или данные команды полностью в стеке
                if ( (foundCmd.BytesLength == 1) || (!isNewCmd) )
                {
                    try
                    {
                        foundCmd.Exec(Commands.Command.getModFromWord(_Stack.List[0].Data));
                    }
                    catch (Exception ex)
                    {
                        PowerDevice.Fatal(String.Format("Ошибка исполнения команды в адресе {0}.\nКоманда: {1}\nОшибка: {2}",
                            AddrPointer.Data.asHex, _Stack.List[0].Data.ToString(), ex.Message));
                        return;
                    }

                    _Stack.Clear();
                }
                // Это команда в несколько слов - задаем задержку стека
                else
                    StackDelay = (Byte)(foundCmd.BytesLength - 1);
            }
            // Есть задержка стека - наполняем его данными
            else
            {
                _Stack.List[CurStackIndex].Data = RAM.getByCWord(AddrPointer.Data);
                StackDelay--;
            }

            // Переход к следующему адресу
            AddrPointer.Data.Inc();
            CyclesCnt++;
        }

        /// <summary>
        /// Получение текущего индекса ячейки стека
        /// </summary>
        /// <returns></returns>
        private Byte getCurStackIndex()
        {
            if (StackDelay == 0) return 0;

            Byte Index = StackSize;
            Index--;
            Index -= StackDelay;

            return Index;
        }
    }
}
