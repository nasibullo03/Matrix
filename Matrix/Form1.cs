using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        }

        #endregion Constructors

        #region Metods


        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PerformOperation.FillOperations();
            SquareMatrix.MatrixA = new SquareMatrix();
            SquareMatrix.MatrixB = new SquareMatrix();
            ShowForm.Form1 = this;
            ShowForm.PerformOperation("Main");

            PanelValuesElementsParametrs();

            MaximizeBtn.Location = new Point(CloseBtn.Location.X - MaximizeBtn.Width, CloseBtn.Location.Y);
            MinimizeBtn.Location = new Point(MaximizeBtn.Location.X - MinimizeBtn.Width, CloseBtn.Location.Y);
            LogoPictureBox.Location = new Point(10, 0);

            CloseBtn.BackgroundImage = Resources.CloseBtnPic();
            MaximizeBtn.BackgroundImage = Resources.MaximizeBtnPic();
            MinimizeBtn.BackgroundImage = Resources.MinimizeBtnPic();
            LogoPictureBox.BackgroundImage = Resources.LogoPic();

            ChangelblProgramName_Font(this);
        }

        private static void ChangelblProgramName_Font(Form1 form)
        {
            PrivateFontCollection myFont = new PrivateFontCollection();
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.Play_Bold))
            {
                var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] FontData = new byte[fontStream.Length];
                fontStream.Read(FontData, 0, (int)fontStream.Length);
                Marshal.Copy(FontData, 0, data, (int)fontStream.Length);
                myFont.AddMemoryFont(data, (int)fontStream.Length);
                Marshal.FreeCoTaskMem(data);
            }
            form.lblProgramName.Font = new Font(myFont.Families[0], 18, FontStyle.Bold);
            form.lblProgramName.UseCompatibleTextRendering = true;
        }

        private static void PanelValuesElementsParametrs()

        {
            SquareMatrix.BrecketOpenPicture = Resources.BrecketOpen();
            SquareMatrix.BrecketClosePicture = Resources.BrecketClose();
            SquareMatrix.LblMatrixName = Resources.LblMatrixName();
            ShowMatrixs.MatrixA_LblName = Resources.LblMatrixName();
            ShowMatrixs.MatrixB_LblName = Resources.LblMatrixName();
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

        private void LblProgramName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        #endregion Metods

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ControlPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}