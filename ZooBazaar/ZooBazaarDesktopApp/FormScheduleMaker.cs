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
using ZooBazaarLogicLibrary;

namespace ZooBazaarDesktopApp
{
    public partial class FormScheduleMaker : Form
    {
        TaskManagement taskManagement;
        AnimalManagement animalManagement;
        List<Animal> seachedAnimals;
        public FormScheduleMaker(AnimalManagement am, TaskManagement tm)
        {
            InitializeComponent();
            animalManagement = am;
            taskManagement = tm;
            initializeSpecieComboBox();
            updateTasks();
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
                    taskManagement.ScheduleTask(tbxTaskName.Text, tbxTaskDescription.Text, taskDateAndTime, (double)nudEstimatedTaskTime.Value, selectedAnimal.Species, selectedAnimal);
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
                    taskManagement.ScheduleTask(tbxTaskName.Text, tbxTaskDescription.Text, taskDateAndTime, (double)nudEstimatedTaskTime.Value, cbxSearchBySpecie.SelectedItem.ToString(), null);
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
            cbxSearchBySpecie.Items.Add("");
            foreach (Animal animal in animalManagement.GetAllAnimals())
            {
                if (cbxSearchBySpecie.Items.Contains(animal.Species))
                    return;
                else
                    cbxSearchBySpecie.Items.Add(animal.Species);
            }
        }

        private void updateSearchedAnimalListView()
        {

            lvwAnimalSearch.Items.Clear();
            foreach (Animal animal in seachedAnimals)
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
            try
            {
                seachedAnimals = animalManagement.GetSearchedAnimals(tbxSearchByName.Text, cbxSearchBySpecie.SelectedItem.ToString(), "", "", "", "", "");
                updateSearchedAnimalListView();
                if (tbxSearchByName.Text == "") { lvwAnimalSearch.Items.Clear(); }
            }
            catch { }
        }

        private void cbxSearchBySpecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            seachedAnimals = animalManagement.GetSearchedAnimals(tbxSearchByName.Text, cbxSearchBySpecie.SelectedItem.ToString(), "", "", "", "", "");
            updateSearchedAnimalListView();
            if (cbxSearchBySpecie.SelectedIndex == 0)
            {
                lvwAnimalSearch.Items.Clear();
            }
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
                item.SubItems.Add(task.TaskDateTime.ToString("dd/MM/yyyy"));
                if (task.Status == "Not started")
                    lvwUnassignedTasks.Items.Add(item);
                else if (task.Status == "Finished")
                    lvwFinishedTasks.Items.Add(item);
                else if (task.Status == "In progress")
                    lvwTasksInProgress.Items.Add(item);
            }
        }

        private void btnMoreTaskDetails_Click(object sender, EventArgs e)
        {
            if (lvwUnassignedTasks.SelectedItems.Count > 0)
            {
                ZooTask selectedTask = (ZooTask)lvwUnassignedTasks.SelectedItems[0].Tag; ;
                PopupTaskDetails popup = new PopupTaskDetails(selectedTask);
                popup.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("You haven't selected the task");
        }

        private void btnMarkTaskAsFinished_Click(object sender, EventArgs e)
        {
            ZooTask selectedTask = (ZooTask)lvwUnassignedTasks.SelectedItems[0].Tag;
            selectedTask.Status = "Finished";
            updateTasks();
        }

        private void btnFinishedTaskMoreDetails_Click(object sender, EventArgs e)
        {
            if (lvwFinishedTasks.SelectedItems.Count > 0)
            {
                ZooTask selectedTask = (ZooTask)lvwFinishedTasks.SelectedItems[0].Tag;
                PopupTaskDetails popup = new PopupTaskDetails(selectedTask);
                popup.ShowDialog();
                this.Show();
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            ZooTask selectedTask = (ZooTask)lvwUnassignedTasks.SelectedItems[0].Tag;
            taskManagement.RemoveTaskByID(selectedTask.ID);
            updateTasks();
        }

        private void lvwAnimalSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
