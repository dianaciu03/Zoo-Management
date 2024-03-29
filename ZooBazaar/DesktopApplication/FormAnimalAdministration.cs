﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLogic;
using BusinessLogic.AnimalInterfaces;
using BusinessLogic.Animals;
using DataAccess.AnimalRepositories;

namespace DesktopApplication
{
    public partial class FormAnimalAdministration : Form
    {
        FormDataValidator formDataValidator;
        private readonly IAnimalManagement animalManagement;
        private readonly ITransferManagement transferManagement;
        List<RadioButton> animalHistoryOrderBy;
        private Transfer currentTransfer;
        public FormAnimalAdministration(IAnimalManagement am)
        {
            InitializeComponent();
            animalManagement = am;
            formDataValidator = new FormDataValidator();
            transferManagement = new TransferManagement(new TransferRepository());
            InitializeFormElements();
            groupBoxSearchAnimal.Visible = true;
            groupBoxTransferDetails.Visible = false;
            btnConfirmTransferDetails.Visible = false;
            FillTransfersList();
            dtpNewEndDate.Enabled = false;
            dtpNewStartDate.Enabled = false;
        }

        private void InitializeFormElements()
        {
            cbxEndangerment.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxOrigin.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));
            cbxEndangermentEdit.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxContinentEdit.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));
            cbxEndangermentAddAnimal.DataSource = Enum.GetValues(typeof(ENDANGERMENT));
            cbxOriginAddAnimal.DataSource = Enum.GetValues(typeof(ORIGINCONTINENT));

            var species = animalManagement.GetAllSpecies();
            cbxAnimalSpecies.DataSource = species;
            cbxAnimalSpeciesEdit.DataSource = species;
            cbxAnimalSpeciesSearch.DataSource = species;
            cbxAnimalSpecies.SelectedIndex = -1;
            cbxAnimalSpeciesEdit.SelectedIndex = -1;
            cbxAnimalSpeciesSearch.SelectedIndex = -1;

            btnClearAll_Click(this, EventArgs.Empty);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            updateAnimalHistoryListview(animalManagement.GetAllAnimals("AnimalId"));
            groupBoxEditAnimal.Visible = false;
            groupBoxAnimalTransfer.Visible = false;
            groupBoxRelationship.Visible = false;
            animalHistoryOrderBy = new List<RadioButton>
            { rbtnName, rbtnSpecies, rbtnContinent, rbtnAge };
            rbtnName.Checked = false;
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
            cbxAnimalSpeciesEdit.Text = a.Species;
            maskedtbxDateOfBirthEdit.Text = a.Birthday.ToString("MM/dd/yyyy");
            cbxContinentEdit.SelectedItem = a.OriginContinent;
            cbxEndangermentEdit.SelectedItem = a.Endangerment;
            if (a.Gender == "Male") rbtnMaleEdit.Checked = true;
            else if (a.Gender == "Female") rbtnFemaleEdit.Checked = true;
            numudEnclosureEdit.Value = 1;
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
                animal.Species = cbxAnimalSpeciesEdit.Text;
                animal.Birthday = date;
                animal.Enclosure = (int)numudEnclosureEdit.Value;
                animal.OriginContinent = (ORIGINCONTINENT)cbxContinentEdit.SelectedItem;
                animal.Endangerment = (ENDANGERMENT)cbxEndangermentEdit.SelectedItem;
                if (rbtnFemaleEdit.Checked == true)
                    animal.Gender = "Female";
                else if (rbtnMaleEdit.Checked == true)
                    animal.Gender = "Male";
                animal.Description = tbxAdditionalCommentsEdit.Text;

                animalManagement.AddUpdateAnimal(animal);

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
            cbxAnimalSpeciesEdit.Text = string.Empty;
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
        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                List<Transfer> transfers = transferManagement.GetAllTransfersById(animal.Id);
                string name = tbxZooNameTransfer.Text;
                string address = tbxAddressTransfer.Text;
                string description = tbxComments.Text;
                string phone = tbxAnimalTransferPhone.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                if (formDataValidator.IsValidTransfer(name, address, description, phone) && (startDate < endDate))
                {
                    if(transfers.Count > 0)
                    {
                        foreach (Transfer transfer in transfers)
                        {
                            if (transfer.StartDate < startDate.Date) 
                            { 
                                if (transfer.EndDate >= startDate.Date)
                                    throw new Exception("Animal is not available at the specified date!\nPlease check the transfer schedule again!");
                            }
                            else if (transfer.StartDate > endDate.Date)
                            {
                                continue;
                            }
                            else
                            {
                                throw new Exception("Animal is not available at the specified date!\nPlease check the transfer schedule again!");
                            }
                        }
                    }
                    Transfer transferNew = new Transfer(name, address, phone, description, startDate, endDate);
                    transferNew.Animal = animal;

                    transferManagement.SaveTransfer(transferNew);
                    if (transferNew.StartDate <= DateTime.Now && transferNew.EndDate >= DateTime.Now)
                    {
                        animalManagement.ChangeAnimalAvailability(animal.Id, "Transfered");
                    }
                    FillTransfersList();
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

                lbxRelationshipsMain.Items.Clear();

                foreach(Animal animaltemp in animalManagement.GetParents(animal.Id))
                {
                    lbxRelationshipsMain.Items.Add($"Parent - {animaltemp}:{animaltemp.Id}");
                }
                foreach(Animal animaltemp in animalManagement.GetMates(animal.Id, animal.Gender))
                {
                    lbxRelationshipsMain.Items.Add($"Mate - {animaltemp}:{animaltemp.Id}");
                }
                foreach (Animal animaltemp in animalManagement.GetChildren(animal.Id))
                {
                    lbxRelationshipsMain.Items.Add($"Child - {animaltemp}:{animaltemp.Id}");
                }
                foreach (Animal animaltemp in animalManagement.GetSiblings(animal.Id))
                {
                    lbxRelationshipsMain.Items.Add($"Sibling - {animaltemp}:{animaltemp.Id}");
                }

                groupBoxSearchAnimal.Visible = false;
                groupBoxRelationship.Visible = true;
                lvwAnimals.Enabled = false;
                tbxMainAnimalRelationship.DataBindings.Clear();
                tbxMainAnimalRelationship.DataBindings.Add("Text", animal, "Name");
                cbxRelationshipType.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddNewRelationship_Click(object sender, EventArgs e)
        {
            switch (cbxRelationshipType.SelectedIndex)
            {
                case 0:
                    {
                        Result<ParentRelationship> result = animalManagement.AddParentChildRelationship(
                            ((Animal)lvwAnimals.SelectedItems[0].Tag),
                            ((Animal)cbxOtherAnimalRelationship.SelectedItem));
                        if (result.Success)
                        {
                        btnCancelRelationship_Click(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show($"{result._message}");
                        }
                        break;
                    }
                case 1:
                    {
                        Result<ParentRelationship> result = animalManagement.AddParentChildRelationship(
                            ((Animal)cbxOtherAnimalRelationship.SelectedItem),
                            ((Animal)lvwAnimals.SelectedItems[0].Tag));
                        if (result.Success)
                        {
                            btnCancelRelationship_Click(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show($"{result._message}");
                        }
                        break;
                    }
                case 2:
                    {
                        if(((Animal)cbxOtherAnimalRelationship.SelectedItem).Gender == "Male" &&
                            ((Animal)lvwAnimals.SelectedItems[0].Tag).Gender == "Female")
                        {
                            animalManagement.AddMateRelationship(
                                ((Animal)cbxOtherAnimalRelationship.SelectedItem).Id,
                                ((Animal)lvwAnimals.SelectedItems[0].Tag).Id);
                            btnCancelRelationship_Click(this, EventArgs.Empty);
                        }
                        else if (((Animal)cbxOtherAnimalRelationship.SelectedItem).Gender == "Female" &&
                            ((Animal)lvwAnimals.SelectedItems[0].Tag).Gender == "Male")
                        {
                            animalManagement.AddMateRelationship(
                                ((Animal)lvwAnimals.SelectedItems[0].Tag).Id,
                                ((Animal)cbxOtherAnimalRelationship.SelectedItem).Id);
                            btnCancelRelationship_Click(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("The mates must not be of the same gender.");
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Please select a realationship type.");
                        break;
                    }
            }
    
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
            string animal = lbxRelationshipsMain.Text;
            var animalsplit = animal.Split(":");
            Animal animalanimal = (Animal)lvwAnimals.SelectedItems[0].Tag;

            animalManagement.RemoveRelationship(Convert.ToInt32(animalsplit[1]), animalanimal.Id);
            btnCancelRelationship_Click(this, EventArgs.Empty);

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

            int? age = null;
            if (tbxAge.Text != "")
            {
                age = Convert.ToInt32(tbxAge.Text);
            }

            int? birthYear = null;
            if (age != null)
            {
                birthYear = DateTime.Now.AddYears((int)age * (-1)).Year;
            }

            searchedAnimals = animalManagement.GetSearchedAnimals(tbxName.Text, cbxAnimalSpeciesSearch.Text, cbxOrigin.Text, gender, availability, birthYear, cbxEndangerment.Text);
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
            cbxAnimalSpeciesSearch.Text = string.Empty;
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
            updateAnimalListview(animalManagement.GetAllAnimals("AnimalId"));
        }

        private void lvwAnimals_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Animal animal = (Animal)lvwAnimals.SelectedItems[0].Tag;
                AnimalDetails form = new AnimalDetails(animal.GetAnimalDetails(animal));
                form.ShowDialog();
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
            string option = "AnimalId";
            foreach (RadioButton rbtn in animalHistoryOrderBy)
            {
                if (rbtn.Checked)
                    option = rbtn.Text;
            }
            updateAnimalHistoryListview(animalManagement.GetAllAnimals(option));
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
            tbxAnimalForRelationship.DataBindings.Clear();
            //tbxAnimalForRelationship.Clear();
            Animal animal;
            try
            {
                string input = maskedtbxBirthDateAddAnimalForm.Text;
                DateTime date;

                // Try to parse the input string as a date
                if (DateTime.TryParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    // If the parsing is successful, format the date and update the text box
                    maskedtbxBirthDateAddAnimalForm.Text = date.ToString("MM/dd/yyyy");
                    maskedtbxBirthDateAddAnimalForm.SelectionStart = maskedtbxBirthDateAddAnimalForm.Text.Length;
                }
                string gender;
                if (rbtnMaleAddAnimal.Checked) gender = "Male";
                else if (rbtnFemaleAddAnimal.Checked) gender = "Female";
                else throw (new Exception("Please select a gender"));

                animal = new Animal(tbxNameAddAnimal.Text, gender, cbxAnimalSpecies.Text, date, (ORIGINCONTINENT)cbxOriginAddAnimal.SelectedItem, tbxAdditionalCommentsAddAnimal.Text, (ENDANGERMENT)cbxEndangermentAddAnimal.SelectedItem, (int)nudEnclosureAddAnimal.Value, "Available");
                animalManagement.AddUpdateAnimal(animal);

                tbxNameAddAnimal.Text = string.Empty;
                cbxAnimalSpecies.Text= string.Empty;
                cbxEndangermentAddAnimal.SelectedIndex = -1;
                cbxOriginAddAnimal.SelectedIndex = -1;
                maskedtbxBirthDateAddAnimalForm.Text = string.Empty;
                nudEnclosureAddAnimal.Value = 1;
                tbxAdditionalCommentsAddAnimal.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            tbxAnimalForRelationship.DataBindings.Add("Text", animal, "Name");
        }

        private void buttonAddRelationshipAddAnimal_Click(object sender, EventArgs e)
        {
            Binding binding = tbxAnimalForRelationship.DataBindings["Text"] ;
            Animal animal = (Animal)binding.DataSource;
            
            switch (cbRelationShipType.SelectedIndex)
            {
                case 0:
                    {
                        animalManagement.AddParentChildRelationship(
                            animal,
                            ((Animal)cbOtherAnimal.SelectedItem));
                        btnCancelRelationship_Click(this, EventArgs.Empty);
                        break;
                    }
                case 1:
                    {
                        animalManagement.AddParentChildRelationship(
                            ((Animal)cbOtherAnimal.SelectedItem),
                            animal);
                        btnCancelRelationship_Click(this, EventArgs.Empty);
                        break;
                    }
                case 2:
                    {
                        if (((Animal)cbOtherAnimal.SelectedItem).Gender == "Male" &&
                            animal.Gender == "Female")
                        {
                            animalManagement.AddMateRelationship(
                                ((Animal)cbOtherAnimal.SelectedItem).Id,
                                animal.Id);
                            btnCancelRelationship_Click(this, EventArgs.Empty);
                        }
                        else if (((Animal)cbOtherAnimal.SelectedItem).Gender == "Female" &&
                            animal.Gender == "Male")
                        {
                            animalManagement.AddMateRelationship(
                                animal.Id,
                                ((Animal)cbOtherAnimal.SelectedItem).Id);
                            btnCancelRelationship_Click(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("The mates must not be of the same gender.");
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Please select a realationship type.");
                        break;
                    }
            }
        }

        private void cbxRelationshipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Binding binding = tbxMainAnimalRelationship.DataBindings["Text"];

            Animal animal = (Animal)binding.DataSource;

            cbxOtherAnimalRelationship.Items.Clear();
            cbxOtherAnimalRelationship.Text = "";

            List<Animal> animalsInSpecies = animalManagement.OtherInSpeciesSearch(animal.Id, animal.Species);
            switch (cbxRelationshipType.SelectedIndex)
            {
                case 0:
                    //children
                    animalsInSpecies.Where(a => a.Birthday > animal.Birthday).ToList().ForEach(a => cbxOtherAnimalRelationship.Items.Add(a));
                    break;
                case 1:
                    //parents
                    List<Animal> parents = animalManagement.GetParents(animal.Id);
                    if(parents.Count == 1 && parents[0].Gender == "Male")
                    {
                        animalsInSpecies.Where(a => a.Birthday < animal.Birthday && a.Gender == "Female").ToList().ForEach(a => cbxOtherAnimalRelationship.Items.Add(a));
                    }
                    else if (parents.Count == 1 && parents[0].Gender == "Female")
                    {
                        animalsInSpecies.Where(a => a.Birthday < animal.Birthday && a.Gender == "Male").ToList().ForEach(a => cbxOtherAnimalRelationship.Items.Add(a));
                    }
                    else if (parents.Count == 2)
                    {
                        //dont show any since already has maximum parents
                    }
                    else
                    {
                        animalsInSpecies.Where(a => a.Birthday < animal.Birthday).ToList().ForEach(a => cbxOtherAnimalRelationship.Items.Add(a));
                    }
                    break;
                case 2:
                    //mates
                    animalsInSpecies.Where(a => a.Gender != animal.Gender).ToList().ForEach(a => cbxOtherAnimalRelationship.Items.Add(a));
                    break;
            }
        }
    


        private void cbRelationShipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Binding binding = tbxAnimalForRelationship.DataBindings["Text"];
            Animal animal = (Animal)binding.DataSource;

            List<Animal> animalsInSpecies = animalManagement.OtherInSpeciesSearch(animal.Id, animal.Species);

            cbOtherAnimal.Items.Clear();
            cbOtherAnimal.Text = "";


            switch (cbRelationShipType.SelectedIndex)
            {
                case 0:
                    //children
                    animalsInSpecies.Where(a => a.Birthday > animal.Birthday).ToList().ForEach(a => cbOtherAnimal.Items.Add(a));
                    break;
                case 1:
                    //parents
                    animalsInSpecies.Where(a => a.Birthday < animal.Birthday).ToList().ForEach(a => cbOtherAnimal.Items.Add(a));
                    break;
                case 2:
                    //mates
                    animalsInSpecies.Where(a => a.Gender != animal.Gender).ToList().ForEach(a => cbOtherAnimal.Items.Add(a));
                    break;
            }
        }

        //
        //TAB TRANSFER ANIMALS
        //

        private void FillTransfersList()
        {
            List<Transfer> transfers = transferManagement.GetAllTransfersNoAnimal();
            //foreach (Transfer transfer in transfers)
            //{
            //    if (transfer.StartDate <= DateTime.Now && transfer.EndDate >= DateTime.Now)
            //        transferManagement.ChangeAnimalAvailability(transfer.TransferId, "Transferred");
            //    else 
            //        transferManagement.ChangeAnimalAvailability(transfer.TransferId, "Available");                 
            //}
            lvwCurrentTransfers.Items.Clear();
            lvwFutureTransfers.Items.Clear();
            lvwPastTransfers.Items.Clear();
            foreach (Transfer transfer in transfers)
            {
                if (transfer.StartDate <= DateTime.Now && transfer.EndDate >= DateTime.Now)
                {
                    ListViewItem item = new ListViewItem();
                    Animal animal = animalManagement.GetAnimalByID(transfer.AnimalId);
                    item.Text = animal.Name;
                    item.Tag = transfer;
                    item.SubItems.Add(animal.Species);

                    string formattedDate = transfer.StartDate.ToString("dd MMMM yyyy");
                    item.SubItems.Add(formattedDate);

                    string formattedDate2 = transfer.EndDate.ToString("dd MMMM yyyy");
                    item.SubItems.Add(formattedDate2);
                    item.SubItems.Add(transfer.ZooName);
                    lvwCurrentTransfers.Items.Add(item);

                    //transferManagement.ChangeAnimalAvailability(transfers[i].TransferId, "Transfered");
                }
                else if (transfer.StartDate < DateTime.Now && transfer.EndDate < DateTime.Now)
                {
                    ListViewItem item = new ListViewItem();
                    Animal animal = animalManagement.GetAnimalByID(transfer.AnimalId);
                    item.Text = animal.Name;
                    item.Tag = transfer;
                    item.SubItems.Add(animal.Species);
                    string formattedDate = transfer.StartDate.ToString("dd MMMM yyyy");
                    item.SubItems.Add(formattedDate);

                    string formattedDate2 = transfer.EndDate.ToString("dd MMMM yyyy");
                    item.SubItems.Add(formattedDate2);
                    item.SubItems.Add(transfer.ZooName);
                    lvwPastTransfers.Items.Add(item);


                    //if (transfers[i].AnimalId != transfers[i - 1].AnimalId)
                    //    transferManagement.ChangeAnimalAvailability(transfers[i].TransferId, "Available");
                    //else
                    //    continue;
                }
                else if (transfer.StartDate > DateTime.Now && transfer.EndDate > DateTime.Now)
                {
                    ListViewItem item = new ListViewItem();
                    Animal animal = animalManagement.GetAnimalByID(transfer.AnimalId);
                    item.Text = animal.Name;
                    item.Tag = transfer;
                    item.SubItems.Add(animal.Species);
                    string formattedDate = transfer.StartDate.ToString("MMMM dd yyyy");
                    item.SubItems.Add(formattedDate);

                    string formattedDate2 = transfer.EndDate.ToString("MMMM dd yyyy");
                    item.SubItems.Add(formattedDate2);
                    item.SubItems.Add(transfer.ZooName);
                    lvwFutureTransfers.Items.Add(item);
                }
            }
        }

        private void cbxAnimalSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string species = cbxAnimalSpecies.Text;
            string origin = animalManagement.GetOrginEnclosureOfSpecies(species, out int enclosureNumber);

            cbxOriginAddAnimal.Text = origin;
            nudEnclosureAddAnimal.Value = enclosureNumber;
        }

        private void btnTransferMoreDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Transfer transfer = (Transfer)lvwCurrentTransfers.SelectedItems[0].Tag;
                FillInTransferDetails(transfer);
                currentTransfer = transfer;
                cbNewEndDate.Checked = false;
                cnNewStartDate.Checked = false;
            }
            catch(Exception)
            {
                return;
            } 
        }

        private void FillInTransferDetails(Transfer transfer)
        {
            Animal animal = animalManagement.GetAnimalByID(transfer.AnimalId);
            labelInputAnimalName.Text = animal.Name;
            labelInputAnimalSpecies.Text = animal.Species;
            labelInputAnimalGender.Text = animal.Gender;
            labelInputZooName.Text = transfer.ZooName;
            labelInputZooAddress.Text = transfer.ZooAddress;
            labelInputZooPhone.Text = transfer.ZooPhone;
            string formattedDate = transfer.StartDate.ToString("MMMM dd yyyy");
            labelInputStartDate.Text = formattedDate;
            string formattedDate2 = transfer.EndDate.ToString("MMMM dd yyyy");
            labelInputEndDate.Text = formattedDate2;
            labelInputComments.Text = transfer.Description;

            groupBoxTransferDetails.Visible = true;
            btnConfirmTransferDetails.Visible = true;
        }

        private void btnConfirmTransferDetails_Click(object sender, EventArgs e)
        {
            if(cbNewEndDate.Checked)
            {
                currentTransfer.EndDate = dtpNewEndDate.Value;
            }
            else if(cnNewStartDate.Checked)
            {
                currentTransfer.StartDate = dtpNewStartDate.Value;
            }
            transferManagement.UpdateTransferDates(currentTransfer.TransferId, currentTransfer.StartDate, currentTransfer.EndDate);
            
            if(currentTransfer.StartDate.Date <= DateTime.Now.Date && currentTransfer.EndDate.Date > DateTime.Now.Date)
            {
                transferManagement.ChangeAnimalAvailability(currentTransfer.TransferId, "Transferred");
            }
            else if(currentTransfer.EndDate.Date == DateTime.Now.Date)
            {
                transferManagement.ChangeAnimalAvailability(currentTransfer.TransferId, "Available");
            }
            else
            {
                transferManagement.ChangeAnimalAvailability(currentTransfer.TransferId, "Available");
            }
            groupBoxTransferDetails.Visible = false;
            btnConfirmTransferDetails.Visible = false;
            cbNewEndDate.Checked = false;
            cnNewStartDate.Checked = false;
            currentTransfer = null;
            FillTransfersList();
        }

        private void cnNewStartDate_CheckedChanged(object sender, EventArgs e)
        {
            if(cnNewStartDate.Checked)
            {
                dtpNewStartDate.Enabled = true;
            }
            else
            {
                dtpNewStartDate.Value = DateTime.Now.Date;
                dtpNewStartDate.Enabled = false;
            }
        }

        private void cbNewEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNewEndDate.Checked)
            {
                dtpNewEndDate.Enabled = true;
            }
            else
            {
                dtpNewStartDate.Value = DateTime.Now.Date;
                dtpNewEndDate.Enabled = false;
            }
        }

        private void btnMoreDetailsFutureTransfers_Click(object sender, EventArgs e)
        {
            try
            {
                Transfer transfer = (Transfer)lvwFutureTransfers.SelectedItems[0].Tag;
                FillInTransferDetails(transfer);
                currentTransfer = transfer;
                cbNewEndDate.Checked = false;
                cnNewStartDate.Checked = false;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnMoreDetailsPastTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Transfer transfer = (Transfer)lvwPastTransfers.SelectedItems[0].Tag;
                FillInTransferDetails(transfer);
                currentTransfer = transfer;
                cbNewEndDate.Checked = false;
                cnNewStartDate.Checked = false;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
