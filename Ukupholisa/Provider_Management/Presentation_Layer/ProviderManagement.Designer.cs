﻿
namespace Ukupholisa.Provider_Management.Presentation_Layer
{
    partial class ProviderManagement
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
            this.groupBoxProvData = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataGridViewProv = new System.Windows.Forms.DataGridView();
            this.tabControlProviderManagement = new System.Windows.Forms.TabControl();
            this.tabPageProvider = new System.Windows.Forms.TabPage();
            this.tabPagePolicy = new System.Windows.Forms.TabPage();
            this.groupBoxProvOperations = new System.Windows.Forms.GroupBox();
            this.listbStatus = new System.Windows.Forms.ListBox();
            this.txtProvLocation = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProvLocation = new System.Windows.Forms.TextBox();
            this.btnProvDelete = new System.Windows.Forms.Button();
            this.btnProvUpdate = new System.Windows.Forms.Button();
            this.btnProvAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProvName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProvID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProvData = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dataGridViewProv = new System.Windows.Forms.DataGridView();
            this.txtProvLocation = new System.Windows.Forms.TextBox();
            this.listbStatus = new System.Windows.Forms.ListBox();
            this.groupBoxProvSearch.SuspendLayout();
            this.groupBoxProvOperations.SuspendLayout();
            this.groupBoxProvData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProv)).BeginInit();
            this.tabControlProviderManagement.SuspendLayout();
            this.tabPageProvider.SuspendLayout();
            this.tabPagePolicy.SuspendLayout();
            this.groupBoxProvOperations.SuspendLayout();
            this.groupBoxProvSearch.SuspendLayout();
            this.tabPagePackage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxProvider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolProv)).BeginInit();
            this.groupBoxPolSearch.SuspendLayout();
            this.groupBoxPolOperations.SuspendLayout();
            this.groupBoxPolicyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPol)).BeginInit();
            this.groupBoxPackageProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackProv)).BeginInit();
            this.groupBoxPackSearch.SuspendLayout();
            this.groupBoxPackOps.SuspendLayout();
            this.groupBoxPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackage)).BeginInit();
            this.tabPagePackagePol.SuspendLayout();
            this.groupBoxPackPol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackPol)).BeginInit();
            this.groupBoxPackPolicyOp.SuspendLayout();
            this.groupBoxPackCurPol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurPackPol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProvData
            // 
            this.groupBoxProvData.Controls.Add(this.btnNext);
            this.groupBoxProvData.Controls.Add(this.btnPrev);
            this.groupBoxProvData.Controls.Add(this.dataGridViewProv);
            this.groupBoxProvData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxProvData.Name = "groupBoxProvData";
            this.groupBoxProvData.Size = new System.Drawing.Size(490, 454);
            this.groupBoxProvData.TabIndex = 6;
            this.groupBoxProvData.TabStop = false;
            this.groupBoxProvData.Text = "Providers";
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
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(6, 426);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProv
            // 
            this.dataGridViewProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProv.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewProv.Name = "dataGridViewProv";
            this.dataGridViewProv.Size = new System.Drawing.Size(478, 401);
            this.dataGridViewProv.TabIndex = 0;
            this.dataGridViewProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProv_CellContentClick);
            // 
            this.btnProvSearch.Location = new System.Drawing.Point(9, 75);
            this.btnProvSearch.Name = "btnProvSearch";
            this.btnProvSearch.Size = new System.Drawing.Size(264, 23);
            this.btnProvSearch.TabIndex = 19;
            this.btnProvSearch.Text = "Search";
            this.btnProvSearch.UseVisualStyleBackColor = true;
            // 
            this.tabControlProviderManagement.Controls.Add(this.tabPageProvider);
            this.tabControlProviderManagement.Controls.Add(this.tabPagePolicy);
            this.tabControlProviderManagement.Controls.Add(this.tabPagePackage);
            this.tabControlProviderManagement.Controls.Add(this.tabPagePackagePol);
            this.tabControlProviderManagement.Location = new System.Drawing.Point(2, 2);
            this.tabControlProviderManagement.Name = "tabControlProviderManagement";
            this.tabControlProviderManagement.SelectedIndex = 0;
            this.tabControlProviderManagement.Size = new System.Drawing.Size(799, 508);
            this.tabControlProviderManagement.TabIndex = 4;
            // 
            // tabPageProvider
            // 
            this.tabPageProvider.Controls.Add(this.groupBoxProvSearch);
            this.tabPageProvider.Controls.Add(this.groupBoxProvOperations);
            this.tabPageProvider.Controls.Add(this.groupBoxProvData);
            this.tabPageProvider.Location = new System.Drawing.Point(4, 22);
            this.tabPageProvider.Name = "tabPageProvider";
            this.tabPageProvider.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvider.Size = new System.Drawing.Size(791, 482);
            this.tabPageProvider.TabIndex = 0;
            this.tabPageProvider.Text = "Provider";
            this.tabPageProvider.UseVisualStyleBackColor = true;
            // 
            // tabPagePolicy
            // 
            this.tabPagePolicy.Controls.Add(this.groupBoxProvider);
            this.tabPagePolicy.Controls.Add(this.groupBoxPolSearch);
            this.tabPagePolicy.Controls.Add(this.groupBoxPolOperations);
            this.tabPagePolicy.Controls.Add(this.groupBoxPolicyData);
            this.tabPagePolicy.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolicy.Name = "tabPagePolicy";
            this.tabPagePolicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePolicy.Size = new System.Drawing.Size(791, 482);
            this.tabPagePolicy.TabIndex = 1;
            this.tabPagePolicy.Text = "Policy";
            this.tabPagePolicy.UseVisualStyleBackColor = true;
            // 
            // groupBoxProvOperations
            // 
            this.groupBoxProvOperations.Controls.Add(this.groupBox1);
            this.groupBoxProvOperations.Controls.Add(this.txtProvLocation);
            this.groupBoxProvOperations.Controls.Add(this.btnProvDelete);
            this.groupBoxProvOperations.Controls.Add(this.btnProvUpdate);
            this.groupBoxProvOperations.Controls.Add(this.btnProvAdd);
            this.groupBoxProvOperations.Controls.Add(this.label3);
            this.groupBoxProvOperations.Controls.Add(this.txtProvName);
            this.groupBoxProvOperations.Controls.Add(this.label2);
            this.groupBoxProvOperations.Controls.Add(this.txtProvID);
            this.groupBoxProvOperations.Controls.Add(this.label1);
            this.groupBoxProvOperations.Location = new System.Drawing.Point(502, 6);
            this.groupBoxProvOperations.Name = "groupBoxProvOperations";
            this.groupBoxProvOperations.Size = new System.Drawing.Size(279, 335);
            this.groupBoxProvOperations.TabIndex = 8;
            this.groupBoxProvOperations.TabStop = false;
            this.groupBoxProvOperations.Text = "Operations";
            // 
            // btnDelete
            // 
            this.txtProvLocation.Location = new System.Drawing.Point(90, 97);
            this.txtProvLocation.Name = "txtProvLocation";
            this.txtProvLocation.Size = new System.Drawing.Size(183, 20);
            this.txtProvLocation.TabIndex = 19;
            // 
            // btnProvDelete
            // 
            this.btnProvDelete.Location = new System.Drawing.Point(198, 296);
            this.btnProvDelete.Name = "btnProvDelete";
            this.btnProvDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProvDelete.TabIndex = 18;
            this.btnProvDelete.Text = "Delete";
            this.btnProvDelete.UseVisualStyleBackColor = true;
            this.btnProvDelete.Click += new System.EventHandler(this.btnProvDelete_Click);
            // 
            // btnProvUpdate
            // 
            this.btnProvUpdate.Location = new System.Drawing.Point(104, 296);
            this.btnProvUpdate.Name = "btnProvUpdate";
            this.btnProvUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnProvUpdate.TabIndex = 17;
            this.btnProvUpdate.Text = "Update";
            this.btnProvUpdate.UseVisualStyleBackColor = true;
            this.btnProvUpdate.Click += new System.EventHandler(this.btnProvUpdate_Click);
            // 
            // btnProvAdd
            // 
            this.btnProvAdd.Location = new System.Drawing.Point(9, 296);
            this.btnProvAdd.Name = "btnProvAdd";
            this.btnProvAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProvAdd.TabIndex = 4;
            this.btnProvAdd.Text = "Add";
            this.btnProvAdd.UseVisualStyleBackColor = true;
            this.btnProvAdd.Click += new System.EventHandler(this.btnProvAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            // 
            // txtProvName
            // 
            this.txtProvName.Location = new System.Drawing.Point(90, 68);
            this.txtProvName.Name = "txtProvName";
            this.txtProvName.Size = new System.Drawing.Size(183, 20);
            this.txtProvName.TabIndex = 8;
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
            // txtProvID
            // 
            this.txtProvID.Location = new System.Drawing.Point(90, 42);
            this.txtProvID.Name = "txtProvID";
            this.txtProvID.Size = new System.Drawing.Size(183, 20);
            this.txtProvID.TabIndex = 6;
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
            // groupBoxProvSearch
            // 
            this.groupBoxProvSearch.Controls.Add(this.btnProvSearch);
            this.groupBoxProvSearch.Controls.Add(this.txtProvSearch);
            this.groupBoxProvSearch.Controls.Add(this.label6);
            this.groupBoxProvSearch.Location = new System.Drawing.Point(502, 347);
            this.groupBoxProvSearch.Name = "groupBoxProvSearch";
            this.groupBoxProvSearch.Size = new System.Drawing.Size(279, 113);
            this.groupBoxProvSearch.TabIndex = 9;
            this.groupBoxProvSearch.TabStop = false;
            this.groupBoxProvSearch.Text = "Search";
            // 
            // btnProvSearch
            // 
            this.btnProvSearch.Location = new System.Drawing.Point(9, 75);
            this.btnProvSearch.Name = "btnProvSearch";
            this.btnProvSearch.Size = new System.Drawing.Size(264, 23);
            this.btnProvSearch.TabIndex = 19;
            this.btnProvSearch.Text = "Search";
            this.btnProvSearch.UseVisualStyleBackColor = true;
            this.btnProvSearch.Click += new System.EventHandler(this.btnProvSearch_Click);
            // 
            // txtProvSearch
            // 
            this.txtProvSearch.Location = new System.Drawing.Point(30, 36);
            this.txtProvSearch.Name = "txtProvSearch";
            this.txtProvSearch.Size = new System.Drawing.Size(243, 20);
            this.txtProvSearch.TabIndex = 20;
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
            // tabPagePackage
            // 
            this.tabPagePackage.Controls.Add(this.groupBoxPackageProv);
            this.tabPagePackage.Controls.Add(this.groupBoxPackSearch);
            this.tabPagePackage.Controls.Add(this.groupBoxPackOps);
            this.tabPagePackage.Controls.Add(this.groupBoxPackage);
            this.tabPagePackage.Location = new System.Drawing.Point(4, 22);
            this.tabPagePackage.Name = "tabPagePackage";
            this.tabPagePackage.Size = new System.Drawing.Size(791, 482);
            this.tabPagePackage.TabIndex = 2;
            this.tabPagePackage.Text = "Package";
            this.tabPagePackage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnFalse);
            this.groupBox1.Controls.Add(this.radioBtnTrue);
            this.groupBox1.Location = new System.Drawing.Point(9, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 49);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // radioBtnTrue
            // 
            this.radioBtnTrue.AutoSize = true;
            this.radioBtnTrue.Location = new System.Drawing.Point(21, 19);
            this.radioBtnTrue.Name = "radioBtnTrue";
            this.radioBtnTrue.Size = new System.Drawing.Size(79, 17);
            this.radioBtnTrue.TabIndex = 0;
            this.radioBtnTrue.TabStop = true;
            this.radioBtnTrue.Text = "Operational";
            this.radioBtnTrue.UseVisualStyleBackColor = true;
            // 
            // radioBtnFalse
            // 
            this.radioBtnFalse.AutoSize = true;
            this.radioBtnFalse.Location = new System.Drawing.Point(173, 19);
            this.radioBtnFalse.Name = "radioBtnFalse";
            this.radioBtnFalse.Size = new System.Drawing.Size(87, 17);
            this.radioBtnFalse.TabIndex = 1;
            this.radioBtnFalse.TabStop = true;
            this.radioBtnFalse.Text = "Discontinued";
            this.radioBtnFalse.UseVisualStyleBackColor = true;
            // 
            // groupBoxProvider
            // 
            this.groupBoxProvider.Controls.Add(this.btnPolProvNext);
            this.groupBoxProvider.Controls.Add(this.btnPolProvPrev);
            this.groupBoxProvider.Controls.Add(this.dataGridViewPolProv);
            this.groupBoxProvider.Location = new System.Drawing.Point(7, 243);
            this.groupBoxProvider.Name = "groupBoxProvider";
            this.groupBoxProvider.Size = new System.Drawing.Size(491, 233);
            this.groupBoxProvider.TabIndex = 7;
            this.groupBoxProvider.TabStop = false;
            this.groupBoxProvider.Text = "Providers";
            // 
            // btnPolProvNext
            // 
            this.btnPolProvNext.Location = new System.Drawing.Point(409, 197);
            this.btnPolProvNext.Name = "btnPolProvNext";
            this.btnPolProvNext.Size = new System.Drawing.Size(75, 23);
            this.btnPolProvNext.TabIndex = 3;
            this.btnPolProvNext.Text = ">";
            this.btnPolProvNext.UseVisualStyleBackColor = true;
            // 
            // btnPolProvPrev
            // 
            this.btnPolProvPrev.Location = new System.Drawing.Point(6, 197);
            this.btnPolProvPrev.Name = "btnPolProvPrev";
            this.btnPolProvPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPolProvPrev.TabIndex = 2;
            this.btnPolProvPrev.Text = "<";
            this.btnPolProvPrev.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPolProv
            // 
            this.dataGridViewPolProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolProv.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPolProv.Name = "dataGridViewPolProv";
            this.dataGridViewPolProv.Size = new System.Drawing.Size(478, 173);
            this.dataGridViewPolProv.TabIndex = 0;
            this.dataGridViewPolProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolProv_CellContentClick);
            // 
            // groupBoxPolSearch
            // 
            this.groupBoxPolSearch.Controls.Add(this.btnPolSearch);
            this.groupBoxPolSearch.Controls.Add(this.txtPolSearch);
            this.groupBoxPolSearch.Controls.Add(this.label7);
            this.groupBoxPolSearch.Controls.Add(this.btnPolProvSearch);
            this.groupBoxPolSearch.Controls.Add(this.txtPolProvSearch);
            this.groupBoxPolSearch.Controls.Add(this.label4);
            this.groupBoxPolSearch.Location = new System.Drawing.Point(504, 363);
            this.groupBoxPolSearch.Name = "groupBoxPolSearch";
            this.groupBoxPolSearch.Size = new System.Drawing.Size(279, 113);
            this.groupBoxPolSearch.TabIndex = 9;
            this.groupBoxPolSearch.TabStop = false;
            this.groupBoxPolSearch.Text = "Search";
            // 
            // btnPolSearch
            // 
            this.btnPolSearch.Location = new System.Drawing.Point(144, 75);
            this.btnPolSearch.Name = "btnPolSearch";
            this.btnPolSearch.Size = new System.Drawing.Size(129, 23);
            this.btnPolSearch.TabIndex = 23;
            this.btnPolSearch.Text = "Policy Search";
            this.btnPolSearch.UseVisualStyleBackColor = true;
            this.btnPolSearch.Click += new System.EventHandler(this.btnPolSearch_Click);
            // 
            // txtPolSearch
            // 
            this.txtPolSearch.Location = new System.Drawing.Point(77, 46);
            this.txtPolSearch.Name = "txtPolSearch";
            this.txtPolSearch.Size = new System.Drawing.Size(196, 20);
            this.txtPolSearch.TabIndex = 22;
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
            // btnPolProvSearch
            // 
            this.btnPolProvSearch.Location = new System.Drawing.Point(9, 75);
            this.btnPolProvSearch.Name = "btnPolProvSearch";
            this.btnPolProvSearch.Size = new System.Drawing.Size(129, 23);
            this.btnPolProvSearch.TabIndex = 19;
            this.btnPolProvSearch.Text = "Provider Search";
            this.btnPolProvSearch.UseVisualStyleBackColor = true;
            this.btnPolProvSearch.Click += new System.EventHandler(this.btnPolProvSearch_Click);
            // 
            // txtPolProvSearch
            // 
            this.txtPolProvSearch.Location = new System.Drawing.Point(77, 22);
            this.txtPolProvSearch.Name = "txtPolProvSearch";
            this.txtPolProvSearch.Size = new System.Drawing.Size(196, 20);
            this.txtPolProvSearch.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Provider ID";
            // 
            // groupBoxPolOperations
            // 
            this.groupBoxPolOperations.Controls.Add(this.cmbCoverLevel);
            this.groupBoxPolOperations.Controls.Add(this.txtPolProvID);
            this.groupBoxPolOperations.Controls.Add(this.txtPolCost);
            this.groupBoxPolOperations.Controls.Add(this.btnPolDelete);
            this.groupBoxPolOperations.Controls.Add(this.btnPolUpdate);
            this.groupBoxPolOperations.Controls.Add(this.brnPolAdd);
            this.groupBoxPolOperations.Controls.Add(this.label5);
            this.groupBoxPolOperations.Controls.Add(this.label8);
            this.groupBoxPolOperations.Controls.Add(this.label9);
            this.groupBoxPolOperations.Controls.Add(this.txtPolName);
            this.groupBoxPolOperations.Controls.Add(this.label10);
            this.groupBoxPolOperations.Controls.Add(this.txtPolID);
            this.groupBoxPolOperations.Controls.Add(this.label11);
            this.groupBoxPolOperations.Location = new System.Drawing.Point(504, 4);
            this.groupBoxPolOperations.Name = "groupBoxPolOperations";
            this.groupBoxPolOperations.Size = new System.Drawing.Size(279, 353);
            this.groupBoxPolOperations.TabIndex = 8;
            this.groupBoxPolOperations.TabStop = false;
            this.groupBoxPolOperations.Text = "Policy Operations";
            // 
            // txtPolProvID
            // 
            this.txtPolProvID.Location = new System.Drawing.Point(90, 146);
            this.txtPolProvID.Name = "txtPolProvID";
            this.txtPolProvID.Size = new System.Drawing.Size(183, 20);
            this.txtPolProvID.TabIndex = 20;
            // 
            // txtPolCost
            // 
            this.txtPolCost.Location = new System.Drawing.Point(90, 121);
            this.txtPolCost.Name = "txtPolCost";
            this.txtPolCost.Size = new System.Drawing.Size(183, 20);
            this.txtPolCost.TabIndex = 19;
            // 
            // btnPolDelete
            // 
            this.btnPolDelete.Location = new System.Drawing.Point(198, 320);
            this.btnPolDelete.Name = "btnPolDelete";
            this.btnPolDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPolDelete.TabIndex = 18;
            this.btnPolDelete.Text = "Delete";
            this.btnPolDelete.UseVisualStyleBackColor = true;
            this.btnPolDelete.Click += new System.EventHandler(this.btnPolDelete_Click);
            // 
            // btnPolUpdate
            // 
            this.btnPolUpdate.Location = new System.Drawing.Point(104, 320);
            this.btnPolUpdate.Name = "btnPolUpdate";
            this.btnPolUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnPolUpdate.TabIndex = 17;
            this.btnPolUpdate.Text = "Update";
            this.btnPolUpdate.UseVisualStyleBackColor = true;
            this.btnPolUpdate.Click += new System.EventHandler(this.btnPolUpdate_Click);
            // 
            // brnPolAdd
            // 
            this.brnPolAdd.Location = new System.Drawing.Point(9, 320);
            this.brnPolAdd.Name = "brnPolAdd";
            this.brnPolAdd.Size = new System.Drawing.Size(75, 23);
            this.brnPolAdd.TabIndex = 4;
            this.brnPolAdd.Text = "Add";
            this.brnPolAdd.UseVisualStyleBackColor = true;
            this.brnPolAdd.Click += new System.EventHandler(this.brnPolAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Provider ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cover Level";
            // 
            // txtPolName
            // 
            this.txtPolName.Location = new System.Drawing.Point(90, 68);
            this.txtPolName.Name = "txtPolName";
            this.txtPolName.Size = new System.Drawing.Size(183, 20);
            this.txtPolName.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Name";
            // 
            // txtPolID
            // 
            this.txtPolID.Location = new System.Drawing.Point(90, 42);
            this.txtPolID.Name = "txtPolID";
            this.txtPolID.Size = new System.Drawing.Size(183, 20);
            this.txtPolID.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Policy ID";
            // 
            // groupBoxPolicyData
            // 
            this.groupBoxPolicyData.Controls.Add(this.btnPolNext);
            this.groupBoxPolicyData.Controls.Add(this.btnPolPrev);
            this.groupBoxPolicyData.Controls.Add(this.dataGridViewPol);
            this.groupBoxPolicyData.Location = new System.Drawing.Point(7, 4);
            this.groupBoxPolicyData.Name = "groupBoxPolicyData";
            this.groupBoxPolicyData.Size = new System.Drawing.Size(491, 233);
            this.groupBoxPolicyData.TabIndex = 6;
            this.groupBoxPolicyData.TabStop = false;
            this.groupBoxPolicyData.Text = "Policies";
            // 
            // btnPolNext
            // 
            this.btnPolNext.Location = new System.Drawing.Point(409, 197);
            this.btnPolNext.Name = "btnPolNext";
            this.btnPolNext.Size = new System.Drawing.Size(75, 23);
            this.btnPolNext.TabIndex = 3;
            this.btnPolNext.Text = ">";
            this.btnPolNext.UseVisualStyleBackColor = true;
            // 
            // btnPolPrev
            // 
            this.btnPolPrev.Location = new System.Drawing.Point(6, 197);
            this.btnPolPrev.Name = "btnPolPrev";
            this.btnPolPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPolPrev.TabIndex = 2;
            this.btnPolPrev.Text = "<";
            this.btnPolPrev.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPol
            // 
            this.dataGridViewPol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPol.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPol.Name = "dataGridViewPol";
            this.dataGridViewPol.Size = new System.Drawing.Size(478, 173);
            this.dataGridViewPol.TabIndex = 0;
            this.dataGridViewPol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPol_CellContentClick);
            // 
            // cmbCoverLevel
            // 
            this.cmbCoverLevel.FormattingEnabled = true;
            this.cmbCoverLevel.Location = new System.Drawing.Point(90, 94);
            this.cmbCoverLevel.Name = "cmbCoverLevel";
            this.cmbCoverLevel.Size = new System.Drawing.Size(183, 21);
            this.cmbCoverLevel.TabIndex = 21;
            // 
            // groupBoxPackageProv
            // 
            this.groupBoxPackageProv.Controls.Add(this.button1);
            this.groupBoxPackageProv.Controls.Add(this.button2);
            this.groupBoxPackageProv.Controls.Add(this.dataGridViewPackProv);
            this.groupBoxPackageProv.Location = new System.Drawing.Point(7, 244);
            this.groupBoxPackageProv.Name = "groupBoxPackageProv";
            this.groupBoxPackageProv.Size = new System.Drawing.Size(491, 233);
            this.groupBoxPackageProv.TabIndex = 11;
            this.groupBoxPackageProv.TabStop = false;
            this.groupBoxPackageProv.Text = "Providers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPackProv
            // 
            this.dataGridViewPackProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackProv.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPackProv.Name = "dataGridViewPackProv";
            this.dataGridViewPackProv.Size = new System.Drawing.Size(478, 173);
            this.dataGridViewPackProv.TabIndex = 0;
            this.dataGridViewPackProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPackProv_CellContentClick);
            // 
            // groupBoxPackSearch
            // 
            this.groupBoxPackSearch.Controls.Add(this.btnPackSearch);
            this.groupBoxPackSearch.Controls.Add(this.txtPackSearch);
            this.groupBoxPackSearch.Controls.Add(this.label12);
            this.groupBoxPackSearch.Controls.Add(this.btnPackProvSearch);
            this.groupBoxPackSearch.Controls.Add(this.txtPackProvSearch);
            this.groupBoxPackSearch.Controls.Add(this.label13);
            this.groupBoxPackSearch.Location = new System.Drawing.Point(504, 364);
            this.groupBoxPackSearch.Name = "groupBoxPackSearch";
            this.groupBoxPackSearch.Size = new System.Drawing.Size(279, 113);
            this.groupBoxPackSearch.TabIndex = 13;
            this.groupBoxPackSearch.TabStop = false;
            this.groupBoxPackSearch.Text = "Search";
            // 
            // btnPackSearch
            // 
            this.btnPackSearch.Location = new System.Drawing.Point(144, 75);
            this.btnPackSearch.Name = "btnPackSearch";
            this.btnPackSearch.Size = new System.Drawing.Size(129, 23);
            this.btnPackSearch.TabIndex = 23;
            this.btnPackSearch.Text = "Package Search";
            this.btnPackSearch.UseVisualStyleBackColor = true;
            this.btnPackSearch.Click += new System.EventHandler(this.btnPackSearch_Click);
            // 
            // txtPackSearch
            // 
            this.txtPackSearch.Location = new System.Drawing.Point(77, 46);
            this.txtPackSearch.Name = "txtPackSearch";
            this.txtPackSearch.Size = new System.Drawing.Size(196, 20);
            this.txtPackSearch.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Package ID";
            // 
            // btnPackProvSearch
            // 
            this.btnPackProvSearch.Location = new System.Drawing.Point(9, 75);
            this.btnPackProvSearch.Name = "btnPackProvSearch";
            this.btnPackProvSearch.Size = new System.Drawing.Size(129, 23);
            this.btnPackProvSearch.TabIndex = 19;
            this.btnPackProvSearch.Text = "Provider Search";
            this.btnPackProvSearch.UseVisualStyleBackColor = true;
            this.btnPackProvSearch.Click += new System.EventHandler(this.btnPackProvSearch_Click);
            // 
            // txtPackProvSearch
            // 
            this.txtPackProvSearch.Location = new System.Drawing.Point(77, 22);
            this.txtPackProvSearch.Name = "txtPackProvSearch";
            this.txtPackProvSearch.Size = new System.Drawing.Size(196, 20);
            this.txtPackProvSearch.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Provider ID";
            // 
            // groupBoxPackOps
            // 
            this.groupBoxPackOps.Controls.Add(this.txtPackProvID);
            this.groupBoxPackOps.Controls.Add(this.txtPackCost);
            this.groupBoxPackOps.Controls.Add(this.btnPackDelete);
            this.groupBoxPackOps.Controls.Add(this.btnPackUpdate);
            this.groupBoxPackOps.Controls.Add(this.btnPackCreate);
            this.groupBoxPackOps.Controls.Add(this.label14);
            this.groupBoxPackOps.Controls.Add(this.label15);
            this.groupBoxPackOps.Controls.Add(this.txtPackName);
            this.groupBoxPackOps.Controls.Add(this.label17);
            this.groupBoxPackOps.Controls.Add(this.txtPackID);
            this.groupBoxPackOps.Controls.Add(this.label18);
            this.groupBoxPackOps.Location = new System.Drawing.Point(504, 5);
            this.groupBoxPackOps.Name = "groupBoxPackOps";
            this.groupBoxPackOps.Size = new System.Drawing.Size(279, 353);
            this.groupBoxPackOps.TabIndex = 12;
            this.groupBoxPackOps.TabStop = false;
            this.groupBoxPackOps.Text = "Package Operations";
            // 
            // txtPackProvID
            // 
            this.txtPackProvID.Location = new System.Drawing.Point(90, 119);
            this.txtPackProvID.Name = "txtPackProvID";
            this.txtPackProvID.Size = new System.Drawing.Size(183, 20);
            this.txtPackProvID.TabIndex = 20;
            // 
            // txtPackCost
            // 
            this.txtPackCost.Location = new System.Drawing.Point(90, 94);
            this.txtPackCost.Name = "txtPackCost";
            this.txtPackCost.Size = new System.Drawing.Size(183, 20);
            this.txtPackCost.TabIndex = 19;
            // 
            // btnPackDelete
            // 
            this.btnPackDelete.Location = new System.Drawing.Point(198, 320);
            this.btnPackDelete.Name = "btnPackDelete";
            this.btnPackDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPackDelete.TabIndex = 18;
            this.btnPackDelete.Text = "Delete";
            this.btnPackDelete.UseVisualStyleBackColor = true;
            this.btnPackDelete.Click += new System.EventHandler(this.btnPackDelete_Click);
            // 
            // btnPackUpdate
            // 
            this.btnPackUpdate.Location = new System.Drawing.Point(104, 320);
            this.btnPackUpdate.Name = "btnPackUpdate";
            this.btnPackUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnPackUpdate.TabIndex = 17;
            this.btnPackUpdate.Text = "Update";
            this.btnPackUpdate.UseVisualStyleBackColor = true;
            this.btnPackUpdate.Click += new System.EventHandler(this.btnPackUpdate_Click);
            // 
            // btnPackCreate
            // 
            this.btnPackCreate.Location = new System.Drawing.Point(9, 320);
            this.btnPackCreate.Name = "btnPackCreate";
            this.btnPackCreate.Size = new System.Drawing.Size(75, 23);
            this.btnPackCreate.TabIndex = 4;
            this.btnPackCreate.Text = "Create";
            this.btnPackCreate.UseVisualStyleBackColor = true;
            this.btnPackCreate.Click += new System.EventHandler(this.btnPackCreate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Provider ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Cost";
            // 
            // txtPackName
            // 
            this.txtPackName.Location = new System.Drawing.Point(90, 68);
            this.txtPackName.Name = "txtPackName";
            this.txtPackName.Size = new System.Drawing.Size(183, 20);
            this.txtPackName.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Name";
            // 
            // txtPackID
            // 
            this.txtPackID.Location = new System.Drawing.Point(90, 42);
            this.txtPackID.Name = "txtPackID";
            this.txtPackID.Size = new System.Drawing.Size(183, 20);
            this.txtPackID.TabIndex = 6;
            this.txtPackID.TextChanged += new System.EventHandler(this.txtPackID_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Package ID";
            // 
            // groupBoxPackage
            // 
            this.groupBoxPackage.Controls.Add(this.btnPackNext);
            this.groupBoxPackage.Controls.Add(this.btnPackPrev);
            this.groupBoxPackage.Controls.Add(this.dataGridViewPackage);
            this.groupBoxPackage.Location = new System.Drawing.Point(7, 5);
            this.groupBoxPackage.Name = "groupBoxPackage";
            this.groupBoxPackage.Size = new System.Drawing.Size(491, 233);
            this.groupBoxPackage.TabIndex = 10;
            this.groupBoxPackage.TabStop = false;
            this.groupBoxPackage.Text = "Packages";
            // 
            // btnPackNext
            // 
            this.btnPackNext.Location = new System.Drawing.Point(409, 197);
            this.btnPackNext.Name = "btnPackNext";
            this.btnPackNext.Size = new System.Drawing.Size(75, 23);
            this.btnPackNext.TabIndex = 3;
            this.btnPackNext.Text = ">";
            this.btnPackNext.UseVisualStyleBackColor = true;
            // 
            // btnPackPrev
            // 
            this.btnPackPrev.Location = new System.Drawing.Point(6, 197);
            this.btnPackPrev.Name = "btnPackPrev";
            this.btnPackPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPackPrev.TabIndex = 2;
            this.btnPackPrev.Text = "<";
            this.btnPackPrev.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPackage
            // 
            this.dataGridViewPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackage.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPackage.Name = "dataGridViewPackage";
            this.dataGridViewPackage.Size = new System.Drawing.Size(478, 173);
            this.dataGridViewPackage.TabIndex = 0;
            this.dataGridViewPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPackage_CellContentClick);
            // 
            // tabPagePackagePol
            // 
            this.tabPagePackagePol.Controls.Add(this.groupBoxPackCurPol);
            this.tabPagePackagePol.Controls.Add(this.groupBoxPackPolicyOp);
            this.tabPagePackagePol.Controls.Add(this.groupBoxPackPol);
            this.tabPagePackagePol.Location = new System.Drawing.Point(4, 22);
            this.tabPagePackagePol.Name = "tabPagePackagePol";
            this.tabPagePackagePol.Size = new System.Drawing.Size(791, 482);
            this.tabPagePackagePol.TabIndex = 3;
            this.tabPagePackagePol.Text = "Package Policies";
            this.tabPagePackagePol.UseVisualStyleBackColor = true;
            // 
            // groupBoxPackPol
            // 
            this.groupBoxPackPol.Controls.Add(this.button3);
            this.groupBoxPackPol.Controls.Add(this.button4);
            this.groupBoxPackPol.Controls.Add(this.dataGridViewPackPol);
            this.groupBoxPackPol.Location = new System.Drawing.Point(6, 211);
            this.groupBoxPackPol.Name = "groupBoxPackPol";
            this.groupBoxPackPol.Size = new System.Drawing.Size(375, 266);
            this.groupBoxPackPol.TabIndex = 7;
            this.groupBoxPackPol.TabStop = false;
            this.groupBoxPackPol.Text = "Policies";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPackPol
            // 
            this.dataGridViewPackPol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackPol.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPackPol.Name = "dataGridViewPackPol";
            this.dataGridViewPackPol.Size = new System.Drawing.Size(357, 212);
            this.dataGridViewPackPol.TabIndex = 0;
            this.dataGridViewPackPol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPackPol_CellContentClick);
            // 
            // groupBoxPackPolicyOp
            // 
            this.groupBoxPackPolicyOp.Controls.Add(this.btnPackPolRemove);
            this.groupBoxPackPolicyOp.Controls.Add(this.btnPackPolAdd);
            this.groupBoxPackPolicyOp.Controls.Add(this.btnPackPolSearch);
            this.groupBoxPackPolicyOp.Controls.Add(this.txtPackPolSearch);
            this.groupBoxPackPolicyOp.Controls.Add(this.label21);
            this.groupBoxPackPolicyOp.Location = new System.Drawing.Point(12, 3);
            this.groupBoxPackPolicyOp.Name = "groupBoxPackPolicyOp";
            this.groupBoxPackPolicyOp.Size = new System.Drawing.Size(769, 202);
            this.groupBoxPackPolicyOp.TabIndex = 13;
            this.groupBoxPackPolicyOp.TabStop = false;
            this.groupBoxPackPolicyOp.Text = "Package Operations";
            // 
            // btnPackPolAdd
            // 
            this.btnPackPolAdd.Location = new System.Drawing.Point(251, 119);
            this.btnPackPolAdd.Name = "btnPackPolAdd";
            this.btnPackPolAdd.Size = new System.Drawing.Size(264, 23);
            this.btnPackPolAdd.TabIndex = 18;
            this.btnPackPolAdd.Text = "Add Selected Policy";
            this.btnPackPolAdd.UseVisualStyleBackColor = true;
            this.btnPackPolAdd.Click += new System.EventHandler(this.btnPackPolAdd_Click);
            // 
            // btnPackPolSearch
            // 
            this.btnPackPolSearch.Location = new System.Drawing.Point(251, 90);
            this.btnPackPolSearch.Name = "btnPackPolSearch";
            this.btnPackPolSearch.Size = new System.Drawing.Size(264, 23);
            this.btnPackPolSearch.TabIndex = 17;
            this.btnPackPolSearch.Text = "Search Policy";
            this.btnPackPolSearch.UseVisualStyleBackColor = true;
            this.btnPackPolSearch.Click += new System.EventHandler(this.btnPackPolSearch_Click);
            // 
            // txtPackPolSearch
            // 
            this.txtPackPolSearch.Location = new System.Drawing.Point(332, 64);
            this.txtPackPolSearch.Name = "txtPackPolSearch";
            this.txtPackPolSearch.Size = new System.Drawing.Size(183, 20);
            this.txtPackPolSearch.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(248, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Policy ID";
            // 
            // btnPackPolRemove
            // 
            this.btnPackPolRemove.Location = new System.Drawing.Point(251, 148);
            this.btnPackPolRemove.Name = "btnPackPolRemove";
            this.btnPackPolRemove.Size = new System.Drawing.Size(264, 23);
            this.btnPackPolRemove.TabIndex = 19;
            this.btnPackPolRemove.Text = "Remove Selected Policy";
            this.btnPackPolRemove.UseVisualStyleBackColor = true;
            this.btnPackPolRemove.Click += new System.EventHandler(this.btnPackPolRemove_Click);
            // 
            // groupBoxPackCurPol
            // 
            this.groupBoxPackCurPol.Controls.Add(this.button5);
            this.groupBoxPackCurPol.Controls.Add(this.button6);
            this.groupBoxPackCurPol.Controls.Add(this.dataGridViewCurPackPol);
            this.groupBoxPackCurPol.Location = new System.Drawing.Point(406, 211);
            this.groupBoxPackCurPol.Name = "groupBoxPackCurPol";
            this.groupBoxPackCurPol.Size = new System.Drawing.Size(375, 266);
            this.groupBoxPackCurPol.TabIndex = 8;
            this.groupBoxPackCurPol.TabStop = false;
            this.groupBoxPackCurPol.Text = "Current Policies";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtProvLocation
            // 
            this.txtProvLocation.Location = new System.Drawing.Point(90, 97);
            this.txtProvLocation.Name = "txtProvLocation";
            this.txtProvLocation.Size = new System.Drawing.Size(183, 20);
            this.txtProvLocation.TabIndex = 19;
            // 
            // listbStatus
            // 
            this.listbStatus.FormattingEnabled = true;
            this.listbStatus.Location = new System.Drawing.Point(90, 129);
            this.listbStatus.Name = "listbStatus";
            this.listbStatus.Size = new System.Drawing.Size(183, 30);
            this.listbStatus.TabIndex = 20;
            // 
            // ProviderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 513);
            this.Controls.Add(this.tabControlProviderManagement);
            this.Name = "ProviderManagement";
            this.Text = "ProviderManagement";
            this.Load += new System.EventHandler(this.ProviderManagement_Load);
            this.groupBoxProvData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProv)).EndInit();
            this.tabControlProviderManagement.ResumeLayout(false);
            this.tabPageProvider.ResumeLayout(false);
            this.tabPagePolicy.ResumeLayout(false);
            this.groupBoxProvOperations.ResumeLayout(false);
            this.groupBoxProvOperations.PerformLayout();
            this.groupBoxProvSearch.ResumeLayout(false);
            this.groupBoxProvSearch.PerformLayout();
            this.tabPagePackage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxProvider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolProv)).EndInit();
            this.groupBoxPolSearch.ResumeLayout(false);
            this.groupBoxPolSearch.PerformLayout();
            this.groupBoxPolOperations.ResumeLayout(false);
            this.groupBoxPolOperations.PerformLayout();
            this.groupBoxPolicyData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPol)).EndInit();
            this.groupBoxPackageProv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackProv)).EndInit();
            this.groupBoxPackSearch.ResumeLayout(false);
            this.groupBoxPackSearch.PerformLayout();
            this.groupBoxPackOps.ResumeLayout(false);
            this.groupBoxPackOps.PerformLayout();
            this.groupBoxPackage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackage)).EndInit();
            this.tabPagePackagePol.ResumeLayout(false);
            this.groupBoxPackPol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackPol)).EndInit();
            this.groupBoxPackPolicyOp.ResumeLayout(false);
            this.groupBoxPackPolicyOp.PerformLayout();
            this.groupBoxPackCurPol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurPackPol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxProvData;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dataGridViewProv;
        private System.Windows.Forms.TabControl tabControlProviderManagement;
        private System.Windows.Forms.TabPage tabPageProvider;
        private System.Windows.Forms.GroupBox groupBoxProvSearch;
        private System.Windows.Forms.Button btnProvSearch;
        private System.Windows.Forms.TextBox txtProvSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxProvOperations;
        private System.Windows.Forms.TextBox txtProvLocation;
        private System.Windows.Forms.Button btnProvDelete;
        private System.Windows.Forms.Button btnProvUpdate;
        private System.Windows.Forms.Button btnProvAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProvName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProvID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPagePolicy;
        private System.Windows.Forms.TabPage tabPagePackage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnFalse;
        private System.Windows.Forms.RadioButton radioBtnTrue;
        private System.Windows.Forms.GroupBox groupBoxProvider;
        private System.Windows.Forms.Button btnPolProvNext;
        private System.Windows.Forms.Button btnPolProvPrev;
        private System.Windows.Forms.DataGridView dataGridViewPolProv;
        private System.Windows.Forms.GroupBox groupBoxPolSearch;
        private System.Windows.Forms.Button btnPolSearch;
        private System.Windows.Forms.TextBox txtPolSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPolProvSearch;
        private System.Windows.Forms.TextBox txtPolProvSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPolOperations;
        private System.Windows.Forms.TextBox txtPolProvID;
        private System.Windows.Forms.TextBox txtPolCost;
        private System.Windows.Forms.Button btnPolDelete;
        private System.Windows.Forms.Button btnPolUpdate;
        private System.Windows.Forms.Button brnPolAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPolName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPolID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxPolicyData;
        private System.Windows.Forms.Button btnPolNext;
        private System.Windows.Forms.Button btnPolPrev;
        private System.Windows.Forms.DataGridView dataGridViewPol;
        private System.Windows.Forms.ComboBox cmbCoverLevel;
        private System.Windows.Forms.GroupBox groupBoxPackageProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewPackProv;
        private System.Windows.Forms.GroupBox groupBoxPackSearch;
        private System.Windows.Forms.Button btnPackSearch;
        private System.Windows.Forms.TextBox txtPackSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPackProvSearch;
        private System.Windows.Forms.TextBox txtPackProvSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxPackOps;
        private System.Windows.Forms.TextBox txtPackProvID;
        private System.Windows.Forms.TextBox txtPackCost;
        private System.Windows.Forms.Button btnPackDelete;
        private System.Windows.Forms.Button btnPackUpdate;
        private System.Windows.Forms.Button btnPackCreate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPackName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPackID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBoxPackage;
        private System.Windows.Forms.Button btnPackNext;
        private System.Windows.Forms.Button btnPackPrev;
        private System.Windows.Forms.DataGridView dataGridViewPackage;
        private System.Windows.Forms.TabPage tabPagePackagePol;
        private System.Windows.Forms.GroupBox groupBoxPackPol;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewPackPol;
        private System.Windows.Forms.GroupBox groupBoxPackPolicyOp;
        private System.Windows.Forms.Button btnPackPolAdd;
        private System.Windows.Forms.Button btnPackPolSearch;
        private System.Windows.Forms.TextBox txtPackPolSearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPackPolRemove;
        private System.Windows.Forms.GroupBox groupBoxPackCurPol;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewCurPackPol;
    }
}