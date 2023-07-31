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
    public partial class FormUpdateTown : Form
    {
        static Town currentTown;

        DataTable dt = new DataTable();
        public FormUpdateTown(Town town)
        {
            InitializeComponent();

            currentTown = town;
        }

        private void FormUpdateTown_Load(object sender, EventArgs e)
        {
            DB.WorkWithTable(ref dt, "Select IDTown, Name, Info, X, Y from Town where IDTown = " + currentTown.TownID, true);

            nudX.Maximum = FormManager.mapWidth;
            nudY.Maximum = FormManager.mapHeight;

            cbTown.ValueMember = "IDCountry";
            cbTown.DisplayMember = "Name";
            nudX.Value = dt.Rows[0].Field<int>(3);
            nudY.Value = dt.Rows[0].Field<int>(4);

            cbTown.DataSource = dt;
            tbInfo.DataBindings.Add(new Binding("Text", dt, "Info"));
        }

        private void btnCanсel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DB.DoDMLCommand("update Town set "
                + " Info = '" + tbInfo.Text+"'"
                + " ,X = "+nudX.Value
                + " ,Y = "+nudY.Value
                + " where IDTown = " + currentTown.TownID + ";");
            this.Close();
        }
    }
}
