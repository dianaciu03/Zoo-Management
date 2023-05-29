namespace DesktopApplication
{
    partial class FormResourcePlanner
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
            this.labelTitleZooBazaar = new System.Windows.Forms.Label();
            this.tabControlResourcePlanner = new System.Windows.Forms.TabControl();
            this.tabAssignTasks = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAssignEmployee = new System.Windows.Forms.Button();
            this.labelCaretakers = new System.Windows.Forms.Label();
            this.cbxCaretakers = new System.Windows.Forms.ComboBox();
            this.btnMoreDetailsTask = new System.Windows.Forms.Button();
            this.lvwAvailableTasks = new System.Windows.Forms.ListView();
            this.colTaskName = new System.Windows.Forms.ColumnHeader();
            this.colTaskDate = new System.Windows.Forms.ColumnHeader();
            this.colEstimatedDuration = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.labelAvailableTasks = new System.Windows.Forms.Label();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.btnTaskMoreDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbtnLast2Weeks = new System.Windows.Forms.RadioButton();
            this.rbtnLastWeek = new System.Windows.Forms.RadioButton();
            this.rbtnToday = new System.Windows.Forms.RadioButton();
            this.labelAllTasks = new System.Windows.Forms.Label();
            this.lvwAllTasks = new System.Windows.Forms.ListView();
            this.colAllTaskName = new System.Windows.Forms.ColumnHeader();
            this.colAllTaskDate = new System.Windows.Forms.ColumnHeader();
            this.colAllTaskEstimatedDuration = new System.Windows.Forms.ColumnHeader();
            this.colAllTaskStatus = new System.Windows.Forms.ColumnHeader();
            this.groupBoxTaskDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEnclosureNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEnclosureArea = new System.Windows.Forms.TextBox();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.lbxTaskEmployees = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxTaskAnimalName = new System.Windows.Forms.TextBox();
            this.tbxAnimalSpecies = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxSelectedTaskDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEstimatedTaskTime = new System.Windows.Forms.TextBox();
            this.tbxTaskID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTaskDate = new System.Windows.Forms.TextBox();
            this.tbxTaskTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlResourcePlanner.SuspendLayout();
            this.tabAssignTasks.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.groupBoxTaskDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(858, 21);
            this.labelTitleZooBazaar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            this.labelTitleZooBazaar.Size = new System.Drawing.Size(184, 37);
            this.labelTitleZooBazaar.TabIndex = 13;
            this.labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // tabControlResourcePlanner
            // 
            this.tabControlResourcePlanner.Controls.Add(this.tabAssignTasks);
            this.tabControlResourcePlanner.Controls.Add(this.tabOverview);
            this.tabControlResourcePlanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlResourcePlanner.Location = new System.Drawing.Point(39, 49);
            this.tabControlResourcePlanner.Name = "tabControlResourcePlanner";
            this.tabControlResourcePlanner.Padding = new System.Drawing.Point(70, 9);
            this.tabControlResourcePlanner.SelectedIndex = 0;
            this.tabControlResourcePlanner.Size = new System.Drawing.Size(1316, 889);
            this.tabControlResourcePlanner.TabIndex = 12;
            // 
            // tabAssignTasks
            // 
            this.tabAssignTasks.Controls.Add(this.button1);
            this.tabAssignTasks.Controls.Add(this.btnAssignEmployee);
            this.tabAssignTasks.Controls.Add(this.labelCaretakers);
            this.tabAssignTasks.Controls.Add(this.cbxCaretakers);
            this.tabAssignTasks.Controls.Add(this.btnMoreDetailsTask);
            this.tabAssignTasks.Controls.Add(this.lvwAvailableTasks);
            this.tabAssignTasks.Controls.Add(this.labelDayOfWeek);
            this.tabAssignTasks.Controls.Add(this.labelAvailableTasks);
            this.tabAssignTasks.Location = new System.Drawing.Point(4, 45);
            this.tabAssignTasks.Name = "tabAssignTasks";
            this.tabAssignTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignTasks.Size = new System.Drawing.Size(1308, 840);
            this.tabAssignTasks.TabIndex = 0;
            this.tabAssignTasks.Text = "Assign tasks";
            this.tabAssignTasks.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(998, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 44);
            this.button1.TabIndex = 38;
            this.button1.Text = "Assign tasks automatically";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.Location = new System.Drawing.Point(19, 638);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(209, 44);
            this.btnAssignEmployee.TabIndex = 37;
            this.btnAssignEmployee.Text = "Assign employee";
            this.btnAssignEmployee.UseVisualStyleBackColor = true;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click);
            // 
            // labelCaretakers
            // 
            this.labelCaretakers.AutoSize = true;
            this.labelCaretakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCaretakers.Location = new System.Drawing.Point(13, 554);
            this.labelCaretakers.Name = "labelCaretakers";
            this.labelCaretakers.Size = new System.Drawing.Size(158, 31);
            this.labelCaretakers.TabIndex = 34;
            this.labelCaretakers.Text = "Caretakers";
            // 
            // cbxCaretakers
            // 
            this.cbxCaretakers.FormattingEnabled = true;
            this.cbxCaretakers.Location = new System.Drawing.Point(19, 600);
            this.cbxCaretakers.Name = "cbxCaretakers";
            this.cbxCaretakers.Size = new System.Drawing.Size(303, 32);
            this.cbxCaretakers.TabIndex = 33;
            // 
            // btnMoreDetailsTask
            // 
            this.btnMoreDetailsTask.Location = new System.Drawing.Point(19, 483);
            this.btnMoreDetailsTask.Name = "btnMoreDetailsTask";
            this.btnMoreDetailsTask.Size = new System.Drawing.Size(291, 44);
            this.btnMoreDetailsTask.TabIndex = 32;
            this.btnMoreDetailsTask.Text = "More details";
            this.btnMoreDetailsTask.UseVisualStyleBackColor = true;
            this.btnMoreDetailsTask.Click += new System.EventHandler(this.btnMoreDetailsTask_Click);
            // 
            // lvwAvailableTasks
            // 
            this.lvwAvailableTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTaskName,
            this.colTaskDate,
            this.colEstimatedDuration,
            this.colStatus});
            this.lvwAvailableTasks.FullRowSelect = true;
            this.lvwAvailableTasks.Location = new System.Drawing.Point(19, 63);
            this.lvwAvailableTasks.MultiSelect = false;
            this.lvwAvailableTasks.Name = "lvwAvailableTasks";
            this.lvwAvailableTasks.Size = new System.Drawing.Size(1270, 414);
            this.lvwAvailableTasks.TabIndex = 31;
            this.lvwAvailableTasks.UseCompatibleStateImageBehavior = false;
            this.lvwAvailableTasks.View = System.Windows.Forms.View.Details;
            this.lvwAvailableTasks.SelectedIndexChanged += new System.EventHandler(this.lvwAvailableTasks_SelectedIndexChanged);
            // 
            // colTaskName
            // 
            this.colTaskName.Text = "Name";
            this.colTaskName.Width = 360;
            // 
            // colTaskDate
            // 
            this.colTaskDate.Text = "Date";
            this.colTaskDate.Width = 220;
            // 
            // colEstimatedDuration
            // 
            this.colEstimatedDuration.Text = "Estimated duration";
            this.colEstimatedDuration.Width = 220;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 220;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDayOfWeek.Location = new System.Drawing.Point(244, 17);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(224, 31);
            this.labelDayOfWeek.TabIndex = 30;
            this.labelDayOfWeek.Text = "Day of the week";
            // 
            // labelAvailableTasks
            // 
            this.labelAvailableTasks.AutoSize = true;
            this.labelAvailableTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvailableTasks.Location = new System.Drawing.Point(13, 17);
            this.labelAvailableTasks.Name = "labelAvailableTasks";
            this.labelAvailableTasks.Size = new System.Drawing.Size(237, 31);
            this.labelAvailableTasks.TabIndex = 13;
            this.labelAvailableTasks.Text = "Available tasks - ";
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.btnTaskMoreDetails);
            this.tabOverview.Controls.Add(this.btnSearch);
            this.tabOverview.Controls.Add(this.rbtnLast2Weeks);
            this.tabOverview.Controls.Add(this.rbtnLastWeek);
            this.tabOverview.Controls.Add(this.rbtnToday);
            this.tabOverview.Controls.Add(this.labelAllTasks);
            this.tabOverview.Controls.Add(this.lvwAllTasks);
            this.tabOverview.Location = new System.Drawing.Point(4, 45);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(1308, 840);
            this.tabOverview.TabIndex = 1;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // btnTaskMoreDetails
            // 
            this.btnTaskMoreDetails.Location = new System.Drawing.Point(17, 534);
            this.btnTaskMoreDetails.Name = "btnTaskMoreDetails";
            this.btnTaskMoreDetails.Size = new System.Drawing.Size(263, 44);
            this.btnTaskMoreDetails.TabIndex = 33;
            this.btnTaskMoreDetails.Text = "More details";
            this.btnTaskMoreDetails.UseVisualStyleBackColor = true;
            this.btnTaskMoreDetails.Click += new System.EventHandler(this.btnTaskMoreDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1204, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 38);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rbtnLast2Weeks
            // 
            this.rbtnLast2Weeks.AutoSize = true;
            this.rbtnLast2Weeks.Location = new System.Drawing.Point(1043, 23);
            this.rbtnLast2Weeks.Name = "rbtnLast2Weeks";
            this.rbtnLast2Weeks.Size = new System.Drawing.Size(135, 28);
            this.rbtnLast2Weeks.TabIndex = 17;
            this.rbtnLast2Weeks.TabStop = true;
            this.rbtnLast2Weeks.Text = "Last 2 weeks";
            this.rbtnLast2Weeks.UseVisualStyleBackColor = true;
            // 
            // rbtnLastWeek
            // 
            this.rbtnLastWeek.AutoSize = true;
            this.rbtnLastWeek.Location = new System.Drawing.Point(926, 23);
            this.rbtnLastWeek.Name = "rbtnLastWeek";
            this.rbtnLastWeek.Size = new System.Drawing.Size(111, 28);
            this.rbtnLastWeek.TabIndex = 16;
            this.rbtnLastWeek.TabStop = true;
            this.rbtnLastWeek.Text = "Last week";
            this.rbtnLastWeek.UseVisualStyleBackColor = true;
            // 
            // rbtnToday
            // 
            this.rbtnToday.AutoSize = true;
            this.rbtnToday.Location = new System.Drawing.Point(839, 23);
            this.rbtnToday.Name = "rbtnToday";
            this.rbtnToday.Size = new System.Drawing.Size(81, 28);
            this.rbtnToday.TabIndex = 15;
            this.rbtnToday.TabStop = true;
            this.rbtnToday.Text = "Today";
            this.rbtnToday.UseVisualStyleBackColor = true;
            // 
            // labelAllTasks
            // 
            this.labelAllTasks.AutoSize = true;
            this.labelAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllTasks.Location = new System.Drawing.Point(11, 13);
            this.labelAllTasks.Name = "labelAllTasks";
            this.labelAllTasks.Size = new System.Drawing.Size(133, 31);
            this.labelAllTasks.TabIndex = 14;
            this.labelAllTasks.Text = "All tasks ";
            // 
            // lvwAllTasks
            // 
            this.lvwAllTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAllTaskName,
            this.colAllTaskDate,
            this.colAllTaskEstimatedDuration,
            this.colAllTaskStatus});
            this.lvwAllTasks.FullRowSelect = true;
            this.lvwAllTasks.Location = new System.Drawing.Point(17, 62);
            this.lvwAllTasks.MultiSelect = false;
            this.lvwAllTasks.Name = "lvwAllTasks";
            this.lvwAllTasks.Size = new System.Drawing.Size(1285, 466);
            this.lvwAllTasks.TabIndex = 0;
            this.lvwAllTasks.UseCompatibleStateImageBehavior = false;
            this.lvwAllTasks.View = System.Windows.Forms.View.Details;
            this.lvwAllTasks.SelectedIndexChanged += new System.EventHandler(this.lvwAllTasks_SelectedIndexChanged);
            // 
            // colAllTaskName
            // 
            this.colAllTaskName.Text = "Name";
            this.colAllTaskName.Width = 360;
            // 
            // colAllTaskDate
            // 
            this.colAllTaskDate.Text = "Date";
            this.colAllTaskDate.Width = 220;
            // 
            // colAllTaskEstimatedDuration
            // 
            this.colAllTaskEstimatedDuration.Text = "Estimated duration";
            this.colAllTaskEstimatedDuration.Width = 220;
            // 
            // colAllTaskStatus
            // 
            this.colAllTaskStatus.Text = "Status";
            this.colAllTaskStatus.Width = 220;
            // 
            // groupBoxTaskDetails
            // 
            this.groupBoxTaskDetails.BackColor = System.Drawing.Color.White;
            this.groupBoxTaskDetails.Controls.Add(this.label2);
            this.groupBoxTaskDetails.Controls.Add(this.tbxEnclosureNumber);
            this.groupBoxTaskDetails.Controls.Add(this.label1);
            this.groupBoxTaskDetails.Controls.Add(this.tbxEnclosureArea);
            this.groupBoxTaskDetails.Controls.Add(this.lblTaskStatus);
            this.groupBoxTaskDetails.Controls.Add(this.lbxTaskEmployees);
            this.groupBoxTaskDetails.Controls.Add(this.label3);
            this.groupBoxTaskDetails.Controls.Add(this.label11);
            this.groupBoxTaskDetails.Controls.Add(this.tbxTaskAnimalName);
            this.groupBoxTaskDetails.Controls.Add(this.tbxAnimalSpecies);
            this.groupBoxTaskDetails.Controls.Add(this.label8);
            this.groupBoxTaskDetails.Controls.Add(this.groupBox3);
            this.groupBoxTaskDetails.Controls.Add(this.label4);
            this.groupBoxTaskDetails.Controls.Add(this.tbxEstimatedTaskTime);
            this.groupBoxTaskDetails.Controls.Add(this.tbxTaskID);
            this.groupBoxTaskDetails.Controls.Add(this.label7);
            this.groupBoxTaskDetails.Controls.Add(this.label10);
            this.groupBoxTaskDetails.Controls.Add(this.label5);
            this.groupBoxTaskDetails.Controls.Add(this.label9);
            this.groupBoxTaskDetails.Controls.Add(this.tbxTaskDate);
            this.groupBoxTaskDetails.Controls.Add(this.tbxTaskTitle);
            this.groupBoxTaskDetails.Controls.Add(this.label6);
            this.groupBoxTaskDetails.Location = new System.Drawing.Point(1361, 94);
            this.groupBoxTaskDetails.Name = "groupBoxTaskDetails";
            this.groupBoxTaskDetails.Size = new System.Drawing.Size(468, 747);
            this.groupBoxTaskDetails.TabIndex = 39;
            this.groupBoxTaskDetails.TabStop = false;
            this.groupBoxTaskDetails.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enclosure number:";
            // 
            // tbxEnclosureNumber
            // 
            this.tbxEnclosureNumber.Location = new System.Drawing.Point(243, 241);
            this.tbxEnclosureNumber.Name = "tbxEnclosureNumber";
            this.tbxEnclosureNumber.ReadOnly = true;
            this.tbxEnclosureNumber.Size = new System.Drawing.Size(76, 29);
            this.tbxEnclosureNumber.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enclosure area:";
            // 
            // tbxEnclosureArea
            // 
            this.tbxEnclosureArea.Location = new System.Drawing.Point(243, 208);
            this.tbxEnclosureArea.Name = "tbxEnclosureArea";
            this.tbxEnclosureArea.ReadOnly = true;
            this.tbxEnclosureArea.Size = new System.Drawing.Size(188, 29);
            this.tbxEnclosureArea.TabIndex = 21;
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaskStatus.Location = new System.Drawing.Point(211, 697);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(114, 37);
            this.lblTaskStatus.TabIndex = 20;
            this.lblTaskStatus.Text = "Status";
            // 
            // lbxTaskEmployees
            // 
            this.lbxTaskEmployees.FormattingEnabled = true;
            this.lbxTaskEmployees.ItemHeight = 24;
            this.lbxTaskEmployees.Location = new System.Drawing.Point(134, 416);
            this.lbxTaskEmployees.Name = "lbxTaskEmployees";
            this.lbxTaskEmployees.Size = new System.Drawing.Size(313, 76);
            this.lbxTaskEmployees.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Task details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Assigned employee(s):";
            // 
            // tbxTaskAnimalName
            // 
            this.tbxTaskAnimalName.Location = new System.Drawing.Point(244, 347);
            this.tbxTaskAnimalName.Name = "tbxTaskAnimalName";
            this.tbxTaskAnimalName.ReadOnly = true;
            this.tbxTaskAnimalName.Size = new System.Drawing.Size(203, 29);
            this.tbxTaskAnimalName.TabIndex = 14;
            // 
            // tbxAnimalSpecies
            // 
            this.tbxAnimalSpecies.Location = new System.Drawing.Point(244, 298);
            this.tbxAnimalSpecies.Name = "tbxAnimalSpecies";
            this.tbxAnimalSpecies.ReadOnly = true;
            this.tbxAnimalSpecies.Size = new System.Drawing.Size(203, 29);
            this.tbxAnimalSpecies.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "hour(s)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxSelectedTaskDescription);
            this.groupBox3.Location = new System.Drawing.Point(22, 509);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 176);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description:";
            // 
            // tbxSelectedTaskDescription
            // 
            this.tbxSelectedTaskDescription.Location = new System.Drawing.Point(6, 28);
            this.tbxSelectedTaskDescription.Multiline = true;
            this.tbxSelectedTaskDescription.Name = "tbxSelectedTaskDescription";
            this.tbxSelectedTaskDescription.ReadOnly = true;
            this.tbxSelectedTaskDescription.Size = new System.Drawing.Size(413, 142);
            this.tbxSelectedTaskDescription.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID:";
            // 
            // tbxEstimatedTaskTime
            // 
            this.tbxEstimatedTaskTime.Location = new System.Drawing.Point(186, 164);
            this.tbxEstimatedTaskTime.Name = "tbxEstimatedTaskTime";
            this.tbxEstimatedTaskTime.ReadOnly = true;
            this.tbxEstimatedTaskTime.Size = new System.Drawing.Size(85, 29);
            this.tbxEstimatedTaskTime.TabIndex = 18;
            // 
            // tbxTaskID
            // 
            this.tbxTaskID.Location = new System.Drawing.Point(355, 31);
            this.tbxTaskID.Name = "tbxTaskID";
            this.tbxTaskID.ReadOnly = true;
            this.tbxTaskID.Size = new System.Drawing.Size(76, 29);
            this.tbxTaskID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estimated time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Animal name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Animal species:";
            // 
            // tbxTaskDate
            // 
            this.tbxTaskDate.Location = new System.Drawing.Point(104, 118);
            this.tbxTaskDate.Name = "tbxTaskDate";
            this.tbxTaskDate.ReadOnly = true;
            this.tbxTaskDate.Size = new System.Drawing.Size(226, 29);
            this.tbxTaskDate.TabIndex = 16;
            // 
            // tbxTaskTitle
            // 
            this.tbxTaskTitle.Location = new System.Drawing.Point(104, 75);
            this.tbxTaskTitle.Name = "tbxTaskTitle";
            this.tbxTaskTitle.ReadOnly = true;
            this.tbxTaskTitle.Size = new System.Drawing.Size(327, 29);
            this.tbxTaskTitle.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date:";
            // 
            // FormResourcePlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DesktopApplication.Properties.Resources.zooimg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1919, 1061);
            this.Controls.Add(this.groupBoxTaskDetails);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlResourcePlanner);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormResourcePlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Planner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlResourcePlanner.ResumeLayout(false);
            this.tabAssignTasks.ResumeLayout(false);
            this.tabAssignTasks.PerformLayout();
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            this.groupBoxTaskDetails.ResumeLayout(false);
            this.groupBoxTaskDetails.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleZooBazaar;
        private System.Windows.Forms.TabControl tabControlResourcePlanner;
        private System.Windows.Forms.TabPage tabAssignTasks;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Label labelAvailableTasks;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.Label labelCaretakers;
        private System.Windows.Forms.ComboBox cbxCaretakers;
        private System.Windows.Forms.Button btnMoreDetailsTask;
        private System.Windows.Forms.ListView lvwAvailableTasks;
        private System.Windows.Forms.Button btnAssignEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbtnLast2Weeks;
        private System.Windows.Forms.RadioButton rbtnLastWeek;
        private System.Windows.Forms.RadioButton rbtnToday;
        private System.Windows.Forms.Label labelAllTasks;
        private System.Windows.Forms.ListView lvwAllTasks;
        private System.Windows.Forms.Button btnTaskMoreDetails;
        private System.Windows.Forms.ColumnHeader colTaskName;
        private System.Windows.Forms.ColumnHeader colTaskDate;
        private System.Windows.Forms.ColumnHeader colStatus;
        private ColumnHeader colEstimatedDuration;
        private GroupBox groupBoxTaskDetails;
        private Label lblTaskStatus;
        private ListBox lbxTaskEmployees;
        private Label label3;
        private Label label11;
        private TextBox tbxTaskAnimalName;
        private TextBox tbxAnimalSpecies;
        private Label label8;
        private GroupBox groupBox3;
        private TextBox tbxSelectedTaskDescription;
        private Label label4;
        private TextBox tbxEstimatedTaskTime;
        private TextBox tbxTaskID;
        private Label label7;
        private Label label10;
        private Label label5;
        private Label label9;
        private TextBox tbxTaskDate;
        private TextBox tbxTaskTitle;
        private Label label6;
        private ColumnHeader colAllTaskName;
        private ColumnHeader colAllTaskDate;
        private ColumnHeader colAllTaskEstimatedDuration;
        private ColumnHeader colAllTaskStatus;
        private Label label2;
        private TextBox tbxEnclosureNumber;
        private Label label1;
        private TextBox tbxEnclosureArea;
        private Button button1;
    }
}