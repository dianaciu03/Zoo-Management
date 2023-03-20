namespace ZooBazaarDesktopApp
{
    partial class FormAnimalAdministration
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
            this.tabControlAnimals = new System.Windows.Forms.TabControl();
            this.tabSearchAnimals = new System.Windows.Forms.TabPage();
            this.lvwAnimals = new System.Windows.Forms.ListView();
            this.colAnimalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAnimalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContinent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnclosure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvailability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.btnEditAnimal = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.groupBoxSearchAnimal = new System.Windows.Forms.GroupBox();
            this.btnDisplayAllAnimals = new System.Windows.Forms.Button();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.cbTransferred = new System.Windows.Forms.CheckBox();
            this.cbAvailable = new System.Windows.Forms.CheckBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.labelGenderAddAnimal = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.cbxEndangerment = new System.Windows.Forms.ComboBox();
            this.cbxOrigin = new System.Windows.Forms.ComboBox();
            this.labelEndangerment = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tbxSpecies = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabAnimalHistory = new System.Windows.Forms.TabPage();
            this.lvwAnimalHistory = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSpecies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContinent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEnclosure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndangerment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAvailability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDisplayHistory = new System.Windows.Forms.Button();
            this.rbtnAge = new System.Windows.Forms.RadioButton();
            this.rbtnContinent = new System.Windows.Forms.RadioButton();
            this.rbtnSpecies = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.labelAllAnimals = new System.Windows.Forms.Label();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
            this.btnTransferAnimal = new System.Windows.Forms.Button();
            this.tabControlAnimals.SuspendLayout();
            this.tabSearchAnimals.SuspendLayout();
            this.groupBoxSearchAnimal.SuspendLayout();
            this.tabAnimalHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAnimals
            // 
            this.tabControlAnimals.Controls.Add(this.tabSearchAnimals);
            this.tabControlAnimals.Controls.Add(this.tabAnimalHistory);
            this.tabControlAnimals.Location = new System.Drawing.Point(63, 65);
            this.tabControlAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlAnimals.Name = "tabControlAnimals";
            this.tabControlAnimals.Padding = new System.Drawing.Point(70, 9);
            this.tabControlAnimals.SelectedIndex = 0;
            this.tabControlAnimals.Size = new System.Drawing.Size(1801, 947);
            this.tabControlAnimals.TabIndex = 0;
            // 
            // tabSearchAnimals
            // 
            this.tabSearchAnimals.Controls.Add(this.btnTransferAnimal);
            this.tabSearchAnimals.Controls.Add(this.lvwAnimals);
            this.tabSearchAnimals.Controls.Add(this.btnAddRelationship);
            this.tabSearchAnimals.Controls.Add(this.btnEditAnimal);
            this.tabSearchAnimals.Controls.Add(this.btnAddAnimal);
            this.tabSearchAnimals.Controls.Add(this.groupBoxSearchAnimal);
            this.tabSearchAnimals.Location = new System.Drawing.Point(4, 46);
            this.tabSearchAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearchAnimals.Name = "tabSearchAnimals";
            this.tabSearchAnimals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearchAnimals.Size = new System.Drawing.Size(1793, 897);
            this.tabSearchAnimals.TabIndex = 0;
            this.tabSearchAnimals.Text = "Search animals";
            this.tabSearchAnimals.UseVisualStyleBackColor = true;
            // 
            // lvwAnimals
            // 
            this.lvwAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAnimalID,
            this.colAnimalName,
            this.colSpecies,
            this.colGender,
            this.colContinent,
            this.colEnclosure,
            this.colAvailability});
            this.lvwAnimals.HideSelection = false;
            this.lvwAnimals.Location = new System.Drawing.Point(583, 30);
            this.lvwAnimals.Name = "lvwAnimals";
            this.lvwAnimals.Size = new System.Drawing.Size(1172, 763);
            this.lvwAnimals.TabIndex = 7;
            this.lvwAnimals.UseCompatibleStateImageBehavior = false;
            this.lvwAnimals.View = System.Windows.Forms.View.Details;
            // 
            // colAnimalID
            // 
            this.colAnimalID.Text = "ID";
            this.colAnimalID.Width = 55;
            // 
            // colAnimalName
            // 
            this.colAnimalName.Text = "Name";
            this.colAnimalName.Width = 181;
            // 
            // colSpecies
            // 
            this.colSpecies.Text = "Species";
            this.colSpecies.Width = 187;
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            this.colGender.Width = 199;
            // 
            // colContinent
            // 
            this.colContinent.Text = "Continent";
            this.colContinent.Width = 221;
            // 
            // colEnclosure
            // 
            this.colEnclosure.Text = "Enclosure";
            this.colEnclosure.Width = 139;
            // 
            // colAvailability
            // 
            this.colAvailability.Text = "Availability";
            this.colAvailability.Width = 185;
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRelationship.Location = new System.Drawing.Point(1202, 822);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(245, 53);
            this.btnAddRelationship.TabIndex = 6;
            this.btnAddRelationship.Text = "Add relationship";
            this.btnAddRelationship.UseVisualStyleBackColor = false;
            // 
            // btnEditAnimal
            // 
            this.btnEditAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAnimal.Location = new System.Drawing.Point(894, 822);
            this.btnEditAnimal.Name = "btnEditAnimal";
            this.btnEditAnimal.Size = new System.Drawing.Size(245, 53);
            this.btnEditAnimal.TabIndex = 5;
            this.btnEditAnimal.Text = "Edit animal";
            this.btnEditAnimal.UseVisualStyleBackColor = false;
            this.btnEditAnimal.Click += new System.EventHandler(this.btnEditAnimal_Click);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(583, 822);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(245, 53);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // groupBoxSearchAnimal
            // 
            this.groupBoxSearchAnimal.Controls.Add(this.btnDisplayAllAnimals);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxAge);
            this.groupBoxSearchAnimal.Controls.Add(this.cbTransferred);
            this.groupBoxSearchAnimal.Controls.Add(this.cbAvailable);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnMale);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnFemale);
            this.groupBoxSearchAnimal.Controls.Add(this.labelGenderAddAnimal);
            this.groupBoxSearchAnimal.Controls.Add(this.btnClearAll);
            this.groupBoxSearchAnimal.Controls.Add(this.btnSearchAnimal);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxEndangerment);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxOrigin);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEndangerment);
            this.groupBoxSearchAnimal.Controls.Add(this.labelStatus);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxSpecies);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelAge);
            this.groupBoxSearchAnimal.Controls.Add(this.labelOrigin);
            this.groupBoxSearchAnimal.Controls.Add(this.labelSpecies);
            this.groupBoxSearchAnimal.Controls.Add(this.labelName);
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(23, 21);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(509, 516);
            this.groupBoxSearchAnimal.TabIndex = 0;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
            // 
            // btnDisplayAllAnimals
            // 
            this.btnDisplayAllAnimals.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDisplayAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllAnimals.Location = new System.Drawing.Point(190, 446);
            this.btnDisplayAllAnimals.Name = "btnDisplayAllAnimals";
            this.btnDisplayAllAnimals.Size = new System.Drawing.Size(288, 45);
            this.btnDisplayAllAnimals.TabIndex = 8;
            this.btnDisplayAllAnimals.Text = "Display all animals";
            this.btnDisplayAllAnimals.UseVisualStyleBackColor = false;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(190, 276);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(91, 32);
            this.tbxAge.TabIndex = 37;
            // 
            // cbTransferred
            // 
            this.cbTransferred.AutoSize = true;
            this.cbTransferred.Location = new System.Drawing.Point(337, 231);
            this.cbTransferred.Name = "cbTransferred";
            this.cbTransferred.Size = new System.Drawing.Size(141, 30);
            this.cbTransferred.TabIndex = 36;
            this.cbTransferred.Text = "Transferred";
            this.cbTransferred.UseVisualStyleBackColor = true;
            // 
            // cbAvailable
            // 
            this.cbAvailable.AutoSize = true;
            this.cbAvailable.Location = new System.Drawing.Point(190, 231);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(120, 30);
            this.cbAvailable.TabIndex = 35;
            this.cbAvailable.Text = "Available";
            this.cbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(190, 186);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(77, 30);
            this.rbtnMale.TabIndex = 34;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(337, 186);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(103, 30);
            this.rbtnFemale.TabIndex = 33;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // labelGenderAddAnimal
            // 
            this.labelGenderAddAnimal.AutoSize = true;
            this.labelGenderAddAnimal.Location = new System.Drawing.Point(22, 185);
            this.labelGenderAddAnimal.Name = "labelGenderAddAnimal";
            this.labelGenderAddAnimal.Size = new System.Drawing.Size(90, 26);
            this.labelGenderAddAnimal.TabIndex = 32;
            this.labelGenderAddAnimal.Text = "Gender:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClearAll.Location = new System.Drawing.Point(346, 386);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(132, 45);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear fields";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.AutoSize = true;
            this.btnSearchAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearchAnimal.Location = new System.Drawing.Point(190, 386);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(132, 45);
            this.btnSearchAnimal.TabIndex = 14;
            this.btnSearchAnimal.Text = "Search";
            this.btnSearchAnimal.UseVisualStyleBackColor = false;
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // cbxEndangerment
            // 
            this.cbxEndangerment.FormattingEnabled = true;
            this.cbxEndangerment.Location = new System.Drawing.Point(190, 323);
            this.cbxEndangerment.Name = "cbxEndangerment";
            this.cbxEndangerment.Size = new System.Drawing.Size(288, 33);
            this.cbxEndangerment.TabIndex = 13;
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Location = new System.Drawing.Point(190, 138);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(288, 33);
            this.cbxOrigin.TabIndex = 9;
            // 
            // labelEndangerment
            // 
            this.labelEndangerment.AutoSize = true;
            this.labelEndangerment.Location = new System.Drawing.Point(22, 323);
            this.labelEndangerment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndangerment.Name = "labelEndangerment";
            this.labelEndangerment.Size = new System.Drawing.Size(161, 26);
            this.labelEndangerment.TabIndex = 8;
            this.labelEndangerment.Text = "Endangerment:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(22, 233);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 26);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status:";
            // 
            // tbxSpecies
            // 
            this.tbxSpecies.Location = new System.Drawing.Point(190, 91);
            this.tbxSpecies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSpecies.Name = "tbxSpecies";
            this.tbxSpecies.Size = new System.Drawing.Size(288, 32);
            this.tbxSpecies.TabIndex = 6;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(190, 44);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(288, 32);
            this.tbxName.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(22, 279);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(57, 26);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age:";
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(22, 138);
            this.labelOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(111, 26);
            this.labelOrigin.TabIndex = 2;
            this.labelOrigin.Text = "Continent:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(22, 91);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(96, 26);
            this.labelSpecies.TabIndex = 1;
            this.labelSpecies.Text = "Species:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 26);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // tabAnimalHistory
            // 
            this.tabAnimalHistory.Controls.Add(this.lvwAnimalHistory);
            this.tabAnimalHistory.Controls.Add(this.btnDisplayHistory);
            this.tabAnimalHistory.Controls.Add(this.rbtnAge);
            this.tabAnimalHistory.Controls.Add(this.rbtnContinent);
            this.tabAnimalHistory.Controls.Add(this.rbtnSpecies);
            this.tabAnimalHistory.Controls.Add(this.rbtnName);
            this.tabAnimalHistory.Controls.Add(this.labelSortBy);
            this.tabAnimalHistory.Controls.Add(this.labelAllAnimals);
            this.tabAnimalHistory.Location = new System.Drawing.Point(4, 46);
            this.tabAnimalHistory.Name = "tabAnimalHistory";
            this.tabAnimalHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimalHistory.Size = new System.Drawing.Size(1793, 897);
            this.tabAnimalHistory.TabIndex = 1;
            this.tabAnimalHistory.Text = "Animal history";
            this.tabAnimalHistory.UseVisualStyleBackColor = true;
            // 
            // lvwAnimalHistory
            // 
            this.lvwAnimalHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnName,
            this.columnSpecies,
            this.columnGender,
            this.columnAge,
            this.columnContinent,
            this.columnEnclosure,
            this.columnEndangerment,
            this.columnAvailability});
            this.lvwAnimalHistory.HideSelection = false;
            this.lvwAnimalHistory.Location = new System.Drawing.Point(24, 77);
            this.lvwAnimalHistory.Name = "lvwAnimalHistory";
            this.lvwAnimalHistory.Size = new System.Drawing.Size(1734, 790);
            this.lvwAnimalHistory.TabIndex = 43;
            this.lvwAnimalHistory.UseCompatibleStateImageBehavior = false;
            this.lvwAnimalHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 63;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 215;
            // 
            // columnSpecies
            // 
            this.columnSpecies.Text = "Species";
            this.columnSpecies.Width = 228;
            // 
            // columnGender
            // 
            this.columnGender.Text = "Gender";
            this.columnGender.Width = 201;
            // 
            // columnAge
            // 
            this.columnAge.Text = "Age";
            this.columnAge.Width = 121;
            // 
            // columnContinent
            // 
            this.columnContinent.Text = "Continent";
            this.columnContinent.Width = 232;
            // 
            // columnEnclosure
            // 
            this.columnEnclosure.Text = "Enclosure";
            this.columnEnclosure.Width = 139;
            // 
            // columnEndangerment
            // 
            this.columnEndangerment.Text = "Endangerment level";
            this.columnEndangerment.Width = 281;
            // 
            // columnAvailability
            // 
            this.columnAvailability.Text = "Availability";
            this.columnAvailability.Width = 219;
            // 
            // btnDisplayHistory
            // 
            this.btnDisplayHistory.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDisplayHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisplayHistory.FlatAppearance.BorderSize = 2;
            this.btnDisplayHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayHistory.Location = new System.Drawing.Point(1629, 19);
            this.btnDisplayHistory.Name = "btnDisplayHistory";
            this.btnDisplayHistory.Size = new System.Drawing.Size(129, 42);
            this.btnDisplayHistory.TabIndex = 42;
            this.btnDisplayHistory.Text = "Display";
            this.btnDisplayHistory.UseVisualStyleBackColor = false;
            this.btnDisplayHistory.Click += new System.EventHandler(this.btnDisplayHistory_Click);
            // 
            // rbtnAge
            // 
            this.rbtnAge.AutoSize = true;
            this.rbtnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAge.Location = new System.Drawing.Point(1525, 25);
            this.rbtnAge.Name = "rbtnAge";
            this.rbtnAge.Size = new System.Drawing.Size(69, 30);
            this.rbtnAge.TabIndex = 41;
            this.rbtnAge.Text = "Age";
            this.rbtnAge.UseVisualStyleBackColor = true;
            // 
            // rbtnContinent
            // 
            this.rbtnContinent.AutoSize = true;
            this.rbtnContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnContinent.Location = new System.Drawing.Point(1387, 25);
            this.rbtnContinent.Name = "rbtnContinent";
            this.rbtnContinent.Size = new System.Drawing.Size(123, 30);
            this.rbtnContinent.TabIndex = 40;
            this.rbtnContinent.Text = "Continent";
            this.rbtnContinent.UseVisualStyleBackColor = true;
            // 
            // rbtnSpecies
            // 
            this.rbtnSpecies.AutoSize = true;
            this.rbtnSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSpecies.Location = new System.Drawing.Point(1264, 25);
            this.rbtnSpecies.Name = "rbtnSpecies";
            this.rbtnSpecies.Size = new System.Drawing.Size(108, 30);
            this.rbtnSpecies.TabIndex = 39;
            this.rbtnSpecies.Text = "Species";
            this.rbtnSpecies.UseVisualStyleBackColor = true;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnName.Location = new System.Drawing.Point(1160, 25);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(89, 30);
            this.rbtnName.TabIndex = 38;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortBy.Location = new System.Drawing.Point(1058, 28);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(87, 26);
            this.labelSortBy.TabIndex = 37;
            this.labelSortBy.Text = "Sort by:";
            // 
            // labelAllAnimals
            // 
            this.labelAllAnimals.AutoSize = true;
            this.labelAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllAnimals.Location = new System.Drawing.Point(18, 17);
            this.labelAllAnimals.Name = "labelAllAnimals";
            this.labelAllAnimals.Size = new System.Drawing.Size(155, 31);
            this.labelAllAnimals.TabIndex = 35;
            this.labelAllAnimals.Text = "All animals";
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(879, 9);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(242, 51);
            this.labelTitleZooBazaar.TabIndex = 1;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // btnTransferAnimal
            // 
            this.btnTransferAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTransferAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferAnimal.Location = new System.Drawing.Point(1510, 822);
            this.btnTransferAnimal.Name = "btnTransferAnimal";
            this.btnTransferAnimal.Size = new System.Drawing.Size(245, 53);
            this.btnTransferAnimal.TabIndex = 8;
            this.btnTransferAnimal.Text = "Transfer animal";
            this.btnTransferAnimal.UseVisualStyleBackColor = false;
            this.btnTransferAnimal.Click += new System.EventHandler(this.btnTransferAnimal_Click);
            // 
            // FormAnimalAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::ZooBazaarDesktopApp.Properties.Resources.zooimg5;
            this.ClientSize = new System.Drawing.Size(1919, 1061);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlAnimals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnimalAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnimalAdministration";
            this.tabControlAnimals.ResumeLayout(false);
            this.tabSearchAnimals.ResumeLayout(false);
            this.groupBoxSearchAnimal.ResumeLayout(false);
            this.groupBoxSearchAnimal.PerformLayout();
            this.tabAnimalHistory.ResumeLayout(false);
            this.tabAnimalHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAnimals;
        private System.Windows.Forms.TabPage tabSearchAnimals;
        private System.Windows.Forms.Label labelTitleZooBazaar;
        private System.Windows.Forms.GroupBox groupBoxSearchAnimal;
        private System.Windows.Forms.Label labelEndangerment;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox tbxSpecies;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox cbxEndangerment;
        private System.Windows.Forms.ComboBox cbxOrigin;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSearchAnimal;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.Button btnEditAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label labelGenderAddAnimal;
        private System.Windows.Forms.TabPage tabAnimalHistory;
        private System.Windows.Forms.CheckBox cbTransferred;
        private System.Windows.Forms.CheckBox cbAvailable;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.ListView lvwAnimals;
        private System.Windows.Forms.ColumnHeader colAnimalID;
        private System.Windows.Forms.ColumnHeader colAnimalName;
        private System.Windows.Forms.ColumnHeader colSpecies;
        private System.Windows.Forms.ColumnHeader colEnclosure;
        private System.Windows.Forms.ColumnHeader colAvailability;
        private System.Windows.Forms.ColumnHeader colContinent;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.Label labelAllAnimals;
        private System.Windows.Forms.RadioButton rbtnAge;
        private System.Windows.Forms.RadioButton rbtnContinent;
        private System.Windows.Forms.RadioButton rbtnSpecies;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.Button btnDisplayHistory;
        private System.Windows.Forms.Button btnDisplayAllAnimals;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ListView lvwAnimalHistory;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSpecies;
        private System.Windows.Forms.ColumnHeader columnGender;
        private System.Windows.Forms.ColumnHeader columnContinent;
        private System.Windows.Forms.ColumnHeader columnEnclosure;
        private System.Windows.Forms.ColumnHeader columnEndangerment;
        private System.Windows.Forms.ColumnHeader columnAvailability;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.Button btnTransferAnimal;
    }
}

