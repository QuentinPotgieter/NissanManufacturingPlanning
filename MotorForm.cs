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
    public partial class MotorForm : Form
    {
        public Motor fMotor = null;
        public MotorForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numSize.Value) == 0 || cbbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a value in each field");
                return;
            }

            string mType = cbbType.Text;
            string description = tbxDesc.Text;
            int size = Convert.ToInt32(numSize.Value);

            fMotor = new Motor(size,mType,description);

            MotorsForm.ActiveForm.Show();
            this.Close();
        }
    }
}
