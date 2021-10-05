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
        public SalesRequestForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = dateRequired.Value;
            decimal quantity = numQuantity.Value;
            string derivative = cbbDerivative.SelectedIndex.ToString();

            MainForm.ActiveForm.Show();
            this.Close();
        }

        private void SalesRequest_Shown(object sender, EventArgs e)
        {
            //load derivatives into combobox
        }
    }
}
