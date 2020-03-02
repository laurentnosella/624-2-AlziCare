using System;
using System.Windows.Forms;

namespace AlziCare
{
    public partial class FrmSelectAccount : Form
    {
        public FrmSelectAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picBoxUser1_Click(object sender, EventArgs e)
        {
            FrmUserPlanning form = new FrmUserPlanning();
            this.Hide();
            form.Show();
        }

        private void picBoxUser2_Click(object sender, EventArgs e)
        {
            FrmUserPlanning form = new FrmUserPlanning();
            this.Hide();
            form.Show();
        }

        private void lblEspaceAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminHome form = new FrmAdminHome();
            form.Show();
        }

        private void SelectAccountForm_Load(object sender, EventArgs e)
        {
            FrmAdminLogin form = new FrmAdminLogin();
            form.ShowDialog();
        }

        private void dgwPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmUserPlanning form = new FrmUserPlanning();
            form.ShowDialog();
        }

        private void btnEspaceAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminHome form = new FrmAdminHome();
            form.Show();
        }

        private void btnFrontEnd_Click(object sender, EventArgs e)
        {

            FrmUserPlanning form = new FrmUserPlanning();
            form.ShowDialog();
        }
    }
}
