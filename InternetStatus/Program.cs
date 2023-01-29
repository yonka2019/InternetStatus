using darknet.forms;
using System;
using System.Windows.Forms;

namespace InternetStatus
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DarkNet.SetDarkModeAllowedForProcess(true);
            Application.Run(new MainForm());
        }
    }
}
