namespace demo
{
    partial class FrmRangesMap
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.lblrangeMode = new System.Windows.Forms.Label();
            this.comboBoxrangeMode = new System.Windows.Forms.ComboBox();
            this.lblrangeParameter = new System.Windows.Forms.Label();
            this.textBoxrangeParameter = new System.Windows.Forms.TextBox();
            this.lblcolorGradientType = new System.Windows.Forms.Label();
            this.comboBoxcolorGradientType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(158, 171);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(121, 34);
            this.btnAnalysis.TabIndex = 6;
            this.btnAnalysis.Text = "制作";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(12, 12);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(52, 15);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "月份：";
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
            this.comboBoxMonth.Location = new System.Drawing.Point(158, 9);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMonth.TabIndex = 8;
            // 
            // lblrangeMode
            // 
            this.lblrangeMode.AutoSize = true;
            this.lblrangeMode.Location = new System.Drawing.Point(12, 41);
            this.lblrangeMode.Name = "lblrangeMode";
            this.lblrangeMode.Size = new System.Drawing.Size(82, 15);
            this.lblrangeMode.TabIndex = 11;
            this.lblrangeMode.Text = "分段模式：";
            // 
            // comboBoxrangeMode
            // 
            this.comboBoxrangeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxrangeMode.FormattingEnabled = true;
            this.comboBoxrangeMode.Items.AddRange(new object[] {
            "自定义分段",
            "等计数分段",
            "对数分段",
            "标准差分段",
            "平方根分段",
            "等距离分段"});
            this.comboBoxrangeMode.Location = new System.Drawing.Point(158, 38);
            this.comboBoxrangeMode.Name = "comboBoxrangeMode";
            this.comboBoxrangeMode.Size = new System.Drawing.Size(121, 23);
            this.comboBoxrangeMode.TabIndex = 10;
            this.comboBoxrangeMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxrangeMode_SelectedIndexChanged);
            // 
            // lblrangeParameter
            // 
            this.lblrangeParameter.AutoSize = true;
            this.lblrangeParameter.Location = new System.Drawing.Point(12, 96);
            this.lblrangeParameter.Name = "lblrangeParameter";
            this.lblrangeParameter.Size = new System.Drawing.Size(82, 15);
            this.lblrangeParameter.TabIndex = 13;
            this.lblrangeParameter.Text = "分段参数：";
            // 
            // textBoxrangeParameter
            // 
            this.textBoxrangeParameter.Location = new System.Drawing.Point(158, 96);
            this.textBoxrangeParameter.Name = "textBoxrangeParameter";
            this.textBoxrangeParameter.Size = new System.Drawing.Size(121, 25);
            this.textBoxrangeParameter.TabIndex = 14;
            // 
            // lblcolorGradientType
            // 
            this.lblcolorGradientType.AutoSize = true;
            this.lblcolorGradientType.Location = new System.Drawing.Point(12, 70);
            this.lblcolorGradientType.Name = "lblcolorGradientType";
            this.lblcolorGradientType.Size = new System.Drawing.Size(112, 15);
            this.lblcolorGradientType.TabIndex = 16;
            this.lblcolorGradientType.Text = "颜色渐变模式：";
            // 
            // comboBoxcolorGradientType
            // 
            this.comboBoxcolorGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcolorGradientType.FormattingEnabled = true;
            this.comboBoxcolorGradientType.Items.AddRange(new object[] {
            "黑->白渐变色",
            "红->白渐变色",
            "绿->白渐变色",
            "蓝->白渐变色",
            "黄->白渐变色",
            "粉红->白渐变色",
            "青->白渐变色",
            "红->黑渐变色",
            "绿->黑渐变色",
            "蓝->黑渐变色",
            "黄->黑渐变色",
            "粉红->黑渐变色",
            "青->黑渐变色",
            "黄->红渐变色",
            "黄->绿渐变色",
            "黄->蓝渐变色",
            "绿->蓝渐变色",
            "绿->红渐变色",
            "蓝->红渐变色",
            "青->红渐变色",
            "青->蓝渐变色",
            "青->绿渐变色",
            "彩虹色",
            "绿->桔黄->紫罗兰渐变色",
            "地形渐变",
            "                光谱渐变"});
            this.comboBoxcolorGradientType.Location = new System.Drawing.Point(158, 67);
            this.comboBoxcolorGradientType.Name = "comboBoxcolorGradientType";
            this.comboBoxcolorGradientType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxcolorGradientType.TabIndex = 15;
            // 
            // FrmRangesMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 253);
            this.Controls.Add(this.lblcolorGradientType);
            this.Controls.Add(this.comboBoxcolorGradientType);
            this.Controls.Add(this.textBoxrangeParameter);
            this.Controls.Add(this.lblrangeParameter);
            this.Controls.Add(this.lblrangeMode);
            this.Controls.Add(this.comboBoxrangeMode);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.btnAnalysis);
            this.Name = "FrmRangesMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRangesMap";
            this.Load += new System.EventHandler(this.FrmRangesMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label lblrangeMode;
        private System.Windows.Forms.ComboBox comboBoxrangeMode;
        private System.Windows.Forms.Label lblrangeParameter;
        private System.Windows.Forms.TextBox textBoxrangeParameter;
        private System.Windows.Forms.Label lblcolorGradientType;
        private System.Windows.Forms.ComboBox comboBoxcolorGradientType;
    }
}