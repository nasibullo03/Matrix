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
			get
			{
				return size;
			}
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
			SquareMatrix clone = (SquareMatrix) this.MemberwiseClone();
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

		private static int Determinant3x3(int[,] m)
		{
			int det = default;
			int
				a = m[0, 0],
				b = m[0, 1],
				c = m[0, 2],
				d = m[1, 0],
				e = m[1, 1],
				f = m[1, 2],
				g = m[2, 0],
				h = m[2, 1],
				i = m[2, 2];

			det =
				a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
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

		public static int DeterminantOver3(int[,] MainMatrix)
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

			int
				DetSize = MainMatrix.GetLength(0) - 1,
				det = 0,
				RowIndex = 0,
				ColIndex = 0,
				MatIndex = MainMatrix.GetLength(0);

			int[,] DetMatrix = new int[DetSize, DetSize];

			for (int FirstColInd = 0; FirstColInd < MatIndex; ++FirstColInd)
			{
				for (
					int MatrixColumn = 1;
					MatrixColumn < MatIndex;
					++MatrixColumn
				)
				{
					for (int MatrixRow = 0; MatrixRow < MatIndex; ++MatrixRow)
					{
						if (MatrixRow == FirstColInd)
						{
							continue;
						}
						else
						{
							DetMatrix[ColIndex, RowIndex++] =
								MainMatrix[MatrixColumn, MatrixRow];
						}
					}
					RowIndex = 0;
					++ColIndex;
				}
				ColIndex = 0;
				RowIndex = 0;
				if (FirstColInd % 2 == 0)
				{
					det +=
						MainMatrix[0, FirstColInd] *
						DeterminantOver3(DetMatrix);
				}
				else if (FirstColInd % 2 == 1)
				{
					det -=
						MainMatrix[0, FirstColInd] *
						DeterminantOver3(DetMatrix);
				}

				DetMatrix = new int[DetSize, DetSize];
			}
			return det;
		}

		public static int Determinant(SquareMatrix m)
		{
			int det = default;

			if (Size == 2)
			{
				det =
					m.Matrix[0, 0] * m.Matrix[1, 1] -
					m.Matrix[1, 0] * m.Matrix[0, 1];
			}
			else if (Size == 3)
			{
				det = Determinant3x3(m.Matrix);
			}
			else if (Size > 3)
			{
				det = DeterminantOver3(m.Matrix);
			}
			return det;
		}
	}
}
