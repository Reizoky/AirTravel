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
    public partial class FormUser : FormManager
    {
        public FormUser()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            btnAddEdge.Visible = false;
            btnDelEdge.Visible = false;
            btnUpdateEdge.Visible = false;
            ddViews.Visible = false;
            pb.ContextMenuStrip = null;
            contextMenuButton.Enabled = false;
            btnInfo.Visible = false;

            btnFind.Visible = true;
            tbFind.Visible = true;
            btnSavePath.Visible = true;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
        }

    }
}
