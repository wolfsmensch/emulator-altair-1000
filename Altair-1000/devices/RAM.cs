using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altair_1000.devices
{
    /// <summary>
    /// Оперативная память
    /// </summary>
    public class RAM
    {
        /// <summary>
        /// Разрядность шины адреса
        /// </summary>
        public static readonly int AddressLength = 8;

        /// <summary>
        /// Ячейки памяти
        /// </summary>
        public CPU.CWord[] Cells;

        /// <summary>
        /// Вместимость памяти (байт)
        /// </summary>
        public UInt16 Size => (UInt16)Cells.Length;

        public RAM()
        {
            Cells = new CPU.CWord[(Int32)Math.Pow(2, (Double)AddressLength)];
            for (int i = 0; i < Size; i++)
                Cells[i] = new CPU.CWord();

            Clear();
        }

        /// <summary>
        /// Обнуление всех ячеек памяти
        /// </summary>
        public void Clear()
        {
            if (Size < 1) return;

            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < CPU.CWord.Capacity; j++)
                    Cells[i].Data[j] = false;
            }
        }
    }
}
