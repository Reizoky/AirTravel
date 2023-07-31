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
    public partial class FormAddEdge : Form
    {

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public FormAddEdge()
        {
            InitializeComponent();
        }

        private void FormAddEdge_Load(object sender, EventArgs e)
        {
            DB.WorkWithTable(ref dt, "Select Name, IDTown from Town", true);
            DB.WorkWithTable(ref dt2, "Select Name, IDTown from Town", true);

            cbTown1.ValueMember = "IDTown";
            cbTown1.DisplayMember = "Name";
            cbTown2.ValueMember = "IDTown";
            cbTown2.DisplayMember = "Name";

            cbTown1.DataSource = dt;
            cbTown2.DataSource = dt2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int t1 = Convert.ToInt32(cbTown1.SelectedValue);
            int t2 = Convert.ToInt32(cbTown2.SelectedValue);
            if (t1 != t2)
                DB.DoDMLCommand("insert into Edge(IDTown1, IDTown2, Cost) values ("
                    + Math.Min(t1, t2) + ", " +
                    +Math.Max(t1, t2) + ", " +
                    +nudCost.Value + ");");
            this.Close();
        }
    }
}
