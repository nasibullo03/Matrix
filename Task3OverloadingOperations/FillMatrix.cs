using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3OverloadingOperations
{
    internal abstract class FillMatrix : Matrix
    {
        public static void Fill(ref SquareMatrix matrix, int Size)
        {
            Random rand = new Random();

            matrix.MatrixValue = new int[Size, Size];

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    matrix.MatrixValue[ColIndex, RowIndex] = rand.Next(0, 9);
                }
            }
        }

        public static void Fill(ref int[,] MatrixValue, int Size)
        {
            Random rand = new Random();

            MatrixValue = new int[Size, Size];

            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    MatrixValue[ColIndex, RowIndex] = rand.Next(0, 9);
                    //textBoxes[ColIndex, RowIndex].Text = MatrixValue[ColIndex, RowIndex].ToString();
                }
            }
        }

        public static void FillTextBoxesAuto()
        {
            Random rand = new Random();
            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    textBoxes[ColIndex, RowIndex].Text = rand.Next(0, 9).ToString();
                }
            }
        }

        public static void Fill(ref Matrix matrix)
        {
            matrix.MatrixValue = new int[Size, Size];
            for (int ColIndex = 0; ColIndex < Size; ++ColIndex)
            {
                for (int RowIndex = 0; RowIndex < Size; ++RowIndex)
                {
                    try
                    {
                        matrix.MatrixValue[ColIndex, RowIndex] = Convert.ToInt32(textBoxes[ColIndex, RowIndex].Text);
                    }
                    catch
                    {
                        matrix.MatrixValue[ColIndex, RowIndex] = 0;
                        textBoxes[ColIndex, RowIndex].Text = "0";
                    }
                }
            }
        }
    }
}