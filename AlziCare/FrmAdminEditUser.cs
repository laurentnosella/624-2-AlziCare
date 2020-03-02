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
    public partial class FrmAdminEditUser : Form
    {
        public FrmAdminEditUser()
        {
            InitializeComponent();
        }

        private void FrmAdminEditUser_Load(object sender, EventArgs e)
        {

        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
