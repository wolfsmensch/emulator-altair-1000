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
        // Список команд

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

        public CPU(RAM RAM)
        {
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
                throw new Exception("Не удалось подключиться к устройству оперативной памяти");            
        }

        /// <summary>
        /// Выполнение такта (цикла) процессора
        /// </summary>
        public void Clock()
        {
            throw new NotImplementedException();
        }
    }
}
