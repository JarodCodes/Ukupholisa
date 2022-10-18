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
        ICRUD policy = new Logic_Layer.Policy();
        ICRUD package = new Logic_Layer.PolicyPackage();
        ICRUD provider = new Logic_Layer.Provider();
        private void ProviderManagement_Load(object sender, EventArgs e)
        {
            dataGridViewProv.DataSource = provider.populate();
            dataGridViewPolProv.DataSource = provider.populate();
            dataGridViewPackProv.DataSource = provider.populate();
            dataGridViewPol.DataSource = policy.populate();
            dataGridViewPackPol.DataSource = policy.populate();
            dataGridViewPackage.DataSource = package.populate();
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
                Logic_Layer.Provider provider = new Logic_Layer.Provider();
                provider.Name = txtProvName.Text;
                provider.Location = txtProvLocation.Text;
                if (radioBtnTrue.Checked)
                {
                    provider.Status = 1;
                }
                else 
                {
                    provider.Status = 0;
                }

                provider.add();
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
                Logic_Layer.Provider provider = new Logic_Layer.Provider();
                provider.ProviderId = int.Parse(txtProvID.Text);
                provider.Name = txtProvName.Text;
                provider.Location = txtProvLocation.Text;
                if (radioBtnTrue.Checked)
                {
                    provider.Status = 1;
                }
                else
                {
                    provider.Status = 0;
                }

                provider.update();
                MessageBox.Show("Provider was updated");
            }
            catch (Exception )
            {
                MessageBox.Show("Provider was not updated");
            }
        }

        private void btnProvDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.Provider provider = new Logic_Layer.Provider();
                provider.ProviderId = int.Parse(txtProvID.Text);

                provider.delete();
                MessageBox.Show("Provider was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Provider was not deleted");
            }
        }

        private void btnProvSearch_Click(object sender, EventArgs e)
        {
            Logic_Layer.Provider provider = new Logic_Layer.Provider();
            provider.ProviderId = int.Parse(txtProvSearch.Text);
            DataTable dt = provider.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No provider found");
            }
            else
            {
                MessageBox.Show("Provider found");
                dataGridViewProv.DataSource = dt;
            }
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

        private void btnPolAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.Policy policy = new Logic_Layer.Policy();
                policy.Name = txtPolName.Text;
                policy.CoverLevel = cmbCoverLevel.Text;
                policy.Cost = int.Parse(txtPolCost.Text);
                policy.ProviderId = int.Parse(txtPolProvID.Text);

                policy.add();
                MessageBox.Show("Policy was added");
            }
            catch (Exception )
            {
                MessageBox.Show("Policy was not added");
            }
        }

        private void btnPolUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.Policy policy = new Logic_Layer.Policy();
                policy.PolicyId = int.Parse(txtPolID.Text);
                policy.Name = txtPolName.Text;
                policy.CoverLevel = cmbCoverLevel.Text;
                policy.Cost = int.Parse(txtPolCost.Text);
                policy.ProviderId = int.Parse(txtPolProvID.Text);

                policy.update();
                MessageBox.Show("Policy was updated");
            }
            catch (Exception )
            {
                MessageBox.Show("Policy was not updated");
            }
        }

        private void btnPolDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.Policy policy = new Logic_Layer.Policy();
                policy.PolicyId = int.Parse(txtPolID.Text);

                policy.delete();
                MessageBox.Show("Policy was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not deleted");
            }
        }

        private void btnPolProvSearch_Click(object sender, EventArgs e)
        {
            Logic_Layer.Provider provider = new Logic_Layer.Provider();
            provider.ProviderId = int.Parse(txtPolProvSearch.Text);
            DataTable dt = provider.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No provider found");
            }
            else
            {
                MessageBox.Show("Provider found");
                dataGridViewPolProv.DataSource = dt;
            }
        }

        private void btnPolSearch_Click(object sender, EventArgs e)
        {
            Logic_Layer.Policy policy = new Logic_Layer.Policy();
            policy.PolicyId = int.Parse(txtPolSearch.Text);
            DataTable dt = policy.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No policy found");
            }
            else
            {
                MessageBox.Show("Policy found");
                dataGridViewPol.DataSource = dt;
            }
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
                DataGridViewRow rows = this.dataGridViewPackage.Rows[e.RowIndex];

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
                Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                package.Name = txtPackName.Text;
                package.Cost = int.Parse(txtPackCost.Text);
                package.ProviderId = int.Parse(txtPackProvID.Text);

                package.add();
                MessageBox.Show("Package was created, remember to add policies on the next screen!");
            }
            catch (Exception )
            {
                MessageBox.Show("Package was not created");
            }
        }

        private void btnPackUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                package.PackageId = int.Parse(txtPackID.Text);
                package.Name = txtPackName.Text;
                package.Cost = int.Parse(txtPackCost.Text);
                package.ProviderId = int.Parse(txtPackProvID.Text);

                package.update();
                MessageBox.Show("Package was updated");
            }
            catch (Exception )
            {
                MessageBox.Show("Package was not updated");
            }
        }

        private void btnPackDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                package.PackageId = int.Parse(txtPackID.Text);

                package.delete();
                MessageBox.Show("Package was deleted");
            }
            catch (Exception )
            {
                MessageBox.Show("Package was not deleted");
            }
        }

        private void btnPackProvSearch_Click(object sender, EventArgs e)
        {
            Logic_Layer.Provider provider = new Logic_Layer.Provider();
            provider.ProviderId = int.Parse(txtPackProvSearch.Text);
            DataTable dt = provider.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No provider found");
            }
            else
            {
                MessageBox.Show("Provider found");
                dataGridViewPackProv.DataSource = dt;
            }
        }

        private void btnPackSearch_Click(object sender, EventArgs e)
        {
            Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
            package.PackageId = int.Parse(txtPackSearch.Text);
            DataTable dt = package.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No package found");
            }
            else
            {
                MessageBox.Show("Package found");
                dataGridViewPackage.DataSource = dt;
            }
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
            Logic_Layer.Policy policy = new Logic_Layer.Policy();
            policy.PolicyId = int.Parse(txtPackPolSearch.Text);
            DataTable dt = policy.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No policy found");
            }
            else
            {
                MessageBox.Show("Policy found");
                dataGridViewPackPol.DataSource = dt;
            }
        }

        private void btnPackPolAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                package.PolicyId = int.Parse(txtPackPolSearch.Text);
                package.PackageId = int.Parse(txtPackID.Text);
                package.addPol();
                MessageBox.Show("Policy was added");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not added");
            }
        }

        private void txtPackID_TextChanged(object sender, EventArgs e)
        {
            Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
            package.PackageId = int.Parse(txtPackID.Text);
            dataGridViewCurPackPol.DataSource = package.packPolSearch();
        }

        private void btnPackPolRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                package.PolicyId = int.Parse(txtPackPolSearch.Text);
                package.PackageId = int.Parse(txtPackID.Text);
                package.removePol();
                MessageBox.Show("Policy was removed");
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not removed");
            }
        }
    }
}
