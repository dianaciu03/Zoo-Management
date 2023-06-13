using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class ucHolidayRequest : UserControl
    {
        Employee employee;
        IEmployeeManagement employeeManagement = new EmployeeManagement(new EmployeeRepository());
        public ucHolidayRequest(Employee selectedEmployee)
        {
            //IDK HOW TO FIX VISUAL BUG FOR THIS UC WHEN IT'S DISPLAYED I LITERALLY COPY PASTED ALL OF IT WTFFFFFFF
            InitializeComponent();
            employee = selectedEmployee;
            tbFirstName.Text = employee.FirstName;
            tbLastName.Text = employee.LastName;
            tbRole.Text = employee.Role.ToString();
        }

        private void btnCancelContractEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveHoliday_Click(object sender, EventArgs e)
        {
            if(dateTimePickerStartDate.Value > dateTimePickerEndDate.Value)
            {
                MessageBox.Show("Please make sure the start date is before the end date!");
                return;
            }
            try
            {
                employeeManagement.AddHoliday(employee.ID, dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Could not schedule holiday time!");
                return;
            }
            
            
        }

    }
}
