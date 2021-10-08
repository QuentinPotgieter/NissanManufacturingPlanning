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
    public partial class MotorsForm : Form
    {
        public MotorsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MotorForm motor = new MotorForm();
            motor.ShowDialog();

            if (motor.fMotor != null)
            {
                new MainForm().SqlInsert("INSERT INTO Motor (Size, Type, Description) VALUES (" + motor.fMotor.getSize().ToString() + ",'" + motor.fMotor.motorType + "','" + motor.fMotor.getDescription() + "')");
                new MainForm().QuerySelectAll("Motor", dgvMotors);
            }
        }

        private void Motors_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("Motor", dgvMotors);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = dgvMotors.Rows[dgvMotors.SelectedCells[0].RowIndex].Cells["MotorID"].Value.ToString();
            string index = dgvMotors.Rows[dgvMotors.SelectedCells[0].RowIndex].Cells["MotorID"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                new MainForm().SqlDelete("DELETE FROM Motor WHERE MotorID = " + index);
            }
            new MainForm().QuerySelectAll("Motor", dgvMotors);
        }
    }
};
