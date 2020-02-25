using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlziCare
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text != "" & txbMdp.Text != "")
            {
                this.Close();
            }
            else
            {
                lblErrorLogin.Visible = true;
            }
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmAdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
