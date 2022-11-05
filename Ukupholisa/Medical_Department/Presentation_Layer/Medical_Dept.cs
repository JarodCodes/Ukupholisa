using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa.Provider_Management.Logic_Layer;

namespace Ukupholisa.Medical_Department
{
    public partial class Medical_Dept : Form
    {
        public Medical_Dept()
        {
            InitializeComponent();
        }
        ICRUD medcon = new Logic_layer.MedCondition();
        ICRUD policy = new Policy();
        Provider provider = new Provider();
        private void Medical_Dept_Load(object sender, EventArgs e)
        {
            dataGridViewMedCon.DataSource = medcon.populate();
            dataGridViewMedPolicies.DataSource = policy.populate();
            TreeNode treeNode = new TreeNode();
            TreeNode pendingNode = new TreeNode();
            TreeNode progressNode = new TreeNode();
            foreach (DataRow dr in provider.getProviderInfo().Rows)
            {
                treeNode = treeViewTreatments.Nodes.Add(dr["Provider_Name"].ToString());
                pendingNode = treeNode.Nodes.Add("Pending");
                PopulateTreeViewChildPending(Convert.ToInt32(dr["Provider_Id"].ToString()), pendingNode);
                progressNode = treeNode.Nodes.Add("In Progress");
                PopulateTreeViewChildProgress(Convert.ToInt32(dr["Provider_Id"].ToString()), progressNode);
            }
        }
        private void PopulateTreeViewChildPending(int parentId, TreeNode ParentNode)
        {
            provider.ProviderId = parentId;
            TreeNode childnode = new TreeNode();
            foreach (DataRow dr in provider.getCurrentTreatmentsPending().Rows)
            {
                if (ParentNode == null)
                    childnode = treeViewTreatments.Nodes.Add(dr["Condition_Treatment"].ToString()+" (Total: "+dr["Total"].ToString() + ")");
                else
                    childnode = ParentNode.Nodes.Add(dr["Condition_Treatment"].ToString() + " (Total: " + dr["Total"].ToString() + ")");

            }

        }
        private void PopulateTreeViewChildProgress(int parentId, TreeNode ParentNode)
        {
            provider.ProviderId = parentId;
            TreeNode childnode = new TreeNode();
            foreach (DataRow dr in provider.getCurrentTreatmentsProgress().Rows)
            {
                if (ParentNode == null)
                    childnode = treeViewTreatments.Nodes.Add(dr["Condition_Treatment"].ToString() + " (Total: " + dr["Total"].ToString() + ")");
                else
                    childnode = ParentNode.Nodes.Add(dr["Condition_Treatment"].ToString() + " (Total: " + dr["Total"].ToString() + ")");

            }

        }
        private void dataGridViewMedCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridViewMedCon.Rows[e.RowIndex];

                txtMedID.Text = rows.Cells["Condition_Id"].Value.ToString();
                txtMedName.Text = rows.Cells["Condition_Name"].Value.ToString();
                rtxtMedDesc.Text = rows.Cells["Condition_Description"].Value.ToString();
                txtTreatment.Text = rows.Cells["Condition_Treatment"].Value.ToString();
                txtMedPolicyID.Text = rows.Cells["Policy_Id"].Value.ToString();
                spinDuration.Value = int.Parse(rows.Cells["Condition_Duration"].Value.ToString());
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
                Logic_layer.MedCondition medcon = new Logic_layer.MedCondition();
                //medcon.MedConID = int.Parse(txtMedID.Text);
                medcon.Name = txtMedName.Text;
                medcon.Description = rtxtMedDesc.Text;
                medcon.Treatment = txtTreatment.Text;
                medcon.PolicyID = int.Parse(txtMedPolicyID.Text);
                medcon.Duration = (int)spinDuration.Value;

                medcon.add();
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
                Logic_layer.MedCondition medcon = new Logic_layer.MedCondition();
                medcon.MedConID = int.Parse(txtMedID.Text);
                medcon.Name = txtMedName.Text;
                medcon.Description = rtxtMedDesc.Text;
                medcon.Treatment = txtTreatment.Text;
                medcon.PolicyID = int.Parse(txtMedPolicyID.Text);
                medcon.Duration = (int)spinDuration.Value;

                medcon.update();
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
                Logic_layer.MedCondition medcon = new Logic_layer.MedCondition();
                medcon.MedConID = int.Parse(txtMedID.Text);

                medcon.delete();
                MessageBox.Show("Condition was deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Condition was not deleted");
            }
        }

        private void btnMedSearch_Click(object sender, EventArgs e)
        {
            Logic_layer.MedCondition medcon = new Logic_layer.MedCondition();
            medcon.MedConID = int.Parse(txtMedSearch.Text);
            DataTable dt = medcon.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No condition found");
            }
            else
            {
                MessageBox.Show("Condition found");
                dataGridViewMedCon.DataSource = dt;
            }
        }

        private void btnMedPolicySearch_Click(object sender, EventArgs e)
        {
            Policy policy = new Policy();
            policy.PolicyId = int.Parse(txtMedPolicySearch.Text);
            DataTable dt = policy.search();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No policy found");
            }
            else
            {
                MessageBox.Show("Policy found");
                dataGridViewMedPolicies.DataSource = dt;
            }
        }
    }
}
