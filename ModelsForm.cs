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
    public partial class ModelsForm : Form
    {
        public ModelsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelForm model = new ModelForm();
            model.ShowDialog();

            if (model.fmodel != null)
            {
                //Not everything in class is used
                new MainForm().SqlInsert("INSERT INTO VehicleModel(ModelName,ModelYear) VALUES('" + model.fmodel.getName() + "'," + model.fmodel.getYear() + ")");

                new MainForm().QuerySelectAll("VehicleModel", dgvModel);
            }
        }

        private void Models_Shown(object sender, EventArgs e)
        {
            new MainForm().QuerySelectAll("VehicleModel", dgvModel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = dgvModel.Rows[dgvModel.SelectedCells[0].RowIndex].Cells["ModelName"].Value.ToString();
            string index = dgvModel.Rows[dgvModel.SelectedCells[0].RowIndex].Cells["ModelID"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                new MainForm().SqlDelete("DELETE FROM VehicleModel WHERE ModelID = " + index);
            }
            new MainForm().QuerySelectAll("VehicleModel", dgvModel);
        }
    }
}
