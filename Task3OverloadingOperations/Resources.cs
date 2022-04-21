using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

        #endregion Metods
    }
}