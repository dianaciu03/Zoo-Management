using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLibrary;

namespace ZooBazaarDesktopApp
{
    public partial class PopupEmployeeDetails : Form
    {
        bool newEmployeeCreation;
        Employee employee;
        FormDataValidator dataValidator= new FormDataValidator();
        EmployeeManagement employeeManagement;
        public PopupEmployeeDetails(Employee em,EmployeeManagement employeeManagement)
        {
            InitializeComponent();
            cbxRole.DataSource = Enum.GetValues(typeof(ROLE));
            this.employeeManagement= employeeManagement;
            //Because in the HRAdministrationForm its mandatory to pass an employee obj
            //If the employee that we passed to this form is empty, we need to create an account(create employee button)
            //create account button is on , edit details button is disabled
            //if the employee is not null, we fill in his details and we save the changes or create new account if they change departments 
            if (em != null )
            {
                
                employee = em;
                btnConfirmEmployeeCreation.Enabled = false;
                btnConfirmEmployeeCreation.Visible = false;
                newEmployeeCreation = false;
                fillInFields();
            }
            else
            {
                btnConfirmEditEmployeeDetailsPopup.Enabled = false;
                btnConfirmEditEmployeeDetailsPopup.Visible = false;
                
                newEmployeeCreation = true;
            }
        }

        private void fillInFields()
        {
            tbxFirstName.Text = employee.FirstName;
            tbxLastName.Text = employee.LastName;
            maskedtbxDoBEmployee.Text = employee.BirthDate.ToString();
            if(employee.PersonGender == "Male")
                rbMaleEmployeeDetails.Checked = true;
            else
                rbFemale.Checked = true;
            tbxAddress.Text = employee.Address;
            tbxPhone.Text = employee.Phone;
            //employee.GetType() returns a ZooBazaar.Role object,
            //i convert it to a string, split it after '.'
            //i set the default value to the first option in the cbx
            //i compare the strings of the Role enum with the string and if they match
            //I assign the selected cbx to the Role that matches and break the foreach
            //UR WELCOME ALSO COMMENT UR CODE FFS
            string[] tempString = employee.GetType().ToString().Split('.');
            cbxRole.SelectedIndex = -1;
            foreach (ROLE role in Enum.GetValues(typeof(ROLE)))
            {
                if (tempString[1] == role.ToString())
                {
                    cbxRole.SelectedItem = role;
                    break;
                }
            }
            tbxEmail.Text = employee.Email;
            tbxEmployeePassword.Text = employee.Password;
        }

        private void btnConfirmEmployeeCreation_Click(object sender, EventArgs e)
        {
            //this validates if the data is correct data type and or empty, check FormDataValidator
            if(dataValidator.ValidateEmployeeFields(tbxFirstName.Text,tbxLastName.Text,tbxEmail.Text,tbxPhone.Text,
              tbxEmployeePassword.Text,tbxAddress.Text, maskedtbxDoBEmployee.Text))
                try
                {
                    string gender;
                    if (rbFemale.Checked) 
                        { gender = "Female"; }
                    else
                        gender = "Male";
                    //Employee tempEmployee;

                        switch (cbxRole.SelectedItem)
                        {
  
                            case(ROLE.HRAdministrator):
                                 employee = new HRAdministrator(1,tbxFirstName.Text,tbxLastName.Text,
                                                    DateTime.ParseExact(maskedtbxDoBEmployee.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture),
                                                    gender,tbxAddress.Text,tbxPhone.Text,tbxEmployeePassword.Text,tbxEmail.Text,40);
                                break;

                            case(ROLE.ResourcePlanner):
                                employee = new ResourcePlanner(1, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text, 40);
                                break;

                            case(ROLE.Manager):
                                employee = new Manager(1, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text, 40);
                                break;
                            
                            case (ROLE.ScheduleMaker):
                                employee = new ScheduleMaker(1, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text, 40);
                                break;

                            case (ROLE.AnimalAdministrator):
                                employee = new AnimalAdministrator(1, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text,40);
                                break;

                            case (ROLE.CareTaker):
                                employee = new CareTaker(1, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text,40);
                                break;

                            default:
                                MessageBox.Show("Account couldn't be created!");
                                break;
                        }
                    //this may not work, or the lvw is not working properly
                    employeeManagement.AddEmployee(employee);
                    MessageBox.Show("Account creation was succesfull!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            else
            {
                MessageBox.Show("Employee account creation didn't work! Please make sure you complete all of the fields!");
                return;
            }
        }

        private void btnConfirmEditEmployeeDetailsPopup_Click(object sender, EventArgs e)
        {

        }
    }
}
