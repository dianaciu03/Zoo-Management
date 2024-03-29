﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Employees;
using DataAccess.EmployeeInterfaces;
using DataAccess.EmployeeRepositories;

namespace DesktopApplication
{
    public partial class FormHRAdministration : Form
    {
        IEmployeeManagement employeeManagement;
        IContractManagement contractManagement = new ContractManagement(new ContractRepository());
        IEmergencyContactManagement emergencyContactManagement = new EmergencyContactManagement(new EmergencyContractRepository());
        public FormHRAdministration(IEmployeeManagement emMng)
        {
            InitializeComponent();
            employeeManagement = emMng;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            cbxRoleSearchFeature.DataSource = Enum.GetValues(typeof(ROLE));
            cbxRoleSearchFeature.SelectedIndex = -1;
            cbRoleEmployeeHistory.DataSource = Enum.GetValues(typeof(ROLE));
            cbRoleEmployeeHistory.SelectedIndex = -1;
            cbxNewEmpRole.DataSource = Enum.GetValues(typeof(ROLE));
            cbxNewEmpRole.SelectedIndex = -1;
        }

        private void updateEmployeeListview(Employee[] employees, int[] hoursWorked)
        {
            lvwEmployees.Items.Clear();
            int index = 0;
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.ID.ToString();
                item.Tag = employee;
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.Role.ToString());
                if (hoursWorked[index] == 40)
                    item.SubItems.Add("Full-time");
                else 
                    item.SubItems.Add("Part-time");
                lvwEmployees.Items.Add(item);
                item.Tag = employee;
                index++;
            }
        }

        private void updateEmployeeHistoryListview(Employee[] employees, int[] hoursWorked)
        {
            listViewEmployeeHistoryTab.Items.Clear();
            int index = 0;
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.ID.ToString();
                item.Tag = employee;
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.Role.ToString());
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.Phone);
                item.SubItems.Add(employee.Address);
                item.SubItems.Add(employee.BirthDate.ToShortDateString());
                if (hoursWorked[index] == 40)
                    item.SubItems.Add("Full-time");
                else
                    item.SubItems.Add("Part-time");
                listViewEmployeeHistoryTab.Items.Add(item);
                index++;
            }
        }

        private void btnDisplayEmployeeInformation_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedItems.Count > 0)
            {
                panelAdministrateEmployees.Controls.Clear();
                Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
                var uc = new ucEmployeeInformation(tempEmployee,employeeManagement) { Dock = DockStyle.Fill };
                panelAdministrateEmployees.Controls.Add(uc);
            }
            else
            {
                MessageBox.Show("Please select an employee!");
                return;
            }
        }

        private void btnEditEmployeeContract_Click(object sender, EventArgs e)
        {
            if(lvwEmployees.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select an employee!");
                return;
            }
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            EmployeeContract tempContract = employeeManagement.GetContractById(tempEmployee.ID);
            var uc = new ucContractDetails(tempContract,contractManagement,tempEmployee.ID) { Dock = DockStyle.Fill };
            panelAdministrateEmployees.Controls.Add(uc);
        }

        private void btnEditEmployeeAdditional_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select an employee!");
                return;
            }
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            var uc = new ucEmergencyContact(tempEmployee,emergencyContactManagement) { Dock = DockStyle.Fill };
            panelAdministrateEmployees.Controls.Add(uc);
        }

        private void btnConfirmEmployeeCreation_Click(object sender, EventArgs e)
        {
            try
            {
                string gender;
                if (rbAddFemale.Checked == true) gender = "Female";
                else if (rbAddMale.Checked == true) gender = "Male";
                else return;
                string input = maskedtbxDoBEmployee.Text;
                DateTime date;

                // Try to parse the input string as a date
                if (DateTime.TryParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    if(date < DateTime.Now)
                    {
                        // If the parsing is successful, format the date and update the text box
                        maskedtbxDoBEmployee.Text = date.ToString("MM/dd/yyyy");
                        maskedtbxDoBEmployee.SelectionStart = maskedtbxDoBEmployee.Text.Length;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid birthday!");
                        return;
                    }
                }
                if (!FormDataValidator.IsValidEmail(tbxEmail.Text))
                {
                    MessageBox.Show("Please enter a valid email!");
                    return;
                }
                Employee employee = new Employee(tbxNewEmpFirstName.Text, tbxNewEmpLastName.Text, date, gender, tbxPhone.Text, tbxNewEmpAddress.Text, tbxEmployeePassword.Text, tbxEmail.Text, (ROLE)cbxNewEmpRole.SelectedItem);

                DateTime? contractEndDate;
                if (cbNotMentioned.Checked == true)
                    contractEndDate = null;
                else contractEndDate = dtmContractEndDate.Value;

                EmployeeContract contract = new EmployeeContract(dtmContractStartDate.Value, contractEndDate, (int)nudWeeklyHours.Value, Convert.ToDouble(tbxEmpSalary.Text));
                EmergencyContact contact = new EmergencyContact(tbxContactFirstName.Text, tbxContactLastName.Text, tbxContactPhone.Text, tbxContactRelationship.Text);
                employeeManagement.AddNewEmployee(employee, contract, contact);
                tabPageAllEmployees.Show();
            }
            catch
            {
                MessageBox.Show("All the fields must be completed!");
            }
        }

        private void cbNotMentioned_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotMentioned.Checked == true)
            {
                dtmContractEndDate.Enabled = false;
            }
            else
                dtmContractStartDate.Enabled = true;
        }

        private void rbtnContractTypeFulltime_CheckedChanged(object sender, EventArgs e)
        {
            nudWeeklyHours.Maximum = 40;
            nudWeeklyHours.Value = 40;
            nudWeeklyHours.Enabled = false;
        }

        private void rbtnContractTypeParttime_CheckedChanged(object sender, EventArgs e)
        {
            nudWeeklyHours.Value = 0;
            nudWeeklyHours.Enabled = true;
            nudWeeklyHours.Maximum = 39;
        }


        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbxFirstNameSearchFeature.Text = string.Empty;
            tbxLastNameEmployeeSearch.Text = string.Empty;
            rbtnFullTimeEmployeeSearchFeature.Checked = false;
            rbtnPartTimeEmployeeSearchFeature.Checked = false;
            cbxRoleSearchFeature.SelectedIndex = -1;
        }

        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            Employee[] employees = employeeManagement.GetEmployees(out int[] ints);
            updateEmployeeListview(employees, ints);
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxFirstNameSearchFeature.Text) && string.IsNullOrEmpty(tbxLastNameEmployeeSearch.Text)&&
               cbxRoleSearchFeature.SelectedIndex==-1 && rbtnFullTimeEmployeeSearchFeature.Checked==false 
               && rbtnPartTimeEmployeeSearchFeature.Checked == false)
            {
                MessageBox.Show("Please select at least one field to search by!");
                return;
            }
            int weeklyHours;
            if (rbtnPartTimeEmployeeSearchFeature.Checked==true)
            { 
                weeklyHours = 39; 
            }
            else if (rbtnFullTimeEmployeeSearchFeature.Checked == true)
            {
                weeklyHours = 40;
            }
            else
            {
                weeklyHours = 41;
            }
            List<Employee> employees = employeeManagement.SearchForEmployee(tbxFirstNameSearchFeature.Text, tbxLastNameEmployeeSearch.Text, weeklyHours, cbxRoleSearchFeature.Text, out int[] ints);
            updateEmployeeListview(employees.ToArray(), ints);
        }

        private void btnClearFieldsEmployeeHistoryTab_Click(object sender, EventArgs e)
        {
            tbxFirstNameEmployeeHistoryTab.Text = string.Empty;
            tbxLastNameEmployeeHistoryTab.Text = string.Empty;
            rbFullTimeEmployeeHistoryTab.Checked = false;
            rbPartTimeEmployeeHistoryTab.Checked = false;
            cbRoleEmployeeHistory.SelectedIndex = -1;
        }

        private void btnDisplayEmployeeHistoryTab_Click(object sender, EventArgs e)
        {
            Employee[] employees = employeeManagement.GetEmployees(out int[] ints);
            updateEmployeeHistoryListview(employees, ints);
        }

        private void btnSearchEmployeeHistoryTab_Click(object sender, EventArgs e)
        {
            //dont touch it!!! it works if you want info ask me lolll
            if (string.IsNullOrEmpty(tbxFirstNameEmployeeHistoryTab.Text) && string.IsNullOrEmpty(tbxLastNameEmployeeHistoryTab.Text) &&
                cbRoleEmployeeHistory.SelectedIndex == -1 && rbFullTimeEmployeeHistoryTab.Checked == false
               && rbPartTimeEmployeeHistoryTab.Checked == false)
            {
                MessageBox.Show("Please select at least one field to search by!");
                return;
            }
            int weeklyHours;
            if (rbPartTimeEmployeeHistoryTab.Checked == true)
            {
                weeklyHours = 39;
            }
            else if (rbFullTimeEmployeeHistoryTab.Checked == true)
            {
                weeklyHours = 40;
            }
            else
            {
                weeklyHours = 41;
            }
            List<Employee> employees = employeeManagement.SearchForEmployee(tbxFirstNameEmployeeHistoryTab.Text, tbxLastNameEmployeeHistoryTab.Text, weeklyHours, cbRoleEmployeeHistory.Text, out int[] ints);
            updateEmployeeHistoryListview(employees.ToArray(), ints);
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            //dont ask it works,fml
            if(listViewEmployeeHistoryTab.Items.Count == 0)
            {
                MessageBox.Show("Please search the employees you want to filter first!");
                return;
            }
            Dictionary<Employee,int> unsortedEmployees= new Dictionary<Employee,int>();
            foreach(ListViewItem item in listViewEmployeeHistoryTab.Items)
            {
                if (item.SubItems[8].Text == "Full-time")
                {
                    unsortedEmployees.Add(item.Tag as Employee, 40);
                }
                else
                {
                    unsortedEmployees.Add(item.Tag as Employee, 20);
                }
                
            }
            //i would do a switch dont get me wrong but it doesn't work like that I dont think
            if(rbtnSortAlphabeticalAsc.Checked)
            {
                
                var sortedEmployees = from entry in unsortedEmployees orderby entry.Key.LastName ascending select (entry.Key,entry.Value);
                Dictionary<Employee, int> employees =  sortedEmployees.ToDictionary(pair => pair.Key, pair => pair.Value);
                Employee[] listOfSortedEmployees = employees.Keys.ToArray();
                updateEmployeeHistoryListview(listOfSortedEmployees,employees.Values.ToArray());
                return;
            }
            if(rbtnSortAlphabeticalDesc.Checked)
            {
                var sortedEmployees = from entry in unsortedEmployees orderby entry.Key.LastName descending select (entry.Key, entry.Value);
                Dictionary<Employee, int> employees = sortedEmployees.ToDictionary(pair => pair.Key, pair => pair.Value);
                Employee[] listOfSortedEmployees = employees.Keys.ToArray();
                updateEmployeeHistoryListview(listOfSortedEmployees, employees.Values.ToArray());
                return;
            }
            if(rbtnSortByRole.Checked)
            {
                var sortedEmployees = from entry in unsortedEmployees orderby entry.Key.Role descending select (entry.Key, entry.Value);
                Dictionary<Employee, int> employees = sortedEmployees.ToDictionary(pair => pair.Key, pair => pair.Value);
                Employee[] listOfSortedEmployees = employees.Keys.ToArray();
                updateEmployeeHistoryListview(listOfSortedEmployees, employees.Values.ToArray());
                return;
            }
            if(rbtnSortByContract.Checked)
            {
                var sortedEmployees = from entry in unsortedEmployees orderby entry.Value descending select (entry.Key, entry.Value);
                Dictionary<Employee, int> employees = sortedEmployees.ToDictionary(pair => pair.Key, pair => pair.Value);
                Employee[] listOfSortedEmployees = employees.Keys.ToArray();
                updateEmployeeHistoryListview(listOfSortedEmployees, employees.Values.ToArray());
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select an employee!");
                return;
            }
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            var uc = new ucHolidayRequest(tempEmployee) { Dock = DockStyle.Fill };
            panelAdministrateEmployees.Controls.Add(uc);
        }

        private void bttnShowEmployeesOnVacation_Click(object sender, EventArgs e)
        {
            lvHolidays.Items.Clear();
            List<Employee>  employees= new List<Employee>();
            List<DateTime> startDates = new List<DateTime>();
            List<DateTime> endDates = new List<DateTime>();
            (employees, startDates, endDates) = employeeManagement.GetAllEmployeesThatHaveHoliday();
            int index = 0;
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.ID.ToString();
                item.Tag = employee;
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.Role.ToString());
                item.SubItems.Add(startDates[index].ToShortDateString());
                item.SubItems.Add(endDates[index].ToShortDateString());
                lvHolidays.Items.Add(item);
                index++;
            }
        }

        private void bttnDeleteHoliday_Click(object sender, EventArgs e)
        {
            if(lvHolidays.SelectedItems.Count == 0)    
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            Employee tempEmployee = lvHolidays.SelectedItems[0].Tag as Employee;
            DateTime startDate = DateTime.Parse(lvHolidays.SelectedItems[0].SubItems[4].Text);

            if (employeeManagement.DeleteHoliday(tempEmployee.ID, startDate))
            {
                MessageBox.Show("Holiday deleted!");
            }
            else
            {
                MessageBox.Show("Could not delete holiday!");
            }
        }
    }
}
