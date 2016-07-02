namespace FHIRClientApp.Forms.Patients
{
    partial class Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Comments = new System.Windows.Forms.Label();
            this.lblHealthStatusRequired = new System.Windows.Forms.Label();
            this.lblMaritalStatusRequired = new System.Windows.Forms.Label();
            this.lblOccupationRequired = new System.Windows.Forms.Label();
            this.lblDOBRequired = new System.Windows.Forms.Label();
            this.lblNameRequired = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.cmbHealthStatus = new System.Windows.Forms.ComboBox();
            this.lblHealthStatus = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbGenderStatus = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabSearchManage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb2HealthStatus = new System.Windows.Forms.ComboBox();
            this.lbl2HealthStatus = new System.Windows.Forms.Label();
            this.cmb2GenderStatus = new System.Windows.Forms.ComboBox();
            this.lbl2MaritalStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt2DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txt2Name = new System.Windows.Forms.TextBox();
            this.lbl2DateOfBirth = new System.Windows.Forms.Label();
            this.lbl2Name = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewServer = new System.Windows.Forms.DataGridView();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabFHIRControl = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PrintReport = new System.Drawing.Printing.PrintDocument();
            this.tab.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabSearchManage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServer)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabFHIRControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabRegistration);
            this.tab.Controls.Add(this.tabSearchManage);
            this.tab.Controls.Add(this.tabServer);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(6, 8);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1233, 521);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // tabRegistration
            // 
            this.tabRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabRegistration.Controls.Add(this.tabControl2);
            this.tabRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistration.Location = new System.Drawing.Point(4, 24);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(1225, 493);
            this.tabRegistration.TabIndex = 0;
            this.tabRegistration.Text = "Add Patient";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRegister);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(8, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(839, 313);
            this.tabControl2.TabIndex = 5;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.textBox1);
            this.tabRegister.Controls.Add(this.Comments);
            this.tabRegister.Controls.Add(this.lblHealthStatusRequired);
            this.tabRegister.Controls.Add(this.lblMaritalStatusRequired);
            this.tabRegister.Controls.Add(this.lblOccupationRequired);
            this.tabRegister.Controls.Add(this.lblDOBRequired);
            this.tabRegister.Controls.Add(this.lblNameRequired);
            this.tabRegister.Controls.Add(this.lblSalary);
            this.tabRegister.Controls.Add(this.txtFamilyName);
            this.tabRegister.Controls.Add(this.cmbHealthStatus);
            this.tabRegister.Controls.Add(this.lblHealthStatus);
            this.tabRegister.Controls.Add(this.dtDateOfBirth);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.cmbGenderStatus);
            this.tabRegister.Controls.Add(this.lblMaritalStatus);
            this.tabRegister.Controls.Add(this.txtName);
            this.tabRegister.Controls.Add(this.lblDateOfBirth);
            this.tabRegister.Controls.Add(this.lblName);
            this.tabRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegister.Location = new System.Drawing.Point(4, 25);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(831, 284);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Patient";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(111, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(693, 99);
            this.textBox1.TabIndex = 24;
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Location = new System.Drawing.Point(11, 104);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(67, 15);
            this.Comments.TabIndex = 23;
            this.Comments.Text = "Comments";
            // 
            // lblHealthStatusRequired
            // 
            this.lblHealthStatusRequired.AutoSize = true;
            this.lblHealthStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblHealthStatusRequired.Location = new System.Drawing.Point(84, 235);
            this.lblHealthStatusRequired.Name = "lblHealthStatusRequired";
            this.lblHealthStatusRequired.Size = new System.Drawing.Size(21, 25);
            this.lblHealthStatusRequired.TabIndex = 22;
            this.lblHealthStatusRequired.Text = "*";
            // 
            // lblMaritalStatusRequired
            // 
            this.lblMaritalStatusRequired.AutoSize = true;
            this.lblMaritalStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblMaritalStatusRequired.Location = new System.Drawing.Point(631, 51);
            this.lblMaritalStatusRequired.Name = "lblMaritalStatusRequired";
            this.lblMaritalStatusRequired.Size = new System.Drawing.Size(21, 25);
            this.lblMaritalStatusRequired.TabIndex = 21;
            this.lblMaritalStatusRequired.Text = "*";
            // 
            // lblOccupationRequired
            // 
            this.lblOccupationRequired.AutoSize = true;
            this.lblOccupationRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupationRequired.ForeColor = System.Drawing.Color.Red;
            this.lblOccupationRequired.Location = new System.Drawing.Point(84, 49);
            this.lblOccupationRequired.Name = "lblOccupationRequired";
            this.lblOccupationRequired.Size = new System.Drawing.Size(21, 25);
            this.lblOccupationRequired.TabIndex = 20;
            this.lblOccupationRequired.Text = "*";
            // 
            // lblDOBRequired
            // 
            this.lblDOBRequired.AutoSize = true;
            this.lblDOBRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDOBRequired.Location = new System.Drawing.Point(631, 13);
            this.lblDOBRequired.Name = "lblDOBRequired";
            this.lblDOBRequired.Size = new System.Drawing.Size(21, 25);
            this.lblDOBRequired.TabIndex = 19;
            this.lblDOBRequired.Text = "*";
            // 
            // lblNameRequired
            // 
            this.lblNameRequired.AutoSize = true;
            this.lblNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNameRequired.Location = new System.Drawing.Point(50, 15);
            this.lblNameRequired.Name = "lblNameRequired";
            this.lblNameRequired.Size = new System.Drawing.Size(21, 25);
            this.lblNameRequired.TabIndex = 18;
            this.lblNameRequired.Text = "*";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(7, 51);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(80, 15);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Family Name";
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFamilyName.Location = new System.Drawing.Point(111, 49);
            this.txtFamilyName.MaxLength = 12;
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(411, 21);
            this.txtFamilyName.TabIndex = 5;
            // 
            // cmbHealthStatus
            // 
            this.cmbHealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHealthStatus.FormattingEnabled = true;
            this.cmbHealthStatus.Location = new System.Drawing.Point(111, 232);
            this.cmbHealthStatus.Name = "cmbHealthStatus";
            this.cmbHealthStatus.Size = new System.Drawing.Size(152, 23);
            this.cmbHealthStatus.TabIndex = 7;
            // 
            // lblHealthStatus
            // 
            this.lblHealthStatus.AutoSize = true;
            this.lblHealthStatus.Location = new System.Drawing.Point(11, 235);
            this.lblHealthStatus.Name = "lblHealthStatus";
            this.lblHealthStatus.Size = new System.Drawing.Size(78, 15);
            this.lblHealthStatus.TabIndex = 12;
            this.lblHealthStatus.Text = "Health status";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.AllowDrop = true;
            this.dtDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfBirth.Location = new System.Drawing.Point(652, 13);
            this.dtDateOfBirth.MaxDate = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            this.dtDateOfBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(152, 21);
            this.dtDateOfBirth.TabIndex = 3;
            this.dtDateOfBirth.Value = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(689, 228);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 28);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Add";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.Register_Click);
            // 
            // cmbGenderStatus
            // 
            this.cmbGenderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenderStatus.FormattingEnabled = true;
            this.cmbGenderStatus.Location = new System.Drawing.Point(652, 51);
            this.cmbGenderStatus.Name = "cmbGenderStatus";
            this.cmbGenderStatus.Size = new System.Drawing.Size(152, 23);
            this.cmbGenderStatus.TabIndex = 6;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(582, 51);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(48, 15);
            this.lblMaritalStatus.TabIndex = 6;
            this.lblMaritalStatus.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(111, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(411, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(558, 15);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(74, 15);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tabSearchManage
            // 
            this.tabSearchManage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabSearchManage.Controls.Add(this.label7);
            this.tabSearchManage.Controls.Add(this.textBox4);
            this.tabSearchManage.Controls.Add(this.textBox3);
            this.tabSearchManage.Controls.Add(this.label1);
            this.tabSearchManage.Controls.Add(this.label10);
            this.tabSearchManage.Controls.Add(this.label11);
            this.tabSearchManage.Controls.Add(this.cmb2HealthStatus);
            this.tabSearchManage.Controls.Add(this.lbl2HealthStatus);
            this.tabSearchManage.Controls.Add(this.cmb2GenderStatus);
            this.tabSearchManage.Controls.Add(this.lbl2MaritalStatus);
            this.tabSearchManage.Controls.Add(this.label2);
            this.tabSearchManage.Controls.Add(this.label5);
            this.tabSearchManage.Controls.Add(this.dt2DateOfBirth);
            this.tabSearchManage.Controls.Add(this.txt2Name);
            this.tabSearchManage.Controls.Add(this.lbl2DateOfBirth);
            this.tabSearchManage.Controls.Add(this.lbl2Name);
            this.tabSearchManage.Controls.Add(this.btnUpdate);
            this.tabSearchManage.Controls.Add(this.btnDelete);
            this.tabSearchManage.Controls.Add(this.tabControl1);
            this.tabSearchManage.Controls.Add(this.dataGridViewPatients);
            this.tabSearchManage.Location = new System.Drawing.Point(4, 24);
            this.tabSearchManage.Name = "tabSearchManage";
            this.tabSearchManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchManage.Size = new System.Drawing.Size(1225, 493);
            this.tabSearchManage.TabIndex = 1;
            this.tabSearchManage.Text = "Search / Manage Patients";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(830, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Comments";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(947, 317);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(256, 63);
            this.textBox4.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(944, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(244, 21);
            this.textBox3.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "FamilyName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(904, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(906, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "*";
            // 
            // cmb2HealthStatus
            // 
            this.cmb2HealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2HealthStatus.FormattingEnabled = true;
            this.cmb2HealthStatus.Location = new System.Drawing.Point(947, 268);
            this.cmb2HealthStatus.Name = "cmb2HealthStatus";
            this.cmb2HealthStatus.Size = new System.Drawing.Size(256, 23);
            this.cmb2HealthStatus.TabIndex = 34;
            // 
            // lbl2HealthStatus
            // 
            this.lbl2HealthStatus.AutoSize = true;
            this.lbl2HealthStatus.Location = new System.Drawing.Point(826, 271);
            this.lbl2HealthStatus.Name = "lbl2HealthStatus";
            this.lbl2HealthStatus.Size = new System.Drawing.Size(78, 15);
            this.lbl2HealthStatus.TabIndex = 36;
            this.lbl2HealthStatus.Text = "Health status";
            // 
            // cmb2GenderStatus
            // 
            this.cmb2GenderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2GenderStatus.FormattingEnabled = true;
            this.cmb2GenderStatus.Location = new System.Drawing.Point(946, 228);
            this.cmb2GenderStatus.Name = "cmb2GenderStatus";
            this.cmb2GenderStatus.Size = new System.Drawing.Size(256, 23);
            this.cmb2GenderStatus.TabIndex = 32;
            // 
            // lbl2MaritalStatus
            // 
            this.lbl2MaritalStatus.AutoSize = true;
            this.lbl2MaritalStatus.Location = new System.Drawing.Point(826, 231);
            this.lbl2MaritalStatus.Name = "lbl2MaritalStatus";
            this.lbl2MaritalStatus.Size = new System.Drawing.Size(48, 15);
            this.lbl2MaritalStatus.TabIndex = 33;
            this.lbl2MaritalStatus.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(900, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(864, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            // 
            // dt2DateOfBirth
            // 
            this.dt2DateOfBirth.AllowDrop = true;
            this.dt2DateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dt2DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2DateOfBirth.Location = new System.Drawing.Point(944, 161);
            this.dt2DateOfBirth.MaxDate = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            this.dt2DateOfBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dt2DateOfBirth.Name = "dt2DateOfBirth";
            this.dt2DateOfBirth.Size = new System.Drawing.Size(218, 21);
            this.dt2DateOfBirth.TabIndex = 24;
            this.dt2DateOfBirth.Value = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            // 
            // txt2Name
            // 
            this.txt2Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Name.Location = new System.Drawing.Point(944, 131);
            this.txt2Name.Name = "txt2Name";
            this.txt2Name.Size = new System.Drawing.Size(256, 21);
            this.txt2Name.TabIndex = 23;
            // 
            // lbl2DateOfBirth
            // 
            this.lbl2DateOfBirth.AutoSize = true;
            this.lbl2DateOfBirth.Location = new System.Drawing.Point(827, 166);
            this.lbl2DateOfBirth.Name = "lbl2DateOfBirth";
            this.lbl2DateOfBirth.Size = new System.Drawing.Size(74, 15);
            this.lbl2DateOfBirth.TabIndex = 22;
            this.lbl2DateOfBirth.Text = "Date of Birth";
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Location = new System.Drawing.Point(824, 133);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(41, 15);
            this.lbl2Name.TabIndex = 21;
            this.lbl2Name.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(830, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 27);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1036, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 105);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 77);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(96, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(326, 21);
            this.textBox5.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(663, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(548, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToOrderColumns = true;
            this.dataGridViewPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(11, 130);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(794, 297);
            this.dataGridViewPatients.TabIndex = 3;
            this.dataGridViewPatients.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.dataGridViewPatients.SelectionChanged += new System.EventHandler(this.dataGridViewMembers_SelectionChanged);
            // 
            // tabServer
            // 
            this.tabServer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabServer.Controls.Add(this.button4);
            this.tabServer.Controls.Add(this.dataGridViewServer);
            this.tabServer.Controls.Add(this.tabControl3);
            this.tabServer.Controls.Add(this.button2);
            this.tabServer.Location = new System.Drawing.Point(4, 24);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(1225, 493);
            this.tabServer.TabIndex = 2;
            this.tabServer.Text = "FHIR Server Tools";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(976, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "import To LocalDB";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewServer
            // 
            this.dataGridViewServer.AllowUserToAddRows = false;
            this.dataGridViewServer.AllowUserToOrderColumns = true;
            this.dataGridViewServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewServer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServer.Location = new System.Drawing.Point(6, 199);
            this.dataGridViewServer.Name = "dataGridViewServer";
            this.dataGridViewServer.ReadOnly = true;
            this.dataGridViewServer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServer.Size = new System.Drawing.Size(839, 261);
            this.dataGridViewServer.TabIndex = 4;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabFHIRControl);
            this.tabControl3.Location = new System.Drawing.Point(6, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(839, 187);
            this.tabControl3.TabIndex = 0;
            // 
            // tabFHIRControl
            // 
            this.tabFHIRControl.Controls.Add(this.button5);
            this.tabFHIRControl.Controls.Add(this.button3);
            this.tabFHIRControl.Controls.Add(this.label4);
            this.tabFHIRControl.Controls.Add(this.textBox6);
            this.tabFHIRControl.Controls.Add(this.button1);
            this.tabFHIRControl.Controls.Add(this.textBox2);
            this.tabFHIRControl.Controls.Add(this.label6);
            this.tabFHIRControl.Location = new System.Drawing.Point(4, 24);
            this.tabFHIRControl.Name = "tabFHIRControl";
            this.tabFHIRControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabFHIRControl.Size = new System.Drawing.Size(831, 159);
            this.tabFHIRControl.TabIndex = 0;
            this.tabFHIRControl.Text = "Import/Export Patient Data";
            this.tabFHIRControl.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(399, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(493, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Query String";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(135, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(523, 21);
            this.textBox6.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fetch All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(135, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(523, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "http://spark.furore.com/fhir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "FHIR Server";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(976, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export localDB to Server";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1239, 537);
            this.Controls.Add(this.tab);
            this.IsMdiContainer = true;
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHIR Client";
            this.tab.ResumeLayout(false);
            this.tabRegistration.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabSearchManage.ResumeLayout(false);
            this.tabSearchManage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabServer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServer)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabFHIRControl.ResumeLayout(false);
            this.tabFHIRControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TabPage tabSearchManage;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbGenderStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.ComboBox cmbHealthStatus;
        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.Label lblHealthStatusRequired;
        private System.Windows.Forms.Label lblMaritalStatusRequired;
        private System.Windows.Forms.Label lblOccupationRequired;
        private System.Windows.Forms.Label lblDOBRequired;
        private System.Windows.Forms.Label lblNameRequired;
        private System.Drawing.Printing.PrintDocument PrintReport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt2DateOfBirth;
        private System.Windows.Forms.TextBox txt2Name;
        private System.Windows.Forms.Label lbl2DateOfBirth;
        private System.Windows.Forms.Label lbl2Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb2HealthStatus;
        private System.Windows.Forms.Label lbl2HealthStatus;
        private System.Windows.Forms.ComboBox cmb2GenderStatus;
        private System.Windows.Forms.Label lbl2MaritalStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Comments;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabFHIRControl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridViewServer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}