namespace AirTravel
{
    partial class FormDelEdge
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
            this.cbEdge = new System.Windows.Forms.ComboBox();
            this.lbEdge = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEdge
            // 
            this.cbEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdge.FormattingEnabled = true;
            this.cbEdge.Location = new System.Drawing.Point(94, 12);
            this.cbEdge.Name = "cbEdge";
            this.cbEdge.Size = new System.Drawing.Size(182, 21);
            this.cbEdge.TabIndex = 12;
            // 
            // lbEdge
            // 
            this.lbEdge.AutoSize = true;
            this.lbEdge.Location = new System.Drawing.Point(12, 15);
            this.lbEdge.Name = "lbEdge";
            this.lbEdge.Size = new System.Drawing.Size(52, 13);
            this.lbEdge.TabIndex = 13;
            this.lbEdge.Text = "Маршрут";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 84);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(201, 84);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 15;
            this.btnCansel.Text = "Отменить";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // FormDelEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 119);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lbEdge);
            this.Controls.Add(this.cbEdge);
            this.Name = "FormDelEdge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить маршрут";
            this.Load += new System.EventHandler(this.FormDelEdge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox cbEdge;
        protected System.Windows.Forms.Label lbEdge;
        protected System.Windows.Forms.Button btnDel;
        protected System.Windows.Forms.Button btnCansel;
    }
}