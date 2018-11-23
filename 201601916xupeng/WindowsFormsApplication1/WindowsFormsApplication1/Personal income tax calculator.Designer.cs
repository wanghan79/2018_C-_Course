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
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_tax = new System.Windows.Forms.TextBox();
            this.textBox_income = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(148, 164);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 0;
            this.button_calculate.Text = "计算";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_calculate_MouseClick);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(353, 163);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_reset_MouseClick);
            // 
            // comboBox_type
            // 
            this.comboBox_type.AutoCompleteCustomSource.AddRange(new string[] {
            "工资，薪水所得",
            "个体工商户生产所得",
            "对企业事业单位的所得",
            "劳务报酬所得",
            "稿酬所得",
            "特许权使用费所得",
            "利息，股息，红利所得",
            "财产租赁所得"});
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "工资，薪水所得",
            "个体工商户生产所得",
            "对企业事业单位的所得",
            "劳务报酬所得",
            "稿酬所得",
            "特许权使用费所得",
            "利息，股息，红利所得",
            "财产租赁所得"});
            this.comboBox_type.Location = new System.Drawing.Point(148, 47);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 20);
            this.comboBox_type.TabIndex = 2;
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(148, 105);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(100, 21);
            this.textBox_total.TabIndex = 3;
            // 
            // textBox_tax
            // 
            this.textBox_tax.Location = new System.Drawing.Point(148, 241);
            this.textBox_tax.Name = "textBox_tax";
            this.textBox_tax.Size = new System.Drawing.Size(100, 21);
            this.textBox_tax.TabIndex = 4;
            // 
            // textBox_income
            // 
            this.textBox_income.Location = new System.Drawing.Point(148, 306);
            this.textBox_income.Name = "textBox_income";
            this.textBox_income.Size = new System.Drawing.Size(100, 21);
            this.textBox_income.TabIndex = 5;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(206, 13);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(101, 12);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "个人所得税计算器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "收入类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "收入总额";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "应纳税款";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "税后收入";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "元";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(332, 102);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 456);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_income);
            this.Controls.Add(this.textBox_tax);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_calculate);
            this.Name = "Form1";
            this.Text = "Personal income tax calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_tax;
        private System.Windows.Forms.TextBox textBox_income;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_add;
    }
}

