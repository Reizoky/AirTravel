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
    public partial class FormAdmin : Form
    {
        DataTable dt;
        bool isSqlQuerry = false;
        public FormAdmin()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            btnSqlQuerry.Visible = false;
            panel.Visible = false;
            btnTablePlus.Visible = false;
            lblAllTables.Visible = false;
            cbAllTables.Visible = false;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            tbAdminPass.Select();
        }

        private void cbAllTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();

                DB.WorkWithTable(ref dt, "Select * from " + cbAllTables.SelectedItem, true);

                bs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new FormSettings();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            bs.EndEdit();

            DB.WorkWithTable(ref dt, ("Select * from " + cbAllTables.SelectedItem), false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DB.WorkWithTable(ref dt, ("Select * from " + cbAllTables.SelectedItem), true);
        }

        private void btnTablePlus_Click(object sender, EventArgs e)
        {
            Form f = new FormTable(dt);
            f.Show();
        }


        private void btnAdminConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAdminPass.Text != string.Empty)
                {
                    BindingSource bs1 = new BindingSource();

                    dt = new DataTable();

                    DB.CreateStringConnection("sa", tbAdminPass.Text);
                    DB.WorkWithTable(ref dt, "select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME <> 'sysdiagrams'", true);

                    bs.DataSource = dt;
                    bn.BindingSource = bs;
                    dgv.DataSource = bs;

                    bs1.DataSource = dt;

                    foreach (DataRow dr in dt.Rows)
                        cbAllTables.Items.Add(dr["TABLE_NAME"].ToString());
                    cbAllTables.SelectedIndex = 0;

                    btnSqlQuerry.Visible = true;
                    btnAdminConn.Visible = false;
                    btnTablePlus.Visible = true;
                    lblAdminPass.Visible = false;
                    tbAdminPass.Visible = false;
                    lblAllTables.Visible = true;
                    cbAllTables.Visible = true;
                }
                else
                    MessageBox.Show("Введите пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSqlQuerry_Click(object sender, EventArgs e)
        {
            panel.Visible = !isSqlQuerry;
            isSqlQuerry = !isSqlQuerry;
        }

        private void btnDoSqlQuerry_Click(object sender, EventArgs e)
        {
            try
            {
                string[] commandsArr = tbSqlQuerry.Text.Split(';');
                if (commandsArr[0] != "")
                    DB.DoSql(commandsArr);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода");
            e.ThrowException = false;
        }
    }
}
