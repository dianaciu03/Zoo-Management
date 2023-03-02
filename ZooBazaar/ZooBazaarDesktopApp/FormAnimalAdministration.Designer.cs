﻿namespace ZooBazaarDesktopApp
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.cbxEndangerment = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxDiet = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cbxOrigin = new System.Windows.Forms.ComboBox();
            this.labelEndangerment = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tbxSpecies = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.labelDiet = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabAddAnimals = new System.Windows.Forms.TabPage();
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
            this.tabControlAnimals.Controls.Add(this.tabAddAnimals);
            this.tabControlAnimals.Location = new System.Drawing.Point(13, 60);
            this.tabControlAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlAnimals.Name = "tabControlAnimals";
            this.tabControlAnimals.Padding = new System.Drawing.Point(70, 9);
            this.tabControlAnimals.SelectedIndex = 0;
            this.tabControlAnimals.Size = new System.Drawing.Size(1512, 763);
            this.tabControlAnimals.TabIndex = 0;
            // 
            // tabAllAnimals
            // 
            this.tabAllAnimals.Controls.Add(this.groupBoxAnimalTransfer);
            this.tabAllAnimals.Controls.Add(this.lvwAnimals);
            this.tabAllAnimals.Controls.Add(this.groupBoxSearchAnimal);
            this.tabAllAnimals.Location = new System.Drawing.Point(4, 46);
            this.tabAllAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAllAnimals.Name = "tabAllAnimals";
            this.tabAllAnimals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAllAnimals.Size = new System.Drawing.Size(1504, 713);
            this.tabAllAnimals.TabIndex = 0;
            this.tabAllAnimals.Text = "All animals";
            this.tabAllAnimals.UseVisualStyleBackColor = true;
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
            this.groupBoxAnimalTransfer.Location = new System.Drawing.Point(26, 420);
            this.groupBoxAnimalTransfer.Name = "groupBoxAnimalTransfer";
            this.groupBoxAnimalTransfer.Size = new System.Drawing.Size(478, 280);
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
            this.tbxComments.Size = new System.Drawing.Size(288, 74);
            this.tbxComments.TabIndex = 18;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(22, 120);
            this.labelComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(113, 25);
            this.labelComments.TabIndex = 17;
            this.labelComments.Text = "Comments:";
            // 
            // btnCancelTransfer
            // 
            this.btnCancelTransfer.AutoSize = true;
            this.btnCancelTransfer.Location = new System.Drawing.Point(324, 233);
            this.btnCancelTransfer.Name = "btnCancelTransfer";
            this.btnCancelTransfer.Size = new System.Drawing.Size(120, 35);
            this.btnCancelTransfer.TabIndex = 16;
            this.btnCancelTransfer.Text = "Cancel";
            this.btnCancelTransfer.UseVisualStyleBackColor = true;
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.AutoSize = true;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(156, 233);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(120, 35);
            this.btnConfirmTransfer.TabIndex = 15;
            this.btnConfirmTransfer.Text = "Confirm";
            this.btnConfirmTransfer.UseVisualStyleBackColor = true;
            // 
            // tbxAnimalTransfer
            // 
            this.tbxAnimalTransfer.Location = new System.Drawing.Point(156, 197);
            this.tbxAnimalTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAnimalTransfer.Name = "tbxAnimalTransfer";
            this.tbxAnimalTransfer.ReadOnly = true;
            this.tbxAnimalTransfer.Size = new System.Drawing.Size(288, 30);
            this.tbxAnimalTransfer.TabIndex = 11;
            // 
            // tbxAddressTransfer
            // 
            this.tbxAddressTransfer.Location = new System.Drawing.Point(156, 80);
            this.tbxAddressTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddressTransfer.Name = "tbxAddressTransfer";
            this.tbxAddressTransfer.Size = new System.Drawing.Size(288, 30);
            this.tbxAddressTransfer.TabIndex = 10;
            // 
            // labelAnimalTransfer
            // 
            this.labelAnimalTransfer.AutoSize = true;
            this.labelAnimalTransfer.Location = new System.Drawing.Point(22, 200);
            this.labelAnimalTransfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnimalTransfer.Name = "labelAnimalTransfer";
            this.labelAnimalTransfer.Size = new System.Drawing.Size(78, 25);
            this.labelAnimalTransfer.TabIndex = 9;
            this.labelAnimalTransfer.Text = "Animal:";
            // 
            // labelAdressTransfer
            // 
            this.labelAdressTransfer.AutoSize = true;
            this.labelAdressTransfer.Location = new System.Drawing.Point(22, 83);
            this.labelAdressTransfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdressTransfer.Name = "labelAdressTransfer";
            this.labelAdressTransfer.Size = new System.Drawing.Size(127, 25);
            this.labelAdressTransfer.TabIndex = 8;
            this.labelAdressTransfer.Text = "Zoo address:";
            // 
            // tbxZooNameTransfer
            // 
            this.tbxZooNameTransfer.Location = new System.Drawing.Point(156, 40);
            this.tbxZooNameTransfer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxZooNameTransfer.Name = "tbxZooNameTransfer";
            this.tbxZooNameTransfer.Size = new System.Drawing.Size(288, 30);
            this.tbxZooNameTransfer.TabIndex = 7;
            // 
            // labelZooNameTransfer
            // 
            this.labelZooNameTransfer.AutoSize = true;
            this.labelZooNameTransfer.Location = new System.Drawing.Point(22, 43);
            this.labelZooNameTransfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZooNameTransfer.Name = "labelZooNameTransfer";
            this.labelZooNameTransfer.Size = new System.Drawing.Size(106, 25);
            this.labelZooNameTransfer.TabIndex = 6;
            this.labelZooNameTransfer.Text = "Zoo name:";
            // 
            // lvwAnimals
            // 
            this.lvwAnimals.HideSelection = false;
            this.lvwAnimals.Location = new System.Drawing.Point(545, 30);
            this.lvwAnimals.Name = "lvwAnimals";
            this.lvwAnimals.Size = new System.Drawing.Size(924, 670);
            this.lvwAnimals.TabIndex = 2;
            this.lvwAnimals.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxSearchAnimal
            // 
            this.groupBoxSearchAnimal.Controls.Add(this.btnClearAll);
            this.groupBoxSearchAnimal.Controls.Add(this.btnSearchAnimal);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxEndangerment);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxStatus);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxDiet);
            this.groupBoxSearchAnimal.Controls.Add(this.numAge);
            this.groupBoxSearchAnimal.Controls.Add(this.cbxOrigin);
            this.groupBoxSearchAnimal.Controls.Add(this.labelEndangerment);
            this.groupBoxSearchAnimal.Controls.Add(this.labelStatus);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxSpecies);
            this.groupBoxSearchAnimal.Controls.Add(this.tbxName);
            this.groupBoxSearchAnimal.Controls.Add(this.labelDiet);
            this.groupBoxSearchAnimal.Controls.Add(this.labelAge);
            this.groupBoxSearchAnimal.Controls.Add(this.labelOrigin);
            this.groupBoxSearchAnimal.Controls.Add(this.labelSpecies);
            this.groupBoxSearchAnimal.Controls.Add(this.labelName);
            this.groupBoxSearchAnimal.Location = new System.Drawing.Point(26, 21);
            this.groupBoxSearchAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Name = "groupBoxSearchAnimal";
            this.groupBoxSearchAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSearchAnimal.Size = new System.Drawing.Size(478, 393);
            this.groupBoxSearchAnimal.TabIndex = 0;
            this.groupBoxSearchAnimal.TabStop = false;
            this.groupBoxSearchAnimal.Text = "Search by:";
            this.groupBoxSearchAnimal.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Location = new System.Drawing.Point(324, 341);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(120, 35);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.AutoSize = true;
            this.btnSearchAnimal.Location = new System.Drawing.Point(156, 341);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(120, 35);
            this.btnSearchAnimal.TabIndex = 14;
            this.btnSearchAnimal.Text = "Search";
            this.btnSearchAnimal.UseVisualStyleBackColor = true;
            // 
            // cbxEndangerment
            // 
            this.cbxEndangerment.FormattingEnabled = true;
            this.cbxEndangerment.Location = new System.Drawing.Point(156, 288);
            this.cbxEndangerment.Name = "cbxEndangerment";
            this.cbxEndangerment.Size = new System.Drawing.Size(288, 33);
            this.cbxEndangerment.TabIndex = 13;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(156, 243);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(288, 33);
            this.cbxStatus.TabIndex = 12;
            // 
            // cbxDiet
            // 
            this.cbxDiet.FormattingEnabled = true;
            this.cbxDiet.Location = new System.Drawing.Point(156, 199);
            this.cbxDiet.Name = "cbxDiet";
            this.cbxDiet.Size = new System.Drawing.Size(288, 33);
            this.cbxDiet.TabIndex = 11;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(156, 163);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 30);
            this.numAge.TabIndex = 10;
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Location = new System.Drawing.Point(156, 124);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(288, 33);
            this.cbxOrigin.TabIndex = 9;
            // 
            // labelEndangerment
            // 
            this.labelEndangerment.AutoSize = true;
            this.labelEndangerment.Location = new System.Drawing.Point(22, 291);
            this.labelEndangerment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndangerment.Name = "labelEndangerment";
            this.labelEndangerment.Size = new System.Drawing.Size(146, 25);
            this.labelEndangerment.TabIndex = 8;
            this.labelEndangerment.Text = "Endangerment:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(22, 246);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 25);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status:";
            // 
            // tbxSpecies
            // 
            this.tbxSpecies.Location = new System.Drawing.Point(156, 83);
            this.tbxSpecies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSpecies.Name = "tbxSpecies";
            this.tbxSpecies.Size = new System.Drawing.Size(288, 30);
            this.tbxSpecies.TabIndex = 6;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(156, 41);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(288, 30);
            this.tbxName.TabIndex = 5;
            // 
            // labelDiet
            // 
            this.labelDiet.AutoSize = true;
            this.labelDiet.Location = new System.Drawing.Point(22, 202);
            this.labelDiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiet.Name = "labelDiet";
            this.labelDiet.Size = new System.Drawing.Size(52, 25);
            this.labelDiet.TabIndex = 4;
            this.labelDiet.Text = "Diet:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(22, 165);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(54, 25);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age:";
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(22, 127);
            this.labelOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(70, 25);
            this.labelOrigin.TabIndex = 2;
            this.labelOrigin.Text = "Origin:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(22, 86);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(89, 25);
            this.labelSpecies.TabIndex = 1;
            this.labelSpecies.Text = "Species:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // tabAddAnimals
            // 
            this.tabAddAnimals.Location = new System.Drawing.Point(4, 46);
            this.tabAddAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAddAnimals.Name = "tabAddAnimals";
            this.tabAddAnimals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAddAnimals.Size = new System.Drawing.Size(1504, 713);
            this.tabAddAnimals.TabIndex = 1;
            this.tabAddAnimals.Text = "Add animals";
            this.tabAddAnimals.UseVisualStyleBackColor = true;
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(685, 9);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(225, 46);
            this.labelTitleZooBazaar.TabIndex = 1;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // FormAnimalAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 831);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlAnimals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnimalAdministration";
            this.Text = "Form1";
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
        private System.Windows.Forms.TabPage tabAddAnimals;
        private System.Windows.Forms.Label labelTitleZooBazaar;
        private System.Windows.Forms.GroupBox groupBoxSearchAnimal;
        private System.Windows.Forms.Label labelEndangerment;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox tbxSpecies;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label labelDiet;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox cbxEndangerment;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxDiet;
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
    }
}

