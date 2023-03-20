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
    public partial class PopupAnimalTransfer : Form
    {
        public PopupAnimalTransfer()
        {
            InitializeComponent();
        }

        private void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
