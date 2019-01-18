namespace SecureTree
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.filesList = new System.Windows.Forms.ListView();
            this.directoryIcons = new System.Windows.Forms.ImageList(this.components);
            this.filesIcons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directoryTree
            // 
            this.directoryTree.ImageIndex = 0;
            this.directoryTree.ImageList = this.directoryIcons;
            this.directoryTree.Location = new System.Drawing.Point(63, 81);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(528, 300);
            this.directoryTree.TabIndex = 0;
            // 
            // filesList
            // 
            this.filesList.Location = new System.Drawing.Point(624, 81);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(551, 300);
            this.filesList.SmallImageList = this.filesIcons;
            this.filesList.TabIndex = 1;
            this.filesList.UseCompatibleStateImageBehavior = false;
            // 
            // directoryIcons
            // 
            this.directoryIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryIcons.ImageStream")));
            this.directoryIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.directoryIcons.Images.SetKeyName(0, "Computer .jpg");
            this.directoryIcons.Images.SetKeyName(1, "Close Folder.jpg");
            this.directoryIcons.Images.SetKeyName(2, "Open Folder.jpg");
            this.directoryIcons.Images.SetKeyName(3, "fixed drive.jpg");
            this.directoryIcons.Images.SetKeyName(4, "My Documents.jpg");
            // 
            // filesIcons
            // 
            this.filesIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("filesIcons.ImageStream")));
            this.filesIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.filesIcons.Images.SetKeyName(0, "Close Folder.jpg");
            this.filesIcons.Images.SetKeyName(1, "Open Folder.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 38F);
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件系统";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.directoryTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.ImageList directoryIcons;
        private System.Windows.Forms.ListView filesList;
        private System.Windows.Forms.ImageList filesIcons;
        private System.Windows.Forms.Label label1;
    }
}

