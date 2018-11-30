namespace person_tax_cal
{
    partial class person_tax_calculate
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
            this.labTitle = new System.Windows.Forms.Label();
            this.labIncountType = new System.Windows.Forms.Label();
            this.labIncountAll = new System.Windows.Forms.Label();
            this.txt_incount_all = new System.Windows.Forms.TextBox();
            this.txt_incount_type = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.but_calculate = new System.Windows.Forms.Button();
            this.but_reset = new System.Windows.Forms.Button();
            this.labTaxDemand = new System.Windows.Forms.Label();
            this.labIncountAfterTax = new System.Windows.Forms.Label();
            this.txt_tax_demand = new System.Windows.Forms.TextBox();
            this.txt_incount_after_tax = new System.Windows.Forms.TextBox();
            this.lab_RMB1 = new System.Windows.Forms.Label();
            this.lab_RMB2 = new System.Windows.Forms.Label();
            this.cmb_incount_type = new System.Windows.Forms.ComboBox();
            this.time_cal = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(114, 30);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(161, 19);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "个人所得税计算器";
            // 
            // labIncountType
            // 
            this.labIncountType.AutoSize = true;
            this.labIncountType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labIncountType.Location = new System.Drawing.Point(44, 77);
            this.labIncountType.Name = "labIncountType";
            this.labIncountType.Size = new System.Drawing.Size(63, 14);
            this.labIncountType.TabIndex = 1;
            this.labIncountType.Text = "收入类型";
            // 
            // labIncountAll
            // 
            this.labIncountAll.AutoSize = true;
            this.labIncountAll.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labIncountAll.Location = new System.Drawing.Point(44, 122);
            this.labIncountAll.Name = "labIncountAll";
            this.labIncountAll.Size = new System.Drawing.Size(63, 14);
            this.labIncountAll.TabIndex = 2;
            this.labIncountAll.Text = "收入总额";
            // 
            // txt_incount_all
            // 
            this.txt_incount_all.Location = new System.Drawing.Point(138, 121);
            this.txt_incount_all.Name = "txt_incount_all";
            this.txt_incount_all.Size = new System.Drawing.Size(115, 21);
            this.txt_incount_all.TabIndex = 3;
            this.txt_incount_all.TextChanged += new System.EventHandler(this.txt_incount_all_TextChanged);
            // 
            // txt_incount_type
            // 
            this.txt_incount_type.Location = new System.Drawing.Point(276, 76);
            this.txt_incount_type.Name = "txt_incount_type";
            this.txt_incount_type.Size = new System.Drawing.Size(75, 21);
            this.txt_incount_type.TabIndex = 4;
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_add.Location = new System.Drawing.Point(276, 119);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 5;
            this.but_add.Text = "添加";
            this.but_add.UseVisualStyleBackColor = true;
            // 
            // but_calculate
            // 
            this.but_calculate.Location = new System.Drawing.Point(150, 174);
            this.but_calculate.Name = "but_calculate";
            this.but_calculate.Size = new System.Drawing.Size(75, 23);
            this.but_calculate.TabIndex = 6;
            this.but_calculate.Text = "计算";
            this.but_calculate.UseVisualStyleBackColor = true;
            this.but_calculate.Click += new System.EventHandler(this.but_calculate_Click);
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(276, 174);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(75, 23);
            this.but_reset.TabIndex = 7;
            this.but_reset.Text = "重新计时";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // labTaxDemand
            // 
            this.labTaxDemand.AutoSize = true;
            this.labTaxDemand.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTaxDemand.Location = new System.Drawing.Point(45, 229);
            this.labTaxDemand.Name = "labTaxDemand";
            this.labTaxDemand.Size = new System.Drawing.Size(63, 14);
            this.labTaxDemand.TabIndex = 8;
            this.labTaxDemand.Text = "应纳税款";
            // 
            // labIncountAfterTax
            // 
            this.labIncountAfterTax.AutoSize = true;
            this.labIncountAfterTax.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labIncountAfterTax.Location = new System.Drawing.Point(46, 274);
            this.labIncountAfterTax.Name = "labIncountAfterTax";
            this.labIncountAfterTax.Size = new System.Drawing.Size(63, 14);
            this.labIncountAfterTax.TabIndex = 9;
            this.labIncountAfterTax.Text = "税后收入";
            // 
            // txt_tax_demand
            // 
            this.txt_tax_demand.Location = new System.Drawing.Point(138, 229);
            this.txt_tax_demand.Name = "txt_tax_demand";
            this.txt_tax_demand.Size = new System.Drawing.Size(115, 21);
            this.txt_tax_demand.TabIndex = 10;
            // 
            // txt_incount_after_tax
            // 
            this.txt_incount_after_tax.Location = new System.Drawing.Point(138, 273);
            this.txt_incount_after_tax.Name = "txt_incount_after_tax";
            this.txt_incount_after_tax.Size = new System.Drawing.Size(115, 21);
            this.txt_incount_after_tax.TabIndex = 11;
            // 
            // lab_RMB1
            // 
            this.lab_RMB1.AutoSize = true;
            this.lab_RMB1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_RMB1.Location = new System.Drawing.Point(273, 230);
            this.lab_RMB1.Name = "lab_RMB1";
            this.lab_RMB1.Size = new System.Drawing.Size(21, 14);
            this.lab_RMB1.TabIndex = 12;
            this.lab_RMB1.Text = "元";
            // 
            // lab_RMB2
            // 
            this.lab_RMB2.AutoSize = true;
            this.lab_RMB2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_RMB2.Location = new System.Drawing.Point(273, 280);
            this.lab_RMB2.Name = "lab_RMB2";
            this.lab_RMB2.Size = new System.Drawing.Size(21, 14);
            this.lab_RMB2.TabIndex = 13;
            this.lab_RMB2.Text = "元";
            // 
            // cmb_incount_type
            // 
            this.cmb_incount_type.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_incount_type.FormattingEnabled = true;
            this.cmb_incount_type.Items.AddRange(new object[] {
            "综合所得适用",
            "经营所得适用",
            "生产经营、承包承租所得适用",
            "劳动报酬所得适用"});
            this.cmb_incount_type.Location = new System.Drawing.Point(138, 77);
            this.cmb_incount_type.Name = "cmb_incount_type";
            this.cmb_incount_type.Size = new System.Drawing.Size(115, 20);
            this.cmb_incount_type.TabIndex = 14;
            this.cmb_incount_type.TextChanged += new System.EventHandler(this.cmb_incount_type_TextChanged);
            // 
            // time_cal
            // 
            this.time_cal.Enabled = true;
            this.time_cal.Interval = 30000;
            this.time_cal.Tick += new System.EventHandler(this.time_cal_Tick);
            // 
            // person_tax_calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 408);
            this.Controls.Add(this.cmb_incount_type);
            this.Controls.Add(this.lab_RMB2);
            this.Controls.Add(this.lab_RMB1);
            this.Controls.Add(this.txt_incount_after_tax);
            this.Controls.Add(this.txt_tax_demand);
            this.Controls.Add(this.labIncountAfterTax);
            this.Controls.Add(this.labTaxDemand);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.but_calculate);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.txt_incount_type);
            this.Controls.Add(this.txt_incount_all);
            this.Controls.Add(this.labIncountAll);
            this.Controls.Add(this.labIncountType);
            this.Controls.Add(this.labTitle);
            this.Name = "person_tax_calculate";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labIncountType;
        private System.Windows.Forms.Label labIncountAll;
        private System.Windows.Forms.TextBox txt_incount_all;
        private System.Windows.Forms.TextBox txt_incount_type;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_calculate;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Label labTaxDemand;
        private System.Windows.Forms.Label labIncountAfterTax;
        private System.Windows.Forms.TextBox txt_tax_demand;
        private System.Windows.Forms.TextBox txt_incount_after_tax;
        private System.Windows.Forms.Label lab_RMB1;
        private System.Windows.Forms.Label lab_RMB2;
        private System.Windows.Forms.ComboBox cmb_incount_type;
        private System.Windows.Forms.Timer time_cal;
    }
}

