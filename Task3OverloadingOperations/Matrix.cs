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
    internal class Matrix : SquareMatrix
    {
        #region Fields

        public static string MatrixAName { get; set; }
        public static string MatrixBName { get; set; }

        //public static string[] ResultText { get; set; }
        public static string[] ResultText { get; set; }

        public static Matrix MatrixA;
        public static Matrix MatrixB;
        public static MatrixForm.Add FormAdd { get; set; }
        public static MatrixForm.Main FormMain { get; set; }
        public static MatrixForm.Change FormChane { get; set; }
        public static PictureBox BrecketOpenPicture { get; set; }
        public static PictureBox BrecketClosePicture { get; set; }

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

        public static void CreateTextBoxes()
        {
            textBoxes = new TextBox[MatrixSize, MatrixSize];

            FormAdd.PanelMatrixValue.Controls.Clear();

            Matrix.LblMatrixName.Visible = true;
            Matrix.BrecketClosePicture.Visible = true;
            Matrix.BrecketOpenPicture.Visible = true;

            LblMatrixName.Location = new Point(0, 0);
            Point brecketOpenLocation = new Point(0, 0);
            brecketOpenLocation.X = LblMatrixName.Location.X + LblMatrixName.Size.Width;
            LblMatrixName.Text = FormAdd.MatrixNameComboBox.Text + "=";
            Point TextBoxPoint = new Point(0, 3);
            TextBoxPoint.X = brecketOpenLocation.X + 22;

            Point brecketCloseLocation = new Point(0, 0);

            Size brecketSize = new Size(20, 0);

            if (FormAdd.MatrixSizeComboBox.Text != "")
            {
                for (int i = 0; i < MatrixSize; ++i)
                {
                    for (int j = 0; j < MatrixSize; ++j)
                    {
                        textBoxes[i, j] = new TextBox();
                        textBoxes[i, j].Location = new System.Drawing.Point(TextBoxPoint.X, TextBoxPoint.Y);
                        textBoxes[i, j].Size = new System.Drawing.Size(20, 20);
                        textBoxes[i, j].TextChanged += new System.EventHandler(FormAdd.MatrixTextBoxes_TextChanged);
                        FormAdd.PanelMatrixValue.Controls.Add(textBoxes[i, j]);
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

                FormAdd.PanelMatrixValue.Controls.Add(BrecketOpenPicture);
                FormAdd.PanelMatrixValue.Controls.Add(BrecketClosePicture);
                FormAdd.PanelMatrixValue.Controls.Add(LblMatrixName);
            }
        }

        public static void ClearTextBoxes(bool ClearMatrixName = true)
        {
            MatrixSize = 0;
            CreateTextBoxes();
            FormAdd.MatrixSizeComboBox.Text = "";
            if (ClearMatrixName)
            {
                FormAdd.MatrixNameComboBox.Text = "";
                LblMatrixName.Text = "";
            }
        }

        public static void FillMatrixValues()
        {
            if (MatrixA.MatrixValue == null)
            {
                FillMatrix.Fill(ref MatrixA);
                MatrixAName = MatrixForm.Add.MatrixName;
            }
            else
            {
                FillMatrix.Fill(ref MatrixB);
                MatrixAName = MatrixForm.Add.MatrixName;
            }
        }

        public static void FillTextBoxes()
        {
            FillMatrix.FillTextBoxesAuto();
        }

        public static void ShowOnResultRechtextBox()
        {
            if (MatrixA.MatrixValue == null || MatrixB.MatrixValue == null)
            {
                if (MatrixA.MatrixValue == null)
                {
                    ShowForm.ShowOneMartix(MatrixB, MatrixBName);
                }
                else
                {
                    ShowForm.ShowOneMartix(MatrixA, MatrixAName);
                }
            }
            else
            {
                ShowForm.ShowBothMartixs();
            }
        }

        private static bool isNeedToRezise(int Row)
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

                    //FormAdd.PanelMatrixValue.Controls.Add(textBoxes[i, j]);
                }

                TextBoxPoint.X = LblMatrixName.Location.X + LblMatrixName.Size.Width + 22;
                TextBoxPoint.Y += 25;
            }
        }

        public static void ResizeTextBoxes()

        {
            Dictionary<int, int> DictForResizing = new Dictionary<int, int>();

            for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
            {
                if (isNeedToRezise(RowIndex))
                {
                    DictForResizing.Add(RowIndex, MaxLenghtofColumn(RowIndex));
                }
            }

            ChangeTextBoxColumnSize(DictForResizing);
        }
    }
}