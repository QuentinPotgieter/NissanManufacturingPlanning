﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NissanManufacturingPlanning
{
    public partial class ModelsForm : Form
    {
        public ModelsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelForm model = new ModelForm();
            model.ShowDialog();
        }

        private void Models_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("VehicleModel", dgvModel);
        }
    }
}