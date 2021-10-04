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
    public partial class Derivatives : Form
    {
        public Derivatives()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Derivative derivative = new Derivative();
            derivative.ShowDialog();
        }
    }
}
