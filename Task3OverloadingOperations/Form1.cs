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

namespace Task3OverloadingOperations
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
            ShowForm.form1 = this;
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
            if (Form1.ActiveForm.Size.Width >= 595 || Form1.ActiveForm.Size.Height >= 330)
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_SYSCOMMAND, DOSIZE, 0);
            }
            else
            {
                Form1.ActiveForm.Size = new Size(596, 331);
            }
        }

        
    }
}