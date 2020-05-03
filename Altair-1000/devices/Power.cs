using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altair_1000.devices
{
    /// <summary>
    /// Питание машины
    /// </summary>
    public class Power
    {
        // Регистр статуса питания
        // Ячейки регистра:
        //  0 - запускается
        //  1 - сервисный режим
        //  2 - аппаратная ошибка
        //  3 - штатный режим работы
        //  4 - выключается
        public CPU.Register RegStatus = new CPU.Register("", 5, true);

        // Эталонное состояние регистра статуса в сервисном режиме
        private CPU.CWord GoodServiceMode = new CPU.CWord(5);

        // Устройства
        public CPU.CPU CPU = null;
        public RAM RAM = null;

        public Power()
        {
            RegStatus.Data.Clear();

            GoodServiceMode.Clear();
            GoodServiceMode.Data[1] = true;
        }

        /// <summary>
        /// Запуск машины
        /// </summary>
        /// <param name="startToService">Запуск в сервисном режиме</param>
        public void Start(Boolean startToService = false)
        {
            RegStatus.Data.Clear();
            RegStatus.Data.Data[0] = true;

            RAM = new RAM();

            if (startToService)
            {
                RegStatus.Data.Clear();
                RegStatus.Data.Data[1] = true;

                return;
            }

            CPU = new CPU.CPU(this, RAM);

            RegStatus.Data.Clear();
            RegStatus.Data.Data[3] = true;
        }

        /// <summary>
        /// Переключение из сервисного режима - в штатный
        /// </summary>
        public void SwitchToNormal()
        {
            if (RegStatus.Data.asByte != GoodServiceMode.asByte)
                throw new Exception("Невозможно переключиться в штатный режим - текущий режим НЕ сервисный");

            CPU = new CPU.CPU(this, RAM);

            RegStatus.Data.Clear();
            RegStatus.Data.Data[3] = true;
        }

        /// <summary>
        /// Штатная остановка машины
        /// </summary>
        public void Stop()
        {
            RegStatus.Data.Clear();
            RegStatus.Data.Data[4] = true;

            CPU = null;
            RAM = null;

            RegStatus.Data.Clear();
        }

        /// <summary>
        /// Произошла аппаратная ошибка
        /// </summary>
        /// <param name="Message"></param>
        public void Fatal(String Message)
        {
            RegStatus.Data.Clear();
            RegStatus.Data.Data[2] = true;

            MessageBox.Show(String.Format("Во время работы произошла аппаратная ошибка. Выполнение остановлено, машина переведена в режим ОШИБКА.\n\nСообщение об ошибке:\n\n{1}",
                Message), "Аппаратная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
