using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altair_1000.devices.CPU.Commands
{
    /// <summary>
    /// Команда процессора
    /// </summary>
    public abstract class Command
    {
        // Ширина слова модификатора команды (бит)
        public const int ModLength = 3;

        // Ширина слова
        public Byte BytesLength = 1;

        // Bin-индентификатор команды
        public CWord CmdWord = new CWord(CWord.MaxCapacity);

        // Dec-идентификатор
        public Byte CmdByte => CmdWord.asByte;

        // Hex-идентификатор
        public String CmdHex => CmdWord.asHex;

        // Допустимые модификаторы
        public List<CWord> ModList = null;

        // Рабочий процессор
        public CPU CPU = null;

        /// <summary>
        /// Выполнить команду
        /// </summary>
        public abstract void Exec(CWord Mode);

        /// <summary>
        /// Проверка модификатора
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        private Boolean checkMod(CWord Mode)
        {
            if (ModList == null)
                return true;
            else if (ModList.Count == 0)
                return (Mode.asByte == 0);

            for(int i = 0; i < ModList.Count; i++)
            {
                if (Mode.asByte == ModList[i].asByte)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Получение модификатора из машинного слвоа команды
        /// </summary>
        /// <param name="cWord">Машинное слово</param>
        /// <returns>Модификатор</returns>
        public static CWord getModFromWord(CWord cWord)
        {
            CWord Mod = new CWord(ModLength);
            int ModIndex = ModLength - 1;

            for(int i = cWord.Capacity - 1; (ModIndex >= 0) && (i >= 0); i--)
            {
                Mod.Data[ModIndex] = cWord.Data[i];
                ModIndex--;
            }

            return Mod;
        }
    }
}
