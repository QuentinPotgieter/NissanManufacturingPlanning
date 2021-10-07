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
    public partial class UserForm : Form
    {
        public User fuser = null;
        public UserForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sname = tbxName.Text;
            string fname = tbxSurname.Text;
            string pw = tbxPw.Text;
            string role = cbbRole.Text;

            //Input Validation
            if (sname == "" || fname == "" || pw == "" || role == "")
            {
                MessageBox.Show("Please enter a value for each field");
                return;
            }
            if (sname.Length > 50 || fname.Length > 50 || pw.Length > 50 || role.Length > 50)
            {
                MessageBox.Show("The name you have entered is too long (Max 50 Characters)");
                return;
            }
            
            
            fuser = new User(sname,fname,pw,role);

            UsersForm.ActiveForm.Show();
            this.Close();
        }
    }
}
