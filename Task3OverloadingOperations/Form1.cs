using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using Svg;

namespace Task3OverloadingOperations
{
    public partial class Form1 : Form
    {
        #region Constructors

        public static int WinHeight = 600;
        public static int WinWidth = 600;

        public Form1()
        {
            InitializeComponent();
            (new Task3OverloadingOperations.DropShadow()).ApplyShadows(this);
        }

        #endregion Constructors

        #region Metods

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PerformOperation.FillOperations();
            Matrix.MatrixA = new Matrix();
            Matrix.MatrixB = new Matrix();
            ShowForm.Form1 = this;
            ShowForm.PerformOperation("Main");

            PanelValuesElementsParametrs();

            MaximizeBtn.Location = new Point(CloseBtn.Location.X - MaximizeBtn.Width, CloseBtn.Location.Y);
            MinimizeBtn.Location = new Point(MaximizeBtn.Location.X - MinimizeBtn.Width, CloseBtn.Location.Y);
            LogoPictureBox.Location = new Point(0, 0);

            CloseBtn.BackgroundImage = Resources.CloseBtnPic();
            MaximizeBtn.BackgroundImage = Resources.MaximizeBtnPic();
            MinimizeBtn.BackgroundImage = Resources.MinimizeBtnPic();
            LogoPictureBox.BackgroundImage = Resources.LogoPic();
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

            PostMessage(this.Handle, WM_SYSCOMMAND, DOSIZE, 0);
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void LblProgramName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        #endregion Metods

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}