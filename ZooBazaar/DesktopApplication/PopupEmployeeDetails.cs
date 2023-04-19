using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace DesktopApplication
{
    public partial class PopupEmployeeDetails : Form
    {
        public PopupEmployeeDetails(Employee employee, EmployeeManagement employeeManagement)
        {
            InitializeComponent();
            tbxFirstName.Text = employee.FirstName;
            tbxLastName.Text = employee.LastName;
            tbxEmail.Text = employee.Email;
            tbxAddress.Text = employee.Address;
            tbxPhone.Text = employee.Phone;
            if(employee.PersonGender == "Male")
                rbMaleEmployeeDetails.Checked = true;
            else
                rbFemale.Checked = true;
            tbxEmployeePassword.Text = employee.Password;
            //maskedtbxDoBEmployee.Text = employee.BirthDate;
        }

        private void btnConfirmContractChanges_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAnimalCreation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
