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

namespace ZooBazaarDesktopApp
{
    public partial class ucEmployeeInformation : UserControl
    {
        EmployeeManagement employeeManagement;
        Employee selectedEmployee;
        public ucEmployeeInformation(EmployeeManagement em, Employee selectedEmployee)
        {
            InitializeComponent();
            employeeManagement = em;
            this.selectedEmployee = selectedEmployee;
            
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
            cbRoleEmployeeEdit.SelectedItem = selectedEmployee.GetRole();
            tbEmailEmployeeEdit.Text = selectedEmployee.Email;
            tbEmailEmployeeEdit.Text = selectedEmployee.Email;
            //NEED TO ADD EMPLOYEE BIRTHDATE INTO THE MASKED TEXTBOX, I DONT KNOW HOW TO PARSE IT 
            // SOMEONE PLEASE DO IT FOR ME TY :*

        }

        private void btnCancelEmployeeEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveEmployeeEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
