using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazaarDesktopApp
{
    public partial class FormHRAdministration : Form
    {
        public FormHRAdministration()
        {
            InitializeComponent();
        }

        private void labelOrigin_Click(object sender, EventArgs e)
        {

        }

        private void numAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEmpployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeInformation form = new EmployeeInformation();
            form.ShowDialog();
            this.Show();
        }

        private void btnEditEmployeeDeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeInformation form = new EmployeeInformation();
            form.ShowDialog();
            this.Show();
        }

        private void btnTerminateEmployeeAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
