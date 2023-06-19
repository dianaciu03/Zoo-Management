using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Employees;

namespace DesktopApplication
{
    public partial class ucContractDetails : UserControl
    {
        EmployeeContract employeeContract;
        IContractManagement _contractManagement;
        int employeeID;
        public ucContractDetails(EmployeeContract ec, IContractManagement emm,int employeeID)
        {
            InitializeComponent();
            employeeContract = ec;
            _contractManagement= emm;
            this.employeeID= employeeID;
        }


        private void btnCancelContractEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBoxContractNotMentionedContractEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxContractNotMentionedContractEdit.Checked) 
            {
                dateTimePickerEndDateContractEdit.Enabled = false;
            }
            else
            {
                dateTimePickerEndDateContractEdit.Enabled = true;
            }
        }

        private void rbFullTimeContractEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFullTimeContractEdit.Checked)
            {
                nudWeeklyHoursContractEdit.Enabled=false;
                nudWeeklyHoursContractEdit.Value = 40;
            }
            else
            {
                nudWeeklyHoursContractEdit.Enabled = true;
                nudWeeklyHoursContractEdit.Value = 8;
            }
        }

        private void btnSaveContractEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudWeeklyHoursContractEdit.Value == 0 || Convert.ToInt32(tbSalaryContractEdit.Text) <= 0)
                {
                    MessageBox.Show("Please complete all of the fields before saving!");
                    return;
                }
                employeeContract.ContractStartDate = DateTime.ParseExact(dateTimePickerStartDateEmployeeContractEdit.Text,"dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                if(!checkBoxContractNotMentionedContractEdit.Checked)
                {
                    employeeContract.ContractEndDate = DateTime.ParseExact(dateTimePickerEndDateContractEdit.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                }
                else
                {
                    employeeContract.ContractEndDate = null;
                }
                employeeContract.Salary = Convert.ToDouble(tbSalaryContractEdit.Text);
                employeeContract.HoursPerWeek = (int)nudWeeklyHoursContractEdit.Value;
                _contractManagement.UpdateContract(employeeContract,employeeID);
                MessageBox.Show("Action successful!");
                this.Hide();
            }
            catch(FormatException) 
            {
                MessageBox.Show("Incorrect data inputed!");
                return;
            }
            catch
            {
                MessageBox.Show("Update couldn't be preformed! Action aborted!");
                return;
            }

        }

        private void ucContractDetails_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDateEmployeeContractEdit.Value = employeeContract.ContractStartDate;
            //gotta check if the value from db is not null (is not 01/01/0001 00:00:00)
            string[] testEndDate = employeeContract.ContractEndDate.ToString().Split(' ');
            DateTime endDate = DateTime.Now;
            if (testEndDate[0] != "01/01/0001")
            {
                endDate = DateTime.ParseExact(testEndDate[0], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            else
            {
                endDate = DateTime.ParseExact(DateTime.Now.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                dateTimePickerEndDateContractEdit.Enabled = false;
                checkBoxContractNotMentionedContractEdit.Checked = true;
            }

            dateTimePickerEndDateContractEdit.Value = endDate;

            nudWeeklyHoursContractEdit.Value = employeeContract.HoursPerWeek;
            if (employeeContract.HoursPerWeek == 40)
            {
                rbFullTimeContractEdit.Checked=true;
                nudWeeklyHoursContractEdit.Enabled = false;
            }
            else
            {
                rbPartTimeContractEdit.Checked = true;
                nudWeeklyHoursContractEdit.Enabled = true;
            }
            tbSalaryContractEdit.Text = employeeContract.Salary.ToString();
        }
    }
}
