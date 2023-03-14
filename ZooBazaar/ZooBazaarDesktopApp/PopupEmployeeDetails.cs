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
using ZooBazaarLogicLibrary.Animals;

namespace ZooBazaarDesktopApp
{
    public partial class PopupEmployeeDetails : Form
    {
        bool newEmployeeCreation;
        Employee employee;
        FormDataValidator dataValidator= new FormDataValidator();
        public PopupEmployeeDetails(Employee em)
        {
            InitializeComponent();
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

        private void fillInFields()
        {
            tbxFirstName.Text = employee.FirstName;
            tbxLastName.Text = employee.LastName;
            maskedtbxAddEditEmployee.Text = employee.BirthDate.ToString();
            cbxGender.SelectedItem = employee.PersonGender;
            tbxAddress.Text = employee.Address;
            tbxPhone.Text = employee.Phone;
            cbxRole.SelectedItem = employee.GetType().Name;
            tbxEmail.Text = employee.Email;
            tbxEmployeePassword.Text = employee.Password;
        }

        private void btnConfirmEmployeeCreation_Click(object sender, EventArgs e)
        {
            if (newEmployeeCreation)
            {
                //if(string.isEmptyOrNull())
                if (!dataValidator.IsValidStringOnly(tbxFirstName.Text))
                {
                    MessageBox.Show("Please input a valid name!");
                }
            }
        }
    }
}
