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
            Matrix.FormAdd = this;
            Matrix.MatrixA = new Matrix();
            Matrix.MatrixB = new Matrix();
            OnLoad();
        }

        private static void OnLoad()
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelForms_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ShowForm.PerformOperation("Main");
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

        //TODO надо создать отдельный клас для обработки и создание матрицы
        private void MatrixSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            OnLoad();
            if (MatrixNameComboBox.Text != "")
            {
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
                lblTextOfCBNameOFMatrix.BackColor = Color.Red;
            }
        }

        private void FillAutoButton_Click(object sender, EventArgs e)
        {
            Matrix.FillTextBoxes();
            OnLoad();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Matrix.FillMatrixValues();
            Matrix.ShowOnResultRechtextBox();
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
    }
}