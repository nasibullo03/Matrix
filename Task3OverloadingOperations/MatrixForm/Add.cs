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
        public static string MatrixName { get; set; }

        public Add()
        {
            InitializeComponent();
        }

        private static void PanelValuesElementsParametrs()
        {
            Matrix.BrecketOpenPicture = new PictureBox();
            Matrix.BrecketOpenPicture.BackgroundImage = global::Task3OverloadingOperations.Properties.Resources.bracket_Open;
            Matrix.BrecketOpenPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Matrix.BrecketOpenPicture.Size = new System.Drawing.Size(20, 68);

            Matrix.BrecketClosePicture = new PictureBox();
            Matrix.BrecketClosePicture.BackgroundImage = global::Task3OverloadingOperations.Properties.Resources.bracket_Close;
            Matrix.BrecketClosePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Matrix.BrecketClosePicture.Size = new System.Drawing.Size(20, 68);

            Matrix.LblMatrixName = new Label();
            Matrix.LblMatrixName.AutoSize = true;
            Matrix.LblMatrixName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Matrix.LblMatrixName.ForeColor = System.Drawing.Color.Black;
            Matrix.LblMatrixName.Size = new System.Drawing.Size(42, 29);
            Matrix.LblMatrixName.Location = new Point(3, 3);
            Matrix.LblMatrixName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        public static void onLoadDefaultParametrs()
        {
            if (!Matrix.isMatrixAEmpty && Matrix.isMatrixBEmpty)
            {
                if (Matrix.MatrixAName == "A")
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "B";
                }
                else
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "A";
                }

                Matrix.FormAdd.MatrixSizeComboBox.Text = Matrix.MatrixA.MatrixValue.GetLength(0).ToString();
            }
            else if (Matrix.isMatrixAEmpty && !Matrix.isMatrixBEmpty)
            {
                Matrix.FormAdd.MatrixNameComboBox.Text = Matrix.MatrixAName;
                if (Matrix.MatrixBName == "B")
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "A";
                }
                else
                {
                    Matrix.FormAdd.MatrixNameComboBox.Text = "B";
                }
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
            PanelValuesElementsParametrs();

            onLoadDefaultParametrs();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelForms_Paint(object sender, PaintEventArgs e)
        {
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

        private void MatrixSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (MatrixNameComboBox.Text != string.Empty)
            {
                if (MatrixSizeComboBox.BackColor == Color.Red)
                {
                    Matrix.MatrixSizeComboBox_DefaultColor();
                }

                lblTextOfCBNameOFMatrix.BackColor = Color.Transparent;
                if (MatrixSizeComboBox.Text != "" && MatrixSizeComboBox.Text != "1")
                {
                    lblSizeOfMatrixName.BackColor = Color.Transparent;

                    try
                    {
                        Matrix.MatrixSize = Convert.ToInt32(MatrixSizeComboBox.Text) > 0 ? Convert.ToInt32(MatrixSizeComboBox.Text) : 0;
                    }
                    catch
                    {
                        MatrixSizeComboBox.Text = "1";
                        Matrix.MatrixSize = 1;
                    }
                    finally
                    {
                        Matrix.CreateTextBoxes();
                    }
                }
                else if (MatrixSizeComboBox.Text == "1")
                {
                    lblSizeOfMatrixName.BackColor = Color.Red;
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ///*****TODO********///
            // надо доработать кноки BackButton чтобы при выход из форма Add отслеживал что матрица заполнена и добавлена в главную форму
            // в обратном случае надо сообщить что пользователь действительно хочет ли выйти из режим добавление матрицы
            // надо убрать RichTextBox из главной формы и вместо его создать метод который показывает значение матрицы
            // с помощью label в главной матрицы p.s просто надо скопировать значение textboxes и добавить в новий метод
            // надо еще подумать в дольнейшие обновление программы

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
    }
}