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
using ZooBazaarLogicLibrary;

namespace ZooBazaarDesktopApp
{
    public partial class FormHRAdministration : Form
    {
        EmployeeManagement employeeManagement;
        Employee employee;
        
        public FormHRAdministration(EmployeeManagement emMng)
        {
            InitializeComponent();
            employeeManagement = emMng;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //cbxRole.DataSource = Enum.GetValues(typeof(ROLE));
           // cbxRole.SelectedIndex = -1;

        }


        private void btnEditEmployeeDeta_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have not selected an employee");
                return;
            }
            Debug.WriteLine(lvwEmployees.SelectedItems[0].Tag.GetType());
            employee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            //this.Hide();
            PopupEmployeeDetails form = new PopupEmployeeDetails(employee,employeeManagement);
            form.ShowDialog();
            //this.Show();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            List<Employee> searchedEmployees = new List<Employee>();
           // if(string.IsNullOrEmpty(tbxFirstName.Text) && string.IsNullOrEmpty(tbxLastName.Text) &&
               // (rbtnFullTimeEmployee.Checked != true) && (rbtnPartTimeEmployee.Checked != true) &&
                //(cbxRole.SelectedIndex == -1))
            {
                MessageBox.Show("Please choose at least one field to search by!");
                return;
            }

            //We implement when we have a contract class/database
            string contractType = string.Empty;
            /*if (rbtnFullTimeEmployee.Checked)
                contractType = rbtnFullTimeEmployee.Text;
            else if (rbtnPartTimeEmployee.Checked)
                contractType = rbtnPartTimeEmployee.Text;*/

           // searchedEmployees = employeeManagement.GetSearchedEmployees(tbxFirstName.Text, tbxLastName.Text, contractType, cbxRole.Text);
            updateEmployeeListview(searchedEmployees.ToArray());
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
                item.SubItems.Add(employee.GetRole());
                if (employee.HoursPerWeek == 40)
                    item.SubItems.Add("Full-time");
                else item.SubItems.Add("Part-time");
                lvwEmployees.Items.Add(item);
                item.Tag = employee;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
           // tbxFirstName.Text = string.Empty;
            //tbxLastName.Text = string.Empty;
           // rbtnFullTimeEmployee.Checked = false;
            //rbtnPartTimeEmployee.Checked = false;
            //cbxRole.SelectedIndex = -1;
        }

        private void btnManageContract_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            updateEmployeeListview(employeeManagement.GetEmployees());
        }

        private void btnDisplayEmployeeInformation_Click(object sender, EventArgs e)
        {
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
            var uc = new ucEmployeeInformation(employeeManagement,tempEmployee) { Dock = DockStyle.Fill };
            panelAdministrateEmployees.Controls.Add(uc);
        }

        private void btnEditEmployeeContract_Click(object sender, EventArgs e)
        {
            panelAdministrateEmployees.Controls.Clear();
            Employee tempEmployee = (Employee)lvwEmployees.SelectedItems[0].Tag;
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
            var uc = new ucEmergencyContact(employeeManagement, tempEmployee) { Dock = DockStyle.Fill };
            panelAdministrateEmployees.Controls.Add(uc);
        }

        private void btnConfirmEmployeeCreation_Click(object sender, EventArgs e)
        {
            string gender;
            if (rbAddFemale.Checked == true) gender = "Female";
            else if (rbAddMale.Checked == true) gender = "Male";
            else return;
            Employee employee;
            switch (cbxNewEmpRole.SelectedItem.ToString())
            {
                case nameof(HRAdministrator):
                    employee = new HRAdministrator(tbxNewEmpFirstName.Text, tbxNewEmpLastName.Text, dateTimePicker1.Value, gender, tbxPhone.Text, tbxNewEmpAddress.Text, tbxEmployeePassword.Text, tbxEmail.Text);
                    break;
                case nameof(AnimalAdministrator):
                    employee = new AnimalAdministrator(tbxNewEmpFirstName.Text, tbxNewEmpLastName.Text, dateTimePicker1.Value, gender, tbxPhone.Text, tbxNewEmpAddress.Text, tbxEmployeePassword.Text, tbxEmail.Text);
                    employeeManagement.AddNewEmployee(employee);
                    break;
                case nameof(ScheduleMaker):
                    employee = new ScheduleMaker(tbxNewEmpFirstName.Text, tbxNewEmpLastName.Text, dateTimePicker1.Value, gender, tbxPhone.Text, tbxNewEmpAddress.Text, tbxEmployeePassword.Text, tbxEmail.Text);
                    employeeManagement.AddNewEmployee(employee);
                    break;

            }
        }

        private void ucSearchFeatureEmployees1_Load(object sender, EventArgs e)
        {

        }
    }
}
