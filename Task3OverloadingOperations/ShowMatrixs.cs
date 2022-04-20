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
using System.Reflection;

namespace Task3OverloadingOperations
{
    public class ShowMatrixs : Matrix
    {
        #region Fields

        //public static Label[,] Matrix_Labels;
        public static Label[,] MatrixA_Labels;

        public static Label[,] MatrixB_Labels;
        public static Label MatrixA_LblName;
        public static Label MatrixB_LblName;

        #endregion Fields

        #region Metods

        #region Public Metods

        public static void Show()

        {
            if (!Matrix.IsMatrixAEmpty && Matrix.IsMatrixBEmpty)
            {
                FormMain.PanelResult.Controls.Clear();
                OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture);
            }
            else if (Matrix.IsMatrixAEmpty && !Matrix.IsMatrixBEmpty)
            {
                FormMain.PanelResult.Controls.Clear();
                OneMatrix(MatrixB, MatrixB_LblName, MatrixB_Labels, BrecketOpenPicture, BrecketClosePicture);
            }
            else if (!Matrix.IsMatrixAEmpty && !Matrix.IsMatrixBEmpty)
            {
                FormMain.PanelResult.Controls.Clear();
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

        #endregion Public Metods

        #region Private Metods

        private static void OneMatrix(Matrix matrix, Label lblMatrixName, Label[,] MatrixLabels, PictureBox BrecketOpenPicture, PictureBox BrecketClosePicture)
        {
            int MatrixSize = matrix.MatrixValue.GetLength(0);
            try
            {
                MatrixLabels = new Label[MatrixSize, MatrixSize];

                BrecketClosePicture.Visible = true;
                BrecketOpenPicture.Visible = true;

                Point brecketOpenLocation = new Point(0, 0);

                lblMatrixName.Text = $"{matrix.Name}=";
                lblMatrixName.AutoSize = true;
                lblMatrixName.Visible = true;

                brecketOpenLocation.X = lblMatrixName.Location.X + lblMatrixName.Size.Width;

                Point brecketCloseLocation = new Point(0, 0);

                Point LabelPoint = new Point()
                {
                    X = brecketOpenLocation.X + 22,
                    Y = 3
                };

                Size brecketSize = new Size(20, 0);

                for (int i = 0; i < MatrixSize; ++i)
                {
                    for (int j = 0; j < MatrixSize; ++j)
                    {
                        MatrixLabels[i, j] = new Label()
                        {
                            Location = new System.Drawing.Point(LabelPoint.X, LabelPoint.Y),
                            AutoSize = true,
                            Text = matrix.MatrixValue[i, j].ToString()
                        };
                        MatrixLabels[i, j].TextChanged += new System.EventHandler(FormAdd.MatrixTextBoxes_TextChanged);

                        FormMain.PanelResult.Controls.Add(MatrixLabels[i, j]);

                        LabelPoint.X += MatrixLabels[i, j].Size.Width + 5;
                    }

                    brecketCloseLocation.X = LabelPoint.X;
                    LabelPoint.X = brecketOpenLocation.X + 22;
                    LabelPoint.Y += 20;
                }

                brecketSize.Height += LabelPoint.Y;

                lblMatrixName.Location = new Point(lblMatrixName.Location.X, brecketSize.Height / 2 - lblMatrixName.Size.Height / 2);

                BrecketOpenPicture.Size = brecketSize;
                BrecketClosePicture.Size = brecketSize;

                BrecketClosePicture.Location = brecketCloseLocation;
                BrecketOpenPicture.Location = brecketOpenLocation;

                ResizeLabels(MatrixLabels, lblMatrixName, BrecketClosePicture);

                FormMain.PanelResult.Controls.Add(BrecketOpenPicture);
                FormMain.PanelResult.Controls.Add(BrecketClosePicture);
                FormMain.PanelResult.Controls.Add(lblMatrixName);
            }
            catch
            {
                MessageBox.Show("Программа вернул ощибку", "Квадратная матрица", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                FormAdd.MatrixSizeComboBox.Text = "0";
            }
        }

        private static void BothMatrixs()
        {
            //Вызов метод для добавление первой матрицы
            OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture);
            //Изменение коррдинации начало для второй матрцы
            MatrixB_LblName.Location = new Point()
            {
                X = BrecketClosePicture.Location.X + 22,
                Y = BrecketClosePicture.Location.Y
            };
            //Вызов метод для добавление второй матрицы

            OneMatrix(MatrixB, MatrixB_LblName, MatrixB_Labels, Resources.brecketOpen(), Resources.brecketClose());
        }

        private static bool IsNeedToRezise(int Row, Label[,] labels)
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

        private static void ResizeLabels(Label[,] labels, Label LblMatrixName, PictureBox BrecketClosePicture)

        {
            Dictionary<int, int> DictForResizing = new Dictionary<int, int>();

            for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
            {
                if (IsNeedToRezise(RowIndex, labels))
                {
                    DictForResizing.Add(RowIndex, MaxWidthofColumn(RowIndex));
                }
            }

            ChangeLabelColumnSize(DictForResizing, labels, LblMatrixName, BrecketClosePicture);
        }

        private static void ChangeLabelColumnSize(Dictionary<int, int> ParametrsForResizing, Label[,] labels, Label LblMatrixName, PictureBox BrecketClosePicture)
        {
            Point LabelPoint = new Point(LblMatrixName.Location.X + LblMatrixName.Size.Width + 22, 3);

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
                BrecketClosePicture.Location = new Point(LabelPoint.X - 5, 0);

                LabelPoint.X = LblMatrixName.Location.X + LblMatrixName.Size.Width + 22;
                LabelPoint.Y += 20;
            }
        }

        #endregion Private Metods

        #endregion Metods
    }
}