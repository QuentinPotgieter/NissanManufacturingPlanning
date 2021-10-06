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
    public partial class ColorsForm : Form
    {
        public ColorsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorForm color = new ColorForm();
            color.ShowDialog();

            new MainForm().SqlInsert("INSERT INTO Colors (Color) VALUES (" +
                new MainForm().QuotedStr(color.fcolor.getDescription()) + ")");

            new MainForm().QuerySelectAll("Colors", dgvColors);
        }

        private void Colors_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("Colors", dgvColors);
        }
    }
}
