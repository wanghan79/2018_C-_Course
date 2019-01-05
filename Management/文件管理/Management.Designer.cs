namespace Management
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_path = new System.Windows.Forms.Label();
            this.txb_path = new System.Windows.Forms.TextBox();
            this.btn_path_confirm = new System.Windows.Forms.Button();
            this.lab_time = new System.Windows.Forms.Label();
            this.txb_time = new System.Windows.Forms.TextBox();
            this.btn_time_confirm = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.trv_directory_file = new System.Windows.Forms.TreeView();
            this.liv_process_list = new System.Windows.Forms.ListView();
            this.tim_time = new System.Windows.Forms.Timer(this.components);
            this.update_filer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.update_change = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.update_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.update_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lab_path
            // 
            this.lab_path.AutoSize = true;
            this.lab_path.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_path.Location = new System.Drawing.Point(131, 92);
            this.lab_path.Name = "lab_path";
            this.lab_path.Size = new System.Drawing.Size(125, 21);
            this.lab_path.TabIndex = 0;
            this.lab_path.Text = "请选择路径";
            // 
            // txb_path
            // 
            this.txb_path.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_path.Location = new System.Drawing.Point(262, 88);
            this.txb_path.Name = "txb_path";
            this.txb_path.Size = new System.Drawing.Size(203, 32);
            this.txb_path.TabIndex = 1;
            this.txb_path.TextChanged += new System.EventHandler(this.txb_path_TextChanged);
            // 
            // btn_path_confirm
            // 
            this.btn_path_confirm.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_path_confirm.Location = new System.Drawing.Point(471, 84);
            this.btn_path_confirm.Name = "btn_path_confirm";
            this.btn_path_confirm.Size = new System.Drawing.Size(75, 36);
            this.btn_path_confirm.TabIndex = 2;
            this.btn_path_confirm.Text = "确定";
            this.btn_path_confirm.UseVisualStyleBackColor = true;
            this.btn_path_confirm.Click += new System.EventHandler(this.btn_path_confirm_Click);
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_time.Location = new System.Drawing.Point(131, 152);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(299, 21);
            this.lab_time.TabIndex = 3;
            this.lab_time.Text = "请输入时间间隔（默认60s）";
            this.lab_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_time
            // 
            this.txb_time.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_time.Location = new System.Drawing.Point(437, 151);
            this.txb_time.Name = "txb_time";
            this.txb_time.Size = new System.Drawing.Size(100, 32);
            this.txb_time.TabIndex = 4;
            // 
            // btn_time_confirm
            // 
            this.btn_time_confirm.Font = new System.Drawing.Font("KaiTi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_time_confirm.Location = new System.Drawing.Point(543, 144);
            this.btn_time_confirm.Name = "btn_time_confirm";
            this.btn_time_confirm.Size = new System.Drawing.Size(75, 36);
            this.btn_time_confirm.TabIndex = 5;
            this.btn_time_confirm.Text = "确定";
            this.btn_time_confirm.UseVisualStyleBackColor = true;
            this.btn_time_confirm.Click += new System.EventHandler(this.btn_time_confirm_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("STXingkai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(302, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 30);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "文件管理器";
            // 
            // trv_directory_file
            // 
            this.trv_directory_file.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv_directory_file.Location = new System.Drawing.Point(27, 196);
            this.trv_directory_file.Name = "trv_directory_file";
            this.trv_directory_file.Size = new System.Drawing.Size(231, 250);
            this.trv_directory_file.TabIndex = 4;
            this.trv_directory_file.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_directory_file_AfterSelect);
            // 
            // liv_process_list
            // 
            this.liv_process_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.update_filer,
            this.update_change,
            this.update_time,
            this.update_user});
            this.liv_process_list.Font = new System.Drawing.Font("STKaiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.liv_process_list.Location = new System.Drawing.Point(284, 196);
            this.liv_process_list.Name = "liv_process_list";
            this.liv_process_list.RightToLeftLayout = true;
            this.liv_process_list.Size = new System.Drawing.Size(516, 250);
            this.liv_process_list.TabIndex = 4;
            this.liv_process_list.UseCompatibleStateImageBehavior = false;
            this.liv_process_list.UseWaitCursor = true;
            this.liv_process_list.View = System.Windows.Forms.View.Details;
            this.liv_process_list.SelectedIndexChanged += new System.EventHandler(this.liv_SelectedIndexChanged);
            // 
            // tim_time
            // 
            this.tim_time.Tick += new System.EventHandler(this.tim_time_Tick);
            // 
            // update_filer
            // 
            this.update_filer.Text = "文件名";
            this.update_filer.Width = 117;
            // 
            // update_change
            // 
            this.update_change.Text = "修改操作";
            this.update_change.Width = 134;
            // 
            // update_time
            // 
            this.update_time.Text = "时间";
            this.update_time.Width = 134;
            // 
            // update_user
            // 
            this.update_user.Text = "用户";
            this.update_user.Width = 135;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 458);
            this.Controls.Add(this.liv_process_list);
            this.Controls.Add(this.trv_directory_file);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_time_confirm);
            this.Controls.Add(this.txb_time);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.btn_path_confirm);
            this.Controls.Add(this.txb_path);
            this.Controls.Add(this.lab_path);
            this.Name = "Management";
            this.Text = "文件管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_path;
        private System.Windows.Forms.TextBox txb_path;
        private System.Windows.Forms.Button btn_path_confirm;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.TextBox txb_time;
        private System.Windows.Forms.Button btn_time_confirm;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TreeView trv_directory_file;
        private System.Windows.Forms.ListView liv_process_list;
        private System.Windows.Forms.Timer tim_time;
        private System.Windows.Forms.ColumnHeader update_filer;
        private System.Windows.Forms.ColumnHeader update_change;
        private System.Windows.Forms.ColumnHeader update_time;
        private System.Windows.Forms.ColumnHeader update_user;

    }
}

