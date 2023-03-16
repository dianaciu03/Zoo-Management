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
            maskedtbxDoBEmployee.Text = employee.BirthDate.ToString("MM/dd/yyyy");
           

            if (employee.PersonGender == "Male")
                rbMaleEmployeeDetails.Checked = true;
            else
                rbFemale.Checked = true;
            tbxAddress.Text = employee.Address;
            tbxPhone.Text = employee.Phone;
      

            string tempString = employee.GetType().Name;
            cbxRole.SelectedIndex = -1;
            foreach (ROLE role in Enum.GetValues(typeof(ROLE)))
            {
                if (tempString == role.ToString())
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
            int employeeID;
            if (employeeManagement.GetEmployees().Length > 0)
            {
                employeeID = employeeManagement.GetEmployees().Last().ID + 1;
            }
            else employeeID = 1;

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
                                 employee = new HRAdministrator(employeeID,tbxFirstName.Text,tbxLastName.Text,
                                                    DateTime.ParseExact(maskedtbxDoBEmployee.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture),
                                                    gender,tbxAddress.Text,tbxPhone.Text,tbxEmployeePassword.Text,tbxEmail.Text,40);
                                break;

                            case(ROLE.ResourcePlanner):
                                employee = new ResourcePlanner(employeeID, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text, 40);
                                break;

                            case(ROLE.Manager):
                                employee = new Manager(employeeID, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text, 40);
                                break;
                            
                            case (ROLE.ScheduleMaker):
                                employee = new ScheduleMaker(employeeID, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text, 40);
                                break;

                            case (ROLE.AnimalAdministrator):
                                employee = new AnimalAdministrator(employeeID, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text,40);
                                break;

                            case (ROLE.CareTaker):
                                employee = new CareTaker(employeeID, tbxFirstName.Text, tbxLastName.Text,
                                                    Convert.ToDateTime(maskedtbxDoBEmployee.Text),
                                                    gender, tbxAddress.Text, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text,40);
                                break;

                            default:
                                MessageBox.Show("Account couldn't be created!");
                                break;
                        }
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
                MessageBox.Show("Employee account creation didn't work! Please make sure you complete all of the fields in the correct format!");
                return;
            }
            this.Close();
        }

        private void btnConfirmEditEmployeeDetailsPopup_Click(object sender, EventArgs e)
        {
            string input = maskedtbxDoBEmployee.Text;
            DateTime date;

            // Try to parse the input string as a date
            if (DateTime.TryParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                // If the parsing is successful, format the date and update the text box
                maskedtbxDoBEmployee.Text = date.ToString("MM/dd/yyyy");
                maskedtbxDoBEmployee.SelectionStart = maskedtbxDoBEmployee.Text.Length;
            }

            if (dataValidator.ValidateEmployeeFields(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, tbxPhone.Text,
              tbxEmployeePassword.Text, tbxAddress.Text, maskedtbxDoBEmployee.Text))
            {
                try
                {
                    employee.FirstName = tbxFirstName.Text;
                    employee.LastName = tbxLastName.Text;
                    employee.Email = tbxEmail.Text;
                    employee.Phone = tbxPhone.Text;
                    employee.Password = tbxEmployeePassword.Text;
                    employee.Address = tbxAddress.Text;
                    employee.BirthDate = DateTime.Parse(input);
                    if (rbFemale.Checked) { employee.PersonGender = "Female"; }
                    else if (rbMaleEmployeeDetails.Checked) { employee.PersonGender = "Male"; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("WTF");
            this.Close();
        }
    }
}
