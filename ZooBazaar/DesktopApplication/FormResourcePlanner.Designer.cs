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
            this.labelDetailsEmployee = new System.Windows.Forms.Label();
            this.labelScheduleEmployee = new System.Windows.Forms.Label();
            this.labelCaretakers = new System.Windows.Forms.Label();
            this.cbxCaretakers = new System.Windows.Forms.ComboBox();
            this.btnMoreDetailsTask = new System.Windows.Forms.Button();
            this.lvwAvailableTasks = new System.Windows.Forms.ListView();
            this.colTaskName = new System.Windows.Forms.ColumnHeader();
            this.colTaskDate = new System.Windows.Forms.ColumnHeader();
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
            this.tabControlResourcePlanner.SuspendLayout();
            this.tabAssignTasks.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleZooBazaar
            // 
            this.labelTitleZooBazaar.AutoSize = true;
            this.labelTitleZooBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleZooBazaar.Location = new System.Drawing.Point(495, 9);
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
            this.tabControlResourcePlanner.Location = new System.Drawing.Point(8, 50);
            this.tabControlResourcePlanner.Name = "tabControlResourcePlanner";
            this.tabControlResourcePlanner.Padding = new System.Drawing.Point(70, 9);
            this.tabControlResourcePlanner.SelectedIndex = 0;
            this.tabControlResourcePlanner.Size = new System.Drawing.Size(1160, 583);
            this.tabControlResourcePlanner.TabIndex = 12;
            // 
            // tabAssignTasks
            // 
            this.tabAssignTasks.Controls.Add(this.button1);
            this.tabAssignTasks.Controls.Add(this.btnAssignEmployee);
            this.tabAssignTasks.Controls.Add(this.labelDetailsEmployee);
            this.tabAssignTasks.Controls.Add(this.labelScheduleEmployee);
            this.tabAssignTasks.Controls.Add(this.labelCaretakers);
            this.tabAssignTasks.Controls.Add(this.cbxCaretakers);
            this.tabAssignTasks.Controls.Add(this.btnMoreDetailsTask);
            this.tabAssignTasks.Controls.Add(this.lvwAvailableTasks);
            this.tabAssignTasks.Controls.Add(this.labelDayOfWeek);
            this.tabAssignTasks.Controls.Add(this.labelAvailableTasks);
            this.tabAssignTasks.Location = new System.Drawing.Point(4, 45);
            this.tabAssignTasks.Name = "tabAssignTasks";
            this.tabAssignTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignTasks.Size = new System.Drawing.Size(1152, 534);
            this.tabAssignTasks.TabIndex = 0;
            this.tabAssignTasks.Text = "Assign tasks";
            this.tabAssignTasks.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 44);
            this.button1.TabIndex = 38;
            this.button1.Text = "More details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.Location = new System.Drawing.Point(634, 171);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(209, 44);
            this.btnAssignEmployee.TabIndex = 37;
            this.btnAssignEmployee.Text = "Assign employee";
            this.btnAssignEmployee.UseVisualStyleBackColor = true;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click);
            // 
            // labelDetailsEmployee
            // 
            this.labelDetailsEmployee.AutoSize = true;
            this.labelDetailsEmployee.Location = new System.Drawing.Point(630, 144);
            this.labelDetailsEmployee.Name = "labelDetailsEmployee";
            this.labelDetailsEmployee.Size = new System.Drawing.Size(263, 24);
            this.labelDetailsEmployee.TabIndex = 36;
            this.labelDetailsEmployee.Text = "Details about today\'s schedule";
            // 
            // labelScheduleEmployee
            // 
            this.labelScheduleEmployee.AutoSize = true;
            this.labelScheduleEmployee.Location = new System.Drawing.Point(630, 120);
            this.labelScheduleEmployee.Name = "labelScheduleEmployee";
            this.labelScheduleEmployee.Size = new System.Drawing.Size(96, 24);
            this.labelScheduleEmployee.TabIndex = 35;
            this.labelScheduleEmployee.Text = "Schedule:";
            // 
            // labelCaretakers
            // 
            this.labelCaretakers.AutoSize = true;
            this.labelCaretakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCaretakers.Location = new System.Drawing.Point(628, 12);
            this.labelCaretakers.Name = "labelCaretakers";
            this.labelCaretakers.Size = new System.Drawing.Size(158, 31);
            this.labelCaretakers.TabIndex = 34;
            this.labelCaretakers.Text = "Caretakers";
            // 
            // cbxCaretakers
            // 
            this.cbxCaretakers.FormattingEnabled = true;
            this.cbxCaretakers.Location = new System.Drawing.Point(634, 58);
            this.cbxCaretakers.Name = "cbxCaretakers";
            this.cbxCaretakers.Size = new System.Drawing.Size(303, 32);
            this.cbxCaretakers.TabIndex = 33;
            // 
            // btnMoreDetailsTask
            // 
            this.btnMoreDetailsTask.Location = new System.Drawing.Point(14, 478);
            this.btnMoreDetailsTask.Name = "btnMoreDetailsTask";
            this.btnMoreDetailsTask.Size = new System.Drawing.Size(209, 44);
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
            this.colStatus});
            this.lvwAvailableTasks.FullRowSelect = true;
            this.lvwAvailableTasks.Location = new System.Drawing.Point(14, 58);
            this.lvwAvailableTasks.MultiSelect = false;
            this.lvwAvailableTasks.Name = "lvwAvailableTasks";
            this.lvwAvailableTasks.Size = new System.Drawing.Size(513, 414);
            this.lvwAvailableTasks.TabIndex = 31;
            this.lvwAvailableTasks.UseCompatibleStateImageBehavior = false;
            this.lvwAvailableTasks.View = System.Windows.Forms.View.Details;
            this.lvwAvailableTasks.SelectedIndexChanged += new System.EventHandler(this.lvwAvailableTasks_SelectedIndexChanged);
            // 
            // colTaskName
            // 
            this.colTaskName.Text = "Name";
            this.colTaskName.Width = 250;
            // 
            // colTaskDate
            // 
            this.colTaskDate.Text = "Date";
            this.colTaskDate.Width = 131;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 128;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDayOfWeek.Location = new System.Drawing.Point(239, 12);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(224, 31);
            this.labelDayOfWeek.TabIndex = 30;
            this.labelDayOfWeek.Text = "Day of the week";
            // 
            // labelAvailableTasks
            // 
            this.labelAvailableTasks.AutoSize = true;
            this.labelAvailableTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvailableTasks.Location = new System.Drawing.Point(8, 12);
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
            this.tabOverview.Size = new System.Drawing.Size(1152, 534);
            this.tabOverview.TabIndex = 1;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // btnTaskMoreDetails
            // 
            this.btnTaskMoreDetails.Location = new System.Drawing.Point(996, 484);
            this.btnTaskMoreDetails.Name = "btnTaskMoreDetails";
            this.btnTaskMoreDetails.Size = new System.Drawing.Size(144, 44);
            this.btnTaskMoreDetails.TabIndex = 33;
            this.btnTaskMoreDetails.Text = "More details";
            this.btnTaskMoreDetails.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(892, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 38);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rbtnLast2Weeks
            // 
            this.rbtnLast2Weeks.AutoSize = true;
            this.rbtnLast2Weeks.Location = new System.Drawing.Point(731, 20);
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
            this.rbtnLastWeek.Location = new System.Drawing.Point(614, 20);
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
            this.rbtnToday.Location = new System.Drawing.Point(527, 20);
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
            this.lvwAllTasks.Location = new System.Drawing.Point(17, 62);
            this.lvwAllTasks.Name = "lvwAllTasks";
            this.lvwAllTasks.Size = new System.Drawing.Size(973, 466);
            this.lvwAllTasks.TabIndex = 0;
            this.lvwAllTasks.UseCompatibleStateImageBehavior = false;
            // 
            // FormResourcePlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DesktopApplication.Properties.Resources.zooimg5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 642);
            this.Controls.Add(this.labelTitleZooBazaar);
            this.Controls.Add(this.tabControlResourcePlanner);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormResourcePlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResourcePlanner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlResourcePlanner.ResumeLayout(false);
            this.tabAssignTasks.ResumeLayout(false);
            this.tabAssignTasks.PerformLayout();
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
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
        private System.Windows.Forms.Label labelDetailsEmployee;
        private System.Windows.Forms.Label labelScheduleEmployee;
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
        private System.Windows.Forms.Button button1;
    }
}