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
        ICRUD client = new Client();
        Family family = new Family();
        ICRUD policy = new Policy();
        private void CleintAndPolicy_Load(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = family.populate();
            dataGridViewPolicies.DataSource = policy.populate();
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewClients.Rows[e.RowIndex];

                txtClientID.Text = rows.Cells["Client_Code"].Value.ToString();
                txtClientName.Text = rows.Cells["Client_Name"].Value.ToString();
                txtClientSurname.Text = rows.Cells["Client_Surname"].Value.ToString();
                txtClientPhone.Text = rows.Cells["Client_Phone"].Value.ToString();
                txtClientAddress.Text = rows.Cells["Client_Address"].Value.ToString();
                txtFamilyID.Text = rows.Cells["Family_Id"].Value.ToString();
            }
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Client client = new Client();
            //    client.UniqueIdentifier = txtClientID.Text;
            //    client.Name = txtClientName.Text;
            //    client.Surname = txtClientSurname.Text;
            //    client.Phone = txtClientPhone.Text;
            //    client.Address = txtClientAddress.Text;

            //    client.update();
            //    MessageBox.Show("Client was updated");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Client was not updated");
            //}
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                client.UniqueIdentifier = txtClientID.Text;

                if (MessageBox.Show("Are you sure you want to delete client " + client.UniqueIdentifier + "?", "WARNING" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    client.delete(); 
                    MessageBox.Show("Client was deleted");

                    dataGridViewClients.DataSource = family.populate();
                    dataGridViewClients.Update();
                    dataGridViewClients.Refresh();

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

        private void btnFamAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();
                family.FamilyID = int.Parse(txtFamilyID.Text);
                family.Family_role = cmbFamilyRole.Text;
                Client client = new Client();
                client.Client_Id = int.Parse(txtFamClientID.Text);

                family.addToFam(client.Client_Id);
                MessageBox.Show("Client was added to family");
            }
            catch (Exception)
            {
                MessageBox.Show("Client was not added tp family");
            }
        }

        private void dataGridViewFamily_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                family.FamilyID = int.Parse(txtFamilyID.Text);
                family.Family_role = cmbFamilyRole.Text;
                Client client = new Client();
                client.Client_Id = int.Parse(txtFamClientID.Text);

                family.update(client.Client_Id);
                MessageBox.Show("Client was successfully updated!");
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
                client.Client_Id = int.Parse(txtFamClientID.Text);
                family.removeFromFam(client.Client_Id);
                MessageBox.Show("Client was removed from family");
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
                family.FamilyID = int.Parse(txtFamilyID.Text);
                family.delete();
                MessageBox.Show("Family was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Family was not deleted");
            }
        }

        private void txtFamilyID_TextChanged(object sender, EventArgs e)
        {
            Family family = new Family();
            Policy policy = new Policy();
            family.FamilyID = int.Parse(txtFamilyID.Text);
            dataGridViewFamily.DataSource = family.search();
            dataGridViewCurFamPol.DataSource = policy.famPolSearch(family.FamilyID);
        }

        private void btnFamPolSearch_Click(object sender, EventArgs e)
        {
            Policy policy = new Policy();
            policy.PolicyId = int.Parse(txtFamPolSearch.Text);
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

        private void btnFamPolAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Family family = new Family();
                family.FamilyID = int.Parse(txtFamilyID.Text);
                Policy policy = new Policy();
                policy.PolicyId = int.Parse(txtFamPolSearch.Text);

                family.addFamPol(policy.PolicyId);
                MessageBox.Show("Policy was added to family");
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
                family.FamilyID = int.Parse(txtFamilyID.Text);
                family.removeFamPol();
                MessageBox.Show("Policy was removed");
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
                    policy.PolicyId = int.Parse(txtClientPolSearch.Text);
                    Client client = new Client();
                    client.UniqueIdentifier = txtClientID.Text;
                    
                    policy.updateStatus(client.UniqueIdentifier);
                    dataGridViewClientPol.DataSource = policy.clientPolSearch(client.UniqueIdentifier);
                    MessageBox.Show("Policy status was updated!");
                }
                else 
                {
                    MessageBox.Show("Policy status was not updated!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Policy status was not updated!");
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
    }
}
