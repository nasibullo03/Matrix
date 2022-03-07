using System;

namespace Task3OverloadingOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();

            SquareMatrix a = new SquareMatrix();
            SquareMatrix.Size = 5;
            SquareMatrix.FillAuto(a);
            Console.WriteLine();

            SquareMatrix b = new SquareMatrix();
            SquareMatrix.FillAuto(b);
            Console.WriteLine();

            SquareMatrix c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            bool eq;
            eq = a == b;
            eq = a != b;

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
