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

            for (int i = 0; i < Size; ++i)
            {
                for (int j = 0; j < Size; ++j)
                {
                    matrix.Matrix[i, j] = rand.Next(0, 9);   
                }
            }
        }

        protected static void PrintOperations(
            SquareMatrix firstMatrix,
            SquareMatrix secondMatrix,
            string operation,
            SquareMatrix result,
            int size
        )
        {
            for (int rowIndex = 0; rowIndex < size; ++rowIndex)
            {
                for (int firstMatrixIndex = 0; firstMatrixIndex < size; ++firstMatrixIndex)
                {
                    Console.Write("{0,4}", firstMatrix.Matrix[rowIndex, firstMatrixIndex]);
                }

                if (rowIndex == (int)size / 2)
                {
                    Console.Write("{0,4}", operation);
                }
                else
                {
                    Console.Write("{0,4}", "");
                }

                for (int SecondMatrixIndex = 0; SecondMatrixIndex < size; ++SecondMatrixIndex)
                {
                    Console.Write("{0,4}", result.Matrix[rowIndex, SecondMatrixIndex]);
                }

                if (rowIndex == (int)size / 2)
                {
                    Console.Write("{0,4}", "=");
                }
                else
                {
                    Console.Write("{0,4}", "");
                }

                for (int ResultMatrixIndex = 0; ResultMatrixIndex < size; ++ResultMatrixIndex)
                {
                    Console.Write("{0,4}", result.Matrix[rowIndex, ResultMatrixIndex]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
