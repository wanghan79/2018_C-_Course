namespace Documentary
{
    partial class DocumentControlSys
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.Titellab = new System.Windows.Forms.Label();
            this.Documenttree = new System.Windows.Forms.TreeView();
            this.Processlist = new System.Windows.Forms.ListView();
            this.headerfile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerchange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pathtxt = new System.Windows.Forms.TextBox();
            this.Pathlab = new System.Windows.Forms.LinkLabel();
            this.Timebtn = new System.Windows.Forms.Button();
            this.TimeLab = new System.Windows.Forms.LinkLabel();
            this.Shrubtimer = new System.Windows.Forms.Timer(this.components);
            this.btnFilePath = new System.Windows.Forms.Button();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.SuspendLayout();
            // 
            // Titellab
            // 
            this.Titellab.AutoSize = true;
            this.Titellab.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Titellab.Location = new System.Drawing.Point(507, -2);
            this.Titellab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titellab.Name = "Titellab";
            this.Titellab.Size = new System.Drawing.Size(383, 52);
            this.Titellab.TabIndex = 0;
            this.Titellab.Text = "文件系统树状图监控";
            // 
            // Documenttree
            // 
            this.Documenttree.LabelEdit = true;
            this.Documenttree.Location = new System.Drawing.Point(12, 249);
            this.Documenttree.Name = "Documenttree";
            this.Documenttree.Size = new System.Drawing.Size(352, 424);
            this.Documenttree.TabIndex = 1;
            // 
            // Processlist
            // 
            this.Processlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerfile,
            this.headerchange,
            this.headertime});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.Processlist.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.Processlist.Location = new System.Drawing.Point(409, 249);
            this.Processlist.Name = "Processlist";
            this.Processlist.RightToLeftLayout = true;
            this.Processlist.Size = new System.Drawing.Size(945, 423);
            this.Processlist.TabIndex = 2;
            this.Processlist.UseCompatibleStateImageBehavior = false;
            this.Processlist.UseWaitCursor = true;
            this.Processlist.View = System.Windows.Forms.View.Details;
            // 
            // headerfile
            // 
            this.headerfile.Text = "文件名";
            this.headerfile.Width = 332;
            // 
            // headerchange
            // 
            this.headerchange.Text = "修改操作";
            this.headerchange.Width = 306;
            // 
            // headertime
            // 
            this.headertime.Text = "时间";
            this.headertime.Width = 435;
            // 
            // Pathtxt
            // 
            this.Pathtxt.Location = new System.Drawing.Point(18, 122);
            this.Pathtxt.Name = "Pathtxt";
            this.Pathtxt.ReadOnly = true;
            this.Pathtxt.Size = new System.Drawing.Size(1190, 34);
            this.Pathtxt.TabIndex = 4;
            this.Pathtxt.TextChanged += new System.EventHandler(this.Pathtxt_TextChanged);
            // 
            // Pathlab
            // 
            this.Pathlab.ActiveLinkColor = System.Drawing.Color.Black;
            this.Pathlab.AutoSize = true;
            this.Pathlab.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pathlab.LinkColor = System.Drawing.Color.Black;
            this.Pathlab.Location = new System.Drawing.Point(12, 77);
            this.Pathlab.Name = "Pathlab";
            this.Pathlab.Size = new System.Drawing.Size(320, 31);
            this.Pathlab.TabIndex = 5;
            this.Pathlab.TabStop = true;
            this.Pathlab.Text = "文件路径(请浏览文件夹选择)";
            // 
            // Timebtn
            // 
            this.Timebtn.Location = new System.Drawing.Point(1237, 177);
            this.Timebtn.Name = "Timebtn";
            this.Timebtn.Size = new System.Drawing.Size(107, 34);
            this.Timebtn.TabIndex = 7;
            this.Timebtn.Text = "开始执行";
            this.Timebtn.UseVisualStyleBackColor = true;
            this.Timebtn.Click += new System.EventHandler(this.Timebtn_Click);
            // 
            // TimeLab
            // 
            this.TimeLab.ActiveLinkColor = System.Drawing.Color.Black;
            this.TimeLab.AutoSize = true;
            this.TimeLab.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLab.LinkColor = System.Drawing.Color.Black;
            this.TimeLab.Location = new System.Drawing.Point(710, 181);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(290, 31);
            this.TimeLab.TabIndex = 8;
            this.TimeLab.TabStop = true;
            this.TimeLab.Text = "请输入时间间隔(默认10s)";
            // 
            // Shrubtimer
            // 
            this.Shrubtimer.Enabled = true;
            this.Shrubtimer.Interval = 1000;
            this.Shrubtimer.Tick += new System.EventHandler(this.Shrubtimer_Tick);
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(1214, 120);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(130, 36);
            this.btnFilePath.TabIndex = 9;
            this.btnFilePath.Text = "浏览文件夹";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(1006, 177);
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(202, 34);
            this.numTime.TabIndex = 10;
            this.numTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DocumentControlSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 732);
            this.Controls.Add(this.numTime);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.TimeLab);
            this.Controls.Add(this.Timebtn);
            this.Controls.Add(this.Pathlab);
            this.Controls.Add(this.Pathtxt);
            this.Controls.Add(this.Processlist);
            this.Controls.Add(this.Documenttree);
            this.Controls.Add(this.Titellab);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DocumentControlSys";
            this.Text = "文件系统树状图监控";
            this.Load += new System.EventHandler(this.DocumentControlSys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titellab;
        private System.Windows.Forms.TreeView Documenttree;
        private System.Windows.Forms.ListView Processlist;
        private System.Windows.Forms.TextBox Pathtxt;
        private System.Windows.Forms.LinkLabel Pathlab;
        private System.Windows.Forms.ColumnHeader headerfile;
        private System.Windows.Forms.ColumnHeader headerchange;
        private System.Windows.Forms.ColumnHeader headertime;
        private System.Windows.Forms.Button Timebtn;
        private System.Windows.Forms.LinkLabel TimeLab;
        private System.Windows.Forms.Timer Shrubtimer;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.NumericUpDown numTime;
    }
}

