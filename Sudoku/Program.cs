using System;
using System.Windows.Forms;

namespace Sudoku
{
    /// <summary>
    /// ������ ����
    /// </summary>
    static class Program
    {
        /// <summary>
        ///  �������� ����� �����
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ����());
        }
    }
}