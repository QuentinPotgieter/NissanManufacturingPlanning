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
    }
}
