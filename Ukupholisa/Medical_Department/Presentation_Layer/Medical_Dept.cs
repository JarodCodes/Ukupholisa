using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa.Medical_Department
{
    public partial class Medical_Dept : Form
    {
        public Medical_Dept()
        {
            InitializeComponent();
        }
        Logic_Layer.MedicalHandler medhandler = new Logic_Layer.MedicalHandler();
        Provider_Management.Logic_Layer.PolicyHandler policyhandler = new Provider_Management.Logic_Layer.PolicyHandler();
        private void Medical_Dept_Load(object sender, EventArgs e)
        {
            dataGridViewMedCon.DataSource = medhandler.PopulateMedCon();
            dataGridViewMedPolicies.DataSource = policyhandler.PopulatePolicy();
        }

        private void dataGridViewMedCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewMedCon.Rows[e.RowIndex];

                txtMedID.Text = rows.Cells["Condition_Id"].Value.ToString();
                txtMedName.Text = rows.Cells["Condition_Name"].Value.ToString();
                rtxtMedDesc.Text = rows.Cells["Condition_Description"].Value.ToString();
                txtMedPolicyID.Text = rows.Cells["Policy_Id"].Value.ToString();
            }
        }

        private void dataGridViewMedPolicies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewMedPolicies.Rows[e.RowIndex];

                txtMedPolicyID.Text = rows.Cells["Policy_Id"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.MedCondition medcon = new DataAccess_Layer.MedCondition();
                medcon.MedConID = int.Parse(txtMedID.Text);
                medcon.Name = txtMedName.Text;
                medcon.Description = rtxtMedDesc.Text;
                medcon.Treatment = txtTreatment.Text;
                medcon.PolicyID = int.Parse(txtMedPolicyID.Text);

                medhandler.addMedCon(medcon);
                MessageBox.Show("Condition was added");
            }
            catch (Exception)
            {
                MessageBox.Show("Condition was not added");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess_Layer.MedCondition medcon = new DataAccess_Layer.MedCondition();
                medcon.MedConID = int.Parse(txtMedID.Text);
                medcon.Name = txtMedName.Text;
                medcon.Description = rtxtMedDesc.Text;
                medcon.Treatment = txtTreatment.Text;
                medcon.PolicyID = int.Parse(txtMedPolicyID.Text);

                medhandler.updateMedCon(medcon);
                MessageBox.Show("Condition was updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Condition was not updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int medID = int.Parse(txtMedID.Text);

                medhandler.deleteMedCon(medID);
                MessageBox.Show("Condition was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Condition was not deleted");
            }
        }

        private void btnMedSearch_Click(object sender, EventArgs e)
        {
            dataGridViewMedCon.DataSource = medhandler.searchMedCon(int.Parse(txtMedSearch.Text));
        }

        private void btnMedPolicySearch_Click(object sender, EventArgs e)
        {
            dataGridViewMedPolicies.DataSource = policyhandler.searchPolicy(int.Parse(txtMedPolicyID.Text));
        }
    }
}
