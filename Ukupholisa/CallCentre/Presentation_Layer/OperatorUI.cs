using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa.CallCentre.Logic_Layer;

namespace Ukupholisa.CallCentre.Presentation_Layer
{
    public partial class OperatorUI : Form
    {
        ICRUD client = new Client();
        Family family = new Family();
        ICRUD policy = new Provider_Management.Logic_Layer.Policy();
        ICRUD medical = new Medical_Department.Logic_layer.MedCondition();


        public OperatorUI()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage1);

            tabControl1.SelectedIndex = 1;

            btnAnswer.Enabled = false;
            btnEndCall.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            //this does not exist--------IGNORE
        }

        private void OperatorUI_Load(object sender, EventArgs e)
        {
            radiobtnYes.Checked = true;
            dataGridViewPolicyList.DataSource = policy.populate();
            dataGridViewClientSummary.DataSource = client.populate();
            txtClientID.Enabled = false;
            cmbFamily_Role.SelectedIndex = 0;

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            btnEndCall.Enabled = false;

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (string.IsNullOrWhiteSpace(txtClientIDSearch.Text))
            {
                MessageBox.Show("Please provide a client ID");
            }
            else
            {
                client.UniqueIdentifier = txtClientIDSearch.Text;
                dataGridViewClientSummary.DataSource = client.search();
            }
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)//Updating the client details
        {
            //this does not exist--------IGNORE
        }

        private void button2_Click(object sender, EventArgs e)//refresh button
        {
            //need to refresh the database so that the changes may reflect without needing to close and open the program.
            dataGridViewClientSummary.DataSource = client.populate();
            dataGridViewClientSummary.Update();
            dataGridViewClientSummary.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IGNORE THIS
        }

        private void button6_Click(object sender, EventArgs e)//Searches the available policies for the medical condition entered.
        {
            Medical_Department.Logic_layer.MedCondition Medical = new Medical_Department.Logic_layer.MedCondition();

            if (string.IsNullOrWhiteSpace(txtMedConditionSearch.Text))
            {
                MessageBox.Show("Please provide a medical condition!");
            }
            else
            {
                Medical.MedConID = int.Parse(txtMedConditionSearch.Text);
                dataGridViewPolicyList.DataSource = Medical.search();
            }
        }

        private void radiobtnNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnYes.Checked)
            {
                txtNewFamilyId.Enabled = true;
            }
            else
            {
                txtNewFamilyId.Enabled = false;
            }
        }

        private void dataGridViewClientSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewClientSummary.Rows[e.RowIndex];

                txtClientID.Text = rows.Cells["Client_Code"].Value.ToString();
                txtClientName.Text = rows.Cells["Client_Name"].Value.ToString();
                txtClientSurname.Text = rows.Cells["Client_Surname"].Value.ToString();
                txtClientPhone.Text = rows.Cells["Client_Phone"].Value.ToString();
                txtClientAddress.Text = rows.Cells["Client_Address"].Value.ToString();

            }
        }

        private void dataGridViewPolicyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewPolicyList.Rows[e.RowIndex];

                txtNewPolID.Text = rows.Cells["Policy_Id"].Value.ToString();

            }
        }

        private void txtClientPolAdd_Click(object sender, EventArgs e)
        {

            //Client client = new Client();
            //Family fam = new Family();
            //client.Client_Id = 
            //client.Name = txtClientName.Text;
            //client.Surname = txtClientName.Text;
            //client.Phone = txtClientName.Text;
            //client.Address = txtClientName.Text;

            //fam.FamilyID = int.Parse(txtNewFamilyId.Text);
            //fam.Family_role = cmbFamily_Role.Text;

            //client.add();
        }

        private void btnSaveClient_Click_1(object sender, EventArgs e)
        {
           // Logic_Layer.Client client = new Client();

            Client client = new Client();
            Family fam = new Family();

            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Enter Client Name!");
                txtClientName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtClientSurname.Text))
            {
                MessageBox.Show("Enter Client Surname!");
                txtClientSurname.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtClientPhone.Text))
            {
                MessageBox.Show("Enter Client Phone number!");
                txtClientPhone.Select();            
            }
            else if (string.IsNullOrWhiteSpace(txtClientAddress.Text))
            {
                MessageBox.Show("Enter Client Address!");
                txtClientAddress.Select();
                return;
            }
            else if(client.validateStrings(txtClientName.Text))
            {
                // Name was incorrect
                MessageBox.Show("Invalid First Name", "Message");
                txtClientName.Focus();
                return;
            }
            else if(client.validateStrings(txtClientSurname.Text))
            {
                // Surname was incorrect
                MessageBox.Show("Invalid Last Name", "Message");
                txtClientSurname.Focus();
                return;
            }
            else if (client.validatePhone(txtClientPhone.Text))
            {
                // phone was incorrect
                MessageBox.Show("Invalid phone number", "Message");
                txtClientPhone.Focus();
                return;
            }
            else if (client.validateAddress(txtClientAddress.Text))
            {
                // address was incorrect
                MessageBox.Show("Invalid address", "Message");
                txtClientAddress.Focus();
                return;
            }
            else if (radiobtnYes.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(txtNewFamilyId.Text))
                {
                    MessageBox.Show("Enter Client Family number!");
                    txtNewFamilyId.Select();
                }
                

                client.Name = txtClientName.Text;
                client.Surname = txtClientSurname.Text;
                client.Phone = txtClientPhone.Text;
                client.Address = txtClientAddress.Text;

                client.UniqueIdentifier = client.getUniqueCode(cmbFamily_Role.Text);

                fam.FamilyID = int.Parse(txtNewFamilyId.Text);
                fam.Family_role = cmbFamily_Role.Text;
                client.addClientWithFamily(fam.Family_role, fam.FamilyID);
            }
            else
            {
                client.Name = txtClientName.Text;
                client.Surname = txtClientSurname.Text;
                client.Phone = txtClientPhone.Text;
                client.Address = txtClientAddress.Text;
                client.UniqueIdentifier = client.getUniqueCode(cmbFamily_Role.Text);
                fam.Family_role = cmbFamily_Role.Text;


                client.getFamilyRole(fam.Family_role);
            }
        }

        private void btnClientUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Enter Client Name!");
                txtClientName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtClientSurname.Text))
            {
                MessageBox.Show("Enter Client Surname!");
                txtClientSurname.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtClientPhone.Text))
            {
                MessageBox.Show("Enter Client Phone number!");
                txtClientPhone.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtClientAddress.Text))
            {
                MessageBox.Show("Enter Client Address!");
                txtClientAddress.Select();
            }
            else
            {
                Client client = new Client();
                Family fam = new Family();

                client.Name = txtClientName.Text;
                client.Surname = txtClientSurname.Text;
                client.Phone = txtClientPhone.Text;
                client.Address = txtClientAddress.Text;

                fam.FamilyID = int.Parse(txtNewFamilyId.Text);
                fam.Family_role = cmbFamily_Role.Text;

                client.update();
            }
        }

        private void radiobtnNo_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNewFamilyId.Enabled = false;
        }

        private void radiobtnYes_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbFamily_Role.Enabled = true;
            txtNewFamilyId.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            btnEndCall.Enabled = false;
            btnAnswer.Enabled = true;
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);

        }
    }
}

