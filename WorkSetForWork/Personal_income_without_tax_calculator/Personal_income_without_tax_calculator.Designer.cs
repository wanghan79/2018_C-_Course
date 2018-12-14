namespace Personal_income_without_tax_calculator
{
    partial class Personal_income_without_tax_calculator
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
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_income_kind = new System.Windows.Forms.Label();
            this.lab_income_total = new System.Windows.Forms.Label();
            this.txt_income_total = new System.Windows.Forms.TextBox();
            this.btn_calculator = new System.Windows.Forms.Button();
            this.cmb_income_kind = new System.Windows.Forms.ComboBox();
            this.lab_tax = new System.Windows.Forms.Label();
            this.lab_real_income = new System.Windows.Forms.Label();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_real_income = new System.Windows.Forms.TextBox();
            this.lbl_yuan = new System.Windows.Forms.Label();
            this.lbl_yuan_1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.timer_limit_10 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_name.Location = new System.Drawing.Point(96, 51);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(287, 34);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "个人所得税计算器";
            // 
            // lab_income_kind
            // 
            this.lab_income_kind.AutoSize = true;
            this.lab_income_kind.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_income_kind.Location = new System.Drawing.Point(66, 154);
            this.lab_income_kind.Name = "lab_income_kind";
            this.lab_income_kind.Size = new System.Drawing.Size(85, 19);
            this.lab_income_kind.TabIndex = 1;
            this.lab_income_kind.Text = "收入类型";
            // 
            // lab_income_total
            // 
            this.lab_income_total.AutoSize = true;
            this.lab_income_total.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_income_total.Location = new System.Drawing.Point(66, 201);
            this.lab_income_total.Name = "lab_income_total";
            this.lab_income_total.Size = new System.Drawing.Size(85, 19);
            this.lab_income_total.TabIndex = 2;
            this.lab_income_total.Text = "收入总额";
            // 
            // txt_income_total
            // 
            this.txt_income_total.Location = new System.Drawing.Point(157, 199);
            this.txt_income_total.Name = "txt_income_total";
            this.txt_income_total.Size = new System.Drawing.Size(100, 21);
            this.txt_income_total.TabIndex = 4;
            // 
            // btn_calculator
            // 
            this.btn_calculator.Location = new System.Drawing.Point(102, 237);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(75, 23);
            this.btn_calculator.TabIndex = 5;
            this.btn_calculator.Text = "计算";
            this.btn_calculator.UseVisualStyleBackColor = true;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // cmb_income_kind
            // 
            this.cmb_income_kind.FormattingEnabled = true;
            this.cmb_income_kind.Items.AddRange(new object[] {
            "",
            "综合所得适用",
            "经营所得适用",
            "生产经营、承包承租所得适用",
            "劳动报酬所得适用"});
            this.cmb_income_kind.Location = new System.Drawing.Point(157, 153);
            this.cmb_income_kind.Name = "cmb_income_kind";
            this.cmb_income_kind.Size = new System.Drawing.Size(168, 20);
            this.cmb_income_kind.TabIndex = 6;
            this.cmb_income_kind.TextChanged += new System.EventHandler(this.cmb_type_TextChanged);
            // 
            // lab_tax
            // 
            this.lab_tax.AutoSize = true;
            this.lab_tax.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tax.Location = new System.Drawing.Point(66, 281);
            this.lab_tax.Name = "lab_tax";
            this.lab_tax.Size = new System.Drawing.Size(85, 19);
            this.lab_tax.TabIndex = 2;
            this.lab_tax.Text = "应纳税款";
            // 
            // lab_real_income
            // 
            this.lab_real_income.AutoSize = true;
            this.lab_real_income.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_real_income.Location = new System.Drawing.Point(66, 323);
            this.lab_real_income.Name = "lab_real_income";
            this.lab_real_income.Size = new System.Drawing.Size(85, 19);
            this.lab_real_income.TabIndex = 2;
            this.lab_real_income.Text = "税后收入";
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(157, 281);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(100, 21);
            this.txt_tax.TabIndex = 4;
            // 
            // txt_real_income
            // 
            this.txt_real_income.Location = new System.Drawing.Point(157, 321);
            this.txt_real_income.Name = "txt_real_income";
            this.txt_real_income.Size = new System.Drawing.Size(100, 21);
            this.txt_real_income.TabIndex = 4;
            // 
            // lbl_yuan
            // 
            this.lbl_yuan.AutoSize = true;
            this.lbl_yuan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_yuan.Location = new System.Drawing.Point(263, 321);
            this.lbl_yuan.Name = "lbl_yuan";
            this.lbl_yuan.Size = new System.Drawing.Size(24, 16);
            this.lbl_yuan.TabIndex = 2;
            this.lbl_yuan.Text = "元";
            // 
            // lbl_yuan_1
            // 
            this.lbl_yuan_1.AutoSize = true;
            this.lbl_yuan_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_yuan_1.Location = new System.Drawing.Point(263, 286);
            this.lbl_yuan_1.Name = "lbl_yuan_1";
            this.lbl_yuan_1.Size = new System.Drawing.Size(24, 16);
            this.lbl_yuan_1.TabIndex = 2;
            this.lbl_yuan_1.Text = "元";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(212, 237);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // timer_limit_10
            // 
            this.timer_limit_10.Enabled = true;
            this.timer_limit_10.Interval = 10000;
            this.timer_limit_10.Tick += new System.EventHandler(this.timer_limit_10_Tick);
            // 
            // Personal_income_without_tax_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 388);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cmb_income_kind);
            this.Controls.Add(this.btn_calculator);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_real_income);
            this.Controls.Add(this.txt_income_total);
            this.Controls.Add(this.lab_real_income);
            this.Controls.Add(this.lbl_yuan_1);
            this.Controls.Add(this.lbl_yuan);
            this.Controls.Add(this.lab_tax);
            this.Controls.Add(this.lab_income_total);
            this.Controls.Add(this.lab_income_kind);
            this.Controls.Add(this.lab_name);
            this.Name = "Personal_income_without_tax_calculator";
            this.Text = "Personal_income_without_tax_calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_income_kind;
        private System.Windows.Forms.Label lab_income_total;
        private System.Windows.Forms.TextBox txt_income_total;
        private System.Windows.Forms.Button btn_calculator;
        private System.Windows.Forms.ComboBox cmb_income_kind;
        private System.Windows.Forms.Label lab_tax;
        private System.Windows.Forms.Label lab_real_income;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_real_income;
        private System.Windows.Forms.Label lbl_yuan;
        private System.Windows.Forms.Label lbl_yuan_1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Timer timer_limit_10;
    }
}

