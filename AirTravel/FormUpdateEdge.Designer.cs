namespace AirTravel
{
    partial class FormUpdateEdge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateEdge));
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lbCost = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEdge
            // 
            this.cbEdge.ValueMember = "IDEdge";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(94, 65);
            // 
            // btnCansel
            // 
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(94, 39);
            this.nudCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(182, 20);
            this.nudCost.TabIndex = 18;
            this.nudCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(12, 41);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(62, 13);
            this.lbCost.TabIndex = 17;
            this.lbCost.Text = "Стоимость";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 83);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdateEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.lbCost);
            this.Name = "FormUpdateEdge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить маршрут";
            this.Load += new System.EventHandler(this.FormUpdateTownEdge_Load);
            this.Controls.SetChildIndex(this.cbEdge, 0);
            this.Controls.SetChildIndex(this.lbEdge, 0);
            this.Controls.SetChildIndex(this.btnDel, 0);
            this.Controls.SetChildIndex(this.btnCansel, 0);
            this.Controls.SetChildIndex(this.lbCost, 0);
            this.Controls.SetChildIndex(this.nudCost, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.NumericUpDown nudCost;
        protected System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Button btnUpdate;
    }
}