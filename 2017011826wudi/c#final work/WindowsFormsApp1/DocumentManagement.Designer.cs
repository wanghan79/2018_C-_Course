using System;

namespace DocumentManagementSystem
{
    partial class DocumentManagement
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
            this.Documenttree = new System.Windows.Forms.TreeView();
            this.Processlist = new System.Windows.Forms.ListView();
            this.headerfile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerchange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headeruser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_titlename = new System.Windows.Forms.Label();
            this.textBox_timer = new System.Windows.Forms.TextBox();
            this.label_timer = new System.Windows.Forms.Label();
            this.button_pathsearch = new System.Windows.Forms.Button();
            this.button_timer = new System.Windows.Forms.Button();
            this.label_pathsearch = new System.Windows.Forms.Label();
            this.textBox_pathsearch = new System.Windows.Forms.TextBox();
            this.subtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Documenttree
            // 
            this.Documenttree.Location = new System.Drawing.Point(12, 136);
            this.Documenttree.Name = "Documenttree";
            this.Documenttree.Size = new System.Drawing.Size(735, 511);
            this.Documenttree.TabIndex = 0;
            // 
            // Processlist
            // 
            this.Processlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerfile,
            this.headerchange,
            this.headertime,
            this.headeruser});
            this.Processlist.Location = new System.Drawing.Point(753, 136);
            this.Processlist.Name = "Processlist";
            this.Processlist.Size = new System.Drawing.Size(727, 511);
            this.Processlist.TabIndex = 1;
            this.Processlist.UseCompatibleStateImageBehavior = false;
            this.Processlist.View = System.Windows.Forms.View.Details;
            // 
            // headerfile
            // 
            this.headerfile.Text = "文件名";
            this.headerfile.Width = 200;
            // 
            // headerchange
            // 
            this.headerchange.Text = "修改操作";
            this.headerchange.Width = 150;
            // 
            // headertime
            // 
            this.headertime.Text = "时间";
            this.headertime.Width = 172;
            // 
            // headeruser
            // 
            this.headeruser.Text = "用户";
            this.headeruser.Width = 100;
            // 
            // label_titlename
            // 
            this.label_titlename.AutoSize = true;
            this.label_titlename.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_titlename.Location = new System.Drawing.Point(500, 22);
            this.label_titlename.Name = "label_titlename";
            this.label_titlename.Size = new System.Drawing.Size(244, 28);
            this.label_titlename.TabIndex = 2;
            this.label_titlename.Text = "文件树状监控系统";
            this.label_titlename.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_timer
            // 
            this.textBox_timer.Location = new System.Drawing.Point(1087, 84);
            this.textBox_timer.Name = "textBox_timer";
            this.textBox_timer.Size = new System.Drawing.Size(124, 25);
            this.textBox_timer.TabIndex = 6;
            this.textBox_timer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_timer.Location = new System.Drawing.Point(664, 89);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(368, 20);
            this.label_timer.TabIndex = 4;
            this.label_timer.Text = "请输入检查周期时间（初始值为15S）:";
            // 
            // button_pathsearch
            // 
            this.button_pathsearch.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_pathsearch.Location = new System.Drawing.Point(549, 84);
            this.button_pathsearch.Name = "button_pathsearch";
            this.button_pathsearch.Size = new System.Drawing.Size(66, 32);
            this.button_pathsearch.TabIndex = 5;
            this.button_pathsearch.Text = "确认";
            this.button_pathsearch.UseVisualStyleBackColor = true;
            this.button_pathsearch.Click += new System.EventHandler(this.button_pathsearch_Click);
            // 
            // button_timer
            // 
            this.button_timer.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_timer.Location = new System.Drawing.Point(1262, 73);
            this.button_timer.Name = "button_timer";
            this.button_timer.Size = new System.Drawing.Size(75, 36);
            this.button_timer.TabIndex = 6;
            this.button_timer.Text = "确认";
            this.button_timer.UseVisualStyleBackColor = true;
            this.button_timer.Click += new System.EventHandler(this.button_timer_Click);
            // 
            // label_pathsearch
            // 
            this.label_pathsearch.AutoSize = true;
            this.label_pathsearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_pathsearch.Location = new System.Drawing.Point(79, 96);
            this.label_pathsearch.Name = "label_pathsearch";
            this.label_pathsearch.Size = new System.Drawing.Size(135, 20);
            this.label_pathsearch.TabIndex = 7;
            this.label_pathsearch.Text = "请输入路径：";
            // 
            // textBox_pathsearch
            // 
            this.textBox_pathsearch.Location = new System.Drawing.Point(220, 91);
            this.textBox_pathsearch.Name = "textBox_pathsearch";
            this.textBox_pathsearch.Size = new System.Drawing.Size(297, 25);
            this.textBox_pathsearch.TabIndex = 8;
            this.textBox_pathsearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // subtimer
            // 
            this.subtimer.Enabled = true;
            this.subtimer.Interval = 1000;
            this.subtimer.Tick += new System.EventHandler(this.subtimer_Tick);
            // 
            // DocumentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 675);
            this.Controls.Add(this.textBox_pathsearch);
            this.Controls.Add(this.label_pathsearch);
            this.Controls.Add(this.button_timer);
            this.Controls.Add(this.button_pathsearch);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.textBox_timer);
            this.Controls.Add(this.label_titlename);
            this.Controls.Add(this.Processlist);
            this.Controls.Add(this.Documenttree);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DocumentManagement";
            this.Text = "Document Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }



        #endregion

        private System.Windows.Forms.TreeView Documenttree;
        private System.Windows.Forms.ListView Processlist;
        private System.Windows.Forms.Label label_titlename;
        private System.Windows.Forms.TextBox textBox_timer;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Button button_pathsearch;
        private System.Windows.Forms.Button button_timer;
        private System.Windows.Forms.Label label_pathsearch;
        private System.Windows.Forms.TextBox textBox_pathsearch;
        private System.Windows.Forms.ColumnHeader headerfile;
        private System.Windows.Forms.ColumnHeader headerchange;
        private System.Windows.Forms.ColumnHeader headertime;
        private System.Windows.Forms.ColumnHeader headeruser;
        private System.Windows.Forms.Timer subtimer;
    }
}

