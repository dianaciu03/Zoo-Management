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
            this.colContinent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnclosure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvailability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.btnEditAnimal = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.groupBoxAnimalTransfer = new System.Windows.Forms.GroupBox();
            this.tbxComments = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.btnCancelTransfer = new System.Windows.Forms.Button();
            this.btnConfirmTransfer = new System.Windows.Forms.Button();
            this.tbxAnimalTransfer = new System.Windows.Forms.TextBox();
            this.tbxAddressTransfer = new System.Windows.Forms.TextBox();
            this.labelAnimalTransfer = new System.Windows.Forms.Label();
            this.labelAdressTransfer = new System.Windows.Forms.Label();
            this.tbxZooNameTransfer = new System.Windows.Forms.TextBox();
            this.labelZooNameTransfer = new System.Windows.Forms.Label();
            this.groupBoxSearchAnimal = new System.Windows.Forms.GroupBox();
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbtnAge = new System.Windows.Forms.RadioButton();
            this.rbtnContinent = new System.Windows.Forms.RadioButton();
            this.rbtnSpecies = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.lvwAllAnimals = new System.Windows.Forms.ListView();
            this.labelAllAnimals = new System.Windows.Forms.Label();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
            this.tabControlAnimals.SuspendLayout();
            this.tabSearchAnimals.SuspendLayout();
            this.groupBoxAnimalTransfer.SuspendLayout();
            this.groupBoxSearchAnimal.SuspendLayout();
            this.tabAnimalHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAnimals
            // 
            this.tabControlAnimals.Controls.Add(this.tabSearchAnimals);
            this.tabControlAnimals.Controls.Add(this.tabAnimalHistory);
            this.tabControlAnimals.Location = new System.Drawing.Point(13, 51);
            this.tabControlAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlAnimals.Name = "tabControlAnimals";
            this.tabControlAnimals.Padding = new System.Drawing.Point(70, 9);
            this.tabControlAnimals.SelectedIndex = 0;
            this.tabControlAnimals.Size = new System.Drawing.Size(1265, 772);
            this.tabControlAnimals.TabIndex = 0;
            // 
            // tabSearchAnimals
            // 
            this.tabSearchAnimals.Controls.Add(this.lvwAnimals);
            this.tabSearchAnimals.Controls.Add(this.btnAddRelationship);
            this.tabSearchAnimals.Controls.Add(this.btnEditAnimal);
            this.tabSearchAnimals.Controls.Add(this.btnAddAnimal);
            this.tabSearchAnimals.Controls.Add(this.groupBoxAnimalTransfer);
            this.tabSearchAnimals.Controls.Add(this.groupBoxSearchAnimal);
            this.tabSearchAnimals.Location = new System.Drawing.Point(4, 41);
            this.tabSearchAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearchAnimals.Name = "tabSearchAnimals";
            this.tabSearchAnimals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearchAnimals.Size = new System.Drawing.Size(1257, 727);
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
            this.colContinent,
            this.colEnclosure,
            this.colAvailability});
            this.lvwAnimals.HideSelection = false;
            this.lvwAnimals.Location = new System.Drawing.Point(502, 30);
            this.lvwAnimals.Name = "lvwAnimals";
            this.lvwAnimals.Size = new System.Drawing.Size(742, 633);
            this.lvwAnimals.TabIndex = 7;
            this.lvwAnimals.UseCompatibleStateImageBehavior = false;
            this.lvwAnimals.View = System.Windows.Forms.View.Details;
            // 
            // colAnimalID
            // 
            this.colAnimalID.Text = "ID";
            this.colAnimalID.Width = 47;
            // 
            // colAnimalName
            // 
            this.colAnimalName.Text = "Name";
            this.colAnimalName.Width = 143;
            // 
            // colSpecies
            // 
            this.colSpecies.Text = "Specie";
            this.colSpecies.Width = 138;
            // 
            // colContinent
            // 
            this.colContinent.Text = "Continent";
            this.colContinent.Width = 146;
            // 
            // colEnclosure
            // 
            this.colEnclosure.Text = "Enclosure";
            this.colEnclosure.Width = 102;
            // 
            // colAvailability
            // 
            this.colAvailability.Text = "Availability";
            this.colAvailability.Width = 160;
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRelationship.Location = new System.Drawing.Point(1029, 669);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(215, 45);
            this.btnAddRelationship.TabIndex = 6;
            this.btnAddRelationship.Text = "Add relationship";
            this.btnAddRelationship.UseVisualStyleBackColor = true;
            // 
            // btnEditAnimal
            // 
            this.btnEditAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAnimal.Location = new System.Drawing.Point(765, 669);
            this.btnEditAnimal.Name = "btnEditAnimal";
            this.btnEditAnimal.Size = new System.Drawing.Size(215, 45);
            this.btnEditAnimal.TabIndex = 5;
            this.btnEditAnimal.Text = "Edit animal";
            this.btnEditAnimal.UseVisualStyleBackColor = true;
            this.btnEditAnimal.Click += new System.EventHandler(this.btnEditAnimal_Click);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(502, 669);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(215, 45);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // groupBoxAnimalTransfer
            // 
            this.groupBoxAnimalTransfer.Controls.Add(this.tbxComments);
            this.groupBoxAnimalTransfer.Controls.Add(this.labelComments);
            this.groupBoxAnimalTransfer.Controls.Add(this.btnCancelTransfer);
            this.groupBoxAnimalTransfer.Controls.Add(this.btnConfirmTransfer);
            this.groupBoxAnimalTransfer.Controls.Add(this.tbxAnimalTransfer);
            this.groupBoxAnimalTransfer.Controls.Add(this.tbxAddressTransfer);
            this.groupBoxAnimalTransfer.Controls.Add(this.labelAnimalTransfer);
            this.groupBoxAnimalTransfer.Controls.Add(this.labelAdressTransfer);
            this.groupBoxAnimalTransfer.Controls.Add(this.tbxZooNameTransfer);
            this.groupBoxAnimalTransfer.Controls.Add(this.labelZooNameTransfer);
            this.groupBoxAnimalTransfer.Location = new System.Drawing.Point(8, 401);
            this.groupBoxAnimalTransfer.Name = "groupBoxAnimalTransfer";
            this.groupBoxAnimalTransfer.Size = new System.Drawing.Size(478, 313);
            this.groupBoxAnimalTransfer.TabIndex = 3;
            this.groupBoxAnimalTransfer.TabStop = false;
            this.groupBoxAnimalTransfer.Text = "Animal transfer";
            // 
            // tbxComments
            // 
            this.tbxComments.Location = new System.Drawing.Point(156, 117);
            this.tbxComments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxComments.Multiline = true;
            this.tbxComments.Name = "tbxComments";
            this.tbxComments.Size = new System.Drawing.Size(288, 95);
            this.tbxComments.TabIndex = 18;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(22, 120);
            this.labelComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(90, 20);
            this.labelComments.TabIndex = 17;
            this.labelComments.Text = "Comments:";
            // 
            // btnCancelTransfer
            // 
            this.btnCancelTransfer.AutoSize = true;
            this.btnCancelTransfer.Location = new System.Drawing.Point(312, 264);
            this.btnCancelTransfer.Name = "btnCancelTransfer";
            this.btnCancelTransfer.Size = new System.Drawing.Size(132, 35);
            this.btnCancelTransfer.TabIndex = 16;
            this.btnCancelTransfer.Text = "Cancel";
            this.btnCancelTransfer.UseVisualStyleBackColor = true;
            this.btnCancelTransfer.Click += new System.EventHandler(this.btnCancelTransfer_Click);
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.AutoSize = true;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(156, 264);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(132, 35);
            this.btnConfirmTransfer.TabIndex = 15;
            this.btnConfirmTransfer.Text = "Confirm";
            this.btnConfirmTransfer.UseVisualStyleBackColor = true;
            // 
            // tbxAnimalTransfer
            // 
            this.tbxAnimalTransfer.Location = new System.Drawing.Point(156, 218);
            this.tbxAnimalTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAnimalTransfer.Name = "tbxAnimalTransfer";
            this.tbxAnimalTransfer.ReadOnly = true;
            this.tbxAnimalTransfer.Size = new System.Drawing.Size(288, 26);
            this.tbxAnimalTransfer.TabIndex = 11;
            // 
            // tbxAddressTransfer
            // 
            this.tbxAddressTransfer.Location = new System.Drawing.Point(156, 80);
            this.tbxAddressTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddressTransfer.Name = "tbxAddressTransfer";
            this.tbxAddressTransfer.Size = new System.Drawing.Size(288, 26);
            this.tbxAddressTransfer.TabIndex = 10;
            // 
            // labelAnimalTransfer
            // 
            this.labelAnimalTransfer.AutoSize = true;
            this.labelAnimalTransfer.Location = new System.Drawing.Point(22, 221);
            this.labelAnimalTransfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnimalTransfer.Name = "labelAnimalTransfer";
            this.labelAnimalTransfer.Size = new System.Drawing.Size(61, 20);
            this.labelAnimalTransfer.TabIndex = 9;
            this.labelAnimalTransfer.Text = "Animal:";
            // 
            // labelAdressTransfer
            // 
            this.labelAdressTransfer.AutoSize = true;
            this.labelAdressTransfer.Location = new System.Drawing.Point(22, 83);
            this.labelAdressTransfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdressTransfer.Name = "labelAdressTransfer";
            this.labelAdressTransfer.Size = new System.Drawing.Size(102, 20);
            this.labelAdressTransfer.TabIndex = 8;
            this.labelAdressTransfer.Text = "Zoo address:";
            // 
            // tbxZooNameTransfer
            // 
            this.tbxZooNameTransfer.Location = new System.Drawing.Point(156, 40);
            this.tbxZooNameTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxZooNameTransfer.Name = "tbxZooNameTransfer";
            this.tbxZooNameTransfer.Size = new System.Drawing.Size(288, 26);
            this.tbxZooNameTransfer.TabIndex = 7;
            // 
            // labelZooNameTransfer
            // 
            this.labelZooNameTransfer.AutoSize = true;
            this.labelZooNameTransfer.Location = new System.Drawing.Point(22, 43);
            this.labelZooNameTransfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZooNameTransfer.Name = "labelZooNameTransfer";
            this.labelZooNameTransfer.Size = new System.Drawing.Size(85, 20);
            this.labelZooNameTransfer.TabIndex = 6;
            this.labelZooNameTransfer.Text = "Zoo name:";
            // 
            // groupBoxSearchAnimal
            // 
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
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(8, 21);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(478, 374);
            this.groupBoxSearchAnimal.TabIndex = 0;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(156, 234);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(91, 26);
            this.tbxAge.TabIndex = 37;
            // 
            // cbTransferred
            // 
            this.cbTransferred.AutoSize = true;
            this.cbTransferred.Location = new System.Drawing.Point(275, 199);
            this.cbTransferred.Name = "cbTransferred";
            this.cbTransferred.Size = new System.Drawing.Size(110, 24);
            this.cbTransferred.TabIndex = 36;
            this.cbTransferred.Text = "Transferred";
            this.cbTransferred.UseVisualStyleBackColor = true;
            // 
            // cbAvailable
            // 
            this.cbAvailable.AutoSize = true;
            this.cbAvailable.Location = new System.Drawing.Point(156, 199);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(91, 24);
            this.cbAvailable.TabIndex = 35;
            this.cbAvailable.Text = "Available";
            this.cbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(156, 163);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(61, 24);
            this.rbtnMale.TabIndex = 34;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(275, 163);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(80, 24);
            this.rbtnFemale.TabIndex = 33;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // labelGenderAddAnimal
            // 
            this.labelGenderAddAnimal.AutoSize = true;
            this.labelGenderAddAnimal.Location = new System.Drawing.Point(22, 165);
            this.labelGenderAddAnimal.Name = "labelGenderAddAnimal";
            this.labelGenderAddAnimal.Size = new System.Drawing.Size(67, 20);
            this.labelGenderAddAnimal.TabIndex = 32;
            this.labelGenderAddAnimal.Text = "Gender:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Location = new System.Drawing.Point(312, 326);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(132, 35);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.AutoSize = true;
            this.btnSearchAnimal.Location = new System.Drawing.Point(156, 326);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(132, 35);
            this.btnSearchAnimal.TabIndex = 14;
            this.btnSearchAnimal.Text = "Search";
            this.btnSearchAnimal.UseVisualStyleBackColor = true;
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // cbxEndangerment
            // 
            this.cbxEndangerment.FormattingEnabled = true;
            this.cbxEndangerment.Location = new System.Drawing.Point(156, 278);
            this.cbxEndangerment.Name = "cbxEndangerment";
            this.cbxEndangerment.Size = new System.Drawing.Size(288, 28);
            this.cbxEndangerment.TabIndex = 13;
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Location = new System.Drawing.Point(156, 124);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(288, 28);
            this.cbxOrigin.TabIndex = 9;
            // 
            // labelEndangerment
            // 
            this.labelEndangerment.AutoSize = true;
            this.labelEndangerment.Location = new System.Drawing.Point(22, 281);
            this.labelEndangerment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndangerment.Name = "labelEndangerment";
            this.labelEndangerment.Size = new System.Drawing.Size(119, 20);
            this.labelEndangerment.TabIndex = 8;
            this.labelEndangerment.Text = "Endangerment:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(22, 200);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 20);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status:";
            // 
            // tbxSpecies
            // 
            this.tbxSpecies.Location = new System.Drawing.Point(156, 83);
            this.tbxSpecies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSpecies.Name = "tbxSpecies";
            this.tbxSpecies.Size = new System.Drawing.Size(288, 26);
            this.tbxSpecies.TabIndex = 6;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(156, 41);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(288, 26);
            this.tbxName.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(22, 237);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 20);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age:";
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(22, 127);
            this.labelOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(82, 20);
            this.labelOrigin.TabIndex = 2;
            this.labelOrigin.Text = "Continent:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(22, 86);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(70, 20);
            this.labelSpecies.TabIndex = 1;
            this.labelSpecies.Text = "Species:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // tabAnimalHistory
            // 
            this.tabAnimalHistory.Controls.Add(this.btnSearch);
            this.tabAnimalHistory.Controls.Add(this.rbtnAge);
            this.tabAnimalHistory.Controls.Add(this.rbtnContinent);
            this.tabAnimalHistory.Controls.Add(this.rbtnSpecies);
            this.tabAnimalHistory.Controls.Add(this.rbtnName);
            this.tabAnimalHistory.Controls.Add(this.labelSortBy);
            this.tabAnimalHistory.Controls.Add(this.lvwAllAnimals);
            this.tabAnimalHistory.Controls.Add(this.labelAllAnimals);
            this.tabAnimalHistory.Location = new System.Drawing.Point(4, 41);
            this.tabAnimalHistory.Name = "tabAnimalHistory";
            this.tabAnimalHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimalHistory.Size = new System.Drawing.Size(1257, 727);
            this.tabAnimalHistory.TabIndex = 1;
            this.tabAnimalHistory.Text = "Animal history";
            this.tabAnimalHistory.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1143, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 38);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rbtnAge
            // 
            this.rbtnAge.AutoSize = true;
            this.rbtnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAge.Location = new System.Drawing.Point(1048, 17);
            this.rbtnAge.Name = "rbtnAge";
            this.rbtnAge.Size = new System.Drawing.Size(63, 28);
            this.rbtnAge.TabIndex = 41;
            this.rbtnAge.TabStop = true;
            this.rbtnAge.Text = "Age";
            this.rbtnAge.UseVisualStyleBackColor = true;
            // 
            // rbtnContinent
            // 
            this.rbtnContinent.AutoSize = true;
            this.rbtnContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnContinent.Location = new System.Drawing.Point(934, 17);
            this.rbtnContinent.Name = "rbtnContinent";
            this.rbtnContinent.Size = new System.Drawing.Size(108, 28);
            this.rbtnContinent.TabIndex = 40;
            this.rbtnContinent.TabStop = true;
            this.rbtnContinent.Text = "Continent";
            this.rbtnContinent.UseVisualStyleBackColor = true;
            // 
            // rbtnSpecies
            // 
            this.rbtnSpecies.AutoSize = true;
            this.rbtnSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSpecies.Location = new System.Drawing.Point(832, 17);
            this.rbtnSpecies.Name = "rbtnSpecies";
            this.rbtnSpecies.Size = new System.Drawing.Size(96, 28);
            this.rbtnSpecies.TabIndex = 39;
            this.rbtnSpecies.TabStop = true;
            this.rbtnSpecies.Text = "Species";
            this.rbtnSpecies.UseVisualStyleBackColor = true;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnName.Location = new System.Drawing.Point(747, 17);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(79, 28);
            this.rbtnName.TabIndex = 38;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortBy.Location = new System.Drawing.Point(668, 19);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(73, 24);
            this.labelSortBy.TabIndex = 37;
            this.labelSortBy.Text = "Sort by:";
            // 
            // lvwAllAnimals
            // 
            this.lvwAllAnimals.HideSelection = false;
            this.lvwAllAnimals.Location = new System.Drawing.Point(12, 56);
            this.lvwAllAnimals.Name = "lvwAllAnimals";
            this.lvwAllAnimals.Size = new System.Drawing.Size(1229, 665);
            this.lvwAllAnimals.TabIndex = 36;
            this.lvwAllAnimals.UseCompatibleStateImageBehavior = false;
            // 
            // labelAllAnimals
            // 
            this.labelAllAnimals.AutoSize = true;
            this.labelAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllAnimals.Location = new System.Drawing.Point(6, 12);
            this.labelAllAnimals.Name = "labelAllAnimals";
            this.labelAllAnimals.Size = new System.Drawing.Size(155, 31);
            this.labelAllAnimals.TabIndex = 35;
            this.labelAllAnimals.Text = "All animals";
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(532, 9);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(184, 37);
            this.labelTitleZooBazaar.TabIndex = 1;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // FormAnimalAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1286, 831);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlAnimals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnimalAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnimalAdministration";
            this.tabControlAnimals.ResumeLayout(false);
            this.tabSearchAnimals.ResumeLayout(false);
            this.groupBoxAnimalTransfer.ResumeLayout(false);
            this.groupBoxAnimalTransfer.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxAnimalTransfer;
        private System.Windows.Forms.TextBox tbxComments;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Button btnCancelTransfer;
        private System.Windows.Forms.Button btnConfirmTransfer;
        private System.Windows.Forms.TextBox tbxAnimalTransfer;
        private System.Windows.Forms.TextBox tbxAddressTransfer;
        private System.Windows.Forms.Label labelAnimalTransfer;
        private System.Windows.Forms.Label labelAdressTransfer;
        private System.Windows.Forms.TextBox tbxZooNameTransfer;
        private System.Windows.Forms.Label labelZooNameTransfer;
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
        private System.Windows.Forms.ListView lvwAllAnimals;
        private System.Windows.Forms.Label labelAllAnimals;
        private System.Windows.Forms.RadioButton rbtnAge;
        private System.Windows.Forms.RadioButton rbtnContinent;
        private System.Windows.Forms.RadioButton rbtnSpecies;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.Button btnSearch;
    }
}

