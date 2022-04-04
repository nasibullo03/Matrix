using System;

namespace Task3OverloadingOperations
{
    internal class PrintValue
    {
        internal static void PrintOperations(
            SquareMatrix FirstMatrix,
            SquareMatrix SecondMatrix,
            string Operation,
            SquareMatrix Result,
            int size
        )
        {
            for (int ColIndex = 0; ColIndex < size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < size; ++RowIndex)
                {
                    Console.Write("{0,4}", FirstMatrix.MatrixValue[ColIndex, RowIndex]);
                }

                if (ColIndex == (int)size / 2)
                {
                    Console.Write("{0,4}", Operation);
                }
                else
                {
                    Console.Write("{0,4}", "");
                }

                for (int RowIndex = 0; RowIndex < size; ++RowIndex)
                {
                    Console.Write("{0,4}", SecondMatrix.MatrixValue[ColIndex, RowIndex]);
                }

                if (ColIndex == (int)size / 2)
                {
                    Console.Write("{0,4}", "=");
                }
                else
                {
                    Console.Write("{0,4}", "");
                }

                for (int RowIndex = 0; RowIndex < size; ++RowIndex)
                {
                    Console.Write("{0,4}", Result.MatrixValue[ColIndex, RowIndex]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintOperations(
            SquareMatrix FirstMatrix,
            SquareMatrix SecondMatrix,
            string Operation,
            bool Result,
            int size
        )
        {
            for (int ColIndex = 0; ColIndex < size; ++ColIndex)
            {
                Console.Write("|");
                for (int RowIndex = 0; RowIndex < size; ++RowIndex)
                {
                    Console.Write("{0,4}", FirstMatrix.MatrixValue[ColIndex, RowIndex]);
                }

                if (ColIndex == (int)size / 2)
                {
                    Console.Write("{0,4}", Operation);
                }
                else
                {
                    Console.Write("{0,4}", "");
                }

                for (int RowIndex = 0; RowIndex < size; ++RowIndex)
                {
                    Console.Write("{0,4}", SecondMatrix.MatrixValue[ColIndex, RowIndex]);
                }

                Console.Write("{0,4}", "|");

                if (ColIndex == (int)size / 2)
                {
                    Console.Write("{0,2}", "=");
                    Console.Write("{0,6}", Result);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintOperations(int[,] MainMatrix, int Result, string Operation)
        {
            int MatrixSize = MainMatrix.GetLength(0);
            if (Operation == "FindDeterminant")
            {
                for (int ColIndex = 0; ColIndex < MatrixSize; ++ColIndex)
                {
                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write("{0,10}", "|A|(det) =");
                    }
                    else
                    {
                        Console.Write("{0,10}", "");
                    }
                    Console.Write("|");
                    for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
                    {
                        Console.Write("{0,4}", MainMatrix[ColIndex, RowIndex]);
                    }
                    Console.Write("{0,4}", "|");

                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write($" = {Result}");
                    }

                    Console.WriteLine();
                }
            }
        }

        public static void PrintOperations(int[,] MainMatrix, int[,] SecondMatrix, string Operation)
        {
            int MatrixSize = MainMatrix.GetLength(0);
            if (Operation == "FindTranspose")
            {
                for (int ColIndex = 0; ColIndex < MatrixSize; ++ColIndex)
                {
                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write("{0,4}", "A =");
                    }
                    else
                    {
                        Console.Write("{0,4}", "");
                    }
                    Console.Write("|");
                    for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
                    {
                        Console.Write("{0,4}", MainMatrix[ColIndex, RowIndex]);
                    }
                    Console.Write("{0,4}", "|");

                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write("{0,17}", "; Transpose(A) = ");
                    }
                    else
                    {
                        Console.Write("{0,17}", "");
                    }
                    Console.Write("|");
                    for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
                    {
                        Console.Write("{0,4}", SecondMatrix[ColIndex, RowIndex]);
                    }

                    Console.Write("{0,4}", "|");
                    Console.WriteLine();
                }
            }
            else if (Operation == "FindMinor")
            {
                for (int ColIndex = 0; ColIndex < MatrixSize; ++ColIndex)
                {
                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write("{0,4}", "A =");
                    }
                    else
                    {
                        Console.Write("{0,4}", "");
                    }
                    Console.Write("|");
                    for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
                    {
                        Console.Write("{0,4}", MainMatrix[ColIndex, RowIndex]);
                    }
                    Console.Write("{0,4}", "|");

                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write("{0,13}", "; Minor(A) = ");
                    }
                    else
                    {
                        Console.Write("{0,13}", "");
                    }
                    Console.Write("|");
                    for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
                    {
                        Console.Write("{0,4}", SecondMatrix[ColIndex, RowIndex]);
                    }

                    Console.Write("{0,4}", "|");
                    Console.WriteLine();
                }
            }
        }

        public static void PrintOperations(int[,] MainMatrix, Double[,] Inverse, string Operation)
        {
            int MatrixSize = MainMatrix.GetLength(0);
            if (Operation == "FindInverseMatrix")
            {
                for (int ColIndex = 0; ColIndex < MatrixSize; ++ColIndex)
                {
                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write("{0,4}", "A =");
                    }
                    else
                    {
                        Console.Write("{0,4}", "");
                    }
                    Console.Write("|");
                    for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
                    {
                        Console.Write("{0,4}", MainMatrix[ColIndex, RowIndex]);
                    }
                    Console.Write("{0,4}", "|");

                    if (ColIndex == (int)MatrixSize / 2)
                    {
                        Console.Write("{0,16}", "; Inverse(A) = ");
                    }
                    else
                    {
                        Console.Write("{0,16}", "");
                    }
                    Console.Write("|");
                    for (int RowIndex = 0; RowIndex < MatrixSize; ++RowIndex)
                    {
                        Console.Write("{0,6}", Inverse[ColIndex, RowIndex]);
                    }
                    Console.Write("{0,2}", "|");
                    Console.WriteLine();
                }
            }
        }

        private static string OutputWithAdditionallySpace(string text, int space)
        {
            string result = "";

            result += text;
            int otherSpace = space - text.Length;
            if (otherSpace > 0)
            {
                for (int i = 0; i < otherSpace; ++i)
                {
                    result += " ";
                }
            }

            return result;
        }

        private static string OutputInOneColumn(string text, int RowIndex)

        {
            string result = "";

            if (Matrix.MaxLenghtofColumn(RowIndex) - text.Length == 0)
            {
                result += text;
            }
            else
            {
                result += text;
                for (int i = 0; i < Matrix.MaxLenghtofColumn(RowIndex) - text.Length; ++i)
                {
                    result += " ";
                }
            }
            return result;
        }

        public static void PrintOneMatrix(int[,] MatrixValue, string MatrixName)
        {
            Matrix.ResultText = new string[Matrix.MatrixSize];
            for (int ColIndex = 0; ColIndex < Matrix.MatrixSize; ++ColIndex)
            {
                if (ColIndex == (int)Matrix.MatrixSize / 2)
                {
                    Matrix.ResultText[ColIndex] += OutputWithAdditionallySpace(MatrixName + "=", MatrixName.Length + 4);
                }
                else
                {
                    Matrix.ResultText[ColIndex] += OutputWithAdditionallySpace(" ", MatrixName.Length + 7);
                }

                for (int RowIndex = 0; RowIndex < Matrix.MatrixSize; ++RowIndex)
                {
                    Matrix.ResultText[ColIndex] += OutputInOneColumn(MatrixValue[ColIndex, RowIndex].ToString(), RowIndex);

                    Matrix.ResultText[ColIndex] += "  ";
                }
            }
        }

        public static void PrintBothMatrix()
        {
            Matrix.ResultText = new string[Matrix.MatrixSize];

            for (int ColIndex = 0; ColIndex < Matrix.MatrixSize; ++ColIndex)
            {
                if (ColIndex == (int)Matrix.MatrixSize / 2)
                {
                    Matrix.ResultText[ColIndex] += OutputWithAdditionallySpace(Matrix.MatrixAName + "=", Matrix.MatrixAName.Length + 4);
                }
                else
                {
                    Matrix.ResultText[ColIndex] += OutputWithAdditionallySpace(" ", Matrix.MatrixAName.Length + 7);
                }

                for (int RowIndex = 0; RowIndex < Matrix.MatrixSize; ++RowIndex)
                {
                    Matrix.ResultText[ColIndex] += OutputInOneColumn(Matrix.MatrixA.MatrixValue[ColIndex, RowIndex].ToString(), RowIndex);

                    Matrix.ResultText[ColIndex] += "  ";
                }

                if (ColIndex == (int)Matrix.MatrixSize / 2)
                {
                    Matrix.ResultText[ColIndex] += OutputWithAdditionallySpace("; " + Matrix.MatrixBName + "=", Matrix.MatrixAName.Length + 6);
                }
                else
                {
                    Matrix.ResultText[ColIndex] += OutputWithAdditionallySpace(" ", Matrix.MatrixAName.Length + 9);
                }

                for (int RowIndex = 0; RowIndex < Matrix.MatrixSize; ++RowIndex)
                {
                    Matrix.ResultText[ColIndex] += OutputInOneColumn(Matrix.MatrixB.MatrixValue[ColIndex, RowIndex].ToString(), RowIndex);

                    Matrix.ResultText[ColIndex] += "  ";
                }
            }
        }
    }
}