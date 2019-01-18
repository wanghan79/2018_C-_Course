namespace Final_Homework
{
    partial class ShowFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFile));
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.directoryicons = new System.Windows.Forms.ImageList(this.components);
            this.fileslist = new System.Windows.Forms.ListView();
            this.fileslisticons = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tBX_ShowPath = new System.Windows.Forms.TextBox();
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tBX_monitor = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.timer_monitor = new System.Windows.Forms.Timer(this.components);
            this.btn_start_counting = new System.Windows.Forms.Button();
            this.timer_Message = new System.Windows.Forms.Timer(this.components);
            this.btn_end_counting = new System.Windows.Forms.Button();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.lbl_monitor = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryTree
            // 
            this.directoryTree.ImageIndex = 0;
            this.directoryTree.ImageList = this.directoryicons;
            this.directoryTree.Location = new System.Drawing.Point(33, 224);
            this.directoryTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(419, 561);
            this.directoryTree.TabIndex = 0;
            this.directoryTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.directoryTree_BeforeExpand);
            this.directoryTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterExpand);
            this.directoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterSelect_1);
            // 
            // directoryicons
            // 
            this.directoryicons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryicons.ImageStream")));
            this.directoryicons.TransparentColor = System.Drawing.Color.Transparent;
            this.directoryicons.Images.SetKeyName(0, "My Computer.ico");
            this.directoryicons.Images.SetKeyName(1, "Folder empty.ico");
            this.directoryicons.Images.SetKeyName(2, "Folder.ico");
            this.directoryicons.Images.SetKeyName(3, "HDD.ico");
            this.directoryicons.Images.SetKeyName(4, "My documents.ico");
            // 
            // fileslist
            // 
            this.fileslist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileslist.Location = new System.Drawing.Point(508, 224);
            this.fileslist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileslist.Name = "fileslist";
            this.fileslist.Size = new System.Drawing.Size(736, 561);
            this.fileslist.SmallImageList = this.fileslisticons;
            this.fileslist.TabIndex = 1;
            this.fileslist.UseCompatibleStateImageBehavior = false;
            this.fileslist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fileslist_MouseClick);
            // 
            // fileslisticons
            // 
            this.fileslisticons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileslisticons.ImageStream")));
            this.fileslisticons.TransparentColor = System.Drawing.Color.Transparent;
            this.fileslisticons.Images.SetKeyName(0, "Folder empty.ico");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_toolStripMenuItem1,
            this.delete_toolStripMenuItem2});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 60);
            // 
            // open_toolStripMenuItem1
            // 
            this.open_toolStripMenuItem1.Name = "open_toolStripMenuItem1";
            this.open_toolStripMenuItem1.Size = new System.Drawing.Size(240, 28);
            this.open_toolStripMenuItem1.Text = "打开文件";
            this.open_toolStripMenuItem1.Click += new System.EventHandler(this.open_toolStripMenuItem1_Click);
            // 
            // delete_toolStripMenuItem2
            // 
            this.delete_toolStripMenuItem2.Name = "delete_toolStripMenuItem2";
            this.delete_toolStripMenuItem2.Size = new System.Drawing.Size(240, 28);
            this.delete_toolStripMenuItem2.Text = "删除文件";
            this.delete_toolStripMenuItem2.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // tBX_ShowPath
            // 
            this.tBX_ShowPath.Location = new System.Drawing.Point(256, 133);
            this.tBX_ShowPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBX_ShowPath.Multiline = true;
            this.tBX_ShowPath.Name = "tBX_ShowPath";
            this.tBX_ShowPath.ReadOnly = true;
            this.tBX_ShowPath.Size = new System.Drawing.Size(195, 69);
            this.tBX_ShowPath.TabIndex = 2;
            this.tBX_ShowPath.TextChanged += new System.EventHandler(this.tBX_Show_TextChanged);
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(963, 131);
            this.btn_choose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(119, 71);
            this.btn_choose.TabIndex = 3;
            this.btn_choose.Text = "确定文件夹";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(1121, 131);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(123, 71);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "重置";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tBX_monitor
            // 
            this.tBX_monitor.Location = new System.Drawing.Point(707, 132);
            this.tBX_monitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBX_monitor.Multiline = true;
            this.tBX_monitor.Name = "tBX_monitor";
            this.tBX_monitor.ReadOnly = true;
            this.tBX_monitor.Size = new System.Drawing.Size(189, 70);
            this.tBX_monitor.TabIndex = 5;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // timer_monitor
            // 
            this.timer_monitor.Interval = 10000;
            this.timer_monitor.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // btn_start_counting
            // 
            this.btn_start_counting.Location = new System.Drawing.Point(33, 37);
            this.btn_start_counting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_start_counting.Name = "btn_start_counting";
            this.btn_start_counting.Size = new System.Drawing.Size(123, 52);
            this.btn_start_counting.TabIndex = 6;
            this.btn_start_counting.Text = "开始计时";
            this.btn_start_counting.UseVisualStyleBackColor = true;
            this.btn_start_counting.Click += new System.EventHandler(this.btn_counting_Click);
            // 
            // timer_Message
            // 
            this.timer_Message.Interval = 3000;
            this.timer_Message.Tick += new System.EventHandler(this.timer_count_Message_Tick);
            // 
            // btn_end_counting
            // 
            this.btn_end_counting.Location = new System.Drawing.Point(1121, 37);
            this.btn_end_counting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_end_counting.Name = "btn_end_counting";
            this.btn_end_counting.Size = new System.Drawing.Size(123, 52);
            this.btn_end_counting.TabIndex = 7;
            this.btn_end_counting.Text = "结束计时";
            this.btn_end_counting.UseVisualStyleBackColor = true;
            this.btn_end_counting.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // lbl_Path
            // 
            this.lbl_Path.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Path.Location = new System.Drawing.Point(28, 152);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(198, 40);
            this.lbl_Path.TabIndex = 8;
            this.lbl_Path.Text = "文件夹路径：";
            // 
            // lbl_monitor
            // 
            this.lbl_monitor.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_monitor.Location = new System.Drawing.Point(504, 150);
            this.lbl_monitor.Name = "lbl_monitor";
            this.lbl_monitor.Size = new System.Drawing.Size(188, 35);
            this.lbl_monitor.TabIndex = 9;
            this.lbl_monitor.Text = "文件检测：";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(452, 31);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(420, 52);
            this.lbl_Name.TabIndex = 10;
            this.lbl_Name.Text = "文 件 检 测 系 统";
            // 
            // ShowFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 820);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_monitor);
            this.Controls.Add(this.lbl_Path);
            this.Controls.Add(this.btn_end_counting);
            this.Controls.Add(this.btn_start_counting);
            this.Controls.Add(this.tBX_monitor);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.tBX_ShowPath);
            this.Controls.Add(this.fileslist);
            this.Controls.Add(this.directoryTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowFile";
            this.Text = "ShowFile";
            this.Load += new System.EventHandler(this.Files_Manager_Load_1);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.ListView fileslist;
        private System.Windows.Forms.ImageList directoryicons;
        private System.Windows.Forms.ImageList fileslisticons;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem open_toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem delete_toolStripMenuItem2;
        private System.Windows.Forms.TextBox tBX_ShowPath;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tBX_monitor;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Timer timer_monitor;
        private System.Windows.Forms.Button btn_start_counting;
        private System.Windows.Forms.Timer timer_Message;
        private System.Windows.Forms.Button btn_end_counting;
        private System.Windows.Forms.Label lbl_monitor;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Label lbl_Name;
    }
}

