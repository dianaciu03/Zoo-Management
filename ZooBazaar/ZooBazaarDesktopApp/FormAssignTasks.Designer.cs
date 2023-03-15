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
            this.labelScheduledTasks = new System.Windows.Forms.Label();
            this.tabControlScheduledTasks = new System.Windows.Forms.TabControl();
            this.tabPageInProgress = new System.Windows.Forms.TabPage();
            this.lvwTasksInProgress = new System.Windows.Forms.ListView();
            this.tabPageFinished = new System.Windows.Forms.TabPage();
            this.lvwFinishedTasks = new System.Windows.Forms.ListView();
            this.lvwCaretakers = new System.Windows.Forms.ListView();
            this.labelCaretakers = new System.Windows.Forms.Label();
            this.tabControlScheduledTasks.SuspendLayout();
            this.tabPageInProgress.SuspendLayout();
            this.tabPageFinished.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(568, 499);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(268, 44);
            this.btnRemoveTask.TabIndex = 11;
            this.btnRemoveTask.Text = "Assign employee";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
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
            // labelScheduledTasks
            // 
            this.labelScheduledTasks.AutoSize = true;
            this.labelScheduledTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduledTasks.Location = new System.Drawing.Point(1, 5);
            this.labelScheduledTasks.Name = "labelScheduledTasks";
            this.labelScheduledTasks.Size = new System.Drawing.Size(229, 31);
            this.labelScheduledTasks.TabIndex = 9;
            this.labelScheduledTasks.Text = "Scheduled tasks";
            // 
            // tabControlScheduledTasks
            // 
            this.tabControlScheduledTasks.Controls.Add(this.tabPageInProgress);
            this.tabControlScheduledTasks.Controls.Add(this.tabPageFinished);
            this.tabControlScheduledTasks.Location = new System.Drawing.Point(3, 39);
            this.tabControlScheduledTasks.Name = "tabControlScheduledTasks";
            this.tabControlScheduledTasks.SelectedIndex = 0;
            this.tabControlScheduledTasks.Size = new System.Drawing.Size(544, 458);
            this.tabControlScheduledTasks.TabIndex = 8;
            // 
            // tabPageInProgress
            // 
            this.tabPageInProgress.Controls.Add(this.lvwTasksInProgress);
            this.tabPageInProgress.Location = new System.Drawing.Point(4, 33);
            this.tabPageInProgress.Name = "tabPageInProgress";
            this.tabPageInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInProgress.Size = new System.Drawing.Size(536, 421);
            this.tabPageInProgress.TabIndex = 0;
            this.tabPageInProgress.Text = "In progress";
            this.tabPageInProgress.UseVisualStyleBackColor = true;
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
            // tabPageFinished
            // 
            this.tabPageFinished.Controls.Add(this.lvwFinishedTasks);
            this.tabPageFinished.Location = new System.Drawing.Point(4, 33);
            this.tabPageFinished.Name = "tabPageFinished";
            this.tabPageFinished.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinished.Size = new System.Drawing.Size(536, 421);
            this.tabPageFinished.TabIndex = 1;
            this.tabPageFinished.Text = "Finished";
            this.tabPageFinished.UseVisualStyleBackColor = true;
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
            // lvwCaretakers
            // 
            this.lvwCaretakers.HideSelection = false;
            this.lvwCaretakers.Location = new System.Drawing.Point(568, 72);
            this.lvwCaretakers.Name = "lvwCaretakers";
            this.lvwCaretakers.Size = new System.Drawing.Size(524, 421);
            this.lvwCaretakers.TabIndex = 12;
            this.lvwCaretakers.UseCompatibleStateImageBehavior = false;
            // 
            // labelCaretakers
            // 
            this.labelCaretakers.AutoSize = true;
            this.labelCaretakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaretakers.Location = new System.Drawing.Point(564, 45);
            this.labelCaretakers.Name = "labelCaretakers";
            this.labelCaretakers.Size = new System.Drawing.Size(104, 24);
            this.labelCaretakers.TabIndex = 13;
            this.labelCaretakers.Text = "Care takers";
            // 
            // FormAssignTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1104, 561);
            this.Controls.Add(this.labelCaretakers);
            this.Controls.Add(this.lvwCaretakers);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnMoreTaskDetails);
            this.Controls.Add(this.labelScheduledTasks);
            this.Controls.Add(this.tabControlScheduledTasks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAssignTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAssignTasks";
            this.tabControlScheduledTasks.ResumeLayout(false);
            this.tabPageInProgress.ResumeLayout(false);
            this.tabPageFinished.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnMoreTaskDetails;
        private System.Windows.Forms.Label labelScheduledTasks;
        private System.Windows.Forms.TabControl tabControlScheduledTasks;
        private System.Windows.Forms.TabPage tabPageInProgress;
        private System.Windows.Forms.ListView lvwTasksInProgress;
        private System.Windows.Forms.TabPage tabPageFinished;
        private System.Windows.Forms.ListView lvwFinishedTasks;
        private System.Windows.Forms.ListView lvwCaretakers;
        private System.Windows.Forms.Label labelCaretakers;
    }
}