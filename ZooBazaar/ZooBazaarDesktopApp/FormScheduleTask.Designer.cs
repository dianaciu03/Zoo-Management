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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudEstimatedTaskTime = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedTaskTime)).BeginInit();
            this.SuspendLayout();
            // 
            // calTaskDateSelection
            // 
            this.calTaskDateSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calTaskDateSelection.Location = new System.Drawing.Point(435, 47);
            this.calTaskDateSelection.Name = "calTaskDateSelection";
            this.calTaskDateSelection.TabIndex = 0;
            // 
            // dtpTaskTime
            // 
            this.dtpTaskTime.CustomFormat = "    HH:00";
            this.dtpTaskTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskTime.Location = new System.Drawing.Point(250, 246);
            this.dtpTaskTime.Name = "dtpTaskTime";
            this.dtpTaskTime.Size = new System.Drawing.Size(148, 29);
            this.dtpTaskTime.TabIndex = 1;
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Location = new System.Drawing.Point(167, 250);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(58, 24);
            this.labelTaskTime.TabIndex = 2;
            this.labelTaskTime.Text = "Time:";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(694, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 458);
            this.tabControl1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scheduled tasks";
            // 
            // btnMoreTaskDetails
            // 
            this.btnMoreTaskDetails.Location = new System.Drawing.Point(694, 503);
            this.btnMoreTaskDetails.Name = "btnMoreTaskDetails";
            this.btnMoreTaskDetails.Size = new System.Drawing.Size(268, 44);
            this.btnMoreTaskDetails.TabIndex = 6;
            this.btnMoreTaskDetails.Text = "More details";
            this.btnMoreTaskDetails.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(970, 503);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(268, 44);
            this.btnRemoveTask.TabIndex = 7;
            this.btnRemoveTask.Text = "Remove task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // btnScheduleTask
            // 
            this.btnScheduleTask.Location = new System.Drawing.Point(12, 501);
            this.btnScheduleTask.Name = "btnScheduleTask";
            this.btnScheduleTask.Size = new System.Drawing.Size(177, 44);
            this.btnScheduleTask.TabIndex = 8;
            this.btnScheduleTask.Text = "Schedule task";
            this.btnScheduleTask.UseVisualStyleBackColor = true;
            // 
            // tbxTaskDescription
            // 
            this.tbxTaskDescription.Location = new System.Drawing.Point(12, 319);
            this.tbxTaskDescription.Multiline = true;
            this.tbxTaskDescription.Name = "tbxTaskDescription";
            this.tbxTaskDescription.Size = new System.Drawing.Size(498, 176);
            this.tbxTaskDescription.TabIndex = 9;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(8, 292);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(147, 24);
            this.labelTaskDescription.TabIndex = 10;
            this.labelTaskDescription.Text = "Task description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.textBox1);
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
            this.groupBox1.Size = new System.Drawing.Size(674, 551);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule new task";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 110);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "hour(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estimated time:";
            // 
            // nudEstimatedTaskTime
            // 
            this.nudEstimatedTaskTime.Location = new System.Drawing.Point(436, 248);
            this.nudEstimatedTaskTime.Name = "nudEstimatedTaskTime";
            this.nudEstimatedTaskTime.Size = new System.Drawing.Size(133, 29);
            this.nudEstimatedTaskTime.TabIndex = 11;
            // 
            // FormScheduleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1255, 651);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}