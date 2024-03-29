﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.AnimalInterfaces;
using BusinessLogic.Animals;
using DataAccess;
using DataAccess.AnimalRepositories;

namespace DesktopApplication
{
    public partial class FormLogin : Form
    {
        IEmployeeManagement employeeManagement = new EmployeeManagement(new EmployeeRepository());
        IAnimalManagement animalManagement = new AnimalManagement(new AnimalRepository());
        ITransferManagement transferManagement = new TransferManagement(new TransferRepository());

        public FormLogin()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxLoginEmail.Text == "" || tbxLoginPassword.Text == "") { return; }
                if (tbxLoginEmail.Text == "check" || tbxLoginPassword.Text == "check") 
                {
                    Check_in_out checkin = new Check_in_out();
                    this.Hide();
                    checkin.Show();
                    return;
                }
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
                        FormResourcePlanner formAssignTasks = new FormResourcePlanner(employeeManagement);
                        formAssignTasks.ShowDialog();
                        break;
                }
                this.Show();
                tbxLoginEmail.Clear();
                tbxLoginPassword.Clear();
            }
            catch(Exception) 
            {
                return;
            }
            
        }
    }
}
