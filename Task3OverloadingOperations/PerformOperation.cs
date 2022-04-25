using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task3OverloadingOperations
{
    public abstract class PerformOperation : ShowMatrixs

    {
        //TODO

        /*
         Надо изменить код функции DoOperation_TwoOperation_TwoMatrix();
         Если в форму main добавлена только одна матрица, тогда для его правильно показывает
         Если в форму добавлена две матрицы, надо писать код , еще не начал
         функции DoOperation_TwoOperation_TwoMatrix создал и добавил switch case

         Надо ограничит размер матрицы иначе матрица будет зависать
         Неправильно показывает Minor и Transpose
         Надо переписать их

        для функции обратная марица еще не добавлена кнопка
        надо добавить кнопку
        надо добавить констант размер форму программы
        
        Надо изменить картинку скобки
        надо добавлять квадратные скобки

         */

        #region Fields

        private static Label LblOperation { get; set; }

        private static Label LblTwoOperationName { get; set; }
        private static Label LblEqual { get; set; }

        public enum Operation
        { Plus, Minus, Multiply, Divide, Determinant, Minor, Transpose, ShowMatrixs }

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
                { Operation.ShowMatrixs, ShowMatrixs.Show}
            };
        }

        public static void Determinant()
        {
            DoOperation(Operation.Determinant);
        }

        public static void Divide()
        {
            DoOperation(Operation.Divide);
        }

        public static void Minor()
        {
            DoOperation(Operation.Minor);
        }

        public static void Minus()
        {
            DoOperation(Operation.Minus);
        }

        public static void Multiply()
        {
            DoOperation(Operation.Multiply);
        }

        public static void Plus()
        {
            DoOperation(Operation.Plus);
        }

        public static void Transpose()
        {
            DoOperation(Operation.Transpose);
        }

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
                }
            }
            else
            {
                switch (operation)
                {
                    case Operation.Minor:
                        DoOperation_Minor(MatrixA, Matrix.FindMinor(MatrixA.MatrixValue), LblTwoOperationName, new Point(3,3));
                        break;

                    case Operation.Determinant:
                        DoOperation_Determinant(MatrixA, Matrix.FindDeterminant(MatrixA.MatrixValue), LblTwoOperationName, new Point(3,3));
                        break;

                    case Operation.Transpose:
                        DoOperation_Transpose(MatrixA, Matrix.FindTranspose(MatrixA.MatrixValue), LblTwoOperationName);
                        break;

                    default:
                        if(Matrix.IsMatrixAEmpty && Matrix.IsMatrixBEmpty)
                            MessageBox.Show("Сначала добавьте матрицу , чтобы выполнить эту операцию!", "Квадраная матрица", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        else 
                            MessageBox.Show("Чтобы выполнить эту операцию, добавьте вторую матрицу!", "Квадраная матрица", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private static void DoOperation_WhithTwoMatrix(string operation, Matrix ResultMatrix)
        {
            FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат

            #region LblTwoOperationName

            LblTwoOperationName = Resources.lblMatrixName();
            LblTwoOperationName.Location = new Point(3, 3);
            LblTwoOperationName.Text = $"{MatrixA.Name}{operation}{MatrixB.Name}=";

            FormMain.PanelResult.Controls.Add(LblTwoOperationName);

            #endregion LblTwoOperationName

            #region FirstMatrix

            MatrixA_LblName.Location = new Point()
            {
                X = LblTwoOperationName.Location.X + LblTwoOperationName.Size.Width,
                Y = 3
            };

            ShowMatrixs.OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture, new Point(3,3), false);

            #endregion FirstMatrix

            #region LblOperation

            //Добавление Label имя
            LblOperation = Resources.lblMatrixName();
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
                X = LblOperation.Location.X + 22,
                Y = BrecketClosePicture.Location.Y
            };
            //Вызов метод для добавление второй матрицы

            PictureBox brecketOpen = Resources.brecketOpen();
            PictureBox brecketClose = Resources.brecketClose();

            OneMatrix(MatrixB, MatrixB_LblName, MatrixB_Labels, brecketOpen, brecketClose,new Point(3,3), false);

            #endregion SecondMatrix

            #region LblEqual

            LblEqual = Resources.lblMatrixName();
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

            Label LblMatrixName = Resources.lblMatrixName();

            LblMatrixName.Location = new Point()
            {
                X = LblEqual.Location.X + LblEqual.Size.Width,
                Y = brecketClose.Location.Y
            };

            OneMatrix(ResultMatrix, LblMatrixName, Matrix_Result, Resources.brecketOpen(), Resources.brecketClose(),new Point(3,3), false);

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
                    DoOperation_Minor(MatrixA, Matrix.FindMinor(MatrixA.MatrixValue), Resources.lblMatrixName(), new Point(3, BrecketOpenPicture.Location.Y+BrecketOpenPicture.Size.Height+10), false) ;
                    DoOperation_Minor(MatrixB, Matrix.FindMinor(MatrixB.MatrixValue), Resources.lblMatrixName(), new Point(3, 2*(BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height+ 10)), false);
                    break;

                case Operation.Determinant:
                    FormMain.PanelResult.Controls.Clear();
                    DoOperation_Determinant(MatrixA, Matrix.FindDeterminant(MatrixA.MatrixValue), Resources.lblMatrixName(), new Point(3, BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height + 10), false);
                    DoOperation_Determinant(MatrixB, Matrix.FindDeterminant(MatrixB.MatrixValue), Resources.lblMatrixName(), new Point(3, 2 * (BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height + 10)), false);
                    break;

                case Operation.Transpose:
                    FormMain.PanelResult.Controls.Clear();
                    DoOperation_Transpose(MatrixA, Matrix.FindDeterminant(MatrixA.MatrixValue), Resources.lblMatrixName(), new Point(3, BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height + 10), false);
                    DoOperation_Transpose(MatrixB, Matrix.FindDeterminant(MatrixB.MatrixValue), Resources.lblMatrixName(), new Point(3, 2 * (BrecketOpenPicture.Location.Y + BrecketOpenPicture.Size.Height + 10)), false);
                    break;

            }
        }

        private static void DoOperation_Transpose(Matrix matrix, int[,] ResultMatrix, Label LblOperationName, bool ClearPannel = true)
        {
            #region MatrixOperationName

            if (ClearPannel)
                FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат

            var lblT = Resources.Label();
            var LblEqualText = Resources.Label();
            LblOperationName = Resources.Label();
            LblOperationName.Location = new Point(3, 3);

            LblOperationName.Text = $"{matrix.Name}";
            LblOperationName.AutoSize = true;

            FormMain.PanelResult.Controls.Add(LblOperationName);

            lblT.Text = "T";
            lblT.Location = new Point
            {
                X = LblOperationName.Location.X + LblOperationName.Size.Width,
                Y = LblOperationName.Location.Y - LblOperationName.Size.Height / 2
            };

            FormMain.PanelResult.Controls.Add(lblT);

            LblEqualText.Text = "=";
            LblEqualText.Location = new Point
            {
                X = lblT.Location.X + lblT.Size.Width,
                Y = LblOperationName.Location.Y
            };

            FormMain.PanelResult.Controls.Add(LblEqualText);

            MatrixA_LblName.Location = new Point()
            {
                X = LblEqualText.Location.X + LblEqualText.Size.Width,
                Y = 3
            };

            #endregion MatrixOperationName

            #region FirstMatrix

            ShowMatrixs.OneMatrix(MatrixA, MatrixA_LblName, MatrixA_Labels, BrecketOpenPicture, BrecketClosePicture, new Point (3,3), false);

            #endregion FirstMatrix

            #region LblEqual

            LblEqual = Resources.lblMatrixName();
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

            Label LblMatrixName = Resources.lblMatrixName();

            LblMatrixName.Location = new Point()
            {
                X = LblEqual.Location.X + LblEqual.Size.Width,
                Y = BrecketClosePicture.Location.Y
            };

            Matrix ResultMatrix1 = new Matrix();
            ResultMatrix1.MatrixValue = ResultMatrix;
            OneMatrix(ResultMatrix1, LblMatrixName, Matrix_Result, Resources.brecketOpen(), Resources.brecketClose(), new Point(3, 3), false);

            #endregion Result

            #region SetMiddlePosition

            LblOperationName.Location = new Point
            {
                X = LblOperationName.Location.X,
                Y = BrecketClosePicture.Size.Height / 2 - LblOperationName.Size.Height / 2
            };

            lblT.Location = new Point
            {
                X = LblOperationName.Location.X + LblOperationName.Size.Width,
                Y = LblOperationName.Location.Y - LblOperationName.Size.Height / 2
            };
            LblEqualText.Location = new Point
            {
                X = lblT.Location.X + lblT.Size.Width,
                Y = LblOperationName.Location.Y
            };
            LblEqual.Location = new Point
            {
                X = LblEqual.Location.X,
                Y = BrecketClosePicture.Size.Height / 2 - LblEqual.Size.Height / 2
            };

            #endregion SetMiddlePosition
        }

        private static void DoOperation_Determinant(Matrix matrix, int Result, Label LblOperationName,Point Startposition, bool ClearPannel = true)
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
            var brecketOpen = Resources.brecketOpen();
            var brecketClose = Resources.brecketClose();

            ShowMatrixs.OneMatrix(matrix, LblOp, MatrixA_Labels, brecketOpen, brecketClose, Startposition, false);

            #endregion FirstMatrix

            #region LblEqual

            LblEqual = Resources.lblMatrixName();
            LblEqual.Text = $"={Result}";
            //Кординации начало для имя операции
            LblEqual.Location = new Point
            {
                X = brecketClose.Location.X + 22,
                Y = brecketClose.Location.Y+Startposition.Y
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

        private static void DoOperation_Minor(Matrix matrix, int[,] Result, Label LblOperation1, Point Startposition,  bool ClearPannel = true)
        {
            #region MatrixOperationName

            if (ClearPannel)
                FormMain.PanelResult.Controls.Clear();//удаление всех элементов панель результат


            if (LblOperation1 == null)
                LblOperation1 = Resources.lblMatrixName();
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

            var BrecketOpenPic = Resources.brecketOpen();
            var BrecketClosePic = Resources.brecketClose();
            ShowMatrixs.OneMatrix(matrix, lblOp, MatrixA_Labels, BrecketOpenPic, BrecketClosePic, Startposition, false);

            #endregion FirstMatrix

            #region LblEqual

            LblEqual = Resources.lblMatrixName();
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

            Label LblMatrixName = Resources.lblMatrixName();

            LblMatrixName.Location = new Point()
            {
                X = LblEqual.Location.X + LblEqual.Size.Width,
                Y = BrecketClosePicture.Location.Y +  Startposition.Y
            };
            Matrix matrix1 = new Matrix
            {
                MatrixValue = Result
            };

            OneMatrix(matrix1, LblMatrixName, Matrix_Result, Resources.brecketOpen(), Resources.brecketClose(), Startposition, false);

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