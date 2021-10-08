
namespace NissanManufacturingPlanning
{
    partial class PlantForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblUptime = new System.Windows.Forms.Label();
            this.numUptime = new System.Windows.Forms.NumericUpDown();
            this.lblRate = new System.Windows.Forms.Label();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUptime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(8, 29);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(267, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(8, 67);
            this.tbxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(267, 20);
            this.tbxCountry.TabIndex = 1;
            this.tbxCountry.TextChanged += new System.EventHandler(this.tbxCountry_TextChanged);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(8, 111);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(267, 20);
            this.tbxAddress.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.tbxCountry);
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 307);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Plant";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDuration);
            this.groupBox3.Controls.Add(this.numDuration);
            this.groupBox3.Controls.Add(this.lblUptime);
            this.groupBox3.Controls.Add(this.numUptime);
            this.groupBox3.Controls.Add(this.lblRate);
            this.groupBox3.Controls.Add(this.numRate);
            this.groupBox3.Location = new System.Drawing.Point(6, 165);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(284, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(5, 95);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(101, 13);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration:   (minutes)";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(6, 108);
            this.numDuration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(273, 20);
            this.numDuration.TabIndex = 4;
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(5, 58);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(93, 13);
            this.lblUptime.TabIndex = 3;
            this.lblUptime.Text = "Uptime:   (0-100%)";
            // 
            // numUptime
            // 
            this.numUptime.Location = new System.Drawing.Point(6, 71);
            this.numUptime.Name = "numUptime";
            this.numUptime.Size = new System.Drawing.Size(273, 20);
            this.numUptime.TabIndex = 2;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(5, 21);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(75, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Rate:   (0-300)";
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(6, 34);
            this.numRate.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(273, 20);
            this.numRate.TabIndex = 0;
            // 
            // PlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 345);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlantForm";
            this.Text = "Plant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUptime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxCountry;
        public System.Windows.Forms.TextBox tbxAddress;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.NumericUpDown numDuration;
        public System.Windows.Forms.NumericUpDown numUptime;
        public System.Windows.Forms.NumericUpDown numRate;
    }
}