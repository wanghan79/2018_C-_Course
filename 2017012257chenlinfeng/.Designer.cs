namespace Personal_tax_counting
{
    partial class Form_calculcator
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_income_type = new System.Windows.Forms.Label();
            this.lbl_all_income = new System.Windows.Forms.Label();
            this.tbx_all_income = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_should_tax = new System.Windows.Forms.Label();
            this.tbx_should_tax = new System.Windows.Forms.TextBox();
            this.lbl_after_tax_income = new System.Windows.Forms.Label();
            this.tbx_after_tax_income = new System.Windows.Forms.TextBox();
            this.cbx_income_type = new System.Windows.Forms.ComboBox();
            this.lbl_should_tax_unit = new System.Windows.Forms.Label();
            this.lbl_after_income_unit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_income_type
            // 
            this.lbl_income_type.AutoSize = true;
            this.lbl_income_type.Location = new System.Drawing.Point(89, 55);
            this.lbl_income_type.Name = "lbl_income_type";
            this.lbl_income_type.Size = new System.Drawing.Size(67, 15);
            this.lbl_income_type.TabIndex = 0;
            this.lbl_income_type.Text = "收入类型";
            this.lbl_income_type.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_all_income
            // 
            this.lbl_all_income.AutoSize = true;
            this.lbl_all_income.Location = new System.Drawing.Point(89, 102);
            this.lbl_all_income.Name = "lbl_all_income";
            this.lbl_all_income.Size = new System.Drawing.Size(67, 15);
            this.lbl_all_income.TabIndex = 1;
            this.lbl_all_income.Text = "收入总额";
            // 
            // tbx_all_income
            // 
            this.tbx_all_income.Location = new System.Drawing.Point(232, 98);
            this.tbx_all_income.Name = "tbx_all_income";
            this.tbx_all_income.Size = new System.Drawing.Size(141, 25);
            this.tbx_all_income.TabIndex = 3;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(90, 178);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(79, 42);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "计算";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_calculate_MouseClick);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(294, 178);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(79, 42);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_reset_MouseClick);
            // 
            // lbl_should_tax
            // 
            this.lbl_should_tax.AutoSize = true;
            this.lbl_should_tax.Location = new System.Drawing.Point(90, 273);
            this.lbl_should_tax.Name = "lbl_should_tax";
            this.lbl_should_tax.Size = new System.Drawing.Size(67, 15);
            this.lbl_should_tax.TabIndex = 6;
            this.lbl_should_tax.Text = "应缴税款";
            // 
            // tbx_should_tax
            // 
            this.tbx_should_tax.Location = new System.Drawing.Point(232, 270);
            this.tbx_should_tax.Name = "tbx_should_tax";
            this.tbx_should_tax.Size = new System.Drawing.Size(141, 25);
            this.tbx_should_tax.TabIndex = 7;
            // 
            // lbl_after_tax_income
            // 
            this.lbl_after_tax_income.AutoSize = true;
            this.lbl_after_tax_income.Location = new System.Drawing.Point(91, 335);
            this.lbl_after_tax_income.Name = "lbl_after_tax_income";
            this.lbl_after_tax_income.Size = new System.Drawing.Size(67, 15);
            this.lbl_after_tax_income.TabIndex = 8;
            this.lbl_after_tax_income.Text = "税后收入";
            // 
            // tbx_after_tax_income
            // 
            this.tbx_after_tax_income.Location = new System.Drawing.Point(232, 331);
            this.tbx_after_tax_income.Name = "tbx_after_tax_income";
            this.tbx_after_tax_income.Size = new System.Drawing.Size(141, 25);
            this.tbx_after_tax_income.TabIndex = 9;
            // 
            // cbx_income_type
            // 
            this.cbx_income_type.FormattingEnabled = true;
            this.cbx_income_type.Items.AddRange(new object[] {
            "综合所得适用",
            "经营所得适用",
            "个体工商户的经营所得及企业所得适用",
            "劳务报酬所得适用"});
            this.cbx_income_type.Location = new System.Drawing.Point(232, 50);
            this.cbx_income_type.Name = "cbx_income_type";
            this.cbx_income_type.Size = new System.Drawing.Size(141, 23);
            this.cbx_income_type.TabIndex = 10;
            this.cbx_income_type.Text = "请选择";
            this.cbx_income_type.SelectedIndexChanged += new System.EventHandler(this.cbx_income_type_SelectedIndexChanged);
            // 
            // lbl_should_tax_unit
            // 
            this.lbl_should_tax_unit.AutoSize = true;
            this.lbl_should_tax_unit.Location = new System.Drawing.Point(379, 275);
            this.lbl_should_tax_unit.Name = "lbl_should_tax_unit";
            this.lbl_should_tax_unit.Size = new System.Drawing.Size(22, 15);
            this.lbl_should_tax_unit.TabIndex = 11;
            this.lbl_should_tax_unit.Text = "元";
            // 
            // lbl_after_income_unit
            // 
            this.lbl_after_income_unit.AutoSize = true;
            this.lbl_after_income_unit.Location = new System.Drawing.Point(379, 336);
            this.lbl_after_income_unit.Name = "lbl_after_income_unit";
            this.lbl_after_income_unit.Size = new System.Drawing.Size(22, 15);
            this.lbl_after_income_unit.TabIndex = 12;
            this.lbl_after_income_unit.Text = "元";
            // 
            // Form_calculcator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.lbl_after_income_unit);
            this.Controls.Add(this.lbl_should_tax_unit);
            this.Controls.Add(this.cbx_income_type);
            this.Controls.Add(this.tbx_after_tax_income);
            this.Controls.Add(this.lbl_after_tax_income);
            this.Controls.Add(this.tbx_should_tax);
            this.Controls.Add(this.lbl_should_tax);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.tbx_all_income);
            this.Controls.Add(this.lbl_all_income);
            this.Controls.Add(this.lbl_income_type);
            this.Name = "Form_calculcator";
            this.Text = "个人所得税计算器";
            this.Load += new System.EventHandler(this.Form_calculcator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_income_type;
        private System.Windows.Forms.Label lbl_all_income;
        private System.Windows.Forms.TextBox tbx_all_income;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_should_tax;
        private System.Windows.Forms.TextBox tbx_should_tax;
        private System.Windows.Forms.Label lbl_after_tax_income;
        private System.Windows.Forms.TextBox tbx_after_tax_income;
        private System.Windows.Forms.ComboBox cbx_income_type;
        private System.Windows.Forms.Label lbl_should_tax_unit;
        private System.Windows.Forms.Label lbl_after_income_unit;
    }
}

