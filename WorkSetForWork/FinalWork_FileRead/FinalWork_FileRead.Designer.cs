namespace FinalWork_FileRead
{
    partial class FinalWork_FileRead
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
            this.treeView_folder = new System.Windows.Forms.TreeView();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.listbox_record = new System.Windows.Forms.ListBox();
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // treeView_folder
            // 
            this.treeView_folder.Location = new System.Drawing.Point(112, 181);
            this.treeView_folder.Name = "treeView_folder";
            this.treeView_folder.Size = new System.Drawing.Size(198, 184);
            this.treeView_folder.TabIndex = 0;
            this.treeView_folder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(112, 98);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(176, 21);
            this.txt_folder.TabIndex = 2;
            // 
            // listbox_record
            // 
            this.listbox_record.FormattingEnabled = true;
            this.listbox_record.ItemHeight = 12;
            this.listbox_record.Location = new System.Drawing.Point(384, 181);
            this.listbox_record.Name = "listbox_record";
            this.listbox_record.Size = new System.Drawing.Size(244, 184);
            this.listbox_record.TabIndex = 3;
            this.listbox_record.SelectedIndexChanged += new System.EventHandler(this.l_SelectedIndexChanged);
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Location = new System.Drawing.Point(365, 98);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_select_folder.TabIndex = 4;
            this.btn_select_folder.Text = "选择文件夹";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(528, 96);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 5;
            this.btn_set.Text = "设置";
            this.btn_set.UseVisualStyleBackColor = true;
            // 
            // timer_check
            // 
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // FinalWork_FileRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 496);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_select_folder);
            this.Controls.Add(this.listbox_record);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.treeView_folder);
            this.Name = "FinalWork_FileRead";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_folder;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.ListBox listbox_record;
        private System.Windows.Forms.Button btn_select_folder;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Timer timer_check;
    }
}

