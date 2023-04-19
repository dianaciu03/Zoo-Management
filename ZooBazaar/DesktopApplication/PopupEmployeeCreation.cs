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
using BusinessLogic;

namespace DesktopApplication
{
    public partial class PopupEmployeeCreation : Form
    {
        /*Employee employee;
        FormDataValidator dataValidator= new FormDataValidator();
        EmployeeManagement employeeManagement;

        public PopupEmployeeCreation(EmployeeManagement employeeManagement)
        {
            
            InitializeComponent();
            this.employeeManagement = employeeManagement;
            cbxRole.DataSource = Enum.GetValues(typeof(ROLE));
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
                                                    gender, tbxPhone.Text, tbxEmployeePassword.Text, tbxEmail.Text,40);
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

        private void btnCancelEmployeeCreation_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    }
}
