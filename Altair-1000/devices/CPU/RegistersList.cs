using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altair_1000.devices.CPU
{
    /// <summary>
    /// Банк (список) регистров
    /// </summary>
    public class RegistersList
    {
        /// <summary>
        /// Общее название
        /// </summary>
        public readonly String Name;

        /// <summary>
        /// Ширина данных каждого регистра
        /// </summary>
        public readonly Byte RegistersCapacity = CWord.MaxCapacity;

        /// <summary>
        /// Список регистров
        /// </summary>
        public List<Register> List;

        /// <summary>
        /// Кол-во регистров
        /// </summary>
        public Byte Count => (Byte)List.Count;

        public RegistersList(String Name = "", Byte RegistersCapacity = CWord.MaxCapacity)
        {
            this.Name = (Name.Length > 0) ? Name : String.Empty;

            if (RegistersCapacity > CWord.MaxCapacity)
                throw new Exception(String.Format("Установленная ширина данных ({0}) превышает максимальную - {1}", 
                    RegistersCapacity, CWord.MaxCapacity));

            this.RegistersCapacity = RegistersCapacity;
        }

        /// <summary>
        /// Добавить новый регистр
        /// </summary>
        /// <param name="ReadOnly"></param>
        public void Add(Boolean ReadOnly = false)
        {
            List.Add(new Register(String.Empty, RegistersCapacity, ReadOnly));
        }

        /// <summary>
        /// Получение индекса регистра по CWord-адресу
        /// </summary>
        /// <param name="cWordAddr"></param>
        /// <returns></returns>
        public int getIndexByCWord(CWord cWordAddr)
        {
            if (cWordAddr.asByte > (Count - 1))
                throw new Exception("Попытка обратить к несуществующему регистру по адресу: " + cWordAddr.asHex);

            return cWordAddr.asByte;
        }

        /// <summary>
        /// Получить регистр по CWord-адресу
        /// </summary>
        /// <param name="cWordAddr"></param>
        /// <returns></returns>
        public Register getByCWord(CWord cWordAddr)
        {
            return List[getIndexByCWord(cWordAddr)];
        }

        /// <summary>
        /// Установить значение регистра по CWord-адресу
        /// </summary>
        /// <param name="Addr"></param>
        /// <param name="Data"></param>
        public void setByCWord(CWord Addr, CWord Data)
        {
            if (Data.Capacity != List[getIndexByCWord(Addr)].Data.Capacity)
                throw new Exception(String.Format("Несовпадение ширины данных присваемого значения и целевого регистра на адресе {0}", Addr.asHex));

            List[getIndexByCWord(Addr)].Data = Data;
        }
    }
}
