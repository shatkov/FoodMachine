using System;
using System.Windows.Forms;

namespace FoodAutomat
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"Программа будет завершена аварийно!",
                    @"Неизвестная ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                // Запись ошибок в файл
                //Error.WriteError(ex);

                #if DEBUG
                throw;
                #endif
            }
        }
    }
}
