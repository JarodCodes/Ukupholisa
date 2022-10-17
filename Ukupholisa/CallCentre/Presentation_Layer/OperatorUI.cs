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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter Client Name!");
                txtName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Enter Client Surname!");
                txtSurname.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Enter Client Phone number!");
                txtPhone.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Enter Client Address!");
                txtAddress.Select();
            }
            else if (radiobtnNo.Checked == true)
            {
                txtFamilyId.Text = "0";
            }
            else
            {
                clientHandler.saveClient(txtName.Text, txtSurname.Text, txtPhone.Text, txtAddress.Text, int.Parse(txtFamilyId.Text));
            }
        }

        private void OperatorUI_Load(object sender, EventArgs e)
        {
            radiobtnYes.Checked = true;
            dataGridView2.DataSource = policy.PopulatePolicy();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientIDSearch.Text))
            {
                MessageBox.Show("Please provide a client ID");
            }
            else
            {
                clientHandler.searchClient(int.Parse(txtClientIDSearch.Text));
            }
        }

        private void button4_Click(object sender, EventArgs e)//Updating the client details
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter Client Name!");
                txtName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Enter Client Surname!");
                txtSurname.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Enter Client Phone number!");
                txtPhone.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Enter Client Address!");
                txtAddress.Select();
            }
            else
            {
                clientHandler.updateClientDetails(int.Parse(txtClientIDSearch.Text));
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
                medhandler.searchMedCon(int.Parse(txtMedConditionSearch.Text));
            }
        }

        private void radiobtnNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnYes.Checked)
            {
                txtFamilyId.Enabled = true;
            }
            else
            {
                txtFamilyId.Enabled = false;
                txtFamilyId.Text = "0";
            }
        }
    }
}
