namespace ZooBazaarDesktopApp
{
    partial class EditAnimalDetails
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxEditAnimal = new System.Windows.Forms.GroupBox();
            this.maskedtbxBirthDateEditAnimalForm = new System.Windows.Forms.MaskedTextBox();
            this.labelEditAnimalBirthDate = new System.Windows.Forms.Label();
            this.rbtnMaleEditAnimal = new System.Windows.Forms.RadioButton();
            this.rbtnFemaleEditAnimal = new System.Windows.Forms.RadioButton();
            this.labelGenderEditAnimal = new System.Windows.Forms.Label();
            this.btnEditAnimalForm = new System.Windows.Forms.Button();
            this.nudEnclosureEditAnimal = new System.Windows.Forms.NumericUpDown();
            this.labelEnclosureEditAnimal = new System.Windows.Forms.Label();
            this.tbxAdditionalCommentsEditAnimal = new System.Windows.Forms.TextBox();
            this.labelAdditionalCommentsEditAnimal = new System.Windows.Forms.Label();
            this.cbxEndangermentEditAnimal = new System.Windows.Forms.ComboBox();
            this.cbxOriginEditAnimal = new System.Windows.Forms.ComboBox();
            this.labelEditAnimalEndangerment = new System.Windows.Forms.Label();
            this.tbxSpeciesEditAnimal = new System.Windows.Forms.TextBox();
            this.tbxNameEditAnimal = new System.Windows.Forms.TextBox();
            this.labelEditAnimalOrigin = new System.Windows.Forms.Label();
            this.labelEditAnimalSpecies = new System.Windows.Forms.Label();
            this.labelEditAnimalName = new System.Windows.Forms.Label();
            this.groupBoxEditAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnclosureEditAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEditAnimal
            // 
            this.groupBoxEditAnimal.Controls.Add(this.maskedtbxBirthDateEditAnimalForm);
            this.groupBoxEditAnimal.Controls.Add(this.labelEditAnimalBirthDate);
            this.groupBoxEditAnimal.Controls.Add(this.rbtnMaleEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.rbtnFemaleEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.labelGenderEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.btnEditAnimalForm);
            this.groupBoxEditAnimal.Controls.Add(this.nudEnclosureEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.labelEnclosureEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.tbxAdditionalCommentsEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.labelAdditionalCommentsEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.cbxEndangermentEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.cbxOriginEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.labelEditAnimalEndangerment);
            this.groupBoxEditAnimal.Controls.Add(this.tbxSpeciesEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.tbxNameEditAnimal);
            this.groupBoxEditAnimal.Controls.Add(this.labelEditAnimalOrigin);
            this.groupBoxEditAnimal.Controls.Add(this.labelEditAnimalSpecies);
            this.groupBoxEditAnimal.Controls.Add(this.labelEditAnimalName);
            this.groupBoxEditAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxEditAnimal.Location = new System.Drawing.Point(17, 15);
            this.groupBoxEditAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxEditAnimal.Name = "groupBoxEditAnimal";
            this.groupBoxEditAnimal.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxEditAnimal.Size = new System.Drawing.Size(608, 718);
            this.groupBoxEditAnimal.TabIndex = 3;
            this.groupBoxEditAnimal.TabStop = false;
            this.groupBoxEditAnimal.Text = "Update animal details:";
            // 
            // maskedtbxBirthDateEditAnimalForm
            // 
            this.maskedtbxBirthDateEditAnimalForm.Location = new System.Drawing.Point(196, 229);
            this.maskedtbxBirthDateEditAnimalForm.Mask = "00/00/0000";
            this.maskedtbxBirthDateEditAnimalForm.Name = "maskedtbxBirthDateEditAnimalForm";
            this.maskedtbxBirthDateEditAnimalForm.ResetOnSpace = false;
            this.maskedtbxBirthDateEditAnimalForm.Size = new System.Drawing.Size(109, 29);
            this.maskedtbxBirthDateEditAnimalForm.TabIndex = 34;
            this.maskedtbxBirthDateEditAnimalForm.ValidatingType = typeof(System.DateTime);
            // 
            // labelEditAnimalBirthDate
            // 
            this.labelEditAnimalBirthDate.AutoSize = true;
            this.labelEditAnimalBirthDate.Location = new System.Drawing.Point(16, 229);
            this.labelEditAnimalBirthDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEditAnimalBirthDate.Name = "labelEditAnimalBirthDate";
            this.labelEditAnimalBirthDate.Size = new System.Drawing.Size(114, 24);
            this.labelEditAnimalBirthDate.TabIndex = 33;
            this.labelEditAnimalBirthDate.Text = "Date of birth:";
            // 
            // rbtnMaleEditAnimal
            // 
            this.rbtnMaleEditAnimal.AutoSize = true;
            this.rbtnMaleEditAnimal.Location = new System.Drawing.Point(196, 186);
            this.rbtnMaleEditAnimal.Name = "rbtnMaleEditAnimal";
            this.rbtnMaleEditAnimal.Size = new System.Drawing.Size(69, 28);
            this.rbtnMaleEditAnimal.TabIndex = 31;
            this.rbtnMaleEditAnimal.TabStop = true;
            this.rbtnMaleEditAnimal.Text = "Male";
            this.rbtnMaleEditAnimal.UseVisualStyleBackColor = true;
            // 
            // rbtnFemaleEditAnimal
            // 
            this.rbtnFemaleEditAnimal.AutoSize = true;
            this.rbtnFemaleEditAnimal.Location = new System.Drawing.Point(289, 186);
            this.rbtnFemaleEditAnimal.Name = "rbtnFemaleEditAnimal";
            this.rbtnFemaleEditAnimal.Size = new System.Drawing.Size(92, 28);
            this.rbtnFemaleEditAnimal.TabIndex = 30;
            this.rbtnFemaleEditAnimal.TabStop = true;
            this.rbtnFemaleEditAnimal.Text = "Female";
            this.rbtnFemaleEditAnimal.UseVisualStyleBackColor = true;
            // 
            // labelGenderEditAnimal
            // 
            this.labelGenderEditAnimal.AutoSize = true;
            this.labelGenderEditAnimal.Location = new System.Drawing.Point(16, 188);
            this.labelGenderEditAnimal.Name = "labelGenderEditAnimal";
            this.labelGenderEditAnimal.Size = new System.Drawing.Size(79, 24);
            this.labelGenderEditAnimal.TabIndex = 29;
            this.labelGenderEditAnimal.Text = "Gender:";
            // 
            // btnEditAnimalForm
            // 
            this.btnEditAnimalForm.AutoSize = true;
            this.btnEditAnimalForm.Location = new System.Drawing.Point(196, 646);
            this.btnEditAnimalForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditAnimalForm.Name = "btnEditAnimalForm";
            this.btnEditAnimalForm.Size = new System.Drawing.Size(198, 53);
            this.btnEditAnimalForm.TabIndex = 28;
            this.btnEditAnimalForm.Text = "Update animal details";
            this.btnEditAnimalForm.UseVisualStyleBackColor = true;
            // 
            // nudEnclosureEditAnimal
            // 
            this.nudEnclosureEditAnimal.Location = new System.Drawing.Point(196, 321);
            this.nudEnclosureEditAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nudEnclosureEditAnimal.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudEnclosureEditAnimal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnclosureEditAnimal.Name = "nudEnclosureEditAnimal";
            this.nudEnclosureEditAnimal.Size = new System.Drawing.Size(109, 29);
            this.nudEnclosureEditAnimal.TabIndex = 17;
            this.nudEnclosureEditAnimal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEnclosureEditAnimal
            // 
            this.labelEnclosureEditAnimal.AutoSize = true;
            this.labelEnclosureEditAnimal.Location = new System.Drawing.Point(16, 323);
            this.labelEnclosureEditAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnclosureEditAnimal.Name = "labelEnclosureEditAnimal";
            this.labelEnclosureEditAnimal.Size = new System.Drawing.Size(123, 24);
            this.labelEnclosureEditAnimal.TabIndex = 16;
            this.labelEnclosureEditAnimal.Text = "Enclosure nr:";
            // 
            // tbxAdditionalCommentsEditAnimal
            // 
            this.tbxAdditionalCommentsEditAnimal.Location = new System.Drawing.Point(21, 408);
            this.tbxAdditionalCommentsEditAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbxAdditionalCommentsEditAnimal.Multiline = true;
            this.tbxAdditionalCommentsEditAnimal.Name = "tbxAdditionalCommentsEditAnimal";
            this.tbxAdditionalCommentsEditAnimal.Size = new System.Drawing.Size(572, 226);
            this.tbxAdditionalCommentsEditAnimal.TabIndex = 15;
            // 
            // labelAdditionalCommentsEditAnimal
            // 
            this.labelAdditionalCommentsEditAnimal.AutoSize = true;
            this.labelAdditionalCommentsEditAnimal.Location = new System.Drawing.Point(17, 378);
            this.labelAdditionalCommentsEditAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdditionalCommentsEditAnimal.Name = "labelAdditionalCommentsEditAnimal";
            this.labelAdditionalCommentsEditAnimal.Size = new System.Drawing.Size(191, 24);
            this.labelAdditionalCommentsEditAnimal.TabIndex = 14;
            this.labelAdditionalCommentsEditAnimal.Text = "Additional comments:";
            // 
            // cbxEndangermentEditAnimal
            // 
            this.cbxEndangermentEditAnimal.FormattingEnabled = true;
            this.cbxEndangermentEditAnimal.Location = new System.Drawing.Point(196, 272);
            this.cbxEndangermentEditAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxEndangermentEditAnimal.Name = "cbxEndangermentEditAnimal";
            this.cbxEndangermentEditAnimal.Size = new System.Drawing.Size(397, 32);
            this.cbxEndangermentEditAnimal.TabIndex = 13;
            // 
            // cbxOriginEditAnimal
            // 
            this.cbxOriginEditAnimal.FormattingEnabled = true;
            this.cbxOriginEditAnimal.Location = new System.Drawing.Point(196, 140);
            this.cbxOriginEditAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbxOriginEditAnimal.Name = "cbxOriginEditAnimal";
            this.cbxOriginEditAnimal.Size = new System.Drawing.Size(397, 32);
            this.cbxOriginEditAnimal.TabIndex = 9;
            // 
            // labelEditAnimalEndangerment
            // 
            this.labelEditAnimalEndangerment.AutoSize = true;
            this.labelEditAnimalEndangerment.Location = new System.Drawing.Point(16, 275);
            this.labelEditAnimalEndangerment.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEditAnimalEndangerment.Name = "labelEditAnimalEndangerment";
            this.labelEditAnimalEndangerment.Size = new System.Drawing.Size(141, 24);
            this.labelEditAnimalEndangerment.TabIndex = 8;
            this.labelEditAnimalEndangerment.Text = "Endangerment:";
            // 
            // tbxSpeciesEditAnimal
            // 
            this.tbxSpeciesEditAnimal.Location = new System.Drawing.Point(196, 94);
            this.tbxSpeciesEditAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxSpeciesEditAnimal.Name = "tbxSpeciesEditAnimal";
            this.tbxSpeciesEditAnimal.Size = new System.Drawing.Size(397, 29);
            this.tbxSpeciesEditAnimal.TabIndex = 6;
            // 
            // tbxNameEditAnimal
            // 
            this.tbxNameEditAnimal.Location = new System.Drawing.Point(196, 48);
            this.tbxNameEditAnimal.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxNameEditAnimal.Name = "tbxNameEditAnimal";
            this.tbxNameEditAnimal.Size = new System.Drawing.Size(397, 29);
            this.tbxNameEditAnimal.TabIndex = 5;
            // 
            // labelEditAnimalOrigin
            // 
            this.labelEditAnimalOrigin.AutoSize = true;
            this.labelEditAnimalOrigin.Location = new System.Drawing.Point(16, 143);
            this.labelEditAnimalOrigin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEditAnimalOrigin.Name = "labelEditAnimalOrigin";
            this.labelEditAnimalOrigin.Size = new System.Drawing.Size(66, 24);
            this.labelEditAnimalOrigin.TabIndex = 2;
            this.labelEditAnimalOrigin.Text = "Origin:";
            // 
            // labelEditAnimalSpecies
            // 
            this.labelEditAnimalSpecies.AutoSize = true;
            this.labelEditAnimalSpecies.Location = new System.Drawing.Point(16, 97);
            this.labelEditAnimalSpecies.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEditAnimalSpecies.Name = "labelEditAnimalSpecies";
            this.labelEditAnimalSpecies.Size = new System.Drawing.Size(83, 24);
            this.labelEditAnimalSpecies.TabIndex = 1;
            this.labelEditAnimalSpecies.Text = "Species:";
            // 
            // labelEditAnimalName
            // 
            this.labelEditAnimalName.AutoSize = true;
            this.labelEditAnimalName.Location = new System.Drawing.Point(16, 51);
            this.labelEditAnimalName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEditAnimalName.Name = "labelEditAnimalName";
            this.labelEditAnimalName.Size = new System.Drawing.Size(66, 24);
            this.labelEditAnimalName.TabIndex = 0;
            this.labelEditAnimalName.Text = "Name:";
            // 
            // EditAnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 739);
            this.Controls.Add(this.groupBoxEditAnimal);
            this.Name = "EditAnimalDetails";
            this.Text = "EditAnimalDetails";
            this.groupBoxEditAnimal.ResumeLayout(false);
            this.groupBoxEditAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnclosureEditAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxEditAnimal;
        private System.Windows.Forms.RadioButton rbtnMaleEditAnimal;
        private System.Windows.Forms.RadioButton rbtnFemaleEditAnimal;
        private System.Windows.Forms.Label labelGenderEditAnimal;
        private System.Windows.Forms.Button btnEditAnimalForm;
        private System.Windows.Forms.NumericUpDown nudEnclosureEditAnimal;
        private System.Windows.Forms.Label labelEnclosureEditAnimal;
        private System.Windows.Forms.TextBox tbxAdditionalCommentsEditAnimal;
        private System.Windows.Forms.Label labelAdditionalCommentsEditAnimal;
        private System.Windows.Forms.ComboBox cbxEndangermentEditAnimal;
        private System.Windows.Forms.ComboBox cbxOriginEditAnimal;
        private System.Windows.Forms.Label labelEditAnimalEndangerment;
        private System.Windows.Forms.TextBox tbxSpeciesEditAnimal;
        private System.Windows.Forms.TextBox tbxNameEditAnimal;
        private System.Windows.Forms.Label labelEditAnimalOrigin;
        private System.Windows.Forms.Label labelEditAnimalSpecies;
        private System.Windows.Forms.Label labelEditAnimalName;
        private System.Windows.Forms.MaskedTextBox maskedtbxBirthDateEditAnimalForm;
        private System.Windows.Forms.Label labelEditAnimalBirthDate;
    }
}