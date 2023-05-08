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
                nudWeeklyHoursContractEdit.Value = 0;
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
            var endDate = DateTime.ParseExact("01/01/0001", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
            if (employeeContract.ContractEndDate > endDate)
            {
                dateTimePickerEndDateContractEdit.Value = (DateTime)employeeContract.ContractEndDate;

            }
            else
            {
                dateTimePickerEndDateContractEdit.Value = DateTime.Now;
                dateTimePickerEndDateContractEdit.Enabled = false;
                checkBoxContractNotMentionedContractEdit.Checked = true;
            }
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
