namespace ZooBazaarDesktopApp
{
    partial class FormScheduleMaker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelScheduledTasks = new System.Windows.Forms.Label();
            this.tabControlScheduledTasks = new System.Windows.Forms.TabControl();
            this.tabPageInProgress = new System.Windows.Forms.TabPage();
            this.lvwTasksInProgress = new System.Windows.Forms.ListView();
            this.tabPageFinished = new System.Windows.Forms.TabPage();
            this.lvwFinishedTasks = new System.Windows.Forms.ListView();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
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
            this.tbxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.btnScheduleTask = new System.Windows.Forms.Button();
            this.dtpTaskTime = new System.Windows.Forms.DateTimePicker();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.calTaskDateSelection = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnMoreTaskDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlScheduledTasks.SuspendLayout();
            this.tabPageInProgress.SuspendLayout();
            this.tabPageFinished.SuspendLayout();
            this.groupBoxAnimalSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(70, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1249, 614);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBoxAnimalSearch);
            this.tabPage1.Controls.Add(this.labelHours);
            this.tabPage1.Controls.Add(this.labelEstimatedTime);
            this.tabPage1.Controls.Add(this.nudEstimatedTaskTime);
            this.tabPage1.Controls.Add(this.tbxTaskDescription);
            this.tabPage1.Controls.Add(this.labelTaskDescription);
            this.tabPage1.Controls.Add(this.btnScheduleTask);
            this.tabPage1.Controls.Add(this.dtpTaskTime);
            this.tabPage1.Controls.Add(this.labelTaskTime);
            this.tabPage1.Controls.Add(this.calTaskDateSelection);
            this.tabPage1.Controls.Add(this.labelScheduledTasks);
            this.tabPage1.Controls.Add(this.tabControlScheduledTasks);
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1241, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule task";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelScheduledTasks
            // 
            this.labelScheduledTasks.AutoSize = true;
            this.labelScheduledTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduledTasks.Location = new System.Drawing.Point(753, 12);
            this.labelScheduledTasks.Name = "labelScheduledTasks";
            this.labelScheduledTasks.Size = new System.Drawing.Size(255, 31);
            this.labelScheduledTasks.TabIndex = 13;
            this.labelScheduledTasks.Text = "Scheduled tasks - ";
            // 
            // tabControlScheduledTasks
            // 
            this.tabControlScheduledTasks.Controls.Add(this.tabPageInProgress);
            this.tabControlScheduledTasks.Controls.Add(this.tabPageFinished);
            this.tabControlScheduledTasks.Controls.Add(this.tabPage3);
            this.tabControlScheduledTasks.Location = new System.Drawing.Point(755, 46);
            this.tabControlScheduledTasks.Name = "tabControlScheduledTasks";
            this.tabControlScheduledTasks.Padding = new System.Drawing.Point(36, 4);
            this.tabControlScheduledTasks.SelectedIndex = 0;
            this.tabControlScheduledTasks.Size = new System.Drawing.Size(467, 513);
            this.tabControlScheduledTasks.TabIndex = 12;
            // 
            // tabPageInProgress
            // 
            this.tabPageInProgress.Controls.Add(this.btnRemoveTask);
            this.tabPageInProgress.Controls.Add(this.btnMoreTaskDetails);
            this.tabPageInProgress.Controls.Add(this.lvwTasksInProgress);
            this.tabPageInProgress.Location = new System.Drawing.Point(4, 35);
            this.tabPageInProgress.Name = "tabPageInProgress";
            this.tabPageInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInProgress.Size = new System.Drawing.Size(459, 474);
            this.tabPageInProgress.TabIndex = 0;
            this.tabPageInProgress.Text = "Available";
            this.tabPageInProgress.UseVisualStyleBackColor = true;
            // 
            // lvwTasksInProgress
            // 
            this.lvwTasksInProgress.HideSelection = false;
            this.lvwTasksInProgress.Location = new System.Drawing.Point(6, 5);
            this.lvwTasksInProgress.Name = "lvwTasksInProgress";
            this.lvwTasksInProgress.Size = new System.Drawing.Size(447, 414);
            this.lvwTasksInProgress.TabIndex = 3;
            this.lvwTasksInProgress.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageFinished
            // 
            this.tabPageFinished.Controls.Add(this.button1);
            this.tabPageFinished.Controls.Add(this.lvwFinishedTasks);
            this.tabPageFinished.Location = new System.Drawing.Point(4, 35);
            this.tabPageFinished.Name = "tabPageFinished";
            this.tabPageFinished.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinished.Size = new System.Drawing.Size(459, 474);
            this.tabPageFinished.TabIndex = 1;
            this.tabPageFinished.Text = "In progress";
            this.tabPageFinished.UseVisualStyleBackColor = true;
            // 
            // lvwFinishedTasks
            // 
            this.lvwFinishedTasks.HideSelection = false;
            this.lvwFinishedTasks.Location = new System.Drawing.Point(6, 5);
            this.lvwFinishedTasks.Name = "lvwFinishedTasks";
            this.lvwFinishedTasks.Size = new System.Drawing.Size(447, 414);
            this.lvwFinishedTasks.TabIndex = 4;
            this.lvwFinishedTasks.UseCompatibleStateImageBehavior = false;
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(591, 9);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(184, 37);
            this.labelTitleZooBazaar.TabIndex = 11;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // groupBoxAnimalSearch
            // 
            this.groupBoxAnimalSearch.Controls.Add(this.lvwAnimalSearch);
            this.groupBoxAnimalSearch.Controls.Add(this.labelSearchByName);
            this.groupBoxAnimalSearch.Controls.Add(this.labelSpecies);
            this.groupBoxAnimalSearch.Controls.Add(this.tbxSearchByName);
            this.groupBoxAnimalSearch.Controls.Add(this.cbxSearchBySpecie);
            this.groupBoxAnimalSearch.Location = new System.Drawing.Point(15, 21);
            this.groupBoxAnimalSearch.Name = "groupBoxAnimalSearch";
            this.groupBoxAnimalSearch.Size = new System.Drawing.Size(454, 287);
            this.groupBoxAnimalSearch.TabIndex = 29;
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
            this.lvwAnimalSearch.Size = new System.Drawing.Size(425, 158);
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
            this.colSpecie.Width = 159;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 174;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Location = new System.Drawing.Point(11, 72);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(153, 24);
            this.labelSearchByName.TabIndex = 16;
            this.labelSearchByName.Text = "Search by name:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(11, 34);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(83, 24);
            this.labelSpecies.TabIndex = 18;
            this.labelSpecies.Text = "Species:";
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(170, 69);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(207, 29);
            this.tbxSearchByName.TabIndex = 14;
            // 
            // cbxSearchBySpecie
            // 
            this.cbxSearchBySpecie.FormattingEnabled = true;
            this.cbxSearchBySpecie.Location = new System.Drawing.Point(170, 31);
            this.cbxSearchBySpecie.Name = "cbxSearchBySpecie";
            this.cbxSearchBySpecie.Size = new System.Drawing.Size(207, 32);
            this.cbxSearchBySpecie.TabIndex = 17;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(630, 281);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(70, 24);
            this.labelHours.TabIndex = 28;
            this.labelHours.Text = "hour(s)";
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.AutoSize = true;
            this.labelEstimatedTime.Location = new System.Drawing.Point(488, 249);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(170, 24);
            this.labelEstimatedTime.TabIndex = 27;
            this.labelEstimatedTime.Text = "Estimated duration:";
            // 
            // nudEstimatedTaskTime
            // 
            this.nudEstimatedTaskTime.Location = new System.Drawing.Point(491, 279);
            this.nudEstimatedTaskTime.Name = "nudEstimatedTaskTime";
            this.nudEstimatedTaskTime.Size = new System.Drawing.Size(133, 29);
            this.nudEstimatedTaskTime.TabIndex = 26;
            // 
            // tbxTaskDescription
            // 
            this.tbxTaskDescription.Location = new System.Drawing.Point(15, 349);
            this.tbxTaskDescription.Multiline = true;
            this.tbxTaskDescription.Name = "tbxTaskDescription";
            this.tbxTaskDescription.Size = new System.Drawing.Size(718, 151);
            this.tbxTaskDescription.TabIndex = 24;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(11, 322);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(147, 24);
            this.labelTaskDescription.TabIndex = 25;
            this.labelTaskDescription.Text = "Task description";
            // 
            // btnScheduleTask
            // 
            this.btnScheduleTask.Location = new System.Drawing.Point(15, 506);
            this.btnScheduleTask.Name = "btnScheduleTask";
            this.btnScheduleTask.Size = new System.Drawing.Size(177, 44);
            this.btnScheduleTask.TabIndex = 23;
            this.btnScheduleTask.Text = "Schedule task";
            this.btnScheduleTask.UseVisualStyleBackColor = true;
            this.btnScheduleTask.Click += new System.EventHandler(this.btnScheduleTask_Click);
            // 
            // dtpTaskTime
            // 
            this.dtpTaskTime.CustomFormat = "    HH:00";
            this.dtpTaskTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskTime.Location = new System.Drawing.Point(585, 202);
            this.dtpTaskTime.Name = "dtpTaskTime";
            this.dtpTaskTime.Size = new System.Drawing.Size(130, 29);
            this.dtpTaskTime.TabIndex = 21;
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Location = new System.Drawing.Point(488, 206);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(91, 24);
            this.labelTaskTime.TabIndex = 22;
            this.labelTaskTime.Text = "Start time:";
            // 
            // calTaskDateSelection
            // 
            this.calTaskDateSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calTaskDateSelection.Location = new System.Drawing.Point(488, 32);
            this.calTaskDateSelection.Name = "calTaskDateSelection";
            this.calTaskDateSelection.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(998, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Day of the week";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(244, 425);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(209, 44);
            this.btnRemoveTask.TabIndex = 19;
            this.btnRemoveTask.Text = "Remove task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // btnMoreTaskDetails
            // 
            this.btnMoreTaskDetails.Location = new System.Drawing.Point(6, 425);
            this.btnMoreTaskDetails.Name = "btnMoreTaskDetails";
            this.btnMoreTaskDetails.Size = new System.Drawing.Size(209, 44);
            this.btnMoreTaskDetails.TabIndex = 18;
            this.btnMoreTaskDetails.Text = "More details";
            this.btnMoreTaskDetails.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "More details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Finished";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "More details";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 414);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormScheduleMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1275, 674);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormScheduleMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScheduleMaker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControlScheduledTasks.ResumeLayout(false);
            this.tabPageInProgress.ResumeLayout(false);
            this.tabPageFinished.ResumeLayout(false);
            this.groupBoxAnimalSearch.ResumeLayout(false);
            this.groupBoxAnimalSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelScheduledTasks;
        private System.Windows.Forms.TabControl tabControlScheduledTasks;
        private System.Windows.Forms.TabPage tabPageInProgress;
        private System.Windows.Forms.ListView lvwTasksInProgress;
        private System.Windows.Forms.TabPage tabPageFinished;
        private System.Windows.Forms.ListView lvwFinishedTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAnimalSearch;
        private System.Windows.Forms.ListView lvwAnimalSearch;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colSpecie;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.ComboBox cbxSearchBySpecie;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.NumericUpDown nudEstimatedTaskTime;
        private System.Windows.Forms.TextBox tbxTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Button btnScheduleTask;
        private System.Windows.Forms.DateTimePicker dtpTaskTime;
        private System.Windows.Forms.Label labelTaskTime;
        private System.Windows.Forms.MonthCalendar calTaskDateSelection;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnMoreTaskDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTitleZooBazaar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
    }
}