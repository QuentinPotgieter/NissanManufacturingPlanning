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
    public partial class Plant : Form
    {
        public Plant()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string country = tbxCountry.Text;
            string address = tbxAddress.Text;
            decimal rate = numRate.Value;
            decimal uptime = numUptime.Value;
            decimal duration = numDuration.Value;

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

            Plants.ActiveForm.Show();
            this.Close();
        }
    }
}
