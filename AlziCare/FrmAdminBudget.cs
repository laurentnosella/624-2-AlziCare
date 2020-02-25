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
    public partial class FrmAdminBudget : Form
    {
        public FrmAdminBudget()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "Extraction en PDF", MessageBoxButtons.OK);

        }
    }
}
