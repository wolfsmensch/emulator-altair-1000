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
        public Byte Size => (Byte)Cells.Length;

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
                for(int j = 0; j < CPU.CWord.MaxCapacity; j++)
                    Cells[i].Data[j] = false;
            }
        }

        /// <summary>
        /// Получить значение ячейки по CWord
        /// </summary>
        /// <param name="word">Слово</param>
        /// <returns>Значение ячейки</returns>
        public CPU.CWord getByCWord(CPU.CWord word)
        {
            if (word.asByte > (Size - 1))
                throw new Exception(String.Format("Обращение к несуществующему адресу: {0}", word.asHex));

            return Cells[word.asByte];
        }
    }
}
