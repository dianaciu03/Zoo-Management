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
    public partial class FormLogin : Form
    {
        IEmployeeManagement employeeManagement = new EmployeeManagement();
        AnimalManagement animalManagement = new AnimalManagement();
        public FormLogin()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbxLoginEmail.Text == "" || tbxLoginPassword.Text == "") { return; }
            if (employeeManagement.GetEmployeeByEmail(tbxLoginEmail.Text) == null)
            {
                MessageBox.Show("User with this email does not exist in the system");
                return;
            }
            Employee logEmployee = employeeManagement.GetEmployeeByEmail(tbxLoginEmail.Text);
            if (logEmployee.Password != tbxLoginPassword.Text)
            {
                MessageBox.Show("Credentials are incorrect! Try again");
                return;
            }
 
            switch (logEmployee.Role)
            {
                case ROLE.AnimalAdministrator:
                    this.Hide();
                    FormAnimalAdministration formAnimalManagement = new FormAnimalAdministration(animalManagement);
                    formAnimalManagement.ShowDialog(); 
                    break;
                case ROLE.HRAdministrator:
                    this.Hide();
                    FormHRAdministration formHRManagement = new FormHRAdministration(employeeManagement);
                    formHRManagement.ShowDialog();
                    break;
                case ROLE.ScheduleMaker:
                    this.Hide();
                    FormScheduleMaker formScheduleTask = new FormScheduleMaker(animalManagement);
                    formScheduleTask.ShowDialog();
                    break;
                case ROLE.ResourcePlanner:
                    this.Hide();
                    FormResourcePlanner formAssignTasks = new FormResourcePlanner();
                    formAssignTasks.ShowDialog();
                    break;
            }
            this.Show();
            tbxLoginEmail.Clear();
            tbxLoginPassword.Clear();
        }
    }
}
