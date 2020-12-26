namespace demo
{
    partial class FrmDotDensityMap
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
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDensity = new System.Windows.Forms.Label();
            this.comboBoxDensity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(132, 153);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(121, 34);
            this.btnAnalysis.TabIndex = 0;
            this.btnAnalysis.Text = "制作";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "total",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(132, 24);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMonth.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(21, 27);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(52, 15);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "月份：";
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(21, 82);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(97, 15);
            this.lblDensity.TabIndex = 4;
            this.lblDensity.Text = "点密度等级：";
            // 
            // comboBoxDensity
            // 
            this.comboBoxDensity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDensity.FormattingEnabled = true;
            this.comboBoxDensity.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxDensity.Location = new System.Drawing.Point(132, 79);
            this.comboBoxDensity.Name = "comboBoxDensity";
            this.comboBoxDensity.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDensity.TabIndex = 3;
            // 
            // FrmDotDensityMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 209);
            this.Controls.Add(this.lblDensity);
            this.Controls.Add(this.comboBoxDensity);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.btnAnalysis);
            this.Name = "FrmDotDensityMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDotDensityMap";
            this.Load += new System.EventHandler(this.FrmDotDensityMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.ComboBox comboBoxDensity;
    }
}