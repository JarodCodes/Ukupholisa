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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBoxMedOperations = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedID = new System.Windows.Forms.TextBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listbTreatment = new System.Windows.Forms.ListBox();
            this.listbPolicy = new System.Windows.Forms.ListBox();
            this.rtxtMedDesc = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxMedSearch = new System.Windows.Forms.GroupBox();
            this.txtMedSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMedSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedCon)).BeginInit();
            this.groupBoxMedData.SuspendLayout();
            this.groupBoxMedOperations.SuspendLayout();
            this.groupBoxMedSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMedCon
            // 
            this.dataGridViewMedCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedCon.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMedCon.Name = "dataGridViewMedCon";
            this.dataGridViewMedCon.Size = new System.Drawing.Size(478, 401);
            this.dataGridViewMedCon.TabIndex = 0;
            // 
            // groupBoxMedData
            // 
            this.groupBoxMedData.Controls.Add(this.btnNext);
            this.groupBoxMedData.Controls.Add(this.btnPrev);
            this.groupBoxMedData.Controls.Add(this.dataGridViewMedCon);
            this.groupBoxMedData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMedData.Name = "groupBoxMedData";
            this.groupBoxMedData.Size = new System.Drawing.Size(491, 454);
            this.groupBoxMedData.TabIndex = 1;
            this.groupBoxMedData.TabStop = false;
            this.groupBoxMedData.Text = "Medical Conditions";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(6, 426);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(409, 426);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // groupBoxMedOperations
            // 
            this.groupBoxMedOperations.Controls.Add(this.btnDelete);
            this.groupBoxMedOperations.Controls.Add(this.btnUpdate);
            this.groupBoxMedOperations.Controls.Add(this.btnAdd);
            this.groupBoxMedOperations.Controls.Add(this.rtxtMedDesc);
            this.groupBoxMedOperations.Controls.Add(this.listbPolicy);
            this.groupBoxMedOperations.Controls.Add(this.listbTreatment);
            this.groupBoxMedOperations.Controls.Add(this.label5);
            this.groupBoxMedOperations.Controls.Add(this.label4);
            this.groupBoxMedOperations.Controls.Add(this.label3);
            this.groupBoxMedOperations.Controls.Add(this.txtMedName);
            this.groupBoxMedOperations.Controls.Add(this.label2);
            this.groupBoxMedOperations.Controls.Add(this.txtMedID);
            this.groupBoxMedOperations.Controls.Add(this.label1);
            this.groupBoxMedOperations.Location = new System.Drawing.Point(509, 12);
            this.groupBoxMedOperations.Name = "groupBoxMedOperations";
            this.groupBoxMedOperations.Size = new System.Drawing.Size(279, 335);
            this.groupBoxMedOperations.TabIndex = 4;
            this.groupBoxMedOperations.TabStop = false;
            this.groupBoxMedOperations.Text = "Operations";
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
            // txtMedID
            // 
            this.txtMedID.Location = new System.Drawing.Point(90, 42);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.Size = new System.Drawing.Size(183, 20);
            this.txtMedID.TabIndex = 6;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Treatment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Policy";
            // 
            // listbTreatment
            // 
            this.listbTreatment.FormattingEnabled = true;
            this.listbTreatment.Location = new System.Drawing.Point(90, 198);
            this.listbTreatment.Name = "listbTreatment";
            this.listbTreatment.Size = new System.Drawing.Size(183, 30);
            this.listbTreatment.TabIndex = 14;
            // 
            // listbPolicy
            // 
            this.listbPolicy.FormattingEnabled = true;
            this.listbPolicy.Location = new System.Drawing.Point(90, 234);
            this.listbPolicy.Name = "listbPolicy";
            this.listbPolicy.Size = new System.Drawing.Size(183, 30);
            this.listbPolicy.TabIndex = 15;
            // 
            // rtxtMedDesc
            // 
            this.rtxtMedDesc.Location = new System.Drawing.Point(90, 94);
            this.rtxtMedDesc.Name = "rtxtMedDesc";
            this.rtxtMedDesc.Size = new System.Drawing.Size(183, 98);
            this.rtxtMedDesc.TabIndex = 16;
            this.rtxtMedDesc.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxMedSearch
            // 
            this.groupBoxMedSearch.Controls.Add(this.btnMedSearch);
            this.groupBoxMedSearch.Controls.Add(this.txtMedSearch);
            this.groupBoxMedSearch.Controls.Add(this.label6);
            this.groupBoxMedSearch.Location = new System.Drawing.Point(509, 353);
            this.groupBoxMedSearch.Name = "groupBoxMedSearch";
            this.groupBoxMedSearch.Size = new System.Drawing.Size(279, 113);
            this.groupBoxMedSearch.TabIndex = 5;
            this.groupBoxMedSearch.TabStop = false;
            this.groupBoxMedSearch.Text = "Search";
            // 
            // txtMedSearch
            // 
            this.txtMedSearch.Location = new System.Drawing.Point(30, 36);
            this.txtMedSearch.Name = "txtMedSearch";
            this.txtMedSearch.Size = new System.Drawing.Size(243, 20);
            this.txtMedSearch.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID";
            // 
            // btnMedSearch
            // 
            this.btnMedSearch.Location = new System.Drawing.Point(9, 75);
            this.btnMedSearch.Name = "btnMedSearch";
            this.btnMedSearch.Size = new System.Drawing.Size(264, 23);
            this.btnMedSearch.TabIndex = 19;
            this.btnMedSearch.Text = "Search";
            this.btnMedSearch.UseVisualStyleBackColor = true;
            // 
            // Medical_Dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBoxMedSearch);
            this.Controls.Add(this.groupBoxMedOperations);
            this.Controls.Add(this.groupBoxMedData);
            this.Name = "Medical_Dept";
            this.Text = "Medical_Dept";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedCon)).EndInit();
            this.groupBoxMedData.ResumeLayout(false);
            this.groupBoxMedOperations.ResumeLayout(false);
            this.groupBoxMedOperations.PerformLayout();
            this.groupBoxMedSearch.ResumeLayout(false);
            this.groupBoxMedSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMedCon;
        private System.Windows.Forms.GroupBox groupBoxMedData;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox groupBoxMedOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtxtMedDesc;
        private System.Windows.Forms.ListBox listbPolicy;
        private System.Windows.Forms.ListBox listbTreatment;
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
    }
}