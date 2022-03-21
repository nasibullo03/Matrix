using System;
using System.Drawing;
using System.Numerics;

namespace Task3OverloadingOperations
{
	public class SquareMatrix : IMatrix
	{
		private static int size { get; set; }

		public static int Size
		{
			get { return size; }
			set
			{
				if (value < 1)
				{
					size = 1;
				}
				else
				{
					size = value;
				}
			}
		}

		public int[,] Matrix;

		public static void FillAuto(SquareMatrix matrix)
		{
			IMatrix.FillMatrix(ref matrix, Size);
		}

		public SquareMatrix Copy()
		{
			SquareMatrix clone = (SquareMatrix)this.MemberwiseClone();
			return clone;
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}

		public static SquareMatrix operator +(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					c.Matrix[i, j] = a.Matrix[i, j] + b.Matrix[i, j];
				}
			}
			IMatrix.PrintOperations(a, b, "+", c, Size);
			return c;
		}

		public static SquareMatrix operator *(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					c.Matrix[i, j] = a.Matrix[i, j] * b.Matrix[i, j];
				}
			}
			IMatrix.PrintOperations(a, b, "*", c, Size);
			return c;
		}

		public static SquareMatrix operator -(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					c.Matrix[i, j] = a.Matrix[i, j] - b.Matrix[i, j];
				}
			}
			IMatrix.PrintOperations(a, b, "-", c, Size);
			return c;
		}

		public static SquareMatrix operator /(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					try
					{
						c.Matrix[i, j] = a.Matrix[i, j] / b.Matrix[i, j];
					}
					catch
					{
						c.Matrix[i, j] = 0;
					}
				}
			}
			IMatrix.PrintOperations(a, b, "/", c, Size);
			return c;
		}

		public static bool operator ==(SquareMatrix a, SquareMatrix b)
		{
			int[,] arrA = a.Matrix;
			int[,] arrB = b.Matrix;

			if (arrA.GetLength(0) != arrB.GetLength(0))
			{
				IMatrix.PrintOperations(a, b, "==", false, Size);
				return false;
			}
			if (arrA.GetLength(1) != arrB.GetLength(1))
			{
				IMatrix.PrintOperations(a, b, "==", false, Size);
				return false;
			}

			for (int i = 0; i < arrA.GetLength(0); i++)
			{
				for (int j = 0; j < arrA.GetLength(1); j++)
				{
					if (arrA[i, j] != arrB[i, j])
					{
						IMatrix.PrintOperations(a, b, "==", false, Size);
						return false;
					}
				}
			}
			IMatrix.PrintOperations(a, b, "==", true, Size);
			return true;
		}

		public static bool operator !=(SquareMatrix a, SquareMatrix b)
		{
			int[,] arrA = a.Matrix;
			int[,] arrB = b.Matrix;

			if (arrA.GetLength(0) != arrB.GetLength(0))
			{
				IMatrix.PrintOperations(a, b, "!=", true, Size);
				return true;
			}
			if (arrA.GetLength(1) != arrB.GetLength(1))
			{
				IMatrix.PrintOperations(a, b, "!=", true, Size);
				return true;
			}

			for (int i = 0; i < arrA.GetLength(0); i++)
			{
				for (int j = 0; j < arrA.GetLength(1); j++)
				{
					if (arrA[i, j] != arrB[i, j])
					{
						IMatrix.PrintOperations(a, b, "!=", true, Size);
						return true;
					}
				}
			}
			IMatrix.PrintOperations(a, b, "!=", false, Size);
			return false;
		}

		public static SquareMatrix operator >(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					if (a.Matrix[i, j] > b.Matrix[i, j])
					{
						c.Matrix[i, j] = 1;
					}
					else
					{
						c.Matrix[i, j] = 0;
					}
				}
			}
			IMatrix.PrintOperations(a, b, ">", c, Size);
			return c;
		}

		public static SquareMatrix operator <(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					if (a.Matrix[i, j] < b.Matrix[i, j])
					{
						c.Matrix[i, j] = 1;
					}
					else
					{
						c.Matrix[i, j] = 0;
					}
				}
			}
			IMatrix.PrintOperations(a, b, "<", c, Size);
			return c;
		}

		public static SquareMatrix operator >=(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					if (a.Matrix[i, j] >= b.Matrix[i, j])
					{
						c.Matrix[i, j] = 1;
					}
					else
					{
						c.Matrix[i, j] = 0;
					}
				}
			}
			IMatrix.PrintOperations(a, b, ">=", c, Size);
			return c;
		}

		public static SquareMatrix operator <=(SquareMatrix a, SquareMatrix b)
		{
			SquareMatrix c = new SquareMatrix();
			c.Matrix = new int[Size, Size];
			for (int i = 0; i < Size; ++i)
			{
				for (int j = 0; j < Size; ++j)
				{
					if (a.Matrix[i, j] <= b.Matrix[i, j])
					{
						c.Matrix[i, j] = 1;
					}
					else
					{
						c.Matrix[i, j] = 0;
					}
				}
			}
			IMatrix.PrintOperations(a, b, "<=", c, Size);
			return c;
		}

		private static int Determinant3x3(int[,] MainMatrix)
		{
			int det = default;
			int a = MainMatrix[0, 0],
				b = MainMatrix[0, 1],
				c = MainMatrix[0, 2],
				d = MainMatrix[1, 0],
				e = MainMatrix[1, 1],
				f = MainMatrix[1, 2],
				g = MainMatrix[2, 0],
				h = MainMatrix[2, 1],
				i = MainMatrix[2, 2];

			det = a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
			return det;
		}

		private static int DeterminantOver3(int[,] MainMatrix)
		{
			/*
			a  b  c
			d  e  f 
			g  h  i
			
			|A| = a(ei − fh) − b(di − fg) + c(dh − eg)
			
			*/
			if (MainMatrix.GetLength(0) == 3)
			{
				return Determinant3x3(MainMatrix);
			}

			int DetSize = MainMatrix.GetLength(0) - 1,
				det = 0,
				RowIndex = 0,
				ColIndex = 0,
				MatIndex = MainMatrix.GetLength(0);

			int[,] DetMatrix = new int[DetSize, DetSize];

			for (int FirstColInd = 0; FirstColInd < MatIndex; ++FirstColInd)
			{
				for (int MatrixColumn = 1; MatrixColumn < MatIndex; ++MatrixColumn)
				{
					for (int MatrixRow = 0; MatrixRow < MatIndex; ++MatrixRow)
					{
						if (MatrixRow == FirstColInd)
						{
							continue;
						}
						else
						{
							DetMatrix[ColIndex, RowIndex++] = MainMatrix[MatrixColumn, MatrixRow];
						}
					}
					RowIndex = 0;
					++ColIndex;
				}
				ColIndex = 0;
				RowIndex = 0;
				if (FirstColInd % 2 == 0)
				{
					det += MainMatrix[0, FirstColInd] * DeterminantOver3(DetMatrix);
				}
				else if (FirstColInd % 2 == 1)
				{
					det -= MainMatrix[0, FirstColInd] * DeterminantOver3(DetMatrix);
				}

				DetMatrix = new int[DetSize, DetSize];
			}
			return det;
		}

		public static int FindDeterminant(int[,] MainMatrix)
		{
			int det = default;
			int MatrixSize = MainMatrix.GetLength(0);
			if (MatrixSize == 2)
			{
				det = MainMatrix[0, 0] * MainMatrix[1, 1] - MainMatrix[1, 0] * MainMatrix[0, 1];
			}
			else if (MatrixSize == 3)
			{
				det = Determinant3x3(MainMatrix);
			}
			else if (MatrixSize > 3)
			{
				det = DeterminantOver3(MainMatrix);
			}
			return det;
		}

		// TODO: pppp времменая операция  надо потом удалить
		public static void pppp(int[,] mm)
		{
			for (int i = 0; i < mm.GetLength(0); ++i)
			{
				for (int j = 0; j < mm.GetLength(0); ++j)
				{
					Console.Write("{0,4}", mm[i, j]);
				}
				System.Console.WriteLine();
			}
			System.Console.WriteLine();
		}

		public static int[,] FindTranspose(int[,] MainMatrix)
		{
			int MatrixSize = MainMatrix.GetLength(0);
			int[,] Transpose = new int[MatrixSize, MatrixSize];

			for (int i = 0; i < MatrixSize; ++i)
			{
				for (int j = 0; j < MatrixSize; ++j)
				{
					Transpose[i, j] = MainMatrix[j, i];
				}
			}

			return Transpose;
		}

		public static int[,] MinorOf3x3(int[,] MainMatrix)
		{
			/*
				| a11 a12 a13 | 
			A =	| a21 a22 a23 | 
				| a31 a32 a33 | 
			
						| a22 a23 | 
			a11 = M11 =	| a32 a33 | = a22*a33 - a23*a32
			*/
			int MatrixSize = MainMatrix.GetLength(0);

			int a11 = MainMatrix[0, 0],
				a12 = MainMatrix[0, 1],
				a13 = MainMatrix[0, 2],
				a21 = MainMatrix[1, 0],
				a22 = MainMatrix[1, 1],
				a23 = MainMatrix[1, 2],
				a31 = MainMatrix[2, 0],
				a32 = MainMatrix[2, 1],
				a33 = MainMatrix[2, 2];

			int M11 = a22 * a33 - a23 * a32,
				M12 = a21 * a33 - a23 * a31,
				M13 = a21 * a32 - a22 * a31,
				M21 = a12 * a33 - a13 * a32,
				M22 = a11 * a33 - a13 * a31,
				M23 = a11 * a32 - a12 * a31,
				M31 = a12 * a23 - a13 * a22,
				M32 = a11 * a23 - a13 * a21,
				M33 = a11 * a22 - a12 * a21;

			int[,] MinorMatrix = { { M11, M12, M13 }, { M21, M22, M23 }, { M31, M32, M33 } };

			return MinorMatrix;
		}

		private static int[,] MinorOver3(int[,] MainMatrix) { 
			int MatrixSize = MainMatrix.GetLength(0);
			int[,] Minor = new int[MatrixSize, MatrixSize];
			
			
		}
		public static int[,] FindMinor(int[,] MainMatrix)
		{
			int MatrixSize = MainMatrix.GetLength(0);
			int[,] Minor = new int[MatrixSize, MatrixSize];

			if (MatrixSize == 2)
			{
				Minor[0, 0] = MainMatrix[1, 1];
				Minor[0, 1] = MainMatrix[1, 0];
				Minor[1, 0] = MainMatrix[0, 1];
				Minor[1, 1] = MainMatrix[0, 0];
			}
			else if (MatrixSize == 3)
			{
				Minor = MinorOf3x3(MainMatrix);
			}
			else if (MatrixSize > 3)
			{
				Minor = MinorOver3(MainMatrix);
			}
			return Minor;
		}
		public static int[,] FindInverseMatrix(int[,] MainMatrix)
		{
			int MatrixSize = MainMatrix.GetLength(0);
			int[,] Inverse = new int[MatrixSize, MatrixSize],
				Transpose = FindTranspose(MainMatrix);
			int Determinant = FindDeterminant(MainMatrix);

			return Inverse;
		}
	}
}
