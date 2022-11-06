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
        Validation val = new Validation();
        private void ProviderManagement_Load(object sender, EventArgs e)
        {
            dataGridViewProv.DataSource = provider.populate();
            dataGridViewPolProv.DataSource = provider.populate();
            dataGridViewPackProv.DataSource = provider.populate();
            dataGridViewPol.DataSource = policy.populate();
            dataGridViewPackPol.DataSource = policy.populate();
            dataGridViewPackage.DataSource = package.populate();
            cmbCoverLevel.SelectedIndex = 0;


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

                if (val.validateStrings(txtProvName.Text))
                {
                    // Name was incorrect
                    MessageBox.Show("Invalid Name!", "Message");
                    txtProvName.Focus();
                    return;
                }
                else if (val.validateStrings(txtProvLocation.Text))
                {
                    // Location was incorrect
                    MessageBox.Show("Invalid Location!", "Message");
                    txtProvLocation.Focus();
                    return;
                }
                else
                {
                    provider.add();
                    MessageBox.Show("Provider was added");
                    dataGridViewProv.DataSource = provider.populate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Provider was not added!");
            }
        }

        private void btnProvUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Logic_Layer.Provider provider = new Logic_Layer.Provider();

                if (radioBtnTrue.Checked)
                {
                    provider.Status = 1;
                }
                else
                {
                    provider.Status = 0;
                }
                if (val.validateStrings(txtProvName.Text))
                {
                    // Name was incorrect
                    MessageBox.Show("Invalid Name!", "Message");
                    txtProvName.Focus();
                    return;
                }
                else if (val.validateStrings(txtProvLocation.Text))
                {
                    // Location was incorrect
                    MessageBox.Show("Invalid Location!", "Message");
                    txtProvLocation.Focus();
                    return;
                }
                else
                {
                    provider.ProviderId = int.Parse(txtProvID.Text);
                    provider.Name = txtProvName.Text;
                    provider.Location = txtProvLocation.Text;
                    provider.update();
                    dataGridViewProv.DataSource = provider.populate();
                    MessageBox.Show("Provider was updated");
                }
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
                if (int.TryParse(txtProvID.Text, out int provID))
                {
                    Logic_Layer.Provider provider = new Logic_Layer.Provider();
                    provider.ProviderId = provID;
                    if (MessageBox.Show("Are you sure you want to delete provider with id " + provider.ProviderId + "?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        provider.delete();
                        dataGridViewProv.DataSource = provider.populate();
                        MessageBox.Show("Provider was deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a provider!", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Provider was not deleted");
            }
        }

        private void btnProvSearch_Click(object sender, EventArgs e)
        {
            Logic_Layer.Provider provider = new Logic_Layer.Provider();

            if (string.IsNullOrWhiteSpace(txtProvSearch.Text))
            {
                MessageBox.Show("Please insert a valid provider id!", "Error");
                txtProvSearch.Select();
            }
            else
            {
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
                if (val.validateStrings(txtPolName.Text))
                {
                    //Name is incorrect
                    MessageBox.Show("Invalid Name!", "Message");
                    txtProvName.Focus();
                    return;
                }
                else if (int.TryParse(txtPolCost.Text, out int polcost))
                {
                    Logic_Layer.Policy policy = new Logic_Layer.Policy();
                    policy.Name = txtPolName.Text;
                    policy.CoverLevel = cmbCoverLevel.Text;
                    policy.Cost = polcost;
                    policy.ProviderId = int.Parse(txtPolProvID.Text);

                    policy.add();
                    dataGridViewPol.DataSource = policy.populate();
                    MessageBox.Show("Policy was added");
                }
                else
                {
                    MessageBox.Show("Incorrect cost inserted!");
                    txtPolCost.Select();
                }
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
                if (val.validateStrings(txtPolName.Text))
                {
                    //Name is incorrect
                    MessageBox.Show("Invalid Name!", "Message");
                    txtProvName.Focus();
                    return;
                }
                else if (int.TryParse(txtPolCost.Text, out int polcost))
                {
                    Logic_Layer.Policy policy = new Logic_Layer.Policy();
                    policy.PolicyId = int.Parse(txtPolID.Text);
                    policy.Name = txtPolName.Text;
                    policy.CoverLevel = cmbCoverLevel.Text;
                    policy.Cost = polcost;
                    policy.ProviderId = int.Parse(txtPolProvID.Text);

                    policy.update();
                    dataGridViewPol.DataSource = policy.populate();
                    MessageBox.Show("Policy was updated");
                }
                else
                {
                    MessageBox.Show("Incorrect cost inserted!");
                    txtPolCost.Select();
                }
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
                if (int.TryParse(txtPolID.Text, out int polID))
                {
                    Logic_Layer.Policy policy = new Logic_Layer.Policy();
                    if (MessageBox.Show("Are you sure you want to delete policy " + txtPolID.Text + "?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        policy.PolicyId = polID;
                        policy.delete();
                        dataGridViewPol.DataSource = policy.populate();
                        MessageBox.Show("Policy was deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a policy!", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not deleted");
            }
        }

        private void btnPolProvSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPolProvSearch.Text, out int provID))
            {
                Logic_Layer.Provider provider = new Logic_Layer.Provider();
                provider.ProviderId = provID;
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
            else
            {
                MessageBox.Show("Please insert a valid provider id!", "Error");
                txtPolProvSearch.Select();
            }
        }

        private void btnPolSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPolSearch.Text, out int polSearch))
            {
                Logic_Layer.Policy policy = new Logic_Layer.Policy();
                policy.PolicyId = polSearch;
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
            else
            {
                MessageBox.Show("Please insert a valid policy id!", "Error");
                txtPolSearch.Select();
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
                if (val.validateStrings(txtPackName.Text))
                {
                    //Name is incorrect
                    MessageBox.Show("Invalid Name!", "Message");
                    txtPackName.Focus();
                    return;
                }
                else if (int.TryParse(txtPackCost.Text, out int packcost))
                {
                    Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                    package.Name = txtPackName.Text;
                    package.Cost = packcost;
                    package.ProviderId = int.Parse(txtPackProvID.Text);

                    package.add();
                    dataGridViewPackage.DataSource = package.populate();
                    MessageBox.Show("Package was created, remember to add policies on the next screen!");
                }
                else
                {
                    MessageBox.Show("Incorrect cost inserted!");
                    txtPackCost.Select();
                }

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
                if (val.validateStrings(txtPackName.Text))
                {
                    //Name is incorrect
                    MessageBox.Show("Invalid Name!", "Message");
                    txtPackName.Focus();
                    return;
                }
                else if (int.TryParse(txtPackCost.Text, out int packcost))
                {
                    Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                    package.PackageId = int.Parse(txtPackID.Text);
                    package.Name = txtPackName.Text;
                    package.Cost = packcost;
                    package.ProviderId = int.Parse(txtPackProvID.Text);

                    package.update();
                    dataGridViewPackage.DataSource = package.populate();
                    MessageBox.Show("Package was updated");
                }
                else
                {
                    MessageBox.Show("Incorrect cost inserted!");
                    txtPackCost.Select();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Package was not updated");
            }
        }

        private void btnPackDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtPackID.Text, out int packId))
                {
                    Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                    if (MessageBox.Show("Are you sure you want to delete package " + txtPackID.Text + "?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        package.PackageId = packId;
                        package.delete();
                        dataGridViewPackage.DataSource = package.populate();
                        MessageBox.Show("Package was deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a package!", "Error");
                    txtPackID.Select();
                }



            }
            catch (Exception)
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
            if (int.TryParse(txtPackPolSearch.Text, out int packpol))
            {
                policy.PolicyId = packpol;
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
            else
            {
                MessageBox.Show("Please insert a valid policy id!", "Error");
            }


        }

        private void btnPackPolAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtPackPolSearch.Text, out int packpol))
                {
                    Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                    package.PolicyId = packpol;
                    package.PackageId = int.Parse(txtPackID.Text);
                    package.addPol();
                    dataGridViewCurPackPol.DataSource = package.packPolSearch();
                    MessageBox.Show("Policy was added");
                }
                else
                {
                    MessageBox.Show("Please insert a valid policy id!", "Error");
                }
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
                if (int.TryParse(txtPackPolSearch.Text, out int packsearchId))
                {
                    Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
                    if (MessageBox.Show("Are you sure you want to delete policy " + txtPackPolSearch.Text + "?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        package.PolicyId = packsearchId;
                        package.PackageId = int.Parse(txtPackID.Text);
                        package.removePol();
                        dataGridViewCurPackPol.DataSource = package.packPolSearch();
                        MessageBox.Show("Policy was removed");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a policy!", "Error");
                    txtPackPolSearch.Select();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Policy was not removed" + ex.Message);
            }
        }

        private void btnProvRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewProv.DataSource = provider.populate();
        }

        private void btnPolRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewPolProv.DataSource = provider.populate();
            dataGridViewPol.DataSource = policy.populate();
        }

        private void btnPackRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewPackage.DataSource = package.populate();
            dataGridViewPackProv.DataSource = provider.populate();
        }

        private void btnPackPolRefresh_Click(object sender, EventArgs e)
        {
            Logic_Layer.PolicyPackage package = new Logic_Layer.PolicyPackage();
            package.PackageId = int.Parse(txtPackID.Text);
            dataGridViewCurPackPol.DataSource = package.packPolSearch();
            dataGridViewPackPol.DataSource = policy.populate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainMenu main = new mainMenu();
            main.Show();
            Close();
        }
    }
}
