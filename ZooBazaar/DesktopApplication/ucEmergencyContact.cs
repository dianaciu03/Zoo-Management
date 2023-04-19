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
    public partial class ucEmergencyContact : UserControl
    {
        Employee selectedEmployee;

        public ucEmergencyContact(Employee empl)
        {
            InitializeComponent();
            selectedEmployee = empl;
        }

        private void ucEmergencyContact_Load(object sender, EventArgs e)
        {
            //tbAddressAdditionalInformation.Text = selectedEmployee.Address;
            //Employees dont have a postal code field,or emergency contact fields lol
            //tbPostalCodeAdditionalInformation.Text = 
            //tbFirstNameAdditionalInformation.Text =
            //tbLastNameAdditionalInformation.Text = 
            //tbPhoneNumberAdditionalInformation.Text = 
        }


        private void btnCancelAdditionalInformationEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveAdditionalInformationEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
