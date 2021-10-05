using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NissanManufacturingPlanning
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //SQL Connection
        string conStr = @"Data Source=DESKTOP-41A65K6;Initial Catalog=NissanManufacturingDB;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;

        public void QuerySelectAll(string table, DataGridView dgv)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string query = "SELECT * FROM "+table;
                comm = new SqlCommand(query, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "SourceTable");

                dgv.DataSource = ds;
                dgv.DataMember = "SourceTable";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
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

        private void Main_Shown(object sender, EventArgs e)
        {
            //connect to database and test connection
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            QuerySelectAll("SalesRequest", dgvSalesRequests);
            QuerySelectAll("ProductionPlan", dgvProductionOutput);
        }
    }
}
