using System;

namespace Task3OverloadingOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			SquareMatrix a = new SquareMatrix();
			SquareMatrix.Size = 4;
			SquareMatrix.FillAuto (a);
			Console.WriteLine();

			SquareMatrix b = new SquareMatrix();
			SquareMatrix.FillAuto (b);
			Console.WriteLine();

			// SquareMatrix c = a + b;
			// c = a - b;
			// c = a * b;
			// c = a / b;
			// bool eq;
			// eq = a == b;
			// eq = a != b;
			// c = a > b;
			// c = a < b;
			// c = a >= b;
			// c = a <= b;
			// c = a <= b;
			int hhh = 0;

			// Console.WriteLine($"Det={SquareMatrix.Determinant (a)}");
			// Console.WriteLine();
			// Console.WriteLine(a >= b);
			hhh = SquareMatrix.DeterminantOver3(a.Matrix);
			System.Console.WriteLine(hhh);

			Console.ReadLine();
		}
	}
}
