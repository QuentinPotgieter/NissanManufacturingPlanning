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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //SQL Connection
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        SqlDataReader read;
        DataSet ds;

        public void QuerySelectAll(string table, DataGridView dgv)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phill\source\repos\NissanManufacturingPlanning\NissanManufacturingDB.mdf;Integrated Security=True");
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

        public List<string> FillComboBox(string query, ComboBox cbb) //Method is to return array used to fill combo box
        {
            List<string> list = new List<string>();

            if (cbb.Name == "cbbColor")
            {
                try
                {
                    conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phill\source\repos\NissanManufacturingPlanning\NissanManufacturingDB.mdf;Integrated Security=True");
                    conn.Open();

                    comm = new SqlCommand(query, conn);
                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        cbb.Items.Add(read.GetString(0));
                    }
                    conn.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                return list;
            }
            
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phill\source\repos\NissanManufacturingPlanning\NissanManufacturingDB.mdf;Integrated Security=True");
                conn.Open();

                comm = new SqlCommand(query, conn);
                read = comm.ExecuteReader();

                while (read.Read())
                {
                    cbb.Items.Add(read.GetInt32(0).ToString());
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            return list;
        }

        public void SqlInsert(string query)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phill\source\repos\NissanManufacturingPlanning\NissanManufacturingDB.mdf;Integrated Security=True");
                conn.Open();

                adap = new SqlDataAdapter();
                comm = new SqlCommand(query, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public string QuotedStr(String S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return "''";
            }

            return ("'" + S.Replace("'", "''") + "'");
        }

        public void SqlUpdate(string query)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phill\source\repos\NissanManufacturingPlanning\NissanManufacturingDB.mdf;Integrated Security=True");
                conn.Open();

                adap = new SqlDataAdapter();
                comm = new SqlCommand(query, conn);
                adap.UpdateCommand = comm;
                adap.UpdateCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void SqlDelete(string query)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phill\source\repos\NissanManufacturingPlanning\NissanManufacturingDB.mdf;Integrated Security=True");
                conn.Open();

                adap = new SqlDataAdapter();
                comm = new SqlCommand(query, conn);
                adap.DeleteCommand = comm;
                adap.DeleteCommand.ExecuteNonQuery();

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
            PlantsForm plants = new PlantsForm();
            plants.ShowDialog();
        }

        private void modelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelsForm models = new ModelsForm();
            models.ShowDialog();
        }

        private void derivativesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DerivativesForm derivatives = new DerivativesForm();
            derivatives.ShowDialog();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorsForm colors = new ColorsForm();
            colors.ShowDialog();
        }

        private void motorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotorsForm motors = new MotorsForm();
            motors.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesRequestForm salesRequest = new SalesRequestForm();
            salesRequest.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductionPlan productionPlan = new ProductionPlan();
            productionPlan.ShowDialog();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            QuerySelectAll("SalesRequest",   dgvSalesRequests);
            QuerySelectAll("ProductionPlan", dgvProductionOutput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plan = dgvProductionOutput.Rows[dgvProductionOutput.SelectedCells[0].RowIndex].Cells["PlanID"].Value.ToString();
            string sales = dgvSalesRequests.Rows[dgvSalesRequests.SelectedCells[0].RowIndex].Cells["SalesRequestID"].Value.ToString();
            SqlUpdate("UPDATE [SalesRequest] SET PlanID = " + plan + " WHERE SalesRequestID = " + sales);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = dgvSalesRequests.Rows[dgvSalesRequests.SelectedCells[0].RowIndex].Cells["SalesRequestsID"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                new MainForm().SqlDelete("DELETE FROM SalesRequest WHERE SalesRequestID = " + name);
            }
            new MainForm().QuerySelectAll("SalesRequest", dgvSalesRequests);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = dgvProductionOutput.Rows[dgvProductionOutput.SelectedCells[0].RowIndex].Cells["PlanID"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                new MainForm().SqlDelete("DELETE FROM ProductionPlan WHERE PlanID = " + name);
            }
            new MainForm().QuerySelectAll("ProductionPlan", dgvProductionOutput);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
        }
    }
}
