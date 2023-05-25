using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.AnimalInterfaces;
using BusinessLogic.Employees;
using DataAccess;

namespace DesktopApplication
{
    public partial class FormScheduleMaker : Form
    {
        TaskManagement taskManagement;
        private readonly IAnimalManagement animalManagement;
        IEmployeeManagement employeeManagement = new EmployeeManagement(new EmployeeRepository());

        List<Animal> searchedAnimals;
        public FormScheduleMaker(IAnimalManagement am)
        {
            InitializeComponent();
            animalManagement = am;
            taskManagement = new TaskManagement();
            initializeSpecieComboBox();
            initializeAreaComboBox();
            updateTasks();
            groupBoxTaskDetails.Visible = false;
            cbxTaskEncArea.SelectedText = "";
        }

        private void btnScheduleTask_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = calTaskDateSelection.SelectionStart;
            DateTime selectedTime = dtpTaskTime.Value;
            DateTime taskDateAndTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hour, selectedTime.Minute, selectedTime.Second);

            if (lvwAnimalSearch.SelectedIndices.Count > 0)
            {
                try
                {
                    if (cbxSearchBySpecie.SelectedIndex < 0)
                    {
                        MessageBox.Show("You haven't selected the animal specie");
                        return;
                    }
                    Animal selectedAnimal = (Animal)lvwAnimalSearch.SelectedItems[0].Tag;
                    cbxTaskEncArea.SelectedItem = selectedAnimal.OriginContinent;
                    taskManagement.ScheduleTask(tbxTaskName.Text, selectedAnimal.OriginContinent.ToString(), (int)nudTaskEncNumber.Value, tbxTaskDescription.Text, taskDateAndTime, (int)nudEstimatedTaskTime.Value, selectedAnimal.Species, selectedAnimal);
                }
                catch
                {
                    MessageBox.Show("Entered task information is invalid. Check if all the fields are entered and if details are in correct format!");
                }
            }
            else
            {
                try
                {
                    if (cbxSearchBySpecie.SelectedIndex < 0)
                    {
                        MessageBox.Show("You haven't selected the animal specie");
                        return;
                    }
                    taskManagement.ScheduleTask(tbxTaskName.Text, cbxTaskEncArea.SelectedItem.ToString(), (int)nudTaskEncNumber.Value, tbxTaskDescription.Text, taskDateAndTime, (int)nudEstimatedTaskTime.Value, cbxSearchBySpecie.SelectedItem.ToString(), null);
                }
                catch
                {
                    MessageBox.Show("Entered task information is invalid. Check if all the fields are entered and if details are in correct format!");
                }
            }
            updateTasks();
        }

        private void initializeSpecieComboBox()
        {
            cbxSearchBySpecie.Items.Clear();
            foreach (string s in animalManagement.GetAllSpecies())
            {
                cbxSearchBySpecie.Items.Add(s);
            }
        }
        private void initializeAreaComboBox()
        {
            cbxTaskEncArea.Items.Clear();
            cbxTaskEncArea.Items.Add("Africa");
            cbxTaskEncArea.Items.Add("Europe");
            cbxTaskEncArea.Items.Add("Asia");
            cbxTaskEncArea.Items.Add("North America");
            cbxTaskEncArea.Items.Add("South America");
            cbxTaskEncArea.Items.Add("Australia");
            cbxTaskEncArea.Items.Add("Antarctica");
        }

        private void updateSearchedAnimalListView()
        {

            lvwAnimalSearch.Items.Clear();
            foreach (Animal animal in searchedAnimals)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = animal;
                item.Text = animal.Id.ToString();
                item.SubItems.Add(animal.Species);
                item.SubItems.Add(animal.Name);
                lvwAnimalSearch.Items.Add(item);
            }
        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            //try
            {
                searchedAnimals = animalManagement.GetSearchedAnimals(tbxSearchByName.Text, cbxSearchBySpecie.SelectedItem.ToString(), string.Empty, string.Empty, string.Empty, null, string.Empty);
                updateSearchedAnimalListView();
                if (tbxSearchByName.Text == "") { lvwAnimalSearch.Items.Clear(); }
            }
            // catch { }
        }

        private void cbxSearchBySpecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchedAnimals = animalManagement.GetSearchedAnimals(tbxSearchByName.Text, cbxSearchBySpecie.SelectedItem.ToString(), string.Empty, string.Empty, string.Empty, null, string.Empty);
            updateSearchedAnimalListView();
        }

        private void updateTasks()
        {
            lvwUnassignedTasks.Items.Clear();
            lvwFinishedTasks.Items.Clear();
            lvwTasksInProgress.Items.Clear();
            foreach (ZooTask task in taskManagement.GetTasks())
            {
                ListViewItem item = new ListViewItem();
                item.Tag = task;
                item.Text = task.Name;
                item.SubItems.Add(task.TaskDateTime.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(task.EstimatedDuration.ToString());

                if (task.Status == "Not started")
                    lvwUnassignedTasks.Items.Add(item);
                else if (task.Status == "Finished")
                    lvwFinishedTasks.Items.Add(item);
                else if (task.Status == "Assigned")
                    lvwTasksInProgress.Items.Add(item);
            }
        }

        private void btnMoreTaskDetails_Click(object sender, EventArgs e)
        {
            if (lvwUnassignedTasks.SelectedItems.Count > 0)
            {
                fillInTaskDetails((ZooTask)lvwUnassignedTasks.SelectedItems[0].Tag);
                groupBoxTaskDetails.Visible = true;
            }
            else MessageBox.Show("You haven't selected the task");
        }
        private void fillInTaskDetails(ZooTask task)
        {
            tbxTaskID.Text = task.ID.ToString();
            tbxTaskTitle.Text = task.Name;
            tbxTaskDate.Text = task.TaskDateTime.ToString("dd/MM/yyyy  HH:mm");
            tbxEstimatedTaskTime.Text = task.EstimatedDuration.ToString();
            tbxEnclosureNumber.Text = task.EnclosureNumber.ToString();
            tbxEnclosureArea.Text = task.EnclosureArea;
            tbxAnimalSpecies.Text = task.Species.ToString();
            if (task.Animal != null)
                tbxTaskAnimalName.Text = task.Animal.Name;
            tbxSelectedTaskDescription.Text = task.Description.ToString();
            if (taskManagement.GetTaskEmployees(task.ID).Count() > 0)
            {
                lbxTaskEmployees.Items.Clear();
                foreach (Employee employee in taskManagement.GetTaskEmployees(task.ID))
                {
                    lbxTaskEmployees.Items.Add(employee.FirstName + " " + employee.LastName);
                }
            }
            else
            {
                lbxTaskEmployees.Items.Clear();
                lbxTaskEmployees.Items.Add("None");
            }
            lblTaskStatus.Text = task.Status.ToString();
            if (task.Status == "Not started") lblTaskStatus.ForeColor = Color.Red;
            else if (task.Status == "Finished") lblTaskStatus.ForeColor = Color.Green;
            else if (task.Status == "Assigned") lblTaskStatus.ForeColor = Color.Goldenrod;
        }

        private void btnMarkTaskAsFinished_Click(object sender, EventArgs e)
        {
            ZooTask selectedTask = (ZooTask)lvwUnassignedTasks.SelectedItems[0].Tag;
            if (selectedTask.TaskDateTime <= DateTime.Today)
                taskManagement.UpdateTaskStatus(selectedTask.ID, "Finished");
            else
                MessageBox.Show("Task that is scheduled in the future cannot be marked as finished");
            updateTasks();
        }

        private void btnFinishedTaskMoreDetails_Click(object sender, EventArgs e)
        {
            if (lvwFinishedTasks.SelectedItems.Count > 0)
            {
                fillInTaskDetails((ZooTask)lvwFinishedTasks.SelectedItems[0].Tag);
                groupBoxTaskDetails.Visible = true;
            }
            else MessageBox.Show("You haven't selected the task");
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            ZooTask selectedTask = (ZooTask)lvwUnassignedTasks.SelectedItems[0].Tag;
            if (taskManagement.GetTaskEmployees(selectedTask.ID).Count() == 0)
                taskManagement.RemoveTask(selectedTask.ID);
            else MessageBox.Show("Task with assigned caretakers cannot be removed");
            updateTasks();
        }

        private void lvwAnimalSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTaskEncArea.Text = string.Empty;
            if (lvwAnimalSearch.SelectedItems.Count > 0)
            {
                Animal selectedAnimal = (Animal)lvwAnimalSearch.SelectedItems[0].Tag;
                cbxTaskEncArea.SelectedText = selectedAnimal.OriginContinent.ToString();
                cbxTaskEncArea.Enabled = false;
            }
            else
            {
                cbxTaskEncArea.Enabled = true;
                initializeAreaComboBox();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvwTasksInProgress.SelectedItems.Count > 0)
            {
                fillInTaskDetails((ZooTask)lvwTasksInProgress.SelectedItems[0].Tag);
                groupBoxTaskDetails.Visible = true;
            }
            else MessageBox.Show("You haven't selected the task");

        }

        private void lvwUnassignedTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxTaskDetails.Visible = false;
        }

        private void lvwTasksInProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxTaskDetails.Visible = false;
        }

        private void lvwFinishedTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxTaskDetails.Visible = false;
        }

        private void btnScheduleShifts_Click(object sender, EventArgs e)
        {
            AutomaticScheduling scheduleMaker = new AutomaticScheduling();
            CaretakerWithHours[] careTakers = employeeManagement.GetCareTakers();
            Shift[] shifts = scheduleMaker.ScheduleEmployeesForShifts(careTakers);
            string message = string.Empty;
            foreach( Shift shift in shifts)
            {
                message += $"{shift.ShiftTime} - {shift.Employee.FirstName + " " + shift.Employee.LastName}\n";
            }
            MessageBox.Show(message);
        }
    }
}
