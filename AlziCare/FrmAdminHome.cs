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
    public partial class FrmAdminHome : Form
    {
        public FrmAdminHome()
        {
            InitializeComponent();
        }

        private void lbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminEditUser form = new FrmAdminEditUser();
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAdminEditUser form = new FrmAdminEditUser();
            form.ShowDialog();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            //Source : https://stackoverflow.com/questions/3845695/is-there-a-builtin-confirmation-dialog-in-windows-forms
            var confirmResult = MessageBox.Show("Veuillez confirmer la suppression du compte : <NomCompte>","Confirmation de la suppression",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            FrmAdminPlanning form = new FrmAdminPlanning();
            form.Show();
        }

        private void btnBudg_Click(object sender, EventArgs e)
        {
            FrmAdminBudget form = new FrmAdminBudget();
            form.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Go Back
        }

        private void dtgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = true;
            btnBudg.Enabled = true;
            btnEdit.Enabled = true;
            btnPlan.Enabled = true;
            btnSupp.Enabled = true;
        }

        private void FrmAdminHome_Load(object sender, EventArgs e)
        {
            //Temporaire, à supprimer pour y préférer l'evenement CellContentClick du DTG
            btnAdd.Enabled = true;
            btnBudg.Enabled = true;
            btnEdit.Enabled = true;
            btnPlan.Enabled = true;
            btnSupp.Enabled = true;
        }
    }
}
