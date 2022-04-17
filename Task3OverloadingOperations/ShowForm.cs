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
        public static Form1 form1 { get; set; }

        private delegate void OperationDelegate();

        private static Dictionary<string, OperationDelegate> _operations { get; set; }

        public ShowForm()
        {
        }

        private static void showForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form1.PanelForms.Controls.Add(form);
            form.Show();
        }

        private static void ClearPannelFormValue()
        {
            form1.ClearPannelFormValue();
        }

        private static void FormAdd()
        {
            ClearPannelFormValue();
            showForm(new MatrixForm.Add());
        }

        private static void FormMain()
        {
            ClearPannelFormValue();
            showForm(new MatrixForm.Main());
        }

        private static void FormChange()
        {
            ClearPannelFormValue();
            showForm(new MatrixForm.Change());
        }

        public static void PerformOperation(string op)
        {
            _operations =
             new Dictionary<string, OperationDelegate>
            {
                { "Add", FormAdd },
                { "Main", FormMain },
                { "Change", FormChange }
            };
            if (!_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op), "op");
            _operations[op]();
        }

        public static void ShowOneMartix(Matrix matrix, String MatrixName)
        {
            PrintValue.PrintOneMatrix(matrix.MatrixValue, MatrixName);
        }

        public static void ShowBothMartixs()
        {
            PrintValue.PrintBothMatrix();
        }
    }
}