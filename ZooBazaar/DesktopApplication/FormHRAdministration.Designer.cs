namespace DesktopApplication
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
            this.btnManageContract = new System.Windows.Forms.Button();
            this.btnEditEmployeeDeta = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lvwEmployees = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colFirstName = new System.Windows.Forms.ColumnHeader();
            this.colLastName = new System.Windows.Forms.ColumnHeader();
            this.colRole = new System.Windows.Forms.ColumnHeader();
            this.colContractType = new System.Windows.Forms.ColumnHeader();
            this.groupBoxSearchAnimal = new System.Windows.Forms.GroupBox();
            this.btnShowAllEmployees = new System.Windows.Forms.Button();
            this.labelEmployeeContractType = new System.Windows.Forms.Label();
            this.rbtnFullTimeEmployee = new System.Windows.Forms.RadioButton();
            this.rbtnPartTimeEmployee = new System.Windows.Forms.RadioButton();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.labelEmployeeRole = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.labelEmployeeLastName = new System.Windows.Forms.Label();
            this.labelEmployeeFirstName = new System.Windows.Forms.Label();
            this.tabPageEmployeeHistory = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnLastName = new System.Windows.Forms.ColumnHeader();
            this.columnRole = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.columnPhone = new System.Windows.Forms.ColumnHeader();
            this.columnContractType = new System.Windows.Forms.ColumnHeader();
            this.columnContractStatus = new System.Windows.Forms.ColumnHeader();
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.rbtnSortByContract = new System.Windows.Forms.RadioButton();
            this.rbtnSortByRole = new System.Windows.Forms.RadioButton();
            this.rbtnSortAlphabeticalDesc = new System.Windows.Forms.RadioButton();
            this.rbtnSortAlphabeticalAsc = new System.Windows.Forms.RadioButton();
            this.labelSortbyEmployee = new System.Windows.Forms.Label();
            this.labelAllAnimals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlHRAdministration.SuspendLayout();
            this.tabPageAllEmployees.SuspendLayout();
            this.groupBoxSearchAnimal.SuspendLayout();
            this.tabPageEmployeeHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHRAdministration
            // 
            this.tabControlHRAdministration.Controls.Add(this.tabPageAllEmployees);
            this.tabControlHRAdministration.Controls.Add(this.tabPageEmployeeHistory);
            this.tabControlHRAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlHRAdministration.Location = new System.Drawing.Point(102, 94);
            this.tabControlHRAdministration.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlHRAdministration.Name = "tabControlHRAdministration";
            this.tabControlHRAdministration.Padding = new System.Drawing.Point(70, 9);
            this.tabControlHRAdministration.SelectedIndex = 0;
            this.tabControlHRAdministration.Size = new System.Drawing.Size(2674, 1418);
            this.tabControlHRAdministration.TabIndex = 9;
            // 
            // tabPageAllEmployees
            // 
            this.tabPageAllEmployees.Controls.Add(this.btnManageContract);
            this.tabPageAllEmployees.Controls.Add(this.btnEditEmployeeDeta);
            this.tabPageAllEmployees.Controls.Add(this.btnAddEmployee);
            this.tabPageAllEmployees.Controls.Add(this.lvwEmployees);
            this.tabPageAllEmployees.Controls.Add(this.groupBoxSearchAnimal);
            this.tabPageAllEmployees.Location = new System.Drawing.Point(4, 46);
            this.tabPageAllEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAllEmployees.Name = "tabPageAllEmployees";
            this.tabPageAllEmployees.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAllEmployees.Size = new System.Drawing.Size(2666, 1368);
            this.tabPageAllEmployees.TabIndex = 0;
            this.tabPageAllEmployees.Text = "Search employees";
            this.tabPageAllEmployees.UseVisualStyleBackColor = true;
            // 
            // btnManageContract
            // 
            this.btnManageContract.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnManageContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageContract.Location = new System.Drawing.Point(2132, 1216);
            this.btnManageContract.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageContract.Name = "btnManageContract";
            this.btnManageContract.Size = new System.Drawing.Size(471, 82);
            this.btnManageContract.TabIndex = 18;
            this.btnManageContract.Text = "Manage contract";
            this.btnManageContract.UseVisualStyleBackColor = false;
            this.btnManageContract.Click += new System.EventHandler(this.btnManageContract_Click);
            // 
            // btnEditEmployeeDeta
            // 
            this.btnEditEmployeeDeta.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditEmployeeDeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditEmployeeDeta.Location = new System.Drawing.Point(1536, 1216);
            this.btnEditEmployeeDeta.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployeeDeta.Name = "btnEditEmployeeDeta";
            this.btnEditEmployeeDeta.Size = new System.Drawing.Size(471, 82);
            this.btnEditEmployeeDeta.TabIndex = 17;
            this.btnEditEmployeeDeta.Text = "Manage employee";
            this.btnEditEmployeeDeta.UseVisualStyleBackColor = false;
            this.btnEditEmployeeDeta.Click += new System.EventHandler(this.btnEditEmployeeDeta_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.Location = new System.Drawing.Point(927, 1216);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(471, 82);
            this.btnAddEmployee.TabIndex = 15;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lvwEmployees
            // 
            this.lvwEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colRole,
            this.colContractType});
            this.lvwEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwEmployees.FullRowSelect = true;
            this.lvwEmployees.Location = new System.Drawing.Point(927, 52);
            this.lvwEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.lvwEmployees.MultiSelect = false;
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(1674, 1118);
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
            // groupBoxSearchAnimal
            // 
            this.groupBoxSearchAnimal.Controls.Add(this.btnShowAllEmployees);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeContractType);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnFullTimeEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnPartTimeEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxRole);
            this.groupBoxSearchAnimal.Controls.Add(this.btnSearchEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.btnClearAll);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeRole);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxLastName);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxFirstName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeLastName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeFirstName);
            this.groupBoxSearchAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(33, 38);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(825, 603);
            this.groupBoxSearchAnimal.TabIndex = 13;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
            // 
            // btnShowAllEmployees
            // 
            this.btnShowAllEmployees.AutoSize = true;
            this.btnShowAllEmployees.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnShowAllEmployees.Location = new System.Drawing.Point(205, 460);
            this.btnShowAllEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllEmployees.Name = "btnShowAllEmployees";
            this.btnShowAllEmployees.Size = new System.Drawing.Size(532, 70);
            this.btnShowAllEmployees.TabIndex = 24;
            this.btnShowAllEmployees.Text = "Display all employees";
            this.btnShowAllEmployees.UseVisualStyleBackColor = false;
            this.btnShowAllEmployees.Click += new System.EventHandler(this.btnShowAllEmployees_Click);
            // 
            // labelEmployeeContractType
            // 
            this.labelEmployeeContractType.AutoSize = true;
            this.labelEmployeeContractType.Location = new System.Drawing.Point(40, 206);
            this.labelEmployeeContractType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeContractType.Name = "labelEmployeeContractType";
            this.labelEmployeeContractType.Size = new System.Drawing.Size(147, 26);
            this.labelEmployeeContractType.TabIndex = 23;
            this.labelEmployeeContractType.Text = "Contract type:";
            // 
            // rbtnFullTimeEmployee
            // 
            this.rbtnFullTimeEmployee.AutoSize = true;
            this.rbtnFullTimeEmployee.Location = new System.Drawing.Point(290, 201);
            this.rbtnFullTimeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFullTimeEmployee.Name = "rbtnFullTimeEmployee";
            this.rbtnFullTimeEmployee.Size = new System.Drawing.Size(114, 30);
            this.rbtnFullTimeEmployee.TabIndex = 22;
            this.rbtnFullTimeEmployee.TabStop = true;
            this.rbtnFullTimeEmployee.Text = "Full-time";
            this.rbtnFullTimeEmployee.UseVisualStyleBackColor = true;
            // 
            // rbtnPartTimeEmployee
            // 
            this.rbtnPartTimeEmployee.AutoSize = true;
            this.rbtnPartTimeEmployee.Location = new System.Drawing.Point(590, 201);
            this.rbtnPartTimeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPartTimeEmployee.Name = "rbtnPartTimeEmployee";
            this.rbtnPartTimeEmployee.Size = new System.Drawing.Size(119, 30);
            this.rbtnPartTimeEmployee.TabIndex = 21;
            this.rbtnPartTimeEmployee.TabStop = true;
            this.rbtnPartTimeEmployee.Text = "Part-time";
            this.rbtnPartTimeEmployee.UseVisualStyleBackColor = true;
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(290, 270);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(476, 33);
            this.cbxRole.TabIndex = 9;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.AutoSize = true;
            this.btnSearchEmployee.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearchEmployee.Location = new System.Drawing.Point(175, 362);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(279, 70);
            this.btnSearchEmployee.TabIndex = 14;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClearAll.Location = new System.Drawing.Point(487, 362);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(279, 70);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear fields";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // labelEmployeeRole
            // 
            this.labelEmployeeRole.AutoSize = true;
            this.labelEmployeeRole.Location = new System.Drawing.Point(40, 274);
            this.labelEmployeeRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeRole.Name = "labelEmployeeRole";
            this.labelEmployeeRole.Size = new System.Drawing.Size(63, 26);
            this.labelEmployeeRole.TabIndex = 16;
            this.labelEmployeeRole.Text = "Role:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(290, 129);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(476, 32);
            this.tbxLastName.TabIndex = 6;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(290, 57);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(476, 32);
            this.tbxFirstName.TabIndex = 5;
            // 
            // labelEmployeeLastName
            // 
            this.labelEmployeeLastName.AutoSize = true;
            this.labelEmployeeLastName.Location = new System.Drawing.Point(40, 134);
            this.labelEmployeeLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeLastName.Name = "labelEmployeeLastName";
            this.labelEmployeeLastName.Size = new System.Drawing.Size(120, 26);
            this.labelEmployeeLastName.TabIndex = 1;
            this.labelEmployeeLastName.Text = "Last name:";
            // 
            // labelEmployeeFirstName
            // 
            this.labelEmployeeFirstName.AutoSize = true;
            this.labelEmployeeFirstName.Location = new System.Drawing.Point(39, 63);
            this.labelEmployeeFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeFirstName.Name = "labelEmployeeFirstName";
            this.labelEmployeeFirstName.Size = new System.Drawing.Size(121, 26);
            this.labelEmployeeFirstName.TabIndex = 0;
            this.labelEmployeeFirstName.Text = "First name:";
            // 
            // tabPageEmployeeHistory
            // 
            this.tabPageEmployeeHistory.Controls.Add(this.listView1);
            this.tabPageEmployeeHistory.Controls.Add(this.btnSearchHistory);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortByContract);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortByRole);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortAlphabeticalDesc);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortAlphabeticalAsc);
            this.tabPageEmployeeHistory.Controls.Add(this.labelSortbyEmployee);
            this.tabPageEmployeeHistory.Controls.Add(this.labelAllAnimals);
            this.tabPageEmployeeHistory.Location = new System.Drawing.Point(4, 46);
            this.tabPageEmployeeHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEmployeeHistory.Name = "tabPageEmployeeHistory";
            this.tabPageEmployeeHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEmployeeHistory.Size = new System.Drawing.Size(2666, 1368);
            this.tabPageEmployeeHistory.TabIndex = 1;
            this.tabPageEmployeeHistory.Text = "Employee history";
            this.tabPageEmployeeHistory.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnFirstName,
            this.columnLastName,
            this.columnRole,
            this.columnEmail,
            this.columnPhone,
            this.columnContractType,
            this.columnContractStatus});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(18, 102);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(2605, 1206);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.btnSearchHistory.Margin = new System.Windows.Forms.Padding(4);
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
            this.rbtnSortByContract.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSortByContract.Name = "rbtnSortByContract";
            this.rbtnSortByContract.Size = new System.Drawing.Size(159, 30);
            this.rbtnSortByContract.TabIndex = 41;
            this.rbtnSortByContract.TabStop = true;
            this.rbtnSortByContract.Text = "Contract type";
            this.rbtnSortByContract.UseVisualStyleBackColor = true;
            // 
            // rbtnSortByRole
            // 
            this.rbtnSortByRole.AutoSize = true;
            this.rbtnSortByRole.Location = new System.Drawing.Point(2050, 27);
            this.rbtnSortByRole.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSortByRole.Name = "rbtnSortByRole";
            this.rbtnSortByRole.Size = new System.Drawing.Size(75, 30);
            this.rbtnSortByRole.TabIndex = 40;
            this.rbtnSortByRole.TabStop = true;
            this.rbtnSortByRole.Text = "Role";
            this.rbtnSortByRole.UseVisualStyleBackColor = true;
            // 
            // rbtnSortAlphabeticalDesc
            // 
            this.rbtnSortAlphabeticalDesc.AutoSize = true;
            this.rbtnSortAlphabeticalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnSortAlphabeticalDesc.Location = new System.Drawing.Point(1779, 27);
            this.rbtnSortAlphabeticalDesc.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSortAlphabeticalDesc.Name = "rbtnSortAlphabeticalDesc";
            this.rbtnSortAlphabeticalDesc.Size = new System.Drawing.Size(166, 30);
            this.rbtnSortAlphabeticalDesc.TabIndex = 39;
            this.rbtnSortAlphabeticalDesc.TabStop = true;
            this.rbtnSortAlphabeticalDesc.Text = "Alphabetical ↓";
            this.rbtnSortAlphabeticalDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnSortAlphabeticalAsc
            // 
            this.rbtnSortAlphabeticalAsc.AutoSize = true;
            this.rbtnSortAlphabeticalAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnSortAlphabeticalAsc.Location = new System.Drawing.Point(1506, 27);
            this.rbtnSortAlphabeticalAsc.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSortAlphabeticalAsc.Name = "rbtnSortAlphabeticalAsc";
            this.rbtnSortAlphabeticalAsc.Size = new System.Drawing.Size(166, 30);
            this.rbtnSortAlphabeticalAsc.TabIndex = 38;
            this.rbtnSortAlphabeticalAsc.TabStop = true;
            this.rbtnSortAlphabeticalAsc.Text = "Alphabetical ↑";
            this.rbtnSortAlphabeticalAsc.UseVisualStyleBackColor = true;
            // 
            // labelSortbyEmployee
            // 
            this.labelSortbyEmployee.AutoSize = true;
            this.labelSortbyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSortbyEmployee.Location = new System.Drawing.Point(1353, 30);
            this.labelSortbyEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortbyEmployee.Name = "labelSortbyEmployee";
            this.labelSortbyEmployee.Size = new System.Drawing.Size(87, 26);
            this.labelSortbyEmployee.TabIndex = 37;
            this.labelSortbyEmployee.Text = "Sort by:";
            // 
            // labelAllAnimals
            // 
            this.labelAllAnimals.AutoSize = true;
            this.labelAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllAnimals.Location = new System.Drawing.Point(9, 22);
            this.labelAllAnimals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllAnimals.Name = "labelAllAnimals";
            this.labelAllAnimals.Size = new System.Drawing.Size(195, 31);
            this.labelAllAnimals.TabIndex = 36;
            this.labelAllAnimals.Text = "All employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1412, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "ZooBazaar";
            // 
            // FormHRAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DesktopApplication.Properties.Resources.zooimg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlHRAdministration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHRAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHRAdministration";
            this.tabControlHRAdministration.ResumeLayout(false);
            this.tabPageAllEmployees.ResumeLayout(false);
            this.groupBoxSearchAnimal.ResumeLayout(false);
            this.groupBoxSearchAnimal.PerformLayout();
            this.tabPageEmployeeHistory.ResumeLayout(false);
            this.tabPageEmployeeHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHRAdministration;
        private System.Windows.Forms.TabPage tabPageAllEmployees;
        private System.Windows.Forms.TabPage tabPageEmployeeHistory;
        private System.Windows.Forms.Button btnEditEmployeeDeta;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListView lvwEmployees;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colContractType;
        private System.Windows.Forms.GroupBox groupBoxSearchAnimal;
        private System.Windows.Forms.Label labelEmployeeContractType;
        private System.Windows.Forms.RadioButton rbtnFullTimeEmployee;
        private System.Windows.Forms.RadioButton rbtnPartTimeEmployee;
        private System.Windows.Forms.Label labelEmployeeRole;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label labelEmployeeLastName;
        private System.Windows.Forms.Label labelEmployeeFirstName;
        private System.Windows.Forms.Label labelAllAnimals;
        private System.Windows.Forms.Label labelSortbyEmployee;
        private System.Windows.Forms.RadioButton rbtnSortAlphabeticalDesc;
        private System.Windows.Forms.RadioButton rbtnSortAlphabeticalAsc;
        private System.Windows.Forms.Button btnSearchHistory;
        private System.Windows.Forms.RadioButton rbtnSortByContract;
        private System.Windows.Forms.RadioButton rbtnSortByRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageContract;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnRole;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnContractType;
        private System.Windows.Forms.ColumnHeader columnContractStatus;
        private System.Windows.Forms.Button btnShowAllEmployees;
    }
}