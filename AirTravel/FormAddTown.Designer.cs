namespace AirTravel
{
    partial class FormAddTown
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
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCanсel = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(100, 12);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 0;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(21, 15);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(47, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Страна*";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 2;
            // 
            // btnCanсel
            // 
            this.btnCanсel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanсel.Location = new System.Drawing.Point(265, 232);
            this.btnCanсel.Name = "btnCanсel";
            this.btnCanсel.Size = new System.Drawing.Size(75, 23);
            this.btnCanсel.TabIndex = 3;
            this.btnCanсel.Text = "Отменить";
            this.btnCanсel.UseVisualStyleBackColor = true;
            this.btnCanсel.Click += new System.EventHandler(this.btnCanсel_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(100, 86);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(240, 117);
            this.tbInfo.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Название*";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(21, 89);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Информация";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddTown
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCanсel;
            this.ClientSize = new System.Drawing.Size(385, 265);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCanсel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cbCountry);
            this.Name = "FormAddTown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить город";
            this.Load += new System.EventHandler(this.FormAddTown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCanсel;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdd;
    }
}