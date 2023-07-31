namespace AirTravel
{
    partial class FormSettings
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
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblServerName = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbAdminPass = new System.Windows.Forms.TextBox();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.lblMngrPass = new System.Windows.Forms.Label();
            this.tbMngrLogin = new System.Windows.Forms.TextBox();
            this.lblMngrLogin = new System.Windows.Forms.Label();
            this.tbGuestPass = new System.Windows.Forms.TextBox();
            this.lblGuestPass = new System.Windows.Forms.Label();
            this.tbGuestLogin = new System.Windows.Forms.TextBox();
            this.lblGuestLogin = new System.Windows.Forms.Label();
            this.tbMngrPass = new System.Windows.Forms.TextBox();
            this.lblGuestPass2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveSettings.Location = new System.Drawing.Point(15, 184);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(12, 9);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(74, 13);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Имя сервера";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(197, 12);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(170, 20);
            this.tbServerName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(275, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbAdminPass
            // 
            this.tbAdminPass.Location = new System.Drawing.Point(197, 38);
            this.tbAdminPass.Name = "tbAdminPass";
            this.tbAdminPass.Size = new System.Drawing.Size(170, 20);
            this.tbAdminPass.TabIndex = 7;
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Location = new System.Drawing.Point(12, 35);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(132, 13);
            this.lblAdminPass.TabIndex = 6;
            this.lblAdminPass.Text = "Пароль администратора";
            // 
            // lblMngrPass
            // 
            this.lblMngrPass.AutoSize = true;
            this.lblMngrPass.Location = new System.Drawing.Point(12, 87);
            this.lblMngrPass.Name = "lblMngrPass";
            this.lblMngrPass.Size = new System.Drawing.Size(106, 13);
            this.lblMngrPass.TabIndex = 10;
            this.lblMngrPass.Text = "Пароль менеджера";
            // 
            // tbMngrLogin
            // 
            this.tbMngrLogin.Location = new System.Drawing.Point(197, 64);
            this.tbMngrLogin.Name = "tbMngrLogin";
            this.tbMngrLogin.Size = new System.Drawing.Size(170, 20);
            this.tbMngrLogin.TabIndex = 9;
            // 
            // lblMngrLogin
            // 
            this.lblMngrLogin.AutoSize = true;
            this.lblMngrLogin.Location = new System.Drawing.Point(12, 61);
            this.lblMngrLogin.Name = "lblMngrLogin";
            this.lblMngrLogin.Size = new System.Drawing.Size(99, 13);
            this.lblMngrLogin.TabIndex = 8;
            this.lblMngrLogin.Text = "Логин менеджера";
            // 
            // tbGuestPass
            // 
            this.tbGuestPass.Location = new System.Drawing.Point(197, 141);
            this.tbGuestPass.Name = "tbGuestPass";
            this.tbGuestPass.Size = new System.Drawing.Size(170, 20);
            this.tbGuestPass.TabIndex = 16;
            // 
            // lblGuestPass
            // 
            this.lblGuestPass.AutoSize = true;
            this.lblGuestPass.Location = new System.Drawing.Point(12, 138);
            this.lblGuestPass.Name = "lblGuestPass";
            this.lblGuestPass.Size = new System.Drawing.Size(76, 13);
            this.lblGuestPass.TabIndex = 15;
            this.lblGuestPass.Text = "Пароль гостя";
            // 
            // tbGuestLogin
            // 
            this.tbGuestLogin.Location = new System.Drawing.Point(197, 115);
            this.tbGuestLogin.Name = "tbGuestLogin";
            this.tbGuestLogin.Size = new System.Drawing.Size(170, 20);
            this.tbGuestLogin.TabIndex = 14;
            // 
            // lblGuestLogin
            // 
            this.lblGuestLogin.AutoSize = true;
            this.lblGuestLogin.Location = new System.Drawing.Point(12, 112);
            this.lblGuestLogin.Name = "lblGuestLogin";
            this.lblGuestLogin.Size = new System.Drawing.Size(69, 13);
            this.lblGuestLogin.TabIndex = 13;
            this.lblGuestLogin.Text = "Логин гостя";
            // 
            // tbMngrPass
            // 
            this.tbMngrPass.Location = new System.Drawing.Point(197, 89);
            this.tbMngrPass.Name = "tbMngrPass";
            this.tbMngrPass.Size = new System.Drawing.Size(170, 20);
            this.tbMngrPass.TabIndex = 12;
            // 
            // lblGuestPass2
            // 
            this.lblGuestPass2.AutoSize = true;
            this.lblGuestPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGuestPass2.Location = new System.Drawing.Point(12, 151);
            this.lblGuestPass2.Name = "lblGuestPass2";
            this.lblGuestPass2.Size = new System.Drawing.Size(115, 13);
            this.lblGuestPass2.TabIndex = 17;
            this.lblGuestPass2.Text = "(может быть пустным)";
            // 
            // FormSettingsServer
            // 
            this.AcceptButton = this.btnSaveSettings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(379, 215);
            this.Controls.Add(this.lblGuestPass2);
            this.Controls.Add(this.tbGuestPass);
            this.Controls.Add(this.lblGuestPass);
            this.Controls.Add(this.tbGuestLogin);
            this.Controls.Add(this.lblGuestLogin);
            this.Controls.Add(this.tbMngrPass);
            this.Controls.Add(this.lblMngrPass);
            this.Controls.Add(this.tbMngrLogin);
            this.Controls.Add(this.lblMngrLogin);
            this.Controls.Add(this.tbAdminPass);
            this.Controls.Add(this.lblAdminPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.btnSaveSettings);
            this.Name = "FormSettingsServer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSerringsServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbAdminPass;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.Label lblMngrPass;
        private System.Windows.Forms.TextBox tbMngrLogin;
        private System.Windows.Forms.Label lblMngrLogin;
        private System.Windows.Forms.TextBox tbGuestPass;
        private System.Windows.Forms.Label lblGuestPass;
        private System.Windows.Forms.TextBox tbGuestLogin;
        private System.Windows.Forms.Label lblGuestLogin;
        private System.Windows.Forms.TextBox tbMngrPass;
        private System.Windows.Forms.Label lblGuestPass2;
    }
}