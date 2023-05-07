namespace DesktopApplication
{
    partial class ucContractDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxContractDetails = new System.Windows.Forms.GroupBox();
            this.btnCancelContractEdit = new System.Windows.Forms.Button();
            this.btnSaveContractEdit = new System.Windows.Forms.Button();
            this.checkBoxContractNotMentionedContractEdit = new System.Windows.Forms.CheckBox();
            this.labelEurosPerMonth = new System.Windows.Forms.Label();
            this.tbSalaryContractEdit = new System.Windows.Forms.TextBox();
            this.labelSalaryContract = new System.Windows.Forms.Label();
            this.dateTimePickerEndDateContractEdit = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDateEmployeeContractEdit = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.nudWeeklyHoursContractEdit = new System.Windows.Forms.NumericUpDown();
            this.labelWeeklyHours = new System.Windows.Forms.Label();
            this.rbFullTimeContractEdit = new System.Windows.Forms.RadioButton();
            this.rbPartTimeContractEdit = new System.Windows.Forms.RadioButton();
            this.labelContractType = new System.Windows.Forms.Label();
            this.groupBoxContractDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyHoursContractEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxContractDetails
            // 
            this.groupBoxContractDetails.Controls.Add(this.btnCancelContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.btnSaveContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.checkBoxContractNotMentionedContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.labelEurosPerMonth);
            this.groupBoxContractDetails.Controls.Add(this.tbSalaryContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.labelSalaryContract);
            this.groupBoxContractDetails.Controls.Add(this.dateTimePickerEndDateContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.labelEndDate);
            this.groupBoxContractDetails.Controls.Add(this.dateTimePickerStartDateEmployeeContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.labelStartDate);
            this.groupBoxContractDetails.Controls.Add(this.nudWeeklyHoursContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.labelWeeklyHours);
            this.groupBoxContractDetails.Controls.Add(this.rbFullTimeContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.rbPartTimeContractEdit);
            this.groupBoxContractDetails.Controls.Add(this.labelContractType);
            this.groupBoxContractDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxContractDetails.Location = new System.Drawing.Point(8, 6);
            this.groupBoxContractDetails.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxContractDetails.Name = "groupBoxContractDetails";
            this.groupBoxContractDetails.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.groupBoxContractDetails.Size = new System.Drawing.Size(550, 498);
            this.groupBoxContractDetails.TabIndex = 36;
            this.groupBoxContractDetails.TabStop = false;
            this.groupBoxContractDetails.Text = "Contract details";
            // 
            // btnCancelContractEdit
            // 
            this.btnCancelContractEdit.Location = new System.Drawing.Point(45, 404);
            this.btnCancelContractEdit.Name = "btnCancelContractEdit";
            this.btnCancelContractEdit.Size = new System.Drawing.Size(159, 42);
            this.btnCancelContractEdit.TabIndex = 52;
            this.btnCancelContractEdit.Text = "Cancel";
            this.btnCancelContractEdit.UseVisualStyleBackColor = true;
            this.btnCancelContractEdit.Click += new System.EventHandler(this.btnCancelContractEdit_Click);
            // 
            // btnSaveContractEdit
            // 
            this.btnSaveContractEdit.Location = new System.Drawing.Point(318, 404);
            this.btnSaveContractEdit.Name = "btnSaveContractEdit";
            this.btnSaveContractEdit.Size = new System.Drawing.Size(159, 42);
            this.btnSaveContractEdit.TabIndex = 51;
            this.btnSaveContractEdit.Text = "Save changes";
            this.btnSaveContractEdit.UseVisualStyleBackColor = true;
            this.btnSaveContractEdit.Click += new System.EventHandler(this.btnSaveContractEdit_Click);
            // 
            // checkBoxContractNotMentionedContractEdit
            // 
            this.checkBoxContractNotMentionedContractEdit.AutoSize = true;
            this.checkBoxContractNotMentionedContractEdit.Location = new System.Drawing.Point(322, 211);
            this.checkBoxContractNotMentionedContractEdit.Name = "checkBoxContractNotMentionedContractEdit";
            this.checkBoxContractNotMentionedContractEdit.Size = new System.Drawing.Size(169, 30);
            this.checkBoxContractNotMentionedContractEdit.TabIndex = 48;
            this.checkBoxContractNotMentionedContractEdit.Text = "not mentioned";
            this.checkBoxContractNotMentionedContractEdit.UseVisualStyleBackColor = true;
            this.checkBoxContractNotMentionedContractEdit.CheckedChanged += new System.EventHandler(this.checkBoxContractNotMentionedContractEdit_CheckedChanged);
            // 
            // labelEurosPerMonth
            // 
            this.labelEurosPerMonth.AutoSize = true;
            this.labelEurosPerMonth.Location = new System.Drawing.Point(353, 318);
            this.labelEurosPerMonth.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEurosPerMonth.Name = "labelEurosPerMonth";
            this.labelEurosPerMonth.Size = new System.Drawing.Size(170, 26);
            this.labelEurosPerMonth.TabIndex = 47;
            this.labelEurosPerMonth.Text = "euros per month";
            // 
            // tbSalaryContractEdit
            // 
            this.tbSalaryContractEdit.Location = new System.Drawing.Point(164, 318);
            this.tbSalaryContractEdit.Name = "tbSalaryContractEdit";
            this.tbSalaryContractEdit.Size = new System.Drawing.Size(165, 32);
            this.tbSalaryContractEdit.TabIndex = 46;
            // 
            // labelSalaryContract
            // 
            this.labelSalaryContract.AutoSize = true;
            this.labelSalaryContract.Location = new System.Drawing.Point(70, 318);
            this.labelSalaryContract.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSalaryContract.Name = "labelSalaryContract";
            this.labelSalaryContract.Size = new System.Drawing.Size(80, 26);
            this.labelSalaryContract.TabIndex = 45;
            this.labelSalaryContract.Text = "Salary:";
            // 
            // dateTimePickerEndDateContractEdit
            // 
            this.dateTimePickerEndDateContractEdit.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEndDateContractEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEndDateContractEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDateContractEdit.Location = new System.Drawing.Point(164, 170);
            this.dateTimePickerEndDateContractEdit.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerEndDateContractEdit.Name = "dateTimePickerEndDateContractEdit";
            this.dateTimePickerEndDateContractEdit.Size = new System.Drawing.Size(165, 32);
            this.dateTimePickerEndDateContractEdit.TabIndex = 30;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(45, 170);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(105, 26);
            this.labelEndDate.TabIndex = 31;
            this.labelEndDate.Text = "End date:";
            // 
            // dateTimePickerStartDateEmployeeContractEdit
            // 
            this.dateTimePickerStartDateEmployeeContractEdit.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartDateEmployeeContractEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartDateEmployeeContractEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDateEmployeeContractEdit.Location = new System.Drawing.Point(164, 104);
            this.dateTimePickerStartDateEmployeeContractEdit.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerStartDateEmployeeContractEdit.Name = "dateTimePickerStartDateEmployeeContractEdit";
            this.dateTimePickerStartDateEmployeeContractEdit.Size = new System.Drawing.Size(165, 32);
            this.dateTimePickerStartDateEmployeeContractEdit.TabIndex = 28;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(38, 110);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(112, 26);
            this.labelStartDate.TabIndex = 29;
            this.labelStartDate.Text = "Start date:";
            // 
            // nudWeeklyHoursContractEdit
            // 
            this.nudWeeklyHoursContractEdit.Location = new System.Drawing.Point(164, 265);
            this.nudWeeklyHoursContractEdit.Margin = new System.Windows.Forms.Padding(6);
            this.nudWeeklyHoursContractEdit.Name = "nudWeeklyHoursContractEdit";
            this.nudWeeklyHoursContractEdit.Size = new System.Drawing.Size(165, 32);
            this.nudWeeklyHoursContractEdit.TabIndex = 25;
            // 
            // labelWeeklyHours
            // 
            this.labelWeeklyHours.AutoSize = true;
            this.labelWeeklyHours.Location = new System.Drawing.Point(0, 267);
            this.labelWeeklyHours.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelWeeklyHours.Name = "labelWeeklyHours";
            this.labelWeeklyHours.Size = new System.Drawing.Size(150, 26);
            this.labelWeeklyHours.TabIndex = 24;
            this.labelWeeklyHours.Text = "Weekly hours:";
            // 
            // rbFullTimeContractEdit
            // 
            this.rbFullTimeContractEdit.AutoSize = true;
            this.rbFullTimeContractEdit.Location = new System.Drawing.Point(184, 53);
            this.rbFullTimeContractEdit.Margin = new System.Windows.Forms.Padding(6);
            this.rbFullTimeContractEdit.Name = "rbFullTimeContractEdit";
            this.rbFullTimeContractEdit.Size = new System.Drawing.Size(114, 30);
            this.rbFullTimeContractEdit.TabIndex = 22;
            this.rbFullTimeContractEdit.TabStop = true;
            this.rbFullTimeContractEdit.Text = "Full-time";
            this.rbFullTimeContractEdit.UseVisualStyleBackColor = true;
            this.rbFullTimeContractEdit.CheckedChanged += new System.EventHandler(this.rbFullTimeContractEdit_CheckedChanged);
            // 
            // rbPartTimeContractEdit
            // 
            this.rbPartTimeContractEdit.AutoSize = true;
            this.rbPartTimeContractEdit.Location = new System.Drawing.Point(372, 53);
            this.rbPartTimeContractEdit.Margin = new System.Windows.Forms.Padding(6);
            this.rbPartTimeContractEdit.Name = "rbPartTimeContractEdit";
            this.rbPartTimeContractEdit.Size = new System.Drawing.Size(119, 30);
            this.rbPartTimeContractEdit.TabIndex = 21;
            this.rbPartTimeContractEdit.TabStop = true;
            this.rbPartTimeContractEdit.Text = "Part-time";
            this.rbPartTimeContractEdit.UseVisualStyleBackColor = true;
            // 
            // labelContractType
            // 
            this.labelContractType.AutoSize = true;
            this.labelContractType.Location = new System.Drawing.Point(3, 53);
            this.labelContractType.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelContractType.Name = "labelContractType";
            this.labelContractType.Size = new System.Drawing.Size(147, 26);
            this.labelContractType.TabIndex = 23;
            this.labelContractType.Text = "Contract type:";
            // 
            // ucContractDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBoxContractDetails);
            this.Name = "ucContractDetails";
            this.Size = new System.Drawing.Size(569, 510);
            this.Load += new System.EventHandler(this.ucContractDetails_Load);
            this.groupBoxContractDetails.ResumeLayout(false);
            this.groupBoxContractDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyHoursContractEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContractDetails;
        private System.Windows.Forms.CheckBox checkBoxContractNotMentionedContractEdit;
        private System.Windows.Forms.Label labelEurosPerMonth;
        private System.Windows.Forms.TextBox tbSalaryContractEdit;
        private System.Windows.Forms.Label labelSalaryContract;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDateContractEdit;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateEmployeeContractEdit;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.NumericUpDown nudWeeklyHoursContractEdit;
        private System.Windows.Forms.Label labelWeeklyHours;
        private System.Windows.Forms.RadioButton rbFullTimeContractEdit;
        private System.Windows.Forms.RadioButton rbPartTimeContractEdit;
        private System.Windows.Forms.Label labelContractType;
        private System.Windows.Forms.Button btnSaveContractEdit;
        private System.Windows.Forms.Button btnCancelContractEdit;
    }
}
