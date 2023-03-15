namespace ZooBazaarDesktopApp
{
    partial class FormScheduleTask
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
            this.calTaskDateSelection = new System.Windows.Forms.MonthCalendar();
            this.dtpTaskTime = new System.Windows.Forms.DateTimePicker();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.lvwTasksInProgress = new System.Windows.Forms.ListView();
            this.tabControlScheduledTasks = new System.Windows.Forms.TabControl();
            this.tabPageInProgress = new System.Windows.Forms.TabPage();
            this.tabPageFinished = new System.Windows.Forms.TabPage();
            this.lvwFinishedTasks = new System.Windows.Forms.ListView();
            this.labelScheduledTasks = new System.Windows.Forms.Label();
            this.btnMoreTaskDetails = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnScheduleTask = new System.Windows.Forms.Button();
            this.tbxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.groupBoxScheduleNewTask = new System.Windows.Forms.GroupBox();
            this.groupBoxAnimalSearch = new System.Windows.Forms.GroupBox();
            this.lvwAnimalSearch = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.cbxSearchBySpecie = new System.Windows.Forms.ComboBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.nudEstimatedTaskTime = new System.Windows.Forms.NumericUpDown();
            this.tabControlScheduledTasks.SuspendLayout();
            this.tabPageInProgress.SuspendLayout();
            this.tabPageFinished.SuspendLayout();
            this.groupBoxScheduleNewTask.SuspendLayout();
            this.groupBoxAnimalSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).BeginInit();
            this.SuspendLayout();
            // 
            // calTaskDateSelection
            // 
            this.calTaskDateSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calTaskDateSelection.Location = new System.Drawing.Point(497, 49);
            this.calTaskDateSelection.Name = "calTaskDateSelection";
            this.calTaskDateSelection.TabIndex = 0;
            // 
            // dtpTaskTime
            // 
            this.dtpTaskTime.CustomFormat = "    HH:00";
            this.dtpTaskTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskTime.Location = new System.Drawing.Point(576, 223);
            this.dtpTaskTime.Name = "dtpTaskTime";
            this.dtpTaskTime.Size = new System.Drawing.Size(148, 29);
            this.dtpTaskTime.TabIndex = 1;
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Location = new System.Drawing.Point(493, 228);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(58, 24);
            this.labelTaskTime.TabIndex = 2;
            this.labelTaskTime.Text = "Time:";
            // 
            // lvwTasksInProgress
            // 
            this.lvwTasksInProgress.HideSelection = false;
            this.lvwTasksInProgress.Location = new System.Drawing.Point(6, 5);
            this.lvwTasksInProgress.Name = "lvwTasksInProgress";
            this.lvwTasksInProgress.Size = new System.Drawing.Size(418, 410);
            this.lvwTasksInProgress.TabIndex = 3;
            this.lvwTasksInProgress.UseCompatibleStateImageBehavior = false;
            // 
            // tabControlScheduledTasks
            // 
            this.tabControlScheduledTasks.Controls.Add(this.tabPageInProgress);
            this.tabControlScheduledTasks.Controls.Add(this.tabPageFinished);
            this.tabControlScheduledTasks.Location = new System.Drawing.Point(771, 43);
            this.tabControlScheduledTasks.Name = "tabControlScheduledTasks";
            this.tabControlScheduledTasks.SelectedIndex = 0;
            this.tabControlScheduledTasks.Size = new System.Drawing.Size(467, 458);
            this.tabControlScheduledTasks.TabIndex = 4;
            // 
            // tabPageInProgress
            // 
            this.tabPageInProgress.Controls.Add(this.lvwTasksInProgress);
            this.tabPageInProgress.Location = new System.Drawing.Point(4, 33);
            this.tabPageInProgress.Name = "tabPageInProgress";
            this.tabPageInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInProgress.Size = new System.Drawing.Size(430, 421);
            this.tabPageInProgress.TabIndex = 0;
            this.tabPageInProgress.Text = "In progress";
            this.tabPageInProgress.UseVisualStyleBackColor = true;
            // 
            // tabPageFinished
            // 
            this.tabPageFinished.Controls.Add(this.lvwFinishedTasks);
            this.tabPageFinished.Location = new System.Drawing.Point(4, 33);
            this.tabPageFinished.Name = "tabPageFinished";
            this.tabPageFinished.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinished.Size = new System.Drawing.Size(459, 421);
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
            // labelScheduledTasks
            // 
            this.labelScheduledTasks.AutoSize = true;
            this.labelScheduledTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduledTasks.Location = new System.Drawing.Point(769, 9);
            this.labelScheduledTasks.Name = "labelScheduledTasks";
            this.labelScheduledTasks.Size = new System.Drawing.Size(229, 31);
            this.labelScheduledTasks.TabIndex = 5;
            this.labelScheduledTasks.Text = "Scheduled tasks";
            // 
            // btnMoreTaskDetails
            // 
            this.btnMoreTaskDetails.Location = new System.Drawing.Point(1025, 503);
            this.btnMoreTaskDetails.Name = "btnMoreTaskDetails";
            this.btnMoreTaskDetails.Size = new System.Drawing.Size(209, 44);
            this.btnMoreTaskDetails.TabIndex = 6;
            this.btnMoreTaskDetails.Text = "More details";
            this.btnMoreTaskDetails.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(775, 503);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(209, 44);
            this.btnRemoveTask.TabIndex = 7;
            this.btnRemoveTask.Text = "Remove task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // btnScheduleTask
            // 
            this.btnScheduleTask.Location = new System.Drawing.Point(6, 511);
            this.btnScheduleTask.Name = "btnScheduleTask";
            this.btnScheduleTask.Size = new System.Drawing.Size(177, 44);
            this.btnScheduleTask.TabIndex = 8;
            this.btnScheduleTask.Text = "Schedule task";
            this.btnScheduleTask.UseVisualStyleBackColor = true;
            // 
            // tbxTaskDescription
            // 
            this.tbxTaskDescription.Location = new System.Drawing.Point(6, 359);
            this.tbxTaskDescription.Multiline = true;
            this.tbxTaskDescription.Name = "tbxTaskDescription";
            this.tbxTaskDescription.Size = new System.Drawing.Size(718, 146);
            this.tbxTaskDescription.TabIndex = 9;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(2, 332);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(147, 24);
            this.labelTaskDescription.TabIndex = 10;
            this.labelTaskDescription.Text = "Task description";
            // 
            // groupBoxScheduleNewTask
            // 
            this.groupBoxScheduleNewTask.Controls.Add(this.groupBoxAnimalSearch);
            this.groupBoxScheduleNewTask.Controls.Add(this.labelHours);
            this.groupBoxScheduleNewTask.Controls.Add(this.labelEstimatedTime);
            this.groupBoxScheduleNewTask.Controls.Add(this.nudEstimatedTaskTime);
            this.groupBoxScheduleNewTask.Controls.Add(this.tbxTaskDescription);
            this.groupBoxScheduleNewTask.Controls.Add(this.labelTaskDescription);
            this.groupBoxScheduleNewTask.Controls.Add(this.btnScheduleTask);
            this.groupBoxScheduleNewTask.Controls.Add(this.dtpTaskTime);
            this.groupBoxScheduleNewTask.Controls.Add(this.labelTaskTime);
            this.groupBoxScheduleNewTask.Controls.Add(this.calTaskDateSelection);
            this.groupBoxScheduleNewTask.Location = new System.Drawing.Point(12, 9);
            this.groupBoxScheduleNewTask.Name = "groupBoxScheduleNewTask";
            this.groupBoxScheduleNewTask.Size = new System.Drawing.Size(742, 573);
            this.groupBoxScheduleNewTask.TabIndex = 11;
            this.groupBoxScheduleNewTask.TabStop = false;
            this.groupBoxScheduleNewTask.Text = "Schedule new task";
            this.groupBoxScheduleNewTask.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxAnimalSearch
            // 
            this.groupBoxAnimalSearch.Controls.Add(this.lvwAnimalSearch);
            this.groupBoxAnimalSearch.Controls.Add(this.labelSearchByName);
            this.groupBoxAnimalSearch.Controls.Add(this.labelSpecies);
            this.groupBoxAnimalSearch.Controls.Add(this.tbxSearchByName);
            this.groupBoxAnimalSearch.Controls.Add(this.cbxSearchBySpecie);
            this.groupBoxAnimalSearch.Location = new System.Drawing.Point(6, 38);
            this.groupBoxAnimalSearch.Name = "groupBoxAnimalSearch";
            this.groupBoxAnimalSearch.Size = new System.Drawing.Size(479, 284);
            this.groupBoxAnimalSearch.TabIndex = 19;
            this.groupBoxAnimalSearch.TabStop = false;
            this.groupBoxAnimalSearch.Text = "Animal search";
            // 
            // lvwAnimalSearch
            // 
            this.lvwAnimalSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colSpecie,
            this.colName});
            this.lvwAnimalSearch.HideSelection = false;
            this.lvwAnimalSearch.Location = new System.Drawing.Point(15, 117);
            this.lvwAnimalSearch.Name = "lvwAnimalSearch";
            this.lvwAnimalSearch.Size = new System.Drawing.Size(445, 158);
            this.lvwAnimalSearch.TabIndex = 15;
            this.lvwAnimalSearch.UseCompatibleStateImageBehavior = false;
            this.lvwAnimalSearch.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 62;
            // 
            // colSpecie
            // 
            this.colSpecie.Text = "Specie";
            this.colSpecie.Width = 147;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 174;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Location = new System.Drawing.Point(80, 80);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(153, 24);
            this.labelSearchByName.TabIndex = 16;
            this.labelSearchByName.Text = "Search by name:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(150, 42);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(83, 24);
            this.labelSpecies.TabIndex = 18;
            this.labelSpecies.Text = "Species:";
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(253, 77);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(207, 29);
            this.tbxSearchByName.TabIndex = 14;
            // 
            // cbxSearchBySpecie
            // 
            this.cbxSearchBySpecie.FormattingEnabled = true;
            this.cbxSearchBySpecie.Location = new System.Drawing.Point(253, 39);
            this.cbxSearchBySpecie.Name = "cbxSearchBySpecie";
            this.cbxSearchBySpecie.Size = new System.Drawing.Size(207, 32);
            this.cbxSearchBySpecie.TabIndex = 17;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(636, 295);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(70, 24);
            this.labelHours.TabIndex = 13;
            this.labelHours.Text = "hour(s)";
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.AutoSize = true;
            this.labelEstimatedTime.Location = new System.Drawing.Point(493, 266);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(137, 24);
            this.labelEstimatedTime.TabIndex = 12;
            this.labelEstimatedTime.Text = "Estimated time:";
            // 
            // nudEstimatedTaskTime
            // 
            this.nudEstimatedTaskTime.Location = new System.Drawing.Point(497, 293);
            this.nudEstimatedTaskTime.Name = "nudEstimatedTaskTime";
            this.nudEstimatedTaskTime.Size = new System.Drawing.Size(133, 29);
            this.nudEstimatedTaskTime.TabIndex = 11;
            // 
            // FormScheduleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1255, 588);
            this.Controls.Add(this.groupBoxScheduleNewTask);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnMoreTaskDetails);
            this.Controls.Add(this.labelScheduledTasks);
            this.Controls.Add(this.tabControlScheduledTasks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormScheduleTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScheduleTask";
            this.tabControlScheduledTasks.ResumeLayout(false);
            this.tabPageInProgress.ResumeLayout(false);
            this.tabPageFinished.ResumeLayout(false);
            this.groupBoxScheduleNewTask.ResumeLayout(false);
            this.groupBoxScheduleNewTask.PerformLayout();
            this.groupBoxAnimalSearch.ResumeLayout(false);
            this.groupBoxAnimalSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calTaskDateSelection;
        private System.Windows.Forms.DateTimePicker dtpTaskTime;
        private System.Windows.Forms.Label labelTaskTime;
        private System.Windows.Forms.ListView lvwTasksInProgress;
        private System.Windows.Forms.TabControl tabControlScheduledTasks;
        private System.Windows.Forms.TabPage tabPageInProgress;
        private System.Windows.Forms.TabPage tabPageFinished;
        private System.Windows.Forms.ListView lvwFinishedTasks;
        private System.Windows.Forms.Label labelScheduledTasks;
        private System.Windows.Forms.Button btnMoreTaskDetails;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnScheduleTask;
        private System.Windows.Forms.TextBox tbxTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.GroupBox groupBoxScheduleNewTask;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.NumericUpDown nudEstimatedTaskTime;
        private System.Windows.Forms.ListView lvwAnimalSearch;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.GroupBox groupBoxAnimalSearch;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colSpecie;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.ComboBox cbxSearchBySpecie;
    }
}