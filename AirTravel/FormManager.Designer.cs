namespace AirTravel
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.ts = new System.Windows.Forms.ToolStrip();
            this.btnWayFound = new System.Windows.Forms.ToolStripButton();
            this.ddViews = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnReport1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddEdge = new System.Windows.Forms.ToolStripButton();
            this.btnDelEdge = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateEdge = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.tbFind = new System.Windows.Forms.ToolStripTextBox();
            this.btnSavePath = new System.Windows.Forms.ToolStripButton();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.contextMenuButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateTown = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelTown = new System.Windows.Forms.ToolStripMenuItem();
            this.ts.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.contextMenuButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWayFound,
            this.ddViews,
            this.btnAddEdge,
            this.btnDelEdge,
            this.btnUpdateEdge,
            this.btnFind,
            this.tbFind,
            this.btnSavePath,
            this.btnInfo});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(912, 25);
            this.ts.TabIndex = 1;
            this.ts.Text = "toolStrip1";
            // 
            // btnWayFound
            // 
            this.btnWayFound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWayFound.Image = ((System.Drawing.Image)(resources.GetObject("btnWayFound.Image")));
            this.btnWayFound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWayFound.Name = "btnWayFound";
            this.btnWayFound.Size = new System.Drawing.Size(124, 22);
            this.btnWayFound.Text = "Построить маршрут";
            this.btnWayFound.Click += new System.EventHandler(this.btnWayFound_Click);
            // 
            // ddViews
            // 
            this.ddViews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddViews.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReport1,
            this.btnReport2,
            this.btnReport3});
            this.ddViews.Image = ((System.Drawing.Image)(resources.GetObject("ddViews.Image")));
            this.ddViews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddViews.Name = "ddViews";
            this.ddViews.Size = new System.Drawing.Size(61, 22);
            this.ddViews.Text = "Отчеты";
            // 
            // btnReport1
            // 
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(215, 22);
            this.btnReport1.Text = "Валюты стран";
            this.btnReport1.Click += new System.EventHandler(this.OpenView_Click);
            // 
            // btnReport2
            // 
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(215, 22);
            this.btnReport2.Text = "Языки стран";
            this.btnReport2.Click += new System.EventHandler(this.OpenView_Click);
            // 
            // btnReport3
            // 
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(215, 22);
            this.btnReport3.Text = "Информация по городам";
            this.btnReport3.Click += new System.EventHandler(this.OpenView_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddEdge.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEdge.Image")));
            this.btnAddEdge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(117, 22);
            this.btnAddEdge.Text = "Добавить маршрут";
            this.btnAddEdge.Click += new System.EventHandler(this.WorkWithEdge_Click);
            // 
            // btnDelEdge
            // 
            this.btnDelEdge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelEdge.Image = ((System.Drawing.Image)(resources.GetObject("btnDelEdge.Image")));
            this.btnDelEdge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelEdge.Name = "btnDelEdge";
            this.btnDelEdge.Size = new System.Drawing.Size(109, 22);
            this.btnDelEdge.Text = "Удалить маршрут";
            this.btnDelEdge.Click += new System.EventHandler(this.WorkWithEdge_Click);
            // 
            // btnUpdateEdge
            // 
            this.btnUpdateEdge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpdateEdge.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateEdge.Image")));
            this.btnUpdateEdge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateEdge.Name = "btnUpdateEdge";
            this.btnUpdateEdge.Size = new System.Drawing.Size(119, 22);
            this.btnUpdateEdge.Text = "Изменить маршрут";
            this.btnUpdateEdge.Click += new System.EventHandler(this.WorkWithEdge_Click);
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(45, 22);
            this.btnFind.Text = "Найти";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbFind
            // 
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(100, 25);
            // 
            // btnSavePath
            // 
            this.btnSavePath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSavePath.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePath.Image")));
            this.btnSavePath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(96, 22);
            this.btnSavePath.Text = "Сохранить путь";
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(98, 22);
            this.btnInfo.Text = "Добавить город";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panel.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panel.Controls.Add(this.pb);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(912, 445);
            this.panel.TabIndex = 9;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Image = global::AirTravel.Properties.Resources.map;
            this.pb.InitialImage = global::AirTravel.Properties.Resources.map;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(912, 445);
            this.pb.TabIndex = 10;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_MouseClick);
            // 
            // contextMenuButton
            // 
            this.contextMenuButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btnUpdateTown});
            this.contextMenuButton.Name = "contextMenuButton";
            this.contextMenuButton.Size = new System.Drawing.Size(164, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Удалить город";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.WorkWithTown_Click);
            // 
            // btnUpdateTown
            // 
            this.btnUpdateTown.Name = "btnUpdateTown";
            this.btnUpdateTown.Size = new System.Drawing.Size(163, 22);
            this.btnUpdateTown.Text = "Изменить город";
            this.btnUpdateTown.Click += new System.EventHandler(this.WorkWithTown_Click);
            // 
            // btnDelTown
            // 
            this.btnDelTown.Name = "btnDelTown";
            this.btnDelTown.Size = new System.Drawing.Size(163, 22);
            this.btnDelTown.Text = "Удалить город";
            this.btnDelTown.Click += new System.EventHandler(this.WorkWithTown_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 470);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ts);
            this.KeyPreview = true;
            this.Name = "FormManager";
            this.Text = "Манагер";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormManager_KeyDown);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.contextMenuButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ToolStripDropDownButton ddViews;
        protected System.Windows.Forms.ToolStripButton btnAddEdge;
        protected System.Windows.Forms.ToolStripButton btnDelEdge;
        protected System.Windows.Forms.ToolStripButton btnUpdateEdge;
        protected System.Windows.Forms.ToolStripButton btnWayFound;
        protected System.Windows.Forms.ToolStrip ts;
        protected System.Windows.Forms.ToolStripMenuItem btnReport1;
        protected System.Windows.Forms.ToolStripMenuItem btnReport2;
        protected System.Windows.Forms.ToolStripMenuItem btnReport3;
        protected System.Windows.Forms.Panel panel;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem btnUpdateTown;
        protected System.Windows.Forms.ToolStripMenuItem btnDelTown;
        protected System.Windows.Forms.PictureBox pb;
        protected System.Windows.Forms.ToolStripButton btnFind;
        protected System.Windows.Forms.ToolStripTextBox tbFind;
        protected System.Windows.Forms.ToolStripButton btnSavePath;
        protected System.Windows.Forms.ContextMenuStrip contextMenuButton;
        protected System.Windows.Forms.ToolStripButton btnInfo;
    }
}