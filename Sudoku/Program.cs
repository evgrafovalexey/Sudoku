using System;
using System.Windows.Forms;

namespace Sudoku
{
    /// <summary>
    /// Запуск игры
    /// </summary>
    static class Program
    {
        /// <summary>
        ///  Основная точка входа
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Вход());
        }
    }
}