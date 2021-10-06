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
            int rate = (int)numRate.Value;
            int uptime = (int)numUptime.Value;
            int duration = (int)numDuration.Value;

            // Input validation
            if (name == null)
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            if (name.Length > 50)
            {
                MessageBox.Show("The name you have entered is too long (Max 50 Characters)");
                return;
            }
            if (country == null)
            {
                MessageBox.Show("Please enter a country");
                return;
            }
            if (country.Length > 50)
            {
                MessageBox.Show("The country you have entered is too long (Max 50 Characters)");
                return;
            }
            if (address == null)
            {
                MessageBox.Show("Please enter a address");
                return;
            }
            if (address.Length > 50)
            {
                MessageBox.Show("The address you have entered is too long (Max 50 Characters)");
                return;
            }

            fPlant = new Plant(rate,uptime,duration,name,country, address);

            PlantsForm.ActiveForm.Show();
            this.Close();
        }
    }
}
