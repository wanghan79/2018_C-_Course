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
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 62);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(138, 376);
            this.treeView.TabIndex = 0;
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(222, 27);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(49, 23);
            this.butSubmit.TabIndex = 1;
            this.butSubmit.Text = "确定";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butSubmit_MouseClick);
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(116, 27);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(100, 21);
            this.txtLoc.TabIndex = 2;
            // 
            // labChoose
            // 
            this.labChoose.AutoSize = true;
            this.labChoose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labChoose.Location = new System.Drawing.Point(30, 27);
            this.labChoose.Name = "labChoose";
            this.labChoose.Size = new System.Drawing.Size(80, 17);
            this.labChoose.TabIndex = 3;
            this.labChoose.Text = "选择的位置：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 4;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(170, 62);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(395, 376);
            this.listBox.TabIndex = 5;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 452);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labChoose);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.treeView);
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
    }
}

