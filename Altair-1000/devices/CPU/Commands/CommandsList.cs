using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altair_1000.devices.CPU.Commands
{
    /// <summary>
    /// Список доступных команд процессора
    /// </summary>
    public class CommandsList
    {
        // Рабочий процессор
        private CPU CPU = null;

        // Список доступных команд
        private List<Command> List = new List<Command>();

        public CommandsList(CPU CPU)
        {
            if (CPU == null) throw new Exception("Архитектура команд не может быть инициализирована без привязки к CPU");
            this.CPU = CPU;

            LoadCommands();
        }

        /// <summary>
        /// Загрузка списка команд
        /// </summary>
        private void LoadCommands()
        {
            List.Clear();
        }

        /// <summary>
        /// Поиск команды по CWord
        /// </summary>
        /// <param name="cWord">Номер команды</param>
        /// <returns>Команда</returns>
        public Command findByCWord(CWord cWord)
        {
            CWord LocalWord = (CWord)cWord.Clone();

            for (int i = CWord.MaxCapacity - 1; i > CWord.MaxCapacity - 4; i--)
                LocalWord.Data[i] = false;

            return List.First(x => (x.CmdWord == LocalWord));
        }        
    }
}
