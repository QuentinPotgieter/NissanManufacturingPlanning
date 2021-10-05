using System;
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
    public partial class PlantsForm : Form
    {
        public PlantsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlantForm plant = new PlantForm();
            plant.ShowDialog();
        }

        private void Plants_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("Plant", dgvPlants);
        }
    }
}
