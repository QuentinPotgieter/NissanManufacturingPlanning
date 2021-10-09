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
        //Role of logged in user
        public string UserRole;


        //SQL Connection
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        SqlDataReader read;
        DataSet ds;

        //Database file must be in Data folder
        public static string connPath = AppDomain.CurrentDomain.BaseDirectory + @"Data\NissanManufacturingDB.mdf";
        public static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+connPath+";Integrated Security=True";

        public void QuerySelectAll(string table, DataGridView dgv)
        {
            try
            {
                conn = new SqlConnection(connStr);
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

        public List<string> FillComboBox(string query) //Method is to return array used to fill combo box 
        {
            List<string> list = new List<string>();
            
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                comm = new SqlCommand(query, conn);
                read = comm.ExecuteReader();
                
                if (read.GetDataTypeName(0) == "int")
                {
                    while (read.Read())
                    {
                        list.Add(read.GetInt32(0).ToString());
                    }
                }

                if (read.GetDataTypeName(0) == "varchar")
                {
                    while (read.Read())
                    {
                        list.Add(read.GetString(0));
                    }
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
                conn = new SqlConnection(connStr);
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
                conn = new SqlConnection(connStr);
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
                conn = new SqlConnection(connStr);
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
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            Close();
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
            QuerySelectAll("SalesRequest", dgvSalesRequests);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductionPlanForm productionPlan = new ProductionPlanForm();
            productionPlan.ShowDialog();
            QuerySelectAll("ProductionPlan", dgvProductionOutput);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            QuerySelectAll("SalesRequest",   dgvSalesRequests);
            QuerySelectAll("ProductionPlan", dgvProductionOutput);
            this.Height = 699;
            this.Width = 1281;

            //Role Access
            if (UserRole == "Administrator")
            {
                managePlantsToolStripMenuItem.Visible = true;
                manageDerivativesToolStripMenuItem.Visible = true;
                colorsToolStripMenuItem.Visible = true;
                motorsToolStripMenuItem.Visible = true;
                usersToolStripMenuItem.Visible = true;

                button2.Enabled = true;
                button4.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
                button1.Enabled = true;
            }
            if (UserRole == "Planner")
            {
                managePlantsToolStripMenuItem.Visible = true;
                manageDerivativesToolStripMenuItem.Visible = false;
                colorsToolStripMenuItem.Visible = false;
                motorsToolStripMenuItem.Visible = false;
                usersToolStripMenuItem.Visible = false;
                
                button2.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = true;
                button5.Enabled = true;
                button1.Enabled = true;
            }
            if (UserRole == "Sales")
            {
                managePlantsToolStripMenuItem.Visible = false;
                manageDerivativesToolStripMenuItem.Visible = false;
                colorsToolStripMenuItem.Visible = false;
                motorsToolStripMenuItem.Visible = false;
                usersToolStripMenuItem.Visible = false;
                
                button2.Enabled = true;
                button4.Enabled = true;
                button3.Enabled = false;
                button5.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProductionOutput.Rows.Count == 0)//Adding Check if production plan is empty (Michael)
            {
                MessageBox.Show("No values in Production Output, Unable to Link");
            }
            else
            {
                string plan = dgvProductionOutput.Rows[dgvProductionOutput.SelectedCells[0].RowIndex].Cells["PlanID"].Value.ToString();
                string sales = dgvSalesRequests.Rows[dgvSalesRequests.SelectedCells[0].RowIndex].Cells["SalesRequestID"].Value.ToString();

                SqlUpdate("UPDATE [SalesRequest] SET PlanID = " + plan + " WHERE SalesRequestID = " + sales);
                MessageBox.Show("Succsesfully linked SalesRequestID: "+sales+" PlanID: "+plan);
            }
            QuerySelectAll("SalesRequest", dgvSalesRequests);
            QuerySelectAll("ProductionPlan", dgvProductionOutput);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvSalesRequests.Rows.Count == 0)//Adding Exception handling for empty DataGridview (Michael)

            {
                MessageBox.Show("No values in Sales Request, Unable to Remove");
            }
            else
            {
                string id = dgvSalesRequests.Rows[dgvSalesRequests.SelectedCells[0].RowIndex].Cells["SalesRequestID"].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " +id+ "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    new MainForm().SqlDelete("DELETE FROM SalesRequest WHERE SalesRequestID = " + id);
                }
                new MainForm().QuerySelectAll("SalesRequest", dgvSalesRequests);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvProductionOutput.Rows.Count == 0) // Check if Production Output is empty, and throw message.
            {
                MessageBox.Show("No values in Production Output, Unable to Remove");
            }
            else
            {
                string id = dgvProductionOutput.Rows[dgvProductionOutput.SelectedCells[0].RowIndex].Cells["PlanID"].Value.ToString();
                string name = dgvProductionOutput.Rows[dgvProductionOutput.SelectedCells[0].RowIndex].Cells["Name"].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " +id+" - "+ name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    new MainForm().SqlDelete("DELETE FROM ProductionPlan WHERE PlanID = " + id);
                }
                new MainForm().QuerySelectAll("ProductionPlan", dgvProductionOutput);
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.ShowDialog();
        }
    }
}
