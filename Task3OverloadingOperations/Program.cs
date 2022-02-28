using System;

namespace Task3OverloadingOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            SquareMatrix m = new SquareMatrix();
            SquareMatrix.Size = 5;
            m.FillMatrixAuto();

            Console.ReadKey();
        }
    }
}
