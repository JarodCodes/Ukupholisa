
namespace Ukupholisa.CallCentre.Presentation_Layer
{
    partial class OperatorUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CallReceiver = new System.Windows.Forms.TabPage();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtClientIDSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtNewFamilyId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radiobtnNo = new System.Windows.Forms.RadioButton();
            this.radiobtnYes = new System.Windows.Forms.RadioButton();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtMedConditionSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridViewPolicyList = new System.Windows.Forms.DataGridView();
            this.dataGridViewClientSummary = new System.Windows.Forms.DataGridView();
            this.txtClientPolAdd = new System.Windows.Forms.Button();
            this.txtNewPolID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.CallReceiver.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CallReceiver);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 556);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // CallReceiver
            // 
            this.CallReceiver.BackColor = System.Drawing.Color.CadetBlue;
            this.CallReceiver.Controls.Add(this.btnEndCall);
            this.CallReceiver.Controls.Add(this.label10);
            this.CallReceiver.Controls.Add(this.label1);
            this.CallReceiver.Controls.Add(this.btnExit);
            this.CallReceiver.Controls.Add(this.btnAnswer);
            this.CallReceiver.Location = new System.Drawing.Point(4, 22);
            this.CallReceiver.Name = "CallReceiver";
            this.CallReceiver.Padding = new System.Windows.Forms.Padding(3);
            this.CallReceiver.Size = new System.Drawing.Size(837, 530);
            this.CallReceiver.TabIndex = 0;
            this.CallReceiver.Text = "Call Receiver";
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(734, 479);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(97, 43);
            this.btnEndCall.TabIndex = 4;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ongoing Call:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 126);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ukupholisa Healthcare\r\nCall Center\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(734, 430);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(97, 43);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.Text = "Answer Call";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(837, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client Check";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewClientSummary);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(557, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 445);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Client Summary";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Refresh Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSearchClient);
            this.groupBox5.Controls.Add(this.txtClientIDSearch);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(543, 105);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Client Search";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(203, 67);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(103, 23);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.Text = "Search Client";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // txtClientIDSearch
            // 
            this.txtClientIDSearch.Location = new System.Drawing.Point(217, 41);
            this.txtClientIDSearch.Name = "txtClientIDSearch";
            this.txtClientIDSearch.Size = new System.Drawing.Size(225, 20);
            this.txtClientIDSearch.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter Client ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClientUpdate);
            this.groupBox3.Controls.Add(this.btnSaveClient);
            this.groupBox3.Controls.Add(this.txtClientAddress);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.txtClientID);
            this.groupBox3.Controls.Add(this.txtClientPhone);
            this.groupBox3.Controls.Add(this.txtClientSurname);
            this.groupBox3.Controls.Add(this.txtClientName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 334);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Details";
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientUpdate.Location = new System.Drawing.Point(148, 263);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(67, 36);
            this.btnClientUpdate.TabIndex = 14;
            this.btnClientUpdate.Text = "Update Client";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(322, 263);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(67, 36);
            this.btnSaveClient.TabIndex = 13;
            this.btnSaveClient.Text = "Add Client";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(217, 151);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(154, 20);
            this.txtClientAddress.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Address";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtNewFamilyId);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.radiobtnNo);
            this.groupBox7.Controls.Add(this.radiobtnYes);
            this.groupBox7.Location = new System.Drawing.Point(148, 176);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(241, 81);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Family Member?";
            // 
            // txtNewFamilyId
            // 
            this.txtNewFamilyId.Location = new System.Drawing.Point(69, 47);
            this.txtNewFamilyId.Name = "txtNewFamilyId";
            this.txtNewFamilyId.Size = new System.Drawing.Size(154, 20);
            this.txtNewFamilyId.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Family ID";
            // 
            // radiobtnNo
            // 
            this.radiobtnNo.AutoSize = true;
            this.radiobtnNo.Location = new System.Drawing.Point(161, 19);
            this.radiobtnNo.Name = "radiobtnNo";
            this.radiobtnNo.Size = new System.Drawing.Size(41, 17);
            this.radiobtnNo.TabIndex = 1;
            this.radiobtnNo.TabStop = true;
            this.radiobtnNo.Text = "No";
            this.radiobtnNo.UseVisualStyleBackColor = true;
            this.radiobtnNo.CheckedChanged += new System.EventHandler(this.radiobtnNo_CheckedChanged);
            // 
            // radiobtnYes
            // 
            this.radiobtnYes.AutoSize = true;
            this.radiobtnYes.Location = new System.Drawing.Point(83, 19);
            this.radiobtnYes.Name = "radiobtnYes";
            this.radiobtnYes.Size = new System.Drawing.Size(46, 17);
            this.radiobtnYes.TabIndex = 0;
            this.radiobtnYes.TabStop = true;
            this.radiobtnYes.Text = "Yes";
            this.radiobtnYes.UseVisualStyleBackColor = true;
            this.radiobtnYes.CheckedChanged += new System.EventHandler(this.radiobtnYes_CheckedChanged);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(217, 47);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(154, 20);
            this.txtClientID.TabIndex = 7;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(217, 125);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(154, 20);
            this.txtClientPhone.TabIndex = 6;
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(217, 99);
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(154, 20);
            this.txtClientSurname.TabIndex = 5;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(217, 73);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(154, 20);
            this.txtClientName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.txtNewPolID);
            this.tabPage1.Controls.Add(this.txtClientPolAdd);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 530);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Policy Check";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(592, 486);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "Refresh Database";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtMedConditionSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(175, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(205, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtMedConditionSearch
            // 
            this.txtMedConditionSearch.Location = new System.Drawing.Point(159, 44);
            this.txtMedConditionSearch.Name = "txtMedConditionSearch";
            this.txtMedConditionSearch.Size = new System.Drawing.Size(252, 20);
            this.txtMedConditionSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medical Condition";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.dataGridViewPolicyList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(175, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(486, 336);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Policies";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(423, 300);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 30);
            this.button7.TabIndex = 2;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 300);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPolicyList
            // 
            this.dataGridViewPolicyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPolicyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolicyList.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPolicyList.Name = "dataGridViewPolicyList";
            this.dataGridViewPolicyList.Size = new System.Drawing.Size(474, 277);
            this.dataGridViewPolicyList.TabIndex = 0;
            this.dataGridViewPolicyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolicyList_CellContentClick);
            // 
            // dataGridViewClientSummary
            // 
            this.dataGridViewClientSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientSummary.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewClientSummary.Name = "dataGridViewClientSummary";
            this.dataGridViewClientSummary.Size = new System.Drawing.Size(260, 423);
            this.dataGridViewClientSummary.TabIndex = 0;
            this.dataGridViewClientSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientSummary_CellContentClick);
            // 
            // txtClientPolAdd
            // 
            this.txtClientPolAdd.Location = new System.Drawing.Point(175, 493);
            this.txtClientPolAdd.Name = "txtClientPolAdd";
            this.txtClientPolAdd.Size = new System.Drawing.Size(75, 23);
            this.txtClientPolAdd.TabIndex = 7;
            this.txtClientPolAdd.Text = "Add Policy";
            this.txtClientPolAdd.UseVisualStyleBackColor = true;
            this.txtClientPolAdd.Click += new System.EventHandler(this.txtClientPolAdd_Click);
            // 
            // txtNewPolID
            // 
            this.txtNewPolID.Location = new System.Drawing.Point(256, 495);
            this.txtNewPolID.Name = "txtNewPolID";
            this.txtNewPolID.Size = new System.Drawing.Size(100, 20);
            this.txtNewPolID.TabIndex = 8;
            // 
            // OperatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 556);
            this.Controls.Add(this.tabControl1);
            this.Name = "OperatorUI";
            this.Text = "OperatorUI";
            this.Load += new System.EventHandler(this.OperatorUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.CallReceiver.ResumeLayout(false);
            this.CallReceiver.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CallReceiver;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtMedConditionSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridViewPolicyList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.TextBox txtClientIDSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radiobtnNo;
        private System.Windows.Forms.RadioButton radiobtnYes;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox txtNewFamilyId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.DataGridView dataGridViewClientSummary;
        private System.Windows.Forms.Button txtClientPolAdd;
        private System.Windows.Forms.TextBox txtNewPolID;
    }
}