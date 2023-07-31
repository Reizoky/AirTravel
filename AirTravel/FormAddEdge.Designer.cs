namespace AirTravel
{
    partial class FormAddEdge
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
            this.lbCost = new System.Windows.Forms.Label();
            this.gbTowns = new System.Windows.Forms.GroupBox();
            this.cbTown2 = new System.Windows.Forms.ComboBox();
            this.cbTown1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.gbTowns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(15, 88);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(62, 13);
            this.lbCost.TabIndex = 12;
            this.lbCost.Text = "Стоимость";
            // 
            // gbTowns
            // 
            this.gbTowns.Controls.Add(this.cbTown2);
            this.gbTowns.Controls.Add(this.cbTown1);
            this.gbTowns.Location = new System.Drawing.Point(12, 12);
            this.gbTowns.Name = "gbTowns";
            this.gbTowns.Size = new System.Drawing.Size(268, 56);
            this.gbTowns.TabIndex = 13;
            this.gbTowns.TabStop = false;
            this.gbTowns.Text = "Города";
            // 
            // cbTown2
            // 
            this.cbTown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTown2.FormattingEnabled = true;
            this.cbTown2.Location = new System.Drawing.Point(141, 19);
            this.cbTown2.Name = "cbTown2";
            this.cbTown2.Size = new System.Drawing.Size(121, 21);
            this.cbTown2.TabIndex = 12;
            // 
            // cbTown1
            // 
            this.cbTown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTown1.FormattingEnabled = true;
            this.cbTown1.Location = new System.Drawing.Point(6, 19);
            this.cbTown1.Name = "cbTown1";
            this.cbTown1.Size = new System.Drawing.Size(121, 21);
            this.cbTown1.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(182, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(18, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(84, 88);
            this.nudCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(120, 20);
            this.nudCost.TabIndex = 16;
            this.nudCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormAddEdge
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(292, 154);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbTowns);
            this.Controls.Add(this.lbCost);
            this.Name = "FormAddEdge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить маршрут";
            this.Load += new System.EventHandler(this.FormAddEdge_Load);
            this.gbTowns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lbCost;
        protected System.Windows.Forms.GroupBox gbTowns;
        protected System.Windows.Forms.ComboBox cbTown2;
        protected System.Windows.Forms.ComboBox cbTown1;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.NumericUpDown nudCost;
    }
}