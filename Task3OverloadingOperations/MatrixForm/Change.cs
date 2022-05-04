using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task3OverloadingOperations.MatrixForm
{
    public partial class Change : Form
    {
        public static string MatrixName { get; set; }

        public static bool IsFirstMatrixValue { get; set; }

        public Change()
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

        public static void OnLoadDefaultParametrs()
        {
            SquareMatrix.FormChange.MatrixNameComboBox.Items.Clear();
            SquareMatrix.FormChange.MatrixSizeComboBox.Items.Clear();
            if (!SquareMatrix.IsMatrixAEmpty && SquareMatrix.IsMatrixBEmpty)
            {
                SquareMatrix.FormChange.MatrixNameComboBox.Text = SquareMatrix.MatrixA.Name;
                SquareMatrix.FormChange.MatrixNameComboBox.Items.Add(SquareMatrix.MatrixA.Name);
                SquareMatrix.MatrixSizeComboBox_ClearItems();
                SquareMatrix.FormChange.MatrixSizeComboBox.Text = SquareMatrix.MatrixA.MatrixValue.GetLength(0).ToString();
                SquareMatrix.MatrixSize = SquareMatrix.MatrixA.MatrixValue.GetLength(0);
                SquareMatrix.CreateTextBoxes(FormName: "Change", matrix: SquareMatrix.MatrixA.MatrixValue);
            }
            else if (SquareMatrix.IsMatrixAEmpty && !SquareMatrix.IsMatrixBEmpty)
            {
                SquareMatrix.FormChange.MatrixNameComboBox.Text = SquareMatrix.MatrixB.Name;
                SquareMatrix.FormChange.MatrixNameComboBox.Items.Add(SquareMatrix.MatrixB.Name);
                SquareMatrix.MatrixSizeComboBox_ClearItems();
                SquareMatrix.FormChange.MatrixSizeComboBox.Text = SquareMatrix.MatrixB.MatrixValue.GetLength(0).ToString();
                SquareMatrix.FormChange.MatrixSizeComboBox.Items.Add(SquareMatrix.MatrixB.MatrixValue.GetLength(0).ToString());
                SquareMatrix.MatrixSize = SquareMatrix.MatrixB.MatrixValue.GetLength(0);
                SquareMatrix.CreateTextBoxes(FormName: "Change", matrix: SquareMatrix.MatrixB.MatrixValue);
            }
            else if (!SquareMatrix.IsMatrixAEmpty && !SquareMatrix.IsMatrixBEmpty)
            {
                SquareMatrix.FormChange.MatrixNameComboBox.Text = SquareMatrix.MatrixA.Name;
                SquareMatrix.FormChange.MatrixSizeComboBox.Text = SquareMatrix.MatrixA.MatrixValue.GetLength(0).ToString();
                SquareMatrix.FormChange.MatrixNameComboBox.Items.Add(SquareMatrix.MatrixA.Name);
                SquareMatrix.FormChange.MatrixNameComboBox.Items.Add(SquareMatrix.MatrixB.Name);
                SquareMatrix.FormChange.MatrixSizeComboBox.Items.Add(SquareMatrix.MatrixA.MatrixValue.GetLength(0).ToString());
                SquareMatrix.MatrixSize = SquareMatrix.MatrixA.MatrixValue.GetLength(0);
                SquareMatrix.CreateTextBoxes(FormName: "Change", matrix: SquareMatrix.MatrixA.MatrixValue);
            }
            else
            {
                SquareMatrix.FormChange.PanelMatrixValue.Controls.Clear();
            }
        }

        private static void OnLoad()
        {
            OnLoadDefaultParametrs();
        }

        public void MatrixTextBoxes_TextChanged(object sender, EventArgs e)
        {
            SquareMatrix.ResizeTextBoxes();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (SquareMatrix.textBoxes == null)
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
            SquareMatrix.ChangeValues(MatrixNameComboBox.Text);
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
            SquareMatrix.FormChange = this;
            OnLoad();
        }

        private void ClearMatrixValuesButton_Click(object sender, EventArgs e)
        {
            SquareMatrix.ClearTextBoxes(ClearMatrixName: false, FormName: "Change");
        }

        private void FillAutoButton_Click(object sender, EventArgs e)
        {
            if (MatrixSizeComboBox.Text == string.Empty || MatrixSizeComboBox.Text == "0")
            {
                SquareMatrix.MatrixSizeComboBox_ChangeColor();
            }
            else
            {
                SquareMatrix.FillTextBoxes();
                if (MatrixSizeComboBox.BackColor == Color.Red)
                {
                    SquareMatrix.MatrixSizeComboBox_DefaultColor();
                }
            }
        }

        private void MatrixNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SquareMatrix.MatrixA.Name == MatrixNameComboBox.Text)
            {
                SquareMatrix.CreateTextBoxes(FormName: "Change", matrix: SquareMatrix.MatrixA.MatrixValue);
            }
            else if (SquareMatrix.MatrixB.Name == MatrixNameComboBox.Text)
            {
                SquareMatrix.CreateTextBoxes(FormName: "Change", matrix: SquareMatrix.MatrixB.MatrixValue);
            }
        }
    }
}