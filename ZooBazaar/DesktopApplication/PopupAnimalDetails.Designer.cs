namespace DesktopApplication
{
    partial class PopupAnimalDetails
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
            this.groupBoxAddAnimal = new System.Windows.Forms.GroupBox();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.labelEditAnimalBirthDate = new System.Windows.Forms.Label();
            this.btnCancelAnimalCreation = new System.Windows.Forms.Button();
            this.btnConfirmAnimalCreation = new System.Windows.Forms.Button();
            this.maskedtbxBirthDateEditAnimalForm = new System.Windows.Forms.MaskedTextBox();
            this.rbtnMaleAddAnimal = new System.Windows.Forms.RadioButton();
            this.rbtnFemaleAddAnimal = new System.Windows.Forms.RadioButton();
            this.labelGenderAddAnimal = new System.Windows.Forms.Label();
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
            this.groupBoxAddAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnclosureAddAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddAnimal
            // 
            this.groupBoxAddAnimal.Controls.Add(this.btnConfirmChanges);
            this.groupBoxAddAnimal.Controls.Add(this.labelEditAnimalBirthDate);
            this.groupBoxAddAnimal.Controls.Add(this.btnCancelAnimalCreation);
            this.groupBoxAddAnimal.Controls.Add(this.btnConfirmAnimalCreation);
            this.groupBoxAddAnimal.Controls.Add(this.maskedtbxBirthDateEditAnimalForm);
            this.groupBoxAddAnimal.Controls.Add(this.rbtnMaleAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.rbtnFemaleAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.labelGenderAddAnimal);
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
            this.groupBoxAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddAnimal.Location = new System.Drawing.Point(17, 15);
            this.groupBoxAddAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxAddAnimal.Name = "groupBoxAddAnimal";
            this.groupBoxAddAnimal.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxAddAnimal.Size = new System.Drawing.Size(616, 714);
            this.groupBoxAddAnimal.TabIndex = 2;
            this.groupBoxAddAnimal.TabStop = false;
            this.groupBoxAddAnimal.Text = "Animal details:";
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConfirmChanges.Location = new System.Drawing.Point(332, 653);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(261, 52);
            this.btnConfirmChanges.TabIndex = 39;
            this.btnConfirmChanges.Text = "Confirm";
            this.btnConfirmChanges.UseVisualStyleBackColor = false;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // labelEditAnimalBirthDate
            // 
            this.labelEditAnimalBirthDate.AutoSize = true;
            this.labelEditAnimalBirthDate.Location = new System.Drawing.Point(17, 228);
            this.labelEditAnimalBirthDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEditAnimalBirthDate.Name = "labelEditAnimalBirthDate";
            this.labelEditAnimalBirthDate.Size = new System.Drawing.Size(136, 26);
            this.labelEditAnimalBirthDate.TabIndex = 38;
            this.labelEditAnimalBirthDate.Text = "Date of birth:";
            // 
            // btnCancelAnimalCreation
            // 
            this.btnCancelAnimalCreation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelAnimalCreation.Location = new System.Drawing.Point(21, 653);
            this.btnCancelAnimalCreation.Name = "btnCancelAnimalCreation";
            this.btnCancelAnimalCreation.Size = new System.Drawing.Size(261, 52);
            this.btnCancelAnimalCreation.TabIndex = 37;
            this.btnCancelAnimalCreation.Text = "Cancel";
            this.btnCancelAnimalCreation.UseVisualStyleBackColor = false;
            this.btnCancelAnimalCreation.Click += new System.EventHandler(this.btnCancelAnimalCreation_Click);
            // 
            // btnConfirmAnimalCreation
            // 
            this.btnConfirmAnimalCreation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConfirmAnimalCreation.Location = new System.Drawing.Point(332, 653);
            this.btnConfirmAnimalCreation.Name = "btnConfirmAnimalCreation";
            this.btnConfirmAnimalCreation.Size = new System.Drawing.Size(261, 52);
            this.btnConfirmAnimalCreation.TabIndex = 36;
            this.btnConfirmAnimalCreation.Text = "Confirm";
            this.btnConfirmAnimalCreation.UseVisualStyleBackColor = false;
            this.btnConfirmAnimalCreation.Click += new System.EventHandler(this.btnConfirmAnimalCreation_Click);
            // 
            // maskedtbxBirthDateEditAnimalForm
            // 
            this.maskedtbxBirthDateEditAnimalForm.Location = new System.Drawing.Point(196, 225);
            this.maskedtbxBirthDateEditAnimalForm.Mask = "00/00/0000";
            this.maskedtbxBirthDateEditAnimalForm.Name = "maskedtbxBirthDateEditAnimalForm";
            this.maskedtbxBirthDateEditAnimalForm.ResetOnSpace = false;
            this.maskedtbxBirthDateEditAnimalForm.Size = new System.Drawing.Size(120, 32);
            this.maskedtbxBirthDateEditAnimalForm.TabIndex = 35;
            // 
            // rbtnMaleAddAnimal
            // 
            this.rbtnMaleAddAnimal.AutoSize = true;
            this.rbtnMaleAddAnimal.Location = new System.Drawing.Point(196, 186);
            this.rbtnMaleAddAnimal.Name = "rbtnMaleAddAnimal";
            this.rbtnMaleAddAnimal.Size = new System.Drawing.Size(77, 30);
            this.rbtnMaleAddAnimal.TabIndex = 31;
            this.rbtnMaleAddAnimal.TabStop = true;
            this.rbtnMaleAddAnimal.Text = "Male";
            this.rbtnMaleAddAnimal.UseVisualStyleBackColor = true;
            // 
            // rbtnFemaleAddAnimal
            // 
            this.rbtnFemaleAddAnimal.AutoSize = true;
            this.rbtnFemaleAddAnimal.Location = new System.Drawing.Point(289, 186);
            this.rbtnFemaleAddAnimal.Name = "rbtnFemaleAddAnimal";
            this.rbtnFemaleAddAnimal.Size = new System.Drawing.Size(103, 30);
            this.rbtnFemaleAddAnimal.TabIndex = 30;
            this.rbtnFemaleAddAnimal.TabStop = true;
            this.rbtnFemaleAddAnimal.Text = "Female";
            this.rbtnFemaleAddAnimal.UseVisualStyleBackColor = true;
            // 
            // labelGenderAddAnimal
            // 
            this.labelGenderAddAnimal.AutoSize = true;
            this.labelGenderAddAnimal.Location = new System.Drawing.Point(16, 188);
            this.labelGenderAddAnimal.Name = "labelGenderAddAnimal";
            this.labelGenderAddAnimal.Size = new System.Drawing.Size(90, 26);
            this.labelGenderAddAnimal.TabIndex = 29;
            this.labelGenderAddAnimal.Text = "Gender:";
            // 
            // nudEnclosureAddAnimal
            // 
            this.nudEnclosureAddAnimal.Location = new System.Drawing.Point(196, 321);
            this.nudEnclosureAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nudEnclosureAddAnimal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnclosureAddAnimal.Name = "nudEnclosureAddAnimal";
            this.nudEnclosureAddAnimal.Size = new System.Drawing.Size(120, 32);
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
            this.labelEnclosureAddAnimal.Location = new System.Drawing.Point(16, 323);
            this.labelEnclosureAddAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnclosureAddAnimal.Name = "labelEnclosureAddAnimal";
            this.labelEnclosureAddAnimal.Size = new System.Drawing.Size(140, 26);
            this.labelEnclosureAddAnimal.TabIndex = 16;
            this.labelEnclosureAddAnimal.Text = "Enclosure nr:";
            // 
            // tbxAdditionalCommentsAddAnimal
            // 
            this.tbxAdditionalCommentsAddAnimal.Location = new System.Drawing.Point(21, 408);
            this.tbxAdditionalCommentsAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbxAdditionalCommentsAddAnimal.Multiline = true;
            this.tbxAdditionalCommentsAddAnimal.Name = "tbxAdditionalCommentsAddAnimal";
            this.tbxAdditionalCommentsAddAnimal.Size = new System.Drawing.Size(572, 226);
            this.tbxAdditionalCommentsAddAnimal.TabIndex = 15;
            // 
            // labelAdditionalCommentsAddAnimal
            // 
            this.labelAdditionalCommentsAddAnimal.AutoSize = true;
            this.labelAdditionalCommentsAddAnimal.Location = new System.Drawing.Point(16, 373);
            this.labelAdditionalCommentsAddAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdditionalCommentsAddAnimal.Name = "labelAdditionalCommentsAddAnimal";
            this.labelAdditionalCommentsAddAnimal.Size = new System.Drawing.Size(222, 26);
            this.labelAdditionalCommentsAddAnimal.TabIndex = 14;
            this.labelAdditionalCommentsAddAnimal.Text = "Additional comments:";
            // 
            // cbxEndangermentAddAnimal
            // 
            this.cbxEndangermentAddAnimal.FormattingEnabled = true;
            this.cbxEndangermentAddAnimal.Location = new System.Drawing.Point(196, 272);
            this.cbxEndangermentAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxEndangermentAddAnimal.Name = "cbxEndangermentAddAnimal";
            this.cbxEndangermentAddAnimal.Size = new System.Drawing.Size(397, 33);
            this.cbxEndangermentAddAnimal.TabIndex = 13;
            // 
            // cbxOriginAddAnimal
            // 
            this.cbxOriginAddAnimal.FormattingEnabled = true;
            this.cbxOriginAddAnimal.Location = new System.Drawing.Point(196, 140);
            this.cbxOriginAddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxOriginAddAnimal.Name = "cbxOriginAddAnimal";
            this.cbxOriginAddAnimal.Size = new System.Drawing.Size(397, 33);
            this.cbxOriginAddAnimal.TabIndex = 9;
            // 
            // labelAddAnimalEndangerment
            // 
            this.labelAddAnimalEndangerment.AutoSize = true;
            this.labelAddAnimalEndangerment.Location = new System.Drawing.Point(16, 275);
            this.labelAddAnimalEndangerment.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalEndangerment.Name = "labelAddAnimalEndangerment";
            this.labelAddAnimalEndangerment.Size = new System.Drawing.Size(161, 26);
            this.labelAddAnimalEndangerment.TabIndex = 8;
            this.labelAddAnimalEndangerment.Text = "Endangerment:";
            // 
            // tbxSpeciesAddAnimal
            // 
            this.tbxSpeciesAddAnimal.Location = new System.Drawing.Point(196, 94);
            this.tbxSpeciesAddAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxSpeciesAddAnimal.Name = "tbxSpeciesAddAnimal";
            this.tbxSpeciesAddAnimal.Size = new System.Drawing.Size(397, 32);
            this.tbxSpeciesAddAnimal.TabIndex = 6;
            // 
            // tbxNameAddAnimal
            // 
            this.tbxNameAddAnimal.Location = new System.Drawing.Point(196, 48);
            this.tbxNameAddAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxNameAddAnimal.Name = "tbxNameAddAnimal";
            this.tbxNameAddAnimal.Size = new System.Drawing.Size(397, 32);
            this.tbxNameAddAnimal.TabIndex = 5;
            // 
            // labelAddAnimalOrigin
            // 
            this.labelAddAnimalOrigin.AutoSize = true;
            this.labelAddAnimalOrigin.Location = new System.Drawing.Point(16, 143);
            this.labelAddAnimalOrigin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalOrigin.Name = "labelAddAnimalOrigin";
            this.labelAddAnimalOrigin.Size = new System.Drawing.Size(76, 26);
            this.labelAddAnimalOrigin.TabIndex = 2;
            this.labelAddAnimalOrigin.Text = "Origin:";
            // 
            // labelAddAnimalSpecies
            // 
            this.labelAddAnimalSpecies.AutoSize = true;
            this.labelAddAnimalSpecies.Location = new System.Drawing.Point(16, 97);
            this.labelAddAnimalSpecies.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalSpecies.Name = "labelAddAnimalSpecies";
            this.labelAddAnimalSpecies.Size = new System.Drawing.Size(96, 26);
            this.labelAddAnimalSpecies.TabIndex = 1;
            this.labelAddAnimalSpecies.Text = "Species:";
            // 
            // labelAddAnimalName
            // 
            this.labelAddAnimalName.AutoSize = true;
            this.labelAddAnimalName.Location = new System.Drawing.Point(16, 51);
            this.labelAddAnimalName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddAnimalName.Name = "labelAddAnimalName";
            this.labelAddAnimalName.Size = new System.Drawing.Size(77, 26);
            this.labelAddAnimalName.TabIndex = 0;
            this.labelAddAnimalName.Text = "Name:";
            // 
            // PopupAnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(650, 738);
            this.Controls.Add(this.groupBoxAddAnimal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "PopupAnimalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal Details";
            this.groupBoxAddAnimal.ResumeLayout(false);
            this.groupBoxAddAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnclosureAddAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddAnimal;
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
        private System.Windows.Forms.RadioButton rbtnMaleAddAnimal;
        private System.Windows.Forms.RadioButton rbtnFemaleAddAnimal;
        private System.Windows.Forms.Label labelGenderAddAnimal;
        private System.Windows.Forms.MaskedTextBox maskedtbxBirthDateEditAnimalForm;
        private System.Windows.Forms.Button btnCancelAnimalCreation;
        private System.Windows.Forms.Button btnConfirmAnimalCreation;
        private System.Windows.Forms.Label labelEditAnimalBirthDate;
        private System.Windows.Forms.Button btnConfirmChanges;
    }
}