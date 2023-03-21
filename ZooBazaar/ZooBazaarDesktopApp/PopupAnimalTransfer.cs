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
using ZooBazaarLogicLibrary.Animals;

namespace ZooBazaarDesktopApp
{
    public partial class PopupAnimalTransfer : Form
    {
        Animal animal;
        AnimalManagement animalManagement;
        TransferManagement transferManagement;
        FormDataValidator formDataValidator;
        public PopupAnimalTransfer(Animal a, AnimalManagement am)
        {
            InitializeComponent();
            transferManagement = new TransferManagement();
            formDataValidator = new FormDataValidator();
            tbxAnimalTransfer.Text = $"{a.Name} - {a.Species}";
            animal = a;
        }

        private void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            string name = tbxZooNameTransfer.Text;
            string address = tbxAddressTransfer.Text;
            string description = tbxComments.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            if (formDataValidator.IsValidTransfer(name, address, description, startDate, endDate))
            {
                Transfer transfer = new Transfer(name, address, description, startDate, endDate, animal);
                animal.Availability = "Transferred";
                animal.Transfer = transfer;
                transferManagement.AddTransferToList(transfer);
                MessageBox.Show("Transfer has been successfully created!");
                this.Close();
            }
            else
                MessageBox.Show("Transfer couldn't be created!");
        }
    }
}
