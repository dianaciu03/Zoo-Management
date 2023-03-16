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
            updateEmployees();
        }

        private void updateEmployees()
        {
            lvwEmployees.Items.Clear();
            foreach (var employee in employeeManagement.GetEmployees())
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.ID.ToString();
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.GetType().Name);
                if (employee.HoursPerWeek == 40)
                    item.SubItems.Add("Full-time");
                else item.SubItems.Add("Part-time");
                    lvwEmployees.Items.Add(item);
                item.Tag= employee;
            }
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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = null;
            PopupEmployeeDetails popupEmployeeDetails = new PopupEmployeeDetails(employee,employeeManagement);
            popupEmployeeDetails.ShowDialog();
            updateEmployees();
        }
        //needs fixing, this updates the list but doesnt work
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEmployees();
        }
    }
}
