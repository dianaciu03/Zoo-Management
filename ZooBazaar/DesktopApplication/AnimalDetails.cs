﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class AnimalDetails : Form
    {
        public AnimalDetails(string details)
        {
            InitializeComponent();
            label2.Text = details;
        }
    }
}
