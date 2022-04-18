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
    public partial class Change : Form
    {
        public static string MatrixName { get; set; }

        public static bool isFirstMatrixValue { get; set; }

        public Change()
        {
            InitializeComponent();
        }

        public static void onLoadDefaultParametrs()
        {
            Matrix.FormChange.MatrixNameComboBox.Items.Clear();
            Matrix.FormChange.MatrixSizeComboBox.Items.Clear();
            if (!Matrix.IsMatrixAEmpty && Matrix.IsMatrixBEmpty)
            {
                Matrix.FormChange.MatrixNameComboBox.Text = Matrix.MatrixA.Name;
                Matrix.FormChange.MatrixNameComboBox.Items.Add(Matrix.MatrixA.Name);
                Matrix.MatrixSizeComboBox_ClearItems();
                Matrix.FormChange.MatrixSizeComboBox.Text = Matrix.MatrixA.MatrixValue.GetLength(0).ToString();

                Matrix.CreateTextBoxes(FormName: "Change", matrix: Matrix.MatrixA.MatrixValue);
            }
            else if (Matrix.IsMatrixAEmpty && !Matrix.IsMatrixBEmpty)
            {
                Matrix.FormChange.MatrixNameComboBox.Text = Matrix.MatrixB.Name;
                Matrix.FormChange.MatrixNameComboBox.Items.Add(Matrix.MatrixB.Name);
                Matrix.MatrixSizeComboBox_ClearItems();
                Matrix.FormChange.MatrixSizeComboBox.Text = Matrix.MatrixB.MatrixValue.GetLength(0).ToString();
                Matrix.FormChange.MatrixSizeComboBox.Items.Add(Matrix.MatrixB.MatrixValue.GetLength(0).ToString());
                Matrix.CreateTextBoxes(FormName: "Change", matrix: Matrix.MatrixB.MatrixValue);
            }
            else if (!Matrix.IsMatrixAEmpty && !Matrix.IsMatrixBEmpty)
            {
                Matrix.FormChange.MatrixNameComboBox.Text = Matrix.MatrixA.Name;
                Matrix.FormChange.MatrixSizeComboBox.Text = Matrix.MatrixA.MatrixValue.GetLength(0).ToString();
                Matrix.FormChange.MatrixNameComboBox.Items.Add(Matrix.MatrixA.Name);
                Matrix.FormChange.MatrixNameComboBox.Items.Add(Matrix.MatrixB.Name);
                Matrix.FormChange.MatrixSizeComboBox.Items.Add(Matrix.MatrixA.MatrixValue.GetLength(0).ToString());
                Matrix.CreateTextBoxes(FormName: "Change", matrix: Matrix.MatrixA.MatrixValue);
            }
        }

        private static void loadTextBoxes()
        {
        }

        private static void OnLoad()
        {
            onLoadDefaultParametrs();
            loadTextBoxes();
        }

        public void MatrixTextBoxes_TextChanged(object sender, EventArgs e)
        {
            Matrix.ResizeTextBoxes();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (Matrix.textBoxes == null)
            {
                ShowForm.PerformOperation("Main");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("При выходе из этого окно ваше действия не сохраняется!!\n\nХотите ли вы продолжать?", "Matrix", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ShowForm.PerformOperation("Main");
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Matrix.ChangeValues();
        }

        private void MatrixNameComboBox_TextChanged(object sender, EventArgs e)
        {
            if (MatrixNameComboBox.Text != "")
            {
                MatrixName = MatrixNameComboBox.Text;
                lblTextOfCBNameOFMatrix.BackColor = Color.Transparent;
            }
            else
            {
                MatrixName = "";
                lblTextOfCBNameOFMatrix.BackColor = Color.Red;
            }
        }

        private void Change_Load(object sender, EventArgs e)
        {
            Matrix.FormChange = this;
            OnLoad();
        }

        private void ClearMatrixValuesButton_Click(object sender, EventArgs e)
        {
            Matrix.ClearTextBoxes(ClearMatrixName: false, FormName: "Change");
        }

        private void FillAutoButton_Click(object sender, EventArgs e)
        {
            if (MatrixSizeComboBox.Text == string.Empty || MatrixSizeComboBox.Text == "0")
            {
                Matrix.MatrixSizeComboBox_ChangeColor();
            }
            else
            {
                Matrix.FillTextBoxes();
                if (MatrixSizeComboBox.BackColor == Color.Red)
                {
                    Matrix.MatrixSizeComboBox_DefaultColor();
                }
            }
        }

        private void MatrixNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Matrix.MatrixA.Name == MatrixNameComboBox.Text)
            {
                Matrix.CreateTextBoxes(FormName: "Change", matrix: Matrix.MatrixA.MatrixValue);
            }
            else if (Matrix.MatrixB.Name == MatrixNameComboBox.Text)
            {
                Matrix.CreateTextBoxes(FormName: "Change", matrix: Matrix.MatrixB.MatrixValue);
            }
        }
    }
}