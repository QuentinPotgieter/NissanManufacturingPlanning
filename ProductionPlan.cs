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
    public partial class ProductionPlan : Form
    {
        public ProductionPlan()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string plant = cbbPlant.SelectedIndex.ToString();
            decimal rate = numRate.Value;
            decimal uptime = numUptime.Value;
            decimal duration = numDuration.Value;

            //input validation
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

            MainForm.ActiveForm.Show();
            this.Close();
        }

        private void ProductionPlan_Shown(object sender, EventArgs e)
        {
            //Load into combobox
            List<string> plant = new MainForm().FillComboBox("SELECT * FROM Plant");
            for (int i = 0; i < plant.Count; i++)
            {
                cbbPlant.Items.Add(plant[i]);
            }
        }
    }
}
