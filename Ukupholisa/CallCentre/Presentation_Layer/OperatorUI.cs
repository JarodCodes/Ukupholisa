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
            //dataGridViewClientSummary.DataSource = client.populate();
            txtClientID.Enabled = false;
            cmbFamily_Role.SelectedIndex = 3;

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            btnEndCall.Enabled = false;

            btnClientPolAdd.Enabled = false;

            btnClientUpdate.Enabled = false;
            btnCancel.Hide();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.UniqueIdentifier = txtClientIDSearch.Text;
            DataTable dt = client.search();
            DataTable dtPolSearch = client.searchClientPol();


            if (string.IsNullOrWhiteSpace(txtClientIDSearch.Text))
            {
                MessageBox.Show("Please provide a client code!");
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No client found");
            }
            else
            {
                MessageBox.Show("Client found!");

                groupBox7.Enabled = false;

                foreach (DataRow item in dt.Rows)
                {
                    txtClientID.Text = item.Field<string>("Client_Code");
                    txtClientName.Text = item.Field<string>("Client_Name");
                    txtClientSurname.Text = item.Field<string>("Client_Surname");
                    txtClientPhone.Text = item.Field<string>("Client_Phone");
                    txtClientAddress.Text = item.Field<string>("Client_Address");
                    txtNewFamilyId.Text = item.Field<int>("Family_Id").ToString();
                    cmbFamily_Role.Text = item.Field<string>("Family_Role");
                }
                dataGridViewClientSummary.DataSource = dtPolSearch;

                btnCancel.Show();
                btnSaveClient.Enabled = false;
                btnClientUpdate.Enabled = true;
                btnClientPolAdd.Enabled = true;

                Button b = btnClientUpdate;
                Point point = new Point(108, 275);
                b.Location = point;
                txtClientIDSearch.Clear();
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

            if (medical.validateStrings(txtMedConditionSearch.Text))
            {
                MessageBox.Show("Invalid medical condition name!");
            }
            else
            {
                Medical.Name = txtMedConditionSearch.Text;
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
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow rows = this.dataGridViewClientSummary.Rows[e.RowIndex];

            //    txtClientID.Text = rows.Cells["Client_Code"].Value.ToString();
            //    txtClientName.Text = rows.Cells["Client_Name"].Value.ToString();
            //    txtClientSurname.Text = rows.Cells["Client_Surname"].Value.ToString();
            //    txtClientPhone.Text = rows.Cells["Client_Phone"].Value.ToString();
            //    txtClientAddress.Text = rows.Cells["Client_Address"].Value.ToString();

            //    groupBox7.Enabled = false;
                

            //}
        }

        private void dataGridViewPolicyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewPolicyList.Rows[e.RowIndex];

                txtNewPolID.Text = rows.Cells["Policy_Code"].Value.ToString();

            }
        }

        private void btnSaveClient_Click_1(object sender, EventArgs e)
        {
            Client client = new Client();
            Family fam = new Family();

            if(client.validateStrings(txtClientName.Text))
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
            else if (radiobtnYes.Checked.Equals(true))
            {
                if (client.validateFamilyId(txtNewFamilyId.Text))
                {
                    // address was incorrect
                    MessageBox.Show("Invalid Family Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClientAddress.Focus();
                    return;
                }
                else
                {
                    client.Name = txtClientName.Text;
                    client.Surname = txtClientSurname.Text;
                    client.Phone = txtClientPhone.Text;
                    client.Address = txtClientAddress.Text;
                    fam.FamilyID = int.Parse(txtNewFamilyId.Text);
                    fam.Family_role = cmbFamily_Role.Text;
                    client.UniqueIdentifier = client.getUniqueCode(client.getRoleCode(fam.Family_role));

                    if (MessageBox.Show("Are you sure you want to add the following client?\n" +
                                    "Name: " + client.Name + "\n" +
                                    "Surname: " + client.Surname + "\n" +
                                    "Phone: " + client.Phone + "\n" +
                                    "Address: " + client.Address + "\n" +
                                    "Family Id: " + fam.FamilyID.ToString() + "\n" +
                                    "Family Role: " + fam.Family_role + "\n", "Adding Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                    {
                        client.addClientWithFamily(fam.Family_role, fam.FamilyID);
                        clearAllData();
                        MessageBox.Show("The Client Code is: " + client.UniqueIdentifier,"Client Code");
                    }
                }
            }
            else
            {
                client.Name = txtClientName.Text;
                client.Surname = txtClientSurname.Text;
                client.Phone = txtClientPhone.Text;
                client.Address = txtClientAddress.Text;
                fam.Family_role = cmbFamily_Role.Text;
                client.UniqueIdentifier = client.getUniqueCode(client.getRoleCode(fam.Family_role));

                if (MessageBox.Show("Are you sure you want to add the following client?\n" +
                                    "Name: " + client.Name + "\n" +
                                    "Surname: " + client.Surname + "\n" +
                                    "Phone: " + client.Phone + "\n" +
                                    "Address: " + client.Address + "\n" +
                                    "Family Id: " + fam.FamilyID.ToString() + "\n" +
                                    "Family Role: " + fam.Family_role + "\n", "Adding Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    client.addClientWithoutFamily(fam.Family_role);
                    clearAllData();
                    MessageBox.Show("The Client Code is: " + client.UniqueIdentifier, "Client Code");
                }

                
            }
        }
        //update a client's details
        private void btnClientUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                Family fam = new Family();
                if (client.validateStrings(txtClientName.Text))
                {
                    // Name was incorrect
                    MessageBox.Show("Invalid First Name", "Message");
                    txtClientName.Focus();
                    return;
                }
                else if (client.validateStrings(txtClientSurname.Text))
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
                else
                {
                    client.UniqueIdentifier = txtClientID.Text;
                    client.Name = txtClientName.Text;
                    client.Surname = txtClientSurname.Text;
                    client.Phone = txtClientPhone.Text;
                    client.Address = txtClientAddress.Text;

                    fam.Family_role = cmbFamily_Role.Text;

                    client.updateClient(fam.Family_role);

                    MessageBox.Show("Record Updated Successfully!");
                    clearAllData();

                    Button b = (Button)sender;
                    Button cancelbtn = btnCancel;
                    b.Location = cancelbtn.Location;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

            clearAllData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            Point point = thisButton.Location;
            btnCancel.Hide();
            btnSaveClient.Enabled = true;

            
            Button b = btnClientUpdate;
            
            b.Location = point;
            groupBox7.Enabled = true;

            clearAllData();
        }

        private void clearAllData()
        {
            txtClientID.Clear();
            txtClientName.Clear();
            txtClientSurname.Clear();
            txtClientPhone.Clear();
            txtClientAddress.Clear();

            txtNewFamilyId.Clear();

            btnClientUpdate.Enabled = false;

            cmbFamily_Role.SelectedIndex = 3;
            radiobtnYes.Checked = false;
            radiobtnNo.Checked = false;


            dataGridViewClientSummary.DataSource = null;
            dataGridViewClientSummary.Rows.Clear();
        }

        private void btnClientPolAdd_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            Family fam = new Family();
            Provider_Management.Logic_Layer.Policy pol = new Provider_Management.Logic_Layer.Policy();


            client.add();
        }
    }
}

