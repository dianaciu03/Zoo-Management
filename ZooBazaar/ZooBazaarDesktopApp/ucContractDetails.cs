using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLibrary;
using ZooBazaarLogicLibrary.Employees;

namespace ZooBazaarDesktopApp
{
    public partial class ucContractDetails : UserControl
    {
        EmployeeContract employeeContract;
        public ucContractDetails()
        {
            InitializeComponent();
            //employeeContract = ec;
        }


        private void btnCancelContractEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
