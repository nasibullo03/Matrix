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
    public partial class Add : Form
    {
        #region Fields

        /// <summary>
        /// Хранит значение имя матрицы
        /// </summary>
        public static string MatrixName { get; set; }

        #endregion Fields

        #region Сonstructor

        public Add()
        {
            InitializeComponent();
        }

        #endregion Сonstructor

        #region Metods

        /// <summary>
        /// Параметры по умолчанию при открытии формы
        /// </summary>
        public static void onLoadDefaultParametrs()
        {
            //Если заполнена только Первая матрица
            if (!Matrix.isMatrixAEmpty && Matrix.isMatrixBEmpty)
            {
                if (Matrix.MatrixA.Name == "A")
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "B";
                }
                else
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "A";
                }
                Matrix.MatrixSizeComboBox_ClearItems();

                Matrix.FormAdd.MatrixSizeComboBox.Text = Matrix.MatrixA.MatrixValue.GetLength(0).ToString();
                Matrix.FormAdd.MatrixSizeComboBox.Enabled = false;
            }
            else if (Matrix.isMatrixAEmpty && !Matrix.isMatrixBEmpty) // если заполнена только значение второй матрицы
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
            } // если оба матрицы заполнена/не заполнена
            else if (Matrix.isMatrixAEmpty && Matrix.isMatrixBEmpty
              || !Matrix.isMatrixAEmpty && !Matrix.isMatrixBEmpty)
            {
                Matrix.FormAdd.MatrixNameComboBox.Text = "A";
                Matrix.FormAdd.MatrixSizeComboBox.Text = string.Empty;
                Matrix.FormAdd.MatrixSizeComboBox.Enabled = true;
            }
        }

        /// <summary>
        /// При загрузки формы
        /// </summary>
        private static void OnLoad()
        {
            onLoadDefaultParametrs();
        }

        /// <summary>
        /// Кнопка назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Поля со списком имя матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Поля со списки размеры матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatrixSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (MatrixNameComboBox.Text != string.Empty)
            {
                if (MatrixSizeComboBox.BackColor == Color.Red)
                {
                    Matrix.MatrixSizeComboBox_DefaultColor();
                }

                lblTextOfCBNameOFMatrix.BackColor = Color.Transparent;
                if (MatrixSizeComboBox.Text != "" && MatrixSizeComboBox.Text != "1" && MatrixSizeComboBox.Text != "0")
                {
                    lblSizeOfMatrixName.BackColor = Color.Transparent;

                    try
                    {
                        Matrix.MatrixSize = Convert.ToInt32(MatrixSizeComboBox.Text) > 1 ? Convert.ToInt32(MatrixSizeComboBox.Text) : 0;
                    }
                    catch
                    {
                        MatrixSizeComboBox.Text = "2";
                        Matrix.MatrixSize = 2;
                    }
                    finally
                    {
                        Matrix.CreateTextBoxes();
                    }
                }
                else if (MatrixSizeComboBox.Text == "1" || MatrixSizeComboBox.Text == "0")
                {
                    Matrix.MatrixSizeComboBox_ChangeColor();
                    Matrix.MatrixSize = 0;
                    Matrix.CreateTextBoxes();
                    Matrix.LblMatrixName.Visible = false;
                    Matrix.BrecketClosePicture.Visible = false;
                    Matrix.BrecketOpenPicture.Visible = false;
                }
                else
                {
                    Matrix.ClearTextBoxes(ClearMatrixName: false);
                }
            }
            else
            {
                Matrix.MatrixSizeComboBox_ChangeColor();
            }
        }

        /// <summary>
        /// Автоматически заполняет текстовые поля матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FillAutoButton_Click(object sender, EventArgs e)
        {
            if (MatrixSizeComboBox.Text == string.Empty)
            {
                MatrixSizeComboBox.Text = new Random().Next(2, 10).ToString();
            }
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

        /// <summary>
        /// Заполняет значение матрицы в перменах чтобы из
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Matrix.AddingValues();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Matrix.ClearTextBoxes();
        }

        public void MatrixTextBoxes_TextChanged(object sender, EventArgs e)
        {
            Matrix.ResizeTextBoxes();
        }

        private void PanelMatrixValue_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ClearMatrixValuesButton_Click(object sender, EventArgs e)
        {
            Matrix.ClearTextBoxes(false);
        }

        private void Add_Load(object sender, EventArgs e)
        {
            Matrix.FormAdd = this;
            OnLoad();
        }

        #endregion Metods
    }
}