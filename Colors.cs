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
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            color.ShowDialog();
        }

        private void Colors_Shown(object sender, EventArgs e)
        {
            new Main().QuerySelectAll("Colors", dgvColors);
        }
    }
}
