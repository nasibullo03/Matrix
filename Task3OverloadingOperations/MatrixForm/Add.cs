using System;
using System.Drawing;
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

        /// <summary>
        /// Параметры по умолчанию при открытии формы
        /// </summary>
        public static void OnLoadDefaultParametrs()
        {
            //Если заполнена только Первая матрица
            if (!SquareMatrix.IsMatrixAEmpty && SquareMatrix.IsMatrixBEmpty)
            {
                if (SquareMatrix.MatrixA.Name == "A")
                {
                    SquareMatrix.FormAdd.MatrixNameComboBox.Text = "B";
                }
                else
                {
                    SquareMatrix.FormAdd.MatrixNameComboBox.Text = "A";
                }
                SquareMatrix.MatrixSizeComboBox_ClearItems();

                SquareMatrix.FormAdd.MatrixSizeComboBox.Text = SquareMatrix.MatrixA.MatrixValue.GetLength(0).ToString();
                SquareMatrix.FormAdd.MatrixSizeComboBox.Enabled = false;
            }
            else if (SquareMatrix.IsMatrixAEmpty && !SquareMatrix.IsMatrixBEmpty) // если заполнена только значение второй матрицы
            {
                SquareMatrix.FormAdd.MatrixNameComboBox.Text = SquareMatrix.MatrixA.Name;
                if (SquareMatrix.MatrixB.Name == "B")
                {
                    SquareMatrix.FormAdd.MatrixNameComboBox.Text = "A";
                }
                else
                {
                    SquareMatrix.FormAdd.MatrixNameComboBox.Text = "B";
                }
                SquareMatrix.MatrixSizeComboBox_ClearItems();
                SquareMatrix.FormAdd.MatrixSizeComboBox.Text = SquareMatrix.MatrixB.MatrixValue.GetLength(0).ToString();
            } // если оба матрицы заполнена/не заполнена
            else if (SquareMatrix.IsMatrixAEmpty && SquareMatrix.IsMatrixBEmpty
              || !SquareMatrix.IsMatrixAEmpty && !SquareMatrix.IsMatrixBEmpty)
            {
                SquareMatrix.FormAdd.MatrixNameComboBox.Text = "A";
                SquareMatrix.FormAdd.MatrixSizeComboBox.Text = string.Empty;
                SquareMatrix.FormAdd.MatrixSizeComboBox.Enabled = true;
            }
        }

        /// <summary>
        /// При загрузки формы
        /// </summary>
        private static void OnLoad()
        {
            OnLoadDefaultParametrs();
        }

        /// <summary>
        /// Кнопка назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (SquareMatrix.textBoxes == null)
            {
                SquareMatrix.ClearTextBoxes();
                ShowForm.PerformOperation("Main");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("При выходе из этого окно ваше действия не сохраняется!!\n\nХотите ли вы продолжать?", "Matrix", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SquareMatrix.ClearTextBoxes();
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
            int MatrixSizeInTextBoxes;
            try
            {
                MatrixSizeInTextBoxes = Convert.ToInt32(MatrixSizeComboBox.Text);
            }
            catch
            {
                MatrixSizeInTextBoxes = 0;
            }

            if (MatrixNameComboBox.Text != string.Empty && MatrixSizeInTextBoxes < 40)
            {
                if (MatrixSizeComboBox.BackColor == Color.Red)
                {
                    SquareMatrix.MatrixSizeComboBox_DefaultColor();
                }

                lblTextOfCBNameOFMatrix.BackColor = Color.Transparent;
                if (MatrixSizeComboBox.Text != "" && MatrixSizeComboBox.Text != "1" && MatrixSizeComboBox.Text != "0")
                {
                    lblSizeOfMatrixName.BackColor = Color.Transparent;

                    try
                    {
                        SquareMatrix.MatrixSize = Convert.ToInt32(MatrixSizeComboBox.Text) > 1 ? Convert.ToInt32(MatrixSizeComboBox.Text) : 0;
                    }
                    catch
                    {
                        MatrixSizeComboBox.Text = "2";
                        SquareMatrix.MatrixSize = 2;
                    }
                    finally
                    {
                        SquareMatrix.CreateTextBoxes();
                    }
                }
                else if (MatrixSizeComboBox.Text == "1" || MatrixSizeComboBox.Text == "0")
                {
                    SquareMatrix.MatrixSizeComboBox_ChangeColor();
                    SquareMatrix.MatrixSize = 0;
                    SquareMatrix.CreateTextBoxes();
                    SquareMatrix.LblMatrixName.Visible = false;
                    SquareMatrix.BrecketClosePicture.Visible = false;
                    SquareMatrix.BrecketOpenPicture.Visible = false;
                }
                else
                {
                    SquareMatrix.ClearTextBoxes(ClearMatrixName: false);
                }
            }
            else
            {
                SquareMatrix.MatrixSizeComboBox_ChangeColor();
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

        /// <summary>
        /// Заполняет значение матрицы в перменах чтобы из
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SquareMatrix.AddingValues();
            ShowForm.PerformOperation("Main");
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            SquareMatrix.ClearTextBoxes();
        }

        public void MatrixTextBoxes_TextChanged(object sender, EventArgs e)
        {
            SquareMatrix.ResizeTextBoxes();
        }

        private void PanelMatrixValue_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ClearMatrixValuesButton_Click(object sender, EventArgs e)
        {
            SquareMatrix.ClearTextBoxes(false);
        }

        private void Add_Load(object sender, EventArgs e)
        {
            SquareMatrix.FormAdd = this;
            OnLoad();
        }

        #endregion Metods
    }
}