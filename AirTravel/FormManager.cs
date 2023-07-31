using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace AirTravel
{
    public partial class FormManager : Form
    {
        bool ctrl = false;
        static public int x = 0;
        static public int y = 0;
        static public int mapWidth;
        static public int mapHeight;
        Town currentTown;
        static int width = Town.width / 2;

        DataTable dtReport;
        DataGridView dgv = new DataGridView();
        DataTable dtTowns;
        DataTable dtEdge;

        List<Town> arrTown = new List<Town>();

        Graphics g;
        Pen pen = new Pen(Color.Black, 2);

        public FormManager()
        {
            InitializeComponent();

            btnFind.Visible = false;
            tbFind.Visible = false;
            btnSavePath.Visible = false;
            btnSavePath.Enabled = false;

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            panel.AutoScrollMinSize = pb.Image.Size;

            RefreshTables();

            PaintTown();

            mapWidth = pb.Size.Width;
            mapHeight = pb.Size.Height;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Town_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                currentTown = ((Town)sender);
            else
                MessageBox.Show(((Town)sender).TownName + Environment.NewLine + ((Town)sender).TownInfo);
        }

        private void OpenView_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSelect = "Select * from ";
                dtReport = new DataTable();
                switch (((ToolStripMenuItem)sender).Name)
                {
                    case "btnReport1":
                        sqlSelect += "CurrencyCountryName";
                        break;
                    case "btnReport2":
                        sqlSelect += "LanguageCountryName";
                        break;
                    case "btnReport3":
                        sqlSelect += "TownCountry";
                        break;
                }
                DB.WorkWithTable(ref dtReport, sqlSelect, true);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV-файл|*.csv";
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);

                foreach (DataColumn col in dtReport.Columns)
                    sw.Write(col.ColumnName + ";");
                sw.WriteLine();

                foreach (DataRow dr in dtReport.Rows)
                {
                    for (int i = 0; i < dtReport.Columns.Count; i++)
                        sw.Write(dr.Field<object>(i) + ";");
                    sw.WriteLine();
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WorkWithEdge_Click(object sender, EventArgs e)
        {
            Form f;
            switch (((ToolStripButton)sender).Text)
            {
                case "Добавить маршрут":
                    f = new FormAddEdge();
                    f.ShowDialog();
                    RefreshTables();

                    FormWayFound.PrintEdge.Clear();
                    pb.Invalidate();
                    break;
                case "Удалить маршрут":
                    f = new FormDelEdge();
                    f.ShowDialog();
                    RefreshTables();

                    FormWayFound.PrintEdge.Clear();
                    pb.Invalidate();
                    break;
                case "Изменить маршрут":
                    f = new FormUpdateEdge();
                    f.ShowDialog();
                    RefreshTables();

                    FormWayFound.PrintEdge.Clear();
                    pb.Invalidate();
                    break;
            }
        }

        private void WorkWithTown_Click(object sender, EventArgs e)
        {
            Form f;
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Добавить город":
                    f = new FormAddTown();
                    f.ShowDialog();
                    RefreshTables();
                    PaintTown();

                    FormWayFound.PrintEdge.Clear();
                    pb.Invalidate();
                    break;
                case "Удалить город":
                    DelTown(currentTown);
                    RefreshTables();
                    PaintTown();

                    FormWayFound.PrintEdge.Clear();
                    pb.Invalidate();
                    break;
                case "Изменить город":
                    f = new FormUpdateTown(currentTown);
                    f.ShowDialog();
                    RefreshTables();
                    PaintTown();

                    FormWayFound.PrintEdge.Clear();
                    pb.Invalidate();
                    break;
            }
        }

        private void pb_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnAddEdge.Visible)
            {
                if (ctrl && btnAddEdge.Visible)
                {
                    x = e.X;
                    y = e.Y;
                    Form f = new FormAddTown();
                    f = new FormAddTown();
                    f.ShowDialog();
                    RefreshTables();
                    PaintTown();
                    ctrl = false;
                };
            }
        }

        protected void btnWayFound_Click(object sender, EventArgs e)
        {
            Form f = new FormWayFound();
            f.ShowDialog();
            btnSavePath.Enabled = true;
            pb.Invalidate();
        }

        private void DelTown(object _currentTown)
        {
            arrTown.Remove((Town)currentTown);
            pb.Controls.Remove(currentTown);
            DB.DoDMLCommand("Delete from Town where IDTown = "+ currentTown.TownID);

            FormWayFound.PrintEdge.Clear();
            pb.Invalidate();
        }

        protected void RefreshTables()
        {
            dtEdge = new DataTable();
            DB.WorkWithTable(ref dtEdge, @"Select
            (select X from Town where IDTown = IDTown1)
            ,(select Y from Town where IDTown = IDTown1)
            ,(select X from Town where IDTown = IDTown2)
            ,(select Y from Town where IDTown = IDTown2)
            ,Name
            from Edge", true);


            dtTowns = new DataTable();
            DB.WorkWithTable(ref dtTowns, "Select IDTown, Name, Info, X, Y from Town", true);
        }

        protected void pb_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            PaintEdge(ref g);
        }

        protected void PaintTown()
        {
            arrTown.Clear();
            pb.Controls.Clear();

            foreach (DataRow dr in dtTowns.Rows)
            {
                Town t = new Town(dr.Field<int>(0), dr.Field<string>(1), dr.Field<string>(2), dr.Field<int>(3), dr.Field<int>(4));
                t.Name = "ID:" + t.TownID.ToString();
                t.PathTown();
                if(btnAddEdge.Visible)
                    t.ContextMenuStrip = contextMenuButton;
                t.MouseDown += Town_RightClick;
                t.Location = new Point(t.TownX - width, t.TownY - width);
                t.TabStop = false;
                arrTown.Add(t);
                pb.Controls.Add(t);
            }
        }

        protected void PaintEdge(ref Graphics g)
        {
            int xStart = 0, yStart = 0, xEnd = 0, yEnd = 0;
            bool isStart, isEnd;
            foreach (Edge edge in FormWayFound.PrintEdge)
            {
                int startPeak = Math.Min(edge.startPeak, edge.endPeak);
                int endPeak = Math.Max(edge.startPeak, edge.endPeak);
                isStart = false;
                isEnd = false;
                foreach (DataRow dr in dtTowns.Rows)
                {
                    if (!isStart && (startPeak == dr.Field<int>(0)))
                    {
                        xStart = dr.Field<int>(3);
                        yStart = dr.Field<int>(4);
                        isStart = true;
                    }
                    if (!isEnd && (endPeak == dr.Field<int>(0)))
                    {
                        xEnd = dr.Field<int>(3);
                        yEnd = dr.Field<int>(4);
                        isEnd = true;
                    }
                    if (isStart && isEnd)
                    {
                        g.DrawLine(pen,
                                new Point(xStart, yStart),
                                new Point(xEnd, yEnd)
                                );
                        isEnd = false;
                        isStart = false;
                        break;
                    }
                }
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            pb.Invalidate();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            bool isFind = false;
            foreach(Town t in arrTown)
            {
                t.Size = new Size(width*2, width*2);
                t.BackColor = Color.White;
            }

            if (tbFind.Text != string.Empty)
            {
                foreach (Town t in arrTown)
                    if (string.Compare(t.TownName, tbFind.Text, true) == 0)
                    {
                        t.Size = new Size(width * 8, width * 8);
                        t.BackColor = Color.Red;
                        isFind = true;
                        MessageBox.Show(t.TownName + Environment.NewLine + t.TownInfo);
                        break;
                    }
            }
            else
            {
                MessageBox.Show("Введите название города для поиска");
            }

            if (!isFind)
                MessageBox.Show("Города с таким именем у нас неть");

        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "TXT-файл|*.txt";
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                foreach (Edge edge in FormWayFound.PrintEdge)
                    sw.WriteLine(edge.name + " " + edge.cost);

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                ctrl = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Для добавления города зажмите CTRL и нажмите левой клавишей мыши на карту");
        }
    }
}
