namespace WindowsFormsApp1
{
    partial class PersonalTaxCalculator
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
            this.button1_Calculate = new System.Windows.Forms.Button();
            this.button2_Reset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1_IncomeTypeSelect = new System.Windows.Forms.ComboBox();
            this.label1_IncomeType = new System.Windows.Forms.Label();
            this.label2_IncomeSum = new System.Windows.Forms.Label();
            this.label3_TaxPayable = new System.Windows.Forms.Label();
            this.textBox1_IncomeSum = new System.Windows.Forms.TextBox();
            this.textBox2_TaxPayable = new System.Windows.Forms.TextBox();
            this.textBox3_AfterTaxIncome = new System.Windows.Forms.TextBox();
            this.label4_AfterTaxIncome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_Calculate
            // 
            this.button1_Calculate.Location = new System.Drawing.Point(93, 138);
            this.button1_Calculate.Name = "button1_Calculate";
            this.button1_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button1_Calculate.TabIndex = 0;
            this.button1_Calculate.Text = "计算";
            this.button1_Calculate.UseVisualStyleBackColor = true;
            this.button1_Calculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_Calculate_MouseClick);
            // 
            // button2_Reset
            // 
            this.button2_Reset.Location = new System.Drawing.Point(224, 138);
            this.button2_Reset.Name = "button2_Reset";
            this.button2_Reset.Size = new System.Drawing.Size(75, 23);
            this.button2_Reset.TabIndex = 1;
            this.button2_Reset.Text = "重置";
            this.button2_Reset.UseVisualStyleBackColor = true;
            this.button2_Reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_Reset_MouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1_IncomeTypeSelect
            // 
            this.comboBox1_IncomeTypeSelect.FormattingEnabled = true;
            this.comboBox1_IncomeTypeSelect.Items.AddRange(new object[] {
            "收入类型1",
            "收入类型2",
            "收入类型3",
            "收入类型4"});
            this.comboBox1_IncomeTypeSelect.Location = new System.Drawing.Point(211, 30);
            this.comboBox1_IncomeTypeSelect.Name = "comboBox1_IncomeTypeSelect";
            this.comboBox1_IncomeTypeSelect.Size = new System.Drawing.Size(121, 23);
            this.comboBox1_IncomeTypeSelect.TabIndex = 3;
            this.comboBox1_IncomeTypeSelect.Text = "收入类型选择";
            this.comboBox1_IncomeTypeSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_IncomeTypeSelect_SelectedIndexChanged);
            // 
            // label1_IncomeType
            // 
            this.label1_IncomeType.AutoSize = true;
            this.label1_IncomeType.Location = new System.Drawing.Point(90, 38);
            this.label1_IncomeType.Name = "label1_IncomeType";
            this.label1_IncomeType.Size = new System.Drawing.Size(67, 15);
            this.label1_IncomeType.TabIndex = 4;
            this.label1_IncomeType.Text = "收入类型";
            // 
            // label2_IncomeSum
            // 
            this.label2_IncomeSum.AutoSize = true;
            this.label2_IncomeSum.Location = new System.Drawing.Point(99, 97);
            this.label2_IncomeSum.Name = "label2_IncomeSum";
            this.label2_IncomeSum.Size = new System.Drawing.Size(67, 15);
            this.label2_IncomeSum.TabIndex = 5;
            this.label2_IncomeSum.Text = "收入总额";
            // 
            // label3_TaxPayable
            // 
            this.label3_TaxPayable.AutoSize = true;
            this.label3_TaxPayable.Location = new System.Drawing.Point(90, 265);
            this.label3_TaxPayable.Name = "label3_TaxPayable";
            this.label3_TaxPayable.Size = new System.Drawing.Size(67, 15);
            this.label3_TaxPayable.TabIndex = 6;
            this.label3_TaxPayable.Text = "应缴税款";
            // 
            // textBox1_IncomeSum
            // 
            this.textBox1_IncomeSum.Location = new System.Drawing.Point(214, 94);
            this.textBox1_IncomeSum.Name = "textBox1_IncomeSum";
            this.textBox1_IncomeSum.Size = new System.Drawing.Size(100, 25);
            this.textBox1_IncomeSum.TabIndex = 7;
            this.textBox1_IncomeSum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2_TaxPayable
            // 
            this.textBox2_TaxPayable.Location = new System.Drawing.Point(224, 255);
            this.textBox2_TaxPayable.Name = "textBox2_TaxPayable";
            this.textBox2_TaxPayable.Size = new System.Drawing.Size(100, 25);
            this.textBox2_TaxPayable.TabIndex = 8;
            // 
            // textBox3_AfterTaxIncome
            // 
            this.textBox3_AfterTaxIncome.Location = new System.Drawing.Point(224, 334);
            this.textBox3_AfterTaxIncome.Name = "textBox3_AfterTaxIncome";
            this.textBox3_AfterTaxIncome.Size = new System.Drawing.Size(100, 25);
            this.textBox3_AfterTaxIncome.TabIndex = 9;
            // 
            // label4_AfterTaxIncome
            // 
            this.label4_AfterTaxIncome.AutoSize = true;
            this.label4_AfterTaxIncome.Location = new System.Drawing.Point(93, 343);
            this.label4_AfterTaxIncome.Name = "label4_AfterTaxIncome";
            this.label4_AfterTaxIncome.Size = new System.Drawing.Size(67, 15);
            this.label4_AfterTaxIncome.TabIndex = 10;
            this.label4_AfterTaxIncome.Text = "税后收入";
            // 
            // PersonalTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4_AfterTaxIncome);
            this.Controls.Add(this.textBox3_AfterTaxIncome);
            this.Controls.Add(this.textBox2_TaxPayable);
            this.Controls.Add(this.textBox1_IncomeSum);
            this.Controls.Add(this.label3_TaxPayable);
            this.Controls.Add(this.label2_IncomeSum);
            this.Controls.Add(this.label1_IncomeType);
            this.Controls.Add(this.comboBox1_IncomeTypeSelect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2_Reset);
            this.Controls.Add(this.button1_Calculate);
            this.Name = "PersonalTaxCalculator";
            this.Text = "PersonalTaxCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Calculate;
        private System.Windows.Forms.Button button2_Reset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1_IncomeTypeSelect;
        private System.Windows.Forms.Label label1_IncomeType;
        private System.Windows.Forms.Label label2_IncomeSum;
        private System.Windows.Forms.Label label3_TaxPayable;
        private System.Windows.Forms.TextBox textBox1_IncomeSum;
        private System.Windows.Forms.TextBox textBox2_TaxPayable;
        private System.Windows.Forms.TextBox textBox3_AfterTaxIncome;
        private System.Windows.Forms.Label label4_AfterTaxIncome;
    }
}

