namespace FinalFile
{
    partial class FinalFile
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.tree_directory = new System.Windows.Forms.TreeView();
            this.btn_choose = new System.Windows.Forms.Button();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.fBD = new System.Windows.Forms.FolderBrowserDialog();
            this.lvw_show = new System.Windows.Forms.ListView();
            this.col_filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_changestyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_changetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_filetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.fSW = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fSW)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ok.Location = new System.Drawing.Point(480, 52);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(57, 42);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btm_ok_Click);
            // 
            // tree_directory
            // 
            this.tree_directory.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tree_directory.LabelEdit = true;
            this.tree_directory.Location = new System.Drawing.Point(59, 104);
            this.tree_directory.Margin = new System.Windows.Forms.Padding(4);
            this.tree_directory.Name = "tree_directory";
            this.tree_directory.PathSeparator = "";
            this.tree_directory.Size = new System.Drawing.Size(469, 418);
            this.tree_directory.TabIndex = 0;
            this.tree_directory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tree_directory_BeforeExpand);
            this.tree_directory.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tree_directory_AfterExpand);
            this.tree_directory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_directory_AfterSelect);
            this.tree_directory.Layout += new System.Windows.Forms.LayoutEventHandler(this.tree_directory_Layout);
            // 
            // btn_choose
            // 
            this.btn_choose.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_choose.Location = new System.Drawing.Point(355, 51);
            this.btn_choose.Margin = new System.Windows.Forms.Padding(4);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(117, 45);
            this.btn_choose.TabIndex = 1;
            this.btn_choose.Text = "choose";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // txt_show
            // 
            this.txt_show.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_show.Location = new System.Drawing.Point(59, 49);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(289, 47);
            this.txt_show.TabIndex = 2;
            this.txt_show.Text = "click \'choose\' to choose a file folder and then \'ok\'";
            this.txt_show.TextChanged += new System.EventHandler(this.txt_show_TextChanged);
            // 
            // lvw_show
            // 
            this.lvw_show.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_filename,
            this.col_changestyle,
            this.col_changetime,
            this.col_filetype});
            this.lvw_show.Location = new System.Drawing.Point(636, 104);
            this.lvw_show.Name = "lvw_show";
            this.lvw_show.Scrollable = false;
            this.lvw_show.Size = new System.Drawing.Size(445, 418);
            this.lvw_show.TabIndex = 3;
            this.lvw_show.UseCompatibleStateImageBehavior = false;
            this.lvw_show.View = System.Windows.Forms.View.Details;
            this.lvw_show.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvw_show_ItemCheck);
            this.lvw_show.SelectedIndexChanged += new System.EventHandler(this.lvw_show_SelectedIndexChanged);
            // 
            // col_filename
            // 
            this.col_filename.Tag = "";
            this.col_filename.Text = "filename";
            this.col_filename.Width = 70;
            // 
            // col_changestyle
            // 
            this.col_changestyle.Text = "changestyle";
            this.col_changestyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_changestyle.Width = 90;
            // 
            // col_changetime
            // 
            this.col_changetime.Text = "changetime";
            this.col_changetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_changetime.Width = 90;
            // 
            // col_filetype
            // 
            this.col_filetype.Text = "filetype";
            this.col_filetype.Width = 90;
            // 
            // tim
            // 
            this.tim.Enabled = true;
            this.tim.Interval = 10000;
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            
            // 
            // fSW
            // 
            this.fSW.EnableRaisingEvents = true;
            this.fSW.SynchronizingObject = this;
            this.fSW.Changed += new System.IO.FileSystemEventHandler(this.fSW_Changed);
            // 
            // FinalFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 563);
            this.Controls.Add(this.lvw_show);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.tree_directory);
            this.Controls.Add(this.btn_ok);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalFile";
            this.Text = "FinalFile";
            this.Load += new System.EventHandler(this.FinalFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fSW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TreeView tree_directory;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.FolderBrowserDialog fBD;
        private System.Windows.Forms.ListView lvw_show;
        private System.Windows.Forms.ColumnHeader col_filename;
        private System.Windows.Forms.ColumnHeader col_changestyle;
        private System.Windows.Forms.ColumnHeader col_changetime;
        private System.Windows.Forms.ColumnHeader col_filetype;
        private System.Windows.Forms.Timer tim;
        private System.IO.FileSystemWatcher fSW;
    }
}

