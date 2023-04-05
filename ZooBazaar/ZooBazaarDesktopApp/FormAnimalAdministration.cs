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
    public partial class FormAnimalAdministration : Form
    {
        AnimalManagement animalManagement;

        public FormAnimalAdministration(AnimalManagement am)
        {
            InitializeComponent();
            animalManagement = am;
            InitializeFormElements();
            
        }

        private void InitializeFormElements()
        {
            cbxEndangerment.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxOrigin.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));
            btnClearAll_Click(this, EventArgs.Empty);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            updateAnimalHistoryListview(animalManagement.GetAllAnimals());
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            PopupAnimalDetails popupAnimalDetails = new PopupAnimalDetails(null, animalManagement);
            popupAnimalDetails.ShowDialog();
        }

        private void btnEditAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal selectedAnimal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                PopupAnimalDetails popupAnimalDetails = new PopupAnimalDetails(selectedAnimal, animalManagement);
                popupAnimalDetails.ShowDialog();
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Please select an animal to edit details!\n" + ex.Message);
            }
            
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            List<Animal> searchedAnimals = new List<Animal>();

            string gender = string.Empty;
            if (rbtnFemale.Checked)
                gender = rbtnFemale.Text;
            else if (rbtnMale.Checked)
                gender = rbtnMale.Text;

            string availability = string.Empty;
            if (cbAvailable.Checked == true && cbTransferred.Checked == false)
                availability = cbAvailable.Text;
            else if (cbAvailable.Checked == false && cbTransferred.Checked == true)
                availability = cbTransferred.Text;
            else if (cbAvailable.Checked == false && cbTransferred.Checked == false || cbAvailable.Checked == false && cbTransferred.Checked == false)
                availability = string.Empty;

            searchedAnimals = animalManagement.GetSearchedAnimals(tbxName.Text, tbxSpecies.Text, cbxOrigin.Text, gender, availability, tbxAge.Text, cbxEndangerment.Text);

            updateAnimalListview(searchedAnimals.ToArray());
        }

        //reverts all fields of the search function to the original state 
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            cbAvailable.Checked = true;
            tbxAge.Text = string.Empty;
            cbxOrigin.SelectedIndex = -1;
            cbxEndangerment.SelectedIndex = -1;
            tbxName.Text = string.Empty;
            tbxSpecies.Text = string.Empty;
        }

        private void updateAnimalListview(Animal[] animals)
        {
            lvwAnimals.Items.Clear();
            foreach (Animal animal in animals)
            {
                ListViewItem item = new ListViewItem();
                item.Text = animal.Id.ToString();
                item.Tag = animal;
                item.SubItems.Add(animal.Name);
                item.SubItems.Add(animal.Species);
                item.SubItems.Add(animal.Gender);
                item.SubItems.Add(animal.OriginContinent.ToString());
                item.SubItems.Add(animal.Enclosure.ToString());
                item.SubItems.Add(animal.Availability);
                lvwAnimals.Items.Add(item);
            }
        }

        private void updateAnimalHistoryListview(Animal[] animals)
        {
            lvwAnimalHistory.Items.Clear();
            foreach (Animal animal in animals)
            {
                ListViewItem item = new ListViewItem();
                item.Text = animal.Id.ToString();
                item.Tag = animal;
                item.SubItems.Add(animal.Name);
                item.SubItems.Add(animal.Species);
                item.SubItems.Add(animal.Gender);
                item.SubItems.Add(animal.GetAge().ToString());
                item.SubItems.Add(animal.OriginContinent.ToString());
                item.SubItems.Add(animal.Enclosure.ToString());
                item.SubItems.Add(animal.Endangerment.ToString());
                item.SubItems.Add(animal.Availability);
                lvwAnimalHistory.Items.Add(item);
            }
        }

        private void btnDisplayHistory_Click(object sender, EventArgs e)
        {
            updateAnimalHistoryListview(animalManagement.GetAllAnimals());
        }

        private void btnTransferAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal selectedAnimal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                PopupAnimalTransfer popupAnimalTransfer = new PopupAnimalTransfer(selectedAnimal, animalManagement);
                popupAnimalTransfer.ShowDialog();
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Please select an animal to edit details!\n" + ex.Message);
            };
        }

        private void btnDisplayAllAnimals_Click(object sender, EventArgs e)
        {
            updateAnimalListview(animalManagement.GetAllAnimals());
        }

        private void lvwAnimals_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                MessageBox.Show(animal.GetAnimalDetails());
            }
            catch(NullReferenceException)
            {
                return;
            }
        }
    }
}
