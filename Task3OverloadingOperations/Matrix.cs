using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3OverloadingOperations
{
    public class Matrix : SquareMatrix
    {
        #region Fields

        public static string[] ResultText { get; set; }

        public static Matrix MatrixA;

        public static Matrix MatrixB;

        public static bool IsMatrixAEmpty
        {
            get
            {
                if (MatrixA.MatrixValue == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool IsMatrixBEmpty
        {
            get
            {
                if (MatrixB.MatrixValue == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static MatrixForm.Add FormAdd { get; set; }
        public static MatrixForm.Main FormMain { get; set; }
        public static MatrixForm.Change FormChange { get; set; }
        public static PictureBox BrecketOpenPicture;
        public static PictureBox BrecketClosePicture;

        public static Label LblMatrixName { get; set; }

        public static int MatrixSize
        {
            get { return SquareMatrix.Size; }
            set
            {
                if (value < 0)
                {
                    SquareMatrix.Size = 0;
                }
                else
                {
                    SquareMatrix.Size = value;
                }
            }
        }

        public static TextBox[,] textBoxes;

        #endregion Fields

        #region constructors

        public Matrix()
        { }

        public Matrix(int MatrixSize)
        {
            Matrix.MatrixSize = MatrixSize;
        }

        #endregion constructors

        public static void CreateTextBoxes(string FormName = "Add", int[,] matrix = null)
        {
            try
            {
                textBoxes = new TextBox[MatrixSize, MatrixSize];
                if (FormName == "Add")
                {
                    FormAdd.PanelMatrixValue.Controls.Clear();
                }
                else if (FormName == "Change")
                {
                    FormChange.PanelMatrixValue.Controls.Clear();
                }
                Matrix.LblMatrixName.Visible = true;
                Matrix.BrecketClosePicture.Visible = true;
                Matrix.BrecketOpenPicture.Visible = true;

                LblMatrixName.Location = new Point(0, 0);
                var brecketOpenLocation = new Point()
                {
                    X = LblMatrixName.Location.X + LblMatrixName.Size.Width,
                    Y = 0
                };

                var TextBoxPoint = new Point()
                {
                    X = brecketOpenLocation.X + 22,
                    Y = 3
                };

                Point brecketCloseLocation = new Point(0, 0);

                Size brecketSize = new Size(20, 0);

                if (FormName == "Add" && FormAdd.MatrixSizeComboBox.Text != ""
                    || FormName == "Change" && FormChange.MatrixSizeComboBox.Text != "")
                {
                    for (int i = 0; i < MatrixSize; ++i)
                    {
                        for (int j = 0; j < MatrixSize; ++j)
                        {
                            textBoxes[i, j] = new TextBox()
                            {
                                Location = new System.Drawing.Point(TextBoxPoint.X, TextBoxPoint.Y),
                                Size = new System.Drawing.Size(20, 20)
                            };

                            if (FormName == "Add")
                            {
                                textBoxes[i, j].TextChanged += new System.EventHandler(FormAdd.MatrixTextBoxes_TextChanged);
                                FormAdd.PanelMatrixValue.Controls.Add(textBoxes[i, j]);
                            }
                            else if (FormName == "Change")
                            {
                                textBoxes[i, j].Text = matrix[i, j].ToString();
                                textBoxes[i, j].TextChanged += new System.EventHandler(FormAdd.MatrixTextBoxes_TextChanged);
                                FormChange.PanelMatrixValue.Controls.Add(textBoxes[i, j]);
                            }

                            TextBoxPoint.X += 25;
                        }

                        brecketCloseLocation.X = TextBoxPoint.X - 2;
                        TextBoxPoint.X = brecketOpenLocation.X + 22;
                        TextBoxPoint.Y += 25;
                    }
                    brecketSize.Height += TextBoxPoint.Y;

                    BrecketOpenPicture.Size = brecketSize;
                    BrecketClosePicture.Size = brecketSize;
                    LblMatrixName.Location = new Point(0, brecketSize.Height / 2 - LblMatrixName.Size.Height / 2);

                    BrecketClosePicture.Location = brecketCloseLocation;
                    BrecketOpenPicture.Location = brecketOpenLocation;
                    if (FormName == "Add")
                    {
                        LblMatrixName.Text = FormAdd.MatrixNameComboBox.Text + "=";
                        FormAdd.PanelMatrixValue.Controls.Add(BrecketOpenPicture);
                        FormAdd.PanelMatrixValue.Controls.Add(BrecketClosePicture);
                        FormAdd.PanelMatrixValue.Controls.Add(LblMatrixName);
                    }
                    else if (FormName == "Change")
                    {
                        LblMatrixName.Text = FormChange.MatrixNameComboBox.Text + "=";
                        FormChange.PanelMatrixValue.Controls.Add(BrecketOpenPicture);
                        FormChange.PanelMatrixValue.Controls.Add(BrecketClosePicture);
                        FormChange.PanelMatrixValue.Controls.Add(LblMatrixName);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Программа вернул ощибку", "Квадратная матрица", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                FormAdd.MatrixSizeComboBox.Text = "0";
            }
        }

        public static void ClearMatrixResultPanel(string FormName = "Add")
        {
            if (FormName == "Add")
                FormAdd.PanelMatrixValue.Controls.Clear();
            else if (FormName == "Change")
                FormChange.PanelMatrixValue.Controls.Clear();
        }

        public static void ClearTextBoxes(bool ClearMatrixName = true, string FormName = "Add")
        {
            if (ClearMatrixName)
            {
                CreateTextBoxes();

                LblMatrixName.Text = "";
                MatrixSize = 0;

                if (FormName == "Add")
                {
                    MatrixForm.Add.OnLoadDefaultParametrs();
                    ClearMatrixResultPanel();
                }
                else if (FormName == "Change")
                {
                    MatrixForm.Change.onLoadDefaultParametrs();
                    ClearMatrixResultPanel("Change");
                }
            }
            else
            {
                if (textBoxes != null)
                {
                    foreach (TextBox textBox in textBoxes)
                    {
                        textBox.Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// Изменит фоновый цвет MatrixSizeComboBox при отличие размеры матрицы
        /// </summary>
        public static void MatrixSizeComboBox_ChangeColor()
        {
            FormAdd.MatrixSizeComboBox.BackColor = Color.Red;
            FormAdd.MatrixSizeComboBox.ForeColor = Color.White;
        }

        /// <summary>
        /// Востановить цвет MatrixSizeComboBox по умолчанию
        /// </summary>

        public static void MatrixSizeComboBox_DefaultColor()
        {
            FormAdd.MatrixSizeComboBox.BackColor = Color.White;
            FormAdd.MatrixSizeComboBox.ForeColor = Color.Black;
        }

        /// <summary>
        /// Убрать все элементы MatrixSizeComboBox
        /// </summary>

        public static void MatrixSizeComboBox_ClearItems()
        {
            FormAdd.MatrixSizeComboBox.Items.Clear();
        }

        /// <summary>
        /// Добавить значение текстового поля в MatrixA и MatrixB
        /// </summary>
        public static void AddingValues()
        {
            if (!IsMatrixAEmpty && IsMatrixBEmpty)
            {
                if (Matrix.MatrixA.MatrixValue.GetLength(0) == Matrix.MatrixSize)
                {
                    onEqualSizes();
                }
                else if (Matrix.MatrixA.MatrixValue.GetLength(0) != Matrix.MatrixSize)
                {
                    onDifferentSizes();
                }
            }
            else if (IsMatrixAEmpty && !IsMatrixBEmpty)
            {
                if (Matrix.MatrixB.MatrixValue.GetLength(0) == Matrix.MatrixSize)
                {
                    onEqualSizes();
                }
                else if (Matrix.MatrixB.MatrixValue.GetLength(0) != Matrix.MatrixSize)
                {
                    onDifferentSizes();
                }
            }
            else if (!IsMatrixAEmpty && !IsMatrixBEmpty)
            {
                ResultText = null;
                onEqualSizes();
            }
            else if (IsMatrixAEmpty && IsMatrixBEmpty)
            {
                onEqualSizes();
            }

            //когда размер матрицы равен
            void onEqualSizes()
            {
                Matrix.FillMatrixValues();
            }
            //когда размер матрицы отличается
            void onDifferentSizes()
            {
                MessageBox.Show("Размеры матрицы в квадратной матрице не могут отличаться", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        public static void ChangeValues(string MatrixName = "A")
        {
            if (Matrix.MatrixA.Name == MatrixName)
            {
                FillMatrix.Fill(ref MatrixA);
            }
            else if (Matrix.MatrixB.Name == MatrixName)
            {
                FillMatrix.Fill(ref MatrixB);
            }
        }

        /// <summary>

        /// Добавить значение текстового поля в MatrixA и MatrixB
        /// </summary>
        private static void FillMatrixValues()
        {
            if (Matrix.IsMatrixAEmpty)
            {
                FillMatrix.Fill(ref MatrixA);
                MatrixA.Name = MatrixForm.Add.MatrixName;
            }
            else if (Matrix.IsMatrixBEmpty)
            {
                FillMatrix.Fill(ref MatrixB);
                MatrixB.Name = MatrixForm.Add.MatrixName;
            }
            else if (!Matrix.IsMatrixAEmpty && !Matrix.IsMatrixBEmpty)
            {
                MatrixA.MatrixValue = null;
                MatrixB.MatrixValue = null;
                FillMatrixValues();
            }
        }

        /// <summary>
        /// Заполнить значения текстовых полей
        /// </summary>
        public static void FillTextBoxes()
        {
            FillMatrix.FillTextBoxesAuto();
        }

        /// <summary>
        /// Показать значение матрицы в главной страницы программа
        /// </summary>

        private static bool IsNeedToRezise(int Row)
        {
            for (int i = 0; i < MatrixSize; ++i)
            {
                if (textBoxes[i, Row].Text.Length > 1)
                {
                    return true;
                }
            }
            return false;
        }

        public static int MaxLenghtofColumn(int Row)
        {
            int max = Convert.ToInt32(textBoxes[0, Row].Text.Length);
            for (int i = 0; i < MatrixSize; ++i)
            {
                if (Convert.ToInt32(textBoxes[i, Row].Text.Length) > max)
                {
                    max = Convert.ToInt32(textBoxes[i, Row].Text.Length);
                }
            }
            return max;
        }

        private static void ChangeTextBoxColumnSize(Dictionary<int, int> ParametrsForResizing)
        {
            Point TextBoxPoint = new Point(LblMatrixName.Location.X + LblMatrixName.Size.Width + 22, 3);

            Size textBoxSize = new Size();

            for (int i = 0; i < MatrixSize; ++i)
            {
                for (int j = 0; j < MatrixSize; ++j)
                {
                    if (ParametrsForResizing.ContainsKey(j))
                    {
                        textBoxSize.Width = 12 + 6 * ParametrsForResizing[j];
                        textBoxSize.Height = 20;
                        textBoxes[i, j].Location = new System.Drawing.Point(TextBoxPoint.X, TextBoxPoint.Y);
                        textBoxes[i, j].Size = textBoxSize;
                        TextBoxPoint.X += 12 + 6 * ParametrsForResizing[j] + 5;
                    }
                    else
                    {
                        textBoxes[i, j].Location = new System.Drawing.Point(TextBoxPoint.X, TextBoxPoint.Y);
                        textBoxes[i, j].Size = new System.Drawing.Size(20, 20);
                        TextBoxPoint.X += 25;
                    }
                }

                BrecketClosePicture.Location = new Point(TextBoxPoint.X, 0);
                TextBoxPoint.X = LblMatrixName.Location.X + LblMatrixName.Size.Width + 22;
                TextBoxPoint.Y += 25;
            }
        }

        public static void ResizeTextBoxes()

        {
            Dictionary<int, int> DictForResizing = new Dictionary<int, int>();

            for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
            {
                if (IsNeedToRezise(RowIndex))
                {
                    DictForResizing.Add(RowIndex, MaxLenghtofColumn(RowIndex));
                }
            }

            ChangeTextBoxColumnSize(DictForResizing);
        }
    }
}