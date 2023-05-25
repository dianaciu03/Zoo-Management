using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace DesktopApplication
{
    public partial class FormResourcePlanner : Form
    {
        IEmployeeManagement employeeManagement;
        TaskManagement taskManagement;
        ZooTask selectedTask;
        public FormResourcePlanner(IEmployeeManagement emMng)
        {
            InitializeComponent();
            employeeManagement = emMng;
            taskManagement = new TaskManagement();
            //taskManagement.ScheduleTask("Penguin clean", "Clean the penguin good", DateTime.Today, 2, "Penguin", null);
            updateAvailableTasksListview();
            updateAllTasksListview();
        }
        private void updateAvailableTasksListview()
        {
            lvwAvailableTasks.Items.Clear();
            foreach (ZooTask task in taskManagement.GetTasks().Where(x => x.Status == "Not started"))
            {
                ListViewItem item = new ListViewItem();
                item.Text = task.Name.ToString();
                item.Tag = task;
                item.SubItems.Add(task.TaskDateTime.ToString());
                item.SubItems.Add(task.EstimatedDuration.ToString());
                item.SubItems.Add(task.Status);
                lvwAvailableTasks.Items.Add(item);
            }
        }
        private void updateAllTasksListview()
        {
            lvwAllTasks.Items.Clear();
            ZooTask[] tasks = taskManagement.GetTasks().OrderBy(x => x.Status).ToArray();
            tasks = taskManagement.GetTasks().OrderBy(x => x.TaskDateTime).ToArray();
            foreach (ZooTask task in taskManagement.GetTasks())
            {
                ListViewItem item = new ListViewItem();
                item.Text = task.Name.ToString();
                item.Tag = task;
                item.SubItems.Add(task.TaskDateTime.ToString("yyyy/MM/dd HH:mm"));
                item.SubItems.Add(task.EstimatedDuration.ToString());
                item.SubItems.Add(task.Status);
                lvwAllTasks.Items.Add(item);
            }
        }

        private void updateEmployeeCombobox(ZooTask task)
        {
            ScheduleManagement scheduleManagement = new ScheduleManagement();
            cbxCaretakers.Items.Clear();
            List<Employee> availableCareTakers = new List<Employee>();

            Shift[] shifts = scheduleManagement.GetShifts(task.TaskDateTime.Date, out Employee[] employees);
            foreach (Employee employee in employees)
            {
                if (taskManagement.CheckEmployeeAvailability(task, employee))
                {
                    if (employee.Role == ROLE.CareTaker)
                        cbxCaretakers.Items.Add(employee);
                }
                availableCareTakers.Add(employee);
            }
        }

        private void lvwAvailableTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCaretakers.SelectedIndex = -1;
            try
            {
                if (lvwAvailableTasks.SelectedItems.Count > 0 && lvwAvailableTasks.SelectedItems.Count < 2)
                    selectedTask = (ZooTask)lvwAvailableTasks.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            updateEmployeeCombobox(selectedTask);

            groupBoxTaskDetails.Visible = false;
        }


        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            Employee selectedCaretaker = (Employee)cbxCaretakers.SelectedItem;
            ZooTask selectedTask = (ZooTask)lvwAvailableTasks.SelectedItems[0].Tag;
            if (selectedTask != null && selectedCaretaker != null)
                taskManagement.AssignEmployee(selectedTask, selectedCaretaker);
            updateAvailableTasksListview();
        }

        private void btnMoreDetailsTask_Click(object sender, EventArgs e)
        {
            ZooTask task;
            if (lvwAvailableTasks.SelectedItems.Count > 0)
            {
                task = (ZooTask)lvwAvailableTasks.SelectedItems[0].Tag;
                fillTaskDetails(task);
            }
            else if (lvwAllTasks.SelectedItems.Count > 0)
            {
                groupBoxTaskDetails.Visible = true;
                task = (ZooTask)lvwAllTasks.SelectedItems[0].Tag;
                fillTaskDetails(task);
            }

        }
        private void fillTaskDetails(ZooTask task)
        {
            groupBoxTaskDetails.Visible = true;
            tbxTaskID.Text = task.ID.ToString();
            tbxTaskTitle.Text = task.Name;
            tbxTaskDate.Text = task.TaskDateTime.ToString("yyyy/MM/dd HH:mm");
            tbxEstimatedTaskTime.Text = task.EstimatedDuration.ToString();
            tbxAnimalSpecies.Text = task.Species;
            tbxEnclosureArea.Text = task.EnclosureArea;
            tbxEnclosureNumber.Text = task.EnclosureNumber.ToString();
            if (task.Animal != null)
                tbxTaskAnimalName.Text = task.Animal.Name;
            lbxTaskEmployees.Items.Clear();
            if (taskManagement.GetTaskEmployees(task.ID).Count() > 0)
            {
                foreach (Employee employee in taskManagement.GetTaskEmployees(task.ID))
                {
                    lbxTaskEmployees.Items.Add(employee.FirstName + " " + employee.LastName);
                }
            }
            else lbxTaskEmployees.Items.Add("None");
            tbxSelectedTaskDescription.Text = task.Description;
            lblTaskStatus.Text = task.Status;
        }

        private void lvwAllTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxTaskDetails.Visible = false;
        }

        private void btnTaskMoreDetails_Click(object sender, EventArgs e)
        {
            groupBoxTaskDetails.Visible = true;
            ZooTask task = (ZooTask)lvwAllTasks.SelectedItems[0].Tag;
            fillTaskDetails(task);
        }
    }
}
