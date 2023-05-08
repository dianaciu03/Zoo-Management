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
using BusinessLogic.Employees;

namespace DesktopApplication
{
    public partial class ucEmergencyContact : UserControl
    {
        Employee selectedEmployee;
        IEmergencyContactManagement emergencyContactManagement;
        EmergencyContact selectedEmergencyContact;
        public ucEmergencyContact(Employee empl, IEmergencyContactManagement emergencyContactManagement)
        {
            InitializeComponent();
            selectedEmployee = empl;
            this.emergencyContactManagement = emergencyContactManagement;
            selectedEmergencyContact = emergencyContactManagement.GetContactByEmployee(selectedEmployee.ID);

        }

        private void ucEmergencyContact_Load(object sender, EventArgs e)
        {
            tbFirstNameAdditionalInformation.Text = selectedEmergencyContact.FirstName;
            tbLastNameAdditionalInformation.Text = selectedEmergencyContact.LastName;
            tbPhoneNumberAdditionalInformation.Text = selectedEmergencyContact.Phone;
            tbxEmergencyContractRel.Text = selectedEmergencyContact.Relationship;
        }


        private void btnCancelAdditionalInformationEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveAdditionalInformationEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tbFirstNameAdditionalInformation.Text) || string.IsNullOrEmpty(tbLastNameAdditionalInformation.Text) 
                  || string.IsNullOrEmpty(tbPhoneNumberAdditionalInformation.Text) || string.IsNullOrEmpty(tbxEmergencyContractRel.Text)) 
                {
                    MessageBox.Show("Please complete all of the fields before saving changes!");
                    return;
                }
                selectedEmergencyContact.FirstName= tbFirstNameAdditionalInformation.Text;
                selectedEmergencyContact.LastName= tbLastNameAdditionalInformation.Text;
                selectedEmergencyContact.Phone= tbPhoneNumberAdditionalInformation.Text;
                selectedEmergencyContact.Relationship = tbxEmergencyContractRel.Text;
                emergencyContactManagement.UpdateEmergencyContact(selectedEmergencyContact, selectedEmployee.ID);
                MessageBox.Show("Changes saved!");
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Changes couldn't be saved! Action aborted!");
            }
        }
    }
}
