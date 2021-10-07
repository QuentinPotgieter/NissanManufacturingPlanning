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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("[User]", dgvUser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.button1.Text = "Update Profile";
            userform.ShowDialog();
        }
    }
}
