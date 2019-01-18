namespace Timer
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_check
            // 
            this.timer_check.Interval = 3000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(305, 137);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 68);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "開始計時";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(305, 236);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(149, 68);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "結束計時";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_check;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
    }
}

