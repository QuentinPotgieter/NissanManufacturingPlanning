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

            if (color.fcolor != null)
            {
                new MainForm().SqlInsert("INSERT INTO Colors (Color) VALUES (" +
                new MainForm().QuotedStr(color.fcolor.getDescription()) + ")");

                new MainForm().QuerySelectAll("Colors", dgvColors);
            }
        }

        private void Colors_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("Colors", dgvColors);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvColors.Rows.Count == 0)
            {
                MessageBox.Show("No Colors to Remove");
            }
            else
            {
                string name = dgvColors.Rows[dgvColors.SelectedCells[0].RowIndex].Cells["Color"].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    new MainForm().SqlDelete("DELETE FROM Colors WHERE Color = '" + name + "'");
                }
                new MainForm().QuerySelectAll("Colors", dgvColors);
            }
            
        }
    }
}
