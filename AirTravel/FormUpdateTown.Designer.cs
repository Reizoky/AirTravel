namespace AirTravel
{
    partial class FormUpdateTown
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCanсel = new System.Windows.Forms.Button();
            this.cbTown = new System.Windows.Forms.ComboBox();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(10, 140);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 13);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Информация";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Название*";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(89, 137);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(240, 117);
            this.tbInfo.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCanсel
            // 
            this.btnCanсel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanсel.Location = new System.Drawing.Point(254, 283);
            this.btnCanсel.Name = "btnCanсel";
            this.btnCanсel.Size = new System.Drawing.Size(75, 23);
            this.btnCanсel.TabIndex = 11;
            this.btnCanсel.Text = "Отменить";
            this.btnCanсel.UseVisualStyleBackColor = true;
            this.btnCanсel.Click += new System.EventHandler(this.btnCanсel_Click);
            // 
            // cbTown
            // 
            this.cbTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTown.FormattingEnabled = true;
            this.cbTown.Location = new System.Drawing.Point(89, 12);
            this.cbTown.Name = "cbTown";
            this.cbTown.Size = new System.Drawing.Size(121, 21);
            this.cbTown.TabIndex = 15;
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(89, 49);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 20);
            this.nudX.TabIndex = 16;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(89, 87);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(120, 20);
            this.nudY.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "X*";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(10, 51);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 13);
            this.lblX.TabIndex = 18;
            this.lblX.Text = "X*";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(10, 89);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 13);
            this.lblY.TabIndex = 19;
            this.lblY.Text = "Y*";
            // 
            // FormUpdateTown
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCanсel;
            this.ClientSize = new System.Drawing.Size(345, 321);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.cbTown);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCanсel);
            this.Name = "FormUpdateTown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить город";
            this.Load += new System.EventHandler(this.FormUpdateTown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCanсel;
        private System.Windows.Forms.ComboBox cbTown;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
    }
}