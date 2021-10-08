using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NissanManufacturingPlanning
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //SQL Connection
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        SqlDataReader read;

        //Database file must be in Data folder
        public static string connPath = AppDomain.CurrentDomain.BaseDirectory + @"Data\NissanManufacturingDB.mdf";
        public static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + connPath + ";Integrated Security=True";

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get variables from user:
            string usernameEntered = textBox1.Text;
            string passwordEntered = textBox2.Text;
            //login challenge
            String ReadUsername = "";
            String ReadPassword = "";
            conn = new SqlConnection(connStr);
            conn.Open();
            string sqlComm = "SELECT FirstName,Password FROM [User] WHERE FirstName = '" + usernameEntered + "' AND Password = '" + passwordEntered + "'";
            comm = new SqlCommand(sqlComm, conn);
            try
            {
                if (usernameEntered != "" && passwordEntered != "")
                {
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReadUsername = reader[0].ToString();
                            ReadPassword = reader[1].ToString();
                        }
                        //on successfull login: 
                    }
                    if (usernameEntered == ReadUsername && passwordEntered == ReadPassword)
                    {
                        Hide();
                        SplashScreen form = new SplashScreen();
                        form.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login!");
                    }
                }
                else
                {
                    MessageBox.Show("Credentials Required");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Exception" + e1);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
