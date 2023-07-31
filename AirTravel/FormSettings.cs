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
    public partial class FormSettings : Form
    {
        public static string serverName = string.Empty;
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (tbServerName.Text != string.Empty &&
                tbAdminPass.Text != string.Empty &&
                tbMngrLogin.Text != string.Empty &&
                tbMngrPass.Text != string.Empty &&
                tbGuestLogin.Text != string.Empty)
            {
                Properties.Settings.Default.serverName = tbServerName.Text;
                Properties.Settings.Default.adminPass = tbAdminPass.Text;
                Properties.Settings.Default.MngrLogin = tbMngrLogin.Text;
                Properties.Settings.Default.MngrPass = tbMngrPass.Text;
                Properties.Settings.Default.GuestLogin = tbGuestLogin.Text;
                Properties.Settings.Default.GuestPass = tbGuestPass.Text;

                Properties.Settings.Default.Save();
            }
            this.Close();
        }

        private void FormSerringsServer_Load(object sender, EventArgs e)
        {
            tbServerName.Text = Properties.Settings.Default.serverName;
            tbAdminPass.Text = Properties.Settings.Default.adminPass;
            tbMngrLogin.Text = Properties.Settings.Default.MngrLogin;
            tbMngrPass.Text = Properties.Settings.Default.MngrPass;
            tbGuestLogin.Text = Properties.Settings.Default.GuestLogin;
            tbGuestPass.Text = Properties.Settings.Default.GuestPass;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
