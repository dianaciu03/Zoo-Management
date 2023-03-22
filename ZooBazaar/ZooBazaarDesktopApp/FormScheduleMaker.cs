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
        public FormScheduleMaker(AnimalManagement am)
        {
            InitializeComponent();
            taskManagement = new TaskManagement();
            animalManagement = am;
            initializeSpecieComboBox();
            updateTasks();
        }


        private void btnScheduleTask_Click(object sender, EventArgs e)
        {
            DateTime taskDateAndTime = calTaskDateSelection.SelectionRange.Start;
            taskDateAndTime.Hour.Equals(dtpTaskTime.Value);

            if (lvwAnimalSearch.SelectedIndices.Count > 0)
            {
                Animal selectedAnimal = (Animal)lvwAnimalSearch.SelectedItems[0].Tag;
                taskManagement.ScheduleTask(tbxTaskName.Text, tbxTaskDescription.Text, taskDateAndTime, (double)nudEstimatedTaskTime.Value, selectedAnimal.Species, selectedAnimal);
            }
            else
            {
                taskManagement.ScheduleTask(tbxTaskName.Text, tbxTaskDescription.Text, taskDateAndTime, (double)nudEstimatedTaskTime.Value, cbxSearchBySpecie.SelectedItem.ToString(), null);
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
            seachedAnimals = animalManagement.GetSearchedAnimals(tbxSearchByName.Text, cbxSearchBySpecie.SelectedItem.ToString(), "", "", "", "", "");
            updateSearchedAnimalListView();
            if(tbxSearchByName.Text == "") { lvwAnimalSearch.Items.Clear(); }
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
            ZooTask selectedTask = (ZooTask)lvwUnassignedTasks.SelectedItems[0].Tag;
            if (selectedTask.Animal != null)
                MessageBox.Show($"ID: {selectedTask.ID} | Name: {selectedTask.Name}\nSpecie: {selectedTask.Species} - Animal: {selectedTask.Animal.Name}\nDate and time: {selectedTask.TaskDateTime}\nEstimated lenght: {selectedTask.TaskDateTime}\nDescription: {selectedTask.Description}");
            else
                MessageBox.Show($"ID: {selectedTask.ID} | Name: {selectedTask.Name}\nSpecie: {selectedTask.Species}\nDate and time: {selectedTask.TaskDateTime}\nEstimated lenght: {selectedTask.TaskDateTime}\nDescription: {selectedTask.Description}");
        }
    }
}
