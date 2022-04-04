using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3OverloadingOperations.MatrixForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Matrix.FormMain = this;
            OnLoad();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ShowForm.PerformOperation("Add");
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            ShowForm.PerformOperation("Change");
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void OnLoad()
        {
            Matrix.FormMain.ResultRTextBox.Lines = Matrix.ResultText != null ? Matrix.ResultText : null;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ResultRTextBox.Clear();
            Matrix.MatrixA = new Matrix();
            Matrix.MatrixB = new Matrix();
            Matrix.MatrixAName = string.Empty;
            Matrix.MatrixBName = string.Empty;
            Matrix.LblMatrixName = new Label();
        }
    }
}