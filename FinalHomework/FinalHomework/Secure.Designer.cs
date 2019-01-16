namespace FinalHomework
{
    partial class SecureTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecureTree));
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.directoryIcons = new System.Windows.Forms.ImageList(this.components);
            this.filesList = new System.Windows.Forms.ListView();
            this.filesIcons = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBX_Show = new System.Windows.Forms.TextBox();
            this.tBX_control = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_counting = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.timer_count_Message = new System.Windows.Forms.Timer(this.components);
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryTree
            // 
            this.directoryTree.ImageIndex = 0;
            this.directoryTree.ImageList = this.directoryIcons;
            this.directoryTree.Location = new System.Drawing.Point(21, 200);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(533, 349);
            this.directoryTree.TabIndex = 0;
            this.directoryTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.directoryTree_BeforeExpand);
            this.directoryTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterExpand);
            this.directoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterSelect);
            // 
            // directoryIcons
            // 
            this.directoryIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryIcons.ImageStream")));
            this.directoryIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.directoryIcons.Images.SetKeyName(0, "Computer.jpg");
            this.directoryIcons.Images.SetKeyName(1, "Close Folder.jpg");
            this.directoryIcons.Images.SetKeyName(2, "Open Floder.jpg");
            this.directoryIcons.Images.SetKeyName(3, "fixed drive.jpg");
            this.directoryIcons.Images.SetKeyName(4, "My Documents.png");
            // 
            // filesList
            // 
            this.filesList.Location = new System.Drawing.Point(586, 200);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(599, 349);
            this.filesList.SmallImageList = this.filesIcons;
            this.filesList.TabIndex = 1;
            this.filesList.UseCompatibleStateImageBehavior = false;
            this.filesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filesList_MouseClick);
            // 
            // filesIcons
            // 
            this.filesIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.filesIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.filesIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.deleteFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.openFileToolStripMenuItem.Text = "打开文件";
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.deleteFileToolStripMenuItem.Text = "删除文件";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // tBX_Show
            // 
            this.tBX_Show.Location = new System.Drawing.Point(256, 92);
            this.tBX_Show.Multiline = true;
            this.tBX_Show.Name = "tBX_Show";
            this.tBX_Show.Size = new System.Drawing.Size(299, 80);
            this.tBX_Show.TabIndex = 3;
            this.tBX_Show.TextChanged += new System.EventHandler(this.tBX_Show_TextChanged);
            // 
            // tBX_control
            // 
            this.tBX_control.Location = new System.Drawing.Point(586, 93);
            this.tBX_control.Multiline = true;
            this.tBX_control.Name = "tBX_control";
            this.tBX_control.Size = new System.Drawing.Size(215, 80);
            this.tBX_control.TabIndex = 4;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_select.Location = new System.Drawing.Point(822, 92);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(123, 81);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "选择文件夹";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_start.Location = new System.Drawing.Point(957, 93);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(113, 80);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "清空";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_counting
            // 
            this.btn_counting.Location = new System.Drawing.Point(1076, 93);
            this.btn_counting.Name = "btn_counting";
            this.btn_counting.Size = new System.Drawing.Size(109, 34);
            this.btn_counting.TabIndex = 7;
            this.btn_counting.Text = "开始计时";
            this.btn_counting.UseVisualStyleBackColor = true;
            this.btn_counting.Click += new System.EventHandler(this.btn_counting_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(1076, 146);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(109, 27);
            this.btn_end.TabIndex = 8;
            this.btn_end.Text = "停止计时";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
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
            // timer_count_Message
            // 
            this.timer_count_Message.Interval = 3000;
            this.timer_count_Message.Tick += new System.EventHandler(this.timer_count_Message_Tick);
            // 
            // timer_check
            // 
            this.timer_check.Interval = 10000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_Name.Location = new System.Drawing.Point(30, 119);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(220, 54);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "文件夹路径:";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(412, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "文件管理监测系统";
            // 
            // SecureTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_counting);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.tBX_control);
            this.Controls.Add(this.tBX_Show);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.directoryTree);
            this.Name = "SecureTree";
            this.Text = "SecureTree";
            this.Load += new System.EventHandler(this.SecureTree_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.ImageList directoryIcons;
        private System.Windows.Forms.ListView filesList;
        private System.Windows.Forms.ImageList filesIcons;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.TextBox tBX_Show;
        private System.Windows.Forms.TextBox tBX_control;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_counting;
        private System.Windows.Forms.Button btn_end;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Timer timer_count_Message;
        private System.Windows.Forms.Timer timer_check;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
    }
}

