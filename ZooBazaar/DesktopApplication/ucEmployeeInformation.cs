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
    public partial class ucEmployeeInformation : UserControl
    {
        Employee selectedEmployee;
        IEmployeeManagement _employeeManagement;
        public ucEmployeeInformation(Employee selectedEmployee, IEmployeeManagement emmg)
        {
            InitializeComponent();
            this.selectedEmployee = selectedEmployee;
            _employeeManagement= emmg;
        }

        private void ucEmployeeInformation_Load(object sender, EventArgs e)
        {
            tbFirstNameEmployeeEdit.Text = selectedEmployee.FirstName;
            tbLastNameEmployeeEdit.Text = selectedEmployee.LastName;
            if(selectedEmployee.PersonGender == "Male")
                rbMaleEmployeeEdit.Checked = true;
            else
                rbFemaleEmployeeEdit.Checked = true;
            cbRoleEmployeeEdit.DataSource = Enum.GetValues(typeof(ROLE));
            cbRoleEmployeeEdit.SelectedItem = selectedEmployee;
            tbPhoneNumberEmployeeEdit.Text = selectedEmployee.Phone;
            tbxEmpAddressEdit.Text = selectedEmployee.Address;
            tbPasswordEmployeeEdit.Text = selectedEmployee.Password;
            tbEmailEmployeeEdit.Text = selectedEmployee.Email;
            maskedTbBirthdayEmployeeEdit.Text = selectedEmployee.BirthDate.ToString("MM/dd/yyyy");

        }

        private void btnCancelEmployeeEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveEmployeeEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstNameEmployeeEdit.Text) || string.IsNullOrEmpty(tbLastNameEmployeeEdit.Text) || string.IsNullOrEmpty(tbPhoneNumberEmployeeEdit.Text) || string.IsNullOrEmpty(tbxEmpAddressEdit.Text) ||
                string.IsNullOrEmpty(tbPasswordEmployeeEdit.Text) || string.IsNullOrEmpty(tbEmailEmployeeEdit.Text) || string.IsNullOrEmpty(maskedTbBirthdayEmployeeEdit.Text))
            {
                MessageBox.Show("Please complete all of the fields before attempting to save changes!");
                return;
            }
            try
            {
                Employee tempEmployee = selectedEmployee;
                tempEmployee.FirstName = tbFirstNameEmployeeEdit.Text;
                tempEmployee.LastName = tbLastNameEmployeeEdit.Text;
                tempEmployee.Email = tbEmailEmployeeEdit.Text;
                tempEmployee.Role = (ROLE)cbRoleEmployeeEdit.SelectedItem;
                tempEmployee.BirthDate = DateTime.ParseExact(maskedTbBirthdayEmployeeEdit.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                tempEmployee.Phone = tbPhoneNumberEmployeeEdit.Text;
                tempEmployee.Password = tbPasswordEmployeeEdit.Text;
                tempEmployee.Address = tbxEmpAddressEdit.Text;
                if (rbFemaleEmployeeEdit.Checked)
                {
                    tempEmployee.PersonGender = "Female";
                }
                else
                    tempEmployee.PersonGender = "Male";
                _employeeManagement.UpdateEmployeeInformation(tempEmployee);
                MessageBox.Show("Action successfull!");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Changes could not be saved! Aborting!");
                return;
            }
        }
    }
}
