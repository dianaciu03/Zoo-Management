﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                item.SubItems.Add(task.Status);
                lvwAvailableTasks.Items.Add(item);
            }
        }

        private void updateEmployeeCombobox(ZooTask task)
        {
            cbxCaretakers.Items.Clear();
            List<Employee> availableCareTakers = new List<Employee>();
            foreach (Employee employee in employeeManagement.GetEmployees(out int[] ints))
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
        }
        

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            Employee selectedCaretaker = (Employee)cbxCaretakers.SelectedItem;
            ZooTask selectedTask = (ZooTask)lvwAvailableTasks.SelectedItems[0].Tag;
            if (selectedTask != null && selectedCaretaker != null)
                selectedTask.AssignEmployee(selectedCaretaker);
            updateTasksListview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateEmployeeCombobox(selectedTask);

        }

        private void btnMoreDetailsTask_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (Employee careTaker in selectedTask.GetAssignedEmployees())
            {
                message += $"{careTaker.FirstName} {careTaker.LastName}";
            }
            MessageBox.Show(message);
        }
    }
}
