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
    public partial class FormTable : FormAdmin
    {
        DataTable dt = new DataTable();
        public FormTable()
        {
            InitializeComponent();
        }

        public FormTable(DataTable _dt)
        {
            InitializeComponent();
            dt = _dt;
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = false;
            btnDell.Visible = false;
            btnSettings.Visible = false;
            btnTablePlus.Visible = false;
            btnAdminConn.Visible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            lblAdminPass.Visible = false;
            tbAdminPass.Visible = false;
            btnTablePlus.Visible = false;
            btnSqlQuerry.Visible = false;
            panel.Visible = false;
            cbAllTables.Visible = false;
            lblAllTables.Visible = false;

            this.FormBorderStyle = FormBorderStyle.Sizable;

            bs.DataSource = dt;
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
    }
}
