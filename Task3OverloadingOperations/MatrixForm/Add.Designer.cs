
namespace Task3OverloadingOperations.MatrixForm
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelOperationButtons = new System.Windows.Forms.Panel();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.PanelControllButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btmFillAuto = new System.Windows.Forms.Button();
            this.lblSizeOfMatrixName = new System.Windows.Forms.Label();
            this.MatrixSizeTextBox = new System.Windows.Forms.TextBox();
            this.PanelFillingMatrixs = new System.Windows.Forms.Panel();
            this.PanelMatrixValue = new System.Windows.Forms.Panel();
            this.PanelMatrixName = new System.Windows.Forms.Panel();
            this.lblMatrixName = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelOperationButtons.SuspendLayout();
            this.PanelControllButtons.SuspendLayout();
            this.PanelFillingMatrixs.SuspendLayout();
            this.PanelMatrixName.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOperationButtons
            // 
            this.PanelOperationButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.PanelOperationButtons.Controls.Add(this.ButtonClear);
            this.PanelOperationButtons.Controls.Add(this.ButtonAdd);
            this.PanelOperationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelOperationButtons.Location = new System.Drawing.Point(0, 221);
            this.PanelOperationButtons.Name = "PanelOperationButtons";
            this.PanelOperationButtons.Size = new System.Drawing.Size(555, 40);
            this.PanelOperationButtons.TabIndex = 17;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(289, 4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(90, 31);
            this.ButtonClear.TabIndex = 0;
            this.ButtonClear.Text = "Отчистить";
            this.ButtonClear.UseVisualStyleBackColor = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(193, 3);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(90, 31);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // PanelControllButtons
            // 
            this.PanelControllButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.PanelControllButtons.Controls.Add(this.label1);
            this.PanelControllButtons.Controls.Add(this.comboBox1);
            this.PanelControllButtons.Controls.Add(this.btmFillAuto);
            this.PanelControllButtons.Controls.Add(this.lblSizeOfMatrixName);
            this.PanelControllButtons.Controls.Add(this.MatrixSizeTextBox);
            this.PanelControllButtons.Controls.Add(this.ButtonBack);
            this.PanelControllButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControllButtons.Location = new System.Drawing.Point(0, 0);
            this.PanelControllButtons.Name = "PanelControllButtons";
            this.PanelControllButtons.Size = new System.Drawing.Size(555, 40);
            this.PanelControllButtons.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите матрицу";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox1.Location = new System.Drawing.Point(193, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // btmFillAuto
            // 
            this.btmFillAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.btmFillAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.btmFillAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmFillAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btmFillAuto.ForeColor = System.Drawing.Color.White;
            this.btmFillAuto.Location = new System.Drawing.Point(418, 5);
            this.btmFillAuto.Name = "btmFillAuto";
            this.btmFillAuto.Size = new System.Drawing.Size(125, 31);
            this.btmFillAuto.TabIndex = 3;
            this.btmFillAuto.Text = "Автозаполнение";
            this.btmFillAuto.UseVisualStyleBackColor = false;
            // 
            // lblSizeOfMatrixName
            // 
            this.lblSizeOfMatrixName.AutoSize = true;
            this.lblSizeOfMatrixName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeOfMatrixName.ForeColor = System.Drawing.Color.White;
            this.lblSizeOfMatrixName.Location = new System.Drawing.Point(250, 14);
            this.lblSizeOfMatrixName.Name = "lblSizeOfMatrixName";
            this.lblSizeOfMatrixName.Size = new System.Drawing.Size(108, 13);
            this.lblSizeOfMatrixName.TabIndex = 2;
            this.lblSizeOfMatrixName.Text = "Размер матрицы";
            // 
            // MatrixSizeTextBox
            // 
            this.MatrixSizeTextBox.Location = new System.Drawing.Point(364, 11);
            this.MatrixSizeTextBox.Name = "MatrixSizeTextBox";
            this.MatrixSizeTextBox.Size = new System.Drawing.Size(48, 20);
            this.MatrixSizeTextBox.TabIndex = 1;
            this.MatrixSizeTextBox.TextChanged += new System.EventHandler(this.MatrixSizeTextBox_TextChanged);
            // 
            // PanelFillingMatrixs
            // 
            this.PanelFillingMatrixs.AutoScroll = true;
            this.PanelFillingMatrixs.Controls.Add(this.PanelMatrixValue);
            this.PanelFillingMatrixs.Controls.Add(this.PanelMatrixName);
            this.PanelFillingMatrixs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFillingMatrixs.Location = new System.Drawing.Point(0, 40);
            this.PanelFillingMatrixs.Name = "PanelFillingMatrixs";
            this.PanelFillingMatrixs.Size = new System.Drawing.Size(555, 181);
            this.PanelFillingMatrixs.TabIndex = 18;
            // 
            // PanelMatrixValue
            // 
            this.PanelMatrixValue.AutoScroll = true;
            this.PanelMatrixValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMatrixValue.Location = new System.Drawing.Point(41, 0);
            this.PanelMatrixValue.Name = "PanelMatrixValue";
            this.PanelMatrixValue.Size = new System.Drawing.Size(514, 181);
            this.PanelMatrixValue.TabIndex = 1;
            // 
            // PanelMatrixName
            // 
            this.PanelMatrixName.Controls.Add(this.lblMatrixName);
            this.PanelMatrixName.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMatrixName.Location = new System.Drawing.Point(0, 0);
            this.PanelMatrixName.Name = "PanelMatrixName";
            this.PanelMatrixName.Size = new System.Drawing.Size(41, 181);
            this.PanelMatrixName.TabIndex = 0;
            // 
            // lblMatrixName
            // 
            this.lblMatrixName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatrixName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMatrixName.ForeColor = System.Drawing.Color.White;
            this.lblMatrixName.Location = new System.Drawing.Point(0, 0);
            this.lblMatrixName.Name = "lblMatrixName";
            this.lblMatrixName.Size = new System.Drawing.Size(41, 181);
            this.lblMatrixName.TabIndex = 0;
            this.lblMatrixName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackgroundImage = global::Task3OverloadingOperations.Properties.Resources.back_image_20px20px;
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Location = new System.Drawing.Point(0, 0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(41, 40);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.PanelFillingMatrixs);
            this.Controls.Add(this.PanelOperationButtons);
            this.Controls.Add(this.PanelControllButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.Text = "Add";
            this.PanelOperationButtons.ResumeLayout(false);
            this.PanelControllButtons.ResumeLayout(false);
            this.PanelControllButtons.PerformLayout();
            this.PanelFillingMatrixs.ResumeLayout(false);
            this.PanelMatrixName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOperationButtons;
        private System.Windows.Forms.Panel PanelControllButtons;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TextBox MatrixSizeTextBox;
        private System.Windows.Forms.Label lblSizeOfMatrixName;
        private System.Windows.Forms.Button btmFillAuto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelFillingMatrixs;
        private System.Windows.Forms.Panel PanelMatrixName;
        private System.Windows.Forms.Label lblMatrixName;
        private System.Windows.Forms.Panel PanelMatrixValue;
    }
}