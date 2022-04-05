using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Task3OverloadingOperations
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
            ShowForm.form1 = this;
            Matrix.MatrixA = new Matrix();
            Matrix.MatrixB = new Matrix();
        }

        #endregion Constructors

        #region Metods

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowForm.PerformOperation("Main");
            PanelValuesElementsParametrs();
        }

        private static void PanelValuesElementsParametrs()
        {
            Matrix.BrecketOpenPicture = new PictureBox();
            Matrix.BrecketOpenPicture.BackgroundImage = global::Task3OverloadingOperations.Properties.Resources.bracket_Open;
            Matrix.BrecketOpenPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Matrix.BrecketOpenPicture.Size = new System.Drawing.Size(20, 68);

            Matrix.BrecketClosePicture = new PictureBox();
            Matrix.BrecketClosePicture.BackgroundImage = global::Task3OverloadingOperations.Properties.Resources.bracket_Close;
            Matrix.BrecketClosePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Matrix.BrecketClosePicture.Size = new System.Drawing.Size(20, 68);

            Matrix.LblMatrixName = new Label();
            Matrix.LblMatrixName.AutoSize = true;
            Matrix.LblMatrixName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Matrix.LblMatrixName.ForeColor = System.Drawing.Color.Black;
            Matrix.LblMatrixName.Size = new System.Drawing.Size(42, 29);
            Matrix.LblMatrixName.Location = new Point(3, 3);
            Matrix.LblMatrixName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        public void ClearPannelFormValue()
        {
            this.PanelForms.Controls.Clear();
        }

        #endregion Metods

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal static extern bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal static extern bool ReleaseCapture();

        private const uint WM_SYSCOMMAND = 0x0112;
        private const uint DOMOVE = 0xF012;
        private const uint DOSIZE = 0xF008;

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            if (this.Size.Width >= 595 || this.Size.Height >= 330)
            {
                PostMessage(this.Handle, WM_SYSCOMMAND, DOSIZE, 0);
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width < 595)
            {
                this.Size = new Size(596, this.Size.Height);
            }
            if (this.Size.Height < 330)
            {
                this.Size = new Size(this.Size.Width, 330);
            }
        }
    }
}