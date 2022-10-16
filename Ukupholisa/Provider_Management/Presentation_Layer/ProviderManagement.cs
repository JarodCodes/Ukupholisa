using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa.Provider_Management.Presentation_Layer
{
    public partial class ProviderManagement : Form
    {
        public ProviderManagement()
        {
            InitializeComponent();
        }
        Logic_Layer.PolicyHandler policyhandler = new Logic_Layer.PolicyHandler();
        private void ProviderManagement_Load(object sender, EventArgs e)
        {
            dataGridViewProv.DataSource = policyhandler.PopulateMedProv();
            dataGridViewPolProv.DataSource = policyhandler.PopulateMedProv();
            dataGridViewPackProv.DataSource = policyhandler.PopulateMedProv();
            dataGridViewPol.DataSource = policyhandler.PopulatePolicy();
            dataGridViewPackPol.DataSource = policyhandler.PopulatePolicy();
            dataGridViewPackage.DataSource = policyhandler.PopulatePackage();
        }

        private void dataGridViewProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewProv.Rows[e.RowIndex];

                txtProvID.Text = rows.Cells["Provider_Id"].Value.ToString();
                txtProvName.Text = rows.Cells["Provider_Name"].Value.ToString();
                txtProvLocation.Text = rows.Cells["Provider_Location"].Value.ToString();
                if (rows.Cells["Provider_Status"].Value.ToString() == "True")
                {
                    radioBtnTrue.Checked = true;
                }
                else 
                {
                    radioBtnFalse.Checked = true;
                }
            }
        }

        private void btnProvAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.Provider provider = new DataAccess_Layer.Provider();
                provider.ProviderId = int.Parse(txtProvID.Text);
                provider.Name = txtProvName.Text;
                provider.Location = txtProvLocation.Text;
                if (radioBtnTrue.Checked)
                {
                    provider.Status = true;
                }
                else 
                {
                    provider.Status = false;
                }

                policyhandler.addProvider(provider);
                MessageBox.Show("Provider was added");
            }
            catch (Exception)
            {
                MessageBox.Show("Provider was not added");
            }
        }

        private void btnProvUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.Provider provider = new DataAccess_Layer.Provider();
                provider.ProviderId = int.Parse(txtProvID.Text);
                provider.Name = txtProvName.Text;
                provider.Location = txtProvLocation.Text;
                if (radioBtnTrue.Checked)
                {
                    provider.Status = true;
                }
                else
                {
                    provider.Status = false;
                }

                policyhandler.updateProvider(provider);
                MessageBox.Show("Provider was updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Provider was not updated");
            }
        }

        private void btnProvDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int provID = int.Parse(txtProvID.Text);

                policyhandler.deleteProvider(provID);
                MessageBox.Show("Provider was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Provider was not deleted");
            }
        }

        private void btnProvSearch_Click(object sender, EventArgs e)
        {
            dataGridViewProv.DataSource = policyhandler.searchProvider(int.Parse(txtProvID.Text));
        }

        private void dataGridViewPol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewPol.Rows[e.RowIndex];

                txtPolID.Text = rows.Cells["Policy_Id"].Value.ToString();
                txtPolName.Text = rows.Cells["Policy_Name"].Value.ToString();
                cmbCoverLevel.Text = rows.Cells["Policy_CoverLevel"].Value.ToString();
                txtPolCost.Text = rows.Cells["Policy_Cost"].Value.ToString();
                txtPolProvID.Text = rows.Cells["Provider_Id"].Value.ToString();
            }
        }

        private void brnPolAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.Policy policy = new DataAccess_Layer.Policy();
                policy.PolicyId = int.Parse(txtPolID.Text);
                policy.Name = txtPolName.Text;
                policy.CoverLevel = cmbCoverLevel.Text;
                policy.Cost = int.Parse(txtPolCost.Text);
                policy.ProviderId = int.Parse(txtPolProvID.Text);

                policyhandler.addPolicy(policy);
                MessageBox.Show("Policy was added");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not added");
            }
        }

        private void btnPolUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.Policy policy = new DataAccess_Layer.Policy();
                policy.PolicyId = int.Parse(txtPolID.Text);
                policy.Name = txtPolName.Text;
                policy.CoverLevel = cmbCoverLevel.Text;
                policy.Cost = int.Parse(txtPolCost.Text);
                policy.ProviderId = int.Parse(txtPolProvID.Text);

                policyhandler.updatePolicy(policy);
                MessageBox.Show("Policy was updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not updated");
            }
        }

        private void btnPolDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int polID = int.Parse(txtPolID.Text);

                policyhandler.deletePolicy(polID);
                MessageBox.Show("Policy was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not deleted");
            }
        }

        private void btnPolProvSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPolProv.DataSource = policyhandler.searchProvider(int.Parse(txtPolProvID.Text));
        }

        private void btnPolSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPolProv.DataSource = policyhandler.searchPolicy(int.Parse(txtPolID.Text));
        }

        private void dataGridViewPolProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewProv.Rows[e.RowIndex];

                txtPolProvID.Text = rows.Cells["Provider_Id"].Value.ToString();
            }
        }

        private void dataGridViewPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewPol.Rows[e.RowIndex];

                txtPackID.Text = rows.Cells["Package_Id"].Value.ToString();
                txtPackName.Text = rows.Cells["Package_Name"].Value.ToString();
                txtPackCost.Text = rows.Cells["Package_Cost"].Value.ToString();
                txtPackProvID.Text = rows.Cells["Provider_Id"].Value.ToString();
            }
        }

        private void dataGridViewPackProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewPackProv.Rows[e.RowIndex];

                txtPackProvID.Text = rows.Cells["Provider_Id"].Value.ToString();
            }
        }

        private void btnPackCreate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.PolicyPackage package = new DataAccess_Layer.PolicyPackage();
                package.PackageId = int.Parse(txtPackID.Text);
                package.Name = txtPackName.Text;
                package.Cost = int.Parse(txtPackCost.Text);
                package.ProviderId = int.Parse(txtPackProvID.Text);

                policyhandler.createPackage(package);
                MessageBox.Show("Package was created");
            }
            catch (Exception)
            {
                MessageBox.Show("Package was not created");
            }
        }

        private void btnPackUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.PolicyPackage package = new DataAccess_Layer.PolicyPackage();
                package.PackageId = int.Parse(txtPackID.Text);
                package.Name = txtPackName.Text;
                package.Cost = int.Parse(txtPackCost.Text);
                package.ProviderId = int.Parse(txtPackProvID.Text);

                policyhandler.updatePackage(package);
                MessageBox.Show("Package was created");
            }
            catch (Exception)
            {
                MessageBox.Show("Package was not created");
            }
        }

        private void btnPackDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int packID = int.Parse(txtPackID.Text);

                policyhandler.deletePackage(packID);
                MessageBox.Show("Package was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Package was not deleted");
            }
        }

        private void btnPackProvSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPolProv.DataSource = policyhandler.searchProvider(int.Parse(txtPolProvID.Text));
        }

        private void btnPackSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPackage.DataSource = policyhandler.searchPackage(int.Parse(txtPackID.Text));
        }

        private void dataGridViewPackPol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewPackPol.Rows[e.RowIndex];

                txtPackPolSearch.Text = rows.Cells["Policy_Id"].Value.ToString();
            }
        }

        private void btnPackPolSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPackPol.DataSource = policyhandler.searchPolicy(int.Parse(txtPackPolSearch.Text));
        }

        private void btnPackPolAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.PolicyPackage package = new DataAccess_Layer.PolicyPackage();
                int polID = int.Parse(txtPackPolSearch.Text);
                int packID = int.Parse(txtPackID.Text);
                policyhandler.addPackPolicy(polID, packID);
                MessageBox.Show("Policy was added");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not added");
            }
        }

        private void txtPackID_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCurPackPol.DataSource = policyhandler.populateCurPackPolicy(int.Parse(txtPackID.Text));
        }

        private void btnPackPolRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int polID = int.Parse(txtPackPolSearch.Text);
                int packID = int.Parse(txtPackID.Text);
                policyhandler.removePackPol(polID, packID);
                MessageBox.Show("Policy was removed");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not removed");
            }
        }

        //private void btnProvSearch_Click(object sender, EventArgs e)
        //{

        //}
    }
}
