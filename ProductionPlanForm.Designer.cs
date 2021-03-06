
namespace NissanManufacturingPlanning
{
    partial class ProductionPlanForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPlant = new System.Windows.Forms.ComboBox();
            this.tbxName = new System.Windows.Forms.TextBox();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbPlant);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(568, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // cbbPlant
            // 
            this.cbbPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPlant.FormattingEnabled = true;
            this.cbbPlant.Location = new System.Drawing.Point(16, 123);
            this.cbbPlant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbPlant.Name = "cbbPlant";
            this.cbbPlant.Size = new System.Drawing.Size(530, 33);
            this.cbbPlant.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(16, 58);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(530, 31);
            this.tbxName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 502);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(252, 60);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Production Plan";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(568, 265);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(10, 183);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(185, 25);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration:   (hours)";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(12, 208);
            this.numDuration.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numDuration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(546, 31);
            this.numDuration.TabIndex = 4;
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(10, 112);
            this.lblUptime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(191, 25);
            this.lblUptime.TabIndex = 3;
            this.lblUptime.Text = "Uptime:   (0-100%)";
            // 
            // numUptime
            // 
            this.numUptime.Location = new System.Drawing.Point(12, 137);
            this.numUptime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numUptime.Name = "numUptime";
            this.numUptime.Size = new System.Drawing.Size(546, 31);
            this.numUptime.TabIndex = 2;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(10, 40);
            this.lblRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(150, 25);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Rate:   (0-300)";
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(12, 65);
            this.numRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numRate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(546, 31);
            this.numRate.TabIndex = 0;
            // 
            // ProductionPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 577);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductionPlanForm";
            this.Text = "Production Plan";
            this.Shown += new System.EventHandler(this.ProductionPlan_Shown);
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
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.NumericUpDown numUptime;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.ComboBox cbbPlant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}