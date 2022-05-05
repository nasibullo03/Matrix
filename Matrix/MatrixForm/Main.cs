using System;
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

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_SAVEBITS = 0x0800;
                //Сохраняет в виде растрового изображения часть изображения экрана,
                //скрытая окном этого класса.При удалении окна система использует
                //сохраненную растровую карту для восстановления изображения экрана,
                //включая другие окна, которые были скрыты.

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_SAVEBITS;
                return cp;
            }
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
            SquareMatrix.MatrixA = new SquareMatrix();
            SquareMatrix.MatrixB = new SquareMatrix();
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
            SquareMatrix.FormMain = this;
            PerformOperation.Operations[PerformOperation.Operation.ShowMatrixs]();
            SquareMatrix.textBoxes = null;
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