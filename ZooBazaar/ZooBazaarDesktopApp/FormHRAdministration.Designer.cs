﻿namespace ZooBazaarDesktopApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditEmployeeDeta = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lvwEmployees = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContractType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxSearchAnimal = new System.Windows.Forms.GroupBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.labelEmployeeAddress = new System.Windows.Forms.Label();
            this.labelEmployeeBirthdate = new System.Windows.Forms.Label();
            this.dtmBirthdate = new System.Windows.Forms.DateTimePicker();
            this.labelEmployeeContractType = new System.Windows.Forms.Label();
            this.rbtnFullTimeEmployee = new System.Windows.Forms.RadioButton();
            this.rbtnPartTimeEmployee = new System.Windows.Forms.RadioButton();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.labelEmployeeEmail = new System.Windows.Forms.Label();
            this.labelEmployeePhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.labelEmployeeRole = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.labelEmployeeLastName = new System.Windows.Forms.Label();
            this.labelEmployeeFirstName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSearchAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(70, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1484, 802);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditEmployeeDeta);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Controls.Add(this.lvwEmployees);
            this.tabPage1.Controls.Add(this.groupBoxSearchAnimal);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1476, 757);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditEmployeeDeta
            // 
            this.btnEditEmployeeDeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEditEmployeeDeta.Location = new System.Drawing.Point(1010, 719);
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
            this.btnAddEmployee.Location = new System.Drawing.Point(673, 719);
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
            this.lvwEmployees.Location = new System.Drawing.Point(506, 14);
            this.lvwEmployees.MultiSelect = false;
            this.lvwEmployees.Name = "lvwEmployees";
            this.lvwEmployees.Size = new System.Drawing.Size(954, 699);
            this.lvwEmployees.TabIndex = 14;
            this.lvwEmployees.UseCompatibleStateImageBehavior = false;
            this.lvwEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 82;
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
            this.groupBoxSearchAnimal.Controls.Add(this.tbxAddress);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeAddress);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeBirthdate);
            this.groupBoxSearchAnimal.Controls.Add(this.dtmBirthdate);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeContractType);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnFullTimeEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnPartTimeEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxEmail);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeEmail);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeePhone);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxPhone);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeRole);
            this.groupBoxSearchAnimal.Controls.Add(this.btnClearAll);
            this.groupBoxSearchAnimal.Controls.Add(this.btnSearchEmployee);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxRole);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxLastName);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxFirstName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeLastName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEmployeeFirstName);
            this.groupBoxSearchAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(7, 14);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(478, 420);
            this.groupBoxSearchAnimal.TabIndex = 13;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(174, 211);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(270, 29);
            this.tbxAddress.TabIndex = 27;
            // 
            // labelEmployeeAddress
            // 
            this.labelEmployeeAddress.AutoSize = true;
            this.labelEmployeeAddress.Location = new System.Drawing.Point(22, 214);
            this.labelEmployeeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeAddress.Name = "labelEmployeeAddress";
            this.labelEmployeeAddress.Size = new System.Drawing.Size(85, 24);
            this.labelEmployeeAddress.TabIndex = 26;
            this.labelEmployeeAddress.Text = "Address:";
            // 
            // labelEmployeeBirthdate
            // 
            this.labelEmployeeBirthdate.AutoSize = true;
            this.labelEmployeeBirthdate.Location = new System.Drawing.Point(21, 328);
            this.labelEmployeeBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeBirthdate.Name = "labelEmployeeBirthdate";
            this.labelEmployeeBirthdate.Size = new System.Drawing.Size(88, 24);
            this.labelEmployeeBirthdate.TabIndex = 25;
            this.labelEmployeeBirthdate.Text = "Birthdate:";
            // 
            // dtmBirthdate
            // 
            this.dtmBirthdate.CustomFormat = "ddMMMMyyyy";
            this.dtmBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmBirthdate.Location = new System.Drawing.Point(174, 324);
            this.dtmBirthdate.Name = "dtmBirthdate";
            this.dtmBirthdate.Size = new System.Drawing.Size(270, 29);
            this.dtmBirthdate.TabIndex = 24;
            // 
            // labelEmployeeContractType
            // 
            this.labelEmployeeContractType.AutoSize = true;
            this.labelEmployeeContractType.Location = new System.Drawing.Point(21, 250);
            this.labelEmployeeContractType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeContractType.Name = "labelEmployeeContractType";
            this.labelEmployeeContractType.Size = new System.Drawing.Size(124, 24);
            this.labelEmployeeContractType.TabIndex = 23;
            this.labelEmployeeContractType.Text = "Contract type:";
            // 
            // rbtnFullTimeEmployee
            // 
            this.rbtnFullTimeEmployee.AutoSize = true;
            this.rbtnFullTimeEmployee.Location = new System.Drawing.Point(174, 248);
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
            this.rbtnPartTimeEmployee.Location = new System.Drawing.Point(343, 248);
            this.rbtnPartTimeEmployee.Name = "rbtnPartTimeEmployee";
            this.rbtnPartTimeEmployee.Size = new System.Drawing.Size(101, 28);
            this.rbtnPartTimeEmployee.TabIndex = 21;
            this.rbtnPartTimeEmployee.TabStop = true;
            this.rbtnPartTimeEmployee.Text = "Part-time";
            this.rbtnPartTimeEmployee.UseVisualStyleBackColor = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(174, 167);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(270, 29);
            this.tbxEmail.TabIndex = 20;
            // 
            // labelEmployeeEmail
            // 
            this.labelEmployeeEmail.AutoSize = true;
            this.labelEmployeeEmail.Location = new System.Drawing.Point(22, 170);
            this.labelEmployeeEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeEmail.Name = "labelEmployeeEmail";
            this.labelEmployeeEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEmployeeEmail.TabIndex = 19;
            this.labelEmployeeEmail.Text = "Email:";
            // 
            // labelEmployeePhone
            // 
            this.labelEmployeePhone.AutoSize = true;
            this.labelEmployeePhone.Location = new System.Drawing.Point(21, 129);
            this.labelEmployeePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeePhone.Name = "labelEmployeePhone";
            this.labelEmployeePhone.Size = new System.Drawing.Size(142, 24);
            this.labelEmployeePhone.TabIndex = 18;
            this.labelEmployeePhone.Text = "Phone number:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(174, 126);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(270, 29);
            this.tbxPhone.TabIndex = 17;
            // 
            // labelEmployeeRole
            // 
            this.labelEmployeeRole.AutoSize = true;
            this.labelEmployeeRole.Location = new System.Drawing.Point(21, 282);
            this.labelEmployeeRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeRole.Name = "labelEmployeeRole";
            this.labelEmployeeRole.Size = new System.Drawing.Size(54, 24);
            this.labelEmployeeRole.TabIndex = 16;
            this.labelEmployeeRole.Text = "Role:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Location = new System.Drawing.Point(312, 369);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(132, 35);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.AutoSize = true;
            this.btnSearchEmployee.Location = new System.Drawing.Point(174, 369);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(132, 35);
            this.btnSearchEmployee.TabIndex = 14;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(174, 282);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(270, 32);
            this.cbxRole.TabIndex = 9;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(174, 83);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(270, 29);
            this.tbxLastName.TabIndex = 6;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(174, 41);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(270, 29);
            this.tbxFirstName.TabIndex = 5;
            // 
            // labelEmployeeLastName
            // 
            this.labelEmployeeLastName.AutoSize = true;
            this.labelEmployeeLastName.Location = new System.Drawing.Point(22, 86);
            this.labelEmployeeLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeLastName.Name = "labelEmployeeLastName";
            this.labelEmployeeLastName.Size = new System.Drawing.Size(101, 24);
            this.labelEmployeeLastName.TabIndex = 1;
            this.labelEmployeeLastName.Text = "Last name:";
            // 
            // labelEmployeeFirstName
            // 
            this.labelEmployeeFirstName.AutoSize = true;
            this.labelEmployeeFirstName.Location = new System.Drawing.Point(22, 44);
            this.labelEmployeeFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeFirstName.Name = "labelEmployeeFirstName";
            this.labelEmployeeFirstName.Size = new System.Drawing.Size(103, 24);
            this.labelEmployeeFirstName.TabIndex = 0;
            this.labelEmployeeFirstName.Text = "First name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1476, 757);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee history";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(580, 9);
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
            this.ClientSize = new System.Drawing.Size(1508, 866);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormHRAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHRAdministration";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxSearchAnimal.ResumeLayout(false);
            this.groupBoxSearchAnimal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEditEmployeeDeta;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListView lvwEmployees;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colContractType;
        private System.Windows.Forms.GroupBox groupBoxSearchAnimal;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label labelEmployeeAddress;
        private System.Windows.Forms.Label labelEmployeeBirthdate;
        private System.Windows.Forms.DateTimePicker dtmBirthdate;
        private System.Windows.Forms.Label labelEmployeeContractType;
        private System.Windows.Forms.RadioButton rbtnFullTimeEmployee;
        private System.Windows.Forms.RadioButton rbtnPartTimeEmployee;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label labelEmployeeEmail;
        private System.Windows.Forms.Label labelEmployeePhone;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label labelEmployeeRole;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label labelEmployeeLastName;
        private System.Windows.Forms.Label labelEmployeeFirstName;
        private System.Windows.Forms.Label labelTitleZooBazaar;
    }
}