namespace File
{
    partial class File
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.directoryIcons = new System.Windows.Forms.ImageList(this.components);
            this.filesIcons = new System.Windows.Forms.ImageList(this.components);
            this.choose = new System.Windows.Forms.Button();
            this.File_path = new System.Windows.Forms.TextBox();
            this.file_show = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filechange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = new System.Windows.Forms.Label();
            this.path_choose = new System.Windows.Forms.Label();
            this.time_choose = new System.Windows.Forms.Label();
            this.check_time = new System.Windows.Forms.Timer(this.components);
            this.text_time = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directoryTree
            // 
            this.directoryTree.ImageIndex = 0;
            this.directoryTree.ImageList = this.directoryIcons;
            this.directoryTree.Location = new System.Drawing.Point(51, 178);
            this.directoryTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(488, 322);
            this.directoryTree.TabIndex = 0;
            // 
            // directoryIcons
            // 
            this.directoryIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryIcons.ImageStream")));
            this.directoryIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.directoryIcons.Images.SetKeyName(0, "php.gif");
            this.directoryIcons.Images.SetKeyName(1, "1-01.png");
            this.directoryIcons.Images.SetKeyName(2, "2-01.png");
            this.directoryIcons.Images.SetKeyName(3, "人物.jpg");
            this.directoryIcons.Images.SetKeyName(4, "天空.jpg");
            // 
            // filesIcons
            // 
            this.filesIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("filesIcons.ImageStream")));
            this.filesIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.filesIcons.Images.SetKeyName(0, "1.png");
            this.filesIcons.Images.SetKeyName(1, "2.png");
            this.filesIcons.Images.SetKeyName(2, "3.png");
            this.filesIcons.Images.SetKeyName(3, "4.png");
            this.filesIcons.Images.SetKeyName(4, "5.png");
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(461, 122);
            this.choose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(79, 30);
            this.choose.TabIndex = 3;
            this.choose.Text = "...";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.choose_file);
            // 
            // File_path
            // 
            this.File_path.Location = new System.Drawing.Point(51, 122);
            this.File_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.File_path.Name = "File_path";
            this.File_path.Size = new System.Drawing.Size(384, 25);
            this.File_path.TabIndex = 5;
            // 
            // file_show
            // 
            this.file_show.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.filechange,
            this.changetime,
            this.user});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.file_show.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.file_show.Location = new System.Drawing.Point(631, 180);
            this.file_show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.file_show.Name = "file_show";
            this.file_show.RightToLeftLayout = true;
            this.file_show.Size = new System.Drawing.Size(645, 320);
            this.file_show.TabIndex = 6;
            this.file_show.UseCompatibleStateImageBehavior = false;
            this.file_show.UseWaitCursor = true;
            this.file_show.View = System.Windows.Forms.View.Details;
            this.file_show.SelectedIndexChanged += new System.EventHandler(this.Pathtxt_TextChanged);
            // 
            // filename
            // 
            this.filename.Text = "文件名";
            this.filename.Width = 120;
            // 
            // filechange
            // 
            this.filechange.Text = "修改操作";
            this.filechange.Width = 120;
            // 
            // changetime
            // 
            this.changetime.Text = "修改时间";
            this.changetime.Width = 120;
            // 
            // user
            // 
            this.user.Text = "用户";
            this.user.Width = 120;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(452, 11);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(383, 52);
            this.name.TabIndex = 7;
            this.name.Text = "文件系统树状图监控";
            // 
            // path_choose
            // 
            this.path_choose.AutoSize = true;
            this.path_choose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.path_choose.Location = new System.Drawing.Point(45, 74);
            this.path_choose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.path_choose.Name = "path_choose";
            this.path_choose.Size = new System.Drawing.Size(112, 27);
            this.path_choose.TabIndex = 8;
            this.path_choose.Text = "请选择路径";
            // 
            // time_choose
            // 
            this.time_choose.AutoSize = true;
            this.time_choose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_choose.Location = new System.Drawing.Point(640, 74);
            this.time_choose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_choose.Name = "time_choose";
            this.time_choose.Size = new System.Drawing.Size(266, 27);
            this.time_choose.TabIndex = 9;
            this.time_choose.Text = "请选择监控时间（默认60s）";
            // 
            // check_time
            // 
            this.check_time.Interval = 1000;
            this.check_time.Tick += new System.EventHandler(this.check_time_Tick);
            // 
            // text_time
            // 
            this.text_time.Location = new System.Drawing.Point(631, 125);
            this.text_time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(101, 25);
            this.text_time.TabIndex = 10;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(805, 124);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(84, 28);
            this.confirm.TabIndex = 11;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            this.confirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.time_change_button);
            // 
            // File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 1055);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.text_time);
            this.Controls.Add(this.time_choose);
            this.Controls.Add(this.path_choose);
            this.Controls.Add(this.name);
            this.Controls.Add(this.file_show);
            this.Controls.Add(this.File_path);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.directoryTree);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "File";
            this.Text = "File";
            this.Load += new System.EventHandler(this.File_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.ImageList directoryIcons;
        private System.Windows.Forms.ImageList filesIcons;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.TextBox File_path;
        private System.Windows.Forms.ListView file_show;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader filechange;
        private System.Windows.Forms.ColumnHeader changetime;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label path_choose;
        private System.Windows.Forms.Label time_choose;
        private System.Windows.Forms.Timer check_time;
        private System.Windows.Forms.TextBox text_time;
        private System.Windows.Forms.Button confirm;
    }
}

