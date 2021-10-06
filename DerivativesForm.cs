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

            new MainForm().SqlInsert("INSERT INTO VehicleDerivative (ModelID, Name, Color, ElectricWindows, AutomaticGearbox, SunRoof, LeatherSeats) VALUES ("+derivative.derivative.getModelId().ToString()+",'"+ derivative.derivative.getName()+"','"+ derivative.derivative.getColorId()+"',"+ derivative.derivative.isElectricWindows().ToString()+","+ derivative.derivative.isAutomaticGearbox()+","+derivative.derivative.isSunRoof()+","+ derivative.derivative.isLeatherSeats()+")");
        }

        private void Derivatives_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("VehicleDerivative", dgvVehicleDerivative);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = dgvVehicleDerivative.Rows[dgvVehicleDerivative.SelectedCells[0].RowIndex].Cells["Name"].Value.ToString();
            string index = dgvVehicleDerivative.Rows[dgvVehicleDerivative.SelectedCells[0].RowIndex].Cells["DerivativeID"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                new MainForm().SqlDelete("DELETE FROM VehicleDerivative WHERE Derivative = " + index);
            }
            new MainForm().QuerySelectAll("VehicleDerivative", dgvVehicleDerivative);
        }
    }
}
