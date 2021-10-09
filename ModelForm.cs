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
        public Model fmodel = null;
        public ModelForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Input validation
            if (tbxName.Text == "")
            {
                MessageBox.Show("Please enter a value for each field");
                return;
            }
            if (tbxName.Text.Length > 50)
            {
                MessageBox.Show("The name you have entered is too long (Max 50 Characters)");
                return;
            }
            
            string name = tbxName.Text;
            int year = Convert.ToInt32(numYear.Value);


            fmodel = new Model(name,year);
            
            ModelsForm.ActiveForm.Show();
            this.Close();
        }

        private void ModelForm_Shown(object sender, EventArgs e)
        {

        }
    }
}
