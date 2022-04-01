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
        public Form1()
        {
            InitializeComponent();
        }

        #region Metods

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFormMain();
        }

        private void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            PanelForms.Controls.Add(form);
            form.Show();
        }

        private void ClearPannelFormValue()
        {
            PanelForms.Controls.Clear();
        }

        public void ShowFormAdd()
        {
            ClearPannelFormValue();
            ShowForm(new MatrixForm.Add());
        }

        public void ShowFormMain()
        {
            ClearPannelFormValue();
            ShowForm(new MatrixForm.Main());
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
    }
}