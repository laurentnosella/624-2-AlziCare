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
    public partial class FrmAdminPlanning : Form
    {
        public FrmAdminPlanning()
        {
            InitializeComponent();
        }

        private void AdminPlanning_Load(object sender, EventArgs e)
        {
            if (cbxMedicTxt.Checked)
            {
                tbxMedic.Enabled = true;
            }
            if (cbxMedicCombo.Checked)
            {
                cbMedic.Enabled = true;
            }
        }

        private void cbMedicTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMedicTxt.Checked)
            {
                tbxMedic.Enabled = true;
            }
            else
            {
                tbxMedic.Enabled = false;
            }
        }

        private void cbMedicCombo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMedicCombo.Checked)
            {
                cbMedic.Enabled = true;
            }
            else
            {
                cbMedic.Enabled = false;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
