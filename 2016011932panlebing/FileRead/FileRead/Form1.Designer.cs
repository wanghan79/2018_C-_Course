namespace FileRead
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
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.butSubmit = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.labChoose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.labTime = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(18, 93);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(205, 562);
            this.treeView.TabIndex = 0;
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(330, 39);
            this.butSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(74, 30);
            this.butSubmit.TabIndex = 1;
            this.butSubmit.Text = "确定";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butSubmit_MouseClick);
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(174, 40);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(148, 28);
            this.txtLoc.TabIndex = 2;
            // 
            // labChoose
            // 
            this.labChoose.AutoSize = true;
            this.labChoose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labChoose.Location = new System.Drawing.Point(45, 40);
            this.labChoose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChoose.Name = "labChoose";
            this.labChoose.Size = new System.Drawing.Size(120, 25);
            this.labChoose.TabIndex = 3;
            this.labChoose.Text = "选择的位置：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 4;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(255, 93);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(590, 562);
            this.listBox.TabIndex = 5;
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(560, 40);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(114, 28);
            this.txtTime.TabIndex = 6;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.Location = new System.Drawing.Point(452, 43);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(102, 25);
            this.labTime.TabIndex = 7;
            this.labTime.Text = "时间间隔：";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(680, 40);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 30);
            this.btnTime.TabIndex = 8;
            this.btnTime.Text = "确定";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 678);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labChoose);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.treeView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "文件读取显示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label labChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button btnTime;
    }
}

