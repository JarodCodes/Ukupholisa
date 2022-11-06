
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorUI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CallReceiver = new System.Windows.Forms.TabPage();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFamily_Role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtClientIDSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewClientSummary = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNewPolID = new System.Windows.Forms.TextBox();
            this.btnClientPolAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtMedConditionSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPolicyList = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dbgCallLogs = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.CallReceiver.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientSummary)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicyList)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgCallLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CallReceiver);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // CallReceiver
            // 
            this.CallReceiver.BackColor = System.Drawing.Color.CadetBlue;
            this.CallReceiver.Controls.Add(this.lblTimer);
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
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(398, 478);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(96, 26);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnEndCall
            // 
            this.btnEndCall.Image = ((System.Drawing.Image)(resources.GetObject("btnEndCall.Image")));
            this.btnEndCall.Location = new System.Drawing.Point(732, 464);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(97, 58);
            this.btnEndCall.TabIndex = 4;
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 478);
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
            this.btnExit.Location = new System.Drawing.Point(3, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Image = ((System.Drawing.Image)(resources.GetObject("btnAnswer.Image")));
            this.btnAnswer.Location = new System.Drawing.Point(629, 464);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(97, 58);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.groupBox6);
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
            this.groupBox6.Controls.Add(this.btnClientUpdate);
            this.groupBox6.Controls.Add(this.btnCancel);
            this.groupBox6.Controls.Add(this.btnSaveClient);
            this.groupBox6.Controls.Add(this.txtClientAddress);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.txtClientID);
            this.groupBox6.Controls.Add(this.txtClientPhone);
            this.groupBox6.Controls.Add(this.txtClientSurname);
            this.groupBox6.Controls.Add(this.txtClientName);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(557, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 407);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Client Summary";
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientUpdate.Location = new System.Drawing.Point(37, 309);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(67, 36);
            this.btnClientUpdate.TabIndex = 27;
            this.btnClientUpdate.Text = "Update";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(37, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 36);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(182, 309);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(67, 36);
            this.btnSaveClient.TabIndex = 26;
            this.btnSaveClient.Text = "Add Client";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click_1);
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(97, 170);
            this.txtClientAddress.MaxLength = 50;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(154, 20);
            this.txtClientAddress.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Address";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.cmbFamily_Role);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtNewFamilyId);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.radiobtnNo);
            this.groupBox7.Controls.Add(this.radiobtnYes);
            this.groupBox7.Location = new System.Drawing.Point(22, 196);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(237, 107);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Family Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Family Referral";
            // 
            // cmbFamily_Role
            // 
            this.cmbFamily_Role.FormattingEnabled = true;
            this.cmbFamily_Role.Items.AddRange(new object[] {
            "FATHER",
            "MOTHER",
            "CHILD",
            "UNSPECIFIED"});
            this.cmbFamily_Role.Location = new System.Drawing.Point(103, 73);
            this.cmbFamily_Role.Name = "cmbFamily_Role";
            this.cmbFamily_Role.Size = new System.Drawing.Size(121, 21);
            this.cmbFamily_Role.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Family Role";
            // 
            // txtNewFamilyId
            // 
            this.txtNewFamilyId.Enabled = false;
            this.txtNewFamilyId.Location = new System.Drawing.Point(103, 47);
            this.txtNewFamilyId.Name = "txtNewFamilyId";
            this.txtNewFamilyId.Size = new System.Drawing.Size(121, 20);
            this.txtNewFamilyId.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Family ID";
            // 
            // radiobtnNo
            // 
            this.radiobtnNo.AutoSize = true;
            this.radiobtnNo.Location = new System.Drawing.Point(190, 19);
            this.radiobtnNo.Name = "radiobtnNo";
            this.radiobtnNo.Size = new System.Drawing.Size(41, 17);
            this.radiobtnNo.TabIndex = 1;
            this.radiobtnNo.TabStop = true;
            this.radiobtnNo.Text = "No";
            this.radiobtnNo.UseVisualStyleBackColor = true;
            this.radiobtnNo.CheckedChanged += new System.EventHandler(this.radiobtnNo_CheckedChanged_1);
            // 
            // radiobtnYes
            // 
            this.radiobtnYes.AutoSize = true;
            this.radiobtnYes.Location = new System.Drawing.Point(112, 19);
            this.radiobtnYes.Name = "radiobtnYes";
            this.radiobtnYes.Size = new System.Drawing.Size(46, 17);
            this.radiobtnYes.TabIndex = 0;
            this.radiobtnYes.TabStop = true;
            this.radiobtnYes.Text = "Yes";
            this.radiobtnYes.UseVisualStyleBackColor = true;
            this.radiobtnYes.CheckedChanged += new System.EventHandler(this.radiobtnYes_CheckedChanged_1);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(97, 66);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(154, 20);
            this.txtClientID.TabIndex = 22;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(97, 144);
            this.txtClientPhone.MaxLength = 10;
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(154, 20);
            this.txtClientPhone.TabIndex = 21;
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(97, 118);
            this.txtClientSurname.MaxLength = 30;
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(154, 20);
            this.txtClientSurname.TabIndex = 20;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(97, 92);
            this.txtClientName.MaxLength = 30;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(154, 20);
            this.txtClientName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Client Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSearchClient);
            this.groupBox5.Controls.Add(this.txtClientIDSearch);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(559, 419);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 105);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Client Search";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(97, 60);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(67, 36);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.Text = "Search Client";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // txtClientIDSearch
            // 
            this.txtClientIDSearch.Location = new System.Drawing.Point(131, 34);
            this.txtClientIDSearch.Name = "txtClientIDSearch";
            this.txtClientIDSearch.Size = new System.Drawing.Size(106, 20);
            this.txtClientIDSearch.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Client Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewClientSummary);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 518);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Details";
            // 
            // dataGridViewClientSummary
            // 
            this.dataGridViewClientSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientSummary.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewClientSummary.Name = "dataGridViewClientSummary";
            this.dataGridViewClientSummary.Size = new System.Drawing.Size(531, 493);
            this.dataGridViewClientSummary.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 530);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Policy Check";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNewPolID);
            this.groupBox1.Controls.Add(this.btnClientPolAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(420, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Policy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(102, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Medical Condition";
            // 
            // txtNewPolID
            // 
            this.txtNewPolID.Location = new System.Drawing.Point(216, 46);
            this.txtNewPolID.Name = "txtNewPolID";
            this.txtNewPolID.Size = new System.Drawing.Size(100, 20);
            this.txtNewPolID.TabIndex = 8;
            // 
            // btnClientPolAdd
            // 
            this.btnClientPolAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientPolAdd.Location = new System.Drawing.Point(172, 72);
            this.btnClientPolAdd.Name = "btnClientPolAdd";
            this.btnClientPolAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClientPolAdd.TabIndex = 7;
            this.btnClientPolAdd.Text = "Add Policy";
            this.btnClientPolAdd.UseVisualStyleBackColor = true;
            this.btnClientPolAdd.Click += new System.EventHandler(this.btnClientPolAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtMedConditionSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Medical Condition";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(178, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtMedConditionSearch
            // 
            this.txtMedConditionSearch.Location = new System.Drawing.Point(141, 46);
            this.txtMedConditionSearch.Name = "txtMedConditionSearch";
            this.txtMedConditionSearch.Size = new System.Drawing.Size(242, 20);
            this.txtMedConditionSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medical Condition";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewPolicyList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(823, 380);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available policies per medical condition";
            // 
            // dataGridViewPolicyList
            // 
            this.dataGridViewPolicyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPolicyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolicyList.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPolicyList.Name = "dataGridViewPolicyList";
            this.dataGridViewPolicyList.Size = new System.Drawing.Size(811, 355);
            this.dataGridViewPolicyList.TabIndex = 0;
            this.dataGridViewPolicyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolicyList_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(837, 530);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Call Logs";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dbgCallLogs);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(184, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(488, 516);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Current Client Call History";
            // 
            // dbgCallLogs
            // 
            this.dbgCallLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgCallLogs.Location = new System.Drawing.Point(6, 19);
            this.dbgCallLogs.Name = "dbgCallLogs";
            this.dbgCallLogs.Size = new System.Drawing.Size(476, 491);
            this.dbgCallLogs.TabIndex = 0;
            // 
            // OperatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 556);
            this.Controls.Add(this.tabControl1);
            this.Name = "OperatorUI";
            this.Text = "OperatorUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperatorUI_FormClosing);
            this.Load += new System.EventHandler(this.OperatorUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.CallReceiver.ResumeLayout(false);
            this.CallReceiver.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientSummary)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicyList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgCallLogs)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtMedConditionSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewPolicyList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.TextBox txtClientIDSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.DataGridView dataGridViewClientSummary;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtNewFamilyId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radiobtnNo;
        private System.Windows.Forms.RadioButton radiobtnYes;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFamily_Role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNewPolID;
        private System.Windows.Forms.Button btnClientPolAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dbgCallLogs;
    }
}