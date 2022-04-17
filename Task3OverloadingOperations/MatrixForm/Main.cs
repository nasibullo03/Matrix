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
        #region Fields

        public enum Operation
        { Plus, Minus, Multiply, Divide, Determinant, Minor, Transpose, ShowMatrixs }

        private delegate void operation();

        private static Dictionary<Operation, operation> Operations;

        #endregion Fields

        #region Metods

        public static void FillOperations()
        {
            Operations = new Dictionary<Operation, operation> {
                { Operation.Plus, ShowMatrix.Plus },
                { Operation.Minus,ShowMatrix. Minus},
                { Operation.Multiply, ShowMatrix.Multiply},
                { Operation.Divide, ShowMatrix.Divide},
                { Operation.Determinant, ShowMatrix.Determinant},
                { Operation.Minor, ShowMatrix.Minor},
                { Operation.Transpose, ShowMatrix.Transpose},
                { Operation.ShowMatrixs, ShowMatrix.Show}
            };
        }

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
            Operations[Operation.Plus]();
        }

        private void OnLoad()
        {
            //Operations[Operation.ShowMatrixs]();
            ShowMatrix.Show();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ResultRTextBox.Clear();
            Matrix.MatrixA = new Matrix();
            Matrix.MatrixB = new Matrix();
            Matrix.MatrixA.Name = string.Empty;
            Matrix.MatrixB.Name = string.Empty;
            Matrix.LblMatrixName = new Label();
        }

        #endregion Metods

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Operations[Operation.Minus]();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Operations[Operation.Multiply]();
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            Operations[Operation.Divide]();
        }

        private void ButtonDeterminant_Click(object sender, EventArgs e)
        {
            Operations[Operation.Determinant]();
        }

        private void ButtonMinor_Click(object sender, EventArgs e)
        {
            Operations[Operation.Minor]();
        }

        private void ButtonTranspose_Click(object sender, EventArgs e)
        {
            Operations[Operation.Transpose]();
        }
    }
}