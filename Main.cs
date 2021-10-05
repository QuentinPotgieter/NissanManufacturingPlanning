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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void managePlantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plants plants = new Plants();
            plants.ShowDialog();
        }

        private void modelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Models models = new Models();
            models.ShowDialog();
        }

        private void derivativesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Derivatives derivatives = new Derivatives();
            derivatives.ShowDialog();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colors colors = new Colors();
            colors.ShowDialog();
        }

        private void motorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motors motors = new Motors();
            motors.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesRequest salesRequest = new SalesRequest();
            salesRequest.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductionPlan productionPlan = new ProductionPlan();
            productionPlan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Fill datagrids
        }
    }
}
