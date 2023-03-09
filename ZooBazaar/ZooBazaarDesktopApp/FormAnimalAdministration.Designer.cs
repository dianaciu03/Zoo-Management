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
            this.tabAllAnimals = new System.Windows.Forms.TabPage();
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
            this.lvwAnimals = new System.Windows.Forms.ListView();
            this.groupBoxSearchAnimal = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.labelGenderAddAnimal = new System.Windows.Forms.Label();
            this.rbtnTransfered = new System.Windows.Forms.RadioButton();
            this.rbtnAvailable = new System.Windows.Forms.RadioButton();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.cbxEndangerment = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cbxOrigin = new System.Windows.Forms.ComboBox();
            this.labelEndangerment = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tbxSpecies = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
            this.tabControlAnimals.SuspendLayout();
            this.tabAllAnimals.SuspendLayout();
            this.groupBoxAnimalTransfer.SuspendLayout();
            this.groupBoxSearchAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAnimals
            // 
            this.tabControlAnimals.Controls.Add(this.tabAllAnimals);
            this.tabControlAnimals.Location = new System.Drawing.Point(13, 54);
            this.tabControlAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlAnimals.Name = "tabControlAnimals";
            this.tabControlAnimals.Padding = new System.Drawing.Point(70, 9);
            this.tabControlAnimals.SelectedIndex = 0;
            this.tabControlAnimals.Size = new System.Drawing.Size(1512, 772);
            this.tabControlAnimals.TabIndex = 0;
            // 
            // tabAllAnimals
            // 
            this.tabAllAnimals.Controls.Add(this.btnAddRelationship);
            this.tabAllAnimals.Controls.Add(this.btnEditAnimal);
            this.tabAllAnimals.Controls.Add(this.btnAddAnimal);
            this.tabAllAnimals.Controls.Add(this.groupBoxAnimalTransfer);
            this.tabAllAnimals.Controls.Add(this.lvwAnimals);
            this.tabAllAnimals.Controls.Add(this.groupBoxSearchAnimal);
            this.tabAllAnimals.Location = new System.Drawing.Point(4, 41);
            this.tabAllAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAllAnimals.Name = "tabAllAnimals";
            this.tabAllAnimals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAllAnimals.Size = new System.Drawing.Size(1504, 727);
            this.tabAllAnimals.TabIndex = 0;
            this.tabAllAnimals.Text = "All animals";
            this.tabAllAnimals.UseVisualStyleBackColor = true;
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRelationship.Location = new System.Drawing.Point(1100, 669);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(215, 45);
            this.btnAddRelationship.TabIndex = 6;
            this.btnAddRelationship.Text = "Add relationship";
            this.btnAddRelationship.UseVisualStyleBackColor = true;
            // 
            // btnEditAnimal
            // 
            this.btnEditAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAnimal.Location = new System.Drawing.Point(900, 669);
            this.btnEditAnimal.Name = "btnEditAnimal";
            this.btnEditAnimal.Size = new System.Drawing.Size(174, 45);
            this.btnEditAnimal.TabIndex = 5;
            this.btnEditAnimal.Text = "Edit animal";
            this.btnEditAnimal.UseVisualStyleBackColor = true;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(704, 669);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(174, 45);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
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
            this.groupBoxAnimalTransfer.Location = new System.Drawing.Point(26, 401);
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
            this.btnCancelTransfer.Location = new System.Drawing.Point(324, 264);
            this.btnCancelTransfer.Name = "btnCancelTransfer";
            this.btnCancelTransfer.Size = new System.Drawing.Size(120, 35);
            this.btnCancelTransfer.TabIndex = 16;
            this.btnCancelTransfer.Text = "Cancel";
            this.btnCancelTransfer.UseVisualStyleBackColor = true;
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.AutoSize = true;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(156, 264);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(120, 35);
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
            // lvwAnimals
            // 
            this.lvwAnimals.HideSelection = false;
            this.lvwAnimals.Location = new System.Drawing.Point(545, 30);
            this.lvwAnimals.Name = "lvwAnimals";
            this.lvwAnimals.Size = new System.Drawing.Size(932, 633);
            this.lvwAnimals.TabIndex = 2;
            this.lvwAnimals.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxSearchAnimal
            // 
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnMale);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnFemale);
            this.groupBoxSearchAnimal.Controls.Add(this.labelGenderAddAnimal);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnTransfered);
            this.groupBoxSearchAnimal.Controls.Add(this.rbtnAvailable);
            this.groupBoxSearchAnimal.Controls.Add(this.btnClearAll);
            this.groupBoxSearchAnimal.Controls.Add(this.btnSearchAnimal);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxEndangerment);
            this.groupBoxSearchAnimal.Controls.Add(this.numAge);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxOrigin);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEndangerment);
            this.groupBoxSearchAnimal.Controls.Add(this.labelStatus);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxSpecies);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelAge);
            this.groupBoxSearchAnimal.Controls.Add(this.labelOrigin);
            this.groupBoxSearchAnimal.Controls.Add(this.labelSpecies);
            this.groupBoxSearchAnimal.Controls.Add(this.labelName);
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(26, 21);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(478, 374);
            this.groupBoxSearchAnimal.TabIndex = 0;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
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
            // rbtnTransfered
            // 
            this.rbtnTransfered.AutoSize = true;
            this.rbtnTransfered.Location = new System.Drawing.Point(275, 198);
            this.rbtnTransfered.Name = "rbtnTransfered";
            this.rbtnTransfered.Size = new System.Drawing.Size(104, 24);
            this.rbtnTransfered.TabIndex = 17;
            this.rbtnTransfered.TabStop = true;
            this.rbtnTransfered.Text = "Transfered";
            this.rbtnTransfered.UseVisualStyleBackColor = true;
            // 
            // rbtnAvailable
            // 
            this.rbtnAvailable.AutoSize = true;
            this.rbtnAvailable.Location = new System.Drawing.Point(156, 198);
            this.rbtnAvailable.Name = "rbtnAvailable";
            this.rbtnAvailable.Size = new System.Drawing.Size(90, 24);
            this.rbtnAvailable.TabIndex = 16;
            this.rbtnAvailable.TabStop = true;
            this.rbtnAvailable.Text = "Available";
            this.rbtnAvailable.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Location = new System.Drawing.Point(302, 326);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(120, 35);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.AutoSize = true;
            this.btnSearchAnimal.Location = new System.Drawing.Point(156, 326);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(120, 35);
            this.btnSearchAnimal.TabIndex = 14;
            this.btnSearchAnimal.Text = "Search";
            this.btnSearchAnimal.UseVisualStyleBackColor = true;
            // 
            // cbxEndangerment
            // 
            this.cbxEndangerment.FormattingEnabled = true;
            this.cbxEndangerment.Location = new System.Drawing.Point(156, 278);
            this.cbxEndangerment.Name = "cbxEndangerment";
            this.cbxEndangerment.Size = new System.Drawing.Size(288, 28);
            this.cbxEndangerment.TabIndex = 13;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(156, 235);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 26);
            this.numAge.TabIndex = 10;
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
            this.labelOrigin.Size = new System.Drawing.Size(54, 20);
            this.labelOrigin.TabIndex = 2;
            this.labelOrigin.Text = "Origin:";
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
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(685, 9);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(184, 37);
            this.labelTitleZooBazaar.TabIndex = 1;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // FormAnimalAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 831);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlAnimals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnimalAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnimalAdministration";
            this.tabControlAnimals.ResumeLayout(false);
            this.tabAllAnimals.ResumeLayout(false);
            this.groupBoxAnimalTransfer.ResumeLayout(false);
            this.groupBoxAnimalTransfer.PerformLayout();
            this.groupBoxSearchAnimal.ResumeLayout(false);
            this.groupBoxSearchAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAnimals;
        private System.Windows.Forms.TabPage tabAllAnimals;
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
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox cbxOrigin;
        private System.Windows.Forms.ListView lvwAnimals;
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
        private System.Windows.Forms.RadioButton rbtnTransfered;
        private System.Windows.Forms.RadioButton rbtnAvailable;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.Button btnEditAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label labelGenderAddAnimal;
    }
}

