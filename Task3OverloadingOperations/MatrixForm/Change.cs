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

        public Change()
        {
            InitializeComponent();
        }

        public static void onLoadDefaultParametrs()
        {
            if (!Matrix.isMatrixAEmpty && Matrix.isMatrixBEmpty)
            {
                Matrix.FormAdd.MatrixNameComboBox.Items.Clear();
                Matrix.FormAdd.MatrixNameComboBox.Text = Matrix.MatrixA.Name;

                Matrix.MatrixSizeComboBox_ClearItems();

                Matrix.FormAdd.MatrixSizeComboBox.Text = Matrix.MatrixA.MatrixValue.GetLength(0).ToString();
            }
            else if (Matrix.isMatrixAEmpty && !Matrix.isMatrixBEmpty)
            {
                Matrix.FormAdd.MatrixNameComboBox.Text = Matrix.MatrixA.Name;
                if (Matrix.MatrixB.Name == "B")
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "A";
                }
                else
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "B";
                }

                Matrix.MatrixSizeComboBox_ClearItems();
                Matrix.FormAdd.MatrixSizeComboBox.Text = Matrix.MatrixB.MatrixValue.GetLength(0).ToString();
            }
            else if (Matrix.isMatrixAEmpty && Matrix.isMatrixBEmpty
              || !Matrix.isMatrixAEmpty && !Matrix.isMatrixBEmpty)
            {
                Matrix.FormAdd.MatrixNameComboBox.Text = "A";
                Matrix.FormAdd.MatrixSizeComboBox.Text = string.Empty;
            }
        }

        private static void OnLoad()
        {
            onLoadDefaultParametrs();
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
            MatrixSizeComboBox_TextChanged(sender, e);
        }

        private void Change_Load(object sender, EventArgs e)
        {
            Matrix.FormChange = this;
            OnLoad();
        }
    }
}