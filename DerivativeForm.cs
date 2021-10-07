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

        public Derivative derivative = null;
        public DerivativeForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string color = cbbColor.SelectedItem.ToString();
            string motor = cbbMotor.SelectedItem.ToString();
            bool sunroof = cbSunRoof.Checked;
            bool autogearbox = cbAutomatic.Checked;
            bool electricwindows = cbElectricWindows.Checked;
            bool leather = cbLeather.Checked;

            // Input validation
            if (name == "" || color == "" || motor == "" || cbbModel.Text == "")
            {
                MessageBox.Show("Please enter a value in each field");
                return;
            }
            if (name.Length > 50 || color.Length > 50 || motor.Length > 50)
            {
                MessageBox.Show("The name you have entered is too long (Max 50 Characters)");
                return;
            }

            int length = cbbModel.Text.IndexOf("-") - 1;

            int model = Convert.ToInt32(cbbModel.SelectedItem.ToString().Substring(0,length));

            derivative = new Derivative(model, name, color, electricwindows, autogearbox, sunroof, leather);
            derivative.setName(name);

            DerivativesForm.ActiveForm.Show();
            this.Close();
        }

        private void DerivativeForm_Shown(object sender, EventArgs e)
        {
            //Load comboboxes
            List<string> color = new MainForm().FillComboBox("SELECT Color FROM Colors", cbbColor);
            for (int i = 0; i < color.Count; i++)
            {
                cbbColor.Items.Add(color[i]);
            }
            List<string> motor = new MainForm().FillComboBox("SELECT MotorID FROM Motor", cbbMotor);
            List<string> motorTwo = new MainForm().FillComboBox("SELECT Description FROM Motor", cbbMotor);
            for (int i = 0; i<motor.Count; i++)
            {
                cbbMotor.Items.Add(motor[i] + " - "+ motorTwo[i]);
            }
            List<string> model = new MainForm().FillComboBox("SELECT ModelID FROM VehicleModel", cbbModel);
            List<string> modelTwo = new MainForm().FillComboBox("SELECT ModelName FROM VehicleModel", cbbMotor);
            for (int i = 0; i < model.Count; i++)
            {
                cbbModel.Items.Add(model[i] + " - " + modelTwo[i]);
            }
        }
    }
}
