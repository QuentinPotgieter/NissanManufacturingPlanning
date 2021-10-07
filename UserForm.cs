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
        public User fuser;
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

            //class
            fuser = new User(sname,fname,pw,role);

            UsersForm.ActiveForm.Show();
            this.Close();
        }
    }
}
