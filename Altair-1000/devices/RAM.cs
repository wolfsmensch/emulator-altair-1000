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
            return Cells[getIndexByCWord(word)];
        }

        /// <summary>
        /// Получить значение ячейки по Hex-адресу
        /// </summary>
        /// <param name="Hex">Адрес</param>
        /// <returns>Значение</returns>
        public CPU.CWord getByHex(string Hex)
        {
            return Cells[getIndexByHex(Hex)];
        }

        /// <summary>
        /// Установить значение ячейки по CWord-адресу
        /// </summary>
        /// <param name="addr">Адрес</param>
        /// <param name="data">Значение</param>
        public void setByCWord(CPU.CWord addr, CPU.CWord data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Установить значение ячейки по HEX-адресу
        /// </summary>
        /// <param name="hexAddr">HEX-Адрес</param>
        /// <param name="data">Значение</param>
        public void setByHex(string hexAddr, CPU.CWord data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение индекса ячейки по CWord
        /// </summary>
        /// <param name="cWordAddr"></param>
        /// <returns></returns>
        public Byte getIndexByCWord(CPU.CWord cWordAddr)
        {
            if (cWordAddr.asByte > (Size - 1))
                throw new Exception(String.Format("Обращение к несуществующему адресу: {0}", cWordAddr.asHex));

            return cWordAddr.asByte;
        }

        /// <summary>
        /// Получение индекса ячейки по HEX-адресу
        /// </summary>
        /// <param name="hexAddr"></param>
        /// <returns></returns>
        public Byte getIndexByHex(string hexAddr)
        {
            Int32 intVal = Int32.Parse(hexAddr, System.Globalization.NumberStyles.HexNumber);
            if ((intVal > (Size - 1)) || (intVal < 0))
                throw new Exception(String.Format("Обращение к несуществующему адресу: {0}", hexAddr));

            return (Byte)intVal;
        }
    }
}
