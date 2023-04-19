namespace DesktopApplication
{
    partial class PopupTaskDetails
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
            this.lblTaskDetails = new System.Windows.Forms.Label();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.lblTaskAnimalSpecies = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.tbxTaskID = new System.Windows.Forms.TextBox();
            this.tbxTaskTitle = new System.Windows.Forms.TextBox();
            this.groupBoxTaskDescription = new System.Windows.Forms.GroupBox();
            this.tbxTaskDescription = new System.Windows.Forms.TextBox();
            this.btnCloseDetails = new System.Windows.Forms.Button();
            this.lblAssignedEmployee = new System.Windows.Forms.Label();
            this.tbxAssignedEmployee = new System.Windows.Forms.TextBox();
            this.tbxAnimalSpecies = new System.Windows.Forms.TextBox();
            this.tbxTaskAnimalName = new System.Windows.Forms.TextBox();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.tbxTaskDate = new System.Windows.Forms.TextBox();
            this.lblTaskEstimatedTime = new System.Windows.Forms.Label();
            this.tbxEstimatedTaskTime = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.groupBoxTaskDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaskDetails
            // 
            this.lblTaskDetails.AutoSize = true;
            this.lblTaskDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDetails.Location = new System.Drawing.Point(15, 26);
            this.lblTaskDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTaskDetails.Name = "lblTaskDetails";
            this.lblTaskDetails.Size = new System.Drawing.Size(188, 37);
            this.lblTaskDetails.TabIndex = 0;
            this.lblTaskDetails.Text = "Task details";
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Location = new System.Drawing.Point(300, 36);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(32, 24);
            this.lblTaskID.TabIndex = 1;
            this.lblTaskID.Text = "ID:";
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Location = new System.Drawing.Point(22, 87);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(50, 24);
            this.lblTaskTitle.TabIndex = 2;
            this.lblTaskTitle.Text = "Title:";
            // 
            // lblTaskAnimalSpecies
            // 
            this.lblTaskAnimalSpecies.AutoSize = true;
            this.lblTaskAnimalSpecies.Location = new System.Drawing.Point(24, 238);
            this.lblTaskAnimalSpecies.Name = "lblTaskAnimalSpecies";
            this.lblTaskAnimalSpecies.Size = new System.Drawing.Size(143, 24);
            this.lblTaskAnimalSpecies.TabIndex = 4;
            this.lblTaskAnimalSpecies.Text = "Animal species:";
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(24, 287);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(126, 24);
            this.lblAnimalName.TabIndex = 5;
            this.lblAnimalName.Text = "Animal name:";
            // 
            // tbxTaskID
            // 
            this.tbxTaskID.Location = new System.Drawing.Point(347, 33);
            this.tbxTaskID.Name = "tbxTaskID";
            this.tbxTaskID.ReadOnly = true;
            this.tbxTaskID.Size = new System.Drawing.Size(76, 29);
            this.tbxTaskID.TabIndex = 7;
            // 
            // tbxTaskTitle
            // 
            this.tbxTaskTitle.Location = new System.Drawing.Point(96, 84);
            this.tbxTaskTitle.Name = "tbxTaskTitle";
            this.tbxTaskTitle.ReadOnly = true;
            this.tbxTaskTitle.Size = new System.Drawing.Size(327, 29);
            this.tbxTaskTitle.TabIndex = 8;
            // 
            // groupBoxTaskDescription
            // 
            this.groupBoxTaskDescription.Controls.Add(this.tbxTaskDescription);
            this.groupBoxTaskDescription.Location = new System.Drawing.Point(22, 329);
            this.groupBoxTaskDescription.Name = "groupBoxTaskDescription";
            this.groupBoxTaskDescription.Size = new System.Drawing.Size(411, 239);
            this.groupBoxTaskDescription.TabIndex = 9;
            this.groupBoxTaskDescription.TabStop = false;
            this.groupBoxTaskDescription.Text = "Description:";
            // 
            // tbxTaskDescription
            // 
            this.tbxTaskDescription.Location = new System.Drawing.Point(6, 28);
            this.tbxTaskDescription.Multiline = true;
            this.tbxTaskDescription.Name = "tbxTaskDescription";
            this.tbxTaskDescription.ReadOnly = true;
            this.tbxTaskDescription.Size = new System.Drawing.Size(395, 200);
            this.tbxTaskDescription.TabIndex = 10;
            // 
            // btnCloseDetails
            // 
            this.btnCloseDetails.Location = new System.Drawing.Point(28, 657);
            this.btnCloseDetails.Name = "btnCloseDetails";
            this.btnCloseDetails.Size = new System.Drawing.Size(204, 37);
            this.btnCloseDetails.TabIndex = 10;
            this.btnCloseDetails.Text = "Close";
            this.btnCloseDetails.UseVisualStyleBackColor = true;
            this.btnCloseDetails.Click += new System.EventHandler(this.btnCloseDetails_Click);
            // 
            // lblAssignedEmployee
            // 
            this.lblAssignedEmployee.AutoSize = true;
            this.lblAssignedEmployee.Location = new System.Drawing.Point(22, 579);
            this.lblAssignedEmployee.Name = "lblAssignedEmployee";
            this.lblAssignedEmployee.Size = new System.Drawing.Size(183, 24);
            this.lblAssignedEmployee.TabIndex = 11;
            this.lblAssignedEmployee.Text = "Assigned employee:";
            // 
            // tbxAssignedEmployee
            // 
            this.tbxAssignedEmployee.Location = new System.Drawing.Point(26, 606);
            this.tbxAssignedEmployee.Name = "tbxAssignedEmployee";
            this.tbxAssignedEmployee.ReadOnly = true;
            this.tbxAssignedEmployee.Size = new System.Drawing.Size(280, 29);
            this.tbxAssignedEmployee.TabIndex = 12;
            // 
            // tbxAnimalSpecies
            // 
            this.tbxAnimalSpecies.Location = new System.Drawing.Point(220, 235);
            this.tbxAnimalSpecies.Name = "tbxAnimalSpecies";
            this.tbxAnimalSpecies.ReadOnly = true;
            this.tbxAnimalSpecies.Size = new System.Drawing.Size(203, 29);
            this.tbxAnimalSpecies.TabIndex = 13;
            // 
            // tbxTaskAnimalName
            // 
            this.tbxTaskAnimalName.Location = new System.Drawing.Point(220, 284);
            this.tbxTaskAnimalName.Name = "tbxTaskAnimalName";
            this.tbxTaskAnimalName.ReadOnly = true;
            this.tbxTaskAnimalName.Size = new System.Drawing.Size(203, 29);
            this.tbxTaskAnimalName.TabIndex = 14;
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.AutoSize = true;
            this.lblTaskDate.Location = new System.Drawing.Point(22, 135);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(53, 24);
            this.lblTaskDate.TabIndex = 15;
            this.lblTaskDate.Text = "Date:";
            // 
            // tbxTaskDate
            // 
            this.tbxTaskDate.Location = new System.Drawing.Point(96, 132);
            this.tbxTaskDate.Name = "tbxTaskDate";
            this.tbxTaskDate.ReadOnly = true;
            this.tbxTaskDate.Size = new System.Drawing.Size(226, 29);
            this.tbxTaskDate.TabIndex = 16;
            // 
            // lblTaskEstimatedTime
            // 
            this.lblTaskEstimatedTime.AutoSize = true;
            this.lblTaskEstimatedTime.Location = new System.Drawing.Point(24, 189);
            this.lblTaskEstimatedTime.Name = "lblTaskEstimatedTime";
            this.lblTaskEstimatedTime.Size = new System.Drawing.Size(137, 24);
            this.lblTaskEstimatedTime.TabIndex = 17;
            this.lblTaskEstimatedTime.Text = "Estimated time:";
            // 
            // tbxEstimatedTaskTime
            // 
            this.tbxEstimatedTaskTime.Location = new System.Drawing.Point(220, 186);
            this.tbxEstimatedTaskTime.Name = "tbxEstimatedTaskTime";
            this.tbxEstimatedTaskTime.ReadOnly = true;
            this.tbxEstimatedTaskTime.Size = new System.Drawing.Size(85, 29);
            this.tbxEstimatedTaskTime.TabIndex = 18;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(311, 189);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(70, 24);
            this.lblHours.TabIndex = 19;
            this.lblHours.Text = "hour(s)";
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStatus.Location = new System.Drawing.Point(267, 657);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(114, 37);
            this.lblTaskStatus.TabIndex = 20;
            this.lblTaskStatus.Text = "Status";
            // 
            // PopupTaskDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 706);
            this.Controls.Add(this.lblTaskStatus);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.tbxEstimatedTaskTime);
            this.Controls.Add(this.lblTaskEstimatedTime);
            this.Controls.Add(this.tbxTaskDate);
            this.Controls.Add(this.lblTaskDate);
            this.Controls.Add(this.tbxTaskAnimalName);
            this.Controls.Add(this.tbxAnimalSpecies);
            this.Controls.Add(this.tbxAssignedEmployee);
            this.Controls.Add(this.lblAssignedEmployee);
            this.Controls.Add(this.btnCloseDetails);
            this.Controls.Add(this.groupBoxTaskDescription);
            this.Controls.Add(this.tbxTaskTitle);
            this.Controls.Add(this.tbxTaskID);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.lblTaskAnimalSpecies);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.lblTaskDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PopupTaskDetails";
            this.Text = "PopupTaskDetails";
            this.groupBoxTaskDescription.ResumeLayout(false);
            this.groupBoxTaskDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskDetails;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.Label lblTaskAnimalSpecies;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.TextBox tbxTaskID;
        private System.Windows.Forms.TextBox tbxTaskTitle;
        private System.Windows.Forms.GroupBox groupBoxTaskDescription;
        private System.Windows.Forms.TextBox tbxTaskDescription;
        private System.Windows.Forms.Button btnCloseDetails;
        private System.Windows.Forms.Label lblAssignedEmployee;
        private System.Windows.Forms.TextBox tbxAssignedEmployee;
        private System.Windows.Forms.TextBox tbxAnimalSpecies;
        private System.Windows.Forms.TextBox tbxTaskAnimalName;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.TextBox tbxTaskDate;
        private System.Windows.Forms.Label lblTaskEstimatedTime;
        private System.Windows.Forms.TextBox tbxEstimatedTaskTime;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblTaskStatus;
    }
}