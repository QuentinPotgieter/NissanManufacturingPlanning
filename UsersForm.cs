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
            if (userform.fuser != null)
            {
                new MainForm().SqlInsert("INSERT INTO [User] (FirstName, Surname, Password, Role) VALUES ('" + userform.fuser.getFName() + "','" + userform.fuser.getSName() + "','" + userform.fuser.getPw() + "','" + userform.fuser.getRole() + "')");
                new MainForm().QuerySelectAll("[User]", dgvUser);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.button1.Text = "Update Profile";
            userform.tbxName.Text = dgvUser.Rows[dgvUser.SelectedCells[0].RowIndex].Cells["FirstName"].Value.ToString(); 
            userform.tbxPw.Text = dgvUser.Rows[dgvUser.SelectedCells[0].RowIndex].Cells["Password"].Value.ToString(); 
            userform.tbxSurname.Text = dgvUser.Rows[dgvUser.SelectedCells[0].RowIndex].Cells["Surname"].Value.ToString(); 
            userform.ShowDialog();

            string index = dgvUser.Rows[dgvUser.SelectedCells[0].RowIndex].Cells["UserID"].Value.ToString();

            if (userform.fuser != null)
            {
                new MainForm().SqlUpdate("UPDATE [User] SET FirstName = '" + userform.fuser.getFName() + "', Surname = '" + userform.fuser.getSName() + "', Password = '" + userform.fuser.getPw() + "', Role = '" + userform.fuser.getRole() + "' WHERE UserID = " + index);

                new MainForm().QuerySelectAll("[User]", dgvUser);
            }
        }
    }
}
