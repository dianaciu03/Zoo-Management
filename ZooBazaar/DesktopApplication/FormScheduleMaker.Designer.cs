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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            nudTaskEncNumber = new NumericUpDown();
            label2 = new Label();
            cbxTaskEncArea = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbtnWeeklyTask = new RadioButton();
            rbtnDailyTask = new RadioButton();
            cbxRepetitiveTask = new CheckBox();
            calTaskDateSelection = new MonthCalendar();
            dtpTaskTime = new DateTimePicker();
            labelTaskTime = new Label();
            nudEstimatedTaskTime = new NumericUpDown();
            labelEstimatedTime = new Label();
            btnScheduleTask = new Button();
            labelTaskDescription = new Label();
            tbxTaskDescription = new TextBox();
            labelHours = new Label();
            tbxTaskName = new TextBox();
            lblTaskName = new Label();
            groupBoxAnimalSearch = new GroupBox();
            lvwAnimalSearch = new ListView();
            colID = new ColumnHeader();
            colSpecie = new ColumnHeader();
            colName = new ColumnHeader();
            labelSearchByName = new Label();
            labelSpecies = new Label();
            tbxSearchByName = new TextBox();
            cbxSearchBySpecie = new ComboBox();
            labelScheduledTasks = new Label();
            tabControlScheduledTasks = new TabControl();
            tabAvailableTasks = new TabPage();
            btnMarkTaskAsFinished = new Button();
            btnRemoveTask = new Button();
            btnMoreTaskDetails = new Button();
            lvwUnassignedTasks = new ListView();
            colTaskName = new ColumnHeader();
            colDate = new ColumnHeader();
            colEstimatedDuration = new ColumnHeader();
            tabTasksInProgress = new TabPage();
            btnAssignedTaskDetails = new Button();
            lvwTasksInProgress = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tabFinishedTasks = new TabPage();
            btnFinishedTaskMoreDetails = new Button();
            lvwFinishedTasks = new ListView();
            colFinishedTaskName = new ColumnHeader();
            colFinishedTaskDate = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBoxTaskDetails = new GroupBox();
            label12 = new Label();
            tbxEnclosureNumber = new TextBox();
            label13 = new Label();
            tbxEnclosureArea = new TextBox();
            lblTaskStatus = new Label();
            lbxTaskEmployees = new ListBox();
            label3 = new Label();
            label11 = new Label();
            tbxTaskAnimalName = new TextBox();
            tbxAnimalSpecies = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            tbxSelectedTaskDescription = new TextBox();
            label4 = new Label();
            tbxEstimatedTaskTime = new TextBox();
            tbxTaskID = new TextBox();
            label7 = new Label();
            label10 = new Label();
            label5 = new Label();
            label9 = new Label();
            tbxTaskDate = new TextBox();
            tbxTaskTitle = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            btnNextWeek = new Button();
            btnPrevWeek = new Button();
            btnPublishSchedule = new Button();
            btnShiftsDetails = new Button();
            btnRemoveShift = new Button();
            lvwGeneratedShifts = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            tbxScheduleEndDate = new TextBox();
            label16 = new Label();
            tbxScheduleStartDate = new TextBox();
            nudScheduleLenght = new NumericUpDown();
            label15 = new Label();
            label14 = new Label();
            btnScheduleShifts = new Button();
            labelTitleZooBazaar = new Label();
            btnRefresh = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTaskEncNumber).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedTaskTime).BeginInit();
            groupBoxAnimalSearch.SuspendLayout();
            tabControlScheduledTasks.SuspendLayout();
            tabAvailableTasks.SuspendLayout();
            tabTasksInProgress.SuspendLayout();
            tabFinishedTasks.SuspendLayout();
            groupBoxTaskDetails.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudScheduleLenght).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(51, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(70, 9);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1809, 952);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(nudTaskEncNumber);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cbxTaskEncArea);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(tbxTaskName);
            tabPage1.Controls.Add(lblTaskName);
            tabPage1.Controls.Add(groupBoxAnimalSearch);
            tabPage1.Controls.Add(labelScheduledTasks);
            tabPage1.Controls.Add(tabControlScheduledTasks);
            tabPage1.Controls.Add(groupBoxTaskDetails);
            tabPage1.Location = new Point(4, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1801, 903);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Schedule task";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudTaskEncNumber
            // 
            nudTaskEncNumber.Location = new Point(679, 76);
            nudTaskEncNumber.Name = "nudTaskEncNumber";
            nudTaskEncNumber.Size = new Size(71, 29);
            nudTaskEncNumber.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 78);
            label2.Name = "label2";
            label2.Size = new Size(172, 24);
            label2.TabIndex = 35;
            label2.Text = "Enclosure number:";
            // 
            // cbxTaskEncArea
            // 
            cbxTaskEncArea.FormattingEnabled = true;
            cbxTaskEncArea.Location = new Point(199, 75);
            cbxTaskEncArea.Name = "cbxTaskEncArea";
            cbxTaskEncArea.Size = new Size(283, 32);
            cbxTaskEncArea.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 78);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 34;
            label1.Text = "Enclosure area:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnWeeklyTask);
            groupBox1.Controls.Add(rbtnDailyTask);
            groupBox1.Controls.Add(cbxRepetitiveTask);
            groupBox1.Controls.Add(calTaskDateSelection);
            groupBox1.Controls.Add(dtpTaskTime);
            groupBox1.Controls.Add(labelTaskTime);
            groupBox1.Controls.Add(nudEstimatedTaskTime);
            groupBox1.Controls.Add(labelEstimatedTime);
            groupBox1.Controls.Add(btnScheduleTask);
            groupBox1.Controls.Add(labelTaskDescription);
            groupBox1.Controls.Add(tbxTaskDescription);
            groupBox1.Controls.Add(labelHours);
            groupBox1.Location = new Point(50, 401);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 462);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task date and time";
            // 
            // rbtnWeeklyTask
            // 
            rbtnWeeklyTask.AutoSize = true;
            rbtnWeeklyTask.Location = new Point(388, 202);
            rbtnWeeklyTask.Name = "rbtnWeeklyTask";
            rbtnWeeklyTask.Size = new Size(90, 28);
            rbtnWeeklyTask.TabIndex = 31;
            rbtnWeeklyTask.TabStop = true;
            rbtnWeeklyTask.Text = "Weekly";
            rbtnWeeklyTask.UseVisualStyleBackColor = true;
            // 
            // rbtnDailyTask
            // 
            rbtnDailyTask.AutoSize = true;
            rbtnDailyTask.Location = new Point(268, 202);
            rbtnDailyTask.Name = "rbtnDailyTask";
            rbtnDailyTask.Size = new Size(68, 28);
            rbtnDailyTask.TabIndex = 30;
            rbtnDailyTask.TabStop = true;
            rbtnDailyTask.Text = "Daily";
            rbtnDailyTask.UseVisualStyleBackColor = true;
            rbtnDailyTask.CheckedChanged += rbtnDailyTask_CheckedChanged;
            // 
            // cbxRepetitiveTask
            // 
            cbxRepetitiveTask.AutoSize = true;
            cbxRepetitiveTask.Location = new Point(268, 166);
            cbxRepetitiveTask.Name = "cbxRepetitiveTask";
            cbxRepetitiveTask.Size = new Size(111, 28);
            cbxRepetitiveTask.TabIndex = 29;
            cbxRepetitiveTask.Text = "Repetitive";
            cbxRepetitiveTask.UseVisualStyleBackColor = true;
            cbxRepetitiveTask.CheckedChanged += cbxRepetitiveTask_CheckedChanged;
            // 
            // calTaskDateSelection
            // 
            calTaskDateSelection.Font = new Font("Microsoft Sans Serif", 18.25F, FontStyle.Regular, GraphicsUnit.Point);
            calTaskDateSelection.Location = new Point(12, 34);
            calTaskDateSelection.MaxSelectionCount = 1;
            calTaskDateSelection.Name = "calTaskDateSelection";
            calTaskDateSelection.TabIndex = 20;
            // 
            // dtpTaskTime
            // 
            dtpTaskTime.CustomFormat = "    HH:mm";
            dtpTaskTime.Format = DateTimePickerFormat.Custom;
            dtpTaskTime.Location = new Point(370, 30);
            dtpTaskTime.Name = "dtpTaskTime";
            dtpTaskTime.Size = new Size(130, 29);
            dtpTaskTime.TabIndex = 21;
            // 
            // labelTaskTime
            // 
            labelTaskTime.AutoSize = true;
            labelTaskTime.Location = new Point(264, 34);
            labelTaskTime.Name = "labelTaskTime";
            labelTaskTime.Size = new Size(91, 24);
            labelTaskTime.TabIndex = 22;
            labelTaskTime.Text = "Start time:";
            // 
            // nudEstimatedTaskTime
            // 
            nudEstimatedTaskTime.Location = new Point(268, 120);
            nudEstimatedTaskTime.Name = "nudEstimatedTaskTime";
            nudEstimatedTaskTime.Size = new Size(133, 29);
            nudEstimatedTaskTime.TabIndex = 26;
            // 
            // labelEstimatedTime
            // 
            labelEstimatedTime.AutoSize = true;
            labelEstimatedTime.Location = new Point(264, 76);
            labelEstimatedTime.Name = "labelEstimatedTime";
            labelEstimatedTime.Size = new Size(170, 24);
            labelEstimatedTime.TabIndex = 27;
            labelEstimatedTime.Text = "Estimated duration:";
            // 
            // btnScheduleTask
            // 
            btnScheduleTask.Location = new Point(11, 408);
            btnScheduleTask.Name = "btnScheduleTask";
            btnScheduleTask.Size = new Size(177, 48);
            btnScheduleTask.TabIndex = 23;
            btnScheduleTask.Text = "Schedule task";
            btnScheduleTask.UseVisualStyleBackColor = true;
            btnScheduleTask.Click += btnScheduleTask_Click;
            // 
            // labelTaskDescription
            // 
            labelTaskDescription.AutoSize = true;
            labelTaskDescription.Location = new Point(11, 266);
            labelTaskDescription.Name = "labelTaskDescription";
            labelTaskDescription.Size = new Size(147, 24);
            labelTaskDescription.TabIndex = 25;
            labelTaskDescription.Text = "Task description";
            // 
            // tbxTaskDescription
            // 
            tbxTaskDescription.Location = new Point(12, 293);
            tbxTaskDescription.Multiline = true;
            tbxTaskDescription.Name = "tbxTaskDescription";
            tbxTaskDescription.Size = new Size(682, 109);
            tbxTaskDescription.TabIndex = 24;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(407, 122);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(70, 24);
            labelHours.TabIndex = 28;
            labelHours.Text = "hour(s)";
            // 
            // tbxTaskName
            // 
            tbxTaskName.Location = new Point(188, 32);
            tbxTaskName.Name = "tbxTaskName";
            tbxTaskName.Size = new Size(562, 29);
            tbxTaskName.TabIndex = 32;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(50, 35);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(108, 24);
            lblTaskName.TabIndex = 31;
            lblTaskName.Text = "Task name:";
            // 
            // groupBoxAnimalSearch
            // 
            groupBoxAnimalSearch.Controls.Add(lvwAnimalSearch);
            groupBoxAnimalSearch.Controls.Add(labelSearchByName);
            groupBoxAnimalSearch.Controls.Add(labelSpecies);
            groupBoxAnimalSearch.Controls.Add(tbxSearchByName);
            groupBoxAnimalSearch.Controls.Add(cbxSearchBySpecie);
            groupBoxAnimalSearch.Location = new Point(50, 127);
            groupBoxAnimalSearch.Name = "groupBoxAnimalSearch";
            groupBoxAnimalSearch.Size = new Size(700, 268);
            groupBoxAnimalSearch.TabIndex = 29;
            groupBoxAnimalSearch.TabStop = false;
            groupBoxAnimalSearch.Text = "Animal search";
            // 
            // lvwAnimalSearch
            // 
            lvwAnimalSearch.Columns.AddRange(new ColumnHeader[] { colID, colSpecie, colName });
            lvwAnimalSearch.FullRowSelect = true;
            lvwAnimalSearch.Location = new Point(15, 117);
            lvwAnimalSearch.MultiSelect = false;
            lvwAnimalSearch.Name = "lvwAnimalSearch";
            lvwAnimalSearch.Size = new Size(679, 141);
            lvwAnimalSearch.TabIndex = 15;
            lvwAnimalSearch.UseCompatibleStateImageBehavior = false;
            lvwAnimalSearch.View = View.Details;
            lvwAnimalSearch.SelectedIndexChanged += lvwAnimalSearch_SelectedIndexChanged;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 62;
            // 
            // colSpecie
            // 
            colSpecie.Text = "Specie";
            colSpecie.Width = 159;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 174;
            // 
            // labelSearchByName
            // 
            labelSearchByName.AutoSize = true;
            labelSearchByName.Location = new Point(11, 72);
            labelSearchByName.Name = "labelSearchByName";
            labelSearchByName.Size = new Size(153, 24);
            labelSearchByName.TabIndex = 16;
            labelSearchByName.Text = "Search by name:";
            // 
            // labelSpecies
            // 
            labelSpecies.AutoSize = true;
            labelSpecies.Location = new Point(11, 34);
            labelSpecies.Name = "labelSpecies";
            labelSpecies.Size = new Size(83, 24);
            labelSpecies.TabIndex = 18;
            labelSpecies.Text = "Species:";
            // 
            // tbxSearchByName
            // 
            tbxSearchByName.Location = new Point(411, 69);
            tbxSearchByName.Name = "tbxSearchByName";
            tbxSearchByName.Size = new Size(283, 29);
            tbxSearchByName.TabIndex = 14;
            tbxSearchByName.TextChanged += tbxSearchByName_TextChanged;
            // 
            // cbxSearchBySpecie
            // 
            cbxSearchBySpecie.FormattingEnabled = true;
            cbxSearchBySpecie.Location = new Point(411, 31);
            cbxSearchBySpecie.Name = "cbxSearchBySpecie";
            cbxSearchBySpecie.Size = new Size(283, 32);
            cbxSearchBySpecie.TabIndex = 17;
            cbxSearchBySpecie.SelectedIndexChanged += cbxSearchBySpecie_SelectedIndexChanged;
            // 
            // labelScheduledTasks
            // 
            labelScheduledTasks.AutoSize = true;
            labelScheduledTasks.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelScheduledTasks.Location = new Point(827, 23);
            labelScheduledTasks.Name = "labelScheduledTasks";
            labelScheduledTasks.Size = new Size(229, 31);
            labelScheduledTasks.TabIndex = 13;
            labelScheduledTasks.Text = "Scheduled tasks";
            // 
            // tabControlScheduledTasks
            // 
            tabControlScheduledTasks.Controls.Add(tabAvailableTasks);
            tabControlScheduledTasks.Controls.Add(tabTasksInProgress);
            tabControlScheduledTasks.Controls.Add(tabFinishedTasks);
            tabControlScheduledTasks.Location = new Point(827, 57);
            tabControlScheduledTasks.Name = "tabControlScheduledTasks";
            tabControlScheduledTasks.Padding = new Point(34, 4);
            tabControlScheduledTasks.SelectedIndex = 0;
            tabControlScheduledTasks.Size = new Size(901, 429);
            tabControlScheduledTasks.TabIndex = 12;
            // 
            // tabAvailableTasks
            // 
            tabAvailableTasks.Controls.Add(btnMarkTaskAsFinished);
            tabAvailableTasks.Controls.Add(btnRemoveTask);
            tabAvailableTasks.Controls.Add(btnMoreTaskDetails);
            tabAvailableTasks.Controls.Add(lvwUnassignedTasks);
            tabAvailableTasks.Location = new Point(4, 35);
            tabAvailableTasks.Name = "tabAvailableTasks";
            tabAvailableTasks.Padding = new Padding(3);
            tabAvailableTasks.Size = new Size(893, 390);
            tabAvailableTasks.TabIndex = 0;
            tabAvailableTasks.Text = "Available";
            tabAvailableTasks.UseVisualStyleBackColor = true;
            // 
            // btnMarkTaskAsFinished
            // 
            btnMarkTaskAsFinished.Location = new Point(218, 340);
            btnMarkTaskAsFinished.Name = "btnMarkTaskAsFinished";
            btnMarkTaskAsFinished.Size = new Size(209, 44);
            btnMarkTaskAsFinished.TabIndex = 20;
            btnMarkTaskAsFinished.Text = "Mark as finished";
            btnMarkTaskAsFinished.UseVisualStyleBackColor = true;
            btnMarkTaskAsFinished.Click += btnMarkTaskAsFinished_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(433, 340);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(209, 44);
            btnRemoveTask.TabIndex = 19;
            btnRemoveTask.Text = "Remove task";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // btnMoreTaskDetails
            // 
            btnMoreTaskDetails.Location = new Point(3, 340);
            btnMoreTaskDetails.Name = "btnMoreTaskDetails";
            btnMoreTaskDetails.Size = new Size(209, 44);
            btnMoreTaskDetails.TabIndex = 18;
            btnMoreTaskDetails.Text = "More details";
            btnMoreTaskDetails.UseVisualStyleBackColor = true;
            btnMoreTaskDetails.Click += btnMoreTaskDetails_Click;
            // 
            // lvwUnassignedTasks
            // 
            lvwUnassignedTasks.Columns.AddRange(new ColumnHeader[] { colTaskName, colDate, colEstimatedDuration });
            lvwUnassignedTasks.FullRowSelect = true;
            lvwUnassignedTasks.Location = new Point(3, 3);
            lvwUnassignedTasks.Name = "lvwUnassignedTasks";
            lvwUnassignedTasks.Size = new Size(887, 331);
            lvwUnassignedTasks.TabIndex = 3;
            lvwUnassignedTasks.UseCompatibleStateImageBehavior = false;
            lvwUnassignedTasks.View = View.Details;
            lvwUnassignedTasks.SelectedIndexChanged += lvwUnassignedTasks_SelectedIndexChanged;
            // 
            // colTaskName
            // 
            colTaskName.Text = "Name";
            colTaskName.Width = 360;
            // 
            // colDate
            // 
            colDate.Text = "Date";
            colDate.Width = 220;
            // 
            // colEstimatedDuration
            // 
            colEstimatedDuration.Text = "Estimated duration";
            colEstimatedDuration.Width = 220;
            // 
            // tabTasksInProgress
            // 
            tabTasksInProgress.Controls.Add(btnAssignedTaskDetails);
            tabTasksInProgress.Controls.Add(lvwTasksInProgress);
            tabTasksInProgress.Location = new Point(4, 26);
            tabTasksInProgress.Name = "tabTasksInProgress";
            tabTasksInProgress.Padding = new Padding(3);
            tabTasksInProgress.Size = new Size(893, 399);
            tabTasksInProgress.TabIndex = 1;
            tabTasksInProgress.Text = "Assigned";
            tabTasksInProgress.UseVisualStyleBackColor = true;
            // 
            // btnAssignedTaskDetails
            // 
            btnAssignedTaskDetails.Location = new Point(6, 342);
            btnAssignedTaskDetails.Name = "btnAssignedTaskDetails";
            btnAssignedTaskDetails.Size = new Size(209, 44);
            btnAssignedTaskDetails.TabIndex = 19;
            btnAssignedTaskDetails.Text = "More details";
            btnAssignedTaskDetails.UseVisualStyleBackColor = true;
            // 
            // lvwTasksInProgress
            // 
            lvwTasksInProgress.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwTasksInProgress.Location = new Point(6, 5);
            lvwTasksInProgress.Name = "lvwTasksInProgress";
            lvwTasksInProgress.Size = new Size(881, 331);
            lvwTasksInProgress.TabIndex = 4;
            lvwTasksInProgress.UseCompatibleStateImageBehavior = false;
            lvwTasksInProgress.View = View.Details;
            lvwTasksInProgress.SelectedIndexChanged += lvwTasksInProgress_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 360;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estimated duration";
            columnHeader3.Width = 220;
            // 
            // tabFinishedTasks
            // 
            tabFinishedTasks.Controls.Add(btnFinishedTaskMoreDetails);
            tabFinishedTasks.Controls.Add(lvwFinishedTasks);
            tabFinishedTasks.Location = new Point(4, 26);
            tabFinishedTasks.Name = "tabFinishedTasks";
            tabFinishedTasks.Padding = new Padding(3);
            tabFinishedTasks.Size = new Size(893, 399);
            tabFinishedTasks.TabIndex = 2;
            tabFinishedTasks.Text = "Finished";
            tabFinishedTasks.UseVisualStyleBackColor = true;
            // 
            // btnFinishedTaskMoreDetails
            // 
            btnFinishedTaskMoreDetails.Location = new Point(6, 342);
            btnFinishedTaskMoreDetails.Name = "btnFinishedTaskMoreDetails";
            btnFinishedTaskMoreDetails.Size = new Size(209, 44);
            btnFinishedTaskMoreDetails.TabIndex = 21;
            btnFinishedTaskMoreDetails.Text = "More details";
            btnFinishedTaskMoreDetails.UseVisualStyleBackColor = true;
            btnFinishedTaskMoreDetails.Click += btnFinishedTaskMoreDetails_Click;
            // 
            // lvwFinishedTasks
            // 
            lvwFinishedTasks.Columns.AddRange(new ColumnHeader[] { colFinishedTaskName, colFinishedTaskDate, columnHeader4 });
            lvwFinishedTasks.FullRowSelect = true;
            lvwFinishedTasks.Location = new Point(6, 5);
            lvwFinishedTasks.Name = "lvwFinishedTasks";
            lvwFinishedTasks.Size = new Size(881, 331);
            lvwFinishedTasks.TabIndex = 20;
            lvwFinishedTasks.UseCompatibleStateImageBehavior = false;
            lvwFinishedTasks.View = View.Details;
            lvwFinishedTasks.SelectedIndexChanged += lvwFinishedTasks_SelectedIndexChanged;
            // 
            // colFinishedTaskName
            // 
            colFinishedTaskName.Text = "Name";
            colFinishedTaskName.Width = 360;
            // 
            // colFinishedTaskDate
            // 
            colFinishedTaskDate.Text = "Date";
            colFinishedTaskDate.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Estimated duration";
            columnHeader4.Width = 220;
            // 
            // groupBoxTaskDetails
            // 
            groupBoxTaskDetails.Controls.Add(label12);
            groupBoxTaskDetails.Controls.Add(tbxEnclosureNumber);
            groupBoxTaskDetails.Controls.Add(label13);
            groupBoxTaskDetails.Controls.Add(tbxEnclosureArea);
            groupBoxTaskDetails.Controls.Add(lblTaskStatus);
            groupBoxTaskDetails.Controls.Add(lbxTaskEmployees);
            groupBoxTaskDetails.Controls.Add(label3);
            groupBoxTaskDetails.Controls.Add(label11);
            groupBoxTaskDetails.Controls.Add(tbxTaskAnimalName);
            groupBoxTaskDetails.Controls.Add(tbxAnimalSpecies);
            groupBoxTaskDetails.Controls.Add(label8);
            groupBoxTaskDetails.Controls.Add(groupBox3);
            groupBoxTaskDetails.Controls.Add(label4);
            groupBoxTaskDetails.Controls.Add(tbxEstimatedTaskTime);
            groupBoxTaskDetails.Controls.Add(tbxTaskID);
            groupBoxTaskDetails.Controls.Add(label7);
            groupBoxTaskDetails.Controls.Add(label10);
            groupBoxTaskDetails.Controls.Add(label5);
            groupBoxTaskDetails.Controls.Add(label9);
            groupBoxTaskDetails.Controls.Add(tbxTaskDate);
            groupBoxTaskDetails.Controls.Add(tbxTaskTitle);
            groupBoxTaskDetails.Controls.Add(label6);
            groupBoxTaskDetails.Location = new Point(827, 492);
            groupBoxTaskDetails.Name = "groupBoxTaskDetails";
            groupBoxTaskDetails.Size = new Size(901, 391);
            groupBoxTaskDetails.TabIndex = 37;
            groupBoxTaskDetails.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 114);
            label12.Name = "label12";
            label12.Size = new Size(172, 24);
            label12.TabIndex = 28;
            label12.Text = "Enclosure number:";
            // 
            // tbxEnclosureNumber
            // 
            tbxEnclosureNumber.Location = new Point(232, 111);
            tbxEnclosureNumber.Name = "tbxEnclosureNumber";
            tbxEnclosureNumber.ReadOnly = true;
            tbxEnclosureNumber.Size = new Size(76, 29);
            tbxEnclosureNumber.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 77);
            label13.Name = "label13";
            label13.Size = new Size(143, 24);
            label13.TabIndex = 26;
            label13.Text = "Enclosure area:";
            // 
            // tbxEnclosureArea
            // 
            tbxEnclosureArea.Location = new Point(232, 77);
            tbxEnclosureArea.Name = "tbxEnclosureArea";
            tbxEnclosureArea.ReadOnly = true;
            tbxEnclosureArea.Size = new Size(185, 29);
            tbxEnclosureArea.TabIndex = 25;
            // 
            // lblTaskStatus
            // 
            lblTaskStatus.AutoSize = true;
            lblTaskStatus.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaskStatus.Location = new Point(686, 339);
            lblTaskStatus.Name = "lblTaskStatus";
            lblTaskStatus.Size = new Size(114, 37);
            lblTaskStatus.TabIndex = 20;
            lblTaskStatus.Text = "Status";
            // 
            // lbxTaskEmployees
            // 
            lbxTaskEmployees.FormattingEnabled = true;
            lbxTaskEmployees.ItemHeight = 24;
            lbxTaskEmployees.Location = new Point(569, 244);
            lbxTaskEmployees.Name = "lbxTaskEmployees";
            lbxTaskEmployees.Size = new Size(313, 76);
            lbxTaskEmployees.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 24);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 37);
            label3.TabIndex = 0;
            label3.Text = "Task details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(678, 207);
            label11.Name = "label11";
            label11.Size = new Size(204, 24);
            label11.TabIndex = 11;
            label11.Text = "Assigned employee(s):";
            // 
            // tbxTaskAnimalName
            // 
            tbxTaskAnimalName.Location = new Point(679, 121);
            tbxTaskAnimalName.Name = "tbxTaskAnimalName";
            tbxTaskAnimalName.ReadOnly = true;
            tbxTaskAnimalName.Size = new Size(203, 29);
            tbxTaskAnimalName.TabIndex = 14;
            // 
            // tbxAnimalSpecies
            // 
            tbxAnimalSpecies.Location = new Point(679, 72);
            tbxAnimalSpecies.Name = "tbxAnimalSpecies";
            tbxAnimalSpecies.ReadOnly = true;
            tbxAnimalSpecies.Size = new Size(203, 29);
            tbxAnimalSpecies.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(281, 205);
            label8.Name = "label8";
            label8.Size = new Size(70, 24);
            label8.TabIndex = 19;
            label8.Text = "hour(s)";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbxSelectedTaskDescription);
            groupBox3.Location = new Point(41, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(473, 141);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Description:";
            // 
            // tbxSelectedTaskDescription
            // 
            tbxSelectedTaskDescription.Location = new Point(6, 28);
            tbxSelectedTaskDescription.Multiline = true;
            tbxSelectedTaskDescription.Name = "tbxSelectedTaskDescription";
            tbxSelectedTaskDescription.ReadOnly = true;
            tbxSelectedTaskDescription.Size = new Size(461, 97);
            tbxSelectedTaskDescription.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(768, 26);
            label4.Name = "label4";
            label4.Size = new Size(32, 24);
            label4.TabIndex = 1;
            label4.Text = "ID:";
            // 
            // tbxEstimatedTaskTime
            // 
            tbxEstimatedTaskTime.Location = new Point(187, 202);
            tbxEstimatedTaskTime.Name = "tbxEstimatedTaskTime";
            tbxEstimatedTaskTime.ReadOnly = true;
            tbxEstimatedTaskTime.Size = new Size(85, 29);
            tbxEstimatedTaskTime.TabIndex = 18;
            // 
            // tbxTaskID
            // 
            tbxTaskID.Location = new Point(806, 24);
            tbxTaskID.Name = "tbxTaskID";
            tbxTaskID.ReadOnly = true;
            tbxTaskID.Size = new Size(76, 29);
            tbxTaskID.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 205);
            label7.Name = "label7";
            label7.Size = new Size(137, 24);
            label7.TabIndex = 17;
            label7.Text = "Estimated time:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(536, 124);
            label10.Name = "label10";
            label10.Size = new Size(126, 24);
            label10.TabIndex = 5;
            label10.Text = "Animal name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 27);
            label5.Name = "label5";
            label5.Size = new Size(50, 24);
            label5.TabIndex = 2;
            label5.Text = "Title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(519, 75);
            label9.Name = "label9";
            label9.Size = new Size(143, 24);
            label9.TabIndex = 4;
            label9.Text = "Animal species:";
            // 
            // tbxTaskDate
            // 
            tbxTaskDate.Location = new Point(105, 156);
            tbxTaskDate.Name = "tbxTaskDate";
            tbxTaskDate.ReadOnly = true;
            tbxTaskDate.Size = new Size(226, 29);
            tbxTaskDate.TabIndex = 16;
            // 
            // tbxTaskTitle
            // 
            tbxTaskTitle.Location = new Point(319, 24);
            tbxTaskTitle.Name = "tbxTaskTitle";
            tbxTaskTitle.ReadOnly = true;
            tbxTaskTitle.Size = new Size(327, 29);
            tbxTaskTitle.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 159);
            label6.Name = "label6";
            label6.Size = new Size(53, 24);
            label6.TabIndex = 15;
            label6.Text = "Date:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnNextWeek);
            tabPage2.Controls.Add(btnPrevWeek);
            tabPage2.Controls.Add(btnPublishSchedule);
            tabPage2.Controls.Add(btnShiftsDetails);
            tabPage2.Controls.Add(btnRemoveShift);
            tabPage2.Controls.Add(lvwGeneratedShifts);
            tabPage2.Controls.Add(tbxScheduleEndDate);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(tbxScheduleStartDate);
            tabPage2.Controls.Add(nudScheduleLenght);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(btnScheduleShifts);
            tabPage2.Location = new Point(4, 45);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1801, 903);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ScheduleShifts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNextWeek
            // 
            btnNextWeek.Location = new Point(471, 23);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(77, 36);
            btnNextWeek.TabIndex = 14;
            btnNextWeek.Text = ">";
            btnNextWeek.UseVisualStyleBackColor = true;
            btnNextWeek.Click += btnNextWeek_Click;
            // 
            // btnPrevWeek
            // 
            btnPrevWeek.Location = new Point(360, 23);
            btnPrevWeek.Name = "btnPrevWeek";
            btnPrevWeek.Size = new Size(77, 36);
            btnPrevWeek.TabIndex = 13;
            btnPrevWeek.Text = "<";
            btnPrevWeek.UseVisualStyleBackColor = true;
            btnPrevWeek.Click += btnPrevWeek_Click;
            // 
            // btnPublishSchedule
            // 
            btnPublishSchedule.Location = new Point(47, 725);
            btnPublishSchedule.Name = "btnPublishSchedule";
            btnPublishSchedule.Size = new Size(537, 35);
            btnPublishSchedule.TabIndex = 12;
            btnPublishSchedule.Text = "Publish";
            btnPublishSchedule.UseVisualStyleBackColor = true;
            btnPublishSchedule.Visible = false;
            btnPublishSchedule.Click += button1_Click;
            // 
            // btnShiftsDetails
            // 
            btnShiftsDetails.Location = new Point(47, 725);
            btnShiftsDetails.Name = "btnShiftsDetails";
            btnShiftsDetails.Size = new Size(182, 35);
            btnShiftsDetails.TabIndex = 11;
            btnShiftsDetails.Text = "Details";
            btnShiftsDetails.UseVisualStyleBackColor = true;
            // 
            // btnRemoveShift
            // 
            btnRemoveShift.Location = new Point(246, 725);
            btnRemoveShift.Name = "btnRemoveShift";
            btnRemoveShift.Size = new Size(182, 35);
            btnRemoveShift.TabIndex = 8;
            btnRemoveShift.Text = "Remove";
            btnRemoveShift.UseVisualStyleBackColor = true;
            // 
            // lvwGeneratedShifts
            // 
            lvwGeneratedShifts.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader7, columnHeader6 });
            lvwGeneratedShifts.Location = new Point(47, 286);
            lvwGeneratedShifts.Name = "lvwGeneratedShifts";
            lvwGeneratedShifts.Size = new Size(537, 433);
            lvwGeneratedShifts.TabIndex = 7;
            lvwGeneratedShifts.UseCompatibleStateImageBehavior = false;
            lvwGeneratedShifts.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Date";
            columnHeader5.Width = 160;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Assignee";
            columnHeader7.Width = 220;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Start time";
            columnHeader6.Width = 150;
            // 
            // tbxScheduleEndDate
            // 
            tbxScheduleEndDate.Location = new Point(684, 63);
            tbxScheduleEndDate.Name = "tbxScheduleEndDate";
            tbxScheduleEndDate.ReadOnly = true;
            tbxScheduleEndDate.Size = new Size(146, 29);
            tbxScheduleEndDate.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(471, 66);
            label16.Name = "label16";
            label16.Size = new Size(190, 24);
            label16.TabIndex = 5;
            label16.Text = "Scheduling end date:";
            // 
            // tbxScheduleStartDate
            // 
            tbxScheduleStartDate.Location = new Point(259, 65);
            tbxScheduleStartDate.Name = "tbxScheduleStartDate";
            tbxScheduleStartDate.ReadOnly = true;
            tbxScheduleStartDate.Size = new Size(147, 29);
            tbxScheduleStartDate.TabIndex = 4;
            // 
            // nudScheduleLenght
            // 
            nudScheduleLenght.Location = new Point(47, 182);
            nudScheduleLenght.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudScheduleLenght.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudScheduleLenght.Name = "nudScheduleLenght";
            nudScheduleLenght.Size = new Size(120, 29);
            nudScheduleLenght.TabIndex = 3;
            nudScheduleLenght.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudScheduleLenght.ValueChanged += nudScheduleLenght_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 155);
            label15.Name = "label15";
            label15.Size = new Size(284, 24);
            label15.TabIndex = 2;
            label15.Text = "Schedule for (number of weeks:)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(47, 68);
            label14.Name = "label14";
            label14.Size = new Size(190, 24);
            label14.TabIndex = 1;
            label14.Text = "Scheduling start date:";
            // 
            // btnScheduleShifts
            // 
            btnScheduleShifts.Location = new Point(47, 239);
            btnScheduleShifts.Name = "btnScheduleShifts";
            btnScheduleShifts.Size = new Size(182, 41);
            btnScheduleShifts.TabIndex = 0;
            btnScheduleShifts.Text = "ScheduleShifts";
            btnScheduleShifts.UseVisualStyleBackColor = true;
            btnScheduleShifts.Click += btnScheduleShifts_Click;
            // 
            // labelTitleZooBazaar
            // 
            labelTitleZooBazaar.AutoSize = true;
            labelTitleZooBazaar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleZooBazaar.Location = new Point(893, 20);
            labelTitleZooBazaar.Margin = new Padding(4, 0, 4, 0);
            labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            labelTitleZooBazaar.Size = new Size(184, 37);
            labelTitleZooBazaar.TabIndex = 11;
            labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1689, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 57);
            btnRefresh.TabIndex = 38;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormScheduleMaker
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 234, 197);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1919, 1061);
            Controls.Add(labelTitleZooBazaar);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FormScheduleMaker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Management";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTaskEncNumber).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedTaskTime).EndInit();
            groupBoxAnimalSearch.ResumeLayout(false);
            groupBoxAnimalSearch.PerformLayout();
            tabControlScheduledTasks.ResumeLayout(false);
            tabAvailableTasks.ResumeLayout(false);
            tabTasksInProgress.ResumeLayout(false);
            tabFinishedTasks.ResumeLayout(false);
            groupBoxTaskDetails.ResumeLayout(false);
            groupBoxTaskDetails.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudScheduleLenght).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnAssignedTaskDetails;
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
        private NumericUpDown nudTaskEncNumber;
        private ComboBox cbxTaskEncArea;
        private Label label1;
        private GroupBox groupBoxTaskDetails;
        private Label label3;
        private Label label4;
        private TextBox tbxTaskID;
        private Label label5;
        private TextBox tbxTaskDate;
        private TextBox tbxTaskTitle;
        private Label label6;
        private TextBox tbxEstimatedTaskTime;
        private Label label7;
        private Label label8;
        private TextBox tbxTaskAnimalName;
        private TextBox tbxAnimalSpecies;
        private Label label10;
        private Label label9;
        private GroupBox groupBox3;
        private TextBox tbxSelectedTaskDescription;
        private Label label11;
        private ListBox lbxTaskEmployees;
        private Label lblTaskStatus;
        private ColumnHeader colEstimatedDuration;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label12;
        private TextBox tbxEnclosureNumber;
        private Label label13;
        private TextBox tbxEnclosureArea;
        private TabPage tabPage2;
        private Button btnScheduleShifts;
        private Button btnShiftsDetails;
        private Button btnRemoveShift;
        private ListView lvwGeneratedShifts;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private TextBox tbxScheduleEndDate;
        private Label label16;
        private TextBox tbxScheduleStartDate;
        private NumericUpDown nudScheduleLenght;
        private Label label15;
        private Label label14;
        private Button btnPublishSchedule;
        private RadioButton rbtnWeeklyTask;
        private RadioButton rbtnDailyTask;
        private CheckBox cbxRepetitiveTask;
        private Button btnNextWeek;
        private Button btnPrevWeek;
        private ColumnHeader columnHeader6;
        private Button btnRefresh;
    }
}