using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTravel
{
    public partial class FormDelEdge : Form
    {
        DataTable dt = new DataTable();
        public FormDelEdge()
        {
            InitializeComponent();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDelEdge_Load(object sender, EventArgs e)
        {
            DB.WorkWithTable(ref dt, "Select Name, IDEdge, Cost from Edge", true);

            cbEdge.ValueMember = "IDEdge";
            cbEdge.DisplayMember = "Name";

            cbEdge.DataSource = dt;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DB.DoDMLCommand("delete from Edge where IDEdge = " + cbEdge.SelectedValue.ToString());
            this.Close();
        }
    }
}
