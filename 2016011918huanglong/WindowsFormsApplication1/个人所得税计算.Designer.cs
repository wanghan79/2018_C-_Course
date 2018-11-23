namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label_incometaxcounter = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_income = new System.Windows.Forms.Label();
            this.label_tax = new System.Windows.Forms.Label();
            this.label_aftertax = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_income = new System.Windows.Forms.TextBox();
            this.textBox_tax = new System.Windows.Forms.TextBox();
            this.textBox_aftertax = new System.Windows.Forms.TextBox();
            this.label_yuan1 = new System.Windows.Forms.Label();
            this.label_yuan2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_count = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_incometaxcounter
            // 
            this.label_incometaxcounter.AutoSize = true;
            this.label_incometaxcounter.Font = new System.Drawing.Font("宋体", 25F);
            this.label_incometaxcounter.Location = new System.Drawing.Point(87, 24);
            this.label_incometaxcounter.Name = "label_incometaxcounter";
            this.label_incometaxcounter.Size = new System.Drawing.Size(287, 34);
            this.label_incometaxcounter.TabIndex = 0;
            this.label_incometaxcounter.Text = "个人所得税计算器";
            this.label_incometaxcounter.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(40, 100);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(53, 12);
            this.label_type.TabIndex = 1;
            this.label_type.Text = "收入类型";
            // 
            // label_income
            // 
            this.label_income.AutoSize = true;
            this.label_income.Location = new System.Drawing.Point(40, 135);
            this.label_income.Name = "label_income";
            this.label_income.Size = new System.Drawing.Size(53, 12);
            this.label_income.TabIndex = 2;
            this.label_income.Text = "收入总额";
            // 
            // label_tax
            // 
            this.label_tax.AutoSize = true;
            this.label_tax.Location = new System.Drawing.Point(43, 277);
            this.label_tax.Name = "label_tax";
            this.label_tax.Size = new System.Drawing.Size(53, 12);
            this.label_tax.TabIndex = 3;
            this.label_tax.Text = "应纳税款";
            // 
            // label_aftertax
            // 
            this.label_aftertax.AutoSize = true;
            this.label_aftertax.Location = new System.Drawing.Point(44, 334);
            this.label_aftertax.Name = "label_aftertax";
            this.label_aftertax.Size = new System.Drawing.Size(53, 12);
            this.label_aftertax.TabIndex = 4;
            this.label_aftertax.Text = "税后收入";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "综合所得适用",
            "经营所得适用",
            "承包经营所得适用"});
            this.comboBox_type.Location = new System.Drawing.Point(99, 100);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 20);
            this.comboBox_type.TabIndex = 5;
            this.comboBox_type.Text = "综合所得适用";
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // textBox_income
            // 
            this.textBox_income.Location = new System.Drawing.Point(99, 135);
            this.textBox_income.Name = "textBox_income";
            this.textBox_income.Size = new System.Drawing.Size(100, 21);
            this.textBox_income.TabIndex = 6;
            this.textBox_income.TextChanged += new System.EventHandler(this.textBox_income_TextChanged);
            // 
            // textBox_tax
            // 
            this.textBox_tax.Location = new System.Drawing.Point(99, 268);
            this.textBox_tax.Name = "textBox_tax";
            this.textBox_tax.Size = new System.Drawing.Size(100, 21);
            this.textBox_tax.TabIndex = 7;
            // 
            // textBox_aftertax
            // 
            this.textBox_aftertax.Location = new System.Drawing.Point(99, 327);
            this.textBox_aftertax.Name = "textBox_aftertax";
            this.textBox_aftertax.Size = new System.Drawing.Size(100, 21);
            this.textBox_aftertax.TabIndex = 8;
            // 
            // label_yuan1
            // 
            this.label_yuan1.AutoSize = true;
            this.label_yuan1.Location = new System.Drawing.Point(206, 274);
            this.label_yuan1.Name = "label_yuan1";
            this.label_yuan1.Size = new System.Drawing.Size(17, 12);
            this.label_yuan1.TabIndex = 9;
            this.label_yuan1.Text = "元";
            // 
            // label_yuan2
            // 
            this.label_yuan2.AutoSize = true;
            this.label_yuan2.Location = new System.Drawing.Point(206, 333);
            this.label_yuan2.Name = "label_yuan2";
            this.label_yuan2.Size = new System.Drawing.Size(17, 12);
            this.label_yuan2.TabIndex = 10;
            this.label_yuan2.Text = "元";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(208, 133);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            this.button_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_add_MouseClick);
            this.button_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_add_MouseDown);
            // 
            // button_count
            // 
            this.button_count.Location = new System.Drawing.Point(99, 196);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(75, 23);
            this.button_count.TabIndex = 12;
            this.button_count.Text = "计算";
            this.button_count.UseVisualStyleBackColor = true;
            this.button_count.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_count_MouseClick);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(208, 196);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_reset_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_count);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_yuan2);
            this.Controls.Add(this.label_yuan1);
            this.Controls.Add(this.textBox_aftertax);
            this.Controls.Add(this.textBox_tax);
            this.Controls.Add(this.textBox_income);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_aftertax);
            this.Controls.Add(this.label_tax);
            this.Controls.Add(this.label_income);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_incometaxcounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_incometaxcounter;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_income;
        private System.Windows.Forms.Label label_tax;
        private System.Windows.Forms.Label label_aftertax;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_income;
        private System.Windows.Forms.TextBox textBox_tax;
        private System.Windows.Forms.TextBox textBox_aftertax;
        private System.Windows.Forms.Label label_yuan1;
        private System.Windows.Forms.Label label_yuan2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.Button button_reset;
    }
}

