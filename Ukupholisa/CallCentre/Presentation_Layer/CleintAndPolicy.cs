using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa.CallCentre.Logic_Layer;
using Ukupholisa.Provider_Management.Logic_Layer;
using Ukupholisa.Medical_Department.Logic_layer;

namespace Ukupholisa.CallCentre.Presentation_Layer
{
    public partial class CleintAndPolicy : Form
    {
        
        public CleintAndPolicy()
        {
            InitializeComponent();
        }
        Family family = new Family();
        ICRUD policy = new Policy();
        Validation val = new Validation();
        private void CleintAndPolicy_Load(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = family.populate();
            dataGridViewPolicies.DataSource = policy.populate();
            cmbClientPolStatus.SelectedIndex = 1;
            cmbFamilyRole.SelectedIndex = 3;
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewClients.Rows[e.RowIndex];

                txtClientID.Text = rows.Cells["Client_Code"].Value.ToString();
                txtFamilyID.Text = rows.Cells["Family_Id"].Value.ToString();
            }
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                if (String.IsNullOrEmpty(txtClientID.Text))
                {
                    MessageBox.Show("Invalid code");
                }
                else
                {
                    client.UniqueIdentifier = txtClientID.Text;
                    if (MessageBox.Show("Are you sure you want to delete client " + client.UniqueIdentifier + "?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        client.delete();
                        MessageBox.Show("Client was deleted");

                        dataGridViewClients.DataSource = family.populate();

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Client was not deleted");
            }
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (String.IsNullOrEmpty(txtClientID.Text))
            {
                MessageBox.Show("Invalid code");
            }
            else
            {
                client.UniqueIdentifier = txtClientSearch.Text;
                DataTable dt = client.search();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No client found");
                }
                else
                {
                    MessageBox.Show("Client found");
                    dataGridViewClients.DataSource = dt;
                }
            }
        }

        private void btnFamAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();
                Client client = new Client();


                if (val.validateStrings(txtClientID.Text))
                {
                    MessageBox.Show("Invalid client ID!");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to add this client to the family?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        family.FamilyID = int.Parse(txtFamilyID.Text);
                        family.Family_role = cmbFamilyRole.Text;
                        client.UniqueIdentifier = txtFamClientID.Text;

                        family.addToFam(client.UniqueIdentifier);
                        dataGridViewFamily.DataSource = family.search();
                        MessageBox.Show("Client was added to family");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client was not added tp family" + ex.Message);
            }
        }

        private void dataGridViewFamily_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //sets text boxes to table values
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewFamily.Rows[e.RowIndex];

                txtFamClientID.Text = rows.Cells["Client_Code"].Value.ToString();
                cmbFamilyRole.Text = rows.Cells["Family_Role"].Value.ToString();
            }
        }

        private void btnFamUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();
                Client client = new Client();
                if (!int.TryParse(txtFamilyID.Text, out int famId))
                {
                    MessageBox.Show("Invalid family ID");
                }
                else if (!int.TryParse(txtFamClientID.Text, out int clientId))
                {
                    MessageBox.Show("Invalid client ID");
                }
                else
                {
                    family.FamilyID = famId;
                    family.Family_role = cmbFamilyRole.Text;
                    client.Client_Id = clientId;
                    family.update(client.Client_Id);
                    dataGridViewFamily.DataSource = family.search();
                    MessageBox.Show("Client was successfully updated!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Client was not updated!");
            }
        }

        private void btnFamRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();
                Client client = new Client();
                
                if (val.validateStrings(txtClientID.Text))
                {
                    MessageBox.Show("Invalid client ID!");
                }
                else 
                {
                    if (MessageBox.Show("Are you sure you want to remove this client from the family?", "Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        client.UniqueIdentifier = txtFamClientID.Text;
                        family.removeFromFam(client.UniqueIdentifier);
                        MessageBox.Show("Client was removed from family");
                        dataGridViewFamily.DataSource = family.search();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Client was not removed from family");
            }
        }

        private void btnFamDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();
                if (!int.TryParse(txtFamilyID.Text, out int famId))
                {
                    MessageBox.Show("Invalid family ID");
                }
                else 
                {
                    if (MessageBox.Show("Are you sure you want to delete the entire family?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        family.FamilyID = famId;
                        family.delete();
                        dataGridViewFamily.DataSource = family.search();
                        MessageBox.Show("Family was deleted");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Family was not deleted");
            }
        }

        private void txtFamilyID_TextChanged(object sender, EventArgs e)
        {
            //supplies following forms with information
            Family family = new Family();
            Policy policy = new Policy();
            family.FamilyID = int.Parse(txtFamilyID.Text);
            dataGridViewFamily.DataSource = family.search();
            dataGridViewCurFamPol.DataSource = policy.famPolSearch(family.FamilyID);
        }

        private void btnFamPolSearch_Click(object sender, EventArgs e)
        {
            Policy policy = new Policy();
            if (!int.TryParse(txtFamPolSearch.Text, out int polId))
            {
                MessageBox.Show("Invalid policy ID");
            }
            else
            {
                policy.PolicyId = polId;
                DataTable dt = policy.search();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No policy found");
                }
                else
                {
                    MessageBox.Show("Policy found");
                    dataGridViewPolicies.DataSource = dt;
                }
            }   
        }

        private void btnFamPolAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();

                Policy policy = new Policy();
                if (!int.TryParse(txtFamilyID.Text, out int famId))
                {
                    MessageBox.Show("Invalid family ID");
                }
                else if (!int.TryParse(txtFamPolSearch.Text, out int polId))
                {
                    MessageBox.Show("Invalid policy ID");
                }
                else
                {
                    policy.PolicyId = polId;
                    family.FamilyID = famId;

                    family.addFamPol(policy.PolicyId);
                    dataGridViewCurFamPol.DataSource = policy.famPolSearch(family.FamilyID);
                    MessageBox.Show("Policy was added to family");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not added tp family");
            }
        }

        private void dataGridViewPolicies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewPolicies.Rows[e.RowIndex];

                txtFamPolSearch.Text = rows.Cells["Policy_Id"].Value.ToString();
            }
        }

        private void btnFamPolRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();
                Policy policy = new Policy();
                if (!int.TryParse(txtFamilyID.Text, out int famId))
                {
                    MessageBox.Show("Invalid family ID");
                }
                else if (!int.TryParse(txtFamPolSearch.Text, out int polId))
                {
                    MessageBox.Show("Invalid policy ID");
                }
                else
                {
                    policy.PolicyId = polId;
                    family.FamilyID = famId;
                    family.removeFamPol();
                    dataGridViewCurFamPol.DataSource = policy.famPolSearch(family.FamilyID);
                    MessageBox.Show("Policy was removed");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Policy was not removed");
            }
        }

        private void dataGridViewCurFamPol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewCurFamPol.Rows[e.RowIndex];

                txtFamPolSearch.Text = rows.Cells["Policy_Id"].Value.ToString();
            }
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            Policy policy = new Policy();
            Client client = new Client();
            client.UniqueIdentifier = txtClientID.Text;
            dataGridViewClientPol.DataSource = policy.clientPolSearch(client.UniqueIdentifier);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Policy policy = new Policy();
                policy.Status = cmbClientPolStatus.Text;

                if (policy.checkStatus((DataTable)dataGridViewClientPol.DataSource, policy.Status))
                {
                    policy.PolCode = txtClientPolSearch.Text;
                    Client client = new Client();
                    client.UniqueIdentifier = txtClientID.Text;
                    
                    policy.updateStatus(client.UniqueIdentifier);
                    dataGridViewClientPol.DataSource = policy.clientPolSearch(client.UniqueIdentifier);
                    MessageBox.Show("Policy status was updated!");
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show("Policy status was not updated!" + ex.Message);
            }
        }

        private void dataGridViewClientPol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewClientPol.Rows[e.RowIndex];

                txtClientPolSearch.Text = rows.Cells["Policy_Code"].Value.ToString();
                cmbClientPolStatus.Text = rows.Cells["Policy_Status"].Value.ToString();
            }
        }

        private void btnClientRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = family.populate();
        }

        private void btnFamPolRefresh_Click(object sender, EventArgs e)
        {
            Policy policy = new Policy();
            Family family = new Family();
            policy.PolicyId = int.Parse(txtFamPolSearch.Text);
            family.FamilyID = int.Parse(txtFamilyID.Text);
            dataGridViewCurFamPol.DataSource = policy.famPolSearch(family.FamilyID);
            dataGridViewPolicies.DataSource = policy.populate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainMenu main = new mainMenu();
            main.Show();
            Close();
        }
    }
}
