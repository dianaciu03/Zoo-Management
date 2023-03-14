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
        public FormAnimalAdministration()
        {
            InitializeComponent();
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
    }
}
