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

            new MainForm().SqlInsert("INSERT INTO Plant (Name, Country, Address, Rate, Uptime, ShiftDuration) VALUES (" +
                plant.fPlant.getDescription()+")") ;

            new MainForm().QuerySelectAll("Plant", dgvPlants);
        }

        private void Plants_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("Plant", dgvPlants);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlantForm plant = new PlantForm();
            plant.ShowDialog();

            string index = dgvPlants.SelectedRows[0].Cells[1].Value.ToString();

            new MainForm().SqlUpdate("UPDATE Plant SET Name = '"+plant.fPlant.getName()+"', Country = '"+plant.fPlant.getCountryId()+"', Address = '"+plant.fPlant.getAddress()+"', Rate = "+plant.fPlant.getRate().ToString()+", Uptime = "+ plant.fPlant.getAvailablity().ToString()+", ShiftDuration = "+plant.fPlant.getShiftDuration().ToString()+" WHERE PlantID = '"+index+"'");

            new MainForm().QuerySelectAll("Plant", dgvPlants);
        }
    }
}
