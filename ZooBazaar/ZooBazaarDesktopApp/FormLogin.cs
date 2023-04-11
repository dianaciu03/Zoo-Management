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
        EmployeeManagement employeeManagement = new EmployeeManagement();
        AnimalManagement animalManagement = new AnimalManagement();
        TaskManagement taskManagement = new TaskManagement();
        public FormLogin()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxLoginEmail.Text == "" || tbxLoginPassword.Text == "") { return; }

                if (employeeManagement.GetEmployeeByEmail(tbxLoginEmail.Text).Password != tbxLoginPassword.Text)
                    return;

                switch (employeeManagement.GetEmployeeByEmail(tbxLoginEmail.Text).GetType().Name)
                {
                    case ("AnimalAdministrator"):
                        this.Hide();
                        FormAnimalAdministration formAnimalManagement = new FormAnimalAdministration(animalManagement);
                        formAnimalManagement.ShowDialog(); 
                        break;
                    case ("HRAdministrator"):
                        this.Hide();
                        FormHRAdministration formHRManagement = new FormHRAdministration(employeeManagement);
                        formHRManagement.ShowDialog();
                        break;
                    case ("ScheduleMaker"):
                        this.Hide();
                        FormScheduleMaker formScheduleTask = new FormScheduleMaker(animalManagement, taskManagement);
                        formScheduleTask.ShowDialog();
                        break;
                    case ("ResourcePlanner"):
                        this.Hide();
                        FormResourcePlanner formAssignTasks = new FormResourcePlanner(employeeManagement, taskManagement);
                        formAssignTasks.ShowDialog();
                        this.Close();
                        break;
                }
                this.Show();
                tbxLoginEmail.Clear();
                tbxLoginPassword.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);  }

        }
    }
}
