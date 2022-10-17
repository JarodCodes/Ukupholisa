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

namespace Ukupholisa.CallCentre.Presentation_Layer
{
    public partial class OperatorUI : Form
    {

        ClientHandler clientHandler = new Logic_Layer.ClientHandler();
        Medical_Department.Logic_Layer.MedicalHandler medhandler = new Medical_Department.Logic_Layer.MedicalHandler();
        Provider_Management.Logic_Layer.PolicyHandler policy = new Provider_Management.Logic_Layer.PolicyHandler();

        public OperatorUI()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
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
            else if (radiobtnNo.Checked == true)
            {
                txtNewFamilyId.Text = "0";
            }
            else
            {
                clientHandler.saveClient(txtClientName.Text, txtClientSurname.Text, txtClientPhone.Text, txtClientAddress.Text, int.Parse(txtNewFamilyId.Text));
            }
        }

        private void OperatorUI_Load(object sender, EventArgs e)
        {
            radiobtnYes.Checked = true;
            dataGridViewPolicyList.DataSource = policy.PopulatePolicy();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientIDSearch.Text))
            {
                MessageBox.Show("Please provide a client ID");
            }
            else
            {
                dataGridViewClientSummary.DataSource = clientHandler.searchClient(int.Parse(txtClientIDSearch.Text));
            }
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)//Updating the client details
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
                clientHandler.updateClientDetails(int.Parse(txtClientID.Text), txtClientName.Text, txtClientSurname.Text, txtClientPhone.Text, txtClientAddress.Text, int.Parse(txtNewFamilyId.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//refresh button
        {
            //need to refresh the database so that the changes may reflect without needing to close and open the program.
        }

        private void button1_Click(object sender, EventArgs e)//Searches the available policies for the medical condition entered.
        {
            //if (string.IsNullOrWhiteSpace(txtClientIDSearch.Text))
            //{
            //    MessageBox.Show("Please provide a client ID");
            //}
            //else
            //{
            //    clientHandler.searchClient(new DataAccess_Layer.Client(txtClientIDSearch.Text));
            //}

            //redundant???????
        }

        private void button6_Click(object sender, EventArgs e)//Searches the available policies for the medical condition entered.
        {
            if (string.IsNullOrWhiteSpace(txtMedConditionSearch.Text))
            {
                MessageBox.Show("Please provide a medical condition!");
            }
            else
            {
                dataGridViewPolicyList.DataSource = medhandler.searchMedPol(int.Parse(txtMedConditionSearch.Text));
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
                txtNewFamilyId.Text = "0";
            }
        }

        private void dataGridViewClientSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewClientSummary.Rows[e.RowIndex];

                txtClientID.Text = rows.Cells["Client_Id"].Value.ToString();
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
            clientHandler.addClientPol(int.Parse(txtClientID.Text), int.Parse(txtNewPolID.Text));
        }
    }
    }
}
