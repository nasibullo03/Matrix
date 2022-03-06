namespace Task3OverloadingOperations
{
	public class SquareMatrix : IMatrix
	{
		private static int size{get;set;}
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
	}
}
