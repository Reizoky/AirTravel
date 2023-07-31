using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirTravel
{
    public partial class MainFormViewer : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        public MainFormViewer()
        {
            InitializeComponent();
        }


        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new FormLogin();
                DialogResult dr = f.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    this.WindowState = FormWindowState.Maximized;
                    foreach (Form child in this.MdiChildren)
                        child.Close();
                    if (DB.login == Properties.Settings.Default.adminLogin &&
                        DB.password == Properties.Settings.Default.adminPass)
                    {
                        Form adminForm = new FormAdmin();
                        adminForm.MdiParent = this;
                        adminForm.Dock = DockStyle.Fill;
                        adminForm.Show();
                    }
                    else if (DB.login == Properties.Settings.Default.MngrLogin)
                    {
                        try
                        {
                            DB.CreateStringConnection("Manager", DB.password);
                            Form managertForm = new FormManager();
                            managertForm.MdiParent = this;
                            managertForm.Show();
                            managertForm.Dock = DockStyle.Fill;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (DB.login == Properties.Settings.Default.GuestLogin &&
                        DB.password == Properties.Settings.Default.GuestPass)
                    {
                        try
                        {
                            DB.CreateStringConnection("Client", DB.password);
                            Form userForm = new FormUser();
                            userForm.MdiParent = this;
                            userForm.Show();
                            userForm.Dock = DockStyle.Fill;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Не правильный логин или пароль");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
