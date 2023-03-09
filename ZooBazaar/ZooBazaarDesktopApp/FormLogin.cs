using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazaarDesktopApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch (tbxLoginEmail.Text)
            {
                case ("animal"):
                    this.Hide();
                    FormAnimalAdministration formAnimalManagement = new FormAnimalAdministration();
                    formAnimalManagement.ShowDialog();
                    break;
                case ("employee"):
                    this.Hide();
                    FormHRAdministration formHRManagement = new FormHRAdministration();
                    formHRManagement.ShowDialog();
                    break;

            }
            this.Show();
            tbxLoginEmail.Clear();
            tbxLoginPassword.Clear();
        }
    }
}
