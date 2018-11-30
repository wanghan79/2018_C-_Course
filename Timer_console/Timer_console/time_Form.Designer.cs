namespace Timer_console
{
    partial class time_Form
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
            this.event1_timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.time_tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // event1_timer
            // 
            this.event1_timer.Interval = 3000;
            this.event1_timer.Tick += new System.EventHandler(this.event1_timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始计时";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // time_tbx
            // 
            this.time_tbx.Location = new System.Drawing.Point(55, 29);
            this.time_tbx.Name = "time_tbx";
            this.time_tbx.Size = new System.Drawing.Size(176, 21);
            this.time_tbx.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.time_tbx);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "time_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer event1_timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox time_tbx;
    }
}

