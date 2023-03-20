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
            this.btnEditEmployeeDeta = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lvwEmployees = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContractType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxSearchAnimal = new System.Windows.Forms.GroupBox();
            this.labelEmployeeContractType = new System.Windows.Forms.Label();
            this.rbtnFullTimeEmployee = new System.Windows.Forms.RadioButton();
            this.rbtnPartTimeEmployee = new System.Windows.Forms.RadioButton();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.labelEmployeeRole = new System.Windows.Forms.Label();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.labelEmployeeLastName = new System.Windows.Forms.Label();
            this.labelEmployeeFirstName = new System.Windows.Forms.Label();
            this.tabPageEmployeeHistory = new System.Windows.Forms.TabPage();
            this.lvwEmployeeHistory = new System.Windows.Forms.ListView();
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.rbtnSortByContract = new System.Windows.Forms.RadioButton();
            this.rbtnSortByRole = new System.Windows.Forms.RadioButton();
            this.rbtnSortAlphabeticalDesc = new System.Windows.Forms.RadioButton();
            this.rbtnSortAlphabeticalAsc = new System.Windows.Forms.RadioButton();
            this.labelSortbyEmployee = new System.Windows.Forms.Label();
            this.labelAllAnimals = new System.Windows.Forms.Label();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
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
            this.tabControlHRAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlHRAdministration.Location = new System.Drawing.Point(12, 52);
            this.tabControlHRAdministration.Name = "tabControlHRAdministration";
            this.tabControlHRAdministration.Padding = new System.Drawing.Point(70, 9);
            this.tabControlHRAdministration.SelectedIndex = 0;
            this.tabControlHRAdministration.Size = new System.Drawing.Size(1431, 774);
            this.tabControlHRAdministration.TabIndex = 9;
            // 
            // tabPageAllEmployees
            // 
            this.tabPageAllEmployees.Controls.Add(this.btnEditEmployeeDeta);
            this.tabPageAllEmployees.Controls.Add(this.btnAddEmployee);
            this.tabPageAllEmployees.Controls.Add(this.lvwEmployees);
            this.tabPageAllEmployees.Controls.Add(this.groupBoxSearchAnimal);
            this.tabPageAllEmployees.Location = new System.Drawing.Point(4, 45);
            this.tabPageAllEmployees.Name = "tabPageAllEmployees";
            this.tabPageAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllEmployees.Size = new System.Drawing.Size(1423, 725);
            this.tabPageAllEmployees.TabIndex = 0;
            this.tabPageAllEmployees.Text = "Search employees";
            this.tabPageAllEmployees.UseVisualStyleBackColor = true;
            // 
            // btnEditEmployeeDeta
            // 
            this.btnEditEmployeeDeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEditEmployeeDeta.Location = new System.Drawing.Point(970, 671);
            this.btnEditEmployeeDeta.Name = "btnEditEmployeeDeta";
            this.btnEditEmployeeDeta.Size = new System.Drawing.Size(314, 40);
            this.btnEditEmployeeDeta.TabIndex = 17;
            this.btnEditEmployeeDeta.Text = "Manage employee";
            this.btnEditEmployeeDeta.UseVisualStyleBackColor = true;
            this.btnEditEmployeeDeta.Click += new System.EventHandler(this.btnEditEmployeeDeta_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddEmployee.Location = new System.Drawing.Point(633, 671);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(314, 40);
            this.btnAddEmployee.TabIndex = 15;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
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
            this.lvwEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lvwEmployees.FullRowSelect = true;
            this.lvwEmployees.HideSelection = false;
            this.lvwEmployees.Location = new System.Drawing.Point(472, 25);
            this.lvwEmployees.MultiSelect = false;
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(932, 640);
            this.lvwEmployees.TabIndex = 14;
            this.lvwEmployees.UseCompatibleStateImageBehavior = false;
            this.lvwEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 58;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First name";
            this.colFirstName.Width = 220;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last name";
            this.colLastName.Width = 220;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.Width = 216;
            // 
            // colContractType
            // 
            this.colContractType.Text = "Contract";
            this.colContractType.Width = 211;
            // 
            // groupBoxSearchAnimal
            // 
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeContractType);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnFullTimeEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnPartTimeEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxRole);
            this.groupBoxSearchAnimal.Controls.Add(this.btnClearAll);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeRole);
            this.groupBoxSearchAnimal.Controls.Add(this.btnSearchEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxLastName);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxFirstName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeLastName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeFirstName);
            this.groupBoxSearchAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(7, 14);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(449, 279);
            this.groupBoxSearchAnimal.TabIndex = 13;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
            // 
            // labelEmployeeContractType
            // 
            this.labelEmployeeContractType.AutoSize = true;
            this.labelEmployeeContractType.Location = new System.Drawing.Point(9, 132);
            this.labelEmployeeContractType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeContractType.Name = "labelEmployeeContractType";
            this.labelEmployeeContractType.Size = new System.Drawing.Size(124, 24);
            this.labelEmployeeContractType.TabIndex = 23;
            this.labelEmployeeContractType.Text = "Contract type:";
            // 
            // rbtnFullTimeEmployee
            // 
            this.rbtnFullTimeEmployee.AutoSize = true;
            this.rbtnFullTimeEmployee.Location = new System.Drawing.Point(162, 130);
            this.rbtnFullTimeEmployee.Name = "rbtnFullTimeEmployee";
            this.rbtnFullTimeEmployee.Size = new System.Drawing.Size(100, 28);
            this.rbtnFullTimeEmployee.TabIndex = 22;
            this.rbtnFullTimeEmployee.TabStop = true;
            this.rbtnFullTimeEmployee.Text = "Full-time";
            this.rbtnFullTimeEmployee.UseVisualStyleBackColor = true;
            // 
            // rbtnPartTimeEmployee
            // 
            this.rbtnPartTimeEmployee.AutoSize = true;
            this.rbtnPartTimeEmployee.Location = new System.Drawing.Point(331, 130);
            this.rbtnPartTimeEmployee.Name = "rbtnPartTimeEmployee";
            this.rbtnPartTimeEmployee.Size = new System.Drawing.Size(101, 28);
            this.rbtnPartTimeEmployee.TabIndex = 21;
            this.rbtnPartTimeEmployee.TabStop = true;
            this.rbtnPartTimeEmployee.Text = "Part-time";
            this.rbtnPartTimeEmployee.UseVisualStyleBackColor = true;
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(162, 164);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(270, 32);
            this.cbxRole.TabIndex = 9;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Location = new System.Drawing.Point(300, 215);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(132, 35);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // labelEmployeeRole
            // 
            this.labelEmployeeRole.AutoSize = true;
            this.labelEmployeeRole.Location = new System.Drawing.Point(9, 164);
            this.labelEmployeeRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeRole.Name = "labelEmployeeRole";
            this.labelEmployeeRole.Size = new System.Drawing.Size(54, 24);
            this.labelEmployeeRole.TabIndex = 16;
            this.labelEmployeeRole.Text = "Role:";
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.AutoSize = true;
            this.btnSearchEmployee.Location = new System.Drawing.Point(162, 215);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(132, 35);
            this.btnSearchEmployee.TabIndex = 14;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(162, 83);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(270, 29);
            this.tbxLastName.TabIndex = 6;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(162, 41);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(270, 29);
            this.tbxFirstName.TabIndex = 5;
            // 
            // labelEmployeeLastName
            // 
            this.labelEmployeeLastName.AutoSize = true;
            this.labelEmployeeLastName.Location = new System.Drawing.Point(10, 86);
            this.labelEmployeeLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeLastName.Name = "labelEmployeeLastName";
            this.labelEmployeeLastName.Size = new System.Drawing.Size(101, 24);
            this.labelEmployeeLastName.TabIndex = 1;
            this.labelEmployeeLastName.Text = "Last name:";
            // 
            // labelEmployeeFirstName
            // 
            this.labelEmployeeFirstName.AutoSize = true;
            this.labelEmployeeFirstName.Location = new System.Drawing.Point(10, 44);
            this.labelEmployeeFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeFirstName.Name = "labelEmployeeFirstName";
            this.labelEmployeeFirstName.Size = new System.Drawing.Size(103, 24);
            this.labelEmployeeFirstName.TabIndex = 0;
            this.labelEmployeeFirstName.Text = "First name:";
            // 
            // tabPageEmployeeHistory
            // 
            this.tabPageEmployeeHistory.Controls.Add(this.lvwEmployeeHistory);
            this.tabPageEmployeeHistory.Controls.Add(this.btnSearchHistory);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortByContract);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortByRole);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortAlphabeticalDesc);
            this.tabPageEmployeeHistory.Controls.Add(this.rbtnSortAlphabeticalAsc);
            this.tabPageEmployeeHistory.Controls.Add(this.labelSortbyEmployee);
            this.tabPageEmployeeHistory.Controls.Add(this.labelAllAnimals);
            this.tabPageEmployeeHistory.Location = new System.Drawing.Point(4, 45);
            this.tabPageEmployeeHistory.Name = "tabPageEmployeeHistory";
            this.tabPageEmployeeHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployeeHistory.Size = new System.Drawing.Size(1423, 725);
            this.tabPageEmployeeHistory.TabIndex = 1;
            this.tabPageEmployeeHistory.Text = "Employee history";
            this.tabPageEmployeeHistory.UseVisualStyleBackColor = true;
            // 
            // lvwEmployeeHistory
            // 
            this.lvwEmployeeHistory.HideSelection = false;
            this.lvwEmployeeHistory.Location = new System.Drawing.Point(12, 60);
            this.lvwEmployeeHistory.Name = "lvwEmployeeHistory";
            this.lvwEmployeeHistory.Size = new System.Drawing.Size(1393, 652);
            this.lvwEmployeeHistory.TabIndex = 43;
            this.lvwEmployeeHistory.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.Location = new System.Drawing.Point(1314, 12);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.Size = new System.Drawing.Size(91, 36);
            this.btnSearchHistory.TabIndex = 42;
            this.btnSearchHistory.Text = "Search";
            this.btnSearchHistory.UseVisualStyleBackColor = true;
            // 
            // rbtnSortByContract
            // 
            this.rbtnSortByContract.AutoSize = true;
            this.rbtnSortByContract.Location = new System.Drawing.Point(1155, 19);
            this.rbtnSortByContract.Name = "rbtnSortByContract";
            this.rbtnSortByContract.Size = new System.Drawing.Size(137, 28);
            this.rbtnSortByContract.TabIndex = 41;
            this.rbtnSortByContract.TabStop = true;
            this.rbtnSortByContract.Text = "Contract type";
            this.rbtnSortByContract.UseVisualStyleBackColor = true;
            // 
            // rbtnSortByRole
            // 
            this.rbtnSortByRole.AutoSize = true;
            this.rbtnSortByRole.Location = new System.Drawing.Point(1082, 16);
            this.rbtnSortByRole.Name = "rbtnSortByRole";
            this.rbtnSortByRole.Size = new System.Drawing.Size(67, 28);
            this.rbtnSortByRole.TabIndex = 40;
            this.rbtnSortByRole.TabStop = true;
            this.rbtnSortByRole.Text = "Role";
            this.rbtnSortByRole.UseVisualStyleBackColor = true;
            // 
            // rbtnSortAlphabeticalDesc
            // 
            this.rbtnSortAlphabeticalDesc.AutoSize = true;
            this.rbtnSortAlphabeticalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSortAlphabeticalDesc.Location = new System.Drawing.Point(930, 16);
            this.rbtnSortAlphabeticalDesc.Name = "rbtnSortAlphabeticalDesc";
            this.rbtnSortAlphabeticalDesc.Size = new System.Drawing.Size(146, 28);
            this.rbtnSortAlphabeticalDesc.TabIndex = 39;
            this.rbtnSortAlphabeticalDesc.TabStop = true;
            this.rbtnSortAlphabeticalDesc.Text = "Alphabetical ↓";
            this.rbtnSortAlphabeticalDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnSortAlphabeticalAsc
            // 
            this.rbtnSortAlphabeticalAsc.AutoSize = true;
            this.rbtnSortAlphabeticalAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSortAlphabeticalAsc.Location = new System.Drawing.Point(778, 16);
            this.rbtnSortAlphabeticalAsc.Name = "rbtnSortAlphabeticalAsc";
            this.rbtnSortAlphabeticalAsc.Size = new System.Drawing.Size(146, 28);
            this.rbtnSortAlphabeticalAsc.TabIndex = 38;
            this.rbtnSortAlphabeticalAsc.TabStop = true;
            this.rbtnSortAlphabeticalAsc.Text = "Alphabetical ↑";
            this.rbtnSortAlphabeticalAsc.UseVisualStyleBackColor = true;
            // 
            // labelSortbyEmployee
            // 
            this.labelSortbyEmployee.AutoSize = true;
            this.labelSortbyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortbyEmployee.Location = new System.Drawing.Point(699, 18);
            this.labelSortbyEmployee.Name = "labelSortbyEmployee";
            this.labelSortbyEmployee.Size = new System.Drawing.Size(73, 24);
            this.labelSortbyEmployee.TabIndex = 37;
            this.labelSortbyEmployee.Text = "Sort by:";
            // 
            // labelAllAnimals
            // 
            this.labelAllAnimals.AutoSize = true;
            this.labelAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllAnimals.Location = new System.Drawing.Point(6, 14);
            this.labelAllAnimals.Name = "labelAllAnimals";
            this.labelAllAnimals.Size = new System.Drawing.Size(195, 31);
            this.labelAllAnimals.TabIndex = 36;
            this.labelAllAnimals.Text = "All employees";
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(585, 9);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(184, 37);
            this.labelTitleZooBazaar.TabIndex = 10;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // FormHRAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1449, 830);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlHRAdministration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label labelTitleZooBazaar;
        private System.Windows.Forms.Label labelAllAnimals;
        private System.Windows.Forms.Label labelSortbyEmployee;
        private System.Windows.Forms.RadioButton rbtnSortAlphabeticalDesc;
        private System.Windows.Forms.RadioButton rbtnSortAlphabeticalAsc;
        private System.Windows.Forms.Button btnSearchHistory;
        private System.Windows.Forms.RadioButton rbtnSortByContract;
        private System.Windows.Forms.RadioButton rbtnSortByRole;
        private System.Windows.Forms.ListView lvwEmployeeHistory;
    }
}