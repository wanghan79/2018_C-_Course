namespace PersonTaxCalculate
{
    partial class form_Person_Tax_Calculate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_Income_Type = new System.Windows.Forms.LinkLabel();
            this.lab_Income_Total = new System.Windows.Forms.LinkLabel();
            this.lab_Parable_Tax = new System.Windows.Forms.LinkLabel();
            this.lab_After_Tax = new System.Windows.Forms.LinkLabel();
            this.cmb_Income_Type = new System.Windows.Forms.ComboBox();
            this.text_Income_Total = new System.Windows.Forms.TextBox();
            this.text_Parable_Tax = new System.Windows.Forms.TextBox();
            this.text_After_Tax = new System.Windows.Forms.TextBox();
            this.lab_Yuan1 = new System.Windows.Forms.LinkLabel();
            this.lab_Yuan2 = new System.Windows.Forms.LinkLabel();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tim_Open_File = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab_Income_Type
            // 
            this.lab_Income_Type.AutoSize = true;
            this.lab_Income_Type.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Income_Type.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_Income_Type.LinkColor = System.Drawing.Color.Black;
            this.lab_Income_Type.Location = new System.Drawing.Point(30, 49);
            this.lab_Income_Type.Name = "lab_Income_Type";
            this.lab_Income_Type.Size = new System.Drawing.Size(72, 16);
            this.lab_Income_Type.TabIndex = 0;
            this.lab_Income_Type.TabStop = true;
            this.lab_Income_Type.Text = "收入类型";
            this.lab_Income_Type.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_Income_Type_LinkClicked);
            // 
            // lab_Income_Total
            // 
            this.lab_Income_Total.AutoSize = true;
            this.lab_Income_Total.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Income_Total.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_Income_Total.LinkColor = System.Drawing.Color.Black;
            this.lab_Income_Total.Location = new System.Drawing.Point(30, 91);
            this.lab_Income_Total.Name = "lab_Income_Total";
            this.lab_Income_Total.Size = new System.Drawing.Size(72, 16);
            this.lab_Income_Total.TabIndex = 1;
            this.lab_Income_Total.TabStop = true;
            this.lab_Income_Total.Text = "收入总额";
            // 
            // lab_Parable_Tax
            // 
            this.lab_Parable_Tax.AutoSize = true;
            this.lab_Parable_Tax.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Parable_Tax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_Parable_Tax.LinkColor = System.Drawing.Color.Black;
            this.lab_Parable_Tax.Location = new System.Drawing.Point(30, 198);
            this.lab_Parable_Tax.Name = "lab_Parable_Tax";
            this.lab_Parable_Tax.Size = new System.Drawing.Size(72, 16);
            this.lab_Parable_Tax.TabIndex = 2;
            this.lab_Parable_Tax.TabStop = true;
            this.lab_Parable_Tax.Text = "应纳税款";
            // 
            // lab_After_Tax
            // 
            this.lab_After_Tax.AutoSize = true;
            this.lab_After_Tax.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_After_Tax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_After_Tax.LinkColor = System.Drawing.Color.Black;
            this.lab_After_Tax.Location = new System.Drawing.Point(30, 253);
            this.lab_After_Tax.Name = "lab_After_Tax";
            this.lab_After_Tax.Size = new System.Drawing.Size(72, 16);
            this.lab_After_Tax.TabIndex = 3;
            this.lab_After_Tax.TabStop = true;
            this.lab_After_Tax.Text = "税后收入";
            this.lab_After_Tax.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // cmb_Income_Type
            // 
            this.cmb_Income_Type.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Income_Type.FormattingEnabled = true;
            this.cmb_Income_Type.Items.AddRange(new object[] {
            "薪资工资所得",
            "劳务报酬所得",
            "财产租赁所得"});
            this.cmb_Income_Type.Location = new System.Drawing.Point(126, 41);
            this.cmb_Income_Type.Name = "cmb_Income_Type";
            this.cmb_Income_Type.Size = new System.Drawing.Size(121, 24);
            this.cmb_Income_Type.TabIndex = 4;
            this.cmb_Income_Type.Text = "请选择";
            this.cmb_Income_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Income_Type_SelectedIndexChanged);
            // 
            // text_Income_Total
            // 
            this.text_Income_Total.Location = new System.Drawing.Point(126, 90);
            this.text_Income_Total.Name = "text_Income_Total";
            this.text_Income_Total.Size = new System.Drawing.Size(121, 21);
            this.text_Income_Total.TabIndex = 5;
            this.text_Income_Total.TextChanged += new System.EventHandler(this.text_Income_Total_TextChanged);
            // 
            // text_Parable_Tax
            // 
            this.text_Parable_Tax.Location = new System.Drawing.Point(126, 199);
            this.text_Parable_Tax.Name = "text_Parable_Tax";
            this.text_Parable_Tax.Size = new System.Drawing.Size(121, 21);
            this.text_Parable_Tax.TabIndex = 6;
            // 
            // text_After_Tax
            // 
            this.text_After_Tax.Location = new System.Drawing.Point(126, 254);
            this.text_After_Tax.Name = "text_After_Tax";
            this.text_After_Tax.Size = new System.Drawing.Size(121, 21);
            this.text_After_Tax.TabIndex = 7;
            this.text_After_Tax.TextChanged += new System.EventHandler(this.text_After_Tax_TextChanged);
            // 
            // lab_Yuan1
            // 
            this.lab_Yuan1.AutoSize = true;
            this.lab_Yuan1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Yuan1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_Yuan1.LinkColor = System.Drawing.Color.Black;
            this.lab_Yuan1.Location = new System.Drawing.Point(266, 204);
            this.lab_Yuan1.Name = "lab_Yuan1";
            this.lab_Yuan1.Size = new System.Drawing.Size(24, 16);
            this.lab_Yuan1.TabIndex = 8;
            this.lab_Yuan1.TabStop = true;
            this.lab_Yuan1.Text = "元";
            // 
            // lab_Yuan2
            // 
            this.lab_Yuan2.AutoSize = true;
            this.lab_Yuan2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Yuan2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lab_Yuan2.LinkColor = System.Drawing.Color.Black;
            this.lab_Yuan2.Location = new System.Drawing.Point(266, 259);
            this.lab_Yuan2.Name = "lab_Yuan2";
            this.lab_Yuan2.Size = new System.Drawing.Size(24, 16);
            this.lab_Yuan2.TabIndex = 9;
            this.lab_Yuan2.TabStop = true;
            this.lab_Yuan2.Text = "元";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Calculate.Location = new System.Drawing.Point(59, 141);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 10;
            this.btn_Calculate.Text = "计算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(205, 141);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.Location = new System.Drawing.Point(288, 90);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // tim_Open_File
            // 
            this.tim_Open_File.Enabled = true;
            this.tim_Open_File.Interval = 3000;
            this.tim_Open_File.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // form_Person_Tax_Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(379, 292);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lab_Yuan2);
            this.Controls.Add(this.lab_Yuan1);
            this.Controls.Add(this.text_After_Tax);
            this.Controls.Add(this.text_Parable_Tax);
            this.Controls.Add(this.text_Income_Total);
            this.Controls.Add(this.cmb_Income_Type);
            this.Controls.Add(this.lab_After_Tax);
            this.Controls.Add(this.lab_Parable_Tax);
            this.Controls.Add(this.lab_Income_Total);
            this.Controls.Add(this.lab_Income_Type);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "form_Person_Tax_Calculate";
            this.Text = "个人所得税计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lab_Income_Type;
        private System.Windows.Forms.LinkLabel lab_Income_Total;
        private System.Windows.Forms.LinkLabel lab_Parable_Tax;
        private System.Windows.Forms.LinkLabel lab_After_Tax;
        private System.Windows.Forms.ComboBox cmb_Income_Type;
        private System.Windows.Forms.TextBox text_Income_Total;
        private System.Windows.Forms.TextBox text_Parable_Tax;
        private System.Windows.Forms.TextBox text_After_Tax;
        private System.Windows.Forms.LinkLabel lab_Yuan1;
        private System.Windows.Forms.LinkLabel lab_Yuan2;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Timer tim_Open_File;
    }
}

