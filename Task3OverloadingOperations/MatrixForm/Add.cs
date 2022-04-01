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
        public Add()
        {
            InitializeComponent();
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "A")
            {
                lblMatrixName.Text = "A=";
                comboBox1.BackColor = default;
                comboBox1.ForeColor = default;
            }
            else if (comboBox1.Text == "B")
            {
                lblMatrixName.Text = "B=";
            }
            else
            {
                lblMatrixName.Text = "";
                comboBox1.BackColor = Color.Red;
                comboBox1.ForeColor = Color.White;
            }
        }

        private void CreateTextBox(Point point)
        {
        }
        //TODO надо создать отдельный клас для обработки и создание матрицы
        private void MatrixSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            PanelMatrixValue.Controls.Clear();
            if (MatrixSizeTextBox.Text != "")
            {
                Point point = new Point();
                point.X = 3;
                point.Y = 3;
                /*try
                {*/
                for (int i = 0; i < Convert.ToInt32(MatrixSizeTextBox.Text); ++i)
                {
                    for (int j = 0; j < Convert.ToInt32(MatrixSizeTextBox.Text); ++j)
                    {
                        TextBox text = new TextBox();

                        text.Name = "el" + point.X.ToString();
                        text.Location = new System.Drawing.Point(point.X, point.Y);
                        text.Size = new System.Drawing.Size(20, 20);
                        PanelMatrixValue.Controls.Add(text);
                        point.X += 25;
                    }
                    point.X = 3;
                    point.Y += 25;
                }
                /*}
                catch
                {
                    throw new Exception("Error convert");
                }*/
            }
        }
    }
}