using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3OverloadingOperations
{
    internal class ShowForm
    {
        #region metods

        public static void FormMain()
        {
            Form1 Form1 = new Form1();
            Form1.ShowFormMain();
        }

        public static void FormAdd()
        {
            Form1 Form1 = new Form1();
            Form1.ShowFormAdd();
        }

        #endregion metods
    }
}