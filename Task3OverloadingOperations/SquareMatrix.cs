using System;

namespace Task3OverloadingOperations
{
    public class SquareMatrix
    {
        public string Name { get; set; }

        public static int Size { get; set; }

        public int GetMatrixSize
        {
            get
            {
                return MatrixValue.GetLength(0);
            }
        }

        public int[,] MatrixValue;

        public SquareMatrix()
        {
        }

        public static void FillAuto(SquareMatrix matrix)
        {
            FillMatrix.Fill(ref matrix, Size);
        }

        public SquareMatrix DeepCopy()
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

        public static SquareMatrix operator +(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            SquareMatrix TemproraryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size]
            };
            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = FirstMatrix.MatrixValue[ColIndex, RowIndex] + SecondMatrix.MatrixValue[ColIndex, RowIndex];
                }
            }
            return TemproraryMatrix;
        }

        public static SquareMatrix operator *(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            SquareMatrix TemproraryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size]
            };
            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = FirstMatrix.MatrixValue[ColIndex, RowIndex] * SecondMatrix.MatrixValue[ColIndex, RowIndex];
                }
            }

            return TemproraryMatrix;
        }

        public static SquareMatrix operator -(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            SquareMatrix TemproraryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size],
            };

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = FirstMatrix.MatrixValue[ColIndex, RowIndex] - SecondMatrix.MatrixValue[ColIndex, RowIndex];
                }
            }

            return TemproraryMatrix;
        }

        public static SquareMatrix operator /(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            SquareMatrix TemproraryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size]
            };

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    try
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = FirstMatrix.MatrixValue[ColIndex, RowIndex] / SecondMatrix.MatrixValue[ColIndex, RowIndex];
                    }
                    catch
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = 0;
                    }
                }
            }

            return TemproraryMatrix;
        }

        public static bool operator ==(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            int[,] MatrixA = FirstMatrix.MatrixValue;
            int[,] MatrixB = SecondMatrix.MatrixValue;

            if (MatrixA.GetLength(0) != MatrixB.GetLength(0))
            {
                return false;
            }
            if (MatrixA.GetLength(1) != MatrixB.GetLength(1))
            {
                return false;
            }

            for (int ColIndex = 0; ColIndex < MatrixA.GetLength(0); ColIndex++)
            {
                for (int RowIndex = 0; RowIndex < MatrixA.GetLength(1); RowIndex++)
                {
                    if (MatrixA[ColIndex, RowIndex] != MatrixB[ColIndex, RowIndex])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !=(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            int[,] MatrixA = FirstMatrix.MatrixValue;
            int[,] MatrixB = SecondMatrix.MatrixValue;

            if (MatrixA.GetLength(0) != MatrixB.GetLength(0))
            {
                return true;
            }
            if (MatrixA.GetLength(1) != MatrixB.GetLength(1))
            {
                return true;
            }

            for (int ColIndex = 0; ColIndex < MatrixA.GetLength(0); ColIndex++)
            {
                for (int RowIndex = 0; RowIndex < MatrixA.GetLength(1); RowIndex++)
                {
                    if (MatrixA[ColIndex, RowIndex] != MatrixB[ColIndex, RowIndex])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static SquareMatrix operator >(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            SquareMatrix TemproraryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size]
            };

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    if (FirstMatrix.MatrixValue[ColIndex, RowIndex] > SecondMatrix.MatrixValue[ColIndex, RowIndex])
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = 1;
                    }
                    else
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = 0;
                    }
                }
            }
            return TemproraryMatrix;
        }

        public static SquareMatrix operator <(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            SquareMatrix TemproraryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size]
            };

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    if (FirstMatrix.MatrixValue[ColIndex, RowIndex] < SecondMatrix.MatrixValue[ColIndex, RowIndex])
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = 1;
                    }
                    else
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = 0;
                    }
                }
            }
            return TemproraryMatrix;
        }

        public static SquareMatrix operator >=(SquareMatrix FirstMatrix, SquareMatrix SecondMAtrix)
        {
            SquareMatrix TemporaryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size]
            };

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    if (FirstMatrix.MatrixValue[ColIndex, RowIndex] >= SecondMAtrix.MatrixValue[ColIndex, RowIndex])
                    {
                        TemporaryMatrix.MatrixValue[ColIndex, RowIndex] = 1;
                    }
                    else
                    {
                        TemporaryMatrix.MatrixValue[ColIndex, RowIndex] = 0;
                    }
                }
            }
            return TemporaryMatrix;
        }

        public static SquareMatrix operator <=(SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            SquareMatrix TemproraryMatrix = new SquareMatrix()
            {
                MatrixValue = new int[Size, Size],
            };
            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    if (FirstMatrix.MatrixValue[ColIndex, RowIndex] <= SecondMatrix.MatrixValue[ColIndex, RowIndex])
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = 1;
                    }
                    else
                    {
                        TemproraryMatrix.MatrixValue[ColIndex, RowIndex] = 0;
                    }
                }
            }

            return TemproraryMatrix;
        }

        private static int Determinant3x3(int[,] MainMatrix)
        {
            int a = MainMatrix[0, 0],
                b = MainMatrix[0, 1],
                c = MainMatrix[0, 2],
                d = MainMatrix[1, 0],
                e = MainMatrix[1, 1],
                f = MainMatrix[1, 2],
                g = MainMatrix[2, 0],
                h = MainMatrix[2, 1],
                i = MainMatrix[2, 2];

            return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
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

        public static int FindDeterminant(int[,] MainMatrix, bool Print = true)
        {
            int det = default;
            int Size = MainMatrix.GetLength(0);
            if (Size == 2)
            {
                det = MainMatrix[0, 0] * MainMatrix[1, 1] - MainMatrix[1, 0] * MainMatrix[0, 1];
            }
            else if (Size == 3)
            {
                det = Determinant3x3(MainMatrix);
            }
            else if (Size > 3)
            {
                det = DeterminantOver3(MainMatrix);
            }

            return det;
        }

        public static int[,] FindTranspose(int[,] MainMatrix, bool Print = true)
        {
            int Size = MainMatrix.GetLength(0);
            int[,] Transpose = new int[Size, Size];

            for (int i = 0; i < Size; ++i)
            {
                for (int j = 0; j < Size; ++j)
                {
                    Transpose[i, j] = MainMatrix[j, i];
                }
            }

            return Transpose;
        }

        private static int[,] MinorOf3x3(int[,] MainMatrix)
        {
            /*
                | a11 a12 a13 |
            A =	| a21 a22 a23 |
                | a31 a32 a33 |

                        | a22 a23 |
            a11 = M11 =	| a32 a33 | = a22*a33 - a23*a32
            */
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

        private static int[,] MinorOf4x4(int[,] MainMatrix)
        {
            /*
                | a11 a12 a13 |
            A =	| a21 a22 a23 |
                | a31 a32 a33 |

                        | a22 a23 |
            a11 = M11 =	| a32 a33 | = a22*a33 - a23*a32
            */
            int Size = MainMatrix.GetLength(0);
            int[,] MinorMatrix = new int[Size, Size];

            return MinorMatrix;
        }

        public static int[,] FindMinor(int[,] MainMatrix, bool Print = true)
        {
            int Size = MainMatrix.GetLength(0);
            int[,] Minor = new int[Size, Size];

            if (Size == 2)
            {
                Minor[0, 0] = MainMatrix[1, 1];
                Minor[0, 1] = MainMatrix[1, 0];
                Minor[1, 0] = MainMatrix[0, 1];
                Minor[1, 1] = MainMatrix[0, 0];
            }
            else if (Size == 3)
            {
                Minor = MinorOf3x3(MainMatrix);
            }
            else if (Size > 3)
            {
                throw new IndexOutOfRangeException();
            }

            return Minor;
        }

        public static double[,] FindInverseMatrix(int[,] MainMatrix, bool Print = true)
        {
            int Size = MainMatrix.GetLength(0);
            double[,] Inverse = new double[Size, Size];
            int[,] Transpose = FindTranspose(MainMatrix, Print: false);
            int Determinant = FindDeterminant(MainMatrix, Print: false);
            double rr = Math.Round(1 / Convert.ToDouble(Determinant), 2);

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    Inverse[ColIndex, RowIndex] = Math.Round(Convert.ToDouble(Transpose[ColIndex, RowIndex]) * rr, 2);
                }
            }

            return Inverse;
        }
    }
}