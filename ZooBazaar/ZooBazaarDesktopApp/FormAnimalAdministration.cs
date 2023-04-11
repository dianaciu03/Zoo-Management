using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLibrary;
using ZooBazaarLogicLibrary.Animals;

namespace ZooBazaarDesktopApp
{
    public partial class FormAnimalAdministration : Form
    {
        FormDataValidator formDataValidator;
        AnimalManagement animalManagement;
        TransferManagement transferManagement;

        public FormAnimalAdministration(AnimalManagement am)
        {
            InitializeComponent();
            animalManagement = am;
            formDataValidator = new FormDataValidator();
            transferManagement = new TransferManagement();
            InitializeFormElements();
        }

        private void InitializeFormElements()
        {
            cbxEndangerment.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxOrigin.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));
            cbxEndangermentEdit.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxContinentEdit.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));
            cbxEndangermentAddAnimal.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxOriginAddAnimal.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));

            btnClearAll_Click(this, EventArgs.Empty);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            updateAnimalHistoryListview(animalManagement.GetAllAnimals());
            groupBoxEditAnimal.Visible = false;
            groupBoxAnimalTransfer.Visible = false;
            groupBoxRelationship.Visible = false;
        }

        //button that makes the group box for editing animal visible (step 1 editing)
        private void btnEditAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                fillInDetails(animal);
                groupBoxSearchAnimal.Visible = false;
                groupBoxEditAnimal.Visible = true;
                lvwAnimals.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an animal to edit details!\n" + ex.Message);
            }  
        }

        //fills in details when editing animal (step 2 editing)
        private void fillInDetails(Animal a)
        {
            tbxNameEdit.Text = a.Name;
            tbxSpeciesEdit.Text = a.Species;
            maskedtbxDateOfBirthEdit.Text = a.Birthday.ToString("MM/dd/yyyy");
            cbxContinentEdit.SelectedItem = a.OriginContinent;
            cbxEndangermentEdit.SelectedItem = a.Endangerment;
            if (a.Gender == "Male") rbtnMaleEdit.Checked = true;
            else if (a.Gender == "Female") rbtnFemaleEdit.Checked = true;
            numudEnclosureEdit.Value = a.Enclosure;
            tbxAdditionalCommentsEdit.Text = a.Description;
        }

        //cancels editing animal and displays the search function back (step 3 editing)
        private void btnCancelEditAnimalDetails_Click(object sender, EventArgs e)
        {
            groupBoxEditAnimal.Visible = false;
            groupBoxSearchAnimal.Visible = true;
            ClearAnimalEditDetails();
            lvwAnimals.Enabled = true;
        }
        
        //confirms changes when editing an animal and reverts back to original search function (step 3 editing)
        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                string input = maskedtbxDateOfBirthEdit.Text;
                DateTime date;

                // Try to parse the input string as a date
                if (DateTime.TryParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    // If the parsing is successful, format the date and update the text box
                    maskedtbxDateOfBirthEdit.Text = date.ToString("MM/dd/yyyy");
                    maskedtbxDateOfBirthEdit.SelectionStart = maskedtbxDateOfBirthEdit.Text.Length;
                }

                animal.Name = tbxNameEdit.Text;
                animal.Species = tbxSpeciesEdit.Text;
                animal.Birthday = DateTime.Parse(input);
                animal.Enclosure = (int)numudEnclosureEdit.Value;
                animal.OriginContinent = (ORIGINCONTINENT)cbxContinentEdit.SelectedItem;
                animal.Endangerment = (ENDANGERMENT)cbxEndangermentEdit.SelectedItem;
                if (rbtnFemaleEdit.Checked == true)
                    animal.Gender = "Female";
                else if (rbtnMaleEdit.Checked == true)
                    animal.Gender = "Male";
                animal.Description = tbxAdditionalCommentsEdit.Text;
                MessageBox.Show("Animal has been edited successfully!");
                //reset to initial state
                btnCancelEditAnimalDetails_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAnimalEditDetails()
        {
            tbxNameEdit.Text = string.Empty;
            tbxSpeciesEdit.Text = string.Empty;
            maskedtbxDateOfBirthEdit.Text = string.Empty;
            cbxContinentEdit.SelectedIndex = -1;
            cbxEndangermentEdit.SelectedIndex = -1;
            rbtnMaleEdit.Checked = false;
            rbtnFemaleEdit.Checked = false;
            numudEnclosureEdit.Text = string.Empty;
            tbxAdditionalCommentsEdit.Text = string.Empty;
        }

        //button that makes the group box for transferring an animal visible (step 1 transfer)
        private void btnTransferAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                groupBoxSearchAnimal.Visible = false;
                groupBoxAnimalTransfer.Visible = true;
                lvwAnimals.Enabled = false;
                tbxAnimalTransfer.Text = animal.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an animal to transfer!\n" + ex.Message);
            }
        }

        //cancels the transfer and displays the search function back (step 2 transfer)
        private void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            groupBoxAnimalTransfer.Visible = false;
            groupBoxSearchAnimal.Visible = true;
            ClearTransferFields();
            lvwAnimals.Enabled = true;
        }

        //confirms transfer and reverts back to original search function (step 2 transfer)
        //ADDED PHONE - REQUIRES CHANGES
        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;

                string name = tbxZooNameTransfer.Text;
                string address = tbxAddressTransfer.Text;
                string description = tbxComments.Text;
                string phone = tbxAnimalTransferPhone.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                if (formDataValidator.IsValidTransfer(name, address, description, phone))
                {
                    Transfer transfer = new Transfer(name, address, description, startDate, endDate, animal, phone);
                    transferManagement.SaveTransfer(transfer);
                    MessageBox.Show("Transfer has been successfully created!");
                    //resets to original state
                    btnCancelTransfer_Click(this, EventArgs.Empty);
                }
                else
                    MessageBox.Show("Transfer couldn't be created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTransferFields()
        {
            tbxAnimalTransfer.Text = string.Empty;
            tbxZooNameTransfer.Text = string.Empty;
            tbxAddressTransfer.Text = string.Empty;
            tbxAnimalTransferPhone.Text = string.Empty;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            tbxComments.Text = string.Empty;
        }

        //button that makes the group box for adding a relationship to an animal visible (step 1 relationship)
        private void btnAddRelationship_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                groupBoxSearchAnimal.Visible = false;
                groupBoxRelationship.Visible = true;
                lvwAnimals.Enabled = false;
                tbxMainAnimalRelationship.Text = animal.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an animal to add relationship!\n" + ex.Message);
            }
        }
        private void btnAddNewRelationship_Click(object sender, EventArgs e)
        {
            //NEEDS IMPLEMENTATION

            MessageBox.Show("Relationship has been added successfully!");
            //reset to original state
            btnCancelRelationship_Click(this, EventArgs.Empty);
        }

        private void btnCancelRelationship_Click(object sender, EventArgs e)
        {
            groupBoxSearchAnimal.Visible = true;
            groupBoxRelationship.Visible = false;
            lvwAnimals.Enabled = true;
            ClearRelationshipFields();
        }

        private void btnRemoveRelationship_Click(object sender, EventArgs e)
        {

        }

        private void ClearRelationshipFields()
        {
            tbxMainAnimalRelationship.Text = string.Empty;
            lbxRelationshipsMain.Items.Clear();
            cbxRelationshipType.SelectedIndex = -1;
            cbxOtherAnimalRelationship.SelectedIndex = -1;
        }

        //button to use the search function
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
        private void btnDisplayAllAnimals_Click(object sender, EventArgs e)
        {
            updateAnimalListview(animalManagement.GetAllAnimals());
        }
        private void lvwAnimals_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                MessageBox.Show(animal.GetAnimalDetails(animal));
            }
            catch(NullReferenceException)
            {
                return;
            }
        }


        //
        //TAB ANIMAL HISTORY
        //
        private void btnDisplayHistory_Click(object sender, EventArgs e)
        {
            updateAnimalHistoryListview(animalManagement.GetAllAnimals());
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


        //
        //TAB ADD ANIMAL
        //
        private void btnConfirmAnimalCreation_Click(object sender, EventArgs e)
        {
            try
            {
                string input = maskedtbxBirthDateAddAnimalForm.Text;
                DateTime date;

                // Try to parse the input string as a date
                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    // If the parsing is successful, format the date and update the text box
                    maskedtbxBirthDateAddAnimalForm.Text = date.ToString("dd/MM/yyyy");
                    maskedtbxBirthDateAddAnimalForm.SelectionStart = maskedtbxBirthDateAddAnimalForm.Text.Length;
                }

                int animalID = animalManagement.NewAnimaID();


                string gender;
                if (rbtnMaleAddAnimal.Checked) gender = "Male";
                else if (rbtnFemaleAddAnimal.Checked) gender = "Female";
                else throw (new Exception("Please select a gender"));

                Animal animal = new Animal(animalID, tbxNameAddAnimal.Text, gender, tbxSpeciesAddAnimal.Text, DateTime.Parse(maskedtbxBirthDateAddAnimalForm.Text), (ORIGINCONTINENT)cbxOriginAddAnimal.SelectedItem, tbxAdditionalCommentsAddAnimal.Text, (ENDANGERMENT)cbxEndangermentAddAnimal.SelectedItem, (int)nudEnclosureAddAnimal.Value, "Available");
                animalManagement.AddAnimal(animal);
                MessageBox.Show($"Animal has been successfully created!\n{animal}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
