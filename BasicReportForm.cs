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
            date.Text = date.Text + DateTime.Now.ToLongDateString();
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
                x16.Text = new SqlCommand("SELECT COUNT(PlanID) FROM ProductionPlan WHERE PlanID IS NOT NULL", conn).ExecuteScalar().ToString();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn = new SqlConnection(MainForm.connStr);
                conn.Open();
                string sqlComm = "SELECT SalesRequest.DateRequired,VehicleDerivative.Name,SalesRequest.Quantity,ProductionPlan.Rate,ProductionPlan.Uptime,ProductionPlan.ShiftDuration FROM SalesRequest JOIN VehicleDerivative ON SalesRequest.DerivativeID=VehicleDerivative.DerivativeID JOIN ProductionPlan ON SalesRequest.PlanID=ProductionPlan.PlanID WHERE SalesRequest.DateRequired BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                comm = new SqlCommand(sqlComm, conn);
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    listBox1.Items.Add("Date\t\t\t" + "Derivative\t" + "Quantity\t" + "Production Plan\t" + "Difference");
                    while (reader.Read())
                    {
                        int planVolume = calcValue((int)reader.GetValue(3), (int)reader.GetValue(4), (int)reader.GetValue(5));
                        int difference = (int)reader.GetValue(2) - (int)planVolume;
                        listBox1.Items.Add(reader.GetValue(0).ToString() + "\t" + reader.GetValue(1).ToString() + "\t" + reader.GetValue(2).ToString() + "\t" + planVolume.ToString() + "\t\t" + difference.ToString());
                    }
                    //on successfull login: 
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private int calcValue(int r, int a, int d)
        {
            return (r * a * (d/60));
        }
    }
}
