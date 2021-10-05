﻿using System;
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
    public partial class Models : Form
    {
        //SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-41A65K6;Initial Catalog=NissanManufacturingDB;Integrated Security=True");
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
                string query = "SELECT * FROM " + table;
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

        public Models()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.ShowDialog();
        }

        private void Models_Shown(object sender, EventArgs e)
        {
            QuerySelectAll("VehicleModel", dgvModel);
        }
    }
}
