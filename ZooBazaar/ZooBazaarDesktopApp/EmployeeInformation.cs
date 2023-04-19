using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLibrary;
using ZooBazaarLogicLibrary.Enums;

namespace ZooBazaarDesktopApp
{
    public partial class EmployeeInformation : Form
    {
        bool newEmployeeCreation;
        Employee employee;
        public EmployeeInformation(Employee em)
        {
            InitializeComponent();
            cbxGender.DataSource = Enum.GetValues(typeof(GENDER));
            cbxRole.DataSource = Enum.GetValues(typeof(ROLE));
            
            if (em != null )
            {
                employee = em;
                newEmployeeCreation = false;
                fillInFields();
            }
            else
            {
                newEmployeeCreation = true;
            }
        }

        private void labelEmployeeContractType_Click(object sender, EventArgs e)
        {

        }

        private void rbtnFullTimeEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnPartTimeEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fillInFields()
        {
            tbxFirstName.Text = employee.FirstName;
            tbxLastName.Text = employee.LastName;
            maskedtbxAddEditEmployee.Text = employee.BirthDate.ToString();
            cbxGender.SelectedItem = employee.PersonGender;
            tbxAddress.Text = employee.Address;
            tbxPhone.Text = employee.Phone;
            switch (employee.GetType().Name)
            {
                case ("Manager"):
                    cbxRole.SelectedIndex = 0;
                    break;
                case ("HRAdministrator"):
                    cbxRole.SelectedIndex = 1;
                    break;
                case ("AnimalAdministrator"):
                    cbxRole.SelectedIndex = 2;
                    break;
                case ("ScheduleMaker"):
                    cbxRole.SelectedIndex = 3;
                    break;
                case ("ResourcePlanner"):
                    cbxRole.SelectedIndex = 4;
                    break;
                
            }
            
            tbxEmail.Text = employee.Email;
            tbxEmployeePassword.Text = employee.Password;
        }

        private void btnConfirmEmployeeCreation_Click(object sender, EventArgs e)
        {
            /*if (!newEmployeeCreation)
            {
                employee.FirstName= tbxFirstName.Text;
                employee.LastName= tbxLastName.Text;
                employee.PersonGender = (GENDER)cbxGender.SelectedItem;
            }*/
        }
    }
}
