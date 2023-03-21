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
            //PopupEmployeeDetails form = new PopupEmployeeDetails(employee,employeeManagement);
            //form.ShowDialog();
            //this.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            PopupEmployeeCreation popupEmployeeCreation = new PopupEmployeeCreation();
            popupEmployeeCreation.ShowDialog();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            List<Employee> searchedEmployees = new List<Employee>();

            //We implement when we have a contract class/database
            string contractType = string.Empty;
            /*if (rbtnFullTimeEmployee.Checked)
                contractType = rbtnFullTimeEmployee.Text;
            else if (rbtnPartTimeEmployee.Checked)
                contractType = rbtnPartTimeEmployee.Text;*/

            searchedEmployees = employeeManagement.GetSearchedEmployees(tbxFirstName.Text, tbxLastName.Text, contractType, cbxRole.Text);
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
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            rbtnFullTimeEmployee.Checked = false;
            rbtnPartTimeEmployee.Checked = false;
            cbxRole.SelectedIndex = -1;
        }

        private void btnManageContract_Click(object sender, EventArgs e)
        {

        }
    }
}
