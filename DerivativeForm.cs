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
            int length = cbbMotor.Text.IndexOf("-") - 1;
            string name = tbxName.Text;
            string color = cbbColor.SelectedItem.ToString();
            int motor = Convert.ToInt32(cbbMotor.SelectedItem.ToString().Substring(0,length));
            bool sunroof = cbSunRoof.Checked;
            bool autogearbox = cbAutomatic.Checked;
            bool electricwindows = cbElectricWindows.Checked;
            bool leather = cbLeather.Checked;

            // Input validation
            if (name == "" || color == "" || cbbModel.SelectedIndex == -1 || cbbMotor.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a value in each field");
                return;
            }
            if (name.Length > 50 || color.Length > 50)
            {
                MessageBox.Show("The name you have entered is too long (Max 50 Characters)");
                return;
            }

            length = cbbModel.Text.IndexOf("-") - 1;

            int model = Convert.ToInt32(cbbModel.SelectedItem.ToString().Substring(0,length));

            derivative = new Derivative(model, name, color, electricwindows, autogearbox, sunroof, leather, motor);
            derivative.setName(name);

            DerivativesForm.ActiveForm.Show();
            this.Close();
        }

        private void DerivativeForm_Shown(object sender, EventArgs e)
        {
            //Load comboboxes
            List<string> color = new MainForm().FillComboBox("SELECT Color FROM Colors");
            for (int i = 0; i < color.Count; i++)
            {
                cbbColor.Items.Add(color[i]);
            }
            List<string> motor = new MainForm().FillComboBox("SELECT MotorID FROM Motor");
            List<string> motorTwo = new MainForm().FillComboBox("SELECT Description FROM Motor");
            for (int i = 0; i<motor.Count; i++)
            {
                cbbMotor.Items.Add(motor[i] + " - "+ motorTwo[i]);
            }
            List<string> model = new MainForm().FillComboBox("SELECT ModelID FROM VehicleModel");
            List<string> modelTwo = new MainForm().FillComboBox("SELECT ModelName FROM VehicleModel");
            for (int i = 0; i < model.Count; i++)
            {
                cbbModel.Items.Add(model[i] + " - " + modelTwo[i]);
            }
        }
    }
}
