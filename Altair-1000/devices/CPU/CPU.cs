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
        // Регистры

        /// <summary>
        /// Указатель на адрес текущей инструкции
        /// </summary>
        Byte AddrPointer;

        /// <summary>
        /// Кол-во выполненных тактов
        /// </summary>
        UInt32 CyclesCnt;
        
        public RAM RAM = null;

        public CPU(RAM RAM)
        {
            this.RAM = RAM;
            if ((RAM == null) || (RAM.Size <= 0))
                throw new Exception("Не удалось подключиться к устройству оперативной памяти");
            
            AddrPointer = 0;
            CyclesCnt = 0;
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
