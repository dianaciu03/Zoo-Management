﻿namespace ZooBazaarDesktopApp
{
    partial class PopupAnimalTransfer
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
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.groupBoxAnimalTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnimalTransfer
            // 
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
            this.groupBoxAnimalTransfer.Location = new System.Drawing.Point(15, 15);
            this.groupBoxAnimalTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxAnimalTransfer.Name = "groupBoxAnimalTransfer";
            this.groupBoxAnimalTransfer.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxAnimalTransfer.Size = new System.Drawing.Size(593, 538);
            this.groupBoxAnimalTransfer.TabIndex = 4;
            this.groupBoxAnimalTransfer.TabStop = false;
            this.groupBoxAnimalTransfer.Text = "Animal transfer";
            // 
            // tbxComments
            // 
            this.tbxComments.Location = new System.Drawing.Point(175, 273);
            this.tbxComments.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxComments.Multiline = true;
            this.tbxComments.Name = "tbxComments";
            this.tbxComments.Size = new System.Drawing.Size(390, 179);
            this.tbxComments.TabIndex = 18;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(14, 276);
            this.labelComments.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(125, 26);
            this.labelComments.TabIndex = 17;
            this.labelComments.Text = "Comments:";
            // 
            // btnCancelTransfer
            // 
            this.btnCancelTransfer.AutoSize = true;
            this.btnCancelTransfer.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelTransfer.Location = new System.Drawing.Point(379, 464);
            this.btnCancelTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelTransfer.Name = "btnCancelTransfer";
            this.btnCancelTransfer.Size = new System.Drawing.Size(186, 50);
            this.btnCancelTransfer.TabIndex = 16;
            this.btnCancelTransfer.Text = "Cancel";
            this.btnCancelTransfer.UseVisualStyleBackColor = false;
            this.btnCancelTransfer.Click += new System.EventHandler(this.btnCancelTransfer_Click);
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.AutoSize = true;
            this.btnConfirmTransfer.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(175, 464);
            this.btnConfirmTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(186, 50);
            this.btnConfirmTransfer.TabIndex = 15;
            this.btnConfirmTransfer.Text = "Confirm";
            this.btnConfirmTransfer.UseVisualStyleBackColor = false;
            this.btnConfirmTransfer.Click += new System.EventHandler(this.btnConfirmTransfer_Click);
            // 
            // tbxAnimalTransfer
            // 
            this.tbxAnimalTransfer.Location = new System.Drawing.Point(175, 40);
            this.tbxAnimalTransfer.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxAnimalTransfer.Name = "tbxAnimalTransfer";
            this.tbxAnimalTransfer.ReadOnly = true;
            this.tbxAnimalTransfer.Size = new System.Drawing.Size(390, 32);
            this.tbxAnimalTransfer.TabIndex = 11;
            // 
            // tbxAddressTransfer
            // 
            this.tbxAddressTransfer.Location = new System.Drawing.Point(175, 128);
            this.tbxAddressTransfer.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxAddressTransfer.Name = "tbxAddressTransfer";
            this.tbxAddressTransfer.Size = new System.Drawing.Size(390, 32);
            this.tbxAddressTransfer.TabIndex = 10;
            // 
            // labelAnimalTransfer
            // 
            this.labelAnimalTransfer.AutoSize = true;
            this.labelAnimalTransfer.Location = new System.Drawing.Point(14, 43);
            this.labelAnimalTransfer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAnimalTransfer.Name = "labelAnimalTransfer";
            this.labelAnimalTransfer.Size = new System.Drawing.Size(86, 26);
            this.labelAnimalTransfer.TabIndex = 9;
            this.labelAnimalTransfer.Text = "Animal:";
            // 
            // labelAdressTransfer
            // 
            this.labelAdressTransfer.AutoSize = true;
            this.labelAdressTransfer.Location = new System.Drawing.Point(14, 131);
            this.labelAdressTransfer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAdressTransfer.Name = "labelAdressTransfer";
            this.labelAdressTransfer.Size = new System.Drawing.Size(138, 26);
            this.labelAdressTransfer.TabIndex = 8;
            this.labelAdressTransfer.Text = "Zoo address:";
            // 
            // tbxZooNameTransfer
            // 
            this.tbxZooNameTransfer.Location = new System.Drawing.Point(175, 84);
            this.tbxZooNameTransfer.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxZooNameTransfer.Name = "tbxZooNameTransfer";
            this.tbxZooNameTransfer.Size = new System.Drawing.Size(390, 32);
            this.tbxZooNameTransfer.TabIndex = 7;
            // 
            // labelZooNameTransfer
            // 
            this.labelZooNameTransfer.AutoSize = true;
            this.labelZooNameTransfer.Location = new System.Drawing.Point(14, 87);
            this.labelZooNameTransfer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelZooNameTransfer.Name = "labelZooNameTransfer";
            this.labelZooNameTransfer.Size = new System.Drawing.Size(116, 26);
            this.labelZooNameTransfer.TabIndex = 6;
            this.labelZooNameTransfer.Text = "Zoo name:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(14, 181);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(112, 26);
            this.labelStartDate.TabIndex = 19;
            this.labelStartDate.Text = "Start date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(175, 175);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(390, 32);
            this.dtpStartDate.TabIndex = 20;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(175, 223);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(390, 32);
            this.dtpEndDate.TabIndex = 21;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(14, 229);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(105, 26);
            this.labelEndDate.TabIndex = 22;
            this.labelEndDate.Text = "End date:";
            // 
            // PopupAnimalTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 569);
            this.Controls.Add(this.groupBoxAnimalTransfer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PopupAnimalTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupAnimalTransfer";
            this.groupBoxAnimalTransfer.ResumeLayout(false);
            this.groupBoxAnimalTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label labelStartDate;
    }
}