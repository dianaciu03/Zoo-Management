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
        public FormLogin()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            InitializeMockData();
        }

        private void InitializeMockData() 
        {
            employeeManagement.AddEmployee(new Manager(1, "John", "Johnson", DateTime.Now, "Male", "ABCD Street 1", "+312312312", "1", "1", 40));
            employeeManagement.AddEmployee(new HRAdministrator(2, "Joana", "Johanson", DateTime.Now, "Female", "ABCD Street 2", "+312312000", "2", "2", 40));
            employeeManagement.AddEmployee(new AnimalAdministrator(3, "Patrick", "Patrickson", DateTime.Now, "Male", "ABCD Street 3", "+312312001", "3", "3", 40));
            employeeManagement.AddEmployee(new ScheduleMaker(4, "Dennis", "Dennison", DateTime.Now, "Male", "ABCD Street 4", "+312312100", "4", "4", 40));
            employeeManagement.AddEmployee(new ResourcePlanner(5, "Olivia", "Olisson", DateTime.Now, "Female", "ABCD Street 5", "+312315102", "5", "5", 40));

            animalManagement.AddAnimal(new Animal(1, "Ana", "Female", "zebra", DateTime.Now, ORIGINCONTINENT.Africa, "descriere zebra", ENDANGERMENT.LeastConcern, 1));
            animalManagement.AddAnimal(new Animal(2, "Maria", "Female", "alpaca", DateTime.Now, ORIGINCONTINENT.Asia, "descriere alpaca", ENDANGERMENT.LeastConcern, 2));
            animalManagement.AddAnimal(new Animal(3, "Tudor", "Male", "lion", DateTime.Now, ORIGINCONTINENT.Africa, "descriere lion", ENDANGERMENT.LeastConcern, 4));
            animalManagement.AddAnimal(new Animal(4, "Andrei", "Male", "lion", DateTime.Now, ORIGINCONTINENT.Africa, "descriere lion", ENDANGERMENT.NotEvaluated, 4));
            animalManagement.AddAnimal(new Animal(5, "Alex", "Male", "sloth", DateTime.Now, ORIGINCONTINENT.Africa, "descriere sloth", ENDANGERMENT.LeastConcern, 3));

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxLoginEmail.Text == "" || tbxLoginPassword.Text == "") { return; }
                switch (employeeManagement.GetEmployee(tbxLoginEmail.Text, tbxLoginPassword.Text).GetType().Name)
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
                        FormScheduleMaker formScheduleTask = new FormScheduleMaker(animalManagement);
                        formScheduleTask.ShowDialog();
                        break;
                    case ("ResourcePlanner"):
                        this.Hide();
                        FormResourcePlanner formAssignTasks = new FormResourcePlanner();
                        formAssignTasks.ShowDialog();
                        break;
                }
                this.Show();
                tbxLoginEmail.Clear();
                tbxLoginPassword.Clear();
            }
            catch(Exception ex) { MessageBox.Show("Credentials incorrect");  }

        }
    }
}
