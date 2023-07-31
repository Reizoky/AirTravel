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
    public partial class FormAddTown : Form
    {
        DataTable dt;
        public FormAddTown()
        {
            InitializeComponent();
        }

        private void btnCanсel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddTown_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            DB.WorkWithTable(ref dt, "Select Name, IDCountry from Country", true);

            cbCountry.ValueMember = "IDCountry";
            cbCountry.DisplayMember = "Name";

            cbCountry.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != string.Empty)
            {
                DB.DoDMLCommand("insert into Town(IDCountry, Name, X, Y, Info) values("
                    + " " + cbCountry.SelectedValue
                    + ", '" + tbName.Text
                    + "', " + FormManager.x
                    + ", " + FormManager.y
                    + ", '" + tbInfo.Text
                    + "' " + ");");
            }
            else
                MessageBox.Show("Введите название города");
            this.Close();
        }
    }
}
