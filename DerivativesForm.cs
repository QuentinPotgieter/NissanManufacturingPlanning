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
    public partial class DerivativesForm : Form
    {
        public DerivativesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DerivativeForm derivative = new DerivativeForm();
            derivative.ShowDialog();

            if (derivative.derivative != null)
            {
                new MainForm().SqlInsert("INSERT INTO VehicleDerivative (ModelID, Name, Color, ElectricWindows, AutomaticGearbox, SunRoof, LeatherSeats, MotorID) VALUES (" + derivative.derivative.getModelId().ToString() + ",'" + derivative.derivative.getName() + "','" + derivative.derivative.getColorId() + "'," + derivative.derivative.isElectricWindows().ToString() + "," + derivative.derivative.isAutomaticGearbox().ToString() + "," + derivative.derivative.isSunRoof().ToString() + "," + derivative.derivative.isLeatherSeats().ToString() +","+ derivative.derivative.getMotorId().ToString()+ ")");

                new MainForm().QuerySelectAll("VehicleDerivative", dgvVehicleDerivative);
            }
        }

        private void Derivatives_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("VehicleDerivative", dgvVehicleDerivative);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVehicleDerivative.Rows.Count == 0)//null checking for remove
            {
                MessageBox.Show("No Derivatives to remove");
            }
            else
            {
                string name = dgvVehicleDerivative.Rows[dgvVehicleDerivative.SelectedCells[0].RowIndex].Cells["Name"].Value.ToString();
                string index = dgvVehicleDerivative.Rows[dgvVehicleDerivative.SelectedCells[0].RowIndex].Cells["DerivativeID"].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    new MainForm().SqlDelete("DELETE FROM VehicleDerivative WHERE DerivativeID = " + index);
                }
                new MainForm().QuerySelectAll("VehicleDerivative", dgvVehicleDerivative);
            }
            
        }
    }
}
