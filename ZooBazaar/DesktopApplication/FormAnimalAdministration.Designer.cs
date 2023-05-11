﻿namespace DesktopApplication
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
            this.groupBoxEditAnimal = new System.Windows.Forms.GroupBox();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.labelDateFormatEdit = new System.Windows.Forms.Label();
            this.labelDateofBirth = new System.Windows.Forms.Label();
            this.btnCancelEditAnimalDetails = new System.Windows.Forms.Button();
            this.maskedtbxDateOfBirthEdit = new System.Windows.Forms.MaskedTextBox();
            this.rbtnMaleEdit = new System.Windows.Forms.RadioButton();
            this.rbtnFemaleEdit = new System.Windows.Forms.RadioButton();
            this.labelGenderEdit = new System.Windows.Forms.Label();
            this.numudEnclosureEdit = new System.Windows.Forms.NumericUpDown();
            this.labelEnclosureNrEdit = new System.Windows.Forms.Label();
            this.tbxAdditionalCommentsEdit = new System.Windows.Forms.TextBox();
            this.labelAdditionalCommentsEdit = new System.Windows.Forms.Label();
            this.cbxEndangermentEdit = new System.Windows.Forms.ComboBox();
            this.cbxContinentEdit = new System.Windows.Forms.ComboBox();
            this.labelEndangerEdit = new System.Windows.Forms.Label();
            this.tbxSpeciesEdit = new System.Windows.Forms.TextBox();
            this.tbxNameEdit = new System.Windows.Forms.TextBox();
            this.labelContinentEdit = new System.Windows.Forms.Label();
            this.labelSpeciesEdit = new System.Windows.Forms.Label();
            this.labelNameEdit = new System.Windows.Forms.Label();
            this.groupBoxRelationship = new System.Windows.Forms.GroupBox();
            this.btnRemoveRelationship = new System.Windows.Forms.Button();
            this.btnCancelRelationship = new System.Windows.Forms.Button();
            this.btnAddNewRelationship = new System.Windows.Forms.Button();
            this.labelExistingRelationshipMain = new System.Windows.Forms.Label();
            this.lbxRelationshipsMain = new System.Windows.Forms.ListBox();
            this.cbxOtherAnimalRelationship = new System.Windows.Forms.ComboBox();
            this.cbxRelationshipType = new System.Windows.Forms.ComboBox();
            this.labelRelationshipTypeMain = new System.Windows.Forms.Label();
            this.labelOtherAnimalMain = new System.Windows.Forms.Label();
            this.tbxMainAnimalRelationship = new System.Windows.Forms.TextBox();
            this.labelMainAnimalRelationship = new System.Windows.Forms.Label();
            this.groupBoxAnimalTransfer = new System.Windows.Forms.GroupBox();
            this.tbxAnimalTransferPhone = new System.Windows.Forms.TextBox();
            this.labelAnimeTransferPhone = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
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
            this.labelAgeSearch = new System.Windows.Forms.Label();
            this.btnDisplayAllAnimals = new System.Windows.Forms.Button();
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
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnTransferAnimal = new System.Windows.Forms.Button();
            this.lvwAnimals = new System.Windows.Forms.ListView();
            this.colAnimalID = new System.Windows.Forms.ColumnHeader();
            this.colAnimalName = new System.Windows.Forms.ColumnHeader();
            this.colSpecies = new System.Windows.Forms.ColumnHeader();
            this.colGender = new System.Windows.Forms.ColumnHeader();
            this.colContinent = new System.Windows.Forms.ColumnHeader();
            this.colEnclosure = new System.Windows.Forms.ColumnHeader();
            this.colAvailability = new System.Windows.Forms.ColumnHeader();
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.btnEditAnimal = new System.Windows.Forms.Button();
            this.tabAnimalHistory = new System.Windows.Forms.TabPage();
            this.lvwAnimalHistory = new System.Windows.Forms.ListView();
            this.columnId = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnSpecies = new System.Windows.Forms.ColumnHeader();
            this.columnGender = new System.Windows.Forms.ColumnHeader();
            this.columnAge = new System.Windows.Forms.ColumnHeader();
            this.columnContinent = new System.Windows.Forms.ColumnHeader();
            this.columnEnclosure = new System.Windows.Forms.ColumnHeader();
            this.columnEndangerment = new System.Windows.Forms.ColumnHeader();
            this.columnAvailability = new System.Windows.Forms.ColumnHeader();
            this.btnDisplayHistory = new System.Windows.Forms.Button();
            this.rbtnAge = new System.Windows.Forms.RadioButton();
            this.rbtnContinent = new System.Windows.Forms.RadioButton();
            this.rbtnSpecies = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.labelAllAnimals = new System.Windows.Forms.Label();
            this.tabPageAddAnimal = new System.Windows.Forms.TabPage();
            this.groupBoxAddAnimal = new System.Windows.Forms.GroupBox();
            this.labelDateFormat = new System.Windows.Forms.Label();
            this.labelAddAnimalBirthDate = new System.Windows.Forms.Label();
            this.maskedtbxBirthDateAddAnimalForm = new System.Windows.Forms.MaskedTextBox();
            this.rbtnMaleAddAnimal = new System.Windows.Forms.RadioButton();
            this.rbtnFemaleAddAnimal = new System.Windows.Forms.RadioButton();
            this.labelGenderAdd = new System.Windows.Forms.Label();
            this.nudEnclosureAddAnimal = new System.Windows.Forms.NumericUpDown();
            this.labelEnclosureAddAnimal = new System.Windows.Forms.Label();
            this.tbxAdditionalCommentsAddAnimal = new System.Windows.Forms.TextBox();
            this.labelAdditionalCommentsAddAnimal = new System.Windows.Forms.Label();
            this.cbxEndangermentAddAnimal = new System.Windows.Forms.ComboBox();
            this.cbxOriginAddAnimal = new System.Windows.Forms.ComboBox();
            this.labelAddAnimalEndangerment = new System.Windows.Forms.Label();
            this.tbxSpeciesAddAnimal = new System.Windows.Forms.TextBox();
            this.tbxNameAddAnimal = new System.Windows.Forms.TextBox();
            this.labelAddAnimalOrigin = new System.Windows.Forms.Label();
            this.labelAddAnimalSpecies = new System.Windows.Forms.Label();
            this.labelAddAnimalName = new System.Windows.Forms.Label();
            this.lvwRecentlyAddedAnimals = new System.Windows.Forms.ListView();
            this.columnNameRecentlyAdded = new System.Windows.Forms.ColumnHeader();
            this.columnSpeciesRecentlyAdded = new System.Windows.Forms.ColumnHeader();
            this.columnGenderRecentlyAdded = new System.Windows.Forms.ColumnHeader();
            this.columnContinentRecentlyAdded = new System.Windows.Forms.ColumnHeader();
            this.columnEnclosureRecentlyAdded = new System.Windows.Forms.ColumnHeader();
            this.btnDeleteRelationship = new System.Windows.Forms.Button();
            this.labelExistingRelationships = new System.Windows.Forms.Label();
            this.buttonAddRelationshipAddAnimal = new System.Windows.Forms.Button();
            this.labelSelectedAnimal = new System.Windows.Forms.Label();
            this.lbxDisplayAnimalRelationships = new System.Windows.Forms.ListBox();
            this.tbxAnimalForRelationship = new System.Windows.Forms.TextBox();
            this.labelRecentlyAddedAnimals = new System.Windows.Forms.Label();
            this.groupBoxRelationships = new System.Windows.Forms.GroupBox();
            this.cbOtherAnimal = new System.Windows.Forms.ComboBox();
            this.cbRelationShipType = new System.Windows.Forms.ComboBox();
            this.labelRelationshipType = new System.Windows.Forms.Label();
            this.labelOtherAnimal = new System.Windows.Forms.Label();
            this.btnConfirmAnimalCreation = new System.Windows.Forms.Button();
            this.btnCancelAnimalCreation = new System.Windows.Forms.Button();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
            this.tabControlAnimals.SuspendLayout();
            this.tabSearchAnimals.SuspendLayout();
            this.groupBoxEditAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudEnclosureEdit)).BeginInit();
            this.groupBoxRelationship.SuspendLayout();
            this.groupBoxAnimalTransfer.SuspendLayout();
            this.groupBoxSearchAnimal.SuspendLayout();
            this.tabAnimalHistory.SuspendLayout();
            this.tabPageAddAnimal.SuspendLayout();
            this.groupBoxAddAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnclosureAddAnimal)).BeginInit();
            this.groupBoxRelationships.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAnimals
            // 
            this.tabControlAnimals.Controls.Add(this.tabSearchAnimals);
            this.tabControlAnimals.Controls.Add(this.tabAnimalHistory);
            this.tabControlAnimals.Controls.Add(this.tabPageAddAnimal);
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
            this.tabSearchAnimals.Controls.Add(this.groupBoxEditAnimal);
            this.tabSearchAnimals.Controls.Add(this.groupBoxRelationship);
            this.tabSearchAnimals.Controls.Add(this.groupBoxAnimalTransfer);
            this.tabSearchAnimals.Controls.Add(this.groupBoxSearchAnimal);
            this.tabSearchAnimals.Controls.Add(this.btnTransferAnimal);
            this.tabSearchAnimals.Controls.Add(this.lvwAnimals);
            this.tabSearchAnimals.Controls.Add(this.btnAddRelationship);
            this.tabSearchAnimals.Controls.Add(this.btnEditAnimal);
            this.tabSearchAnimals.Location = new System.Drawing.Point(4, 46);
            this.tabSearchAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearchAnimals.Name = "tabSearchAnimals";
            this.tabSearchAnimals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearchAnimals.Size = new System.Drawing.Size(1793, 897);
            this.tabSearchAnimals.TabIndex = 0;
            this.tabSearchAnimals.Text = "Search animals";
            this.tabSearchAnimals.UseVisualStyleBackColor = true;
            // 
            // groupBoxEditAnimal
            // 
            this.groupBoxEditAnimal.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEditAnimal.Controls.Add(this.btnConfirmChanges);
            this.groupBoxEditAnimal.Controls.Add(this.labelDateFormatEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelDateofBirth);
            this.groupBoxEditAnimal.Controls.Add(this.btnCancelEditAnimalDetails);
            this.groupBoxEditAnimal.Controls.Add(this.maskedtbxDateOfBirthEdit);
            this.groupBoxEditAnimal.Controls.Add(this.rbtnMaleEdit);
            this.groupBoxEditAnimal.Controls.Add(this.rbtnFemaleEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelGenderEdit);
            this.groupBoxEditAnimal.Controls.Add(this.numudEnclosureEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelEnclosureNrEdit);
            this.groupBoxEditAnimal.Controls.Add(this.tbxAdditionalCommentsEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelAdditionalCommentsEdit);
            this.groupBoxEditAnimal.Controls.Add(this.cbxEndangermentEdit);
            this.groupBoxEditAnimal.Controls.Add(this.cbxContinentEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelEndangerEdit);
            this.groupBoxEditAnimal.Controls.Add(this.tbxSpeciesEdit);
            this.groupBoxEditAnimal.Controls.Add(this.tbxNameEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelContinentEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelSpeciesEdit);
            this.groupBoxEditAnimal.Controls.Add(this.labelNameEdit);
            this.groupBoxEditAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditAnimal.Location = new System.Drawing.Point(29, 18);
            this.groupBoxEditAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxEditAnimal.Name = "groupBoxEditAnimal";
            this.groupBoxEditAnimal.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxEditAnimal.Size = new System.Drawing.Size(630, 850);
            this.groupBoxEditAnimal.TabIndex = 43;
            this.groupBoxEditAnimal.TabStop = false;
            this.groupBoxEditAnimal.Text = "Animal details:";
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConfirmChanges.Location = new System.Drawing.Point(21, 740);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(261, 52);
            this.btnConfirmChanges.TabIndex = 42;
            this.btnConfirmChanges.Text = "Confirm";
            this.btnConfirmChanges.UseVisualStyleBackColor = false;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // labelDateFormatEdit
            // 
            this.labelDateFormatEdit.AutoSize = true;
            this.labelDateFormatEdit.Location = new System.Drawing.Point(359, 269);
            this.labelDateFormatEdit.Name = "labelDateFormatEdit";
            this.labelDateFormatEdit.Size = new System.Drawing.Size(155, 29);
            this.labelDateFormatEdit.TabIndex = 39;
            this.labelDateFormatEdit.Text = "(mm/dd/yyyy)";
            // 
            // labelDateofBirth
            // 
            this.labelDateofBirth.AutoSize = true;
            this.labelDateofBirth.Location = new System.Drawing.Point(17, 269);
            this.labelDateofBirth.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDateofBirth.Name = "labelDateofBirth";
            this.labelDateofBirth.Size = new System.Drawing.Size(148, 29);
            this.labelDateofBirth.TabIndex = 38;
            this.labelDateofBirth.Text = "Date of birth:";
            // 
            // btnCancelEditAnimalDetails
            // 
            this.btnCancelEditAnimalDetails.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelEditAnimalDetails.Location = new System.Drawing.Point(334, 740);
            this.btnCancelEditAnimalDetails.Name = "btnCancelEditAnimalDetails";
            this.btnCancelEditAnimalDetails.Size = new System.Drawing.Size(261, 52);
            this.btnCancelEditAnimalDetails.TabIndex = 41;
            this.btnCancelEditAnimalDetails.Text = "Cancel";
            this.btnCancelEditAnimalDetails.UseVisualStyleBackColor = false;
            this.btnCancelEditAnimalDetails.Click += new System.EventHandler(this.btnCancelEditAnimalDetails_Click);
            // 
            // maskedtbxDateOfBirthEdit
            // 
            this.maskedtbxDateOfBirthEdit.Location = new System.Drawing.Point(205, 266);
            this.maskedtbxDateOfBirthEdit.Mask = "00/00/0000";
            this.maskedtbxDateOfBirthEdit.Name = "maskedtbxDateOfBirthEdit";
            this.maskedtbxDateOfBirthEdit.ResetOnSpace = false;
            this.maskedtbxDateOfBirthEdit.Size = new System.Drawing.Size(129, 35);
            this.maskedtbxDateOfBirthEdit.TabIndex = 35;
            // 
            // rbtnMaleEdit
            // 
            this.rbtnMaleEdit.AutoSize = true;
            this.rbtnMaleEdit.Location = new System.Drawing.Point(205, 218);
            this.rbtnMaleEdit.Name = "rbtnMaleEdit";
            this.rbtnMaleEdit.Size = new System.Drawing.Size(84, 33);
            this.rbtnMaleEdit.TabIndex = 31;
            this.rbtnMaleEdit.TabStop = true;
            this.rbtnMaleEdit.Text = "Male";
            this.rbtnMaleEdit.UseVisualStyleBackColor = true;
            // 
            // rbtnFemaleEdit
            // 
            this.rbtnFemaleEdit.AutoSize = true;
            this.rbtnFemaleEdit.Location = new System.Drawing.Point(315, 218);
            this.rbtnFemaleEdit.Name = "rbtnFemaleEdit";
            this.rbtnFemaleEdit.Size = new System.Drawing.Size(113, 33);
            this.rbtnFemaleEdit.TabIndex = 30;
            this.rbtnFemaleEdit.TabStop = true;
            this.rbtnFemaleEdit.Text = "Female";
            this.rbtnFemaleEdit.UseVisualStyleBackColor = true;
            // 
            // labelGenderEdit
            // 
            this.labelGenderEdit.AutoSize = true;
            this.labelGenderEdit.Location = new System.Drawing.Point(16, 220);
            this.labelGenderEdit.Name = "labelGenderEdit";
            this.labelGenderEdit.Size = new System.Drawing.Size(100, 29);
            this.labelGenderEdit.TabIndex = 29;
            this.labelGenderEdit.Text = "Gender:";
            // 
            // numudEnclosureEdit
            // 
            this.numudEnclosureEdit.Location = new System.Drawing.Point(205, 378);
            this.numudEnclosureEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numudEnclosureEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudEnclosureEdit.Name = "numudEnclosureEdit";
            this.numudEnclosureEdit.Size = new System.Drawing.Size(129, 35);
            this.numudEnclosureEdit.TabIndex = 17;
            this.numudEnclosureEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEnclosureNrEdit
            // 
            this.labelEnclosureNrEdit.AutoSize = true;
            this.labelEnclosureNrEdit.Location = new System.Drawing.Point(16, 380);
            this.labelEnclosureNrEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnclosureNrEdit.Name = "labelEnclosureNrEdit";
            this.labelEnclosureNrEdit.Size = new System.Drawing.Size(154, 29);
            this.labelEnclosureNrEdit.TabIndex = 16;
            this.labelEnclosureNrEdit.Text = "Enclosure nr:";
            // 
            // tbxAdditionalCommentsEdit
            // 
            this.tbxAdditionalCommentsEdit.Location = new System.Drawing.Point(21, 483);
            this.tbxAdditionalCommentsEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbxAdditionalCommentsEdit.Multiline = true;
            this.tbxAdditionalCommentsEdit.Name = "tbxAdditionalCommentsEdit";
            this.tbxAdditionalCommentsEdit.Size = new System.Drawing.Size(581, 226);
            this.tbxAdditionalCommentsEdit.TabIndex = 15;
            // 
            // labelAdditionalCommentsEdit
            // 
            this.labelAdditionalCommentsEdit.AutoSize = true;
            this.labelAdditionalCommentsEdit.Location = new System.Drawing.Point(16, 439);
            this.labelAdditionalCommentsEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdditionalCommentsEdit.Name = "labelAdditionalCommentsEdit";
            this.labelAdditionalCommentsEdit.Size = new System.Drawing.Size(243, 29);
            this.labelAdditionalCommentsEdit.TabIndex = 14;
            this.labelAdditionalCommentsEdit.Text = "Additional comments:";
            // 
            // cbxEndangermentEdit
            // 
            this.cbxEndangermentEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndangermentEdit.FormattingEnabled = true;
            this.cbxEndangermentEdit.Location = new System.Drawing.Point(205, 320);
            this.cbxEndangermentEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxEndangermentEdit.Name = "cbxEndangermentEdit";
            this.cbxEndangermentEdit.Size = new System.Drawing.Size(397, 37);
            this.cbxEndangermentEdit.TabIndex = 13;
            // 
            // cbxContinentEdit
            // 
            this.cbxContinentEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContinentEdit.FormattingEnabled = true;
            this.cbxContinentEdit.Location = new System.Drawing.Point(205, 163);
            this.cbxContinentEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxContinentEdit.Name = "cbxContinentEdit";
            this.cbxContinentEdit.Size = new System.Drawing.Size(397, 37);
            this.cbxContinentEdit.TabIndex = 9;
            // 
            // labelEndangerEdit
            // 
            this.labelEndangerEdit.AutoSize = true;
            this.labelEndangerEdit.Location = new System.Drawing.Point(16, 323);
            this.labelEndangerEdit.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEndangerEdit.Name = "labelEndangerEdit";
            this.labelEndangerEdit.Size = new System.Drawing.Size(177, 29);
            this.labelEndangerEdit.TabIndex = 8;
            this.labelEndangerEdit.Text = "Endangerment:";
            // 
            // tbxSpeciesEdit
            // 
            this.tbxSpeciesEdit.Location = new System.Drawing.Point(205, 106);
            this.tbxSpeciesEdit.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxSpeciesEdit.Name = "tbxSpeciesEdit";
            this.tbxSpeciesEdit.Size = new System.Drawing.Size(397, 35);
            this.tbxSpeciesEdit.TabIndex = 6;
            // 
            // tbxNameEdit
            // 
            this.tbxNameEdit.Location = new System.Drawing.Point(205, 48);
            this.tbxNameEdit.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxNameEdit.Name = "tbxNameEdit";
            this.tbxNameEdit.Size = new System.Drawing.Size(397, 35);
            this.tbxNameEdit.TabIndex = 5;
            // 
            // labelContinentEdit
            // 
            this.labelContinentEdit.AutoSize = true;
            this.labelContinentEdit.Location = new System.Drawing.Point(16, 166);
            this.labelContinentEdit.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelContinentEdit.Name = "labelContinentEdit";
            this.labelContinentEdit.Size = new System.Drawing.Size(121, 29);
            this.labelContinentEdit.TabIndex = 2;
            this.labelContinentEdit.Text = "Continent:";
            // 
            // labelSpeciesEdit
            // 
            this.labelSpeciesEdit.AutoSize = true;
            this.labelSpeciesEdit.Location = new System.Drawing.Point(16, 109);
            this.labelSpeciesEdit.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSpeciesEdit.Name = "labelSpeciesEdit";
            this.labelSpeciesEdit.Size = new System.Drawing.Size(107, 29);
            this.labelSpeciesEdit.TabIndex = 1;
            this.labelSpeciesEdit.Text = "Species:";
            // 
            // labelNameEdit
            // 
            this.labelNameEdit.AutoSize = true;
            this.labelNameEdit.Location = new System.Drawing.Point(16, 51);
            this.labelNameEdit.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNameEdit.Name = "labelNameEdit";
            this.labelNameEdit.Size = new System.Drawing.Size(84, 29);
            this.labelNameEdit.TabIndex = 0;
            this.labelNameEdit.Text = "Name:";
            // 
            // groupBoxRelationship
            // 
            this.groupBoxRelationship.Controls.Add(this.btnRemoveRelationship);
            this.groupBoxRelationship.Controls.Add(this.btnCancelRelationship);
            this.groupBoxRelationship.Controls.Add(this.btnAddNewRelationship);
            this.groupBoxRelationship.Controls.Add(this.labelExistingRelationshipMain);
            this.groupBoxRelationship.Controls.Add(this.lbxRelationshipsMain);
            this.groupBoxRelationship.Controls.Add(this.cbxOtherAnimalRelationship);
            this.groupBoxRelationship.Controls.Add(this.cbxRelationshipType);
            this.groupBoxRelationship.Controls.Add(this.labelRelationshipTypeMain);
            this.groupBoxRelationship.Controls.Add(this.labelOtherAnimalMain);
            this.groupBoxRelationship.Controls.Add(this.tbxMainAnimalRelationship);
            this.groupBoxRelationship.Controls.Add(this.labelMainAnimalRelationship);
            this.groupBoxRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRelationship.Location = new System.Drawing.Point(29, 18);
            this.groupBoxRelationship.Name = "groupBoxRelationship";
            this.groupBoxRelationship.Size = new System.Drawing.Size(630, 750);
            this.groupBoxRelationship.TabIndex = 46;
            this.groupBoxRelationship.TabStop = false;
            this.groupBoxRelationship.Text = "Add relationship";
            // 
            // btnRemoveRelationship
            // 
            this.btnRemoveRelationship.AutoSize = true;
            this.btnRemoveRelationship.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRemoveRelationship.Location = new System.Drawing.Point(178, 676);
            this.btnRemoveRelationship.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveRelationship.Name = "btnRemoveRelationship";
            this.btnRemoveRelationship.Size = new System.Drawing.Size(261, 55);
            this.btnRemoveRelationship.TabIndex = 22;
            this.btnRemoveRelationship.Text = "Remove relationship";
            this.btnRemoveRelationship.UseVisualStyleBackColor = false;
            this.btnRemoveRelationship.Click += new System.EventHandler(this.btnRemoveRelationship_Click);
            // 
            // btnCancelRelationship
            // 
            this.btnCancelRelationship.AutoSize = true;
            this.btnCancelRelationship.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelRelationship.Location = new System.Drawing.Point(331, 310);
            this.btnCancelRelationship.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelRelationship.Name = "btnCancelRelationship";
            this.btnCancelRelationship.Size = new System.Drawing.Size(261, 55);
            this.btnCancelRelationship.TabIndex = 21;
            this.btnCancelRelationship.Text = "Cancel";
            this.btnCancelRelationship.UseVisualStyleBackColor = false;
            this.btnCancelRelationship.Click += new System.EventHandler(this.btnCancelRelationship_Click);
            // 
            // btnAddNewRelationship
            // 
            this.btnAddNewRelationship.AutoSize = true;
            this.btnAddNewRelationship.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddNewRelationship.Location = new System.Drawing.Point(33, 310);
            this.btnAddNewRelationship.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNewRelationship.Name = "btnAddNewRelationship";
            this.btnAddNewRelationship.Size = new System.Drawing.Size(261, 55);
            this.btnAddNewRelationship.TabIndex = 20;
            this.btnAddNewRelationship.Text = "Add relationship";
            this.btnAddNewRelationship.UseVisualStyleBackColor = false;
            this.btnAddNewRelationship.Click += new System.EventHandler(this.btnAddNewRelationship_Click);
            // 
            // labelExistingRelationshipMain
            // 
            this.labelExistingRelationshipMain.AutoSize = true;
            this.labelExistingRelationshipMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExistingRelationshipMain.Location = new System.Drawing.Point(28, 424);
            this.labelExistingRelationshipMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExistingRelationshipMain.Name = "labelExistingRelationshipMain";
            this.labelExistingRelationshipMain.Size = new System.Drawing.Size(246, 29);
            this.labelExistingRelationshipMain.TabIndex = 19;
            this.labelExistingRelationshipMain.Text = "Existing relationships:";
            // 
            // lbxRelationshipsMain
            // 
            this.lbxRelationshipsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxRelationshipsMain.FormattingEnabled = true;
            this.lbxRelationshipsMain.HorizontalScrollbar = true;
            this.lbxRelationshipsMain.ItemHeight = 29;
            this.lbxRelationshipsMain.Location = new System.Drawing.Point(33, 471);
            this.lbxRelationshipsMain.Margin = new System.Windows.Forms.Padding(2);
            this.lbxRelationshipsMain.Name = "lbxRelationshipsMain";
            this.lbxRelationshipsMain.Size = new System.Drawing.Size(559, 178);
            this.lbxRelationshipsMain.TabIndex = 18;
            // 
            // cbxOtherAnimalRelationship
            // 
            this.cbxOtherAnimalRelationship.FormattingEnabled = true;
            this.cbxOtherAnimalRelationship.Location = new System.Drawing.Point(33, 239);
            this.cbxOtherAnimalRelationship.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOtherAnimalRelationship.Name = "cbxOtherAnimalRelationship";
            this.cbxOtherAnimalRelationship.Size = new System.Drawing.Size(365, 37);
            this.cbxOtherAnimalRelationship.TabIndex = 16;
            // 
            // cbxRelationshipType
            // 
            this.cbxRelationshipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRelationshipType.FormattingEnabled = true;
            this.cbxRelationshipType.Items.AddRange(new object[] {
            "Parent of",
            "Child of",
            "Mate of"});
            this.cbxRelationshipType.Location = new System.Drawing.Point(33, 139);
            this.cbxRelationshipType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRelationshipType.Name = "cbxRelationshipType";
            this.cbxRelationshipType.Size = new System.Drawing.Size(365, 37);
            this.cbxRelationshipType.TabIndex = 14;
            this.cbxRelationshipType.SelectedIndexChanged += new System.EventHandler(this.cbxRelationshipType_SelectedIndexChanged);
            // 
            // labelRelationshipTypeMain
            // 
            this.labelRelationshipTypeMain.AutoSize = true;
            this.labelRelationshipTypeMain.Location = new System.Drawing.Point(28, 98);
            this.labelRelationshipTypeMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRelationshipTypeMain.Name = "labelRelationshipTypeMain";
            this.labelRelationshipTypeMain.Size = new System.Drawing.Size(204, 29);
            this.labelRelationshipTypeMain.TabIndex = 17;
            this.labelRelationshipTypeMain.Text = "Relationship type:";
            // 
            // labelOtherAnimalMain
            // 
            this.labelOtherAnimalMain.AutoSize = true;
            this.labelOtherAnimalMain.Location = new System.Drawing.Point(28, 200);
            this.labelOtherAnimalMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtherAnimalMain.Name = "labelOtherAnimalMain";
            this.labelOtherAnimalMain.Size = new System.Drawing.Size(158, 29);
            this.labelOtherAnimalMain.TabIndex = 15;
            this.labelOtherAnimalMain.Text = "Other Animal:";
            // 
            // tbxMainAnimalRelationship
            // 
            this.tbxMainAnimalRelationship.Location = new System.Drawing.Point(202, 41);
            this.tbxMainAnimalRelationship.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxMainAnimalRelationship.Name = "tbxMainAnimalRelationship";
            this.tbxMainAnimalRelationship.ReadOnly = true;
            this.tbxMainAnimalRelationship.Size = new System.Drawing.Size(390, 35);
            this.tbxMainAnimalRelationship.TabIndex = 13;
            // 
            // labelMainAnimalRelationship
            // 
            this.labelMainAnimalRelationship.AutoSize = true;
            this.labelMainAnimalRelationship.Location = new System.Drawing.Point(28, 44);
            this.labelMainAnimalRelationship.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelMainAnimalRelationship.Name = "labelMainAnimalRelationship";
            this.labelMainAnimalRelationship.Size = new System.Drawing.Size(92, 29);
            this.labelMainAnimalRelationship.TabIndex = 12;
            this.labelMainAnimalRelationship.Text = "Animal:";
            // 
            // groupBoxAnimalTransfer
            // 
            this.groupBoxAnimalTransfer.Controls.Add(this.tbxAnimalTransferPhone);
            this.groupBoxAnimalTransfer.Controls.Add(this.labelAnimeTransferPhone);
            this.groupBoxAnimalTransfer.Controls.Add(this.labelEndDate);
            this.groupBoxAnimalTransfer.Controls.Add(this.dtpEndDate);
            this.groupBoxAnimalTransfer.Controls.Add(this.dtpStartDate);
            this.groupBoxAnimalTransfer.Controls.Add(this.labelStartDate);
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
            this.groupBoxAnimalTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAnimalTransfer.Location = new System.Drawing.Point(29, 18);
            this.groupBoxAnimalTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxAnimalTransfer.Name = "groupBoxAnimalTransfer";
            this.groupBoxAnimalTransfer.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxAnimalTransfer.Size = new System.Drawing.Size(630, 750);
            this.groupBoxAnimalTransfer.TabIndex = 45;
            this.groupBoxAnimalTransfer.TabStop = false;
            this.groupBoxAnimalTransfer.Text = "Animal transfer";
            // 
            // tbxAnimalTransferPhone
            // 
            this.tbxAnimalTransferPhone.Location = new System.Drawing.Point(205, 266);
            this.tbxAnimalTransferPhone.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxAnimalTransferPhone.Name = "tbxAnimalTransferPhone";
            this.tbxAnimalTransferPhone.Size = new System.Drawing.Size(390, 35);
            this.tbxAnimalTransferPhone.TabIndex = 24;
            // 
            // labelAnimeTransferPhone
            // 
            this.labelAnimeTransferPhone.AutoSize = true;
            this.labelAnimeTransferPhone.Location = new System.Drawing.Point(17, 269);
            this.labelAnimeTransferPhone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAnimeTransferPhone.Name = "labelAnimeTransferPhone";
            this.labelAnimeTransferPhone.Size = new System.Drawing.Size(177, 29);
            this.labelAnimeTransferPhone.TabIndex = 23;
            this.labelAnimeTransferPhone.Text = "Phone number:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(17, 376);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(115, 29);
            this.labelEndDate.TabIndex = 22;
            this.labelEndDate.Text = "End date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(205, 370);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(390, 35);
            this.dtpEndDate.TabIndex = 21;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(205, 318);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(390, 35);
            this.dtpStartDate.TabIndex = 20;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(17, 324);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(121, 29);
            this.labelStartDate.TabIndex = 19;
            this.labelStartDate.Text = "Start date:";
            // 
            // tbxComments
            // 
            this.tbxComments.Location = new System.Drawing.Point(205, 424);
            this.tbxComments.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxComments.Multiline = true;
            this.tbxComments.Name = "tbxComments";
            this.tbxComments.Size = new System.Drawing.Size(390, 179);
            this.tbxComments.TabIndex = 18;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(17, 427);
            this.labelComments.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(135, 29);
            this.labelComments.TabIndex = 17;
            this.labelComments.Text = "Comments:";
            // 
            // btnCancelTransfer
            // 
            this.btnCancelTransfer.AutoSize = true;
            this.btnCancelTransfer.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelTransfer.Location = new System.Drawing.Point(334, 649);
            this.btnCancelTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelTransfer.Name = "btnCancelTransfer";
            this.btnCancelTransfer.Size = new System.Drawing.Size(261, 60);
            this.btnCancelTransfer.TabIndex = 16;
            this.btnCancelTransfer.Text = "Cancel";
            this.btnCancelTransfer.UseVisualStyleBackColor = false;
            this.btnCancelTransfer.Click += new System.EventHandler(this.btnCancelTransfer_Click);
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.AutoSize = true;
            this.btnConfirmTransfer.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(22, 649);
            this.btnConfirmTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(261, 60);
            this.btnConfirmTransfer.TabIndex = 15;
            this.btnConfirmTransfer.Text = "Confirm";
            this.btnConfirmTransfer.UseVisualStyleBackColor = false;
            this.btnConfirmTransfer.Click += new System.EventHandler(this.btnConfirmTransfer_Click);
            // 
            // tbxAnimalTransfer
            // 
            this.tbxAnimalTransfer.Location = new System.Drawing.Point(205, 41);
            this.tbxAnimalTransfer.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxAnimalTransfer.Name = "tbxAnimalTransfer";
            this.tbxAnimalTransfer.ReadOnly = true;
            this.tbxAnimalTransfer.Size = new System.Drawing.Size(390, 35);
            this.tbxAnimalTransfer.TabIndex = 11;
            // 
            // tbxAddressTransfer
            // 
            this.tbxAddressTransfer.Location = new System.Drawing.Point(205, 147);
            this.tbxAddressTransfer.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxAddressTransfer.Multiline = true;
            this.tbxAddressTransfer.Name = "tbxAddressTransfer";
            this.tbxAddressTransfer.Size = new System.Drawing.Size(390, 102);
            this.tbxAddressTransfer.TabIndex = 10;
            // 
            // labelAnimalTransfer
            // 
            this.labelAnimalTransfer.AutoSize = true;
            this.labelAnimalTransfer.Location = new System.Drawing.Point(17, 44);
            this.labelAnimalTransfer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAnimalTransfer.Name = "labelAnimalTransfer";
            this.labelAnimalTransfer.Size = new System.Drawing.Size(92, 29);
            this.labelAnimalTransfer.TabIndex = 9;
            this.labelAnimalTransfer.Text = "Animal:";
            // 
            // labelAdressTransfer
            // 
            this.labelAdressTransfer.AutoSize = true;
            this.labelAdressTransfer.Location = new System.Drawing.Point(17, 150);
            this.labelAdressTransfer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAdressTransfer.Name = "labelAdressTransfer";
            this.labelAdressTransfer.Size = new System.Drawing.Size(154, 29);
            this.labelAdressTransfer.TabIndex = 8;
            this.labelAdressTransfer.Text = "Zoo address:";
            // 
            // tbxZooNameTransfer
            // 
            this.tbxZooNameTransfer.Location = new System.Drawing.Point(205, 95);
            this.tbxZooNameTransfer.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxZooNameTransfer.Name = "tbxZooNameTransfer";
            this.tbxZooNameTransfer.Size = new System.Drawing.Size(390, 35);
            this.tbxZooNameTransfer.TabIndex = 7;
            // 
            // labelZooNameTransfer
            // 
            this.labelZooNameTransfer.AutoSize = true;
            this.labelZooNameTransfer.Location = new System.Drawing.Point(17, 98);
            this.labelZooNameTransfer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelZooNameTransfer.Name = "labelZooNameTransfer";
            this.labelZooNameTransfer.Size = new System.Drawing.Size(127, 29);
            this.labelZooNameTransfer.TabIndex = 6;
            this.labelZooNameTransfer.Text = "Zoo name:";
            // 
            // groupBoxSearchAnimal
            // 
            this.groupBoxSearchAnimal.Controls.Add(this.tbxAge);
            this.groupBoxSearchAnimal.Controls.Add(this.labelAgeSearch);
            this.groupBoxSearchAnimal.Controls.Add(this.btnDisplayAllAnimals);
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
            this.groupBoxSearchAnimal.Controls.Add(this.labelOrigin);
            this.groupBoxSearchAnimal.Controls.Add(this.labelSpecies);
            this.groupBoxSearchAnimal.Controls.Add(this.labelName);
            this.groupBoxSearchAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(29, 18);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(630, 581);
            this.groupBoxSearchAnimal.TabIndex = 12;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(252, 291);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(163, 35);
            this.tbxAge.TabIndex = 38;
            // 
            // labelAgeSearch
            // 
            this.labelAgeSearch.AutoSize = true;
            this.labelAgeSearch.Location = new System.Drawing.Point(32, 297);
            this.labelAgeSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgeSearch.Name = "labelAgeSearch";
            this.labelAgeSearch.Size = new System.Drawing.Size(62, 29);
            this.labelAgeSearch.TabIndex = 37;
            this.labelAgeSearch.Text = "Age:";
            // 
            // btnDisplayAllAnimals
            // 
            this.btnDisplayAllAnimals.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDisplayAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAllAnimals.Location = new System.Drawing.Point(172, 510);
            this.btnDisplayAllAnimals.Name = "btnDisplayAllAnimals";
            this.btnDisplayAllAnimals.Size = new System.Drawing.Size(288, 56);
            this.btnDisplayAllAnimals.TabIndex = 8;
            this.btnDisplayAllAnimals.Text = "Display all animals";
            this.btnDisplayAllAnimals.UseVisualStyleBackColor = false;
            this.btnDisplayAllAnimals.Click += new System.EventHandler(this.btnDisplayAllAnimals_Click);
            // 
            // cbTransferred
            // 
            this.cbTransferred.AutoSize = true;
            this.cbTransferred.Location = new System.Drawing.Point(430, 243);
            this.cbTransferred.Name = "cbTransferred";
            this.cbTransferred.Size = new System.Drawing.Size(158, 33);
            this.cbTransferred.TabIndex = 36;
            this.cbTransferred.Text = "Transferred";
            this.cbTransferred.UseVisualStyleBackColor = true;
            // 
            // cbAvailable
            // 
            this.cbAvailable.AutoSize = true;
            this.cbAvailable.Location = new System.Drawing.Point(252, 243);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(130, 33);
            this.cbAvailable.TabIndex = 35;
            this.cbAvailable.Text = "Available";
            this.cbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(252, 198);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(84, 33);
            this.rbtnMale.TabIndex = 34;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(430, 198);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(113, 33);
            this.rbtnFemale.TabIndex = 33;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // labelGenderAddAnimal
            // 
            this.labelGenderAddAnimal.AutoSize = true;
            this.labelGenderAddAnimal.Location = new System.Drawing.Point(32, 200);
            this.labelGenderAddAnimal.Name = "labelGenderAddAnimal";
            this.labelGenderAddAnimal.Size = new System.Drawing.Size(100, 29);
            this.labelGenderAddAnimal.TabIndex = 32;
            this.labelGenderAddAnimal.Text = "Gender:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClearAll.Location = new System.Drawing.Point(349, 431);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(239, 56);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear fields";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.AutoSize = true;
            this.btnSearchAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearchAnimal.Location = new System.Drawing.Point(37, 431);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(239, 56);
            this.btnSearchAnimal.TabIndex = 14;
            this.btnSearchAnimal.Text = "Search";
            this.btnSearchAnimal.UseVisualStyleBackColor = false;
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // cbxEndangerment
            // 
            this.cbxEndangerment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndangerment.FormattingEnabled = true;
            this.cbxEndangerment.Location = new System.Drawing.Point(252, 346);
            this.cbxEndangerment.Name = "cbxEndangerment";
            this.cbxEndangerment.Size = new System.Drawing.Size(336, 37);
            this.cbxEndangerment.TabIndex = 13;
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Location = new System.Drawing.Point(252, 144);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(336, 37);
            this.cbxOrigin.TabIndex = 9;
            // 
            // labelEndangerment
            // 
            this.labelEndangerment.AutoSize = true;
            this.labelEndangerment.Location = new System.Drawing.Point(32, 349);
            this.labelEndangerment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndangerment.Name = "labelEndangerment";
            this.labelEndangerment.Size = new System.Drawing.Size(177, 29);
            this.labelEndangerment.TabIndex = 8;
            this.labelEndangerment.Text = "Endangerment:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(32, 248);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(85, 29);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status:";
            // 
            // tbxSpecies
            // 
            this.tbxSpecies.Location = new System.Drawing.Point(252, 92);
            this.tbxSpecies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSpecies.Name = "tbxSpecies";
            this.tbxSpecies.Size = new System.Drawing.Size(336, 35);
            this.tbxSpecies.TabIndex = 6;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(252, 41);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(336, 35);
            this.tbxName.TabIndex = 5;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(32, 147);
            this.labelOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(121, 29);
            this.labelOrigin.TabIndex = 2;
            this.labelOrigin.Text = "Continent:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(32, 95);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(107, 29);
            this.labelSpecies.TabIndex = 1;
            this.labelSpecies.Text = "Species:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // btnTransferAnimal
            // 
            this.btnTransferAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTransferAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransferAnimal.Location = new System.Drawing.Point(1419, 809);
            this.btnTransferAnimal.Name = "btnTransferAnimal";
            this.btnTransferAnimal.Size = new System.Drawing.Size(245, 59);
            this.btnTransferAnimal.TabIndex = 8;
            this.btnTransferAnimal.Text = "Transfer animal";
            this.btnTransferAnimal.UseVisualStyleBackColor = false;
            this.btnTransferAnimal.Click += new System.EventHandler(this.btnTransferAnimal_Click);
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
            this.lvwAnimals.FullRowSelect = true;
            this.lvwAnimals.Location = new System.Drawing.Point(689, 30);
            this.lvwAnimals.Name = "lvwAnimals";
            this.lvwAnimals.Size = new System.Drawing.Size(1058, 738);
            this.lvwAnimals.TabIndex = 7;
            this.lvwAnimals.UseCompatibleStateImageBehavior = false;
            this.lvwAnimals.View = System.Windows.Forms.View.Details;
            this.lvwAnimals.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwAnimals_MouseDoubleClick);
            // 
            // colAnimalID
            // 
            this.colAnimalID.Text = "ID";
            this.colAnimalID.Width = 55;
            // 
            // colAnimalName
            // 
            this.colAnimalName.Text = "Name";
            this.colAnimalName.Width = 176;
            // 
            // colSpecies
            // 
            this.colSpecies.Text = "Species";
            this.colSpecies.Width = 176;
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            this.colGender.Width = 175;
            // 
            // colContinent
            // 
            this.colContinent.Text = "Continent";
            this.colContinent.Width = 182;
            // 
            // colEnclosure
            // 
            this.colEnclosure.Text = "Enclosure";
            this.colEnclosure.Width = 149;
            // 
            // colAvailability
            // 
            this.colAvailability.Text = "Availability";
            this.colAvailability.Width = 185;
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRelationship.Location = new System.Drawing.Point(1111, 809);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(245, 59);
            this.btnAddRelationship.TabIndex = 6;
            this.btnAddRelationship.Text = "Add relationship";
            this.btnAddRelationship.UseVisualStyleBackColor = false;
            this.btnAddRelationship.Click += new System.EventHandler(this.btnAddRelationship_Click);
            // 
            // btnEditAnimal
            // 
            this.btnEditAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditAnimal.Location = new System.Drawing.Point(803, 809);
            this.btnEditAnimal.Name = "btnEditAnimal";
            this.btnEditAnimal.Size = new System.Drawing.Size(245, 59);
            this.btnEditAnimal.TabIndex = 5;
            this.btnEditAnimal.Text = "Edit animal";
            this.btnEditAnimal.UseVisualStyleBackColor = false;
            this.btnEditAnimal.Click += new System.EventHandler(this.btnEditAnimal_Click);
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
            this.tabAnimalHistory.Location = new System.Drawing.Point(4, 36);
            this.tabAnimalHistory.Name = "tabAnimalHistory";
            this.tabAnimalHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimalHistory.Size = new System.Drawing.Size(1793, 907);
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
            this.btnDisplayHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.rbtnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnAge.Location = new System.Drawing.Point(1481, 24);
            this.rbtnAge.Name = "rbtnAge";
            this.rbtnAge.Size = new System.Drawing.Size(121, 30);
            this.rbtnAge.TabIndex = 41;
            this.rbtnAge.Text = "BirthDate";
            this.rbtnAge.UseVisualStyleBackColor = true;
            // 
            // rbtnContinent
            // 
            this.rbtnContinent.AutoSize = true;
            this.rbtnContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnContinent.Location = new System.Drawing.Point(1387, 25);
            this.rbtnContinent.Name = "rbtnContinent";
            this.rbtnContinent.Size = new System.Drawing.Size(88, 30);
            this.rbtnContinent.TabIndex = 40;
            this.rbtnContinent.Text = "Origin";
            this.rbtnContinent.UseVisualStyleBackColor = true;
            // 
            // rbtnSpecies
            // 
            this.rbtnSpecies.AutoSize = true;
            this.rbtnSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.rbtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.labelSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSortBy.Location = new System.Drawing.Point(1058, 28);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(87, 26);
            this.labelSortBy.TabIndex = 37;
            this.labelSortBy.Text = "Sort by:";
            // 
            // labelAllAnimals
            // 
            this.labelAllAnimals.AutoSize = true;
            this.labelAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllAnimals.Location = new System.Drawing.Point(18, 17);
            this.labelAllAnimals.Name = "labelAllAnimals";
            this.labelAllAnimals.Size = new System.Drawing.Size(155, 31);
            this.labelAllAnimals.TabIndex = 35;
            this.labelAllAnimals.Text = "All animals";
            // 
            // tabPageAddAnimal
            // 
            this.tabPageAddAnimal.Controls.Add(this.groupBoxAddAnimal);
            this.tabPageAddAnimal.Controls.Add(this.lvwRecentlyAddedAnimals);
            this.tabPageAddAnimal.Controls.Add(this.btnDeleteRelationship);
            this.tabPageAddAnimal.Controls.Add(this.labelExistingRelationships);
            this.tabPageAddAnimal.Controls.Add(this.buttonAddRelationshipAddAnimal);
            this.tabPageAddAnimal.Controls.Add(this.labelSelectedAnimal);
            this.tabPageAddAnimal.Controls.Add(this.lbxDisplayAnimalRelationships);
            this.tabPageAddAnimal.Controls.Add(this.tbxAnimalForRelationship);
            this.tabPageAddAnimal.Controls.Add(this.labelRecentlyAddedAnimals);
            this.tabPageAddAnimal.Controls.Add(this.groupBoxRelationships);
            this.tabPageAddAnimal.Controls.Add(this.btnConfirmAnimalCreation);
            this.tabPageAddAnimal.Controls.Add(this.btnCancelAnimalCreation);
            this.tabPageAddAnimal.Location = new System.Drawing.Point(4, 36);
            this.tabPageAddAnimal.Name = "tabPageAddAnimal";
            this.tabPageAddAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddAnimal.Size = new System.Drawing.Size(1793, 907);
            this.tabPageAddAnimal.TabIndex = 2;
            this.tabPageAddAnimal.Text = "Add Animal";
            this.tabPageAddAnimal.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddAnimal
            // 
            this.groupBoxAddAnimal.Controls.Add(this.labelDateFormat);
            this.groupBoxAddAnimal.Controls.Add(this.labelAddAnimalBirthDate);
            this.groupBoxAddAnimal.Controls.Add(this.maskedtbxBirthDateAddAnimalForm);
            this.groupBoxAddAnimal.Controls.Add(this.rbtnMaleAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.rbtnFemaleAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.labelGenderAdd);
            this.groupBoxAddAnimal.Controls.Add(this.nudEnclosureAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.labelEnclosureAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.tbxAdditionalCommentsAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.labelAdditionalCommentsAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.cbxEndangermentAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.cbxOriginAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.labelAddAnimalEndangerment);
            this.groupBoxAddAnimal.Controls.Add(this.tbxSpeciesAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.tbxNameAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.labelAddAnimalOrigin);
            this.groupBoxAddAnimal.Controls.Add(this.labelAddAnimalSpecies);
            this.groupBoxAddAnimal.Controls.Add(this.labelAddAnimalName);
            this.groupBoxAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAddAnimal.Location = new System.Drawing.Point(41, 29);
            this.groupBoxAddAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxAddAnimal.Name = "groupBoxAddAnimal";
            this.groupBoxAddAnimal.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxAddAnimal.Size = new System.Drawing.Size(630, 733);
            this.groupBoxAddAnimal.TabIndex = 43;
            this.groupBoxAddAnimal.TabStop = false;
            this.groupBoxAddAnimal.Text = "Animal details:";
            // 
            // labelDateFormat
            // 
            this.labelDateFormat.AutoSize = true;
            this.labelDateFormat.Location = new System.Drawing.Point(359, 269);
            this.labelDateFormat.Name = "labelDateFormat";
            this.labelDateFormat.Size = new System.Drawing.Size(155, 29);
            this.labelDateFormat.TabIndex = 39;
            this.labelDateFormat.Text = "(mm/dd/yyyy)";
            // 
            // labelAddAnimalBirthDate
            // 
            this.labelAddAnimalBirthDate.AutoSize = true;
            this.labelAddAnimalBirthDate.Location = new System.Drawing.Point(17, 269);
            this.labelAddAnimalBirthDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalBirthDate.Name = "labelAddAnimalBirthDate";
            this.labelAddAnimalBirthDate.Size = new System.Drawing.Size(148, 29);
            this.labelAddAnimalBirthDate.TabIndex = 38;
            this.labelAddAnimalBirthDate.Text = "Date of birth:";
            // 
            // maskedtbxBirthDateAddAnimalForm
            // 
            this.maskedtbxBirthDateAddAnimalForm.Location = new System.Drawing.Point(205, 266);
            this.maskedtbxBirthDateAddAnimalForm.Mask = "00/00/0000";
            this.maskedtbxBirthDateAddAnimalForm.Name = "maskedtbxBirthDateAddAnimalForm";
            this.maskedtbxBirthDateAddAnimalForm.ResetOnSpace = false;
            this.maskedtbxBirthDateAddAnimalForm.Size = new System.Drawing.Size(129, 35);
            this.maskedtbxBirthDateAddAnimalForm.TabIndex = 35;
            // 
            // rbtnMaleAddAnimal
            // 
            this.rbtnMaleAddAnimal.AutoSize = true;
            this.rbtnMaleAddAnimal.Location = new System.Drawing.Point(205, 218);
            this.rbtnMaleAddAnimal.Name = "rbtnMaleAddAnimal";
            this.rbtnMaleAddAnimal.Size = new System.Drawing.Size(84, 33);
            this.rbtnMaleAddAnimal.TabIndex = 31;
            this.rbtnMaleAddAnimal.TabStop = true;
            this.rbtnMaleAddAnimal.Text = "Male";
            this.rbtnMaleAddAnimal.UseVisualStyleBackColor = true;
            // 
            // rbtnFemaleAddAnimal
            // 
            this.rbtnFemaleAddAnimal.AutoSize = true;
            this.rbtnFemaleAddAnimal.Location = new System.Drawing.Point(315, 218);
            this.rbtnFemaleAddAnimal.Name = "rbtnFemaleAddAnimal";
            this.rbtnFemaleAddAnimal.Size = new System.Drawing.Size(113, 33);
            this.rbtnFemaleAddAnimal.TabIndex = 30;
            this.rbtnFemaleAddAnimal.TabStop = true;
            this.rbtnFemaleAddAnimal.Text = "Female";
            this.rbtnFemaleAddAnimal.UseVisualStyleBackColor = true;
            // 
            // labelGenderAdd
            // 
            this.labelGenderAdd.AutoSize = true;
            this.labelGenderAdd.Location = new System.Drawing.Point(16, 220);
            this.labelGenderAdd.Name = "labelGenderAdd";
            this.labelGenderAdd.Size = new System.Drawing.Size(100, 29);
            this.labelGenderAdd.TabIndex = 29;
            this.labelGenderAdd.Text = "Gender:";
            // 
            // nudEnclosureAddAnimal
            // 
            this.nudEnclosureAddAnimal.Location = new System.Drawing.Point(205, 378);
            this.nudEnclosureAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nudEnclosureAddAnimal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnclosureAddAnimal.Name = "nudEnclosureAddAnimal";
            this.nudEnclosureAddAnimal.Size = new System.Drawing.Size(129, 35);
            this.nudEnclosureAddAnimal.TabIndex = 17;
            this.nudEnclosureAddAnimal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEnclosureAddAnimal
            // 
            this.labelEnclosureAddAnimal.AutoSize = true;
            this.labelEnclosureAddAnimal.Location = new System.Drawing.Point(16, 380);
            this.labelEnclosureAddAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnclosureAddAnimal.Name = "labelEnclosureAddAnimal";
            this.labelEnclosureAddAnimal.Size = new System.Drawing.Size(154, 29);
            this.labelEnclosureAddAnimal.TabIndex = 16;
            this.labelEnclosureAddAnimal.Text = "Enclosure nr:";
            // 
            // tbxAdditionalCommentsAddAnimal
            // 
            this.tbxAdditionalCommentsAddAnimal.Location = new System.Drawing.Point(21, 483);
            this.tbxAdditionalCommentsAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbxAdditionalCommentsAddAnimal.Multiline = true;
            this.tbxAdditionalCommentsAddAnimal.Name = "tbxAdditionalCommentsAddAnimal";
            this.tbxAdditionalCommentsAddAnimal.Size = new System.Drawing.Size(581, 220);
            this.tbxAdditionalCommentsAddAnimal.TabIndex = 15;
            // 
            // labelAdditionalCommentsAddAnimal
            // 
            this.labelAdditionalCommentsAddAnimal.AutoSize = true;
            this.labelAdditionalCommentsAddAnimal.Location = new System.Drawing.Point(16, 439);
            this.labelAdditionalCommentsAddAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdditionalCommentsAddAnimal.Name = "labelAdditionalCommentsAddAnimal";
            this.labelAdditionalCommentsAddAnimal.Size = new System.Drawing.Size(243, 29);
            this.labelAdditionalCommentsAddAnimal.TabIndex = 14;
            this.labelAdditionalCommentsAddAnimal.Text = "Additional comments:";
            // 
            // cbxEndangermentAddAnimal
            // 
            this.cbxEndangermentAddAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndangermentAddAnimal.FormattingEnabled = true;
            this.cbxEndangermentAddAnimal.Location = new System.Drawing.Point(205, 320);
            this.cbxEndangermentAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxEndangermentAddAnimal.Name = "cbxEndangermentAddAnimal";
            this.cbxEndangermentAddAnimal.Size = new System.Drawing.Size(397, 37);
            this.cbxEndangermentAddAnimal.TabIndex = 13;
            // 
            // cbxOriginAddAnimal
            // 
            this.cbxOriginAddAnimal.FormattingEnabled = true;
            this.cbxOriginAddAnimal.Location = new System.Drawing.Point(205, 163);
            this.cbxOriginAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxOriginAddAnimal.Name = "cbxOriginAddAnimal";
            this.cbxOriginAddAnimal.Size = new System.Drawing.Size(397, 37);
            this.cbxOriginAddAnimal.TabIndex = 9;
            // 
            // labelAddAnimalEndangerment
            // 
            this.labelAddAnimalEndangerment.AutoSize = true;
            this.labelAddAnimalEndangerment.Location = new System.Drawing.Point(16, 323);
            this.labelAddAnimalEndangerment.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalEndangerment.Name = "labelAddAnimalEndangerment";
            this.labelAddAnimalEndangerment.Size = new System.Drawing.Size(177, 29);
            this.labelAddAnimalEndangerment.TabIndex = 8;
            this.labelAddAnimalEndangerment.Text = "Endangerment:";
            // 
            // tbxSpeciesAddAnimal
            // 
            this.tbxSpeciesAddAnimal.Location = new System.Drawing.Point(205, 106);
            this.tbxSpeciesAddAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxSpeciesAddAnimal.Name = "tbxSpeciesAddAnimal";
            this.tbxSpeciesAddAnimal.Size = new System.Drawing.Size(397, 35);
            this.tbxSpeciesAddAnimal.TabIndex = 6;
            // 
            // tbxNameAddAnimal
            // 
            this.tbxNameAddAnimal.Location = new System.Drawing.Point(205, 48);
            this.tbxNameAddAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxNameAddAnimal.Name = "tbxNameAddAnimal";
            this.tbxNameAddAnimal.Size = new System.Drawing.Size(397, 35);
            this.tbxNameAddAnimal.TabIndex = 5;
            // 
            // labelAddAnimalOrigin
            // 
            this.labelAddAnimalOrigin.AutoSize = true;
            this.labelAddAnimalOrigin.Location = new System.Drawing.Point(16, 166);
            this.labelAddAnimalOrigin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalOrigin.Name = "labelAddAnimalOrigin";
            this.labelAddAnimalOrigin.Size = new System.Drawing.Size(85, 29);
            this.labelAddAnimalOrigin.TabIndex = 2;
            this.labelAddAnimalOrigin.Text = "Origin:";
            // 
            // labelAddAnimalSpecies
            // 
            this.labelAddAnimalSpecies.AutoSize = true;
            this.labelAddAnimalSpecies.Location = new System.Drawing.Point(16, 109);
            this.labelAddAnimalSpecies.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalSpecies.Name = "labelAddAnimalSpecies";
            this.labelAddAnimalSpecies.Size = new System.Drawing.Size(107, 29);
            this.labelAddAnimalSpecies.TabIndex = 1;
            this.labelAddAnimalSpecies.Text = "Species:";
            // 
            // labelAddAnimalName
            // 
            this.labelAddAnimalName.AutoSize = true;
            this.labelAddAnimalName.Location = new System.Drawing.Point(16, 51);
            this.labelAddAnimalName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalName.Name = "labelAddAnimalName";
            this.labelAddAnimalName.Size = new System.Drawing.Size(84, 29);
            this.labelAddAnimalName.TabIndex = 0;
            this.labelAddAnimalName.Text = "Name:";
            // 
            // lvwRecentlyAddedAnimals
            // 
            this.lvwRecentlyAddedAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameRecentlyAdded,
            this.columnSpeciesRecentlyAdded,
            this.columnGenderRecentlyAdded,
            this.columnContinentRecentlyAdded,
            this.columnEnclosureRecentlyAdded});
            this.lvwRecentlyAddedAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwRecentlyAddedAnimals.Location = new System.Drawing.Point(733, 78);
            this.lvwRecentlyAddedAnimals.Name = "lvwRecentlyAddedAnimals";
            this.lvwRecentlyAddedAnimals.Size = new System.Drawing.Size(1002, 236);
            this.lvwRecentlyAddedAnimals.TabIndex = 38;
            this.lvwRecentlyAddedAnimals.UseCompatibleStateImageBehavior = false;
            this.lvwRecentlyAddedAnimals.View = System.Windows.Forms.View.Details;
            // 
            // columnNameRecentlyAdded
            // 
            this.columnNameRecentlyAdded.Text = "Name";
            this.columnNameRecentlyAdded.Width = 206;
            // 
            // columnSpeciesRecentlyAdded
            // 
            this.columnSpeciesRecentlyAdded.Text = "Species";
            this.columnSpeciesRecentlyAdded.Width = 203;
            // 
            // columnGenderRecentlyAdded
            // 
            this.columnGenderRecentlyAdded.Text = "Gender";
            this.columnGenderRecentlyAdded.Width = 227;
            // 
            // columnContinentRecentlyAdded
            // 
            this.columnContinentRecentlyAdded.Text = "Continent";
            this.columnContinentRecentlyAdded.Width = 183;
            // 
            // columnEnclosureRecentlyAdded
            // 
            this.columnEnclosureRecentlyAdded.Text = "Enclosure";
            this.columnEnclosureRecentlyAdded.Width = 175;
            // 
            // btnDeleteRelationship
            // 
            this.btnDeleteRelationship.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDeleteRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRelationship.Location = new System.Drawing.Point(821, 788);
            this.btnDeleteRelationship.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteRelationship.Name = "btnDeleteRelationship";
            this.btnDeleteRelationship.Size = new System.Drawing.Size(300, 70);
            this.btnDeleteRelationship.TabIndex = 2;
            this.btnDeleteRelationship.Text = "Delete relationship";
            this.btnDeleteRelationship.UseVisualStyleBackColor = false;
            // 
            // labelExistingRelationships
            // 
            this.labelExistingRelationships.AutoSize = true;
            this.labelExistingRelationships.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExistingRelationships.Location = new System.Drawing.Point(733, 510);
            this.labelExistingRelationships.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExistingRelationships.Name = "labelExistingRelationships";
            this.labelExistingRelationships.Size = new System.Drawing.Size(246, 29);
            this.labelExistingRelationships.TabIndex = 5;
            this.labelExistingRelationships.Text = "Existing relationships:";
            // 
            // buttonAddRelationshipAddAnimal
            // 
            this.buttonAddRelationshipAddAnimal.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonAddRelationshipAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddRelationshipAddAnimal.Location = new System.Drawing.Point(1378, 788);
            this.buttonAddRelationshipAddAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRelationshipAddAnimal.Name = "buttonAddRelationshipAddAnimal";
            this.buttonAddRelationshipAddAnimal.Size = new System.Drawing.Size(300, 70);
            this.buttonAddRelationshipAddAnimal.TabIndex = 1;
            this.buttonAddRelationshipAddAnimal.Text = "Add relationship";
            this.buttonAddRelationshipAddAnimal.UseVisualStyleBackColor = false;
            this.buttonAddRelationshipAddAnimal.Click += new System.EventHandler(this.buttonAddRelationshipAddAnimal_Click);
            // 
            // labelSelectedAnimal
            // 
            this.labelSelectedAnimal.AutoSize = true;
            this.labelSelectedAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedAnimal.Location = new System.Drawing.Point(733, 393);
            this.labelSelectedAnimal.Name = "labelSelectedAnimal";
            this.labelSelectedAnimal.Size = new System.Drawing.Size(192, 29);
            this.labelSelectedAnimal.TabIndex = 41;
            this.labelSelectedAnimal.Text = "Selected animal:";
            // 
            // lbxDisplayAnimalRelationships
            // 
            this.lbxDisplayAnimalRelationships.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxDisplayAnimalRelationships.FormattingEnabled = true;
            this.lbxDisplayAnimalRelationships.HorizontalScrollbar = true;
            this.lbxDisplayAnimalRelationships.ItemHeight = 29;
            this.lbxDisplayAnimalRelationships.Location = new System.Drawing.Point(738, 554);
            this.lbxDisplayAnimalRelationships.Margin = new System.Windows.Forms.Padding(2);
            this.lbxDisplayAnimalRelationships.Name = "lbxDisplayAnimalRelationships";
            this.lbxDisplayAnimalRelationships.Size = new System.Drawing.Size(487, 178);
            this.lbxDisplayAnimalRelationships.TabIndex = 1;
            // 
            // tbxAnimalForRelationship
            // 
            this.tbxAnimalForRelationship.Enabled = false;
            this.tbxAnimalForRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxAnimalForRelationship.Location = new System.Drawing.Point(738, 441);
            this.tbxAnimalForRelationship.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAnimalForRelationship.Multiline = true;
            this.tbxAnimalForRelationship.Name = "tbxAnimalForRelationship";
            this.tbxAnimalForRelationship.ReadOnly = true;
            this.tbxAnimalForRelationship.Size = new System.Drawing.Size(492, 37);
            this.tbxAnimalForRelationship.TabIndex = 4;
            // 
            // labelRecentlyAddedAnimals
            // 
            this.labelRecentlyAddedAnimals.AutoSize = true;
            this.labelRecentlyAddedAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecentlyAddedAnimals.Location = new System.Drawing.Point(733, 41);
            this.labelRecentlyAddedAnimals.Name = "labelRecentlyAddedAnimals";
            this.labelRecentlyAddedAnimals.Size = new System.Drawing.Size(276, 29);
            this.labelRecentlyAddedAnimals.TabIndex = 40;
            this.labelRecentlyAddedAnimals.Text = "Recently added animals:";
            // 
            // groupBoxRelationships
            // 
            this.groupBoxRelationships.Controls.Add(this.cbOtherAnimal);
            this.groupBoxRelationships.Controls.Add(this.cbRelationShipType);
            this.groupBoxRelationships.Controls.Add(this.labelRelationshipType);
            this.groupBoxRelationships.Controls.Add(this.labelOtherAnimal);
            this.groupBoxRelationships.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRelationships.Location = new System.Drawing.Point(1303, 393);
            this.groupBoxRelationships.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRelationships.Name = "groupBoxRelationships";
            this.groupBoxRelationships.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRelationships.Size = new System.Drawing.Size(432, 339);
            this.groupBoxRelationships.TabIndex = 39;
            this.groupBoxRelationships.TabStop = false;
            this.groupBoxRelationships.Text = "Add Relationship";
            // 
            // cbOtherAnimal
            // 
            this.cbOtherAnimal.FormattingEnabled = true;
            this.cbOtherAnimal.Location = new System.Drawing.Point(34, 224);
            this.cbOtherAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.cbOtherAnimal.Name = "cbOtherAnimal";
            this.cbOtherAnimal.Size = new System.Drawing.Size(365, 37);
            this.cbOtherAnimal.TabIndex = 2;
            // 
            // cbRelationShipType
            // 
            this.cbRelationShipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelationShipType.FormattingEnabled = true;
            this.cbRelationShipType.Items.AddRange(new object[] {
            "Parent of",
            "Child of",
            "Mate of"});
            this.cbRelationShipType.Location = new System.Drawing.Point(34, 101);
            this.cbRelationShipType.Margin = new System.Windows.Forms.Padding(2);
            this.cbRelationShipType.Name = "cbRelationShipType";
            this.cbRelationShipType.Size = new System.Drawing.Size(365, 37);
            this.cbRelationShipType.TabIndex = 1;
            this.cbRelationShipType.SelectedIndexChanged += new System.EventHandler(this.cbRelationShipType_SelectedIndexChanged);
            // 
            // labelRelationshipType
            // 
            this.labelRelationshipType.AutoSize = true;
            this.labelRelationshipType.Location = new System.Drawing.Point(29, 50);
            this.labelRelationshipType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRelationshipType.Name = "labelRelationshipType";
            this.labelRelationshipType.Size = new System.Drawing.Size(204, 29);
            this.labelRelationshipType.TabIndex = 2;
            this.labelRelationshipType.Text = "Relationship type:";
            // 
            // labelOtherAnimal
            // 
            this.labelOtherAnimal.AutoSize = true;
            this.labelOtherAnimal.Location = new System.Drawing.Point(29, 177);
            this.labelOtherAnimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtherAnimal.Name = "labelOtherAnimal";
            this.labelOtherAnimal.Size = new System.Drawing.Size(158, 29);
            this.labelOtherAnimal.TabIndex = 1;
            this.labelOtherAnimal.Text = "Other Animal:";
            // 
            // btnConfirmAnimalCreation
            // 
            this.btnConfirmAnimalCreation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConfirmAnimalCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmAnimalCreation.Location = new System.Drawing.Point(382, 787);
            this.btnConfirmAnimalCreation.Name = "btnConfirmAnimalCreation";
            this.btnConfirmAnimalCreation.Size = new System.Drawing.Size(289, 70);
            this.btnConfirmAnimalCreation.TabIndex = 36;
            this.btnConfirmAnimalCreation.Text = "Confirm";
            this.btnConfirmAnimalCreation.UseVisualStyleBackColor = false;
            this.btnConfirmAnimalCreation.Click += new System.EventHandler(this.btnConfirmAnimalCreation_Click);
            // 
            // btnCancelAnimalCreation
            // 
            this.btnCancelAnimalCreation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelAnimalCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAnimalCreation.Location = new System.Drawing.Point(41, 788);
            this.btnCancelAnimalCreation.Name = "btnCancelAnimalCreation";
            this.btnCancelAnimalCreation.Size = new System.Drawing.Size(289, 70);
            this.btnCancelAnimalCreation.TabIndex = 37;
            this.btnCancelAnimalCreation.Text = "Cancel";
            this.btnCancelAnimalCreation.UseVisualStyleBackColor = false;
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(879, 9);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(242, 51);
            this.labelTitleZooBazaar.TabIndex = 1;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // FormAnimalAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DesktopApplication.Properties.Resources.zooimg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1919, 1061);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlAnimals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnimalAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnimalAdministration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlAnimals.ResumeLayout(false);
            this.tabSearchAnimals.ResumeLayout(false);
            this.groupBoxEditAnimal.ResumeLayout(false);
            this.groupBoxEditAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudEnclosureEdit)).EndInit();
            this.groupBoxRelationship.ResumeLayout(false);
            this.groupBoxRelationship.PerformLayout();
            this.groupBoxAnimalTransfer.ResumeLayout(false);
            this.groupBoxAnimalTransfer.PerformLayout();
            this.groupBoxSearchAnimal.ResumeLayout(false);
            this.groupBoxSearchAnimal.PerformLayout();
            this.tabAnimalHistory.ResumeLayout(false);
            this.tabAnimalHistory.PerformLayout();
            this.tabPageAddAnimal.ResumeLayout(false);
            this.tabPageAddAnimal.PerformLayout();
            this.groupBoxAddAnimal.ResumeLayout(false);
            this.groupBoxAddAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnclosureAddAnimal)).EndInit();
            this.groupBoxRelationships.ResumeLayout(false);
            this.groupBoxRelationships.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAnimals;
        private System.Windows.Forms.TabPage tabSearchAnimals;
        private System.Windows.Forms.Label labelTitleZooBazaar;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.Button btnEditAnimal;
        private System.Windows.Forms.TabPage tabAnimalHistory;
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
        private System.Windows.Forms.TabPage tabPageAddAnimal;
        private System.Windows.Forms.Button btnConfirmAnimalCreation;
        private System.Windows.Forms.Button btnCancelAnimalCreation;
        private System.Windows.Forms.ListView lvwRecentlyAddedAnimals;
        private System.Windows.Forms.ColumnHeader columnNameRecentlyAdded;
        private System.Windows.Forms.ColumnHeader columnSpeciesRecentlyAdded;
        private System.Windows.Forms.Button btnDeleteRelationship;
        private System.Windows.Forms.Label labelExistingRelationships;
        private System.Windows.Forms.Button buttonAddRelationshipAddAnimal;
        private System.Windows.Forms.Label labelSelectedAnimal;
        private System.Windows.Forms.ListBox lbxDisplayAnimalRelationships;
        private System.Windows.Forms.TextBox tbxAnimalForRelationship;
        private System.Windows.Forms.Label labelRecentlyAddedAnimals;
        private System.Windows.Forms.GroupBox groupBoxRelationships;
        private System.Windows.Forms.ComboBox cbOtherAnimal;
        private System.Windows.Forms.ComboBox cbRelationShipType;
        private System.Windows.Forms.Label labelRelationshipType;
        private System.Windows.Forms.Label labelOtherAnimal;
        private System.Windows.Forms.ColumnHeader columnGenderRecentlyAdded;
        private System.Windows.Forms.ColumnHeader columnContinentRecentlyAdded;
        private System.Windows.Forms.ColumnHeader columnEnclosureRecentlyAdded;
        private System.Windows.Forms.GroupBox groupBoxSearchAnimal;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label labelAgeSearch;
        private System.Windows.Forms.Button btnDisplayAllAnimals;
        private System.Windows.Forms.CheckBox cbTransferred;
        private System.Windows.Forms.CheckBox cbAvailable;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label labelGenderAddAnimal;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSearchAnimal;
        private System.Windows.Forms.ComboBox cbxEndangerment;
        private System.Windows.Forms.ComboBox cbxOrigin;
        private System.Windows.Forms.Label labelEndangerment;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox tbxSpecies;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxEditAnimal;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Label labelDateFormatEdit;
        private System.Windows.Forms.Label labelDateofBirth;
        private System.Windows.Forms.Button btnCancelEditAnimalDetails;
        private System.Windows.Forms.MaskedTextBox maskedtbxDateOfBirthEdit;
        private System.Windows.Forms.RadioButton rbtnMaleEdit;
        private System.Windows.Forms.RadioButton rbtnFemaleEdit;
        private System.Windows.Forms.Label labelGenderEdit;
        private System.Windows.Forms.NumericUpDown numudEnclosureEdit;
        private System.Windows.Forms.Label labelEnclosureNrEdit;
        private System.Windows.Forms.TextBox tbxAdditionalCommentsEdit;
        private System.Windows.Forms.Label labelAdditionalCommentsEdit;
        private System.Windows.Forms.ComboBox cbxEndangermentEdit;
        private System.Windows.Forms.ComboBox cbxContinentEdit;
        private System.Windows.Forms.Label labelEndangerEdit;
        private System.Windows.Forms.TextBox tbxSpeciesEdit;
        private System.Windows.Forms.TextBox tbxNameEdit;
        private System.Windows.Forms.Label labelContinentEdit;
        private System.Windows.Forms.Label labelSpeciesEdit;
        private System.Windows.Forms.Label labelNameEdit;
        private System.Windows.Forms.GroupBox groupBoxAddAnimal;
        private System.Windows.Forms.Label labelDateFormat;
        private System.Windows.Forms.Label labelAddAnimalBirthDate;
        private System.Windows.Forms.MaskedTextBox maskedtbxBirthDateAddAnimalForm;
        private System.Windows.Forms.RadioButton rbtnMaleAddAnimal;
        private System.Windows.Forms.RadioButton rbtnFemaleAddAnimal;
        private System.Windows.Forms.Label labelGenderAdd;
        private System.Windows.Forms.NumericUpDown nudEnclosureAddAnimal;
        private System.Windows.Forms.Label labelEnclosureAddAnimal;
        private System.Windows.Forms.TextBox tbxAdditionalCommentsAddAnimal;
        private System.Windows.Forms.Label labelAdditionalCommentsAddAnimal;
        private System.Windows.Forms.ComboBox cbxEndangermentAddAnimal;
        private System.Windows.Forms.ComboBox cbxOriginAddAnimal;
        private System.Windows.Forms.Label labelAddAnimalEndangerment;
        private System.Windows.Forms.TextBox tbxSpeciesAddAnimal;
        private System.Windows.Forms.TextBox tbxNameAddAnimal;
        private System.Windows.Forms.Label labelAddAnimalOrigin;
        private System.Windows.Forms.Label labelAddAnimalSpecies;
        private System.Windows.Forms.Label labelAddAnimalName;
        private System.Windows.Forms.GroupBox groupBoxAnimalTransfer;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label labelStartDate;
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
        private System.Windows.Forms.TextBox tbxAnimalTransferPhone;
        private System.Windows.Forms.Label labelAnimeTransferPhone;
        private System.Windows.Forms.GroupBox groupBoxRelationship;
        private System.Windows.Forms.Button btnRemoveRelationship;
        private System.Windows.Forms.Button btnCancelRelationship;
        private System.Windows.Forms.Button btnAddNewRelationship;
        private System.Windows.Forms.Label labelExistingRelationshipMain;
        private System.Windows.Forms.ListBox lbxRelationshipsMain;
        private System.Windows.Forms.ComboBox cbxOtherAnimalRelationship;
        private System.Windows.Forms.ComboBox cbxRelationshipType;
        private System.Windows.Forms.Label labelRelationshipTypeMain;
        private System.Windows.Forms.Label labelOtherAnimalMain;
        private System.Windows.Forms.TextBox tbxMainAnimalRelationship;
        private System.Windows.Forms.Label labelMainAnimalRelationship;
    }
}
