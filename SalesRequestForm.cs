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
    public partial class SalesRequestForm : Form
    {
        public SalesRequest ssr;
        public SalesRequestForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (numQuantity.Value == 0)
            {
                MessageBox.Show("Please enter a quantity");
                return;
            }
            if (cbbDerivative.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a derivative");
                return;
            }

            int length = cbbDerivative.SelectedItem.ToString().IndexOf("-")-1;
            DateTime date       = dateRequired.Value;
            int      quantity   = Convert.ToInt32(numQuantity.Value);
            string   derivative = cbbDerivative.SelectedItem.ToString().Substring(0,length);

            ssr = new SalesRequest(quantity,Convert.ToInt32(derivative),1,date);

            if (ssr != null)
            {
                new MainForm().SqlInsert("INSERT INTO SalesRequest (DateRequired, DerivativeID, Quantity, PlanID) VALUES ('" + ssr.getDateRequired().ToString("yyyy-MM-dd") + "'," + ssr.getdDerivativeId().ToString() + "," + ssr.getQuantity().ToString() + ","+ssr.getPlanId()+")");
            }
            MainForm.ActiveForm.Show();
            this.Close();
        }

        private void SalesRequest_Shown(object sender, EventArgs e)
        {
            //load derivatives into combobox
            List<string> deriv = new MainForm().FillComboBox("SELECT DerivativeID FROM VehicleDerivative");
            List<string> derivTwo = new MainForm().FillComboBox("SELECT Name FROM VehicleDerivative");
            for (int i = 0; i < deriv.Count; i++)
            {
                cbbDerivative.Items.Add(deriv[i]+" - "+derivTwo[i]);
            }
        }
    }
}
