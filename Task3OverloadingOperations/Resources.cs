using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Svg;
using System.IO;
using System.Timers;

namespace Task3OverloadingOperations
{
    public static class Resources
    {
        #region Fields

        private static int PictureCount { get; set; }

        #endregion Fields

        #region Metods

        public static Label lblMatrixName()
        {
            return new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.Black,
                Size = new System.Drawing.Size(35, 29),
                Location = new Point(3, 3),
            };
        }

        public static Label Label()
        {
            return new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.Black,
                Location = new Point(3, 3),
            };
        }

        public static PictureBox brecketOpen()
        {
            return new PictureBox
            {
                BackgroundImage = global::Task3OverloadingOperations.Properties.Resources.bracket_Open,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(20, 68),
                Name = $"brecketOpen{PictureCount++}"
            };
        }

        public static PictureBox brecketClose()
        {
            return new PictureBox
            {
                BackgroundImage = global::Task3OverloadingOperations.Properties.Resources.bracket_Close,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(20, 68),
                Name = $"brecketOpen{PictureCount++}"
            };
        }

        public static Bitmap MaximizeBtnPic()
        {
            string path = Path.Combine(Environment.CurrentDirectory + @"\Resources\window-maximizeSvg.svg");
            SvgDocument svg = SvgDocument.Open(path);
            Bitmap bitmap = svg.Draw();
            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(y, x).A != 0)
                    {
                        bitmap.SetPixel(y, x, Color.White);
                    }
                }
            }

            return new Bitmap(bitmap, new Size(15, 15));
        }

        public static Bitmap MinimizeBtnPic()
        {
            string path = Path.Combine(Environment.CurrentDirectory + @"\Resources\window-minimizeSvg.svg");
            SvgDocument svg = SvgDocument.Open(path);
            Bitmap bitmap = svg.Draw();
            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(x, y).A != 0)
                    {
                        bitmap.SetPixel(x, y, Color.White);
                    }
                }
            }

            return new Bitmap(bitmap, new Size(15, 15));
        }

        public static Bitmap CloseBtnPic()
        {
            string path = Path.Combine(Environment.CurrentDirectory + @"\Resources\window-closeSvg.svg");
            SvgDocument svg = SvgDocument.Open(path);
            Bitmap bitmap = svg.Draw();
            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(x, y).A != 0)
                    {
                        bitmap.SetPixel(x, y, Color.White);
                    }
                }
            }

            return new Bitmap(bitmap, new Size(12, 12));
        }

        public static Bitmap LogoPic()
        {
            string path = Path.Combine(Environment.CurrentDirectory + @"\Resources\logoSvg.svg");
            SvgDocument svg = SvgDocument.Open(path);
            Bitmap bitmap = svg.Draw();

            Random random = new Random();

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(x, y).A != 0)
                    {
                        bitmap.SetPixel(x, y, Color.White);
                    }
                }
            }

            return new Bitmap(bitmap, new Size(40, 30));
        }

        #endregion Metods
    }
}