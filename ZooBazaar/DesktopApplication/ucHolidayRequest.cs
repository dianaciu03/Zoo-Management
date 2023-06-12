using BusinessLogic;
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
            //REVIEW WITH AUGUSTINAS HOW TO IMPLEMENT IN DB, idk how the shifts work and I dont wanna break it
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbRole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
