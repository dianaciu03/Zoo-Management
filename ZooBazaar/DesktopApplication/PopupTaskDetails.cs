using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace DesktopApplication
{
    public partial class PopupTaskDetails : Form
    {
        public PopupTaskDetails(ZooTask task)
        {
            InitializeComponent();
            fillInTaskDetails(task);
        }

        private void fillInTaskDetails(ZooTask task)
        {
            tbxTaskID.Text = task.ID.ToString();
            tbxTaskTitle.Text = task.Name;
            tbxTaskDate.Text = task.TaskDateTime.ToString("dd/MM/yyyy  HH:mm");
            tbxEstimatedTaskTime.Text = task.EstimatedDuration.ToString();
            tbxAnimalSpecies.Text = task.Species.ToString();
            if (task.Animal != null)
                tbxTaskAnimalName.Text = task.Animal.Name;
            tbxTaskDescription.Text = task.Description.ToString();
            tbxAssignedEmployee.Text = "";
            lblTaskStatus.Text = task.Status.ToString();
            if (task.Status == "Not started") lblTaskStatus.ForeColor = Color.Red;
            else if (task.Status == "Finished") lblTaskStatus.ForeColor = Color.Green;
        }

        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
