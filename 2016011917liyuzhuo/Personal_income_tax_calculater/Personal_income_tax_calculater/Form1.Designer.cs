namespace Personal_income_tax_calculater
{
    partial class Form_PersonalIncomeTaxCalculator
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_amount = new System.Windows.Forms.Label();
            this.lab_tax = new System.Windows.Forms.Label();
            this.lab_income = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_income = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lab_yuan1 = new System.Windows.Forms.Label();
            this.lab_yuan2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(383, 194);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 31);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_calculate.Location = new System.Drawing.Point(195, 254);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(113, 31);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "计算";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.Location = new System.Drawing.Point(383, 254);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 31);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_type.Location = new System.Drawing.Point(27, 129);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(88, 25);
            this.lab_type.TabIndex = 3;
            this.lab_type.Text = "收入类型";
            // 
            // lab_amount
            // 
            this.lab_amount.AutoSize = true;
            this.lab_amount.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_amount.Location = new System.Drawing.Point(27, 200);
            this.lab_amount.Name = "lab_amount";
            this.lab_amount.Size = new System.Drawing.Size(88, 25);
            this.lab_amount.TabIndex = 4;
            this.lab_amount.Text = "收入总额";
            // 
            // lab_tax
            // 
            this.lab_tax.AutoSize = true;
            this.lab_tax.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tax.Location = new System.Drawing.Point(27, 333);
            this.lab_tax.Name = "lab_tax";
            this.lab_tax.Size = new System.Drawing.Size(88, 25);
            this.lab_tax.TabIndex = 5;
            this.lab_tax.Text = "应纳税款";
            // 
            // lab_income
            // 
            this.lab_income.AutoSize = true;
            this.lab_income.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_income.Location = new System.Drawing.Point(27, 413);
            this.lab_income.Name = "lab_income";
            this.lab_income.Size = new System.Drawing.Size(88, 25);
            this.lab_income.TabIndex = 6;
            this.lab_income.Text = "税后收入";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.Location = new System.Drawing.Point(145, 50);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(257, 40);
            this.lab_title.TabIndex = 7;
            this.lab_title.Text = "个人所得税计算器";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_amount.Location = new System.Drawing.Point(152, 197);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(208, 31);
            this.txt_amount.TabIndex = 8;
            // 
            // txt_tax
            // 
            this.txt_tax.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tax.Location = new System.Drawing.Point(152, 327);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(208, 31);
            this.txt_tax.TabIndex = 9;
            // 
            // txt_income
            // 
            this.txt_income.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income.Location = new System.Drawing.Point(152, 407);
            this.txt_income.Name = "txt_income";
            this.txt_income.Size = new System.Drawing.Size(208, 31);
            this.txt_income.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.Items.AddRange(new object[] {
            "工资薪金",
            "个体工商户生产经营",
            "对企事业单位承包经营",
            "承租经营",
            "劳务报酬",
            "稿酬",
            "特许权使用费",
            "利息股息红利",
            "财产租赁",
            "财产转让",
            "偶然所得",
            "其他"});
            this.comboBox1.Location = new System.Drawing.Point(152, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 32);
            this.comboBox1.TabIndex = 11;
            // 
            // lab_yuan1
            // 
            this.lab_yuan1.AutoSize = true;
            this.lab_yuan1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_yuan1.Location = new System.Drawing.Point(378, 333);
            this.lab_yuan1.Name = "lab_yuan1";
            this.lab_yuan1.Size = new System.Drawing.Size(31, 25);
            this.lab_yuan1.TabIndex = 12;
            this.lab_yuan1.Text = "元";
            // 
            // lab_yuan2
            // 
            this.lab_yuan2.AutoSize = true;
            this.lab_yuan2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_yuan2.Location = new System.Drawing.Point(378, 413);
            this.lab_yuan2.Name = "lab_yuan2";
            this.lab_yuan2.Size = new System.Drawing.Size(31, 25);
            this.lab_yuan2.TabIndex = 13;
            this.lab_yuan2.Text = "元";
            // 
            // Form_PersonalIncomeTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 526);
            this.Controls.Add(this.lab_yuan2);
            this.Controls.Add(this.lab_yuan1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_income);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_income);
            this.Controls.Add(this.lab_tax);
            this.Controls.Add(this.lab_amount);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_PersonalIncomeTaxCalculator";
            this.Text = "PersonalIncomeTaxCalculator";
            this.Load += new System.EventHandler(this.Form_PersonalIncomeTaxCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_amount;
        private System.Windows.Forms.Label lab_tax;
        private System.Windows.Forms.Label lab_income;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_income;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lab_yuan1;
        private System.Windows.Forms.Label lab_yuan2;
    }
}

