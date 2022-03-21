using System;

namespace Task3OverloadingOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			SquareMatrix a = new SquareMatrix();
			SquareMatrix.Size = 3;
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
			int hhh = default;

			// Console.WriteLine($"Det={SquareMatrix.Determinant (a)}");
			// Console.WriteLine();
			// Console.WriteLine(a >= b);
			// hhh = SquareMatrix.FindDeterminant(a.Matrix);
			// System.Console.WriteLine(hhh);
			int [,] iiii = SquareMatrix.FindMinor(a.Matrix);
			System.Console.WriteLine();
			Console.ReadLine();
		}
	}
}
