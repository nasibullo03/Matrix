using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Task3OverloadingOperations
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Metods

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Matrix.MatrixA = new Matrix();
            Matrix.MatrixB = new Matrix();
            ShowForm.Form1 = this;
            ShowForm.PerformOperation("Main");
            MatrixForm.Main.FillOperations();

            PanelValuesElementsParametrs();
        }

        private static void PanelValuesElementsParametrs()
        {
            Matrix.BrecketOpenPicture = Resources.brecketOpen();

            Matrix.BrecketClosePicture = Resources.brecketClose();

            Matrix.LblMatrixName = Resources.lblMatrixName();

            ShowMatrixs.MatrixA_LblName = Resources.lblMatrixName();

            ShowMatrixs.MatrixB_LblName = Resources.lblMatrixName();
        }

        public void ClearPannelFormValue()
        {
            this.PanelForms.Controls.Clear();
        }

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

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            if (this.Size.Width >= 595 || this.Size.Height >= 330)
            {
                PostMessage(this.Handle, WM_SYSCOMMAND, DOSIZE, 0);
            }
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
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

        private void LblProgramName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        #endregion Metods
    }
}