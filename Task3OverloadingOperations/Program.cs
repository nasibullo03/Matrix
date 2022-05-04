/*****************************************
*   Program - Name: Квадратная матрица   *
*   Date: 04.05.2022                     *
*   Author: Nasibullo Khalilov           *
*****************************************/

using System;
using System.Windows.Forms;

namespace Task3OverloadingOperations
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
            Application.Run(new Form1());
        }
    }
}