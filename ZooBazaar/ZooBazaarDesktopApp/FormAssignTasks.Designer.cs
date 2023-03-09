namespace ZooBazaarDesktopApp
{
    partial class FormAssignTasks
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
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnMoreTaskDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvwTasksInProgress = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwFinishedTasks = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(279, 499);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(268, 44);
            this.btnRemoveTask.TabIndex = 11;
            this.btnRemoveTask.Text = "Assign employee";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // btnMoreTaskDetails
            // 
            this.btnMoreTaskDetails.Location = new System.Drawing.Point(3, 499);
            this.btnMoreTaskDetails.Name = "btnMoreTaskDetails";
            this.btnMoreTaskDetails.Size = new System.Drawing.Size(268, 44);
            this.btnMoreTaskDetails.TabIndex = 10;
            this.btnMoreTaskDetails.Text = "More details";
            this.btnMoreTaskDetails.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Scheduled tasks";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 458);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvwTasksInProgress);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "In progress";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvwTasksInProgress
            // 
            this.lvwTasksInProgress.HideSelection = false;
            this.lvwTasksInProgress.Location = new System.Drawing.Point(6, 6);
            this.lvwTasksInProgress.Name = "lvwTasksInProgress";
            this.lvwTasksInProgress.Size = new System.Drawing.Size(524, 410);
            this.lvwTasksInProgress.TabIndex = 3;
            this.lvwTasksInProgress.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvwFinishedTasks);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finished";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvwFinishedTasks
            // 
            this.lvwFinishedTasks.HideSelection = false;
            this.lvwFinishedTasks.Location = new System.Drawing.Point(6, 5);
            this.lvwFinishedTasks.Name = "lvwFinishedTasks";
            this.lvwFinishedTasks.Size = new System.Drawing.Size(524, 410);
            this.lvwFinishedTasks.TabIndex = 4;
            this.lvwFinishedTasks.UseCompatibleStateImageBehavior = false;
            // 
            // FormAssignTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 561);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnMoreTaskDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAssignTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAssignTasks";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnMoreTaskDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvwTasksInProgress;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvwFinishedTasks;
    }
}