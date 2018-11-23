namespace WindowsFormsApplication2
{
    partial class taxCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tax_type = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_toPay = new System.Windows.Forms.Label();
            this.lbl_afterTax = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.txt_income = new System.Windows.Forms.TextBox();
            this.txt_toPay = new System.Windows.Forms.TextBox();
            this.txt_afterTax = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(164, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "个人所得税计算器";
            // 
            // lbl_tax_type
            // 
            this.lbl_tax_type.AutoSize = true;
            this.lbl_tax_type.Location = new System.Drawing.Point(115, 78);
            this.lbl_tax_type.Name = "lbl_tax_type";
            this.lbl_tax_type.Size = new System.Drawing.Size(53, 12);
            this.lbl_tax_type.TabIndex = 1;
            this.lbl_tax_type.Text = "收入类型";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Location = new System.Drawing.Point(117, 137);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(53, 12);
            this.lbl_income.TabIndex = 2;
            this.lbl_income.Text = "收入总额";
            // 
            // lbl_toPay
            // 
            this.lbl_toPay.AutoSize = true;
            this.lbl_toPay.Location = new System.Drawing.Point(117, 223);
            this.lbl_toPay.Name = "lbl_toPay";
            this.lbl_toPay.Size = new System.Drawing.Size(53, 12);
            this.lbl_toPay.TabIndex = 3;
            this.lbl_toPay.Text = "应纳税款";
            // 
            // lbl_afterTax
            // 
            this.lbl_afterTax.AutoSize = true;
            this.lbl_afterTax.Location = new System.Drawing.Point(117, 279);
            this.lbl_afterTax.Name = "lbl_afterTax";
            this.lbl_afterTax.Size = new System.Drawing.Size(53, 12);
            this.lbl_afterTax.TabIndex = 4;
            this.lbl_afterTax.Text = "税后收入";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "工资、薪金所得税",
            "个体工商户",
            "对企事业单位",
            "劳务报酬",
            "稿酬所得",
            "特许权",
            "利息",
            "租赁"});
            this.cmb_type.Location = new System.Drawing.Point(178, 75);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(187, 20);
            this.cmb_type.TabIndex = 5;
            this.cmb_type.Text = "选择收入类型";
            // 
            // txt_income
            // 
            this.txt_income.Location = new System.Drawing.Point(178, 131);
            this.txt_income.Name = "txt_income";
            this.txt_income.Size = new System.Drawing.Size(186, 21);
            this.txt_income.TabIndex = 6;
            // 
            // txt_toPay
            // 
            this.txt_toPay.Location = new System.Drawing.Point(179, 220);
            this.txt_toPay.Name = "txt_toPay";
            this.txt_toPay.Size = new System.Drawing.Size(186, 21);
            this.txt_toPay.TabIndex = 7;
            // 
            // txt_afterTax
            // 
            this.txt_afterTax.Location = new System.Drawing.Point(179, 276);
            this.txt_afterTax.Name = "txt_afterTax";
            this.txt_afterTax.Size = new System.Drawing.Size(186, 21);
            this.txt_afterTax.TabIndex = 8;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(179, 180);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "计算";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.click_calculate);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(288, 180);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.click_reset);
            // 
            // taxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 381);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_afterTax);
            this.Controls.Add(this.txt_toPay);
            this.Controls.Add(this.txt_income);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.lbl_afterTax);
            this.Controls.Add(this.lbl_toPay);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.lbl_tax_type);
            this.Controls.Add(this.label1);
            this.Name = "taxCalculator";
            this.Text = "taxCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tax_type;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_toPay;
        private System.Windows.Forms.Label lbl_afterTax;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.TextBox txt_income;
        private System.Windows.Forms.TextBox txt_toPay;
        private System.Windows.Forms.TextBox txt_afterTax;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_reset;
    }
}

