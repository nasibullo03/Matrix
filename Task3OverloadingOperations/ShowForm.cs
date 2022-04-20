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
        public static Form1 Form1 { get; set; }

        private delegate void OperationDelegate();

        private static Dictionary<string, OperationDelegate> Operations { get; set; }

        public ShowForm()
        {
        }

        private static void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            Form1.PanelForms.Controls.Add(form);
            form.Show();
        }

        private static void ClearPannelFormValue()
        {
            Form1.ClearPannelFormValue();
        }

        private static void FormAdd()
        {
            ClearPannelFormValue();
            OpenForm(new MatrixForm.Add());
        }

        private static void FormMain()
        {
            ClearPannelFormValue();
            OpenForm(new MatrixForm.Main());
        }

        private static void FormChange()
        {
            ClearPannelFormValue();
            OpenForm(new MatrixForm.Change());
        }

        public static void PerformOperation(string op)
        {
            Operations =
             new Dictionary<string, OperationDelegate>
            {
                { "Add", FormAdd },
                { "Main", FormMain },
                { "Change", FormChange }
            };
            if (!Operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op), "op");
            Operations[op]();
        }

        public static void ShowOneMartix(Matrix matrix, String MatrixName)
        {
        }

        public static void ShowBothMartixs()
        {
        }
    }
}