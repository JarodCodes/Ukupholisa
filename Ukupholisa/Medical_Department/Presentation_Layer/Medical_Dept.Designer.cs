namespace Ukupholisa.Medical_Department
{
    partial class Medical_Dept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMedCon = new System.Windows.Forms.DataGridView();
            this.groupBoxMedData = new System.Windows.Forms.GroupBox();
            this.btnMedNext = new System.Windows.Forms.Button();
            this.btnMedPrev = new System.Windows.Forms.Button();
            this.groupBoxMedOperations = new System.Windows.Forms.GroupBox();
            this.txtMedPolicyID = new System.Windows.Forms.TextBox();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtxtMedDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMedSearch = new System.Windows.Forms.GroupBox();
            this.btnMedPolicySearch = new System.Windows.Forms.Button();
            this.txtMedPolicySearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMedSearch = new System.Windows.Forms.Button();
            this.txtMedSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMedPolicies = new System.Windows.Forms.GroupBox();
            this.btnMedPolicyNext = new System.Windows.Forms.Button();
            this.btnMedPolicyPrev = new System.Windows.Forms.Button();
            this.dataGridViewMedPolicies = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.spinDuration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedCon)).BeginInit();
            this.groupBoxMedData.SuspendLayout();
            this.groupBoxMedOperations.SuspendLayout();
            this.groupBoxMedSearch.SuspendLayout();
            this.groupBoxMedPolicies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedPolicies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedCon
            // 
            this.dataGridViewMedCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedCon.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMedCon.Name = "dataGridViewMedCon";
            this.dataGridViewMedCon.Size = new System.Drawing.Size(478, 173);
            this.dataGridViewMedCon.TabIndex = 0;
            this.dataGridViewMedCon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedCon_CellContentClick);
            // 
            // groupBoxMedData
            // 
            this.groupBoxMedData.Controls.Add(this.btnMedNext);
            this.groupBoxMedData.Controls.Add(this.btnMedPrev);
            this.groupBoxMedData.Controls.Add(this.dataGridViewMedCon);
            this.groupBoxMedData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMedData.Name = "groupBoxMedData";
            this.groupBoxMedData.Size = new System.Drawing.Size(491, 233);
            this.groupBoxMedData.TabIndex = 1;
            this.groupBoxMedData.TabStop = false;
            this.groupBoxMedData.Text = "Medical Conditions";
            // 
            // btnMedNext
            // 
            this.btnMedNext.Location = new System.Drawing.Point(409, 197);
            this.btnMedNext.Name = "btnMedNext";
            this.btnMedNext.Size = new System.Drawing.Size(75, 23);
            this.btnMedNext.TabIndex = 3;
            this.btnMedNext.Text = ">";
            this.btnMedNext.UseVisualStyleBackColor = true;
            // 
            // btnMedPrev
            // 
            this.btnMedPrev.Location = new System.Drawing.Point(6, 197);
            this.btnMedPrev.Name = "btnMedPrev";
            this.btnMedPrev.Size = new System.Drawing.Size(75, 23);
            this.btnMedPrev.TabIndex = 2;
            this.btnMedPrev.Text = "<";
            this.btnMedPrev.UseVisualStyleBackColor = true;
            // 
            // groupBoxMedOperations
            // 
            this.groupBoxMedOperations.Controls.Add(this.spinDuration);
            this.groupBoxMedOperations.Controls.Add(this.label8);
            this.groupBoxMedOperations.Controls.Add(this.txtMedPolicyID);
            this.groupBoxMedOperations.Controls.Add(this.txtTreatment);
            this.groupBoxMedOperations.Controls.Add(this.btnDelete);
            this.groupBoxMedOperations.Controls.Add(this.btnUpdate);
            this.groupBoxMedOperations.Controls.Add(this.btnAdd);
            this.groupBoxMedOperations.Controls.Add(this.rtxtMedDesc);
            this.groupBoxMedOperations.Controls.Add(this.label5);
            this.groupBoxMedOperations.Controls.Add(this.label4);
            this.groupBoxMedOperations.Controls.Add(this.label3);
            this.groupBoxMedOperations.Controls.Add(this.txtMedName);
            this.groupBoxMedOperations.Controls.Add(this.label2);
            this.groupBoxMedOperations.Controls.Add(this.txtMedID);
            this.groupBoxMedOperations.Controls.Add(this.label1);
            this.groupBoxMedOperations.Location = new System.Drawing.Point(509, 12);
            this.groupBoxMedOperations.Name = "groupBoxMedOperations";
            this.groupBoxMedOperations.Size = new System.Drawing.Size(279, 353);
            this.groupBoxMedOperations.TabIndex = 4;
            this.groupBoxMedOperations.TabStop = false;
            this.groupBoxMedOperations.Text = "Condition Operations";
            // 
            // txtMedPolicyID
            // 
            this.txtMedPolicyID.Location = new System.Drawing.Point(90, 225);
            this.txtMedPolicyID.Name = "txtMedPolicyID";
            this.txtMedPolicyID.Size = new System.Drawing.Size(183, 20);
            this.txtMedPolicyID.TabIndex = 20;
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(90, 200);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(183, 20);
            this.txtTreatment.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtxtMedDesc
            // 
            this.rtxtMedDesc.Location = new System.Drawing.Point(90, 94);
            this.rtxtMedDesc.Name = "rtxtMedDesc";
            this.rtxtMedDesc.Size = new System.Drawing.Size(183, 98);
            this.rtxtMedDesc.TabIndex = 16;
            this.rtxtMedDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Policy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Treatment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(90, 68);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(183, 20);
            this.txtMedName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // txtMedID
            // 
            this.txtMedID.Location = new System.Drawing.Point(90, 42);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.Size = new System.Drawing.Size(183, 20);
            this.txtMedID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // groupBoxMedSearch
            // 
            this.groupBoxMedSearch.Controls.Add(this.btnMedPolicySearch);
            this.groupBoxMedSearch.Controls.Add(this.txtMedPolicySearch);
            this.groupBoxMedSearch.Controls.Add(this.label7);
            this.groupBoxMedSearch.Controls.Add(this.btnMedSearch);
            this.groupBoxMedSearch.Controls.Add(this.txtMedSearch);
            this.groupBoxMedSearch.Controls.Add(this.label6);
            this.groupBoxMedSearch.Location = new System.Drawing.Point(509, 371);
            this.groupBoxMedSearch.Name = "groupBoxMedSearch";
            this.groupBoxMedSearch.Size = new System.Drawing.Size(279, 113);
            this.groupBoxMedSearch.TabIndex = 5;
            this.groupBoxMedSearch.TabStop = false;
            this.groupBoxMedSearch.Text = "Search";
            // 
            // btnMedPolicySearch
            // 
            this.btnMedPolicySearch.Location = new System.Drawing.Point(144, 75);
            this.btnMedPolicySearch.Name = "btnMedPolicySearch";
            this.btnMedPolicySearch.Size = new System.Drawing.Size(129, 23);
            this.btnMedPolicySearch.TabIndex = 23;
            this.btnMedPolicySearch.Text = "Policy Search";
            this.btnMedPolicySearch.UseVisualStyleBackColor = true;
            this.btnMedPolicySearch.Click += new System.EventHandler(this.btnMedPolicySearch_Click);
            // 
            // txtMedPolicySearch
            // 
            this.txtMedPolicySearch.Location = new System.Drawing.Point(77, 46);
            this.txtMedPolicySearch.Name = "txtMedPolicySearch";
            this.txtMedPolicySearch.Size = new System.Drawing.Size(196, 20);
            this.txtMedPolicySearch.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Policy ID";
            // 
            // btnMedSearch
            // 
            this.btnMedSearch.Location = new System.Drawing.Point(9, 75);
            this.btnMedSearch.Name = "btnMedSearch";
            this.btnMedSearch.Size = new System.Drawing.Size(129, 23);
            this.btnMedSearch.TabIndex = 19;
            this.btnMedSearch.Text = "Condition Search";
            this.btnMedSearch.UseVisualStyleBackColor = true;
            this.btnMedSearch.Click += new System.EventHandler(this.btnMedSearch_Click);
            // 
            // txtMedSearch
            // 
            this.txtMedSearch.Location = new System.Drawing.Point(77, 22);
            this.txtMedSearch.Name = "txtMedSearch";
            this.txtMedSearch.Size = new System.Drawing.Size(196, 20);
            this.txtMedSearch.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Condition ID";
            // 
            // groupBoxMedPolicies
            // 
            this.groupBoxMedPolicies.Controls.Add(this.btnMedPolicyNext);
            this.groupBoxMedPolicies.Controls.Add(this.btnMedPolicyPrev);
            this.groupBoxMedPolicies.Controls.Add(this.dataGridViewMedPolicies);
            this.groupBoxMedPolicies.Location = new System.Drawing.Point(12, 251);
            this.groupBoxMedPolicies.Name = "groupBoxMedPolicies";
            this.groupBoxMedPolicies.Size = new System.Drawing.Size(491, 233);
            this.groupBoxMedPolicies.TabIndex = 4;
            this.groupBoxMedPolicies.TabStop = false;
            this.groupBoxMedPolicies.Text = "Policies";
            // 
            // btnMedPolicyNext
            // 
            this.btnMedPolicyNext.Location = new System.Drawing.Point(409, 197);
            this.btnMedPolicyNext.Name = "btnMedPolicyNext";
            this.btnMedPolicyNext.Size = new System.Drawing.Size(75, 23);
            this.btnMedPolicyNext.TabIndex = 3;
            this.btnMedPolicyNext.Text = ">";
            this.btnMedPolicyNext.UseVisualStyleBackColor = true;
            // 
            // btnMedPolicyPrev
            // 
            this.btnMedPolicyPrev.Location = new System.Drawing.Point(6, 197);
            this.btnMedPolicyPrev.Name = "btnMedPolicyPrev";
            this.btnMedPolicyPrev.Size = new System.Drawing.Size(75, 23);
            this.btnMedPolicyPrev.TabIndex = 2;
            this.btnMedPolicyPrev.Text = "<";
            this.btnMedPolicyPrev.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedPolicies
            // 
            this.dataGridViewMedPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedPolicies.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMedPolicies.Name = "dataGridViewMedPolicies";
            this.dataGridViewMedPolicies.Size = new System.Drawing.Size(478, 173);
            this.dataGridViewMedPolicies.TabIndex = 0;
            this.dataGridViewMedPolicies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedPolicies_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Duration (Days)";
            // 
            // spinDuration
            // 
            this.spinDuration.Location = new System.Drawing.Point(90, 251);
            this.spinDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDuration.Name = "spinDuration";
            this.spinDuration.Size = new System.Drawing.Size(183, 20);
            this.spinDuration.TabIndex = 22;
            this.spinDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Medical_Dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBoxMedPolicies);
            this.Controls.Add(this.groupBoxMedSearch);
            this.Controls.Add(this.groupBoxMedOperations);
            this.Controls.Add(this.groupBoxMedData);
            this.Name = "Medical_Dept";
            this.Text = "Medical_Dept";
            this.Load += new System.EventHandler(this.Medical_Dept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedCon)).EndInit();
            this.groupBoxMedData.ResumeLayout(false);
            this.groupBoxMedOperations.ResumeLayout(false);
            this.groupBoxMedOperations.PerformLayout();
            this.groupBoxMedSearch.ResumeLayout(false);
            this.groupBoxMedSearch.PerformLayout();
            this.groupBoxMedPolicies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedPolicies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMedCon;
        private System.Windows.Forms.GroupBox groupBoxMedData;
        private System.Windows.Forms.Button btnMedNext;
        private System.Windows.Forms.Button btnMedPrev;
        private System.Windows.Forms.GroupBox groupBoxMedOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtxtMedDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedID;
        private System.Windows.Forms.GroupBox groupBoxMedSearch;
        private System.Windows.Forms.Button btnMedSearch;
        private System.Windows.Forms.TextBox txtMedSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.TextBox txtMedPolicyID;
        private System.Windows.Forms.GroupBox groupBoxMedPolicies;
        private System.Windows.Forms.Button btnMedPolicyNext;
        private System.Windows.Forms.Button btnMedPolicyPrev;
        private System.Windows.Forms.DataGridView dataGridViewMedPolicies;
        private System.Windows.Forms.TextBox txtMedPolicySearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMedPolicySearch;
        private System.Windows.Forms.NumericUpDown spinDuration;
        private System.Windows.Forms.Label label8;
    }
}