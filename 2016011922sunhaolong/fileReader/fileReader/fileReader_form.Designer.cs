namespace fileReader
{
    partial class fileReader
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.treeView = new System.Windows.Forms.TreeView();
            this.fileBtn = new System.Windows.Forms.Button();
            this.fileTxt = new System.Windows.Forms.TextBox();
            this.fileLab = new System.Windows.Forms.Label();
            this.viewLab = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeLab = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.timeBtn = new System.Windows.Forms.Button();
            this.sLab = new System.Windows.Forms.Label();
            this.timerWatcher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(21, 109);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(423, 448);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(248, 42);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(85, 25);
            this.fileBtn.TabIndex = 1;
            this.fileBtn.Text = "确定";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // fileTxt
            // 
            this.fileTxt.Location = new System.Drawing.Point(24, 42);
            this.fileTxt.Name = "fileTxt";
            this.fileTxt.Size = new System.Drawing.Size(196, 25);
            this.fileTxt.TabIndex = 2;
            // 
            // fileLab
            // 
            this.fileLab.AutoSize = true;
            this.fileLab.Location = new System.Drawing.Point(18, 24);
            this.fileLab.Name = "fileLab";
            this.fileLab.Size = new System.Drawing.Size(142, 15);
            this.fileLab.TabIndex = 3;
            this.fileLab.Text = "请输入文件夹路径：";
            // 
            // viewLab
            // 
            this.viewLab.AutoSize = true;
            this.viewLab.Location = new System.Drawing.Point(21, 88);
            this.viewLab.Name = "viewLab";
            this.viewLab.Size = new System.Drawing.Size(82, 15);
            this.viewLab.TabIndex = 4;
            this.viewLab.Text = "文件夹结构";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(339, 42);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(105, 25);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "浏览文件夹";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.changeCol,
            this.timeCol});
            this.listView.Font = new System.Drawing.Font("宋体", 12F);
            this.listView.GridLines = true;
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            this.listView.Location = new System.Drawing.Point(475, 109);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(590, 448);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nameCol
            // 
            this.nameCol.Text = "文件名";
            this.nameCol.Width = 280;
            // 
            // changeCol
            // 
            this.changeCol.Text = "操作";
            this.changeCol.Width = 90;
            // 
            // timeCol
            // 
            this.timeCol.Text = "修改时间";
            this.timeCol.Width = 220;
            // 
            // timeLab
            // 
            this.timeLab.AutoSize = true;
            this.timeLab.Font = new System.Drawing.Font("宋体", 12F);
            this.timeLab.Location = new System.Drawing.Point(525, 47);
            this.timeLab.Name = "timeLab";
            this.timeLab.Size = new System.Drawing.Size(259, 20);
            this.timeLab.TabIndex = 7;
            this.timeLab.Text = "设置间隔时间（默认30s）：";
            // 
            // timeTxt
            // 
            this.timeTxt.Location = new System.Drawing.Point(790, 44);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(100, 25);
            this.timeTxt.TabIndex = 8;
            // 
            // timeBtn
            // 
            this.timeBtn.Location = new System.Drawing.Point(935, 42);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(101, 27);
            this.timeBtn.TabIndex = 9;
            this.timeBtn.Text = "确定";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // sLab
            // 
            this.sLab.AutoSize = true;
            this.sLab.Font = new System.Drawing.Font("宋体", 12F);
            this.sLab.Location = new System.Drawing.Point(896, 49);
            this.sLab.Name = "sLab";
            this.sLab.Size = new System.Drawing.Size(19, 20);
            this.sLab.TabIndex = 11;
            this.sLab.Text = "s";
            // 
            // timerWatcher
            // 
            this.timerWatcher.Enabled = true;
            this.timerWatcher.Interval = 1000;
            this.timerWatcher.Tick += new System.EventHandler(this.timerWatcher_Tick);
            // 
            // fileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 586);
            this.Controls.Add(this.sLab);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.timeLab);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.viewLab);
            this.Controls.Add(this.fileLab);
            this.Controls.Add(this.fileTxt);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.treeView);
            this.Name = "fileReader";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.TextBox fileTxt;
        private System.Windows.Forms.Label fileLab;
        private System.Windows.Forms.Label viewLab;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader changeCol;
        private System.Windows.Forms.ColumnHeader timeCol;
        private System.Windows.Forms.Label timeLab;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.Button timeBtn;
        private System.Windows.Forms.Label sLab;
        private System.Windows.Forms.Timer timerWatcher;
    }
}

