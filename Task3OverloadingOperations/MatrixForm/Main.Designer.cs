
namespace Task3OverloadingOperations.MatrixForm
{
    partial class Main
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
            this.ButtonTranspose = new System.Windows.Forms.Button();
            this.ButtonMinor = new System.Windows.Forms.Button();
            this.ButtonDeterminant = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.PanelControllButtons = new System.Windows.Forms.Panel();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.PanelResult = new System.Windows.Forms.Panel();
            this.PanelOperationButtons.SuspendLayout();
            this.PanelControllButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOperationButtons
            // 
            this.PanelOperationButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.PanelOperationButtons.Controls.Add(this.ButtonTranspose);
            this.PanelOperationButtons.Controls.Add(this.ButtonMinor);
            this.PanelOperationButtons.Controls.Add(this.ButtonDeterminant);
            this.PanelOperationButtons.Controls.Add(this.ButtonDivision);
            this.PanelOperationButtons.Controls.Add(this.ButtonMultiply);
            this.PanelOperationButtons.Controls.Add(this.ButtonMinus);
            this.PanelOperationButtons.Controls.Add(this.ButtonPlus);
            this.PanelOperationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelOperationButtons.Location = new System.Drawing.Point(0, 272);
            this.PanelOperationButtons.Name = "PanelOperationButtons";
            this.PanelOperationButtons.Size = new System.Drawing.Size(474, 40);
            this.PanelOperationButtons.TabIndex = 14;
            // 
            // ButtonTranspose
            // 
            this.ButtonTranspose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonTranspose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonTranspose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonTranspose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTranspose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTranspose.ForeColor = System.Drawing.Color.White;
            this.ButtonTranspose.Location = new System.Drawing.Point(363, 6);
            this.ButtonTranspose.Name = "ButtonTranspose";
            this.ButtonTranspose.Size = new System.Drawing.Size(85, 30);
            this.ButtonTranspose.TabIndex = 6;
            this.ButtonTranspose.Text = "Transpose";
            this.ButtonTranspose.UseVisualStyleBackColor = false;
            this.ButtonTranspose.Click += new System.EventHandler(this.ButtonTranspose_Click);
            // 
            // ButtonMinor
            // 
            this.ButtonMinor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonMinor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonMinor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonMinor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinor.ForeColor = System.Drawing.Color.White;
            this.ButtonMinor.Location = new System.Drawing.Point(307, 6);
            this.ButtonMinor.Name = "ButtonMinor";
            this.ButtonMinor.Size = new System.Drawing.Size(50, 30);
            this.ButtonMinor.TabIndex = 5;
            this.ButtonMinor.Text = "Minor";
            this.ButtonMinor.UseVisualStyleBackColor = false;
            this.ButtonMinor.Click += new System.EventHandler(this.ButtonMinor_Click);
            // 
            // ButtonDeterminant
            // 
            this.ButtonDeterminant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDeterminant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonDeterminant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonDeterminant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDeterminant.ForeColor = System.Drawing.Color.White;
            this.ButtonDeterminant.Location = new System.Drawing.Point(251, 6);
            this.ButtonDeterminant.Name = "ButtonDeterminant";
            this.ButtonDeterminant.Size = new System.Drawing.Size(50, 30);
            this.ButtonDeterminant.TabIndex = 4;
            this.ButtonDeterminant.Text = "Det";
            this.ButtonDeterminant.UseVisualStyleBackColor = false;
            this.ButtonDeterminant.Click += new System.EventHandler(this.ButtonDeterminant_Click);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDivision.ForeColor = System.Drawing.Color.White;
            this.ButtonDivision.Location = new System.Drawing.Point(196, 6);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(50, 30);
            this.ButtonDivision.TabIndex = 4;
            this.ButtonDivision.Text = "/";
            this.ButtonDivision.UseVisualStyleBackColor = false;
            this.ButtonDivision.Click += new System.EventHandler(this.ButtonDivision_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMultiply.ForeColor = System.Drawing.Color.White;
            this.ButtonMultiply.Location = new System.Drawing.Point(140, 6);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(50, 30);
            this.ButtonMultiply.TabIndex = 1;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinus.ForeColor = System.Drawing.Color.White;
            this.ButtonMinus.Location = new System.Drawing.Point(84, 6);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(50, 30);
            this.ButtonMinus.TabIndex = 2;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlus.ForeColor = System.Drawing.Color.White;
            this.ButtonPlus.Location = new System.Drawing.Point(28, 6);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(50, 30);
            this.ButtonPlus.TabIndex = 3;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // PanelControllButtons
            // 
            this.PanelControllButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.PanelControllButtons.Controls.Add(this.ButtonClear);
            this.PanelControllButtons.Controls.Add(this.ButtonChange);
            this.PanelControllButtons.Controls.Add(this.ButtonAdd);
            this.PanelControllButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControllButtons.Location = new System.Drawing.Point(0, 0);
            this.PanelControllButtons.Name = "PanelControllButtons";
            this.PanelControllButtons.Size = new System.Drawing.Size(474, 40);
            this.PanelControllButtons.TabIndex = 13;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(285, 4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(90, 31);
            this.ButtonClear.TabIndex = 0;
            this.ButtonClear.Text = "Отчистить";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonChange
            // 
            this.ButtonChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChange.ForeColor = System.Drawing.Color.White;
            this.ButtonChange.Location = new System.Drawing.Point(189, 4);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(90, 31);
            this.ButtonChange.TabIndex = 0;
            this.ButtonChange.Text = "Изменить";
            this.ButtonChange.UseVisualStyleBackColor = false;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(93, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(90, 31);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // PanelResult
            // 
            this.PanelResult.AutoScroll = true;
            this.PanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResult.Location = new System.Drawing.Point(0, 40);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(474, 232);
            this.PanelResult.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(98)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(474, 312);
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.PanelOperationButtons);
            this.Controls.Add(this.PanelControllButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanelOperationButtons.ResumeLayout(false);
            this.PanelControllButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOperationButtons;
        private System.Windows.Forms.Button ButtonTranspose;
        private System.Windows.Forms.Button ButtonMinor;
        private System.Windows.Forms.Button ButtonDeterminant;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Panel PanelControllButtons;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Button ButtonAdd;
        public System.Windows.Forms.Panel PanelResult;
    }
}