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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwFinishedTasks = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoreTaskDetails = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnScheduleTask = new System.Windows.Forms.Button();
            this.tbxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwAnimalSearch = new System.Windows.Forms.ListView();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudEstimatedTaskTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSearchBySpecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(800, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 458);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvwTasksInProgress);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "In progress";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvwFinishedTasks);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 421);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(798, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scheduled tasks";
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
            this.btnRemoveTask.Location = new System.Drawing.Point(804, 503);
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
            this.tbxTaskDescription.Size = new System.Drawing.Size(662, 146);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudEstimatedTaskTime);
            this.groupBox1.Controls.Add(this.tbxTaskDescription);
            this.groupBox1.Controls.Add(this.labelTaskDescription);
            this.groupBox1.Controls.Add(this.btnScheduleTask);
            this.groupBox1.Controls.Add(this.dtpTaskTime);
            this.groupBox1.Controls.Add(this.labelTaskTime);
            this.groupBox1.Controls.Add(this.calTaskDateSelection);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 573);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule new task";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(253, 77);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(207, 29);
            this.tbxSearchByName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "hour(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estimated time:";
            // 
            // nudEstimatedTaskTime
            // 
            this.nudEstimatedTaskTime.Location = new System.Drawing.Point(497, 293);
            this.nudEstimatedTaskTime.Name = "nudEstimatedTaskTime";
            this.nudEstimatedTaskTime.Size = new System.Drawing.Size(133, 29);
            this.nudEstimatedTaskTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search by name:";
            // 
            // cbxSearchBySpecie
            // 
            this.cbxSearchBySpecie.FormattingEnabled = true;
            this.cbxSearchBySpecie.Location = new System.Drawing.Point(253, 39);
            this.cbxSearchBySpecie.Name = "cbxSearchBySpecie";
            this.cbxSearchBySpecie.Size = new System.Drawing.Size(207, 32);
            this.cbxSearchBySpecie.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Species:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwAnimalSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxSearchByName);
            this.groupBox2.Controls.Add(this.cbxSearchBySpecie);
            this.groupBox2.Location = new System.Drawing.Point(6, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 284);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animal search";
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 62;
            // 
            // colSpecie
            // 
            this.colSpecie.Text = "Specie";
            this.colSpecie.Width = 142;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 174;
            // 
            // FormScheduleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1255, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnMoreTaskDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormScheduleTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScheduleTask";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calTaskDateSelection;
        private System.Windows.Forms.DateTimePicker dtpTaskTime;
        private System.Windows.Forms.Label labelTaskTime;
        private System.Windows.Forms.ListView lvwTasksInProgress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvwFinishedTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoreTaskDetails;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnScheduleTask;
        private System.Windows.Forms.TextBox tbxTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudEstimatedTaskTime;
        private System.Windows.Forms.ListView lvwAnimalSearch;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colSpecie;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSearchBySpecie;
    }
}