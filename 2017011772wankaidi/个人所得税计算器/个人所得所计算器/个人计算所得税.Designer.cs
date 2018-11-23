namespace WindowsFormsApplication2
{
    partial class 个人所得税计算器
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
            this.bt_add = new System.Windows.Forms.Button();
            this.lb_Personal_income_tax_calculator = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.lb_income_all = new System.Windows.Forms.Label();
            this.lb_income_type = new System.Windows.Forms.Label();
            this.lb_Tax_payable = new System.Windows.Forms.Label();
            this.lb_After_tax_input = new System.Windows.Forms.Label();
            this.cmb_income_type = new System.Windows.Forms.ComboBox();
            this.tb_income_all = new System.Windows.Forms.TextBox();
            this.tb_Tax_payable = new System.Windows.Forms.TextBox();
            this.tb_After_tax_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(700, 202);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Personal_income_tax_calculator
            // 
            this.lb_Personal_income_tax_calculator.AutoSize = true;
            this.lb_Personal_income_tax_calculator.Font = new System.Drawing.Font("宋体", 30F);
            this.lb_Personal_income_tax_calculator.Location = new System.Drawing.Point(427, 61);
            this.lb_Personal_income_tax_calculator.Name = "lb_Personal_income_tax_calculator";
            this.lb_Personal_income_tax_calculator.Size = new System.Drawing.Size(337, 40);
            this.lb_Personal_income_tax_calculator.TabIndex = 1;
            this.lb_Personal_income_tax_calculator.Text = "个人所得税计算器";
            this.lb_Personal_income_tax_calculator.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(700, 238);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_calculate
            // 
            this.bt_calculate.Location = new System.Drawing.Point(569, 238);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(75, 23);
            this.bt_calculate.TabIndex = 3;
            this.bt_calculate.Text = "计算";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_income_all
            // 
            this.lb_income_all.AutoSize = true;
            this.lb_income_all.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_income_all.Location = new System.Drawing.Point(411, 206);
            this.lb_income_all.Name = "lb_income_all";
            this.lb_income_all.Size = new System.Drawing.Size(89, 20);
            this.lb_income_all.TabIndex = 4;
            this.lb_income_all.Text = "收入总额";
            // 
            // lb_income_type
            // 
            this.lb_income_type.AutoSize = true;
            this.lb_income_type.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_income_type.Location = new System.Drawing.Point(411, 163);
            this.lb_income_type.Name = "lb_income_type";
            this.lb_income_type.Size = new System.Drawing.Size(89, 20);
            this.lb_income_type.TabIndex = 5;
            this.lb_income_type.Text = "收入类型";
            // 
            // lb_Tax_payable
            // 
            this.lb_Tax_payable.AutoSize = true;
            this.lb_Tax_payable.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_Tax_payable.Location = new System.Drawing.Point(411, 281);
            this.lb_Tax_payable.Name = "lb_Tax_payable";
            this.lb_Tax_payable.Size = new System.Drawing.Size(129, 20);
            this.lb_Tax_payable.TabIndex = 6;
            this.lb_Tax_payable.Text = "应纳税款(元)";
            // 
            // lb_After_tax_input
            // 
            this.lb_After_tax_input.AutoSize = true;
            this.lb_After_tax_input.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_After_tax_input.Location = new System.Drawing.Point(411, 333);
            this.lb_After_tax_input.Name = "lb_After_tax_input";
            this.lb_After_tax_input.Size = new System.Drawing.Size(139, 20);
            this.lb_After_tax_input.TabIndex = 7;
            this.lb_After_tax_input.Text = "税后输入(元）";
            // 
            // cmb_income_type
            // 
            this.cmb_income_type.AutoCompleteCustomSource.AddRange(new string[] {
            "综合个人所得税"});
            this.cmb_income_type.FormattingEnabled = true;
            this.cmb_income_type.Items.AddRange(new object[] {
            "年终奖"});
            this.cmb_income_type.Location = new System.Drawing.Point(548, 163);
            this.cmb_income_type.Name = "cmb_income_type";
            this.cmb_income_type.Size = new System.Drawing.Size(121, 20);
            this.cmb_income_type.TabIndex = 8;
            this.cmb_income_type.Text = "综合个人所得税 ";
            this.cmb_income_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_income_all
            // 
            this.tb_income_all.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_income_all.Location = new System.Drawing.Point(560, 202);
            this.tb_income_all.Name = "tb_income_all";
            this.tb_income_all.Size = new System.Drawing.Size(100, 21);
            this.tb_income_all.TabIndex = 10;
            this.tb_income_all.UseWaitCursor = true;
            this.tb_income_all.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_Tax_payable
            // 
            this.tb_Tax_payable.Location = new System.Drawing.Point(560, 276);
            this.tb_Tax_payable.Name = "tb_Tax_payable";
            this.tb_Tax_payable.Size = new System.Drawing.Size(100, 21);
            this.tb_Tax_payable.TabIndex = 11;
            this.tb_Tax_payable.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_After_tax_input
            // 
            this.tb_After_tax_input.Location = new System.Drawing.Point(560, 333);
            this.tb_After_tax_input.Name = "tb_After_tax_input";
            this.tb_After_tax_input.Size = new System.Drawing.Size(100, 21);
            this.tb_After_tax_input.TabIndex = 12;
            this.tb_After_tax_input.TextChanged += new System.EventHandler(this.tb_After_tax_input_TextChanged);
            // 
            // 个人所得税计算器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 523);
            this.Controls.Add(this.tb_After_tax_input);
            this.Controls.Add(this.tb_Tax_payable);
            this.Controls.Add(this.tb_income_all);
            this.Controls.Add(this.cmb_income_type);
            this.Controls.Add(this.lb_After_tax_input);
            this.Controls.Add(this.lb_Tax_payable);
            this.Controls.Add(this.lb_income_type);
            this.Controls.Add(this.lb_income_all);
            this.Controls.Add(this.bt_calculate);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.lb_Personal_income_tax_calculator);
            this.Controls.Add(this.bt_add);
            this.Name = "个人所得税计算器";
            this.Text = "个人所得税计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label lb_Personal_income_tax_calculator;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.Label lb_income_all;
        private System.Windows.Forms.Label lb_income_type;
        private System.Windows.Forms.Label lb_Tax_payable;
        private System.Windows.Forms.Label lb_After_tax_input;
        private System.Windows.Forms.ComboBox cmb_income_type;
        private System.Windows.Forms.TextBox tb_income_all;
        private System.Windows.Forms.TextBox tb_Tax_payable;
        private System.Windows.Forms.TextBox tb_After_tax_input;
    }
}

