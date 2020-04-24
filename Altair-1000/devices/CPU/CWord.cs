using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altair_1000.devices.CPU
{
    /// <summary>
    /// Машинное слово (8 бит)
    /// </summary>
    public class CWord
    {
        public static readonly int Capacity = 8;
        public List<Boolean> Data = new List<bool>(Capacity);

        public CWord()
        {
            for (int i = 0; i < Capacity; i++)
                Data[i] = false;
        }
    }
}
