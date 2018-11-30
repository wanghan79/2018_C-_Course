namespace taxcaculate
{
    partial class Form_tax
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
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_total = new System.Windows.Forms.Label();
            this.lab_aftertax = new System.Windows.Forms.Label();
            this.lab_tax = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_afertax = new System.Windows.Forms.TextBox();
            this.label_yuan2 = new System.Windows.Forms.Label();
            this.label_yuan1 = new System.Windows.Forms.Label();
            this.btn_compute = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.com_type = new System.Windows.Forms.ComboBox();
            this.tim_savefile = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.Location = new System.Drawing.Point(232, 54);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(245, 29);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "个人所得税计算器";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_type.Location = new System.Drawing.Point(119, 131);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(94, 21);
            this.lab_type.TabIndex = 1;
            this.lab_type.Text = "收入类型";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_total.Location = new System.Drawing.Point(119, 184);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(94, 21);
            this.lab_total.TabIndex = 2;
            this.lab_total.Text = "收入总额";
            // 
            // lab_aftertax
            // 
            this.lab_aftertax.AutoSize = true;
            this.lab_aftertax.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_aftertax.Location = new System.Drawing.Point(119, 344);
            this.lab_aftertax.Name = "lab_aftertax";
            this.lab_aftertax.Size = new System.Drawing.Size(94, 21);
            this.lab_aftertax.TabIndex = 3;
            this.lab_aftertax.Text = "税后收入";
            // 
            // lab_tax
            // 
            this.lab_tax.AutoSize = true;
            this.lab_tax.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tax.Location = new System.Drawing.Point(119, 292);
            this.lab_tax.Name = "lab_tax";
            this.lab_tax.Size = new System.Drawing.Size(94, 21);
            this.lab_tax.TabIndex = 3;
            this.lab_tax.Text = "应缴税款";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_total.Location = new System.Drawing.Point(275, 184);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(149, 26);
            this.txt_total.TabIndex = 4;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // txt_tax
            // 
            this.txt_tax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tax.Location = new System.Drawing.Point(275, 292);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(149, 26);
            this.txt_tax.TabIndex = 5;
            // 
            // txt_afertax
            // 
            this.txt_afertax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_afertax.Location = new System.Drawing.Point(275, 344);
            this.txt_afertax.Name = "txt_afertax";
            this.txt_afertax.Size = new System.Drawing.Size(149, 26);
            this.txt_afertax.TabIndex = 5;
            // 
            // label_yuan2
            // 
            this.label_yuan2.AutoSize = true;
            this.label_yuan2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_yuan2.Location = new System.Drawing.Point(447, 344);
            this.label_yuan2.Name = "label_yuan2";
            this.label_yuan2.Size = new System.Drawing.Size(31, 21);
            this.label_yuan2.TabIndex = 3;
            this.label_yuan2.Text = "元";
            // 
            // label_yuan1
            // 
            this.label_yuan1.AutoSize = true;
            this.label_yuan1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_yuan1.Location = new System.Drawing.Point(447, 292);
            this.label_yuan1.Name = "label_yuan1";
            this.label_yuan1.Size = new System.Drawing.Size(31, 21);
            this.label_yuan1.TabIndex = 3;
            this.label_yuan1.Text = "元";
            // 
            // btn_compute
            // 
            this.btn_compute.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_compute.Location = new System.Drawing.Point(275, 238);
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.Size = new System.Drawing.Size(117, 27);
            this.btn_compute.TabIndex = 6;
            this.btn_compute.Text = "计算";
            this.btn_compute.UseVisualStyleBackColor = true;
            this.btn_compute.Click += new System.EventHandler(this.btn_compute_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.Location = new System.Drawing.Point(435, 238);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(114, 27);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_click);
            // 
            // com_type
            // 
            this.com_type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.com_type.FormattingEnabled = true;
            this.com_type.Items.AddRange(new object[] {
            "综合所得适用",
            "经营所得适用"});
            this.com_type.Location = new System.Drawing.Point(275, 131);
            this.com_type.Name = "com_type";
            this.com_type.Size = new System.Drawing.Size(149, 24);
            this.com_type.TabIndex = 8;
            this.com_type.Text = "收入类型选择";
            this.com_type.SelectedIndexChanged += new System.EventHandler(this.com_index_change);
            this.com_type.Click += new System.EventHandler(this.com_click);
            // 
            // tim_savefile
            // 
            this.tim_savefile.Enabled = true;
            this.tim_savefile.Interval = 10000;
            this.tim_savefile.Tick += new System.EventHandler(this.tim_savefile_action);
            // 
            // Form_tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(696, 435);
            this.Controls.Add(this.com_type);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_compute);
            this.Controls.Add(this.txt_afertax);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lab_tax);
            this.Controls.Add(this.label_yuan1);
            this.Controls.Add(this.label_yuan2);
            this.Controls.Add(this.lab_aftertax);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.lab_title);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_tax";
            this.Text = "tax_caculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Label lab_aftertax;
        private System.Windows.Forms.Label lab_tax;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_afertax;
        private System.Windows.Forms.Label label_yuan2;
        private System.Windows.Forms.Label label_yuan1;
        private System.Windows.Forms.Button btn_compute;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox com_type;
        private System.Windows.Forms.Timer tim_savefile;
    }
}

