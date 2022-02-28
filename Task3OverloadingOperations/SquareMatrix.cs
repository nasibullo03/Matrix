using System;

namespace Task3OverloadingOperations
{
	public class SquareMatrix
	{
		public static int Size { get; set; }

		public int[,] Matrix;



		public SquareMatrix(){}
		public static SquareMatrix operator+(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					c.Matrix[i, j] = a.Matrix[i, j] + b.Matrix[i, j] ;
					//Console.Write("{0,4}",c.Matrix[i, j]);
				}
				//Console.WriteLine();
			}
			PrintOperations(a, b, "+", c);
			return c;

		}
		
		
		

		public static void FillMatrixAuto(SquareMatrix matrix)
		{
			Random rand = new Random();

			matrix.Matrix = new int[Size, Size];

			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					matrix.Matrix[i, j] = rand.Next(0, 9);
					//Console.Write("{0,4}",matrix.Matrix[i, j]);
				}
				//Console.WriteLine();
			}
			
		}
		
		private static void PrintOperations (SquareMatrix firstMatrix, SquareMatrix secondMatrix, string operation , SquareMatrix result) 
		{
			for (int rowIndex = 0; rowIndex < Size; ++rowIndex)
			{
				for (int firstMatrixIndex = 0; firstMatrixIndex < Size; ++firstMatrixIndex)
				{
					Console.Write("{0,4}",firstMatrix.Matrix[rowIndex, firstMatrixIndex]);
				}
				
				if(rowIndex == (int)Size/2)
				{
					Console.Write("{0,4}",operation);
				} else 
				{
					Console.Write("{0,4}","");
				}
				
				for (int SecondMatrixIndex = 0; SecondMatrixIndex < Size; ++SecondMatrixIndex)
				{
					Console.Write("{0,4}",result.Matrix[rowIndex, SecondMatrixIndex]);
				}
				
				if(rowIndex == (int)Size/2)
				{
					Console.Write("{0,4}","=");
				} else 
				{
					Console.Write("{0,4}","");
				}
				
				for (int ResultMatrixIndex = 0; ResultMatrixIndex < Size; ++ResultMatrixIndex)
				{
					Console.Write("{0,4}",result.Matrix[rowIndex, ResultMatrixIndex]);
				}
				
				Console.WriteLine();
			}
		}
		
		
	}
}
