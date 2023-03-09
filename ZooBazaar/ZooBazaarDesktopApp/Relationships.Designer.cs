namespace ZooBazaarLogicLibrary
{
    partial class Relationships
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMainAnimal = new System.Windows.Forms.Label();
            this.btnDeleteRelationship = new System.Windows.Forms.Button();
            this.lbxDisplayAnimalRelationships = new System.Windows.Forms.ListBox();
            this.cbOtherAnimal = new System.Windows.Forms.ComboBox();
            this.cbRelationShipType = new System.Windows.Forms.ComboBox();
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.labelRelationshipType = new System.Windows.Forms.Label();
            this.labelCompanion = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxRelationships.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRelationships
            // 
            this.groupBoxRelationships.Controls.Add(this.textBox1);
            this.groupBoxRelationships.Controls.Add(this.labelMainAnimal);
            this.groupBoxRelationships.Controls.Add(this.btnDeleteRelationship);
            this.groupBoxRelationships.Controls.Add(this.lbxDisplayAnimalRelationships);
            this.groupBoxRelationships.Controls.Add(this.cbOtherAnimal);
            this.groupBoxRelationships.Controls.Add(this.cbRelationShipType);
            this.groupBoxRelationships.Controls.Add(this.btnAddRelationship);
            this.groupBoxRelationships.Controls.Add(this.labelRelationshipType);
            this.groupBoxRelationships.Controls.Add(this.labelCompanion);
            this.groupBoxRelationships.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxRelationships.Location = new System.Drawing.Point(8, 8);
            this.groupBoxRelationships.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRelationships.Name = "groupBoxRelationships";
            this.groupBoxRelationships.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRelationships.Size = new System.Drawing.Size(427, 486);
            this.groupBoxRelationships.TabIndex = 1;
            this.groupBoxRelationships.TabStop = false;
            this.groupBoxRelationships.Text = "Add Relationship";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(50, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 29);
            this.textBox1.TabIndex = 4;
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
            this.btnDeleteRelationship.Location = new System.Drawing.Point(115, 423);
            this.btnDeleteRelationship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRelationship.Name = "btnDeleteRelationship";
            this.btnDeleteRelationship.Size = new System.Drawing.Size(173, 30);
            this.btnDeleteRelationship.TabIndex = 2;
            this.btnDeleteRelationship.Text = "Delete relationship";
            this.btnDeleteRelationship.UseVisualStyleBackColor = true;
            // 
            // lbxDisplayAnimalRelationships
            // 
            this.lbxDisplayAnimalRelationships.FormattingEnabled = true;
            this.lbxDisplayAnimalRelationships.ItemHeight = 24;
            this.lbxDisplayAnimalRelationships.Location = new System.Drawing.Point(37, 218);
            this.lbxDisplayAnimalRelationships.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxDisplayAnimalRelationships.Name = "lbxDisplayAnimalRelationships";
            this.lbxDisplayAnimalRelationships.ScrollAlwaysVisible = true;
            this.lbxDisplayAnimalRelationships.Size = new System.Drawing.Size(315, 172);
            this.lbxDisplayAnimalRelationships.TabIndex = 1;
            // 
            // cbOtherAnimal
            // 
            this.cbOtherAnimal.FormattingEnabled = true;
            this.cbOtherAnimal.Location = new System.Drawing.Point(177, 118);
            this.cbOtherAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOtherAnimal.Name = "cbOtherAnimal";
            this.cbOtherAnimal.Size = new System.Drawing.Size(175, 32);
            this.cbOtherAnimal.TabIndex = 2;
            // 
            // cbRelationShipType
            // 
            this.cbRelationShipType.FormattingEnabled = true;
            this.cbRelationShipType.Location = new System.Drawing.Point(177, 87);
            this.cbRelationShipType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRelationShipType.Name = "cbRelationShipType";
            this.cbRelationShipType.Size = new System.Drawing.Size(175, 32);
            this.cbRelationShipType.TabIndex = 1;
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRelationship.Location = new System.Drawing.Point(115, 162);
            this.btnAddRelationship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(173, 27);
            this.btnAddRelationship.TabIndex = 1;
            this.btnAddRelationship.Text = "Add relationship";
            this.btnAddRelationship.UseVisualStyleBackColor = true;
            // 
            // labelRelationshipType
            // 
            this.labelRelationshipType.AutoSize = true;
            this.labelRelationshipType.Location = new System.Drawing.Point(35, 89);
            this.labelRelationshipType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRelationshipType.Name = "labelRelationshipType";
            this.labelRelationshipType.Size = new System.Drawing.Size(158, 24);
            this.labelRelationshipType.TabIndex = 2;
            this.labelRelationshipType.Text = "Relationship type:";
            // 
            // labelCompanion
            // 
            this.labelCompanion.AutoSize = true;
            this.labelCompanion.Location = new System.Drawing.Point(35, 120);
            this.labelCompanion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanion.Name = "labelCompanion";
            this.labelCompanion.Size = new System.Drawing.Size(125, 24);
            this.labelCompanion.TabIndex = 1;
            this.labelCompanion.Text = "Other Animal:";
            // 
            // Relationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 550);
            this.Controls.Add(this.groupBoxRelationships);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Relationships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relationships";
            this.groupBoxRelationships.ResumeLayout(false);
            this.groupBoxRelationships.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRelationships;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMainAnimal;
        private System.Windows.Forms.Button btnDeleteRelationship;
        private System.Windows.Forms.ListBox lbxDisplayAnimalRelationships;
        private System.Windows.Forms.ComboBox cbOtherAnimal;
        private System.Windows.Forms.ComboBox cbRelationShipType;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.Label labelRelationshipType;
        private System.Windows.Forms.Label labelCompanion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}