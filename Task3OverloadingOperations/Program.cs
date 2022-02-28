using System;

namespace Task3OverloadingOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			SquareMatrix a = new SquareMatrix();
			SquareMatrix.Size = 5;
			SquareMatrix.FillMatrixAuto (a);
			Console.WriteLine();

			SquareMatrix b = new SquareMatrix();
			SquareMatrix.FillMatrixAuto (b);
			Console.WriteLine();

			SquareMatrix c = a + b;
			c = a - b;
			c = a * b;
			c = a / b;
			

			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
