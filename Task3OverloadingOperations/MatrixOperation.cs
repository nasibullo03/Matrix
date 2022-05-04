using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Task3OverloadingOperations
{
    public abstract class PerformOperation : ShowMatrixs

    {
        //TODO

        /*

         Надо ограничит размер матрицы иначе матрица будет зависать
         Неправильно показывает Minor и Transpose

        для функции обратная марица еще не добавлена кнопка
        надо добавить кнопку
        надо добавить констант размер форму программы

         */

        #region Fields

        private static Label LblOperation { get; set; }

        private static Label LblTwoOperationName { get; set; }
        private static Label LblEqual { get; set; }

        public enum Operation
        {
            Plus, Minus, Multiply, Divide, Determinant, Minor, Transpose, ShowMatrixs,
            GreateThan, SmallThan, GreatOrEqualThan, SmallOrEqualThan, Equal, IsNotEqual
        }

        public delegate void operation();

        public static Dictionary<Operation, operation> Operations { get; set; }

        #endregion Fields

        #region Metods

        public static void FillOperations()
        {
            Operations = new Dictionary<Operation, operation> {
                { Operation.Plus, Plus },
                { Operation.Minus, Minus},
                { Operation.Multiply, Multiply},
                { Operation.Divide, Divide},
                { Operation.Determinant, Determinant},
                { Operation.Minor, Minor},
                { Operation.Transpose, Transpose},
                { Operation.GreateThan,GreateThan },
                { Operation.SmallThan, SmallThan },
                { Operation.GreatOrEqualThan, GreatOrEqualThan},
                { Operation.SmallOrEqualThan, SmallOrEqualThan },
                { Operation.Equal,Equal },
                { Operation.IsNotEqual, IsNotEqual},
                { Operation.ShowMatrixs, ShowMatrixs.Show }
            };
        }

        public static void Determinant() => DoOperation(Operation.Determinant);

        public static void Divide() => DoOperation(Operation.Divide);

        public static void Minor() => DoOperation(Operation.Minor);

        public static void Minus() => DoOperation(Operation.Minus);

        public static void Multiply() => DoOperation(Operation.Multiply);

        public static void Plus() => DoOperation(Operation.Plus);

        public static void Transpose() => DoOperation(Operation.Transpose);

        public static void GreateThan() => DoOperation(Operation.GreateThan);

        public static void SmallThan() => DoOperation(Operation.SmallThan);

        public static void GreatOrEqualThan() => DoOperation(Operation.GreatOrEqualThan);

        public static void SmallOrEqualThan() => DoOperation(Operation.SmallOrEqualThan);

        public static void Equal() => DoOperation(Operation.Equal);

        public static void IsNotEqual() => DoOperation(Operation.IsNotEqual);

        private static void DoOperation(Operation operation)
        {
            if (!IsMatrixAEmpty && !IsMatrixBEmpty)
            {
                switch (operation)
                {
                    case Operation.Plus:
                        DoOperation_WhithTwoMatrix("+", MatrixA + MatrixB);
                        break;

                    case Operation.Minus:
                        DoOperation_WhithTwoMatrix("-", MatrixA - MatrixB);
                        break;

                    case Operation.Multiply:
                        DoOperation_WhithTwoMatrix("*", MatrixA * MatrixB);
                        break;

                    case Operation.Divide:
                        DoOperation_WhithTwoMatrix("/", MatrixA / MatrixB);
                        break;

                    case Operation.Minor:
                        DoOperation_TwoOperation_TwoMatrix(Operation.Minor);
                        break;

                    case Operation.Determinant:
                        DoOperation_TwoOperation_TwoMatrix(Operation.Determinant);
                        break;

                    case Operation.Transpose:
                        DoOperation_TwoOperation_TwoMatrix(Operation.Determinant);
                        break;

                    case Operation.GreateThan:
                        DoOperation_WhithTwoMatrix(">", MatrixA > MatrixB);
                        break;

                    case Operation.SmallThan:
                        DoOperation_WhithTwoMatrix("<", MatrixA < MatrixB);
                        break;

                    case Operation.GreatOrEqualThan:
                        DoOperation_WhithTwoMatrix(">=", MatrixA >= MatrixB);
                        break;

                    case Operation.SmallOrEqualThan:
                        DoOperation_WhithTwoMatrix("<=", MatrixA <= MatrixB);

                        break;

                    case Operation.Equal:
                        DoOperation_WhithTwoMatrix("==", MatrixA == MatrixB);
                        break;

                    case Operation.IsNotEqual:
                        DoOperation_WhithTwoMatrix("!=", MatrixA != MatrixB);
                        break;
                }
            }
            else
            {
                switch (operation)
                {
                    case Operation.Minor:
                        DoOperation_Minor(MatrixA, SquareMatrix.FindMinor(MatrixA.MatrixValue), LblTwoOperationName, new Point(3, 3));
                        break;

                    case Operation.Determinant:
                        DoOperation_Determinant(MatrixA, SquareMatrix.FindDeterminant(MatrixA.MatrixValue), LblTwoOperationName, new Point(3, 3));
                        break;

                    case Operation.Transpose:
                        DoOperation_Transpose(MatrixA, SquareMatrix.FindTranspose(MatrixA.MatrixValue), LblTwoOperationName, new Point(3, 3));
                        break;

                    default:
                        if (SquareMatrix.IsMatrixAEmpty && SquareMatrix.IsMatrixBEmpty)
                            MessageBox.Show("Сначала добавьте матрицу , чтобы выполнить эту операцию!", "Квадраная матрица", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Чтобы выполнить эту операцию, добавьте вторую матрицу!", "Квадраная матрица", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private static void DoOperation_WhithTwoMatrix(string operation, SquareMatrix ResultMatrix)
        {
            FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат

            #region LblTwoOperationName

            LblTwoOperationName = Resources.LblMatrixName();
            LblTwoOperationName.Location = new Point(3, 3);
            LblTwoOperationName.Text = $"{MatrixA.Name}{operation}{MatrixB.Name} =";

            FormMain.PanelResult.Controls.Add(LblTwoOperationName);

            #endregion LblTwoOperationName

            #region FirstMatrix

            MatrixA_LblName.Location = new Point()
            {
                X = LblTwoOperationName.Location.X + LblTwoOperationName.Size.Width,
                Y = 3
            };

            ShowMatrixs.OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture, new Point(3, 3), false);

            #endregion FirstMatrix

            #region LblOperation

            //Добавление Label имя
            LblOperation = Resources.LblMatrixName();
            LblOperation.Text = operation;
            //Кординации начало для имя операции
            LblOperation.Location = new Point
            {
                X = BrecketClosePicture.Location.X + 22,
                Y = BrecketClosePicture.Location.Y
            };
            //Добавление имя операции в главной форме
            FormMain.PanelResult.Controls.Add(LblOperation);

            #endregion LblOperation

            #region SecondMatrix

            //Изменение коррдинации начало для второй матрцы
            MatrixB_LblName.Location = new Point()
            {
                X = LblOperation.Location.X + LblOperation.Width,
                Y = BrecketClosePicture.Location.Y
            };
            //Вызов метод для добавление второй матрицы

            PictureBox brecketOpen = Resources.BrecketOpen();
            PictureBox brecketClose = Resources.BrecketClose();

            OneMatrix(MatrixB, MatrixB_LblName, MatrixB_Labels, brecketOpen, brecketClose, new Point(3, 3), false);

            #endregion SecondMatrix

            #region LblEqual

            LblEqual = Resources.LblMatrixName();
            LblEqual.Text = "=";
            //Кординации начало для имя операции
            LblEqual.Location = new Point
            {
                X = brecketClose.Location.X + 22,
                Y = brecketClose.Location.Y
            };
            //Добавление имя операции в главной форме
            FormMain.PanelResult.Controls.Add(LblEqual);

            #endregion LblEqual

            #region Result

            Label LblMatrixName = Resources.LblMatrixName();

            LblMatrixName.Location = new Point()
            {
                X = LblEqual.Location.X + LblEqual.Size.Width,
                Y = brecketClose.Location.Y
            };

            OneMatrix(ResultMatrix, LblMatrixName, Matrix_Result, Resources.BrecketOpen(), Resources.BrecketClose(), new Point(3, 3), false);

            #endregion Result

            #region SetMiddlePosition

            LblTwoOperationName.Location = new Point
            {
                X = LblTwoOperationName.Location.X,
                Y = brecketClose.Size.Height / 2 - LblTwoOperationName.Size.Height / 2
            };

            LblOperation.Location = new Point
            {
                X = LblOperation.Location.X,
                Y = brecketClose.Size.Height / 2 - LblOperation.Size.Height / 2
            };

            LblEqual.Location = new Point
            {
                X = LblEqual.Location.X,
                Y = brecketClose.Size.Height / 2 - LblEqual.Size.Height / 2
            };

            #endregion SetMiddlePosition
        }

        private static void DoOperation_WhithTwoMatrix(string operation, bool ResultMatrix)
        {
            FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат

            #region LblTwoOperationName

            LblTwoOperationName = Resources.LblMatrixName();
            LblTwoOperationName.Location = new Point(3, 3);
            LblTwoOperationName.Text = $"{MatrixA.Name}{operation}{MatrixB.Name} =";

            FormMain.PanelResult.Controls.Add(LblTwoOperationName);

            #endregion LblTwoOperationName

            #region FirstMatrix

            MatrixA_LblName.Location = new Point()
            {
                X = LblTwoOperationName.Location.X + LblTwoOperationName.Size.Width,
                Y = 3
            };

            ShowMatrixs.OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture, new Point(3, 3), false);

            #endregion FirstMatrix

            #region LblOperation

            //Добавление Label имя
            LblOperation = Resources.LblMatrixName();
            LblOperation.Text = operation;
            //Кординации начало для имя операции
            LblOperation.Location = new Point
            {
                X = BrecketClosePicture.Location.X + 22,
                Y = BrecketClosePicture.Location.Y
            };
            //Добавление имя операции в главной форме
            FormMain.PanelResult.Controls.Add(LblOperation);

            #endregion LblOperation

            #region SecondMatrix

            //Изменение коррдинации начало для второй матрцы
            MatrixB_LblName.Location = new Point()
            {
                X = LblOperation.Location.X + LblOperation.Width,
                Y = BrecketClosePicture.Location.Y
            };
            //Вызов метод для добавление второй матрицы

            PictureBox brecketOpen = Resources.BrecketOpen();
            PictureBox brecketClose = Resources.BrecketClose();

            OneMatrix(MatrixB, MatrixB_LblName, MatrixB_Labels, brecketOpen, brecketClose, new Point(3, 3), false);

            #endregion SecondMatrix

            #region LblEqual

            LblEqual = Resources.LblMatrixName();
            LblEqual.Text = "=";
            //Кординации начало для имя операции
            LblEqual.Location = new Point
            {
                X = brecketClose.Location.X + 22,
                Y = brecketClose.Location.Y
            };
            //Добавление имя операции в главной форме
            FormMain.PanelResult.Controls.Add(LblEqual);

            #endregion LblEqual

            #region Result

            Label LblMatrixResult = Resources.LblMatrixName();
            LblMatrixResult.Text = (ResultMatrix) ? "True" : "False";

            LblMatrixResult.Location = new Point()
            {
                X = LblEqual.Location.X + LblEqual.Size.Width,
                Y = brecketClose.Size.Height / 2 - LblTwoOperationName.Size.Height / 2
            };
            FormMain.PanelResult.Controls.Add(LblMatrixResult);

            #endregion Result

            #region SetMiddlePosition

            LblTwoOperationName.Location = new Point
            {
                X = LblTwoOperationName.Location.X,
                Y = brecketClose.Size.Height / 2 - LblTwoOperationName.Size.Height / 2
            };

            LblOperation.Location = new Point
            {
                X = LblOperation.Location.X,
                Y = brecketClose.Size.Height / 2 - LblOperation.Size.Height / 2
            };

            LblEqual.Location = new Point
            {
                X = LblEqual.Location.X,
                Y = brecketClose.Size.Height / 2 - LblEqual.Size.Height / 2
            };

            #endregion SetMiddlePosition
        }

        private static void DoOperation_TwoOperation_TwoMatrix(Operation operation)
        {
            switch (operation)
            {
                case Operation.Minor:
                    FormMain.PanelResult.Controls.Clear();
                    DoOperation_Minor(MatrixA, SquareMatrix.FindMinor(MatrixA.MatrixValue), Resources.LblMatrixName(), new Point(3, 3), false);
                    DoOperation_Minor(MatrixB, SquareMatrix.FindMinor(MatrixB.MatrixValue), Resources.LblMatrixName(), new Point(3, BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height + 10), false);
                    break;

                case Operation.Determinant:
                    FormMain.PanelResult.Controls.Clear();
                    DoOperation_Determinant(MatrixA, SquareMatrix.FindDeterminant(MatrixA.MatrixValue), Resources.LblMatrixName(), new Point(3, 3), false);
                    DoOperation_Determinant(MatrixB, SquareMatrix.FindDeterminant(MatrixB.MatrixValue), Resources.LblMatrixName(), new Point(3, BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height + 10), false);
                    break;

                case Operation.Transpose:
                    FormMain.PanelResult.Controls.Clear();
                    DoOperation_Transpose(MatrixA, SquareMatrix.FindTranspose(MatrixA.MatrixValue), Resources.LblMatrixName(), new Point(3, 3), false);
                    DoOperation_Transpose(MatrixB, SquareMatrix.FindTranspose(MatrixB.MatrixValue), Resources.LblMatrixName(), new Point(3, BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height + 10), false);
                    break;
            }
        }

        private static void DoOperation_Transpose(SquareMatrix matrix, int[,] ResultMatrix, Label LblOperName, Point Startposition, bool ClearPannel = true)
        {
            #region MatrixOperationName

            if (ClearPannel)
                FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат

            if (LblOperName == null)
                _ = Resources.Label();

            var lblT = Resources.Label();
            var LblEqualText = Resources.Label();
            LblOperName = Resources.Label();
            LblOperName.Location = Startposition;

            LblOperName.Text = $"{matrix.Name}";
            LblOperName.AutoSize = true;

            FormMain.PanelResult.Controls.Add(LblOperName);

            lblT.Text = "T";
            lblT.Location = new Point
            {
                X = LblOperName.Location.X + LblOperName.Size.Width,
                Y = LblOperName.Location.Y - LblOperName.Size.Height / 2
            };

            FormMain.PanelResult.Controls.Add(lblT);

            LblEqualText.Text = "=";
            LblEqualText.Location = new Point
            {
                X = lblT.Location.X + lblT.Size.Width,
                Y = LblOperName.Location.Y
            };

            FormMain.PanelResult.Controls.Add(LblEqualText);

            MatrixA_LblName.Location = new Point()
            {
                X = LblEqualText.Location.X + LblEqualText.Size.Width,
                Y = Startposition.Y
            };

            #endregion MatrixOperationName

            #region FirstMatrix

            ShowMatrixs.OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture, Startposition, false);

            #endregion FirstMatrix

            #region LblEqual

            LblEqual = Resources.LblMatrixName();
            LblEqual.Text = "=";
            //Кординации начало для имя операции
            LblEqual.Location = new Point
            {
                X = BrecketClosePicture.Location.X + 22,
                Y = BrecketClosePicture.Location.Y
            };

            //Добавление имя операции в главной форме
            FormMain.PanelResult.Controls.Add(LblEqual);

            #endregion LblEqual

            #region Result

            Label LblMatrixName = Resources.LblMatrixName();

            LblMatrixName.Location = new Point()
            {
                X = LblEqual.Location.X + LblEqual.Size.Width,
                Y = BrecketClosePicture.Location.Y
            };

            SquareMatrix ResultMatrix1 = new SquareMatrix
            {
                MatrixValue = ResultMatrix
            };
            OneMatrix(ResultMatrix1, LblMatrixName, Matrix_Result, Resources.BrecketOpen(), Resources.BrecketClose(), new Point(3, 3), false);

            #endregion Result

            #region SetMiddlePosition

            LblOperName.Location = new Point
            {
                X = LblOperName.Location.X,
                Y = BrecketClosePicture.Size.Height / 2 - LblOperName.Size.Height / 2
            };

            lblT.Location = new Point
            {
                X = LblOperName.Location.X + LblOperName.Size.Width,
                Y = LblOperName.Location.Y - LblOperName.Size.Height / 2
            };
            LblEqualText.Location = new Point
            {
                X = lblT.Location.X + lblT.Size.Width,
                Y = LblOperName.Location.Y
            };
            LblEqual.Location = new Point
            {
                X = LblEqual.Location.X,
                Y = BrecketClosePicture.Size.Height / 2 - LblEqual.Size.Height / 2
            };

            #endregion SetMiddlePosition
        }

        private static void DoOperation_Determinant(SquareMatrix matrix, int Result, Label LblOperationName, Point Startposition, bool ClearPannel = true)
        {
            #region MatrixOperationName

            if (ClearPannel)
                FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат

            if (LblOperationName == null)
                LblOperationName = Resources.Label();

            LblOperationName.Location = Startposition;

            LblOperationName.Text = $"|{matrix.Name}|=";
            LblOperationName.AutoSize = true;

            FormMain.PanelResult.Controls.Add(LblOperationName);
            var LblOp = Resources.Label();
            LblOp.Location = new Point()
            {
                X = LblOperationName.Location.X + LblOperationName.Size.Width,
                Y = Startposition.Y
            };

            #endregion MatrixOperationName

            #region FirstMatrix

            var brecketOpen = Resources.BrecketOpen();
            var brecketClose = Resources.BrecketClose();

            ShowMatrixs.OneMatrix(matrix, LblOp, MatrixA_Labels, brecketOpen, brecketClose, Startposition, false);

            #endregion FirstMatrix

            #region LblEqual

            LblEqual = Resources.LblMatrixName();
            LblEqual.Text = $"={Result}";
            //Кординации начало для имя операции
            LblEqual.Location = new Point
            {
                X = brecketClose.Location.X + 22,
                Y = brecketClose.Location.Y + Startposition.Y
            };

            //Добавление имя операции в главной форме
            FormMain.PanelResult.Controls.Add(LblEqual);

            #endregion LblEqual

            #region SetMiddlePosition

            LblOperationName.Location = new Point
            {
                X = LblOperationName.Location.X,
                Y = (brecketClose.Size.Height / 2 - LblOperationName.Size.Height / 2) + Startposition.Y
            };

            LblEqual.Location = new Point
            {
                X = LblEqual.Location.X,
                Y = (brecketClose.Size.Height / 2 - LblEqual.Size.Height / 2) + Startposition.Y
            };

            #endregion SetMiddlePosition
        }

        private static void DoOperation_Minor(SquareMatrix matrix, int[,] Result, Label LblOperation1, Point Startposition, bool ClearPannel = true)
        {
            #region MatrixOperationName

            if (ClearPannel)
                FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат

            if (LblOperation1 == null)
                LblOperation1 = Resources.LblMatrixName();
            LblOperation1.Location = Startposition;

            LblOperation1.Text = $"M({matrix.Name})=";
            LblOperation1.AutoSize = true;

            FormMain.PanelResult.Controls.Add(LblOperation1);

            var lblOp = Resources.Label();
            lblOp.Location = new Point()
            {
                X = LblOperation1.Location.X + LblOperation1.Size.Width,
                Y = Startposition.Y
            };

            #endregion MatrixOperationName

            #region FirstMatrix

            var BrecketOpenPic = Resources.BrecketOpen();
            var BrecketClosePic = Resources.BrecketClose();
            ShowMatrixs.OneMatrix(matrix, lblOp, MatrixA_Labels, BrecketOpenPic, BrecketClosePic, Startposition, false);

            #endregion FirstMatrix

            #region LblEqual

            LblEqual = Resources.LblMatrixName();
            LblEqual.Text = "=";
            //Кординации начало для имя операции
            LblEqual.Location = new Point
            {
                X = BrecketClosePic.Location.X + 22,
                Y = BrecketClosePic.Location.Y + Startposition.Y
            };

            //Добавление имя операции в главной форме
            FormMain.PanelResult.Controls.Add(LblEqual);

            #endregion LblEqual

            #region Result

            Label LblMatrixName = Resources.LblMatrixName();

            LblMatrixName.Location = new Point()
            {
                X = LblEqual.Location.X + LblEqual.Size.Width,
                Y = BrecketClosePicture.Location.Y + Startposition.Y
            };
            SquareMatrix matrix1 = new SquareMatrix
            {
                MatrixValue = Result
            };

            OneMatrix(matrix1, LblMatrixName, Matrix_Result, Resources.BrecketOpen(), Resources.BrecketClose(), Startposition, false);

            #endregion Result

            #region SetMiddlePosition

            LblOperation1.Location = new Point
            {
                X = LblOperation1.Location.X,
                Y = (BrecketClosePicture.Size.Height / 2 - LblOperation1.Size.Height / 2) + Startposition.Y
            };

            LblEqual.Location = new Point
            {
                X = LblEqual.Location.X,
                Y = (BrecketClosePicture.Size.Height / 2 - LblEqual.Size.Height / 2) + Startposition.Y
            };

            #endregion SetMiddlePosition
        }

        #endregion Metods
    }
}