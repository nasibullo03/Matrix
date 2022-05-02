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
        #region Metods

        public Main()

        {
            InitializeComponent();
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
            PerformOperation.Operations[PerformOperation.Operation.Plus]();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            PanelResult.Controls.Clear();
            Matrix.MatrixA = new Matrix();
            Matrix.MatrixB = new Matrix();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.Minus]();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.Multiply]();
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.Divide]();
        }

        private void ButtonDeterminant_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.Determinant]();
        }

        private void ButtonMinor_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.Minor]();
        }

        private void ButtonTranspose_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.Transpose]();
        }

        #endregion Metods

        private void Main_Load(object sender, EventArgs e)
        {
            Matrix.FormMain = this;
            PerformOperation.Operations[PerformOperation.Operation.ShowMatrixs]();
        }

        private void ButtonGreatThan_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.GreateThan]();
        }

        private void ButtonSmallThan_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.SmallThan]();
        }

        private void ButtonIsNotEqual_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.IsNotEqual]();
        }

        private void ButtonSmall_OR_Equal_Than_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.SmallOrEqualThan]();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.Equal]();
        }

        private void ButtonGrate_OR_Equal_Than_Click(object sender, EventArgs e)
        {
            PerformOperation.Operations[PerformOperation.Operation.GreatOrEqualThan]();
        }
    }
}