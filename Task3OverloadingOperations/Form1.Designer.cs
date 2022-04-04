
namespace Task3OverloadingOperations
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.DownEmptyPanel = new System.Windows.Forms.Panel();
            this.RightEmptyPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftEmptyPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.RightEmptyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.ControlPanel.Controls.Add(this.CloseBtn);
            this.ControlPanel.Controls.Add(this.lblProgramName);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.ForeColor = System.Drawing.Color.White;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(595, 49);
            this.ControlPanel.TabIndex = 0;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(569, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProgramName.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(236, 2);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(130, 44);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Matrix";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.panelMain.Controls.Add(this.PanelForms);
            this.panelMain.Controls.Add(this.DownEmptyPanel);
            this.panelMain.Controls.Add(this.RightEmptyPanel);
            this.panelMain.Controls.Add(this.LeftEmptyPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(595, 281);
            this.panelMain.TabIndex = 1;
            // 
            // PanelForms
            // 
            this.PanelForms.AutoScroll = true;
            this.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForms.Location = new System.Drawing.Point(20, 0);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(555, 261);
            this.PanelForms.TabIndex = 12;
            // 
            // DownEmptyPanel
            // 
            this.DownEmptyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.DownEmptyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownEmptyPanel.Location = new System.Drawing.Point(20, 261);
            this.DownEmptyPanel.Name = "DownEmptyPanel";
            this.DownEmptyPanel.Size = new System.Drawing.Size(555, 20);
            this.DownEmptyPanel.TabIndex = 9;
            // 
            // RightEmptyPanel
            // 
            this.RightEmptyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.RightEmptyPanel.Controls.Add(this.panel1);
            this.RightEmptyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightEmptyPanel.Location = new System.Drawing.Point(575, 0);
            this.RightEmptyPanel.Name = "RightEmptyPanel";
            this.RightEmptyPanel.Size = new System.Drawing.Size(20, 281);
            this.RightEmptyPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // LeftEmptyPanel
            // 
            this.LeftEmptyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.LeftEmptyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftEmptyPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftEmptyPanel.Name = "LeftEmptyPanel";
            this.LeftEmptyPanel.Size = new System.Drawing.Size(20, 281);
            this.LeftEmptyPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(595, 330);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ControlPanel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.RightEmptyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Panel PanelForms;
        private System.Windows.Forms.Panel LeftEmptyPanel;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel DownEmptyPanel;
        private System.Windows.Forms.Panel RightEmptyPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

