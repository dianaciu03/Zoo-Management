namespace ZooBazaarDesktopApp
{
    partial class FormHRAdministration
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
            this.tabControlHRAdministration = new System.Windows.Forms.TabControl();
            this.tabPageAllEmployees = new System.Windows.Forms.TabPage();
            this.panelAdministrateEmployees = new System.Windows.Forms.Panel();
            this.btnEditEmployeeAdditional = new System.Windows.Forms.Button();
            this.btnEditEmployeeContract = new System.Windows.Forms.Button();
            this.btnDisplayEmployeeInformation = new System.Windows.Forms.Button();
            this.ucSearchFeatureEmployees1 = new ZooBazaarDesktopApp.ucSearchFeatureEmployees();
            this.lvwEmployees = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContractType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageEmployeeHistory = new System.Windows.Forms.TabPage();
            this.groupBoxSearchEmployeeHistoryTab = new System.Windows.Forms.GroupBox();
            this.btnDisplayEmployeeHistoryTab = new System.Windows.Forms.Button();
            this.labelContractTypeEmployeeHistoryTab = new System.Windows.Forms.Label();
            this.rbFullTimeEmployeeHistoryTab = new System.Windows.Forms.RadioButton();
            this.rbPartTimeEmployeeHistoryTab = new System.Windows.Forms.RadioButton();
            this.cbRoleEmployeeHistory = new System.Windows.Forms.ComboBox();
            this.btnSearchEmployeeHistoryTab = new System.Windows.Forms.Button();
            this.btnClearFieldsEmployeeHistoryTab = new System.Windows.Forms.Button();
            this.labelRoleEmployeeTab = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelLastNameEmployeeHistory = new System.Windows.Forms.Label();
            this.labelFNEmployeeHistory = new System.Windows.Forms.Label();
            this.listViewEmployeeHistoryTab = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContractType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContractStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.rbtnSortByContract = new System.Windows.Forms.RadioButton();
            this.rbtnSortByRole = new System.Windows.Forms.RadioButton();
            this.rbtnSortAlphabeticalDesc = new System.Windows.Forms.RadioButton();
            this.rbtnSortAlphabeticalAsc = new System.Windows.Forms.RadioButton();
            this.labelSortbyEmployee = new System.Windows.Forms.Label();
            this.labelAllAnimals = new System.Windows.Forms.Label();
            this.tabCreateEmployee = new System.Windows.Forms.TabPage();
            this.labelNote = new System.Windows.Forms.Label();
            this.groupBoxEmergencyContact = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbxNewEmpAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancelEmployeeCreation = new System.Windows.Forms.Button();
            this.groupBoxContractDetailsPopup = new System.Windows.Forms.GroupBox();
            this.cbNotMentioned = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dtmContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelContractStartDate = new System.Windows.Forms.Label();
            this.labelContractMonths = new System.Windows.Forms.Label();
            this.nudContractLenght = new System.Windows.Forms.NumericUpDown();
            this.cbxFixedTermContract = new System.Windows.Forms.CheckBox();
            this.nudWeeklyHours = new System.Windows.Forms.NumericUpDown();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmEmployeeCreation = new System.Windows.Forms.Button();
            this.groupBoxEmployeeDetailsPopup = new System.Windows.Forms.GroupBox();
            this.rbAddFemale = new System.Windows.Forms.RadioButton();
            this.rbAddMale = new System.Windows.Forms.RadioButton();
            this.maskedtbxDoBEmployee = new System.Windows.Forms.MaskedTextBox();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.labelEmployeePassword = new System.Windows.Forms.Label();
            this.tbxEmployeePassword = new System.Windows.Forms.TextBox();
            this.labelEmployeeBirthdate = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.labelEmployeeEmail = new System.Windows.Forms.Label();
            this.labelEmployeePhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNewEmpRole = new System.Windows.Forms.ComboBox();
            this.tbxNewEmpLastName = new System.Windows.Forms.TextBox();
            this.tbxNewEmpFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlHRAdministration.SuspendLayout();
            this.tabPageAllEmployees.SuspendLayout();
            this.tabPageEmployeeHistory.SuspendLayout();
            this.groupBoxSearchEmployeeHistoryTab.SuspendLayout();
            this.tabCreateEmployee.SuspendLayout();
            this.groupBoxEmergencyContact.SuspendLayout();
            this.groupBoxContractDetailsPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContractLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyHours)).BeginInit();
            this.groupBoxEmployeeDetailsPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHRAdministration
            // 
            this.tabControlHRAdministration.Controls.Add(this.tabPageAllEmployees);
            this.tabControlHRAdministration.Controls.Add(this.tabPageEmployeeHistory);
            this.tabControlHRAdministration.Controls.Add(this.tabCreateEmployee);
            this.tabControlHRAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlHRAdministration.Location = new System.Drawing.Point(102, 94);
            this.tabControlHRAdministration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlHRAdministration.Name = "tabControlHRAdministration";
            this.tabControlHRAdministration.Padding = new System.Drawing.Point(70, 9);
            this.tabControlHRAdministration.SelectedIndex = 0;
            this.tabControlHRAdministration.Size = new System.Drawing.Size(2674, 1418);
            this.tabControlHRAdministration.TabIndex = 9;
            // 
            // tabPageAllEmployees
            // 
            this.tabPageAllEmployees.Controls.Add(this.panelAdministrateEmployees);
            this.tabPageAllEmployees.Controls.Add(this.btnEditEmployeeAdditional);
            this.tabPageAllEmployees.Controls.Add(this.btnEditEmployeeContract);
            this.tabPageAllEmployees.Controls.Add(this.btnDisplayEmployeeInformation);
            this.tabPageAllEmployees.Controls.Add(this.ucSearchFeatureEmployees1);
            this.tabPageAllEmployees.Controls.Add(this.lvwEmployees);
            this.tabPageAllEmployees.Location = new System.Drawing.Point(4, 58);
            this.tabPageAllEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAllEmployees.Name = "tabPageAllEmployees";
            this.tabPageAllEmployees.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAllEmployees.Size = new System.Drawing.Size(2666, 1356);
            this.tabPageAllEmployees.TabIndex = 0;
            this.tabPageAllEmployees.Text = "Administrate employees";
            this.tabPageAllEmployees.UseVisualStyleBackColor = true;
            // 
            // panelAdministrateEmployees
            // 
            this.panelAdministrateEmployees.Location = new System.Drawing.Point(20, 573);
            this.panelAdministrateEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAdministrateEmployees.Name = "panelAdministrateEmployees";
            this.panelAdministrateEmployees.Size = new System.Drawing.Size(854, 765);
            this.panelAdministrateEmployees.TabIndex = 22;
            // 
            // btnEditEmployeeAdditional
            // 
            this.btnEditEmployeeAdditional.AutoSize = true;
            this.btnEditEmployeeAdditional.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditEmployeeAdditional.Location = new System.Drawing.Point(2193, 1208);
            this.btnEditEmployeeAdditional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditEmployeeAdditional.Name = "btnEditEmployeeAdditional";
            this.btnEditEmployeeAdditional.Size = new System.Drawing.Size(597, 70);
            this.btnEditEmployeeAdditional.TabIndex = 21;
            this.btnEditEmployeeAdditional.Text = "Edit additional information";
            this.btnEditEmployeeAdditional.UseVisualStyleBackColor = false;
            this.btnEditEmployeeAdditional.Click += new System.EventHandler(this.btnEditEmployeeAdditional_Click);
            // 
            // btnEditEmployeeContract
            // 
            this.btnEditEmployeeContract.AutoSize = true;
            this.btnEditEmployeeContract.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditEmployeeContract.Location = new System.Drawing.Point(1568, 1208);
            this.btnEditEmployeeContract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditEmployeeContract.Name = "btnEditEmployeeContract";
            this.btnEditEmployeeContract.Size = new System.Drawing.Size(526, 70);
            this.btnEditEmployeeContract.TabIndex = 20;
            this.btnEditEmployeeContract.Text = "Edit employee contract";
            this.btnEditEmployeeContract.UseVisualStyleBackColor = false;
            this.btnEditEmployeeContract.Click += new System.EventHandler(this.btnEditEmployeeContract_Click);
            // 
            // btnDisplayEmployeeInformation
            // 
            this.btnDisplayEmployeeInformation.AutoSize = true;
            this.btnDisplayEmployeeInformation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDisplayEmployeeInformation.Location = new System.Drawing.Point(927, 1208);
            this.btnDisplayEmployeeInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayEmployeeInformation.Name = "btnDisplayEmployeeInformation";
            this.btnDisplayEmployeeInformation.Size = new System.Drawing.Size(594, 70);
            this.btnDisplayEmployeeInformation.TabIndex = 19;
            this.btnDisplayEmployeeInformation.Text = "Edit employee information";
            this.btnDisplayEmployeeInformation.UseVisualStyleBackColor = false;
            this.btnDisplayEmployeeInformation.Click += new System.EventHandler(this.btnDisplayEmployeeInformation_Click);
            // 
            // ucSearchFeatureEmployees1
            // 
            this.ucSearchFeatureEmployees1.Location = new System.Drawing.Point(20, 22);
            this.ucSearchFeatureEmployees1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucSearchFeatureEmployees1.MaximumSize = new System.Drawing.Size(854, 561);
            this.ucSearchFeatureEmployees1.MinimumSize = new System.Drawing.Size(854, 561);
            this.ucSearchFeatureEmployees1.Name = "ucSearchFeatureEmployees1";
            this.ucSearchFeatureEmployees1.Size = new System.Drawing.Size(854, 561);
            this.ucSearchFeatureEmployees1.TabIndex = 16;
            this.ucSearchFeatureEmployees1.Load += new System.EventHandler(this.ucSearchFeatureEmployees1_Load);
            // 
            // lvwEmployees
            // 
            this.lvwEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colRole,
            this.colContractType});
            this.lvwEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lvwEmployees.FullRowSelect = true;
            this.lvwEmployees.HideSelection = false;
            this.lvwEmployees.Location = new System.Drawing.Point(927, 52);
            this.lvwEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwEmployees.MultiSelect = false;
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(1674, 1124);
            this.lvwEmployees.TabIndex = 14;
            this.lvwEmployees.UseCompatibleStateImageBehavior = false;
            this.lvwEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 77;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First name";
            this.colFirstName.Width = 228;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last name";
            this.colLastName.Width = 233;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.Width = 246;
            // 
            // colContractType
            // 
            this.colContractType.Text = "Contract type";
            this.colContractType.Width = 221;
            // 
            // tabPageEmployeeHistory
            // 
            this.tabPageEmployeeHistory.Controls.Add(this.groupBoxSearchEmployeeHistoryTab);
            this.tabPageEmployeeHistory.Controls.Add(this.listViewEmployeeHistoryTab);
            this.tabPageEmployeeHistory.Controls.Add(this.btnSearchHistory);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortByContract);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortByRole);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortAlphabeticalDesc);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortAlphabeticalAsc);
            this.tabPageEmployeeHistory.Controls.Add(this.labelSortbyEmployee);
            this.tabPageEmployeeHistory.Controls.Add(this.labelAllAnimals);
            this.tabPageEmployeeHistory.Location = new System.Drawing.Point(4, 58);
            this.tabPageEmployeeHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageEmployeeHistory.Name = "tabPageEmployeeHistory";
            this.tabPageEmployeeHistory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageEmployeeHistory.Size = new System.Drawing.Size(2666, 1356);
            this.tabPageEmployeeHistory.TabIndex = 1;
            this.tabPageEmployeeHistory.Text = "Employee history";
            this.tabPageEmployeeHistory.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchEmployeeHistoryTab
            // 
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.btnDisplayEmployeeHistoryTab);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.labelContractTypeEmployeeHistoryTab);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.rbFullTimeEmployeeHistoryTab);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.rbPartTimeEmployeeHistoryTab);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.cbRoleEmployeeHistory);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.btnSearchEmployeeHistoryTab);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.btnClearFieldsEmployeeHistoryTab);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.labelRoleEmployeeTab);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.textBox4);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.textBox5);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.labelLastNameEmployeeHistory);
            this.groupBoxSearchEmployeeHistoryTab.Controls.Add(this.labelFNEmployeeHistory);
            this.groupBoxSearchEmployeeHistoryTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBoxSearchEmployeeHistoryTab.Location = new System.Drawing.Point(6, 88);
            this.groupBoxSearchEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxSearchEmployeeHistoryTab.Name = "groupBoxSearchEmployeeHistoryTab";
            this.groupBoxSearchEmployeeHistoryTab.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxSearchEmployeeHistoryTab.Size = new System.Drawing.Size(825, 603);
            this.groupBoxSearchEmployeeHistoryTab.TabIndex = 45;
            this.groupBoxSearchEmployeeHistoryTab.TabStop = false;
            this.groupBoxSearchEmployeeHistoryTab.Text = "Search by:";
            // 
            // btnDisplayEmployeeHistoryTab
            // 
            this.btnDisplayEmployeeHistoryTab.AutoSize = true;
            this.btnDisplayEmployeeHistoryTab.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDisplayEmployeeHistoryTab.Location = new System.Drawing.Point(206, 460);
            this.btnDisplayEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayEmployeeHistoryTab.Name = "btnDisplayEmployeeHistoryTab";
            this.btnDisplayEmployeeHistoryTab.Size = new System.Drawing.Size(532, 70);
            this.btnDisplayEmployeeHistoryTab.TabIndex = 24;
            this.btnDisplayEmployeeHistoryTab.Text = "Display all employees";
            this.btnDisplayEmployeeHistoryTab.UseVisualStyleBackColor = false;
            // 
            // labelContractTypeEmployeeHistoryTab
            // 
            this.labelContractTypeEmployeeHistoryTab.AutoSize = true;
            this.labelContractTypeEmployeeHistoryTab.Location = new System.Drawing.Point(40, 206);
            this.labelContractTypeEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelContractTypeEmployeeHistoryTab.Name = "labelContractTypeEmployeeHistoryTab";
            this.labelContractTypeEmployeeHistoryTab.Size = new System.Drawing.Size(216, 37);
            this.labelContractTypeEmployeeHistoryTab.TabIndex = 23;
            this.labelContractTypeEmployeeHistoryTab.Text = "Contract type:";
            // 
            // rbFullTimeEmployeeHistoryTab
            // 
            this.rbFullTimeEmployeeHistoryTab.AutoSize = true;
            this.rbFullTimeEmployeeHistoryTab.Location = new System.Drawing.Point(290, 201);
            this.rbFullTimeEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFullTimeEmployeeHistoryTab.Name = "rbFullTimeEmployeeHistoryTab";
            this.rbFullTimeEmployeeHistoryTab.Size = new System.Drawing.Size(164, 41);
            this.rbFullTimeEmployeeHistoryTab.TabIndex = 22;
            this.rbFullTimeEmployeeHistoryTab.TabStop = true;
            this.rbFullTimeEmployeeHistoryTab.Text = "Full-time";
            this.rbFullTimeEmployeeHistoryTab.UseVisualStyleBackColor = true;
            // 
            // rbPartTimeEmployeeHistoryTab
            // 
            this.rbPartTimeEmployeeHistoryTab.AutoSize = true;
            this.rbPartTimeEmployeeHistoryTab.Location = new System.Drawing.Point(590, 201);
            this.rbPartTimeEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPartTimeEmployeeHistoryTab.Name = "rbPartTimeEmployeeHistoryTab";
            this.rbPartTimeEmployeeHistoryTab.Size = new System.Drawing.Size(171, 41);
            this.rbPartTimeEmployeeHistoryTab.TabIndex = 21;
            this.rbPartTimeEmployeeHistoryTab.TabStop = true;
            this.rbPartTimeEmployeeHistoryTab.Text = "Part-time";
            this.rbPartTimeEmployeeHistoryTab.UseVisualStyleBackColor = true;
            // 
            // cbRoleEmployeeHistory
            // 
            this.cbRoleEmployeeHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoleEmployeeHistory.FormattingEnabled = true;
            this.cbRoleEmployeeHistory.Location = new System.Drawing.Point(290, 270);
            this.cbRoleEmployeeHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoleEmployeeHistory.Name = "cbRoleEmployeeHistory";
            this.cbRoleEmployeeHistory.Size = new System.Drawing.Size(476, 45);
            this.cbRoleEmployeeHistory.TabIndex = 9;
            // 
            // btnSearchEmployeeHistoryTab
            // 
            this.btnSearchEmployeeHistoryTab.AutoSize = true;
            this.btnSearchEmployeeHistoryTab.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearchEmployeeHistoryTab.Location = new System.Drawing.Point(176, 362);
            this.btnSearchEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchEmployeeHistoryTab.Name = "btnSearchEmployeeHistoryTab";
            this.btnSearchEmployeeHistoryTab.Size = new System.Drawing.Size(279, 70);
            this.btnSearchEmployeeHistoryTab.TabIndex = 14;
            this.btnSearchEmployeeHistoryTab.Text = "Search";
            this.btnSearchEmployeeHistoryTab.UseVisualStyleBackColor = false;
            // 
            // btnClearFieldsEmployeeHistoryTab
            // 
            this.btnClearFieldsEmployeeHistoryTab.AutoSize = true;
            this.btnClearFieldsEmployeeHistoryTab.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClearFieldsEmployeeHistoryTab.Location = new System.Drawing.Point(488, 362);
            this.btnClearFieldsEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearFieldsEmployeeHistoryTab.Name = "btnClearFieldsEmployeeHistoryTab";
            this.btnClearFieldsEmployeeHistoryTab.Size = new System.Drawing.Size(279, 70);
            this.btnClearFieldsEmployeeHistoryTab.TabIndex = 15;
            this.btnClearFieldsEmployeeHistoryTab.Text = "Clear fields";
            this.btnClearFieldsEmployeeHistoryTab.UseVisualStyleBackColor = false;
            // 
            // labelRoleEmployeeTab
            // 
            this.labelRoleEmployeeTab.AutoSize = true;
            this.labelRoleEmployeeTab.Location = new System.Drawing.Point(40, 274);
            this.labelRoleEmployeeTab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRoleEmployeeTab.Name = "labelRoleEmployeeTab";
            this.labelRoleEmployeeTab.Size = new System.Drawing.Size(90, 37);
            this.labelRoleEmployeeTab.TabIndex = 16;
            this.labelRoleEmployeeTab.Text = "Role:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(290, 129);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(476, 44);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(290, 57);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(476, 44);
            this.textBox5.TabIndex = 5;
            // 
            // labelLastNameEmployeeHistory
            // 
            this.labelLastNameEmployeeHistory.AutoSize = true;
            this.labelLastNameEmployeeHistory.Location = new System.Drawing.Point(40, 134);
            this.labelLastNameEmployeeHistory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLastNameEmployeeHistory.Name = "labelLastNameEmployeeHistory";
            this.labelLastNameEmployeeHistory.Size = new System.Drawing.Size(176, 37);
            this.labelLastNameEmployeeHistory.TabIndex = 1;
            this.labelLastNameEmployeeHistory.Text = "Last name:";
            // 
            // labelFNEmployeeHistory
            // 
            this.labelFNEmployeeHistory.AutoSize = true;
            this.labelFNEmployeeHistory.Location = new System.Drawing.Point(39, 63);
            this.labelFNEmployeeHistory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFNEmployeeHistory.Name = "labelFNEmployeeHistory";
            this.labelFNEmployeeHistory.Size = new System.Drawing.Size(178, 37);
            this.labelFNEmployeeHistory.TabIndex = 0;
            this.labelFNEmployeeHistory.Text = "First name:";
            // 
            // listViewEmployeeHistoryTab
            // 
            this.listViewEmployeeHistoryTab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnFirstName,
            this.columnLastName,
            this.columnRole,
            this.columnEmail,
            this.columnPhone,
            this.columnContractType,
            this.columnContractStatus});
            this.listViewEmployeeHistoryTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listViewEmployeeHistoryTab.FullRowSelect = true;
            this.listViewEmployeeHistoryTab.HideSelection = false;
            this.listViewEmployeeHistoryTab.Location = new System.Drawing.Point(842, 102);
            this.listViewEmployeeHistoryTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewEmployeeHistoryTab.MultiSelect = false;
            this.listViewEmployeeHistoryTab.Name = "listViewEmployeeHistoryTab";
            this.listViewEmployeeHistoryTab.Size = new System.Drawing.Size(1782, 1206);
            this.listViewEmployeeHistoryTab.TabIndex = 44;
            this.listViewEmployeeHistoryTab.UseCompatibleStateImageBehavior = false;
            this.listViewEmployeeHistoryTab.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 58;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First name";
            this.columnFirstName.Width = 220;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last name";
            this.columnLastName.Width = 230;
            // 
            // columnRole
            // 
            this.columnRole.Text = "Role";
            this.columnRole.Width = 216;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 221;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone";
            this.columnPhone.Width = 263;
            // 
            // columnContractType
            // 
            this.columnContractType.Text = "ContractType";
            this.columnContractType.Width = 235;
            // 
            // columnContractStatus
            // 
            this.columnContractStatus.Text = "Contract status";
            this.columnContractStatus.Width = 256;
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearchHistory.Location = new System.Drawing.Point(2452, 16);
            this.btnSearchHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.Size = new System.Drawing.Size(172, 63);
            this.btnSearchHistory.TabIndex = 42;
            this.btnSearchHistory.Text = "Display";
            this.btnSearchHistory.UseVisualStyleBackColor = false;
            // 
            // rbtnSortByContract
            // 
            this.rbtnSortByContract.AutoSize = true;
            this.rbtnSortByContract.Location = new System.Drawing.Point(2186, 27);
            this.rbtnSortByContract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSortByContract.Name = "rbtnSortByContract";
            this.rbtnSortByContract.Size = new System.Drawing.Size(232, 41);
            this.rbtnSortByContract.TabIndex = 41;
            this.rbtnSortByContract.Text = "Contract type";
            this.rbtnSortByContract.UseVisualStyleBackColor = true;
            // 
            // rbtnSortByRole
            // 
            this.rbtnSortByRole.AutoSize = true;
            this.rbtnSortByRole.Location = new System.Drawing.Point(2050, 27);
            this.rbtnSortByRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSortByRole.Name = "rbtnSortByRole";
            this.rbtnSortByRole.Size = new System.Drawing.Size(106, 41);
            this.rbtnSortByRole.TabIndex = 40;
            this.rbtnSortByRole.Text = "Role";
            this.rbtnSortByRole.UseVisualStyleBackColor = true;
            // 
            // rbtnSortAlphabeticalDesc
            // 
            this.rbtnSortAlphabeticalDesc.AutoSize = true;
            this.rbtnSortAlphabeticalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSortAlphabeticalDesc.Location = new System.Drawing.Point(1779, 27);
            this.rbtnSortAlphabeticalDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSortAlphabeticalDesc.Name = "rbtnSortAlphabeticalDesc";
            this.rbtnSortAlphabeticalDesc.Size = new System.Drawing.Size(242, 41);
            this.rbtnSortAlphabeticalDesc.TabIndex = 39;
            this.rbtnSortAlphabeticalDesc.Text = "Alphabetical ↓";
            this.rbtnSortAlphabeticalDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnSortAlphabeticalAsc
            // 
            this.rbtnSortAlphabeticalAsc.AutoSize = true;
            this.rbtnSortAlphabeticalAsc.Checked = true;
            this.rbtnSortAlphabeticalAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSortAlphabeticalAsc.Location = new System.Drawing.Point(1506, 27);
            this.rbtnSortAlphabeticalAsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSortAlphabeticalAsc.Name = "rbtnSortAlphabeticalAsc";
            this.rbtnSortAlphabeticalAsc.Size = new System.Drawing.Size(242, 41);
            this.rbtnSortAlphabeticalAsc.TabIndex = 38;
            this.rbtnSortAlphabeticalAsc.TabStop = true;
            this.rbtnSortAlphabeticalAsc.Text = "Alphabetical ↑";
            this.rbtnSortAlphabeticalAsc.UseVisualStyleBackColor = true;
            // 
            // labelSortbyEmployee
            // 
            this.labelSortbyEmployee.AutoSize = true;
            this.labelSortbyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortbyEmployee.Location = new System.Drawing.Point(1353, 30);
            this.labelSortbyEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortbyEmployee.Name = "labelSortbyEmployee";
            this.labelSortbyEmployee.Size = new System.Drawing.Size(127, 37);
            this.labelSortbyEmployee.TabIndex = 37;
            this.labelSortbyEmployee.Text = "Sort by:";
            // 
            // labelAllAnimals
            // 
            this.labelAllAnimals.AutoSize = true;
            this.labelAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllAnimals.Location = new System.Drawing.Point(9, 22);
            this.labelAllAnimals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllAnimals.Name = "labelAllAnimals";
            this.labelAllAnimals.Size = new System.Drawing.Size(282, 46);
            this.labelAllAnimals.TabIndex = 36;
            this.labelAllAnimals.Text = "All employees";
            // 
            // tabCreateEmployee
            // 
            this.tabCreateEmployee.Controls.Add(this.labelNote);
            this.tabCreateEmployee.Controls.Add(this.groupBoxEmergencyContact);
            this.tabCreateEmployee.Controls.Add(this.btnCancelEmployeeCreation);
            this.tabCreateEmployee.Controls.Add(this.groupBoxContractDetailsPopup);
            this.tabCreateEmployee.Controls.Add(this.btnConfirmEmployeeCreation);
            this.tabCreateEmployee.Controls.Add(this.groupBoxEmployeeDetailsPopup);
            this.tabCreateEmployee.Location = new System.Drawing.Point(4, 58);
            this.tabCreateEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCreateEmployee.Name = "tabCreateEmployee";
            this.tabCreateEmployee.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCreateEmployee.Size = new System.Drawing.Size(2666, 1356);
            this.tabCreateEmployee.TabIndex = 2;
            this.tabCreateEmployee.Text = "Create employee";
            this.tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelNote.Location = new System.Drawing.Point(802, 891);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(1038, 40);
            this.labelNote.TabIndex = 35;
            this.labelNote.Text = "Note: You need to complete all fields before creating an account";
            // 
            // groupBoxEmergencyContact
            // 
            this.groupBoxEmergencyContact.Controls.Add(this.label8);
            this.groupBoxEmergencyContact.Controls.Add(this.textBox6);
            this.groupBoxEmergencyContact.Controls.Add(this.label12);
            this.groupBoxEmergencyContact.Controls.Add(this.textBox9);
            this.groupBoxEmergencyContact.Controls.Add(this.textBox10);
            this.groupBoxEmergencyContact.Controls.Add(this.textBox11);
            this.groupBoxEmergencyContact.Controls.Add(this.label14);
            this.groupBoxEmergencyContact.Controls.Add(this.label15);
            this.groupBoxEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBoxEmergencyContact.Location = new System.Drawing.Point(1824, 62);
            this.groupBoxEmergencyContact.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxEmergencyContact.Name = "groupBoxEmergencyContact";
            this.groupBoxEmergencyContact.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxEmergencyContact.Size = new System.Drawing.Size(807, 411);
            this.groupBoxEmergencyContact.TabIndex = 35;
            this.groupBoxEmergencyContact.TabStop = false;
            this.groupBoxEmergencyContact.Text = "Emergency contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 40);
            this.label8.TabIndex = 29;
            this.label8.Text = "Relationship:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(332, 315);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(440, 48);
            this.textBox6.TabIndex = 28;
            // 
            // tbxNewEmpAddress
            // 
            this.tbxNewEmpAddress.Location = new System.Drawing.Point(304, 479);
            this.tbxNewEmpAddress.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxNewEmpAddress.Multiline = true;
            this.tbxNewEmpAddress.Name = "tbxNewEmpAddress";
            this.tbxNewEmpAddress.Size = new System.Drawing.Size(440, 48);
            this.tbxNewEmpAddress.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 482);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 40);
            this.label9.TabIndex = 26;
            this.label9.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 240);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 40);
            this.label12.TabIndex = 18;
            this.label12.Text = "Phone number:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(332, 236);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(440, 48);
            this.textBox9.TabIndex = 17;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(332, 158);
            this.textBox10.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(440, 48);
            this.textBox10.TabIndex = 6;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(332, 81);
            this.textBox11.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(440, 48);
            this.textBox11.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 162);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "Last name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(93, 86);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 40);
            this.label15.TabIndex = 0;
            this.label15.Text = "First name:";
            // 
            // btnCancelEmployeeCreation
            // 
            this.btnCancelEmployeeCreation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelEmployeeCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.btnCancelEmployeeCreation.Location = new System.Drawing.Point(1536, 1010);
            this.btnCancelEmployeeCreation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelEmployeeCreation.Name = "btnCancelEmployeeCreation";
            this.btnCancelEmployeeCreation.Size = new System.Drawing.Size(512, 154);
            this.btnCancelEmployeeCreation.TabIndex = 33;
            this.btnCancelEmployeeCreation.Text = "Cancel";
            this.btnCancelEmployeeCreation.UseVisualStyleBackColor = false;
            // 
            // groupBoxContractDetailsPopup
            // 
            this.groupBoxContractDetailsPopup.Controls.Add(this.cbNotMentioned);
            this.groupBoxContractDetailsPopup.Controls.Add(this.label6);
            this.groupBoxContractDetailsPopup.Controls.Add(this.textBox3);
            this.groupBoxContractDetailsPopup.Controls.Add(this.labelSalary);
            this.groupBoxContractDetailsPopup.Controls.Add(this.dateTimePicker1);
            this.groupBoxContractDetailsPopup.Controls.Add(this.labelEndDate);
            this.groupBoxContractDetailsPopup.Controls.Add(this.dtmContractStartDate);
            this.groupBoxContractDetailsPopup.Controls.Add(this.labelContractStartDate);
            this.groupBoxContractDetailsPopup.Controls.Add(this.labelContractMonths);
            this.groupBoxContractDetailsPopup.Controls.Add(this.nudContractLenght);
            this.groupBoxContractDetailsPopup.Controls.Add(this.cbxFixedTermContract);
            this.groupBoxContractDetailsPopup.Controls.Add(this.nudWeeklyHours);
            this.groupBoxContractDetailsPopup.Controls.Add(this.lblHoursPerWeek);
            this.groupBoxContractDetailsPopup.Controls.Add(this.radioButton1);
            this.groupBoxContractDetailsPopup.Controls.Add(this.radioButton2);
            this.groupBoxContractDetailsPopup.Controls.Add(this.label4);
            this.groupBoxContractDetailsPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBoxContractDetailsPopup.Location = new System.Drawing.Point(879, 62);
            this.groupBoxContractDetailsPopup.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.groupBoxContractDetailsPopup.Name = "groupBoxContractDetailsPopup";
            this.groupBoxContractDetailsPopup.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.groupBoxContractDetailsPopup.Size = new System.Drawing.Size(910, 756);
            this.groupBoxContractDetailsPopup.TabIndex = 34;
            this.groupBoxContractDetailsPopup.TabStop = false;
            this.groupBoxContractDetailsPopup.Text = "Contract details";
            // 
            // cbNotMentioned
            // 
            this.cbNotMentioned.AutoSize = true;
            this.cbNotMentioned.Location = new System.Drawing.Point(597, 318);
            this.cbNotMentioned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNotMentioned.Name = "cbNotMentioned";
            this.cbNotMentioned.Size = new System.Drawing.Size(271, 44);
            this.cbNotMentioned.TabIndex = 48;
            this.cbNotMentioned.Text = "not mentioned";
            this.cbNotMentioned.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 40);
            this.label6.TabIndex = 47;
            this.label6.Text = "euros per month";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 456);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 48);
            this.textBox3.TabIndex = 46;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(129, 460);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(129, 40);
            this.labelSalary.TabIndex = 45;
            this.labelSalary.Text = "Salary:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 238);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(560, 46);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(92, 249);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(171, 40);
            this.labelEndDate.TabIndex = 31;
            this.labelEndDate.Text = "End date:";
            // 
            // dtmContractStartDate
            // 
            this.dtmContractStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtmContractStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.dtmContractStartDate.Location = new System.Drawing.Point(312, 156);
            this.dtmContractStartDate.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.dtmContractStartDate.Name = "dtmContractStartDate";
            this.dtmContractStartDate.Size = new System.Drawing.Size(560, 46);
            this.dtmContractStartDate.TabIndex = 28;
            // 
            // labelContractStartDate
            // 
            this.labelContractStartDate.AutoSize = true;
            this.labelContractStartDate.Location = new System.Drawing.Point(81, 165);
            this.labelContractStartDate.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelContractStartDate.Name = "labelContractStartDate";
            this.labelContractStartDate.Size = new System.Drawing.Size(183, 40);
            this.labelContractStartDate.TabIndex = 29;
            this.labelContractStartDate.Text = "Start date:";
            // 
            // labelContractMonths
            // 
            this.labelContractMonths.AutoSize = true;
            this.labelContractMonths.Location = new System.Drawing.Point(580, 561);
            this.labelContractMonths.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labelContractMonths.Name = "labelContractMonths";
            this.labelContractMonths.Size = new System.Drawing.Size(159, 40);
            this.labelContractMonths.TabIndex = 28;
            this.labelContractMonths.Text = "Month(s)";
            // 
            // nudContractLenght
            // 
            this.nudContractLenght.Enabled = false;
            this.nudContractLenght.Location = new System.Drawing.Point(404, 558);
            this.nudContractLenght.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.nudContractLenght.Name = "nudContractLenght";
            this.nudContractLenght.Size = new System.Drawing.Size(156, 48);
            this.nudContractLenght.TabIndex = 27;
            // 
            // cbxFixedTermContract
            // 
            this.cbxFixedTermContract.AutoSize = true;
            this.cbxFixedTermContract.Location = new System.Drawing.Point(36, 560);
            this.cbxFixedTermContract.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.cbxFixedTermContract.Name = "cbxFixedTermContract";
            this.cbxFixedTermContract.Size = new System.Drawing.Size(353, 44);
            this.cbxFixedTermContract.TabIndex = 26;
            this.cbxFixedTermContract.Text = "Fixed-term contract";
            this.cbxFixedTermContract.UseVisualStyleBackColor = true;
            // 
            // nudWeeklyHours
            // 
            this.nudWeeklyHours.Location = new System.Drawing.Point(312, 378);
            this.nudWeeklyHours.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.nudWeeklyHours.Name = "nudWeeklyHours";
            this.nudWeeklyHours.Size = new System.Drawing.Size(248, 48);
            this.nudWeeklyHours.TabIndex = 25;
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(24, 381);
            this.lblHoursPerWeek.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(245, 40);
            this.lblHoursPerWeek.TabIndex = 24;
            this.lblHoursPerWeek.Text = "Weekly hours:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(312, 80);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(180, 44);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Full-time";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(544, 80);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(188, 44);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Part-time";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 40);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contract type:";
            // 
            // btnConfirmEmployeeCreation
            // 
            this.btnConfirmEmployeeCreation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConfirmEmployeeCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.btnConfirmEmployeeCreation.Location = new System.Drawing.Point(609, 1010);
            this.btnConfirmEmployeeCreation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmEmployeeCreation.Name = "btnConfirmEmployeeCreation";
            this.btnConfirmEmployeeCreation.Size = new System.Drawing.Size(512, 154);
            this.btnConfirmEmployeeCreation.TabIndex = 32;
            this.btnConfirmEmployeeCreation.Text = "Create account";
            this.btnConfirmEmployeeCreation.UseVisualStyleBackColor = false;
            this.btnConfirmEmployeeCreation.Click += new System.EventHandler(this.btnConfirmEmployeeCreation_Click);
            // 
            // groupBoxEmployeeDetailsPopup
            // 
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.rbAddFemale);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.rbAddMale);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.maskedtbxDoBEmployee);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.lblEmployeeGender);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.tbxNewEmpAddress);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.labelEmployeePassword);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.label9);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.tbxEmployeePassword);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.labelEmployeeBirthdate);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.tbxEmail);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.labelEmployeeEmail);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.labelEmployeePhone);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.tbxPhone);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.label2);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.cbxNewEmpRole);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.tbxNewEmpLastName);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.tbxNewEmpFirstName);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.label3);
            this.groupBoxEmployeeDetailsPopup.Controls.Add(this.label5);
            this.groupBoxEmployeeDetailsPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBoxEmployeeDetailsPopup.Location = new System.Drawing.Point(33, 62);
            this.groupBoxEmployeeDetailsPopup.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxEmployeeDetailsPopup.Name = "groupBoxEmployeeDetailsPopup";
            this.groupBoxEmployeeDetailsPopup.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxEmployeeDetailsPopup.Size = new System.Drawing.Size(807, 825);
            this.groupBoxEmployeeDetailsPopup.TabIndex = 31;
            this.groupBoxEmployeeDetailsPopup.TabStop = false;
            this.groupBoxEmployeeDetailsPopup.Text = "Employee information";
            // 
            // rbAddFemale
            // 
            this.rbAddFemale.AutoSize = true;
            this.rbAddFemale.Location = new System.Drawing.Point(530, 237);
            this.rbAddFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAddFemale.Name = "rbAddFemale";
            this.rbAddFemale.Size = new System.Drawing.Size(162, 44);
            this.rbAddFemale.TabIndex = 34;
            this.rbAddFemale.TabStop = true;
            this.rbAddFemale.Text = "Female";
            this.rbAddFemale.UseVisualStyleBackColor = true;
            // 
            // rbAddMale
            // 
            this.rbAddMale.AutoSize = true;
            this.rbAddMale.Location = new System.Drawing.Point(345, 237);
            this.rbAddMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAddMale.Name = "rbAddMale";
            this.rbAddMale.Size = new System.Drawing.Size(120, 44);
            this.rbAddMale.TabIndex = 33;
            this.rbAddMale.TabStop = true;
            this.rbAddMale.Text = "Male";
            this.rbAddMale.UseVisualStyleBackColor = true;
            // 
            // maskedtbxDoBEmployee
            // 
            this.maskedtbxDoBEmployee.Location = new System.Drawing.Point(548, 704);
            this.maskedtbxDoBEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedtbxDoBEmployee.Mask = "00/00/0000";
            this.maskedtbxDoBEmployee.Name = "maskedtbxDoBEmployee";
            this.maskedtbxDoBEmployee.Size = new System.Drawing.Size(198, 48);
            this.maskedtbxDoBEmployee.TabIndex = 32;
            this.maskedtbxDoBEmployee.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.AutoSize = true;
            this.lblEmployeeGender.Location = new System.Drawing.Point(114, 243);
            this.lblEmployeeGender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(147, 40);
            this.lblEmployeeGender.TabIndex = 31;
            this.lblEmployeeGender.Text = "Gender:";
            // 
            // labelEmployeePassword
            // 
            this.labelEmployeePassword.AutoSize = true;
            this.labelEmployeePassword.Location = new System.Drawing.Point(78, 632);
            this.labelEmployeePassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeePassword.Name = "labelEmployeePassword";
            this.labelEmployeePassword.Size = new System.Drawing.Size(185, 40);
            this.labelEmployeePassword.TabIndex = 29;
            this.labelEmployeePassword.Text = "Password:";
            // 
            // tbxEmployeePassword
            // 
            this.tbxEmployeePassword.Location = new System.Drawing.Point(304, 627);
            this.tbxEmployeePassword.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxEmployeePassword.Name = "tbxEmployeePassword";
            this.tbxEmployeePassword.Size = new System.Drawing.Size(440, 48);
            this.tbxEmployeePassword.TabIndex = 28;
            // 
            // labelEmployeeBirthdate
            // 
            this.labelEmployeeBirthdate.AutoSize = true;
            this.labelEmployeeBirthdate.Location = new System.Drawing.Point(46, 708);
            this.labelEmployeeBirthdate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeBirthdate.Name = "labelEmployeeBirthdate";
            this.labelEmployeeBirthdate.Size = new System.Drawing.Size(459, 40);
            this.labelEmployeeBirthdate.TabIndex = 25;
            this.labelEmployeeBirthdate.Text = "Date of birth (mm/dd/yyyy) :";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(304, 552);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(440, 48);
            this.tbxEmail.TabIndex = 20;
            // 
            // labelEmployeeEmail
            // 
            this.labelEmployeeEmail.AutoSize = true;
            this.labelEmployeeEmail.Location = new System.Drawing.Point(136, 561);
            this.labelEmployeeEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeEmail.Name = "labelEmployeeEmail";
            this.labelEmployeeEmail.Size = new System.Drawing.Size(117, 40);
            this.labelEmployeeEmail.TabIndex = 19;
            this.labelEmployeeEmail.Text = "Email:";
            // 
            // labelEmployeePhone
            // 
            this.labelEmployeePhone.AutoSize = true;
            this.labelEmployeePhone.Location = new System.Drawing.Point(12, 405);
            this.labelEmployeePhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeePhone.Name = "labelEmployeePhone";
            this.labelEmployeePhone.Size = new System.Drawing.Size(263, 40);
            this.labelEmployeePhone.TabIndex = 18;
            this.labelEmployeePhone.Text = "Phone number:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(304, 400);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(440, 48);
            this.tbxPhone.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Role:";
            // 
            // cbxNewEmpRole
            // 
            this.cbxNewEmpRole.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbxNewEmpRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewEmpRole.FormattingEnabled = true;
            this.cbxNewEmpRole.Location = new System.Drawing.Point(304, 315);
            this.cbxNewEmpRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNewEmpRole.Name = "cbxNewEmpRole";
            this.cbxNewEmpRole.Size = new System.Drawing.Size(440, 48);
            this.cbxNewEmpRole.TabIndex = 9;
            // 
            // tbxNewEmpLastName
            // 
            this.tbxNewEmpLastName.Location = new System.Drawing.Point(304, 152);
            this.tbxNewEmpLastName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxNewEmpLastName.Name = "tbxNewEmpLastName";
            this.tbxNewEmpLastName.Size = new System.Drawing.Size(440, 48);
            this.tbxNewEmpLastName.TabIndex = 6;
            // 
            // tbxNewEmpFirstName
            // 
            this.tbxNewEmpFirstName.Location = new System.Drawing.Point(304, 75);
            this.tbxNewEmpFirstName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxNewEmpFirstName.Name = "tbxNewEmpFirstName";
            this.tbxNewEmpFirstName.Size = new System.Drawing.Size(440, 48);
            this.tbxNewEmpFirstName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1412, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 73);
            this.label1.TabIndex = 11;
            this.label1.Text = "ZooBazaar";
            // 
            // FormHRAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::ZooBazaarDesktopApp.Properties.Resources.zooimg5;
            this.ClientSize = new System.Drawing.Size(2884, 1581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlHRAdministration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHRAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHRAdministration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlHRAdministration.ResumeLayout(false);
            this.tabPageAllEmployees.ResumeLayout(false);
            this.tabPageAllEmployees.PerformLayout();
            this.tabPageEmployeeHistory.ResumeLayout(false);
            this.tabPageEmployeeHistory.PerformLayout();
            this.groupBoxSearchEmployeeHistoryTab.ResumeLayout(false);
            this.groupBoxSearchEmployeeHistoryTab.PerformLayout();
            this.tabCreateEmployee.ResumeLayout(false);
            this.tabCreateEmployee.PerformLayout();
            this.groupBoxEmergencyContact.ResumeLayout(false);
            this.groupBoxEmergencyContact.PerformLayout();
            this.groupBoxContractDetailsPopup.ResumeLayout(false);
            this.groupBoxContractDetailsPopup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContractLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyHours)).EndInit();
            this.groupBoxEmployeeDetailsPopup.ResumeLayout(false);
            this.groupBoxEmployeeDetailsPopup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHRAdministration;
        private System.Windows.Forms.TabPage tabPageAllEmployees;
        private System.Windows.Forms.TabPage tabPageEmployeeHistory;
        private System.Windows.Forms.ListView lvwEmployees;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colContractType;
        private System.Windows.Forms.Label labelAllAnimals;
        private System.Windows.Forms.Label labelSortbyEmployee;
        private System.Windows.Forms.RadioButton rbtnSortAlphabeticalDesc;
        private System.Windows.Forms.RadioButton rbtnSortAlphabeticalAsc;
        private System.Windows.Forms.Button btnSearchHistory;
        private System.Windows.Forms.RadioButton rbtnSortByContract;
        private System.Windows.Forms.RadioButton rbtnSortByRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewEmployeeHistoryTab;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnRole;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnContractType;
        private System.Windows.Forms.ColumnHeader columnContractStatus;
        private System.Windows.Forms.TabPage tabCreateEmployee;
        private System.Windows.Forms.Button btnCancelEmployeeCreation;
        private System.Windows.Forms.GroupBox groupBoxContractDetailsPopup;
        private System.Windows.Forms.CheckBox cbNotMentioned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dtmContractStartDate;
        private System.Windows.Forms.Label labelContractStartDate;
        private System.Windows.Forms.Label labelContractMonths;
        private System.Windows.Forms.NumericUpDown nudContractLenght;
        private System.Windows.Forms.CheckBox cbxFixedTermContract;
        private System.Windows.Forms.NumericUpDown nudWeeklyHours;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmEmployeeCreation;
        private System.Windows.Forms.GroupBox groupBoxEmployeeDetailsPopup;
        private System.Windows.Forms.RadioButton rbAddFemale;
        private System.Windows.Forms.RadioButton rbAddMale;
        private System.Windows.Forms.MaskedTextBox maskedtbxDoBEmployee;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.Label labelEmployeePassword;
        private System.Windows.Forms.TextBox tbxEmployeePassword;
        private System.Windows.Forms.Label labelEmployeeBirthdate;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label labelEmployeeEmail;
        private System.Windows.Forms.Label labelEmployeePhone;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNewEmpRole;
        private System.Windows.Forms.TextBox tbxNewEmpLastName;
        private System.Windows.Forms.TextBox tbxNewEmpFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxSearchEmployeeHistoryTab;
        private System.Windows.Forms.Button btnDisplayEmployeeHistoryTab;
        private System.Windows.Forms.Label labelContractTypeEmployeeHistoryTab;
        private System.Windows.Forms.RadioButton rbFullTimeEmployeeHistoryTab;
        private System.Windows.Forms.RadioButton rbPartTimeEmployeeHistoryTab;
        private System.Windows.Forms.ComboBox cbRoleEmployeeHistory;
        private System.Windows.Forms.Button btnSearchEmployeeHistoryTab;
        private System.Windows.Forms.Button btnClearFieldsEmployeeHistoryTab;
        private System.Windows.Forms.Label labelRoleEmployeeTab;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelLastNameEmployeeHistory;
        private System.Windows.Forms.Label labelFNEmployeeHistory;
        private System.Windows.Forms.GroupBox groupBoxEmergencyContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbxNewEmpAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelNote;
        private ucSearchFeatureEmployees ucSearchFeatureEmployees1;
        private System.Windows.Forms.Button btnEditEmployeeAdditional;
        private System.Windows.Forms.Button btnEditEmployeeContract;
        private System.Windows.Forms.Button btnDisplayEmployeeInformation;
        private System.Windows.Forms.Panel panelAdministrateEmployees;
    }
}