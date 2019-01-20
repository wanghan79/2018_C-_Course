namespace fileManager
{
    partial class fileManager
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
            this.filetree = new System.Windows.Forms.TreeView();
            this.select_path = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.filechangelist = new System.Windows.Forms.ListView();
            this.file_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.change_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.change_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_path = new System.Windows.Forms.Label();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_change_timer = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filetree
            // 
            this.filetree.Location = new System.Drawing.Point(87, 101);
            this.filetree.Name = "filetree";
            this.filetree.Size = new System.Drawing.Size(242, 192);
            this.filetree.TabIndex = 0;
            // 
            // select_path
            // 
            this.select_path.Location = new System.Drawing.Point(284, 43);
            this.select_path.Name = "select_path";
            this.select_path.Size = new System.Drawing.Size(75, 23);
            this.select_path.TabIndex = 1;
            this.select_path.Text = "选择路径";
            this.select_path.UseVisualStyleBackColor = true;
            this.select_path.Click += new System.EventHandler(this.click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(203, 43);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirmpath);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(87, 45);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(100, 21);
            this.txt_path.TabIndex = 3;
            // 
            // filechangelist
            // 
            this.filechangelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file_path,
            this.change_type,
            this.change_time,
            this.user});
            this.filechangelist.Location = new System.Drawing.Point(461, 101);
            this.filechangelist.Name = "filechangelist";
            this.filechangelist.Size = new System.Drawing.Size(456, 192);
            this.filechangelist.TabIndex = 4;
            this.filechangelist.UseCompatibleStateImageBehavior = false;
            this.filechangelist.View = System.Windows.Forms.View.Details;
            // 
            // file_path
            // 
            this.file_path.Text = "文件名";
            this.file_path.Width = 200;
            // 
            // change_type
            // 
            this.change_type.Text = "修改类型";
            // 
            // change_time
            // 
            this.change_time.Text = "修改时间";
            this.change_time.Width = 120;
            // 
            // user
            // 
            this.user.Text = "用户";
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.Timer);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(12, 48);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(53, 12);
            this.lbl_path.TabIndex = 5;
            this.lbl_path.Text = "文件路径";
            // 
            // txt_timer
            // 
            this.txt_timer.Location = new System.Drawing.Point(638, 44);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.Size = new System.Drawing.Size(100, 21);
            this.txt_timer.TabIndex = 6;
            this.txt_timer.Text = "5";
            this.txt_timer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timer_input);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(559, 48);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 12);
            this.lbl_timer.TabIndex = 7;
            this.lbl_timer.Text = "定时器(s)";
            // 
            // btn_change_timer
            // 
            this.btn_change_timer.Location = new System.Drawing.Point(744, 44);
            this.btn_change_timer.Name = "btn_change_timer";
            this.btn_change_timer.Size = new System.Drawing.Size(75, 23);
            this.btn_change_timer.TabIndex = 8;
            this.btn_change_timer.Text = "修改";
            this.btn_change_timer.UseVisualStyleBackColor = true;
            this.btn_change_timer.Click += new System.EventHandler(this.timer_change);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(416, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(135, 20);
            this.title.TabIndex = 9;
            this.title.Text = "文件管理系统";
            // 
            // fileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 439);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_change_timer);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.filechangelist);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.select_path);
            this.Controls.Add(this.filetree);
            this.Name = "fileManager";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView filetree;
        private System.Windows.Forms.Button select_path;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.ListView filechangelist;
        private System.Windows.Forms.ColumnHeader file_path;
        private System.Windows.Forms.ColumnHeader change_type;
        private System.Windows.Forms.ColumnHeader change_time;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_change_timer;
        private System.Windows.Forms.Label title;
    }
}

