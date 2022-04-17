using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Task3OverloadingOperations
{
    public class ShowMatrix : Matrix
    {
        #region Fields

        //public static Label[,] Matrix_Labels;
        public static Label[,] MatrixA_Labels;

        public static Label[,] MatrixB_Labels;
        public static Label MatrixA_LblName { get; set; }
        public static Label MatrixB_LblName { get; set; }

        private static void OneMatrix(Matrix matrix)
        {
            //int MatrixSize = matrix.MatrixValue.GetLength(0);
            try
            {
                MatrixA_Labels = new Label[MatrixSize, MatrixSize];
                FormMain.PanelResult.Controls.Clear();

                Matrix.BrecketClosePicture.Visible = true;
                Matrix.BrecketOpenPicture.Visible = true;

                Point brecketOpenLocation = new Point(0, 0);
                MatrixA_LblName.Text = matrix.Name;
                MessageBox.Show(MatrixA_LblName.Size.Height.ToString());
                MatrixA_LblName.AutoSize = true;
                MessageBox.Show(MatrixA_LblName.Size.Width.ToString());
                brecketOpenLocation.X = MatrixA_LblName.Location.X + MatrixA_LblName.Size.Width;

                Point brecketCloseLocation = new Point(0, 0);

                Point LabelPoint = new Point(0, 3);
                LabelPoint.X = brecketOpenLocation.X + 22;

                Size brecketSize = new Size(20, 0);

                for (int i = 0; i < MatrixSize; ++i)
                {
                    for (int j = 0; j < MatrixSize; ++j)
                    {
                        MatrixA_Labels[i, j] = new Label();
                        MatrixA_Labels[i, j].Location = new System.Drawing.Point(LabelPoint.X, LabelPoint.Y);
                        MatrixA_Labels[i, j].AutoSize = true;

                        MatrixA_Labels[i, j].Text = matrix.MatrixValue[i, j].ToString();
                        MatrixA_Labels[i, j].TextChanged += new System.EventHandler(FormAdd.MatrixTextBoxes_TextChanged);
                        FormMain.PanelResult.Controls.Add(MatrixA_Labels[i, j]);

                        LabelPoint.X += MatrixA_Labels[i, j].Size.Width + 5;
                    }

                    brecketCloseLocation.X = LabelPoint.X;
                    LabelPoint.X = brecketOpenLocation.X + 22;
                    LabelPoint.Y += 20;
                }

                brecketSize.Height += LabelPoint.Y;

                BrecketOpenPicture.Size = brecketSize;
                BrecketClosePicture.Size = brecketSize;
                MatrixA_LblName.Location = new Point(0, brecketSize.Height / 2 - MatrixA_LblName.Size.Height / 2);

                BrecketClosePicture.Location = brecketCloseLocation;
                BrecketOpenPicture.Location = brecketOpenLocation;

                ResizeLabels(MatrixA_Labels, MatrixA_LblName);

                FormMain.PanelResult.Controls.Add(BrecketOpenPicture);
                FormMain.PanelResult.Controls.Add(BrecketClosePicture);
                FormMain.PanelResult.Controls.Add(LblMatrixName);
            }
            catch
            {
                MessageBox.Show("Программа вернул ощибку", "Квадратная матрица", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                FormAdd.MatrixSizeComboBox.Text = "0";
            }
        }

        private static void BothMatrixs()
        { }

        private static bool isNeedToRezise(int Row, Label[,] labels)
        {
            int minSize = labels[0, Row].Size.Width;
            for (int i = 0; i < MatrixSize; ++i)
            {
                if (labels[i, Row].Size.Width != minSize)
                {
                    return true;
                }
            }
            return false;
        }

        private static int MaxWidthofColumn(int Row)
        {
            int max = Convert.ToInt32(textBoxes[0, Row].Size.Width);
            for (int i = 0; i < MatrixSize; ++i)
            {
                if (Convert.ToInt32(textBoxes[i, Row].Size.Width) > max)
                {
                    max = Convert.ToInt32(textBoxes[i, Row].Size.Width);
                }
            }
            return max;
        }

        public static void ResizeLabels(Label[,] labels, Label LblMatrixName)

        {
            Dictionary<int, int> DictForResizing = new Dictionary<int, int>();

            for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
            {
                if (isNeedToRezise(RowIndex, labels))
                {
                    DictForResizing.Add(RowIndex, MaxWidthofColumn(RowIndex));
                }
            }

            ChangeLabelColumnSize(DictForResizing, labels, LblMatrixName);
        }

        private static void ChangeLabelColumnSize(Dictionary<int, int> ParametrsForResizing, Label[,] labels, Label LblMatrixName)
        {
            Point LabelPoint = new Point(LblMatrixName.Location.X + LblMatrixName.Size.Width + 22, 3);
            MessageBox.Show($"{MatrixA_LblName.Location.X}/n {LblMatrixName.Size.Width}");
            Size LabelSize = new Size();

            for (int i = 0; i < MatrixSize; ++i)
            {
                for (int j = 0; j < MatrixSize; ++j)
                {
                    if (ParametrsForResizing.ContainsKey(j))
                    {
                        LabelSize.Width = ParametrsForResizing[j];
                        LabelSize.Height = 20;
                        labels[i, j].Location = new System.Drawing.Point(LabelPoint.X, LabelPoint.Y);
                        labels[i, j].Size = LabelSize;
                        LabelPoint.X += ParametrsForResizing[j] + 5;
                    }
                    else
                    {
                        labels[i, j].Location = new System.Drawing.Point(LabelPoint.X, LabelPoint.Y);
                        LabelPoint.X += labels[i, j].Size.Width + 5;
                    }
                }

                BrecketClosePicture.Location = new Point(LabelPoint.X, 0);
                LabelPoint.X = LblMatrixName.Location.X + LblMatrixName.Size.Width + 22;
                LabelPoint.Y += 20;
            }
        }

        public static void Show()

        {
            if (!Matrix.isMatrixAEmpty && Matrix.isMatrixBEmpty)
            {
                OneMatrix(MatrixA);
            }
            else if (Matrix.isMatrixAEmpty && !Matrix.isMatrixBEmpty)
            {
                OneMatrix(MatrixB);
            }
            else if (!Matrix.isMatrixAEmpty && !Matrix.isMatrixBEmpty)
            {
                BothMatrixs();
            }
        }

        public static void Determinant()
        {
            throw new NotImplementedException();
        }

        public static void Divide()
        {
            throw new NotImplementedException();
        }

        public static void Minor()
        {
            throw new NotImplementedException();
        }

        public static void Minus()
        {
            throw new NotImplementedException();
        }

        public static void Multiply()
        {
            throw new NotImplementedException();
        }

        public static void Plus()
        {
            throw new NotImplementedException();
        }

        public static void Transpose()
        {
            throw new NotImplementedException();
        }

        #endregion Fields
    }
}