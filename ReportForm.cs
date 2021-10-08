using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NissanManufacturingPlanning
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        //SQL Connection
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        SqlDataReader read;

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(MainForm.connStr);
                conn.Open();
                x1.Text = new SqlCommand("SELECT COUNT(ModelID) FROM VehicleModel", conn).ExecuteScalar().ToString();
                x2.Text = new SqlCommand("SELECT COUNT(DerivativeID) FROM VehicleDerivative", conn).ExecuteScalar().ToString();
                x7.Text = new SqlCommand("SELECT COUNT(PlantID) FROM Plant", conn).ExecuteScalar().ToString();
                x11.Text = new SqlCommand("SELECT COUNT(SalesRequestID) FROM SalesRequest", conn).ExecuteScalar().ToString();
                x12.Text = new SqlCommand("SELECT COUNT(SalesRequestID) FROM SalesRequest WHERE PlanID IS NOT NULL", conn).ExecuteScalar().ToString();
                x13.Text = new SqlCommand("SELECT COUNT(SalesRequestID) FROM SalesRequest WHERE PlanID IS NULL", conn).ExecuteScalar().ToString();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
