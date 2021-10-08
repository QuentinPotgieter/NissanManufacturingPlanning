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
            int length = cbbPlant.SelectedItem.ToString().IndexOf("-")-1;
            string name = tbxName.Text;
            string plant = cbbPlant.SelectedItem.ToString().Substring(0,length);
            int rate = Convert.ToInt32(numRate.Value);
            int uptime = Convert.ToInt32(numUptime.Value);
            int duration = Convert.ToInt32(numDuration.Value)*60;

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

            new MainForm().SqlInsert("INSERT INTO [ProductionPlan] (PlantID, Name, Rate, Uptime, ShiftDuration) VALUES ('"+plant+"','"+name+"',"+rate.ToString()+","+uptime.ToString()+","+duration.ToString()+")");

            MainForm.ActiveForm.Show();
            this.Close();
        }

        private void ProductionPlan_Shown(object sender, EventArgs e)
        {
            //Load into combobox
            List<string> plant = new MainForm().FillComboBox("SELECT PlantID FROM Plant");
            List<string> plantTwo = new MainForm().FillComboBox("SELECT Name FROM Plant");
            for (int i = 0; i < plant.Count; i++)
            {
                cbbPlant.Items.Add(plant[i]+" - "+plantTwo[i]);
            }
        }
    }
}
