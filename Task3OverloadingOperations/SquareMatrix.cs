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
    }
}
