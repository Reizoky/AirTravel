namespace AirTravel
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblAllTables = new System.Windows.Forms.ToolStripLabel();
            this.cbAllTables = new System.Windows.Forms.ToolStripComboBox();
            this.btnTablePlus = new System.Windows.Forms.ToolStripButton();
            this.btnSqlQuerry = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnAdminConn = new System.Windows.Forms.ToolStripButton();
            this.lblAdminPass = new System.Windows.Forms.ToolStripLabel();
            this.tbAdminPass = new System.Windows.Forms.ToolStripTextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.tbSqlQuerry = new System.Windows.Forms.TextBox();
            this.btnDoSqlQuerry = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnDell = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAllTables,
            this.cbAllTables,
            this.btnTablePlus,
            this.btnSqlQuerry,
            this.btnSettings,
            this.btnAdminConn,
            this.lblAdminPass,
            this.tbAdminPass});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(792, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // lblAllTables
            // 
            this.lblAllTables.Name = "lblAllTables";
            this.lblAllTables.Size = new System.Drawing.Size(54, 22);
            this.lblAllTables.Text = "Таблица";
            // 
            // cbAllTables
            // 
            this.cbAllTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllTables.Name = "cbAllTables";
            this.cbAllTables.Size = new System.Drawing.Size(121, 25);
            this.cbAllTables.SelectedIndexChanged += new System.EventHandler(this.cbAllTables_SelectedIndexChanged);
            // 
            // btnTablePlus
            // 
            this.btnTablePlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTablePlus.Image = ((System.Drawing.Image)(resources.GetObject("btnTablePlus.Image")));
            this.btnTablePlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTablePlus.Name = "btnTablePlus";
            this.btnTablePlus.Size = new System.Drawing.Size(152, 22);
            this.btnTablePlus.Text = "Дополнительная таблица";
            this.btnTablePlus.Click += new System.EventHandler(this.btnTablePlus_Click);
            // 
            // btnSqlQuerry
            // 
            this.btnSqlQuerry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSqlQuerry.Image = ((System.Drawing.Image)(resources.GetObject("btnSqlQuerry.Image")));
            this.btnSqlQuerry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSqlQuerry.Name = "btnSqlQuerry";
            this.btnSqlQuerry.Size = new System.Drawing.Size(70, 22);
            this.btnSqlQuerry.Text = "Sql Запрос";
            this.btnSqlQuerry.Click += new System.EventHandler(this.btnSqlQuerry_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(71, 22);
            this.btnSettings.Text = "Настройки";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAdminConn
            // 
            this.btnAdminConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdminConn.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminConn.Image")));
            this.btnAdminConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdminConn.Name = "btnAdminConn";
            this.btnAdminConn.Size = new System.Drawing.Size(87, 22);
            this.btnAdminConn.Text = "Подлючиться";
            this.btnAdminConn.Click += new System.EventHandler(this.btnAdminConn_Click);
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(49, 22);
            this.lblAdminPass.Text = "Пароль";
            // 
            // tbAdminPass
            // 
            this.tbAdminPass.Name = "tbAdminPass";
            this.tbAdminPass.Size = new System.Drawing.Size(100, 25);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tbSqlQuerry);
            this.panel.Controls.Add(this.btnDoSqlQuerry);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 388);
            this.panel.TabIndex = 4;
            // 
            // tbSqlQuerry
            // 
            this.tbSqlQuerry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSqlQuerry.Location = new System.Drawing.Point(0, 0);
            this.tbSqlQuerry.Multiline = true;
            this.tbSqlQuerry.Name = "tbSqlQuerry";
            this.tbSqlQuerry.Size = new System.Drawing.Size(200, 356);
            this.tbSqlQuerry.TabIndex = 2;
            // 
            // btnDoSqlQuerry
            // 
            this.btnDoSqlQuerry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDoSqlQuerry.Location = new System.Drawing.Point(0, 356);
            this.btnDoSqlQuerry.Name = "btnDoSqlQuerry";
            this.btnDoSqlQuerry.Size = new System.Drawing.Size(200, 32);
            this.btnDoSqlQuerry.TabIndex = 1;
            this.btnDoSqlQuerry.Text = "Выполнить Sql команды";
            this.btnDoSqlQuerry.UseVisualStyleBackColor = true;
            this.btnDoSqlQuerry.Click += new System.EventHandler(this.btnDoSqlQuerry_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(200, 50);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(592, 363);
            this.dgv.TabIndex = 6;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // bn
            // 
            this.bn.AddNewItem = this.btnAdd;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = this.btnDell;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnDell,
            this.btnSave,
            this.btnUpdate});
            this.bn.Location = new System.Drawing.Point(200, 25);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(592, 25);
            this.bn.TabIndex = 5;
            this.bn.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // btnDell
            // 
            this.btnDell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDell.Image = ((System.Drawing.Image)(resources.GetObject("btnDell.Image")));
            this.btnDell.Name = "btnDell";
            this.btnDell.RightToLeftAutoMirrorImage = true;
            this.btnDell.Size = new System.Drawing.Size(23, 22);
            this.btnDell.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 22);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 22);
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 413);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormAdmin";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ToolStripButton btnTablePlus;
        protected System.Windows.Forms.ToolStrip toolStrip;
        protected System.Windows.Forms.ToolStripLabel lblAllTables;
        protected System.Windows.Forms.ToolStripComboBox cbAllTables;
        protected System.Windows.Forms.BindingSource bs;
        protected System.Windows.Forms.ToolStripButton btnSettings;
        protected System.Windows.Forms.ToolStripButton btnAdminConn;
        protected System.Windows.Forms.DataGridView dgv;
        protected System.Windows.Forms.BindingNavigator bn;
        protected System.Windows.Forms.ToolStripButton btnAdd;
        protected System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        protected System.Windows.Forms.ToolStripButton btnDell;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        protected System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        protected System.Windows.Forms.ToolStripButton btnSave;
        protected System.Windows.Forms.ToolStripButton btnUpdate;
        protected System.Windows.Forms.TextBox tbSqlQuerry;
        protected System.Windows.Forms.Button btnDoSqlQuerry;
        protected System.Windows.Forms.ToolStripButton btnSqlQuerry;
        protected System.Windows.Forms.Panel panel;
        protected System.Windows.Forms.ToolStripLabel lblAdminPass;
        protected System.Windows.Forms.ToolStripTextBox tbAdminPass;
    }
}