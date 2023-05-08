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
            labelTitleZooBazaar = new Label();
            tabControlResourcePlanner = new TabControl();
            tabAssignTasks = new TabPage();
            btnAssignEmployee = new Button();
            labelCaretakers = new Label();
            cbxCaretakers = new ComboBox();
            btnMoreDetailsTask = new Button();
            lvwAvailableTasks = new ListView();
            colTaskName = new ColumnHeader();
            colTaskDate = new ColumnHeader();
            colEstimatedDuration = new ColumnHeader();
            colStatus = new ColumnHeader();
            labelDayOfWeek = new Label();
            labelAvailableTasks = new Label();
            tabOverview = new TabPage();
            btnTaskMoreDetails = new Button();
            btnSearch = new Button();
            rbtnLast2Weeks = new RadioButton();
            rbtnLastWeek = new RadioButton();
            rbtnToday = new RadioButton();
            labelAllTasks = new Label();
            lvwAllTasks = new ListView();
            colAllTaskName = new ColumnHeader();
            colAllTaskDate = new ColumnHeader();
            colAllTaskEstimatedDuration = new ColumnHeader();
            colAllTaskStatus = new ColumnHeader();
            groupBoxTaskDetails = new GroupBox();
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
            tabControlResourcePlanner.SuspendLayout();
            tabAssignTasks.SuspendLayout();
            tabOverview.SuspendLayout();
            groupBoxTaskDetails.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitleZooBazaar
            // 
            labelTitleZooBazaar.AutoSize = true;
            labelTitleZooBazaar.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleZooBazaar.Location = new Point(858, 21);
            labelTitleZooBazaar.Margin = new Padding(4, 0, 4, 0);
            labelTitleZooBazaar.Name = "labelTitleZooBazaar";
            labelTitleZooBazaar.Size = new Size(184, 37);
            labelTitleZooBazaar.TabIndex = 13;
            labelTitleZooBazaar.Text = "ZooBazaar";
            // 
            // tabControlResourcePlanner
            // 
            tabControlResourcePlanner.Controls.Add(tabAssignTasks);
            tabControlResourcePlanner.Controls.Add(tabOverview);
            tabControlResourcePlanner.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlResourcePlanner.Location = new Point(39, 49);
            tabControlResourcePlanner.Name = "tabControlResourcePlanner";
            tabControlResourcePlanner.Padding = new Point(70, 9);
            tabControlResourcePlanner.SelectedIndex = 0;
            tabControlResourcePlanner.Size = new Size(1316, 889);
            tabControlResourcePlanner.TabIndex = 12;
            // 
            // tabAssignTasks
            // 
            tabAssignTasks.Controls.Add(btnAssignEmployee);
            tabAssignTasks.Controls.Add(labelCaretakers);
            tabAssignTasks.Controls.Add(cbxCaretakers);
            tabAssignTasks.Controls.Add(btnMoreDetailsTask);
            tabAssignTasks.Controls.Add(lvwAvailableTasks);
            tabAssignTasks.Controls.Add(labelDayOfWeek);
            tabAssignTasks.Controls.Add(labelAvailableTasks);
            tabAssignTasks.Location = new Point(4, 45);
            tabAssignTasks.Name = "tabAssignTasks";
            tabAssignTasks.Padding = new Padding(3);
            tabAssignTasks.Size = new Size(1308, 840);
            tabAssignTasks.TabIndex = 0;
            tabAssignTasks.Text = "Assign tasks";
            tabAssignTasks.UseVisualStyleBackColor = true;
            // 
            // btnAssignEmployee
            // 
            btnAssignEmployee.Location = new Point(19, 638);
            btnAssignEmployee.Name = "btnAssignEmployee";
            btnAssignEmployee.Size = new Size(209, 44);
            btnAssignEmployee.TabIndex = 37;
            btnAssignEmployee.Text = "Assign employee";
            btnAssignEmployee.UseVisualStyleBackColor = true;
            btnAssignEmployee.Click += btnAssignEmployee_Click;
            // 
            // labelCaretakers
            // 
            labelCaretakers.AutoSize = true;
            labelCaretakers.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCaretakers.Location = new Point(13, 554);
            labelCaretakers.Name = "labelCaretakers";
            labelCaretakers.Size = new Size(158, 31);
            labelCaretakers.TabIndex = 34;
            labelCaretakers.Text = "Caretakers";
            // 
            // cbxCaretakers
            // 
            cbxCaretakers.FormattingEnabled = true;
            cbxCaretakers.Location = new Point(19, 600);
            cbxCaretakers.Name = "cbxCaretakers";
            cbxCaretakers.Size = new Size(303, 32);
            cbxCaretakers.TabIndex = 33;
            // 
            // btnMoreDetailsTask
            // 
            btnMoreDetailsTask.Location = new Point(19, 483);
            btnMoreDetailsTask.Name = "btnMoreDetailsTask";
            btnMoreDetailsTask.Size = new Size(291, 44);
            btnMoreDetailsTask.TabIndex = 32;
            btnMoreDetailsTask.Text = "More details";
            btnMoreDetailsTask.UseVisualStyleBackColor = true;
            btnMoreDetailsTask.Click += btnMoreDetailsTask_Click;
            // 
            // lvwAvailableTasks
            // 
            lvwAvailableTasks.Columns.AddRange(new ColumnHeader[] { colTaskName, colTaskDate, colEstimatedDuration, colStatus });
            lvwAvailableTasks.FullRowSelect = true;
            lvwAvailableTasks.Location = new Point(19, 63);
            lvwAvailableTasks.MultiSelect = false;
            lvwAvailableTasks.Name = "lvwAvailableTasks";
            lvwAvailableTasks.Size = new Size(1270, 414);
            lvwAvailableTasks.TabIndex = 31;
            lvwAvailableTasks.UseCompatibleStateImageBehavior = false;
            lvwAvailableTasks.View = View.Details;
            lvwAvailableTasks.SelectedIndexChanged += lvwAvailableTasks_SelectedIndexChanged;
            // 
            // colTaskName
            // 
            colTaskName.Text = "Name";
            colTaskName.Width = 360;
            // 
            // colTaskDate
            // 
            colTaskDate.Text = "Date";
            colTaskDate.Width = 220;
            // 
            // colEstimatedDuration
            // 
            colEstimatedDuration.Text = "Estimated duration";
            colEstimatedDuration.Width = 220;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 220;
            // 
            // labelDayOfWeek
            // 
            labelDayOfWeek.AutoSize = true;
            labelDayOfWeek.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDayOfWeek.Location = new Point(244, 17);
            labelDayOfWeek.Name = "labelDayOfWeek";
            labelDayOfWeek.Size = new Size(224, 31);
            labelDayOfWeek.TabIndex = 30;
            labelDayOfWeek.Text = "Day of the week";
            // 
            // labelAvailableTasks
            // 
            labelAvailableTasks.AutoSize = true;
            labelAvailableTasks.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAvailableTasks.Location = new Point(13, 17);
            labelAvailableTasks.Name = "labelAvailableTasks";
            labelAvailableTasks.Size = new Size(237, 31);
            labelAvailableTasks.TabIndex = 13;
            labelAvailableTasks.Text = "Available tasks - ";
            // 
            // tabOverview
            // 
            tabOverview.Controls.Add(btnTaskMoreDetails);
            tabOverview.Controls.Add(btnSearch);
            tabOverview.Controls.Add(rbtnLast2Weeks);
            tabOverview.Controls.Add(rbtnLastWeek);
            tabOverview.Controls.Add(rbtnToday);
            tabOverview.Controls.Add(labelAllTasks);
            tabOverview.Controls.Add(lvwAllTasks);
            tabOverview.Location = new Point(4, 45);
            tabOverview.Name = "tabOverview";
            tabOverview.Padding = new Padding(3);
            tabOverview.Size = new Size(1308, 840);
            tabOverview.TabIndex = 1;
            tabOverview.Text = "Overview";
            tabOverview.UseVisualStyleBackColor = true;
            // 
            // btnTaskMoreDetails
            // 
            btnTaskMoreDetails.Location = new Point(17, 534);
            btnTaskMoreDetails.Name = "btnTaskMoreDetails";
            btnTaskMoreDetails.Size = new Size(263, 44);
            btnTaskMoreDetails.TabIndex = 33;
            btnTaskMoreDetails.Text = "More details";
            btnTaskMoreDetails.UseVisualStyleBackColor = true;
            btnTaskMoreDetails.Click += btnTaskMoreDetails_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1204, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 38);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // rbtnLast2Weeks
            // 
            rbtnLast2Weeks.AutoSize = true;
            rbtnLast2Weeks.Location = new Point(1043, 23);
            rbtnLast2Weeks.Name = "rbtnLast2Weeks";
            rbtnLast2Weeks.Size = new Size(135, 28);
            rbtnLast2Weeks.TabIndex = 17;
            rbtnLast2Weeks.TabStop = true;
            rbtnLast2Weeks.Text = "Last 2 weeks";
            rbtnLast2Weeks.UseVisualStyleBackColor = true;
            // 
            // rbtnLastWeek
            // 
            rbtnLastWeek.AutoSize = true;
            rbtnLastWeek.Location = new Point(926, 23);
            rbtnLastWeek.Name = "rbtnLastWeek";
            rbtnLastWeek.Size = new Size(111, 28);
            rbtnLastWeek.TabIndex = 16;
            rbtnLastWeek.TabStop = true;
            rbtnLastWeek.Text = "Last week";
            rbtnLastWeek.UseVisualStyleBackColor = true;
            // 
            // rbtnToday
            // 
            rbtnToday.AutoSize = true;
            rbtnToday.Location = new Point(839, 23);
            rbtnToday.Name = "rbtnToday";
            rbtnToday.Size = new Size(81, 28);
            rbtnToday.TabIndex = 15;
            rbtnToday.TabStop = true;
            rbtnToday.Text = "Today";
            rbtnToday.UseVisualStyleBackColor = true;
            // 
            // labelAllTasks
            // 
            labelAllTasks.AutoSize = true;
            labelAllTasks.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllTasks.Location = new Point(11, 13);
            labelAllTasks.Name = "labelAllTasks";
            labelAllTasks.Size = new Size(133, 31);
            labelAllTasks.TabIndex = 14;
            labelAllTasks.Text = "All tasks ";
            // 
            // lvwAllTasks
            // 
            lvwAllTasks.Columns.AddRange(new ColumnHeader[] { colAllTaskName, colAllTaskDate, colAllTaskEstimatedDuration, colAllTaskStatus });
            lvwAllTasks.FullRowSelect = true;
            lvwAllTasks.Location = new Point(17, 62);
            lvwAllTasks.MultiSelect = false;
            lvwAllTasks.Name = "lvwAllTasks";
            lvwAllTasks.Size = new Size(1285, 466);
            lvwAllTasks.TabIndex = 0;
            lvwAllTasks.UseCompatibleStateImageBehavior = false;
            lvwAllTasks.View = View.Details;
            lvwAllTasks.SelectedIndexChanged += lvwAllTasks_SelectedIndexChanged;
            // 
            // colAllTaskName
            // 
            colAllTaskName.Text = "Name";
            colAllTaskName.Width = 360;
            // 
            // colAllTaskDate
            // 
            colAllTaskDate.Text = "Date";
            colAllTaskDate.Width = 220;
            // 
            // colAllTaskEstimatedDuration
            // 
            colAllTaskEstimatedDuration.Text = "Estimated duration";
            colAllTaskEstimatedDuration.Width = 220;
            // 
            // colAllTaskStatus
            // 
            colAllTaskStatus.Text = "Status";
            colAllTaskStatus.Width = 220;
            // 
            // groupBoxTaskDetails
            // 
            groupBoxTaskDetails.BackColor = Color.White;
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
            groupBoxTaskDetails.Location = new Point(1361, 94);
            groupBoxTaskDetails.Name = "groupBoxTaskDetails";
            groupBoxTaskDetails.Size = new Size(468, 675);
            groupBoxTaskDetails.TabIndex = 39;
            groupBoxTaskDetails.TabStop = false;
            groupBoxTaskDetails.Visible = false;
            // 
            // lblTaskStatus
            // 
            lblTaskStatus.AutoSize = true;
            lblTaskStatus.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaskStatus.Location = new Point(195, 619);
            lblTaskStatus.Name = "lblTaskStatus";
            lblTaskStatus.Size = new Size(114, 37);
            lblTaskStatus.TabIndex = 20;
            lblTaskStatus.Text = "Status";
            // 
            // lbxTaskEmployees
            // 
            lbxTaskEmployees.FormattingEnabled = true;
            lbxTaskEmployees.ItemHeight = 24;
            lbxTaskEmployees.Location = new Point(118, 338);
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
            label11.Location = new Point(227, 311);
            label11.Name = "label11";
            label11.Size = new Size(204, 24);
            label11.TabIndex = 11;
            label11.Text = "Assigned employee(s):";
            // 
            // tbxTaskAnimalName
            // 
            tbxTaskAnimalName.Location = new Point(228, 269);
            tbxTaskAnimalName.Name = "tbxTaskAnimalName";
            tbxTaskAnimalName.ReadOnly = true;
            tbxTaskAnimalName.Size = new Size(203, 29);
            tbxTaskAnimalName.TabIndex = 14;
            // 
            // tbxAnimalSpecies
            // 
            tbxAnimalSpecies.Location = new Point(228, 220);
            tbxAnimalSpecies.Name = "tbxAnimalSpecies";
            tbxAnimalSpecies.ReadOnly = true;
            tbxAnimalSpecies.Size = new Size(203, 29);
            tbxAnimalSpecies.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 167);
            label8.Name = "label8";
            label8.Size = new Size(70, 24);
            label8.TabIndex = 19;
            label8.Text = "hour(s)";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbxSelectedTaskDescription);
            groupBox3.Location = new Point(6, 431);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 176);
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
            tbxSelectedTaskDescription.Size = new Size(413, 142);
            tbxSelectedTaskDescription.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 33);
            label4.Name = "label4";
            label4.Size = new Size(32, 24);
            label4.TabIndex = 1;
            label4.Text = "ID:";
            // 
            // tbxEstimatedTaskTime
            // 
            tbxEstimatedTaskTime.Location = new Point(186, 164);
            tbxEstimatedTaskTime.Name = "tbxEstimatedTaskTime";
            tbxEstimatedTaskTime.ReadOnly = true;
            tbxEstimatedTaskTime.Size = new Size(85, 29);
            tbxEstimatedTaskTime.TabIndex = 18;
            // 
            // tbxTaskID
            // 
            tbxTaskID.Location = new Point(355, 31);
            tbxTaskID.Name = "tbxTaskID";
            tbxTaskID.ReadOnly = true;
            tbxTaskID.Size = new Size(76, 29);
            tbxTaskID.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 167);
            label7.Name = "label7";
            label7.Size = new Size(137, 24);
            label7.TabIndex = 17;
            label7.Text = "Estimated time:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(85, 272);
            label10.Name = "label10";
            label10.Size = new Size(126, 24);
            label10.TabIndex = 5;
            label10.Text = "Animal name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 78);
            label5.Name = "label5";
            label5.Size = new Size(50, 24);
            label5.TabIndex = 2;
            label5.Text = "Title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 223);
            label9.Name = "label9";
            label9.Size = new Size(143, 24);
            label9.TabIndex = 4;
            label9.Text = "Animal species:";
            // 
            // tbxTaskDate
            // 
            tbxTaskDate.Location = new Point(104, 118);
            tbxTaskDate.Name = "tbxTaskDate";
            tbxTaskDate.ReadOnly = true;
            tbxTaskDate.Size = new Size(226, 29);
            tbxTaskDate.TabIndex = 16;
            // 
            // tbxTaskTitle
            // 
            tbxTaskTitle.Location = new Point(104, 75);
            tbxTaskTitle.Name = "tbxTaskTitle";
            tbxTaskTitle.ReadOnly = true;
            tbxTaskTitle.Size = new Size(327, 29);
            tbxTaskTitle.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 121);
            label6.Name = "label6";
            label6.Size = new Size(53, 24);
            label6.TabIndex = 15;
            label6.Text = "Date:";
            // 
            // FormResourcePlanner
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.zooimg5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1919, 1061);
            Controls.Add(groupBoxTaskDetails);
            Controls.Add(labelTitleZooBazaar);
            Controls.Add(tabControlResourcePlanner);
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FormResourcePlanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormResourcePlanner";
            WindowState = FormWindowState.Maximized;
            tabControlResourcePlanner.ResumeLayout(false);
            tabAssignTasks.ResumeLayout(false);
            tabAssignTasks.PerformLayout();
            tabOverview.ResumeLayout(false);
            tabOverview.PerformLayout();
            groupBoxTaskDetails.ResumeLayout(false);
            groupBoxTaskDetails.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}