
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
            this.ClearMatrixValuesButton = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.PanelControllButtons = new System.Windows.Forms.Panel();
            this.MatrixSizeComboBox = new System.Windows.Forms.ComboBox();
            this.lblTextOfCBNameOFMatrix = new System.Windows.Forms.Label();
            this.MatrixNameComboBox = new System.Windows.Forms.ComboBox();
            this.FillAutoButton = new System.Windows.Forms.Button();
            this.lblSizeOfMatrixName = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelFillingMatrixs = new System.Windows.Forms.Panel();
            this.PanelMatrixValue = new System.Windows.Forms.Panel();
            this.PanelOperationButtons.SuspendLayout();
            this.PanelControllButtons.SuspendLayout();
            this.PanelFillingMatrixs.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOperationButtons
            // 
            this.PanelOperationButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.PanelOperationButtons.Controls.Add(this.ClearMatrixValuesButton);
            this.PanelOperationButtons.Controls.Add(this.ButtonClear);
            this.PanelOperationButtons.Controls.Add(this.ButtonAdd);
            this.PanelOperationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelOperationButtons.Location = new System.Drawing.Point(0, 265);
            this.PanelOperationButtons.Name = "PanelOperationButtons";
            this.PanelOperationButtons.Size = new System.Drawing.Size(571, 40);
            this.PanelOperationButtons.TabIndex = 17;
            // 
            // ClearMatrixValuesButton
            // 
            this.ClearMatrixValuesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearMatrixValuesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ClearMatrixValuesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ClearMatrixValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearMatrixValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearMatrixValuesButton.ForeColor = System.Drawing.Color.White;
            this.ClearMatrixValuesButton.Location = new System.Drawing.Point(215, 3);
            this.ClearMatrixValuesButton.Name = "ClearMatrixValuesButton";
            this.ClearMatrixValuesButton.Size = new System.Drawing.Size(143, 31);
            this.ClearMatrixValuesButton.TabIndex = 0;
            this.ClearMatrixValuesButton.Text = "Очистить матрицу";
            this.ClearMatrixValuesButton.UseVisualStyleBackColor = false;
            this.ClearMatrixValuesButton.Click += new System.EventHandler(this.ClearMatrixValuesButton_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(364, 3);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(143, 31);
            this.ButtonClear.TabIndex = 0;
            this.ButtonClear.Text = "Очистить все";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(66, 3);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(143, 31);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // PanelControllButtons
            // 
            this.PanelControllButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.PanelControllButtons.Controls.Add(this.MatrixSizeComboBox);
            this.PanelControllButtons.Controls.Add(this.lblTextOfCBNameOFMatrix);
            this.PanelControllButtons.Controls.Add(this.MatrixNameComboBox);
            this.PanelControllButtons.Controls.Add(this.FillAutoButton);
            this.PanelControllButtons.Controls.Add(this.lblSizeOfMatrixName);
            this.PanelControllButtons.Controls.Add(this.ButtonBack);
            this.PanelControllButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControllButtons.Location = new System.Drawing.Point(0, 0);
            this.PanelControllButtons.Name = "PanelControllButtons";
            this.PanelControllButtons.Size = new System.Drawing.Size(571, 40);
            this.PanelControllButtons.TabIndex = 16;
            // 
            // MatrixSizeComboBox
            // 
            this.MatrixSizeComboBox.FormattingEnabled = true;
            this.MatrixSizeComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.MatrixSizeComboBox.Location = new System.Drawing.Point(361, 11);
            this.MatrixSizeComboBox.Name = "MatrixSizeComboBox";
            this.MatrixSizeComboBox.Size = new System.Drawing.Size(51, 21);
            this.MatrixSizeComboBox.TabIndex = 4;
            this.MatrixSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.MatrixSizeComboBox_SelectedIndexChanged);
            this.MatrixSizeComboBox.TextChanged += new System.EventHandler(this.MatrixSizeComboBox_TextChanged);
            // 
            // lblTextOfCBNameOFMatrix
            // 
            this.lblTextOfCBNameOFMatrix.AutoSize = true;
            this.lblTextOfCBNameOFMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextOfCBNameOFMatrix.ForeColor = System.Drawing.Color.White;
            this.lblTextOfCBNameOFMatrix.Location = new System.Drawing.Point(69, 14);
            this.lblTextOfCBNameOFMatrix.Name = "lblTextOfCBNameOFMatrix";
            this.lblTextOfCBNameOFMatrix.Size = new System.Drawing.Size(118, 13);
            this.lblTextOfCBNameOFMatrix.TabIndex = 5;
            this.lblTextOfCBNameOFMatrix.Text = "Выберите матрицу";
            // 
            // MatrixNameComboBox
            // 
            this.MatrixNameComboBox.FormattingEnabled = true;
            this.MatrixNameComboBox.Items.AddRange(new object[] {
            "A",
            "B"});
            this.MatrixNameComboBox.Location = new System.Drawing.Point(193, 11);
            this.MatrixNameComboBox.Name = "MatrixNameComboBox";
            this.MatrixNameComboBox.Size = new System.Drawing.Size(51, 21);
            this.MatrixNameComboBox.TabIndex = 4;
            this.MatrixNameComboBox.TextChanged += new System.EventHandler(this.MatrixNameComboBox_TextChanged);
            // 
            // FillAutoButton
            // 
            this.FillAutoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.FillAutoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.FillAutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillAutoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillAutoButton.ForeColor = System.Drawing.Color.White;
            this.FillAutoButton.Location = new System.Drawing.Point(418, 5);
            this.FillAutoButton.Name = "FillAutoButton";
            this.FillAutoButton.Size = new System.Drawing.Size(125, 31);
            this.FillAutoButton.TabIndex = 3;
            this.FillAutoButton.Text = "Автозаполнение";
            this.FillAutoButton.UseVisualStyleBackColor = false;
            this.FillAutoButton.Click += new System.EventHandler(this.FillAutoButton_Click);
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
            // PanelFillingMatrixs
            // 
            this.PanelFillingMatrixs.AutoScroll = true;
            this.PanelFillingMatrixs.Controls.Add(this.PanelMatrixValue);
            this.PanelFillingMatrixs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFillingMatrixs.Location = new System.Drawing.Point(0, 40);
            this.PanelFillingMatrixs.Name = "PanelFillingMatrixs";
            this.PanelFillingMatrixs.Size = new System.Drawing.Size(571, 225);
            this.PanelFillingMatrixs.TabIndex = 18;
            // 
            // PanelMatrixValue
            // 
            this.PanelMatrixValue.AutoScroll = true;
            this.PanelMatrixValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMatrixValue.Location = new System.Drawing.Point(0, 0);
            this.PanelMatrixValue.Name = "PanelMatrixValue";
            this.PanelMatrixValue.Size = new System.Drawing.Size(571, 225);
            this.PanelMatrixValue.TabIndex = 6;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(571, 305);
            this.Controls.Add(this.PanelFillingMatrixs);
            this.Controls.Add(this.PanelOperationButtons);
            this.Controls.Add(this.PanelControllButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.PanelOperationButtons.ResumeLayout(false);
            this.PanelControllButtons.ResumeLayout(false);
            this.PanelControllButtons.PerformLayout();
            this.PanelFillingMatrixs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOperationButtons;
        private System.Windows.Forms.Panel PanelControllButtons;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label lblSizeOfMatrixName;
        public System.Windows.Forms.ComboBox MatrixNameComboBox;
        private System.Windows.Forms.Label lblTextOfCBNameOFMatrix;
        public System.Windows.Forms.Panel PanelFillingMatrixs;
        public System.Windows.Forms.ComboBox MatrixSizeComboBox;
        private System.Windows.Forms.Button ClearMatrixValuesButton;
        public System.Windows.Forms.Panel PanelMatrixValue;
        private System.Windows.Forms.Button FillAutoButton;
    }
}