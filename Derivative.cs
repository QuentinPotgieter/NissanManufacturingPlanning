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
    public partial class Derivative : Form
    {
        public Derivative()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string color = cbbColor.SelectedIndex.ToString();
            string motor = cbbMotor.SelectedIndex.ToString();
            string model = cbbModel.SelectedIndex.ToString();
            string sunroof = cbSunRoof.ToString();
            string autogearbox = cbAutomatic.ToString();
            string electricwindows = cbElectricWindows.ToString();
            string leather = cbLeather.ToString();

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

            new Main().SqlInsert("INSERT INTO VehicleDerivative (ModelID, Name, Color, ElectricWindows, AutomaticGearbox, SunRoof, LeatherSeats)" +
                                 " VALUES ("+
                                 new Main().QuotedStr(model) + "," +
                                 new Main().QuotedStr(name) + "," +
                                 new Main().QuotedStr(color) + "," +
                                 electricwindows + "," +
                                 autogearbox + "," +
                                 sunroof + "," +
                                 leather + "," +
                                 ")");

            Derivatives.ActiveForm.Show();
            this.Close();
        }
    }
}
