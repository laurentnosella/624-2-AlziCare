using System;
using System.Windows.Forms;

namespace AlziCare
{
    public partial class FrmSelectAccountForm : Form
    {
        public FrmSelectAccountForm()
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
            form.Show();
        }

        private void dgwPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmUserPlanning form = new FrmUserPlanning();
            form.Show();
        }
    }
}
