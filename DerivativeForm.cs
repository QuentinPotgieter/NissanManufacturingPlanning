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
    public partial class DerivativeForm : Form
    {

        public Derivative derivative;
        public DerivativeForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string color = cbbColor.SelectedItem.ToString();
            string motor = cbbMotor.SelectedItem.ToString();
            int model = Convert.ToInt32(cbbModel.SelectedItem.ToString());
            bool sunroof = cbSunRoof.Checked;
            bool autogearbox = cbAutomatic.Checked;
            bool electricwindows = cbElectricWindows.Checked;
            bool leather = cbLeather.Checked;

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

            
            derivative = new Derivative(model, name, color, electricwindows, autogearbox, sunroof, leather);
            derivative.setName(name);

            DerivativesForm.ActiveForm.Show();
            this.Close();
        }

        private void DerivativeForm_Shown(object sender, EventArgs e)
        {
            //Load comboboxes
            List<string> color = new MainForm().FillComboBox("SELECT * FROM Colors", cbbColor);
            for (int i = 0; i < color.Count; i++)
            {
                cbbMotor.Items.Add(color[i]);
            }
            List<string> motor = new MainForm().FillComboBox("SELECT * FROM Motor", cbbMotor);
            for(int i = 0; i<motor.Count; i++)
            {
                cbbMotor.Items.Add(motor[i]);
            }
            List<string> model = new MainForm().FillComboBox("SELECT * FROM VehicleModel", cbbModel);
            for (int i = 0; i < model.Count; i++)
            {
                cbbMotor.Items.Add(model[i]);
            }
        }
    }
}
