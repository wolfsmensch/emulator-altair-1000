using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altair_1000.devices.CPU
{
    /// <summary>
    /// Регистр процессора
    /// </summary>
    public class Register
    {
        public readonly String Name = String.Empty;
        public readonly Byte Capacity = CWord.MaxCapacity;

        public readonly Boolean ReadOnly;

        public CWord Data;

        public Register(String Name = "", Byte Capacity = CWord.MaxCapacity, Boolean ReadOnly = false)
        {
            this.Name = (Name.Length > 0) ? Name : String.Empty;

            if (Capacity > CWord.MaxCapacity)
                throw new Exception(String.Format("Установленная ширина данных ({0}) превышает максимальную - {1}", Capacity, CWord.MaxCapacity));

            this.Capacity = Capacity;
            this.ReadOnly = ReadOnly;

            Data = new CWord(Capacity);
        }
    }
}
