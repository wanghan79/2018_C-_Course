namespace WindowsFormsApplication
{
    partial class personalTaxCalculater
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.com_chooseType = new System.Windows.Forms.ComboBox();
            this.lab_gross = new System.Windows.Forms.Label();
            this.textBox_gross = new System.Windows.Forms.TextBox();
            this.btn_calculater = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_tax = new System.Windows.Forms.Label();
            this.textBox_tax = new System.Windows.Forms.TextBox();
            this.lab_withoutTax = new System.Windows.Forms.Label();
            this.textBox_withoutTax = new System.Windows.Forms.TextBox();
            this.lab_taxYuan = new System.Windows.Forms.Label();
            this.lab_withoutYuan = new System.Windows.Forms.Label();
            this.lab_grossYuan = new System.Windows.Forms.Label();
            this.timer_alert = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.header.Location = new System.Drawing.Point(159, 31);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(295, 35);
            this.header.TabIndex = 0;
            this.header.Text = "个人所得税计算器";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_type.Location = new System.Drawing.Point(95, 119);
            this.lab_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(72, 16);
            this.lab_type.TabIndex = 1;
            this.lab_type.Text = "收入类型";
            // 
            // com_chooseType
            // 
            this.com_chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_chooseType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.com_chooseType.FormattingEnabled = true;
            this.com_chooseType.Items.AddRange(new object[] {
            "综合所得适用",
            "经营所得适用",
            "承包经营、承租经营所得适用",
            "劳务报酬所得适用"});
            this.com_chooseType.Location = new System.Drawing.Point(201, 116);
            this.com_chooseType.Margin = new System.Windows.Forms.Padding(4);
            this.com_chooseType.Name = "com_chooseType";
            this.com_chooseType.Size = new System.Drawing.Size(239, 24);
            this.com_chooseType.TabIndex = 2;
            this.com_chooseType.SelectedIndexChanged += new System.EventHandler(this.com_chooseType_SelectedIndexChanged);
            // 
            // lab_gross
            // 
            this.lab_gross.AutoSize = true;
            this.lab_gross.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gross.Location = new System.Drawing.Point(95, 184);
            this.lab_gross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_gross.Name = "lab_gross";
            this.lab_gross.Size = new System.Drawing.Size(72, 16);
            this.lab_gross.TabIndex = 3;
            this.lab_gross.Text = "收入总额";
            // 
            // textBox_gross
            // 
            this.textBox_gross.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_gross.Location = new System.Drawing.Point(201, 181);
            this.textBox_gross.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_gross.Name = "textBox_gross";
            this.textBox_gross.Size = new System.Drawing.Size(239, 26);
            this.textBox_gross.TabIndex = 4;
            // 
            // btn_calculater
            // 
            this.btn_calculater.Location = new System.Drawing.Point(248, 228);
            this.btn_calculater.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calculater.Name = "btn_calculater";
            this.btn_calculater.Size = new System.Drawing.Size(143, 35);
            this.btn_calculater.TabIndex = 5;
            this.btn_calculater.Text = "计算";
            this.btn_calculater.UseVisualStyleBackColor = true;
            this.btn_calculater.Click += new System.EventHandler(this.btn_calculater_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(493, 181);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 26);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_tax
            // 
            this.lab_tax.AutoSize = true;
            this.lab_tax.Location = new System.Drawing.Point(95, 298);
            this.lab_tax.Name = "lab_tax";
            this.lab_tax.Size = new System.Drawing.Size(72, 16);
            this.lab_tax.TabIndex = 7;
            this.lab_tax.Text = "应纳税款";
            // 
            // textBox_tax
            // 
            this.textBox_tax.CausesValidation = false;
            this.textBox_tax.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_tax.Location = new System.Drawing.Point(201, 295);
            this.textBox_tax.Name = "textBox_tax";
            this.textBox_tax.ReadOnly = true;
            this.textBox_tax.Size = new System.Drawing.Size(239, 26);
            this.textBox_tax.TabIndex = 8;
            this.textBox_tax.TabStop = false;
            // 
            // lab_withoutTax
            // 
            this.lab_withoutTax.AutoSize = true;
            this.lab_withoutTax.Location = new System.Drawing.Point(95, 357);
            this.lab_withoutTax.Name = "lab_withoutTax";
            this.lab_withoutTax.Size = new System.Drawing.Size(72, 16);
            this.lab_withoutTax.TabIndex = 9;
            this.lab_withoutTax.Text = "税后收入";
            // 
            // textBox_withoutTax
            // 
            this.textBox_withoutTax.CausesValidation = false;
            this.textBox_withoutTax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_withoutTax.Location = new System.Drawing.Point(201, 354);
            this.textBox_withoutTax.Name = "textBox_withoutTax";
            this.textBox_withoutTax.ReadOnly = true;
            this.textBox_withoutTax.Size = new System.Drawing.Size(239, 26);
            this.textBox_withoutTax.TabIndex = 10;
            this.textBox_withoutTax.TabStop = false;
            // 
            // lab_taxYuan
            // 
            this.lab_taxYuan.AutoSize = true;
            this.lab_taxYuan.Location = new System.Drawing.Point(446, 298);
            this.lab_taxYuan.Name = "lab_taxYuan";
            this.lab_taxYuan.Size = new System.Drawing.Size(24, 16);
            this.lab_taxYuan.TabIndex = 11;
            this.lab_taxYuan.Text = "元";
            this.lab_taxYuan.Click += new System.EventHandler(this.lab_taxYuan_Click);
            // 
            // lab_withoutYuan
            // 
            this.lab_withoutYuan.AutoSize = true;
            this.lab_withoutYuan.Location = new System.Drawing.Point(446, 357);
            this.lab_withoutYuan.Name = "lab_withoutYuan";
            this.lab_withoutYuan.Size = new System.Drawing.Size(24, 16);
            this.lab_withoutYuan.TabIndex = 12;
            this.lab_withoutYuan.Text = "元";
            // 
            // lab_grossYuan
            // 
            this.lab_grossYuan.AutoSize = true;
            this.lab_grossYuan.Location = new System.Drawing.Point(447, 186);
            this.lab_grossYuan.Name = "lab_grossYuan";
            this.lab_grossYuan.Size = new System.Drawing.Size(24, 16);
            this.lab_grossYuan.TabIndex = 13;
            this.lab_grossYuan.Text = "元";
            // 
            // timer_alert
            // 
            this.timer_alert.Interval = 30000;
            this.timer_alert.Tick += new System.EventHandler(this.timer_alert_Tick);
            // 
            // personalTaxCalculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 483);
            this.Controls.Add(this.lab_grossYuan);
            this.Controls.Add(this.lab_withoutYuan);
            this.Controls.Add(this.lab_taxYuan);
            this.Controls.Add(this.textBox_withoutTax);
            this.Controls.Add(this.lab_withoutTax);
            this.Controls.Add(this.textBox_tax);
            this.Controls.Add(this.lab_tax);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_calculater);
            this.Controls.Add(this.textBox_gross);
            this.Controls.Add(this.lab_gross);
            this.Controls.Add(this.com_chooseType);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "personalTaxCalculater";
            this.Text = "personalTaxCalculater";
            this.Load += new System.EventHandler(this.personalTaxCalculater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.ComboBox com_chooseType;
        private System.Windows.Forms.Label lab_gross;
        private System.Windows.Forms.TextBox textBox_gross;
        private System.Windows.Forms.Button btn_calculater;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_tax;
        private System.Windows.Forms.TextBox textBox_tax;
        private System.Windows.Forms.Label lab_withoutTax;
        private System.Windows.Forms.TextBox textBox_withoutTax;
        private System.Windows.Forms.Label lab_taxYuan;
        private System.Windows.Forms.Label lab_withoutYuan;
        private System.Windows.Forms.Label lab_grossYuan;
        private System.Windows.Forms.Timer timer_alert;
    }
}

