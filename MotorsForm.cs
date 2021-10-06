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

            //Weird error
            new MainForm().SqlInsert("INSERT INTO Motor (Size, Type, Description) VALUES ("+motor.fMotor.getSize().ToString()+",'"+ motor.fMotor.GetType()+"','"+ motor.fMotor.getDescription()+ "')");

            new MainForm().QuerySelectAll("Motor", dgvMotors);
        }

        private void Motors_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("Motor", dgvMotors);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
};
