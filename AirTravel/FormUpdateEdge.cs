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
    public partial class FormUpdateEdge : FormDelEdge
    {
        DataTable dt;

        public FormUpdateEdge()
        {
            InitializeComponent();

            btnDel.Visible = false;
        }

        private void FormUpdateTownEdge_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            DB.WorkWithTable(ref dt, @"Select Name, IDEdge, Cost from Edge", true);

            cbEdge.DisplayMember = "Name";
            cbEdge.ValueMember = "IDEdge";

            cbEdge.DataSource = dt;

            nudCost.DataBindings.Add(new Binding("Value", dt, "Cost"));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DB.DoDMLCommand("update Edge set Cost = " + nudCost.Value);
            this.Close();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
