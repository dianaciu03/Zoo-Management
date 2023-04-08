namespace ZooBazaarLogicLibrary
{
    partial class PopupRelationships
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
            this.groupBoxRelationships = new System.Windows.Forms.GroupBox();
            this.labelExistingRelationships = new System.Windows.Forms.Label();
            this.tbxAnimalForRelationship = new System.Windows.Forms.TextBox();
            this.labelMainAnimal = new System.Windows.Forms.Label();
            this.btnDeleteRelationship = new System.Windows.Forms.Button();
            this.lbxDisplayAnimalRelationships = new System.Windows.Forms.ListBox();
            this.cbOtherAnimal = new System.Windows.Forms.ComboBox();
            this.cbRelationShipType = new System.Windows.Forms.ComboBox();
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.labelRelationshipType = new System.Windows.Forms.Label();
            this.labelOtherAnimal = new System.Windows.Forms.Label();
            this.groupBoxRelationships.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRelationships
            // 
            this.groupBoxRelationships.Controls.Add(this.labelExistingRelationships);
            this.groupBoxRelationships.Controls.Add(this.tbxAnimalForRelationship);
            this.groupBoxRelationships.Controls.Add(this.labelMainAnimal);
            this.groupBoxRelationships.Controls.Add(this.btnDeleteRelationship);
            this.groupBoxRelationships.Controls.Add(this.lbxDisplayAnimalRelationships);
            this.groupBoxRelationships.Controls.Add(this.cbOtherAnimal);
            this.groupBoxRelationships.Controls.Add(this.cbRelationShipType);
            this.groupBoxRelationships.Controls.Add(this.btnAddRelationship);
            this.groupBoxRelationships.Controls.Add(this.labelRelationshipType);
            this.groupBoxRelationships.Controls.Add(this.labelOtherAnimal);
            this.groupBoxRelationships.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxRelationships.Location = new System.Drawing.Point(8, 8);
            this.groupBoxRelationships.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRelationships.Name = "groupBoxRelationships";
            this.groupBoxRelationships.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRelationships.Size = new System.Drawing.Size(410, 476);
            this.groupBoxRelationships.TabIndex = 1;
            this.groupBoxRelationships.TabStop = false;
            this.groupBoxRelationships.Text = "Add Relationship";
            this.groupBoxRelationships.Enter += new System.EventHandler(this.groupBoxRelationships_Enter);
            // 
            // labelExistingRelationships
            // 
            this.labelExistingRelationships.AutoSize = true;
            this.labelExistingRelationships.Location = new System.Drawing.Point(40, 228);
            this.labelExistingRelationships.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExistingRelationships.Name = "labelExistingRelationships";
            this.labelExistingRelationships.Size = new System.Drawing.Size(191, 24);
            this.labelExistingRelationships.TabIndex = 5;
            this.labelExistingRelationships.Text = "Existing relationships:";
            // 
            // tbxAnimalForRelationship
            // 
            this.tbxAnimalForRelationship.Enabled = false;
            this.tbxAnimalForRelationship.Location = new System.Drawing.Point(43, 32);
            this.tbxAnimalForRelationship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAnimalForRelationship.Name = "tbxAnimalForRelationship";
            this.tbxAnimalForRelationship.ReadOnly = true;
            this.tbxAnimalForRelationship.Size = new System.Drawing.Size(193, 29);
            this.tbxAnimalForRelationship.TabIndex = 4;
            // 
            // labelMainAnimal
            // 
            this.labelMainAnimal.AutoSize = true;
            this.labelMainAnimal.Location = new System.Drawing.Point(5, 34);
            this.labelMainAnimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainAnimal.Name = "labelMainAnimal";
            this.labelMainAnimal.Size = new System.Drawing.Size(44, 24);
            this.labelMainAnimal.TabIndex = 3;
            this.labelMainAnimal.Text = "For:";
            // 
            // btnDeleteRelationship
            // 
            this.btnDeleteRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDeleteRelationship.Location = new System.Drawing.Point(125, 430);
            this.btnDeleteRelationship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRelationship.Name = "btnDeleteRelationship";
            this.btnDeleteRelationship.Size = new System.Drawing.Size(173, 38);
            this.btnDeleteRelationship.TabIndex = 2;
            this.btnDeleteRelationship.Text = "Delete relationship";
            this.btnDeleteRelationship.UseVisualStyleBackColor = true;
            // 
            // lbxDisplayAnimalRelationships
            // 
            this.lbxDisplayAnimalRelationships.FormattingEnabled = true;
            this.lbxDisplayAnimalRelationships.HorizontalScrollbar = true;
            this.lbxDisplayAnimalRelationships.ItemHeight = 24;
            this.lbxDisplayAnimalRelationships.Location = new System.Drawing.Point(39, 257);
            this.lbxDisplayAnimalRelationships.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxDisplayAnimalRelationships.Name = "lbxDisplayAnimalRelationships";
            this.lbxDisplayAnimalRelationships.Size = new System.Drawing.Size(352, 148);
            this.lbxDisplayAnimalRelationships.TabIndex = 1;
            // 
            // cbOtherAnimal
            // 
            this.cbOtherAnimal.FormattingEnabled = true;
            this.cbOtherAnimal.Location = new System.Drawing.Point(198, 111);
            this.cbOtherAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOtherAnimal.Name = "cbOtherAnimal";
            this.cbOtherAnimal.Size = new System.Drawing.Size(193, 32);
            this.cbOtherAnimal.TabIndex = 2;
            // 
            // cbRelationShipType
            // 
            this.cbRelationShipType.FormattingEnabled = true;
            this.cbRelationShipType.Location = new System.Drawing.Point(198, 76);
            this.cbRelationShipType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRelationShipType.Name = "cbRelationShipType";
            this.cbRelationShipType.Size = new System.Drawing.Size(193, 32);
            this.cbRelationShipType.TabIndex = 1;
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRelationship.Location = new System.Drawing.Point(125, 155);
            this.btnAddRelationship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(173, 38);
            this.btnAddRelationship.TabIndex = 1;
            this.btnAddRelationship.Text = "Add relationship";
            this.btnAddRelationship.UseVisualStyleBackColor = true;
            this.btnAddRelationship.Click += new System.EventHandler(this.btnAddRelationship_Click);
            // 
            // labelRelationshipType
            // 
            this.labelRelationshipType.AutoSize = true;
            this.labelRelationshipType.Location = new System.Drawing.Point(40, 78);
            this.labelRelationshipType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRelationshipType.Name = "labelRelationshipType";
            this.labelRelationshipType.Size = new System.Drawing.Size(158, 24);
            this.labelRelationshipType.TabIndex = 2;
            this.labelRelationshipType.Text = "Relationship type:";
            // 
            // labelOtherAnimal
            // 
            this.labelOtherAnimal.AutoSize = true;
            this.labelOtherAnimal.Location = new System.Drawing.Point(40, 114);
            this.labelOtherAnimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtherAnimal.Name = "labelOtherAnimal";
            this.labelOtherAnimal.Size = new System.Drawing.Size(125, 24);
            this.labelOtherAnimal.TabIndex = 1;
            this.labelOtherAnimal.Text = "Other Animal:";
            // 
            // PopupRelationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 485);
            this.Controls.Add(this.groupBoxRelationships);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PopupRelationships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relationships";
            this.groupBoxRelationships.ResumeLayout(false);
            this.groupBoxRelationships.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRelationships;
        private System.Windows.Forms.TextBox tbxAnimalForRelationship;
        private System.Windows.Forms.Label labelMainAnimal;
        private System.Windows.Forms.Button btnDeleteRelationship;
        private System.Windows.Forms.ListBox lbxDisplayAnimalRelationships;
        private System.Windows.Forms.ComboBox cbOtherAnimal;
        private System.Windows.Forms.ComboBox cbRelationShipType;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.Label labelRelationshipType;
        private System.Windows.Forms.Label labelOtherAnimal;
        private System.Windows.Forms.Label labelExistingRelationships;
    }
}