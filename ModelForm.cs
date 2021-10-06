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
    public partial class ModelForm : Form
    {
        public Model fmodel;
        public ModelForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int year = Convert.ToInt32(numYear.Value);
            int motor = Convert.ToInt32(cbbMotor.Text);

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

            fmodel = new Model(name,motor,year);

            
            ModelsForm.ActiveForm.Show();
            this.Close();
        }

        private void ModelForm_Shown(object sender, EventArgs e)
        {
            List<string> motor = new MainForm().FillComboBox("SELECT * FROM Motor", cbbMotor);
            for (int i = 0; i < motor.Count; i++)
            {
                cbbMotor.Items.Add(motor[i]);
            }
        }
    }
}
