using DataGridAvto.Framework.CarManager;
using DataGridAvto.Storage.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridAvto
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storage = new MemoryCarStorage();
            var manager = new CarManager(storage);

            Application.Run(new Form1(manager));
        }
    }
}
