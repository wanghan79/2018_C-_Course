namespace Personal_Income_Tax_Calculaterr
{
    partial class Form_calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_calculate));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.llb_title = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_income = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(448, 198);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.Location = new System.Drawing.Point(448, 259);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(102, 35);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // llb_title
            // 
            this.llb_title.AutoSize = true;
            this.llb_title.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llb_title.Location = new System.Drawing.Point(181, 38);
            this.llb_title.Name = "llb_title";
            this.llb_title.Size = new System.Drawing.Size(247, 32);
            this.llb_title.TabIndex = 2;
            this.llb_title.Text = "个人所得税计算器";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_type.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "综合所得",
            "经营所得",
            "利息、股息、红利所得，财产租赁所得，财产转让所得和偶然所得",
            "劳务报酬"});
            this.cmb_type.Location = new System.Drawing.Point(202, 133);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(205, 31);
            this.cmb_type.TabIndex = 3;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_type.Location = new System.Drawing.Point(60, 133);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(110, 31);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Text = "收入类型";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_amount.Location = new System.Drawing.Point(60, 199);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(110, 31);
            this.lbl_amount.TabIndex = 5;
            this.lbl_amount.Text = "收入总额";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_amount.Location = new System.Drawing.Point(202, 196);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(205, 34);
            this.txt_amount.TabIndex = 6;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_calculate.Location = new System.Drawing.Point(232, 259);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(137, 35);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "计算";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tax.Location = new System.Drawing.Point(60, 343);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(110, 31);
            this.lbl_tax.TabIndex = 8;
            this.lbl_tax.Text = "应纳税款";
            this.lbl_tax.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_income.Location = new System.Drawing.Point(60, 415);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(110, 31);
            this.lbl_income.TabIndex = 9;
            this.lbl_income.Text = "税后收入";
            // 
            // txt_tax
            // 
            this.txt_tax.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tax.Location = new System.Drawing.Point(202, 349);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.ReadOnly = true;
            this.txt_tax.Size = new System.Drawing.Size(205, 34);
            this.txt_tax.TabIndex = 10;
            // 
            // txt_income
            // 
            this.txt_income.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income.Location = new System.Drawing.Point(202, 415);
            this.txt_income.Name = "txt_income";
            this.txt_income.ReadOnly = true;
            this.txt_income.Size = new System.Drawing.Size(205, 34);
            this.txt_income.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(605, 575);
            this.Controls.Add(this.txt_income);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.llb_title);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label llb_title;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_income;
        
    }
}

