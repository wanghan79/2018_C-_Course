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
            this.btn_traverse = new System.Windows.Forms.Button();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView_folder
            // 
            this.treeView_folder.Location = new System.Drawing.Point(36, 246);
            this.treeView_folder.Name = "treeView_folder";
            this.treeView_folder.Size = new System.Drawing.Size(401, 232);
            this.treeView_folder.TabIndex = 0;
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(36, 184);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(401, 21);
            this.txt_folder.TabIndex = 2;
            // 
            // listbox_record
            // 
            this.listbox_record.FormattingEnabled = true;
            this.listbox_record.ItemHeight = 12;
            this.listbox_record.Location = new System.Drawing.Point(456, 246);
            this.listbox_record.Name = "listbox_record";
            this.listbox_record.Size = new System.Drawing.Size(504, 232);
            this.listbox_record.TabIndex = 3;
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Location = new System.Drawing.Point(653, 182);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(96, 23);
            this.btn_select_folder.TabIndex = 4;
            this.btn_select_folder.Text = "select folder";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(794, 182);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 5;
            this.btn_set.Text = "setting";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // timer_check
            // 
            this.timer_check.Enabled = true;
            this.timer_check.Interval = 10000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // btn_traverse
            // 
            this.btn_traverse.Location = new System.Drawing.Point(485, 182);
            this.btn_traverse.Name = "btn_traverse";
            this.btn_traverse.Size = new System.Drawing.Size(120, 23);
            this.btn_traverse.TabIndex = 6;
            this.btn_traverse.Text = "default traverse";
            this.btn_traverse.UseVisualStyleBackColor = true;
            this.btn_traverse.Click += new System.EventHandler(this.btn_traverse_Click);
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_remark.Location = new System.Drawing.Point(178, 71);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(571, 42);
            this.lbl_remark.TabIndex = 7;
            this.lbl_remark.Text = "traverse a folder you select or default ,\r\nthen record additions , removes , and " +
    "modifications";
            // 
            // FinalWork_FileRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 536);
            this.Controls.Add(this.lbl_remark);
            this.Controls.Add(this.btn_traverse);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_select_folder);
            this.Controls.Add(this.listbox_record);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.treeView_folder);
            this.Name = "FinalWork_FileRead";
            this.Text = "FinalWork_FileRead";
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
        private System.Windows.Forms.Button btn_traverse;
        private System.Windows.Forms.Label lbl_remark;
    }
}

