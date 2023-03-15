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
using ZooBazaarLogicLibrary.Enums;

namespace ZooBazaarDesktopApp
{
    public partial class FormAnimalAdministration : Form
    {
        AnimalManagement animalManagement = new AnimalManagement();

        public FormAnimalAdministration()
        {
            InitializeComponent();
            InitializeAnimalMockData();
            InitializeFormElements();
        }

        private void InitializeFormElements()
        {
            cbxEndangerment.DataSource = Enum.GetValues(typeof(Endangerment));
            cbxOrigin.DataSource = Enum.GetValues(typeof(OriginContinent));
            btnClearAll_Click(this, EventArgs.Empty);
            btnCancelTransfer_Click(this, EventArgs.Empty);
        }

        public void InitializeAnimalMockData()
        {
            animalManagement.Animals.Add(new Animal(1, "Ana", "Female", "zebra", DateTime.Now, OriginContinent.Africa, "descriere zebra", Endangerment.LeastConcern, 1));
            animalManagement.Animals.Add(new Animal(2, "Maria", "Female", "alpaca", DateTime.Now, OriginContinent.Asia, "descriere alpaca", Endangerment.LeastConcern, 2));
            animalManagement.Animals.Add(new Animal(3, "Tudor", "Male", "lion", DateTime.Now, OriginContinent.Africa, "descriere lion", Endangerment.LeastConcern, 4));
            animalManagement.Animals.Add(new Animal(4, "Andrei", "Male", "lion", DateTime.Now, OriginContinent.Africa, "descriere lion", Endangerment.NotEvaluated, 4));
            animalManagement.Animals.Add(new Animal(5, "Alex", "Male", "sloth", DateTime.Now, OriginContinent.Africa, "descriere sloth", Endangerment.LeastConcern, 3));
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            
            PopupAnimalDetails popupAnimalDetails = new PopupAnimalDetails();
            popupAnimalDetails.Show();
        }

        private void btnEditAnimal_Click(object sender, EventArgs e)
        {
            if(lvwAnimals.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please select only one animal!");
                return;
            }
            if(lvwAnimals.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select an animal to edit details!");
                return;
            }
            
            PopupAnimalDetails popupAnimalDetails = new PopupAnimalDetails();
            popupAnimalDetails.Show();
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            lbxAnimals.Items.Clear();
            List<Animal> searchedAnimals = new List<Animal>();

            string gender = string.Empty;
            if(rbtnFemale.Checked)
                gender = rbtnFemale.Text;
            else if(rbtnMale.Checked)
                gender = rbtnMale.Text;

            string availability = string.Empty;
            if (cbAvailable.Checked == true && cbTransferred.Checked == false)
                availability = cbAvailable.Text;
            else if (cbAvailable.Checked == false && cbTransferred.Checked == true)
                availability = cbTransferred.Text;
            else if (cbAvailable.Checked == false && cbTransferred.Checked == false || cbAvailable.Checked == false && cbTransferred.Checked == false)
                availability = string.Empty;

            searchedAnimals = animalManagement.GetSearchedAnimals(tbxName.Text, tbxSpecies.Text, cbxOrigin.Text, gender, availability, tbxAge.Text, cbxEndangerment.Text);

            foreach (Animal animal in searchedAnimals)
            {
                lbxAnimals.Items.Add(animal);
            }
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
        }

        //clears all fields in the transfer form
        private void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            tbxAddressTransfer.Text = string.Empty;
            tbxZooNameTransfer.Text = string.Empty;
            tbxComments.Text = string.Empty;
            tbxAnimalTransfer.Text = string.Empty;
        }
    }
}
