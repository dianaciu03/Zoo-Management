namespace DesktopApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calTaskDateSelection = new System.Windows.Forms.MonthCalendar();
            this.dtpTaskTime = new System.Windows.Forms.DateTimePicker();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.nudEstimatedTaskTime = new System.Windows.Forms.NumericUpDown();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.btnScheduleTask = new System.Windows.Forms.Button();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.tbxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.tbxTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.groupBoxAnimalSearch = new System.Windows.Forms.GroupBox();
            this.lvwAnimalSearch = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colSpecie = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.cbxSearchBySpecie = new System.Windows.Forms.ComboBox();
            this.labelScheduledTasks = new System.Windows.Forms.Label();
            this.tabControlScheduledTasks = new System.Windows.Forms.TabControl();
            this.tabAvailableTasks = new System.Windows.Forms.TabPage();
            this.btnMarkTaskAsFinished = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnMoreTaskDetails = new System.Windows.Forms.Button();
            this.lvwUnassignedTasks = new System.Windows.Forms.ListView();
            this.colTaskName = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.tabTasksInProgress = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lvwTasksInProgress = new System.Windows.Forms.ListView();
            this.tabFinishedTasks = new System.Windows.Forms.TabPage();
            this.btnFinishedTaskMoreDetails = new System.Windows.Forms.Button();
            this.lvwFinishedTasks = new System.Windows.Forms.ListView();
            this.colFinishedTaskName = new System.Windows.Forms.ColumnHeader();
            this.colFinishedTaskDate = new System.Windows.Forms.ColumnHeader();
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).BeginInit();
            this.groupBoxAnimalSearch.SuspendLayout();
            this.tabControlScheduledTasks.SuspendLayout();
            this.tabAvailableTasks.SuspendLayout();
            this.tabTasksInProgress.SuspendLayout();
            this.tabFinishedTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(168, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(70, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1539, 973);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tbxTaskName);
            this.tabPage1.Controls.Add(this.lblTaskName);
            this.tabPage1.Controls.Add(this.groupBoxAnimalSearch);
            this.tabPage1.Controls.Add(this.labelScheduledTasks);
            this.tabPage1.Controls.Add(this.tabControlScheduledTasks);
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1531, 924);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule task";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calTaskDateSelection);
            this.groupBox1.Controls.Add(this.dtpTaskTime);
            this.groupBox1.Controls.Add(this.labelTaskTime);
            this.groupBox1.Controls.Add(this.nudEstimatedTaskTime);
            this.groupBox1.Controls.Add(this.labelEstimatedTime);
            this.groupBox1.Controls.Add(this.btnScheduleTask);
            this.groupBox1.Controls.Add(this.labelTaskDescription);
            this.groupBox1.Controls.Add(this.tbxTaskDescription);
            this.groupBox1.Controls.Add(this.labelHours);
            this.groupBox1.Location = new System.Drawing.Point(50, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 497);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task date and time";
            // 
            // calTaskDateSelection
            // 
            this.calTaskDateSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calTaskDateSelection.Location = new System.Drawing.Point(12, 34);
            this.calTaskDateSelection.MaxSelectionCount = 1;
            this.calTaskDateSelection.Name = "calTaskDateSelection";
            this.calTaskDateSelection.TabIndex = 20;
            // 
            // dtpTaskTime
            // 
            this.dtpTaskTime.CustomFormat = "    HH:mm";
            this.dtpTaskTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskTime.Location = new System.Drawing.Point(370, 30);
            this.dtpTaskTime.Name = "dtpTaskTime";
            this.dtpTaskTime.Size = new System.Drawing.Size(130, 29);
            this.dtpTaskTime.TabIndex = 21;
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Location = new System.Drawing.Point(264, 34);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(91, 24);
            this.labelTaskTime.TabIndex = 22;
            this.labelTaskTime.Text = "Start time:";
            // 
            // nudEstimatedTaskTime
            // 
            this.nudEstimatedTaskTime.Location = new System.Drawing.Point(268, 120);
            this.nudEstimatedTaskTime.Name = "nudEstimatedTaskTime";
            this.nudEstimatedTaskTime.Size = new System.Drawing.Size(133, 29);
            this.nudEstimatedTaskTime.TabIndex = 26;
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.AutoSize = true;
            this.labelEstimatedTime.Location = new System.Drawing.Point(264, 76);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(170, 24);
            this.labelEstimatedTime.TabIndex = 27;
            this.labelEstimatedTime.Text = "Estimated duration:";
            // 
            // btnScheduleTask
            // 
            this.btnScheduleTask.Location = new System.Drawing.Point(12, 440);
            this.btnScheduleTask.Name = "btnScheduleTask";
            this.btnScheduleTask.Size = new System.Drawing.Size(177, 48);
            this.btnScheduleTask.TabIndex = 23;
            this.btnScheduleTask.Text = "Schedule task";
            this.btnScheduleTask.UseVisualStyleBackColor = true;
            this.btnScheduleTask.Click += new System.EventHandler(this.btnScheduleTask_Click);
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(11, 217);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(147, 24);
            this.labelTaskDescription.TabIndex = 25;
            this.labelTaskDescription.Text = "Task description";
            // 
            // tbxTaskDescription
            // 
            this.tbxTaskDescription.Location = new System.Drawing.Point(12, 244);
            this.tbxTaskDescription.Multiline = true;
            this.tbxTaskDescription.Name = "tbxTaskDescription";
            this.tbxTaskDescription.Size = new System.Drawing.Size(682, 190);
            this.tbxTaskDescription.TabIndex = 24;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(407, 122);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(70, 24);
            this.labelHours.TabIndex = 28;
            this.labelHours.Text = "hour(s)";
            // 
            // tbxTaskName
            // 
            this.tbxTaskName.Location = new System.Drawing.Point(188, 32);
            this.tbxTaskName.Name = "tbxTaskName";
            this.tbxTaskName.Size = new System.Drawing.Size(562, 29);
            this.tbxTaskName.TabIndex = 32;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(50, 35);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(108, 24);
            this.lblTaskName.TabIndex = 31;
            this.lblTaskName.Text = "Task name:";
            // 
            // groupBoxAnimalSearch
            // 
            this.groupBoxAnimalSearch.Controls.Add(this.lvwAnimalSearch);
            this.groupBoxAnimalSearch.Controls.Add(this.labelSearchByName);
            this.groupBoxAnimalSearch.Controls.Add(this.labelSpecies);
            this.groupBoxAnimalSearch.Controls.Add(this.tbxSearchByName);
            this.groupBoxAnimalSearch.Controls.Add(this.cbxSearchBySpecie);
            this.groupBoxAnimalSearch.Location = new System.Drawing.Point(50, 147);
            this.groupBoxAnimalSearch.Name = "groupBoxAnimalSearch";
            this.groupBoxAnimalSearch.Size = new System.Drawing.Size(700, 268);
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
            this.lvwAnimalSearch.FullRowSelect = true;
            this.lvwAnimalSearch.Location = new System.Drawing.Point(15, 117);
            this.lvwAnimalSearch.Name = "lvwAnimalSearch";
            this.lvwAnimalSearch.Size = new System.Drawing.Size(679, 141);
            this.lvwAnimalSearch.TabIndex = 15;
            this.lvwAnimalSearch.UseCompatibleStateImageBehavior = false;
            this.lvwAnimalSearch.View = System.Windows.Forms.View.Details;
            this.lvwAnimalSearch.SelectedIndexChanged += new System.EventHandler(this.lvwAnimalSearch_SelectedIndexChanged);
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
            this.tbxSearchByName.Location = new System.Drawing.Point(411, 69);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(283, 29);
            this.tbxSearchByName.TabIndex = 14;
            this.tbxSearchByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // cbxSearchBySpecie
            // 
            this.cbxSearchBySpecie.FormattingEnabled = true;
            this.cbxSearchBySpecie.Location = new System.Drawing.Point(411, 31);
            this.cbxSearchBySpecie.Name = "cbxSearchBySpecie";
            this.cbxSearchBySpecie.Size = new System.Drawing.Size(283, 32);
            this.cbxSearchBySpecie.TabIndex = 17;
            this.cbxSearchBySpecie.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBySpecie_SelectedIndexChanged);
            // 
            // labelScheduledTasks
            // 
            this.labelScheduledTasks.AutoSize = true;
            this.labelScheduledTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScheduledTasks.Location = new System.Drawing.Point(787, 18);
            this.labelScheduledTasks.Name = "labelScheduledTasks";
            this.labelScheduledTasks.Size = new System.Drawing.Size(229, 31);
            this.labelScheduledTasks.TabIndex = 13;
            this.labelScheduledTasks.Text = "Scheduled tasks";
            // 
            // tabControlScheduledTasks
            // 
            this.tabControlScheduledTasks.Controls.Add(this.tabAvailableTasks);
            this.tabControlScheduledTasks.Controls.Add(this.tabTasksInProgress);
            this.tabControlScheduledTasks.Controls.Add(this.tabFinishedTasks);
            this.tabControlScheduledTasks.Location = new System.Drawing.Point(789, 52);
            this.tabControlScheduledTasks.Name = "tabControlScheduledTasks";
            this.tabControlScheduledTasks.Padding = new System.Drawing.Point(34, 4);
            this.tabControlScheduledTasks.SelectedIndex = 0;
            this.tabControlScheduledTasks.Size = new System.Drawing.Size(700, 513);
            this.tabControlScheduledTasks.TabIndex = 12;
            // 
            // tabAvailableTasks
            // 
            this.tabAvailableTasks.Controls.Add(this.btnMarkTaskAsFinished);
            this.tabAvailableTasks.Controls.Add(this.btnRemoveTask);
            this.tabAvailableTasks.Controls.Add(this.btnMoreTaskDetails);
            this.tabAvailableTasks.Controls.Add(this.lvwUnassignedTasks);
            this.tabAvailableTasks.Location = new System.Drawing.Point(4, 35);
            this.tabAvailableTasks.Name = "tabAvailableTasks";
            this.tabAvailableTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailableTasks.Size = new System.Drawing.Size(692, 474);
            this.tabAvailableTasks.TabIndex = 0;
            this.tabAvailableTasks.Text = "Available";
            this.tabAvailableTasks.UseVisualStyleBackColor = true;
            // 
            // btnMarkTaskAsFinished
            // 
            this.btnMarkTaskAsFinished.Location = new System.Drawing.Point(243, 425);
            this.btnMarkTaskAsFinished.Name = "btnMarkTaskAsFinished";
            this.btnMarkTaskAsFinished.Size = new System.Drawing.Size(209, 44);
            this.btnMarkTaskAsFinished.TabIndex = 20;
            this.btnMarkTaskAsFinished.Text = "Mark as finished";
            this.btnMarkTaskAsFinished.UseVisualStyleBackColor = true;
            this.btnMarkTaskAsFinished.Click += new System.EventHandler(this.btnMarkTaskAsFinished_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(477, 425);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(209, 44);
            this.btnRemoveTask.TabIndex = 19;
            this.btnRemoveTask.Text = "Remove task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnMoreTaskDetails
            // 
            this.btnMoreTaskDetails.Location = new System.Drawing.Point(6, 425);
            this.btnMoreTaskDetails.Name = "btnMoreTaskDetails";
            this.btnMoreTaskDetails.Size = new System.Drawing.Size(209, 44);
            this.btnMoreTaskDetails.TabIndex = 18;
            this.btnMoreTaskDetails.Text = "More details";
            this.btnMoreTaskDetails.UseVisualStyleBackColor = true;
            this.btnMoreTaskDetails.Click += new System.EventHandler(this.btnMoreTaskDetails_Click);
            // 
            // lvwUnassignedTasks
            // 
            this.lvwUnassignedTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTaskName,
            this.colDate});
            this.lvwUnassignedTasks.FullRowSelect = true;
            this.lvwUnassignedTasks.Location = new System.Drawing.Point(6, 5);
            this.lvwUnassignedTasks.Name = "lvwUnassignedTasks";
            this.lvwUnassignedTasks.Size = new System.Drawing.Size(680, 414);
            this.lvwUnassignedTasks.TabIndex = 3;
            this.lvwUnassignedTasks.UseCompatibleStateImageBehavior = false;
            this.lvwUnassignedTasks.View = System.Windows.Forms.View.Details;
            // 
            // colTaskName
            // 
            this.colTaskName.Text = "Name";
            this.colTaskName.Width = 284;
            // 
            // colDate
            // 
            this.colDate.Text = "Task date";
            this.colDate.Width = 159;
            // 
            // tabTasksInProgress
            // 
            this.tabTasksInProgress.Controls.Add(this.button1);
            this.tabTasksInProgress.Controls.Add(this.lvwTasksInProgress);
            this.tabTasksInProgress.Location = new System.Drawing.Point(4, 26);
            this.tabTasksInProgress.Name = "tabTasksInProgress";
            this.tabTasksInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasksInProgress.Size = new System.Drawing.Size(692, 483);
            this.tabTasksInProgress.TabIndex = 1;
            this.tabTasksInProgress.Text = "In progress";
            this.tabTasksInProgress.UseVisualStyleBackColor = true;
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
            // lvwTasksInProgress
            // 
            this.lvwTasksInProgress.Location = new System.Drawing.Point(6, 5);
            this.lvwTasksInProgress.Name = "lvwTasksInProgress";
            this.lvwTasksInProgress.Size = new System.Drawing.Size(680, 414);
            this.lvwTasksInProgress.TabIndex = 4;
            this.lvwTasksInProgress.UseCompatibleStateImageBehavior = false;
            // 
            // tabFinishedTasks
            // 
            this.tabFinishedTasks.Controls.Add(this.btnFinishedTaskMoreDetails);
            this.tabFinishedTasks.Controls.Add(this.lvwFinishedTasks);
            this.tabFinishedTasks.Location = new System.Drawing.Point(4, 26);
            this.tabFinishedTasks.Name = "tabFinishedTasks";
            this.tabFinishedTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinishedTasks.Size = new System.Drawing.Size(692, 483);
            this.tabFinishedTasks.TabIndex = 2;
            this.tabFinishedTasks.Text = "Finished";
            this.tabFinishedTasks.UseVisualStyleBackColor = true;
            // 
            // btnFinishedTaskMoreDetails
            // 
            this.btnFinishedTaskMoreDetails.Location = new System.Drawing.Point(6, 425);
            this.btnFinishedTaskMoreDetails.Name = "btnFinishedTaskMoreDetails";
            this.btnFinishedTaskMoreDetails.Size = new System.Drawing.Size(209, 44);
            this.btnFinishedTaskMoreDetails.TabIndex = 21;
            this.btnFinishedTaskMoreDetails.Text = "More details";
            this.btnFinishedTaskMoreDetails.UseVisualStyleBackColor = true;
            this.btnFinishedTaskMoreDetails.Click += new System.EventHandler(this.btnFinishedTaskMoreDetails_Click);
            // 
            // lvwFinishedTasks
            // 
            this.lvwFinishedTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFinishedTaskName,
            this.colFinishedTaskDate});
            this.lvwFinishedTasks.FullRowSelect = true;
            this.lvwFinishedTasks.Location = new System.Drawing.Point(6, 5);
            this.lvwFinishedTasks.Name = "lvwFinishedTasks";
            this.lvwFinishedTasks.Size = new System.Drawing.Size(680, 414);
            this.lvwFinishedTasks.TabIndex = 20;
            this.lvwFinishedTasks.UseCompatibleStateImageBehavior = false;
            this.lvwFinishedTasks.View = System.Windows.Forms.View.Details;
            // 
            // colFinishedTaskName
            // 
            this.colFinishedTaskName.Text = "Name";
            this.colFinishedTaskName.Width = 284;
            // 
            // colFinishedTaskDate
            // 
            this.colFinishedTaskDate.Text = "Task date";
            this.colFinishedTaskDate.Width = 159;
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(893, 20);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(184, 37);
            this.labelTitleZooBazaar.TabIndex = 11;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Enclosure area:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 32);
            this.comboBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Enclosure number:";
            // 
            // FormScheduleMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DesktopApplication.Properties.Resources.zooimg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1919, 1061);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormScheduleMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScheduleMaker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).EndInit();
            this.groupBoxAnimalSearch.ResumeLayout(false);
            this.groupBoxAnimalSearch.PerformLayout();
            this.tabControlScheduledTasks.ResumeLayout(false);
            this.tabAvailableTasks.ResumeLayout(false);
            this.tabTasksInProgress.ResumeLayout(false);
            this.tabFinishedTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelScheduledTasks;
        private System.Windows.Forms.TabControl tabControlScheduledTasks;
        private System.Windows.Forms.TabPage tabAvailableTasks;
        private System.Windows.Forms.ListView lvwUnassignedTasks;
        private System.Windows.Forms.TabPage tabTasksInProgress;
        private System.Windows.Forms.ListView lvwTasksInProgress;
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
        private System.Windows.Forms.TabPage tabFinishedTasks;
        private System.Windows.Forms.Button btnFinishedTaskMoreDetails;
        private System.Windows.Forms.ListView lvwFinishedTasks;
        private System.Windows.Forms.TextBox tbxTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.ColumnHeader colTaskName;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Button btnMarkTaskAsFinished;
        private System.Windows.Forms.ColumnHeader colFinishedTaskName;
        private System.Windows.Forms.ColumnHeader colFinishedTaskDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
    }
}