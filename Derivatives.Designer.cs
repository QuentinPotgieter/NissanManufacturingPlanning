
namespace NissanManufacturingPlanning
{
    partial class Derivatives
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvVehicleDerivative = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleDerivative)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvVehicleDerivative);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(874, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Derivatives";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 73);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove Derivative";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Derivative";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvVehicleDerivative
            // 
            this.dgvVehicleDerivative.AllowUserToAddRows = false;
            this.dgvVehicleDerivative.AllowUserToDeleteRows = false;
            this.dgvVehicleDerivative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleDerivative.Location = new System.Drawing.Point(8, 23);
            this.dgvVehicleDerivative.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVehicleDerivative.Name = "dgvVehicleDerivative";
            this.dgvVehicleDerivative.ReadOnly = true;
            this.dgvVehicleDerivative.RowHeadersWidth = 82;
            this.dgvVehicleDerivative.RowTemplate.Height = 33;
            this.dgvVehicleDerivative.Size = new System.Drawing.Size(681, 486);
            this.dgvVehicleDerivative.TabIndex = 0;
            // 
            // Derivatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 546);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Derivatives";
            this.Text = "Derivatives";
            this.Shown += new System.EventHandler(this.Derivatives_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleDerivative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVehicleDerivative;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}