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
    public partial class PlantForm : Form
    {
        public Plant fPlant;
        public PlantForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string country = tbxCountry.Text;
            string address = tbxAddress.Text;
            int rate = Convert.ToInt32(numRate.Value);
            int uptime = Convert.ToInt32(numUptime.Value);
            int duration = Convert.ToInt32(numDuration.Value);

            // Input validation
            if (name == "" || country == "" || address == "" || rate == 0 || uptime == 0 || duration == 0)
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            if (name.Length > 50 || country.Length > 50 || address.Length > 50)
            {
                MessageBox.Show("The name you have entered is too long (Max 50 Characters)");
                return;
            }

            fPlant = new Plant(rate,uptime,duration,name,country, address);

            PlantsForm.ActiveForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxCountry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
