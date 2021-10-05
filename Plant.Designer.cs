
namespace NissanManufacturingPlanning
{
    partial class Plant
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.numUptime = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUptime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(8, 23);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(267, 20);
            this.tbxName.TabIndex = 0;
            this.tbxName.Text = "Name";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(8, 53);
            this.tbxCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(267, 20);
            this.tbxCountry.TabIndex = 1;
            this.tbxCountry.Text = "Country";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(8, 81);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(267, 20);
            this.tbxAddress.TabIndex = 2;
            this.tbxAddress.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.tbxCountry);
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 294);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add/Update";
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
            this.groupBox3.Location = new System.Drawing.Point(6, 140);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(284, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(6, 34);
            this.numRate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(273, 20);
            this.numRate.TabIndex = 0;
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
            // Plant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 335);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Plant";
            this.Text = "Plant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUptime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.NumericUpDown numUptime;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.NumericUpDown numRate;
    }
}