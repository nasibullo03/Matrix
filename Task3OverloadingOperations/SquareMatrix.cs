using System;

namespace Task3OverloadingOperations
{
    public class SquareMatrix
    {
        public static int Size { get; set; }

        public int[,] Matrix;

        public SquareMatrix(int size)
        {
            Size = size;
        }

        public SquareMatrix()
        {
        }

        public void FillMatrixAuto()
        {
            Random rand = new Random();

            Matrix = new int[Size, Size];

            for (int i = 0; i < Size; ++i)
            {
                for (int j = 0; j < Size; ++j)
                {
                    Matrix[i, j] = rand.Next(0, 9);
                    //Console.Write(Matrix[i, j] + "  ");
                }
                //Console.WriteLine();
            }
        }
    }
}
