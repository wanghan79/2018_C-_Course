namespace FinalWork_FileRead
{
    partial class setting
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
            this.lbl_select_time = new System.Windows.Forms.Label();
            this.comboBox_time = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_select_time
            // 
            this.lbl_select_time.AutoSize = true;
            this.lbl_select_time.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_select_time.Location = new System.Drawing.Point(67, 54);
            this.lbl_select_time.Name = "lbl_select_time";
            this.lbl_select_time.Size = new System.Drawing.Size(131, 21);
            this.lbl_select_time.TabIndex = 0;
            this.lbl_select_time.Text = "select time";
            // 
            // comboBox_time
            // 
            this.comboBox_time.FormattingEnabled = true;
            this.comboBox_time.Items.AddRange(new object[] {
            "10000 (10s)(default)",
            "30000 (30s)",
            "60000 (60s/1min)",
            "90000 (90s)",
            "120000 (120s/2min)",
            "600000 (10min)"});
            this.comboBox_time.Location = new System.Drawing.Point(71, 88);
            this.comboBox_time.Name = "comboBox_time";
            this.comboBox_time.Size = new System.Drawing.Size(167, 20);
            this.comboBox_time.TabIndex = 1;
            this.comboBox_time.TextChanged += new System.EventHandler(this.comboBox_time_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(71, 194);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.comboBox_time);
            this.Controls.Add(this.lbl_select_time);
            this.Name = "setting";
            this.Text = "setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_select_time;
        private System.Windows.Forms.ComboBox comboBox_time;
        private System.Windows.Forms.Button btn_submit;
    }
}