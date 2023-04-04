using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLibrary;

namespace ZooBazaarDesktopApp
{
    public partial class PopupAnimalDetails : Form
    {
        Animal animal;
        AnimalManagement animalManagement;
        public PopupAnimalDetails(Animal a, AnimalManagement am)
        {
            InitializeComponent();
            cbxEndangermentAddAnimal.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxOriginAddAnimal.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));

            animalManagement = am;
            if (a == null)
            {
                btnConfirmAnimalCreation.Visible = true;
                btnConfirmChanges.Visible = false;
                return;
            }
            animal = a;
            btnConfirmAnimalCreation.Visible = false;
            btnConfirmChanges.Visible = true;
            fillInDetails(a);
        }

        private void btnCancelAnimalCreation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAnimalCreation_Click(object sender, EventArgs e)
        {
            int animalID;
            if (animalManagement.GetAllAnimals().Length > 0)
            {
                animalID = animalManagement.GetAllAnimals().Last().Id + 1;
            }
            else animalID = 1;

            string gender;
            if (rbtnMaleAddAnimal.Checked) gender = "Male";
            else if (rbtnFemaleAddAnimal.Checked) gender = "Female";
            else throw (new Exception("Please select a gender"));

            animal = new Animal(animalID, tbxNameAddAnimal.Text, gender, tbxSpeciesAddAnimal.Text, DateTime.Parse(maskedtbxBirthDateEditAnimalForm.Text), (ORIGINCONTINENT)cbxOriginAddAnimal.SelectedItem, tbxAdditionalCommentsAddAnimal.Text, (ENDANGERMENT)cbxEndangermentAddAnimal.SelectedItem, (int)nudEnclosureAddAnimal.Value, "available");
            animalManagement.AddAnimal(animal);
            this.Close();
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            animal.Name = tbxNameAddAnimal.Text;
            animal.Species = tbxSpeciesAddAnimal.Text;
            animal.Birthday = DateTime.Parse(maskedtbxBirthDateEditAnimalForm.Text);
            animal.Enclosure = (int)nudEnclosureAddAnimal.Value;
            animal.OriginContinent = (ORIGINCONTINENT)cbxOriginAddAnimal.SelectedItem;
            animal.Endangerment = (ENDANGERMENT)cbxEndangermentAddAnimal.SelectedItem;
            if (rbtnFemaleAddAnimal.Checked == true) 
                animal.Gender = "Female";
            else if (rbtnMaleAddAnimal.Checked == true) 
                animal.Gender = "Male";
            animal.Description = tbxAdditionalCommentsAddAnimal.Text;
            this.Close();
        }

        private void fillInDetails(Animal a)
        {
            tbxNameAddAnimal.Text = a.Name;
            tbxSpeciesAddAnimal.Text = a.Species;
            maskedtbxBirthDateEditAnimalForm.Text = a.Birthday.ToString();
            cbxOriginAddAnimal.SelectedItem = a.OriginContinent;
            cbxEndangermentAddAnimal.SelectedItem = a.Endangerment;
            if (a.Gender == "Male") rbtnMaleAddAnimal.Checked = true;
            else if (a.Gender == "Female") rbtnFemaleAddAnimal.Checked = true;
            nudEnclosureAddAnimal.Value = a.Enclosure;
            tbxAdditionalCommentsAddAnimal.Text = a.Description;
        }
    }
}
