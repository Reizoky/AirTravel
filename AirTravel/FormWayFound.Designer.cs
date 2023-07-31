namespace AirTravel
{
    partial class FormWayFound
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
            this.cbActualPeak = new System.Windows.Forms.ComboBox();
            this.lblActualPeak = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLastPeak = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnWayFound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbActualPeak
            // 
            this.cbActualPeak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActualPeak.FormattingEnabled = true;
            this.cbActualPeak.Location = new System.Drawing.Point(60, 12);
            this.cbActualPeak.Name = "cbActualPeak";
            this.cbActualPeak.Size = new System.Drawing.Size(129, 21);
            this.cbActualPeak.TabIndex = 0;
            // 
            // lblActualPeak
            // 
            this.lblActualPeak.AutoSize = true;
            this.lblActualPeak.Location = new System.Drawing.Point(11, 15);
            this.lblActualPeak.Name = "lblActualPeak";
            this.lblActualPeak.Size = new System.Drawing.Size(43, 13);
            this.lblActualPeak.TabIndex = 1;
            this.lblActualPeak.Text = "Откуда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Куда";
            // 
            // cbLastPeak
            // 
            this.cbLastPeak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLastPeak.FormattingEnabled = true;
            this.cbLastPeak.Location = new System.Drawing.Point(244, 12);
            this.cbLastPeak.Name = "cbLastPeak";
            this.cbLastPeak.Size = new System.Drawing.Size(129, 21);
            this.cbLastPeak.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnWayFound
            // 
            this.btnWayFound.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnWayFound.Location = new System.Drawing.Point(12, 70);
            this.btnWayFound.Name = "btnWayFound";
            this.btnWayFound.Size = new System.Drawing.Size(92, 23);
            this.btnWayFound.TabIndex = 16;
            this.btnWayFound.Text = "Построить";
            this.btnWayFound.UseVisualStyleBackColor = true;
            this.btnWayFound.Click += new System.EventHandler(this.btnWayFound_Click);
            // 
            // FormWayFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 109);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWayFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLastPeak);
            this.Controls.Add(this.lblActualPeak);
            this.Controls.Add(this.cbActualPeak);
            this.Name = "FormWayFound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Построить маршркт";
            this.Load += new System.EventHandler(this.FormWayFound_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbActualPeak;
        private System.Windows.Forms.Label lblActualPeak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLastPeak;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnWayFound;
    }
}