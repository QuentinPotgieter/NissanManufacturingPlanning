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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            richTextBox6.AppendText("\nQuentin Potgieter - 33361908");
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox6.BringToFront();
            richTextBox6.Text = ("THE TEAM:");
            timer1.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            richTextBox6.AppendText("\nDehan Lenting - 34535802");
            timer3.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            richTextBox6.AppendText("\nLouis Muller - 26994259");
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            richTextBox6.AppendText("\nMichael Hanekom - 30808065");
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            richTextBox6.AppendText("\nPhillip Swanepoel - 29903599");
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            button1.Visible = false;
            richTextBox6.Text = ("");
            richTextBox6.SendToBack();
        }
    }
}
