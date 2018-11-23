namespace WindowsFormsApplication2
{
    partial class TaxCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxCalculator));
            this.Button_Count = new System.Windows.Forms.Button();
            this.Label_Income_Type = new System.Windows.Forms.Label();
            this.Label_Income_Total = new System.Windows.Forms.Label();
            this.Label_Give_Tax = new System.Windows.Forms.Label();
            this.ComboBox_Income_Type = new System.Windows.Forms.ComboBox();
            this.TextBox_Income_Total = new System.Windows.Forms.TextBox();
            this.Label_Person_Tax = new System.Windows.Forms.Label();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.TextBox_Give_Tax = new System.Windows.Forms.TextBox();
            this.Label_Tax_Income = new System.Windows.Forms.Label();
            this.TextBox_Tax_Income = new System.Windows.Forms.TextBox();
            this.label1_Give_Tax = new System.Windows.Forms.Label();
            this.label2_Tax_Income = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Count
            // 
            resources.ApplyResources(this.Button_Count, "Button_Count");
            this.Button_Count.Name = "Button_Count";
            this.Button_Count.UseVisualStyleBackColor = true;
            this.Button_Count.Click += new System.EventHandler(this.Count);
            // 
            // Label_Income_Type
            // 
            resources.ApplyResources(this.Label_Income_Type, "Label_Income_Type");
            this.Label_Income_Type.Name = "Label_Income_Type";
            // 
            // Label_Income_Total
            // 
            resources.ApplyResources(this.Label_Income_Total, "Label_Income_Total");
            this.Label_Income_Total.Name = "Label_Income_Total";
            // 
            // Label_Give_Tax
            // 
            resources.ApplyResources(this.Label_Give_Tax, "Label_Give_Tax");
            this.Label_Give_Tax.ForeColor = System.Drawing.Color.Black;
            this.Label_Give_Tax.Name = "Label_Give_Tax";
            this.Label_Give_Tax.Click += new System.EventHandler(this.label3_Click);
            // 
            // ComboBox_Income_Type
            // 
            this.ComboBox_Income_Type.FormattingEnabled = true;
            this.ComboBox_Income_Type.Items.AddRange(new object[] {
            resources.GetString("ComboBox_Income_Type.Items"),
            resources.GetString("ComboBox_Income_Type.Items1"),
            resources.GetString("ComboBox_Income_Type.Items2"),
            resources.GetString("ComboBox_Income_Type.Items3"),
            resources.GetString("ComboBox_Income_Type.Items4"),
            resources.GetString("ComboBox_Income_Type.Items5"),
            resources.GetString("ComboBox_Income_Type.Items6"),
            resources.GetString("ComboBox_Income_Type.Items7")});
            resources.ApplyResources(this.ComboBox_Income_Type, "ComboBox_Income_Type");
            this.ComboBox_Income_Type.Name = "ComboBox_Income_Type";
            this.ComboBox_Income_Type.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Income_Type_SelectedIndexChanged);
            // 
            // TextBox_Income_Total
            // 
            resources.ApplyResources(this.TextBox_Income_Total, "TextBox_Income_Total");
            this.TextBox_Income_Total.Name = "TextBox_Income_Total";
            // 
            // Label_Person_Tax
            // 
            resources.ApplyResources(this.Label_Person_Tax, "Label_Person_Tax");
            this.Label_Person_Tax.Name = "Label_Person_Tax";
            // 
            // Button_Reset
            // 
            resources.ApplyResources(this.Button_Reset, "Button_Reset");
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Replay);
            // 
            // TextBox_Give_Tax
            // 
            resources.ApplyResources(this.TextBox_Give_Tax, "TextBox_Give_Tax");
            this.TextBox_Give_Tax.Name = "TextBox_Give_Tax";
            // 
            // Label_Tax_Income
            // 
            resources.ApplyResources(this.Label_Tax_Income, "Label_Tax_Income");
            this.Label_Tax_Income.Name = "Label_Tax_Income";
            // 
            // TextBox_Tax_Income
            // 
            resources.ApplyResources(this.TextBox_Tax_Income, "TextBox_Tax_Income");
            this.TextBox_Tax_Income.Name = "TextBox_Tax_Income";
            this.TextBox_Tax_Income.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1_Give_Tax
            // 
            resources.ApplyResources(this.label1_Give_Tax, "label1_Give_Tax");
            this.label1_Give_Tax.Name = "label1_Give_Tax";
            // 
            // label2_Tax_Income
            // 
            resources.ApplyResources(this.label2_Tax_Income, "label2_Tax_Income");
            this.label2_Tax_Income.Name = "label2_Tax_Income";
            // 
            // TaxCalculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2_Tax_Income);
            this.Controls.Add(this.label1_Give_Tax);
            this.Controls.Add(this.TextBox_Tax_Income);
            this.Controls.Add(this.Label_Tax_Income);
            this.Controls.Add(this.TextBox_Give_Tax);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Label_Person_Tax);
            this.Controls.Add(this.TextBox_Income_Total);
            this.Controls.Add(this.ComboBox_Income_Type);
            this.Controls.Add(this.Label_Give_Tax);
            this.Controls.Add(this.Label_Income_Total);
            this.Controls.Add(this.Label_Income_Type);
            this.Controls.Add(this.Button_Count);
            this.Name = "TaxCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Count;
        private System.Windows.Forms.Label Label_Income_Type;
        private System.Windows.Forms.Label Label_Income_Total;
        private System.Windows.Forms.Label Label_Give_Tax;
        private System.Windows.Forms.ComboBox ComboBox_Income_Type;
        private System.Windows.Forms.TextBox TextBox_Income_Total;
        private System.Windows.Forms.Label Label_Person_Tax;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextBox_Give_Tax;
        private System.Windows.Forms.Label Label_Tax_Income;
        private System.Windows.Forms.TextBox TextBox_Tax_Income;
        private System.Windows.Forms.Label label1_Give_Tax;
        private System.Windows.Forms.Label label2_Tax_Income;
    }
}

