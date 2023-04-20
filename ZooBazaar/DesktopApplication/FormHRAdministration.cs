using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Employees;

namespace DesktopApplication
{
    public partial class FormHRAdministration : Form
    {
        IEmployeeManagement employeeManagement;        
        public FormHRAdministration(IEmployeeManagement emMng)
        {
            InitializeComponent();
            employeeManagement = emMng;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            cbxNewEmpRole.DataSource = Enum.GetValues(typeof(ROLE));
           // cbxRole.SelectedIndex = -1;
        }

        private void updateEmployeeListview(Employee[] employees)
        {
            lvwEmployees.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.ID.ToString();
                item.Tag = employee;
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.Role.ToString());
                /*if (employee.HoursPerWeek == 40)
                    item.SubItems.Add("Full-time");
                else item.SubItems.Add("Part-time");*/
                lvwEmployees.Items.Add(item);
                item.Tag = employee;
            }
        }

        private void btnDisplayEmployeeInformation_Click(object sender, EventArgs e)
        {
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            var uc = new ucEmployeeInformation(tempEmployee) { Dock = DockStyle.Fill };
            panelAdministrateEmployees.Controls.Add(uc);
        }

        private void btnEditEmployeeContract_Click(object sender, EventArgs e)
        {
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            var uc = new ucContractDetails();
            panelAdministrateEmployees.Controls.Add(uc);
            //Need to add a contract obj for the employees to pass it to the Employee contract edit
            // I guess the employees need a contract obj inserted in their class
            //it doesn't exist atm should be added soon
           // var uc = new ucContractDetails(employeeManagement, employeeContract) { Dock = DockStyle.Fill };
            //panelAdministrateEmployees.Controls.Add(uc);
        }

        private void btnEditEmployeeAdditional_Click(object sender, EventArgs e)
        {
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            var uc = new ucEmergencyContact(tempEmployee) { Dock = DockStyle.Fill };
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
                Employee employee = new Employee(tbxNewEmpFirstName.Text, tbxNewEmpLastName.Text, dtmContractEndDate.Value, tbxPhone.Text, gender, tbxNewEmpAddress.Text, tbxEmployeePassword.Text, tbxEmail.Text, (ROLE)cbxNewEmpRole.SelectedItem);

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
                MessageBox.Show("All the fields must be entered");
            }
        }

        private void btnShowAllEmployees_Click_1(object sender, EventArgs e)
        {
            updateEmployeeListview(employeeManagement.GetEmployees());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            nudWeeklyHours.Value = 40;
            nudWeeklyHours.ReadOnly = true;
        }

        private void rbtnContractTypeParttime_CheckedChanged(object sender, EventArgs e)
        {
            nudWeeklyHours.Value = 0;
            nudWeeklyHours.ReadOnly = false;
        }

        private void cbxNewEmpRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelEmployeeCreation_Click(object sender, EventArgs e)
        {

        }
    }
}
