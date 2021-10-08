using NissanManufacturingPlanning.Classes;
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
            if (plant.fPlant != null)
            {
                new MainForm().SqlInsert("INSERT INTO Plant (Name, Country, Address, Rate, Uptime, ShiftDuration) VALUES (" + plant.fPlant.getDescription() + ")");
                new MainForm().QuerySelectAll("Plant", dgvPlants);
            }
        }

        private void Plants_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("Plant", dgvPlants);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvPlants.Rows.Count == 0)//Null/Empty Datagridview checking on Update
            {
                MessageBox.Show("No Plants to Update");
            }else
            {
                PlantForm plant = new PlantForm();
                plant.btnAdd.Text = "Update Plant";
                plant.tbxName.Text = dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["Name"].Value.ToString();
                plant.tbxCountry.Text = dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["Country"].Value.ToString();
                plant.tbxAddress.Text = dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["Address"].Value.ToString();
                plant.numDuration.Value = Convert.ToInt32(dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["ShiftDuration"].Value.ToString()) / 60;
                plant.numRate.Value = Convert.ToInt32(dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["Rate"].Value.ToString());
                plant.numUptime.Value = Convert.ToInt32(dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["Uptime"].Value.ToString());
                plant.ShowDialog();

                string index = dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["PlantID"].Value.ToString();

                if (plant.fPlant != null)
                {
                    new MainForm().SqlUpdate("UPDATE Plant SET Name = '" + plant.fPlant.getName() + "', Country = '" + plant.fPlant.getCountryId() + "', Address = '" + plant.fPlant.getAddress() + "', Rate = " + plant.fPlant.getRate().ToString() + ", Uptime = " + plant.fPlant.getAvailablity().ToString() + ", ShiftDuration = " + plant.fPlant.getShiftDuration().ToString() + " WHERE PlantID = '" + index + "'");
                    new MainForm().QuerySelectAll("Plant", dgvPlants);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (dgvPlants.Rows.Count == 0)//Null checking on Remove
            {
                MessageBox.Show("No Plants to Remove");
            }
            else
            {
                string name = dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["Name"].Value.ToString();
                string index = dgvPlants.Rows[dgvPlants.SelectedCells[0].RowIndex].Cells["PlantID"].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    new MainForm().SqlDelete("DELETE FROM Plant WHERE PlantID = " + index);
                }
                new MainForm().QuerySelectAll("Plant", dgvPlants);
            }
            
        }
    }
}
