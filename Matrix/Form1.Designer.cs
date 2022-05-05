
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.DownEmptyPanel = new System.Windows.Forms.Panel();
            this.RightEmptyPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftEmptyPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.panelMain.SuspendLayout();
            this.RightEmptyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.ControlPanel.Controls.Add(this.LogoPictureBox);
            this.ControlPanel.Controls.Add(this.MinimizeBtn);
            this.ControlPanel.Controls.Add(this.MaximizeBtn);
            this.ControlPanel.Controls.Add(this.CloseBtn);
            this.ControlPanel.Controls.Add(this.lblProgramName);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.ForeColor = System.Drawing.Color.White;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(700, 49);
            this.ControlPanel.TabIndex = 0;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 2);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(59, 47);
            this.LogoPictureBox.TabIndex = 6;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeBtn.Location = new System.Drawing.Point(595, 2);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(26, 23);
            this.MinimizeBtn.TabIndex = 5;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBtn.Location = new System.Drawing.Point(642, 0);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(26, 23);
            this.MaximizeBtn.TabIndex = 4;
            this.MaximizeBtn.UseVisualStyleBackColor = false;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(674, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(208, 9);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(310, 33);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Квадратная матрица";
            this.lblProgramName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblProgramName_MouseDown);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.PanelForms);
            this.panelMain.Controls.Add(this.DownEmptyPanel);
            this.panelMain.Controls.Add(this.RightEmptyPanel);
            this.panelMain.Controls.Add(this.LeftEmptyPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(700, 351);
            this.panelMain.TabIndex = 1;
            // 
            // PanelForms
            // 
            this.PanelForms.AutoScroll = true;
            this.PanelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForms.Location = new System.Drawing.Point(20, 0);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(660, 331);
            this.PanelForms.TabIndex = 12;
            // 
            // DownEmptyPanel
            // 
            this.DownEmptyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.DownEmptyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownEmptyPanel.Location = new System.Drawing.Point(20, 331);
            this.DownEmptyPanel.Name = "DownEmptyPanel";
            this.DownEmptyPanel.Size = new System.Drawing.Size(660, 20);
            this.DownEmptyPanel.TabIndex = 9;
            // 
            // RightEmptyPanel
            // 
            this.RightEmptyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.RightEmptyPanel.Controls.Add(this.panel1);
            this.RightEmptyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightEmptyPanel.Location = new System.Drawing.Point(680, 0);
            this.RightEmptyPanel.Name = "RightEmptyPanel";
            this.RightEmptyPanel.Size = new System.Drawing.Size(20, 351);
            this.RightEmptyPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);

            // 
            // LeftEmptyPanel
            // 
            this.LeftEmptyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.LeftEmptyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftEmptyPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftEmptyPanel.Name = "LeftEmptyPanel";
            this.LeftEmptyPanel.Size = new System.Drawing.Size(20, 351);
            this.LeftEmptyPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.RightEmptyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Panel PanelForms;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        public System.Windows.Forms.Panel RightEmptyPanel;
        public System.Windows.Forms.Panel LeftEmptyPanel;
        public System.Windows.Forms.Panel DownEmptyPanel;
    }
}

