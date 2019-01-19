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
            this.headeruser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OKbtn = new System.Windows.Forms.Button();
            this.Pathtxt = new System.Windows.Forms.TextBox();
            this.Pathlab = new System.Windows.Forms.LinkLabel();
            this.Timetxt = new System.Windows.Forms.TextBox();
            this.Timebtn = new System.Windows.Forms.Button();
            this.TimeLab = new System.Windows.Forms.LinkLabel();
            this.Shrubtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Titellab
            // 
            this.Titellab.AutoSize = true;
            this.Titellab.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Titellab.Location = new System.Drawing.Point(539, 9);
            this.Titellab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titellab.Name = "Titellab";
            this.Titellab.Size = new System.Drawing.Size(306, 42);
            this.Titellab.TabIndex = 0;
            this.Titellab.Text = "文件系统树状图监控";
            // 
            // Documenttree
            // 
            this.Documenttree.LabelEdit = true;
            this.Documenttree.Location = new System.Drawing.Point(12, 164);
            this.Documenttree.Name = "Documenttree";
            this.Documenttree.Size = new System.Drawing.Size(352, 424);
            this.Documenttree.TabIndex = 1;
            this.Documenttree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Documenttree_AfterSelect);
            // 
            // Processlist
            // 
            this.Processlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerfile,
            this.headerchange,
            this.headertime,
            this.headeruser});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.Processlist.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.Processlist.Location = new System.Drawing.Point(416, 165);
            this.Processlist.Name = "Processlist";
            this.Processlist.RightToLeftLayout = true;
            this.Processlist.Size = new System.Drawing.Size(945, 423);
            this.Processlist.TabIndex = 2;
            this.Processlist.UseCompatibleStateImageBehavior = false;
            this.Processlist.UseWaitCursor = true;
            this.Processlist.View = System.Windows.Forms.View.Details;
            this.Processlist.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // headerfile
            // 
            this.headerfile.Text = "文件名";
            this.headerfile.Width = 401;
            // 
            // headerchange
            // 
            this.headerchange.Text = "修改操作";
            this.headerchange.Width = 96;
            // 
            // headertime
            // 
            this.headertime.Text = "时间";
            this.headertime.Width = 231;
            // 
            // headeruser
            // 
            this.headeruser.Text = "用户";
            this.headeruser.Width = 221;
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(546, 83);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(74, 36);
            this.OKbtn.TabIndex = 3;
            this.OKbtn.Text = "确认";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // Pathtxt
            // 
            this.Pathtxt.Location = new System.Drawing.Point(187, 83);
            this.Pathtxt.Name = "Pathtxt";
            this.Pathtxt.Size = new System.Drawing.Size(330, 29);
            this.Pathtxt.TabIndex = 4;
            this.Pathtxt.TextChanged += new System.EventHandler(this.Pathtxt_TextChanged);
            // 
            // Pathlab
            // 
            this.Pathlab.ActiveLinkColor = System.Drawing.Color.Black;
            this.Pathlab.AutoSize = true;
            this.Pathlab.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pathlab.LinkColor = System.Drawing.Color.Black;
            this.Pathlab.Location = new System.Drawing.Point(23, 82);
            this.Pathlab.Name = "Pathlab";
            this.Pathlab.Size = new System.Drawing.Size(107, 26);
            this.Pathlab.TabIndex = 5;
            this.Pathlab.TabStop = true;
            this.Pathlab.Text = "请输入路径";
            this.Pathlab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Pathlab_LinkClicked);
            // 
            // Timetxt
            // 
            this.Timetxt.Location = new System.Drawing.Point(1001, 85);
            this.Timetxt.Name = "Timetxt";
            this.Timetxt.Size = new System.Drawing.Size(202, 29);
            this.Timetxt.TabIndex = 6;
            this.Timetxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Timebtn
            // 
            this.Timebtn.Location = new System.Drawing.Point(1248, 82);
            this.Timebtn.Name = "Timebtn";
            this.Timebtn.Size = new System.Drawing.Size(88, 34);
            this.Timebtn.TabIndex = 7;
            this.Timebtn.Text = "确认";
            this.Timebtn.UseVisualStyleBackColor = true;
            this.Timebtn.Click += new System.EventHandler(this.Timebtn_Click);
            // 
            // TimeLab
            // 
            this.TimeLab.ActiveLinkColor = System.Drawing.Color.Black;
            this.TimeLab.AutoSize = true;
            this.TimeLab.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLab.LinkColor = System.Drawing.Color.Black;
            this.TimeLab.Location = new System.Drawing.Point(709, 82);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(230, 26);
            this.TimeLab.TabIndex = 8;
            this.TimeLab.TabStop = true;
            this.TimeLab.Text = "请输入时间间隔(默认60s)";
            // 
            // Shrubtimer
            // 
            this.Shrubtimer.Enabled = true;
            this.Shrubtimer.Interval = 1000;
            this.Shrubtimer.Tick += new System.EventHandler(this.Shrubtimer_Tick);
            // 
            // DocumentControlSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 617);
            this.Controls.Add(this.TimeLab);
            this.Controls.Add(this.Timebtn);
            this.Controls.Add(this.Timetxt);
            this.Controls.Add(this.Pathlab);
            this.Controls.Add(this.Pathtxt);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.Processlist);
            this.Controls.Add(this.Documenttree);
            this.Controls.Add(this.Titellab);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DocumentControlSys";
            this.Text = "文件系统树状图监控";
            this.Load += new System.EventHandler(this.DocumentControlSys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titellab;
        private System.Windows.Forms.TreeView Documenttree;
        private System.Windows.Forms.ListView Processlist;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.TextBox Pathtxt;
        private System.Windows.Forms.LinkLabel Pathlab;
        private System.Windows.Forms.ColumnHeader headerfile;
        private System.Windows.Forms.ColumnHeader headerchange;
        private System.Windows.Forms.ColumnHeader headertime;
        private System.Windows.Forms.ColumnHeader headeruser;
        private System.Windows.Forms.TextBox Timetxt;
        private System.Windows.Forms.Button Timebtn;
        private System.Windows.Forms.LinkLabel TimeLab;
        private System.Windows.Forms.Timer Shrubtimer;
    }
}

