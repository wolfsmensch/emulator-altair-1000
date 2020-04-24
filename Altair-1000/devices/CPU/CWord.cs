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
        /// <summary>
        /// Ширина машинного слова
        /// </summary>
        public static readonly int Capacity = 8;

        /// <summary>
        /// Биты
        /// </summary>
        public Boolean[] Data = new Boolean[Capacity];

        public CWord()
        {
            for (int i = 0; i < Capacity; i++)
                Data[i] = false;
        }

        /// <summary>
        /// Представление в виде типа Byte
        /// </summary>
        public Byte asByte => convertToByte();
        private Byte convertToByte()
        {
            Byte res = 0;

            for(int i = 0; i < Capacity; i++)
            {
                if (Data[i])
                {
                    Byte tmpVal = 0;
                    if (i == 0)
                        tmpVal = 1;
                    else
                    {
                        for(int j = 1; j <= i; j++)
                            tmpVal += 2;
                    }

                    res += tmpVal;
                }
            }

            return res;
        }

        /// <summary>
        /// Представление в виде HEX
        /// </summary>
        public String asHex => asByte.ToString("X");
    }
}
