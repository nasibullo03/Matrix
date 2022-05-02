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

        public static Label[,] MatrixA_Labels;
        public static Label[,] MatrixB_Labels;
        public static Label[,] Matrix_Result;

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
                OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture, new Point(3, 3));
            }
            else if (Matrix.IsMatrixAEmpty && !Matrix.IsMatrixBEmpty)
            {
                FormMain.PanelResult.Controls.Clear();
                OneMatrix(MatrixB, MatrixB_LblName, MatrixB_Labels, BrecketOpenPicture, BrecketClosePicture, new Point(3, 3));
            }
            else if (!Matrix.IsMatrixAEmpty && !Matrix.IsMatrixBEmpty)
            {
                FormMain.PanelResult.Controls.Clear();
                BothMatrixs();
            }
        }

        #endregion Public Metods

        #region Private Metods

        public static void OneMatrix(
            Matrix matrix,
            Label lblMatrixName,
            Label[,] MatrixLabels,
            PictureBox BrecketOpenPicture,
            PictureBox BrecketClosePicture,
            Point startPosition,
            bool showLblName = true
            )
        {
            int MatrixSize = matrix.MatrixValue.GetLength(0);
            try
            {
                MatrixLabels = new Label[MatrixSize, MatrixSize];

                BrecketClosePicture.Visible = true;
                BrecketOpenPicture.Visible = true;

                Point brecketOpenLocation = startPosition;

                if (showLblName)
                {
                    lblMatrixName.Text = $"{matrix.Name}=";
                    lblMatrixName.AutoSize = true;
                    lblMatrixName.Visible = true;

                    brecketOpenLocation.X = lblMatrixName.Location.X + lblMatrixName.Size.Width;
                }
                else
                {
                    brecketOpenLocation.X = lblMatrixName.Location.X;
                }

                Point brecketCloseLocation = startPosition;

                Point LabelPoint = new Point()
                {
                    X = brecketOpenLocation.X + 22,
                    Y = startPosition.Y
                };

                Size brecketSize = new Size(20, 0);

                for (int i = 0; i < MatrixSize; ++i)
                {
                    for (int j = 0; j < MatrixSize; ++j)
                    {
                        MatrixLabels[i, j] = new Label()
                        {
                            Location = new Point(LabelPoint.X, LabelPoint.Y),
                            AutoSize = true,
                            Text = matrix.MatrixValue[i, j].ToString()
                        };

                        MatrixLabels[i, j].TextChanged += new System.EventHandler(FormAdd.MatrixTextBoxes_TextChanged);

                        FormMain.PanelResult.Controls.Add(MatrixLabels[i, j]);

                        LabelPoint.X += MatrixLabels[i, j].Width + 5;
                    }

                    brecketCloseLocation.X = LabelPoint.X;
                    LabelPoint.X = brecketOpenLocation.X + 22;
                    LabelPoint.Y += 20;
                }

                brecketSize.Height += LabelPoint.Y - startPosition.Y;

                if (showLblName)
                    lblMatrixName.Location = new Point(lblMatrixName.Location.X, brecketSize.Height / 2 - lblMatrixName.Size.Height / 2 + startPosition.Y);
                else
                    lblMatrixName.Visible = false;

                BrecketOpenPicture.Size = brecketSize;
                BrecketClosePicture.Size = brecketSize;

                BrecketClosePicture.Location = brecketCloseLocation;
                BrecketOpenPicture.Location = brecketOpenLocation;

                FormMain.PanelResult.Controls.Add(BrecketOpenPicture);
                FormMain.PanelResult.Controls.Add(BrecketClosePicture);
                FormMain.PanelResult.Controls.Add(lblMatrixName);

                ResizeLabels(MatrixLabels, lblMatrixName, BrecketClosePicture, startPosition, showLblName);
            }
            catch
            {
                MessageBox.Show("Программа вернул ощибку", "Квадратная матрица", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                FormAdd.MatrixSizeComboBox.Text = "0";
            }
        }

        private static void BothMatrixs()
        {
            MatrixA_LblName.Location = new Point
            {
                X = 3,
                Y = 3
            };

            //Вызов метод для добавление первой матрицы
            OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture, new Point(3, 3));
            //Изменение коррдинации начало для второй матрцы
            Label LblSeparatinSign = Resources.Label();
            LblSeparatinSign.Text = ";";
            LblSeparatinSign.Location = new Point
            {
                X = BrecketClosePicture.Location.X + BrecketClosePicture.Width,
                Y = BrecketClosePicture.Location.Y + BrecketClosePicture.Height / 2 - LblSeparatinSign.Height + 3,
            };

            FormMain.PanelResult.Controls.Add(LblSeparatinSign);

            MatrixB_LblName.Location = new Point()
            {
                X = BrecketClosePicture.Location.X + 22 + LblSeparatinSign.Width,
                Y = BrecketClosePicture.Location.Y
            };

            //Вызов метод для добавление второй матрицы
            var brecketOpen = Resources.brecketOpen();
            var brecketClose = Resources.brecketClose();
            OneMatrix(MatrixB, MatrixB_LblName, MatrixB_Labels, brecketOpen, brecketClose, new Point(3, 3));

            Label LblSeparatinSign1 = Resources.Label();
            LblSeparatinSign1.Text = ";";
            LblSeparatinSign1.Location = new Point
            {
                X = brecketClose.Location.X + brecketClose.Width,
                Y = brecketClose.Location.Y + brecketClose.Height / 2 - LblSeparatinSign1.Height + 3,
            };

            FormMain.PanelResult.Controls.Add(LblSeparatinSign1);
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

        private static int MaxWidthofColumn(int Row, Label[,] labels)
        {
            int max = labels[0, Row].Width;
            for (int i = 0; i < MatrixSize; ++i)
            {
                if (labels[i, Row].Width > max)
                {
                    max = textBoxes[i, Row].Width;
                }
            }

            return max;
        }

        private static void ResizeLabels(Label[,] labels, Label LblMatrixName, PictureBox BrecketClosePicture, Point startPosition, bool showLblName = true)

        {
            Dictionary<int, int> DictForResizing = new Dictionary<int, int>();

            for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
            {
                if (IsNeedToRezise(RowIndex, labels))
                {
                    DictForResizing.Add(RowIndex, MaxWidthofColumn(RowIndex, labels));
                    /*MessageBox.Show($"ResizeLabels\n" +
                        $" MaxWidthofColumn({RowIndex}) = {MaxWidthofColumn(RowIndex, labels)}");*/
                }
            }

            ChangeLabelColumnSize(DictForResizing, labels, LblMatrixName, BrecketClosePicture, startPosition, showLblName);
        }

        private static void ChangeLabelColumnSize(Dictionary<int, int> ParametrsForResizing, Label[,] labels, Label LblMatrixName, PictureBox BrecketClosePicture, Point startPosition, bool showLblName = true)
        {
            Point LabelPoint;

            LabelPoint = new Point(LblMatrixName.Location.X + LblMatrixName.Width + BrecketOpenPicture.Width, startPosition.Y);

            Size LabelSize = new Size();

            for (int i = 0; i < MatrixSize; ++i)
            {
                for (int j = 0; j < MatrixSize; ++j)
                {
                    if (ParametrsForResizing.ContainsKey(j))
                    {
                        LabelSize.Width = ParametrsForResizing[j];
                        LabelSize.Height = 20;

                        /*                        MessageBox.Show($"1 ParametrsForResizing[{ParametrsForResizing[j]}\n" +
                                                   $" labels[i, j].Size = h:{ labels[i, j].Size.Height}  w:{labels[i, j].Size.Width}");*/
                        if (showLblName)
                            labels[i, j].Location = new Point(LabelPoint.X, LabelPoint.Y);
                        else
                            labels[i, j].Location = new Point(LabelPoint.X - LblMatrixName.Size.Width, LabelPoint.Y);

                        labels[i, j].AutoSize = false;
                        labels[i, j].Size = LabelSize;

                        LabelPoint.X += labels[i, j].Size.Width + 5;
                    }
                    else
                    {
                        if (showLblName)
                            labels[i, j].Location = new Point(LabelPoint.X, LabelPoint.Y);
                        else
                            labels[i, j].Location = new Point(LabelPoint.X - LblMatrixName.Size.Width, LabelPoint.Y);
                        LabelPoint.X += labels[i, j].Size.Width + 5;
                    }
                }
                if (showLblName)
                    BrecketClosePicture.Location = new Point(LabelPoint.X - 5, startPosition.Y);
                else
                    BrecketClosePicture.Location = new Point(LabelPoint.X - LblMatrixName.Size.Width - 5, startPosition.Y);

                LabelPoint.X = LblMatrixName.Location.X + LblMatrixName.Size.Width + 22;
                LabelPoint.Y += 20;
            }
        }

        #endregion Private Metods

        #endregion Metods
    }
}