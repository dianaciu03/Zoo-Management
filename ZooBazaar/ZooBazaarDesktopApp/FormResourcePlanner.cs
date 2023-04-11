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
    public partial class FormResourcePlanner : Form
    {
        EmployeeManagement employeeManagement;
        TaskManagement taskManagement;
        ZooTask selectedTask;
        public FormResourcePlanner(EmployeeManagement em, TaskManagement tm)
        {
            InitializeComponent();
            employeeManagement = new EmployeeManagement();
            taskManagement = tm;
            taskManagement.ScheduleTask("Task test1", "Tesst task 1 desc", DateTime.Today.AddDays(6), 4, "Penguin", null);
            taskManagement.ScheduleTask("Task test2", "Tesst task 2 desc", DateTime.Today.AddDays(7), 4, "Zebra", null);
            updateTasksListview();
        }
        private void updateTasksListview()
        {
            lvwAvailableTasks.Items.Clear();
            foreach (ZooTask task in taskManagement.GetTasks())
            {
                ListViewItem item = new ListViewItem();
                item.Text = task.Name.ToString();
                item.Tag = task;
                item.SubItems.Add(task.TaskDateTime.ToString());
                if (task.GetAssignedEmployees().Count() > 0)
                    item.SubItems.Add("Assigned");
                else
                    item.SubItems.Add("Not-assigned");
                lvwAvailableTasks.Items.Add(item);
            }
        }

        private void updateEmployeeCombobox(ZooTask task)
        {
            cbxCaretakers.Items.Clear();
            List<CareTaker> availableCareTakers = new List<CareTaker>();
            foreach (CareTaker careTaker in employeeManagement.GetEmployees())
            {
                if (taskManagement.CheckEmployeeAvailability(task, careTaker))
                {
                    cbxCaretakers.Items.Add(careTaker);
                }
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
        }
        

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            Employee selectedCaretaker = (CareTaker)cbxCaretakers.SelectedItem;
            ZooTask selectedTask = (ZooTask)lvwAvailableTasks.SelectedItems[0].Tag;
            if (selectedTask != null && selectedCaretaker != null)
                selectedTask.AssignEmployee((CareTaker)selectedCaretaker);
            updateTasksListview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateEmployeeCombobox(selectedTask);

        }

        private void btnMoreDetailsTask_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (CareTaker careTaker in selectedTask.GetAssignedEmployees())
            {
                message += $"{careTaker.FirstName} {careTaker.LastName}";
            }
            MessageBox.Show(message);
        }
    }
}
