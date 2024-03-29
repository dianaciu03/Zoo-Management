﻿namespace DesktopApplication
{
    partial class ucEmergencyContact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAdditionalInformation = new System.Windows.Forms.GroupBox();
            this.btnCancelAdditionalInformationEdit = new System.Windows.Forms.Button();
            this.btnSaveAdditionalInformationEdit = new System.Windows.Forms.Button();
            this.groupBoxEmergencyContact = new System.Windows.Forms.GroupBox();
            this.tbPhoneNumberAdditionalInformation = new System.Windows.Forms.TextBox();
            this.labelFirstNameAdditionalInformation = new System.Windows.Forms.Label();
            this.labelLastNameAdditionalInformation = new System.Windows.Forms.Label();
            this.tbFirstNameAdditionalInformation = new System.Windows.Forms.TextBox();
            this.tbLastNameAdditionalInformation = new System.Windows.Forms.TextBox();
            this.labelPhoneNumberAdditionalInformation = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmergencyContractRel = new System.Windows.Forms.TextBox();
            this.groupBoxAdditionalInformation.SuspendLayout();
            this.groupBoxEmergencyContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdditionalInformation
            // 
            this.groupBoxAdditionalInformation.Controls.Add(this.btnCancelAdditionalInformationEdit);
            this.groupBoxAdditionalInformation.Controls.Add(this.btnSaveAdditionalInformationEdit);
            this.groupBoxAdditionalInformation.Controls.Add(this.groupBoxEmergencyContact);
            this.groupBoxAdditionalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBoxAdditionalInformation.Location = new System.Drawing.Point(4, 3);
            this.groupBoxAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxAdditionalInformation.Name = "groupBoxAdditionalInformation";
            this.groupBoxAdditionalInformation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxAdditionalInformation.Size = new System.Drawing.Size(550, 502);
            this.groupBoxAdditionalInformation.TabIndex = 36;
            this.groupBoxAdditionalInformation.TabStop = false;
            this.groupBoxAdditionalInformation.Text = "Additional Information";
            // 
            // btnCancelAdditionalInformationEdit
            // 
            this.btnCancelAdditionalInformationEdit.Location = new System.Drawing.Point(62, 430);
            this.btnCancelAdditionalInformationEdit.Name = "btnCancelAdditionalInformationEdit";
            this.btnCancelAdditionalInformationEdit.Size = new System.Drawing.Size(175, 36);
            this.btnCancelAdditionalInformationEdit.TabIndex = 41;
            this.btnCancelAdditionalInformationEdit.Text = "Cancel";
            this.btnCancelAdditionalInformationEdit.UseVisualStyleBackColor = true;
            this.btnCancelAdditionalInformationEdit.Click += new System.EventHandler(this.btnCancelAdditionalInformationEdit_Click);
            // 
            // btnSaveAdditionalInformationEdit
            // 
            this.btnSaveAdditionalInformationEdit.Location = new System.Drawing.Point(318, 430);
            this.btnSaveAdditionalInformationEdit.Name = "btnSaveAdditionalInformationEdit";
            this.btnSaveAdditionalInformationEdit.Size = new System.Drawing.Size(175, 36);
            this.btnSaveAdditionalInformationEdit.TabIndex = 40;
            this.btnSaveAdditionalInformationEdit.Text = "Save changes";
            this.btnSaveAdditionalInformationEdit.UseVisualStyleBackColor = true;
            this.btnSaveAdditionalInformationEdit.Click += new System.EventHandler(this.btnSaveAdditionalInformationEdit_Click);
            // 
            // groupBoxEmergencyContact
            // 
            this.groupBoxEmergencyContact.Controls.Add(this.tbxEmergencyContractRel);
            this.groupBoxEmergencyContact.Controls.Add(this.label1);
            this.groupBoxEmergencyContact.Controls.Add(this.tbPhoneNumberAdditionalInformation);
            this.groupBoxEmergencyContact.Controls.Add(this.labelFirstNameAdditionalInformation);
            this.groupBoxEmergencyContact.Controls.Add(this.labelLastNameAdditionalInformation);
            this.groupBoxEmergencyContact.Controls.Add(this.tbFirstNameAdditionalInformation);
            this.groupBoxEmergencyContact.Controls.Add(this.tbLastNameAdditionalInformation);
            this.groupBoxEmergencyContact.Controls.Add(this.labelPhoneNumberAdditionalInformation);
            this.groupBoxEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBoxEmergencyContact.Location = new System.Drawing.Point(7, 51);
            this.groupBoxEmergencyContact.Name = "groupBoxEmergencyContact";
            this.groupBoxEmergencyContact.Size = new System.Drawing.Size(532, 349);
            this.groupBoxEmergencyContact.TabIndex = 37;
            this.groupBoxEmergencyContact.TabStop = false;
            this.groupBoxEmergencyContact.Text = "Emergency contact";
            // 
            // tbPhoneNumberAdditionalInformation
            // 
            this.tbPhoneNumberAdditionalInformation.Location = new System.Drawing.Point(213, 164);
            this.tbPhoneNumberAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPhoneNumberAdditionalInformation.Name = "tbPhoneNumberAdditionalInformation";
            this.tbPhoneNumberAdditionalInformation.Size = new System.Drawing.Size(295, 32);
            this.tbPhoneNumberAdditionalInformation.TabIndex = 17;
            // 
            // labelFirstNameAdditionalInformation
            // 
            this.labelFirstNameAdditionalInformation.AutoSize = true;
            this.labelFirstNameAdditionalInformation.Location = new System.Drawing.Point(50, 67);
            this.labelFirstNameAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstNameAdditionalInformation.Name = "labelFirstNameAdditionalInformation";
            this.labelFirstNameAdditionalInformation.Size = new System.Drawing.Size(121, 26);
            this.labelFirstNameAdditionalInformation.TabIndex = 0;
            this.labelFirstNameAdditionalInformation.Text = "First name:";
            // 
            // labelLastNameAdditionalInformation
            // 
            this.labelLastNameAdditionalInformation.AutoSize = true;
            this.labelLastNameAdditionalInformation.Location = new System.Drawing.Point(51, 119);
            this.labelLastNameAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastNameAdditionalInformation.Name = "labelLastNameAdditionalInformation";
            this.labelLastNameAdditionalInformation.Size = new System.Drawing.Size(120, 26);
            this.labelLastNameAdditionalInformation.TabIndex = 1;
            this.labelLastNameAdditionalInformation.Text = "Last name:";
            // 
            // tbFirstNameAdditionalInformation
            // 
            this.tbFirstNameAdditionalInformation.Location = new System.Drawing.Point(213, 64);
            this.tbFirstNameAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFirstNameAdditionalInformation.Name = "tbFirstNameAdditionalInformation";
            this.tbFirstNameAdditionalInformation.Size = new System.Drawing.Size(295, 32);
            this.tbFirstNameAdditionalInformation.TabIndex = 5;
            // 
            // tbLastNameAdditionalInformation
            // 
            this.tbLastNameAdditionalInformation.Location = new System.Drawing.Point(213, 116);
            this.tbLastNameAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLastNameAdditionalInformation.Name = "tbLastNameAdditionalInformation";
            this.tbLastNameAdditionalInformation.Size = new System.Drawing.Size(295, 32);
            this.tbLastNameAdditionalInformation.TabIndex = 6;
            // 
            // labelPhoneNumberAdditionalInformation
            // 
            this.labelPhoneNumberAdditionalInformation.AutoSize = true;
            this.labelPhoneNumberAdditionalInformation.Location = new System.Drawing.Point(11, 170);
            this.labelPhoneNumberAdditionalInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumberAdditionalInformation.Name = "labelPhoneNumberAdditionalInformation";
            this.labelPhoneNumberAdditionalInformation.Size = new System.Drawing.Size(161, 26);
            this.labelPhoneNumberAdditionalInformation.TabIndex = 18;
            this.labelPhoneNumberAdditionalInformation.Text = "Phone number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Relationship:";
            // 
            // tbxEmergencyContractRel
            // 
            this.tbxEmergencyContractRel.Location = new System.Drawing.Point(213, 213);
            this.tbxEmergencyContractRel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxEmergencyContractRel.Name = "tbxEmergencyContractRel";
            this.tbxEmergencyContractRel.Size = new System.Drawing.Size(295, 32);
            this.tbxEmergencyContractRel.TabIndex = 20;
            // 
            // ucEmergencyContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBoxAdditionalInformation);
            this.Name = "ucEmergencyContact";
            this.Size = new System.Drawing.Size(569, 510);
            this.Load += new System.EventHandler(this.ucEmergencyContact_Load);
            this.groupBoxAdditionalInformation.ResumeLayout(false);
            this.groupBoxEmergencyContact.ResumeLayout(false);
            this.groupBoxEmergencyContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdditionalInformation;
        private System.Windows.Forms.Label labelPhoneNumberAdditionalInformation;
        private System.Windows.Forms.TextBox tbPhoneNumberAdditionalInformation;
        private System.Windows.Forms.TextBox tbLastNameAdditionalInformation;
        private System.Windows.Forms.TextBox tbFirstNameAdditionalInformation;
        private System.Windows.Forms.Label labelLastNameAdditionalInformation;
        private System.Windows.Forms.Label labelFirstNameAdditionalInformation;
        private System.Windows.Forms.GroupBox groupBoxEmergencyContact;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelAdditionalInformationEdit;
        private System.Windows.Forms.Button btnSaveAdditionalInformationEdit;
        private System.Windows.Forms.TextBox tbxEmergencyContractRel;
        private System.Windows.Forms.Label label1;
    }
}
