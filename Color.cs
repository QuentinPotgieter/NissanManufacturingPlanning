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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;

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

            new Main().SqlInsert("INSERT INTO Colors (Color) VALUES ("+
                new Main().QuotedStr(name) +
                ")");

            Colors.ActiveForm.Show();
            this.Close();
        }
    }
}
