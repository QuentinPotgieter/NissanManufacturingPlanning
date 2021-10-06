
namespace NissanManufacturingPlanning
{
    partial class DerivativeForm
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
            this.cbbModel = new System.Windows.Forms.ComboBox();
            this.cbbMotor = new System.Windows.Forms.ComboBox();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.cbLeather = new System.Windows.Forms.CheckBox();
            this.cbElectricWindows = new System.Windows.Forms.CheckBox();
            this.cbAutomatic = new System.Windows.Forms.CheckBox();
            this.cbSunRoof = new System.Windows.Forms.CheckBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbModel);
            this.groupBox1.Controls.Add(this.cbbMotor);
            this.groupBox1.Controls.Add(this.cbbColor);
            this.groupBox1.Controls.Add(this.cbLeather);
            this.groupBox1.Controls.Add(this.cbElectricWindows);
            this.groupBox1.Controls.Add(this.cbAutomatic);
            this.groupBox1.Controls.Add(this.cbSunRoof);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(288, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Derivative";
            // 
            // cbbModel
            // 
            this.cbbModel.FormattingEnabled = true;
            this.cbbModel.Location = new System.Drawing.Point(7, 114);
            this.cbbModel.Name = "cbbModel";
            this.cbbModel.Size = new System.Drawing.Size(274, 21);
            this.cbbModel.TabIndex = 11;
            this.cbbModel.Text = "Model";
            // 
            // cbbMotor
            // 
            this.cbbMotor.FormattingEnabled = true;
            this.cbbMotor.Location = new System.Drawing.Point(7, 85);
            this.cbbMotor.Name = "cbbMotor";
            this.cbbMotor.Size = new System.Drawing.Size(274, 21);
            this.cbbMotor.TabIndex = 10;
            this.cbbMotor.Text = "Motor";
            // 
            // cbbColor
            // 
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Location = new System.Drawing.Point(7, 54);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(274, 21);
            this.cbbColor.TabIndex = 9;
            this.cbbColor.Text = "Color";
            // 
            // cbLeather
            // 
            this.cbLeather.AutoSize = true;
            this.cbLeather.Location = new System.Drawing.Point(7, 222);
            this.cbLeather.Margin = new System.Windows.Forms.Padding(2);
            this.cbLeather.Name = "cbLeather";
            this.cbLeather.Size = new System.Drawing.Size(92, 17);
            this.cbLeather.TabIndex = 7;
            this.cbLeather.Text = "Leather Seats";
            this.cbLeather.UseVisualStyleBackColor = true;
            // 
            // cbElectricWindows
            // 
            this.cbElectricWindows.AutoSize = true;
            this.cbElectricWindows.Location = new System.Drawing.Point(7, 193);
            this.cbElectricWindows.Margin = new System.Windows.Forms.Padding(2);
            this.cbElectricWindows.Name = "cbElectricWindows";
            this.cbElectricWindows.Size = new System.Drawing.Size(108, 17);
            this.cbElectricWindows.TabIndex = 6;
            this.cbElectricWindows.Text = "Electric Windows";
            this.cbElectricWindows.UseVisualStyleBackColor = true;
            // 
            // cbAutomatic
            // 
            this.cbAutomatic.AutoSize = true;
            this.cbAutomatic.Location = new System.Drawing.Point(7, 166);
            this.cbAutomatic.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutomatic.Name = "cbAutomatic";
            this.cbAutomatic.Size = new System.Drawing.Size(116, 17);
            this.cbAutomatic.TabIndex = 4;
            this.cbAutomatic.Text = "Automatic Gearbox";
            this.cbAutomatic.UseVisualStyleBackColor = true;
            // 
            // cbSunRoof
            // 
            this.cbSunRoof.AutoSize = true;
            this.cbSunRoof.Location = new System.Drawing.Point(7, 138);
            this.cbSunRoof.Margin = new System.Windows.Forms.Padding(2);
            this.cbSunRoof.Name = "cbSunRoof";
            this.cbSunRoof.Size = new System.Drawing.Size(71, 17);
            this.cbSunRoof.TabIndex = 3;
            this.cbSunRoof.Text = "Sun Roof";
            this.cbSunRoof.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(6, 23);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(275, 20);
            this.tbxName.TabIndex = 0;
            this.tbxName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 271);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DerivativeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 314);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DerivativeForm";
            this.Text = "Derivative";
            this.Shown += new System.EventHandler(this.DerivativeForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckBox cbLeather;
        private System.Windows.Forms.CheckBox cbElectricWindows;
        private System.Windows.Forms.CheckBox cbAutomatic;
        private System.Windows.Forms.CheckBox cbSunRoof;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbMotor;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.ComboBox cbbModel;
    }
}