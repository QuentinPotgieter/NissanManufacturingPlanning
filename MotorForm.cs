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
        public Motor fMotor;
        public MotorForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mType = cbbType.SelectedItem.ToString();
            string description = txtDesc.Text;
            int size = (int)numSize.Value;

            fMotor = new Motor(size,mType,description);

            MotorsForm.ActiveForm.Show();
            this.Close();
        }
    }
}
