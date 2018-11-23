namespace personmoneytax
{
    partial class Form_Taxcalculator
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
            this.Button_Calculate = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.TextBox_Taxmoney = new System.Windows.Forms.TextBox();
            this.TextBox_Aftertaxmoney = new System.Windows.Forms.TextBox();
            this.TextBox_Totalmoney = new System.Windows.Forms.TextBox();
            this.label1_calulatename = new System.Windows.Forms.Label();
            this.Label_Taxtype = new System.Windows.Forms.Label();
            this.Label_Berforetaxmoney = new System.Windows.Forms.Label();
            this.ComboBox_Taxtype = new System.Windows.Forms.ComboBox();
            this.Label_Aftertax = new System.Windows.Forms.Label();
            this.Label_Taxmonet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Calculate
            // 
            this.Button_Calculate.Location = new System.Drawing.Point(163, 232);
            this.Button_Calculate.Name = "Button_Calculate";
            this.Button_Calculate.Size = new System.Drawing.Size(97, 39);
            this.Button_Calculate.TabIndex = 0;
            this.Button_Calculate.Text = "计算";
            this.Button_Calculate.UseVisualStyleBackColor = true;
            this.Button_Calculate.Click += new System.EventHandler(this.Button_Calculate_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(341, 232);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(98, 39);
            this.Button_Reset.TabIndex = 1;
            this.Button_Reset.Text = "重置";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // TextBox_Taxmoney
            // 
            this.TextBox_Taxmoney.Location = new System.Drawing.Point(318, 350);
            this.TextBox_Taxmoney.Name = "TextBox_Taxmoney";
            this.TextBox_Taxmoney.Size = new System.Drawing.Size(121, 25);
            this.TextBox_Taxmoney.TabIndex = 2;
            // 
            // TextBox_Aftertaxmoney
            // 
            this.TextBox_Aftertaxmoney.Location = new System.Drawing.Point(318, 298);
            this.TextBox_Aftertaxmoney.Name = "TextBox_Aftertaxmoney";
            this.TextBox_Aftertaxmoney.Size = new System.Drawing.Size(121, 25);
            this.TextBox_Aftertaxmoney.TabIndex = 3;
            // 
            // TextBox_Totalmoney
            // 
            this.TextBox_Totalmoney.Location = new System.Drawing.Point(318, 88);
            this.TextBox_Totalmoney.Name = "TextBox_Totalmoney";
            this.TextBox_Totalmoney.Size = new System.Drawing.Size(121, 25);
            this.TextBox_Totalmoney.TabIndex = 4;
            // 
            // label1_calulatename
            // 
            this.label1_calulatename.AutoSize = true;
            this.label1_calulatename.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_calulatename.Location = new System.Drawing.Point(259, 40);
            this.label1_calulatename.Name = "label1_calulatename";
            this.label1_calulatename.Size = new System.Drawing.Size(253, 30);
            this.label1_calulatename.TabIndex = 6;
            this.label1_calulatename.Text = "个人所得税计算器";
            // 
            // Label_Taxtype
            // 
            this.Label_Taxtype.AutoSize = true;
            this.Label_Taxtype.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Taxtype.Location = new System.Drawing.Point(149, 163);
            this.Label_Taxtype.Name = "Label_Taxtype";
            this.Label_Taxtype.Size = new System.Drawing.Size(89, 20);
            this.Label_Taxtype.TabIndex = 7;
            this.Label_Taxtype.Text = "税收类型";
            // 
            // Label_Berforetaxmoney
            // 
            this.Label_Berforetaxmoney.AutoSize = true;
            this.Label_Berforetaxmoney.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Berforetaxmoney.Location = new System.Drawing.Point(149, 93);
            this.Label_Berforetaxmoney.Name = "Label_Berforetaxmoney";
            this.Label_Berforetaxmoney.Size = new System.Drawing.Size(69, 20);
            this.Label_Berforetaxmoney.TabIndex = 8;
            this.Label_Berforetaxmoney.Text = "总收入";
            // 
            // ComboBox_Taxtype
            // 
            this.ComboBox_Taxtype.FormattingEnabled = true;
            this.ComboBox_Taxtype.Items.AddRange(new object[] {
            "商业税",
            "个人所得税",
            "增值税"});
            this.ComboBox_Taxtype.Location = new System.Drawing.Point(318, 160);
            this.ComboBox_Taxtype.Name = "ComboBox_Taxtype";
            this.ComboBox_Taxtype.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_Taxtype.TabIndex = 9;
            this.ComboBox_Taxtype.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label_Aftertax
            // 
            this.Label_Aftertax.AutoSize = true;
            this.Label_Aftertax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Aftertax.Location = new System.Drawing.Point(160, 308);
            this.Label_Aftertax.Name = "Label_Aftertax";
            this.Label_Aftertax.Size = new System.Drawing.Size(89, 20);
            this.Label_Aftertax.TabIndex = 10;
            this.Label_Aftertax.Text = "税后收入";
            // 
            // Label_Taxmonet
            // 
            this.Label_Taxmonet.AutoSize = true;
            this.Label_Taxmonet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Taxmonet.Location = new System.Drawing.Point(163, 353);
            this.Label_Taxmonet.Name = "Label_Taxmonet";
            this.Label_Taxmonet.Size = new System.Drawing.Size(49, 20);
            this.Label_Taxmonet.TabIndex = 11;
            this.Label_Taxmonet.Text = "税收";
            // 
            // Form_Taxcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Taxmonet);
            this.Controls.Add(this.Label_Aftertax);
            this.Controls.Add(this.ComboBox_Taxtype);
            this.Controls.Add(this.Label_Berforetaxmoney);
            this.Controls.Add(this.Label_Taxtype);
            this.Controls.Add(this.label1_calulatename);
            this.Controls.Add(this.TextBox_Totalmoney);
            this.Controls.Add(this.TextBox_Aftertaxmoney);
            this.Controls.Add(this.TextBox_Taxmoney);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_Calculate);
            this.Name = "Form_Taxcalculator";
            this.Text = "个人所得税计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Calculate;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.TextBox TextBox_Taxmoney;
        private System.Windows.Forms.TextBox TextBox_Aftertaxmoney;
        private System.Windows.Forms.TextBox TextBox_Totalmoney;
        private System.Windows.Forms.Label label1_calulatename;
        private System.Windows.Forms.Label Label_Taxtype;
        private System.Windows.Forms.Label Label_Berforetaxmoney;
        private System.Windows.Forms.ComboBox ComboBox_Taxtype;
        private System.Windows.Forms.Label Label_Aftertax;
        private System.Windows.Forms.Label Label_Taxmonet;
    }
}

