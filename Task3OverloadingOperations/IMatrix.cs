using System.IO.Enumeration;
using System;

namespace Task3OverloadingOperations
{
    interface IMatrix
    {
        static int Size { get; set; }
        protected static void FillMatrix(ref SquareMatrix matrix, int Size)
        {
            Random rand = new Random();

            matrix.Matrix = new int[Size, Size];

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    matrix.Matrix[ColIndex, RowIndex] = rand.Next(0, 9);
                }
            }
        }

        protected static void PrintOperations(
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
                    Console.Write("{0,4}", FirstMatrix.Matrix[ColIndex, RowIndex]);
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
                    Console.Write("{0,4}", SecondMatrix.Matrix[ColIndex, RowIndex]);
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
                    Console.Write("{0,4}", Result.Matrix[ColIndex, RowIndex]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        protected static void PrintOperations(
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
                    Console.Write("{0,4}", FirstMatrix.Matrix[ColIndex, RowIndex]);
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
                    Console.Write("{0,4}", SecondMatrix.Matrix[ColIndex, RowIndex]);
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
        protected static void PrintOperations(int[,] MainMatrix, int Result, string Operation)
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
        protected static void PrintOperations(int[,] MainMatrix, int[,] SecondMatrix, string Operation)
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
        protected static void PrintOperations(int[,] MainMatrix, Double[,] Inverse, string Operation)
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
    }
}
