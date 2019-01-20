using System;
using System.Windows.Forms;
using System.IO; 
namespace fileManager
{
    public partial class fileManager : Form
    {
        string path = "";
        string[] watcherlist = new string[4] { "", "", "", "wangwx" };
        int flag = 0;//是否修改文件

        public fileManager()
        {
            InitializeComponent();
        }
        //生成树
        private void Tree(string path, TreeNode node)
        {
            DirectoryInfo mydir = new DirectoryInfo(@path);

            DirectoryInfo[] d = mydir.GetDirectories();
            FileInfo[] f = mydir.GetFiles();
   
            if (d.Length > 0)
            {
                foreach (DirectoryInfo dir in d)
                {
                    string p = dir.FullName;
                    TreeNode node1 = new TreeNode();
                    node1.Text = dir.Name;
                    node.Nodes.Add(node1);
                    Tree(p, node1);
                }
            }
            if (f.Length > 0)
                foreach (FileInfo file in f)
                {
                    TreeNode node2 = new TreeNode();
                    node2.Text = file.Name;
                    node.Nodes.Add(node2);
                }

        }

        private void Filewatcher(string path)
        {
            if (path != "")
            {
                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.Path = path;
                Console.WriteLine(path);
                /*监视LastAcceSS和LastWrite时间的更改以及文件或目录的重命名*/
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                       NotifyFilters.FileName | NotifyFilters.DirectoryName;
                //只监视文本文件
                //watcher.Filter = "*.txt";
                //添加事件句柄
                //当由FileSystemWatcher所指定的路径中的文件或目录的
                //大小、系统属性、最后写时间、最后访问时间或安全权限
                //发生更改时，更改事件就会发生
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                //由FileSystemWatcher所指定的路径中文件或目录被创建时，创建事件就会发生
                watcher.Created += new FileSystemEventHandler(OnChanged);
                //当由FileSystemWatcher所指定的路径中文件或目录被删除时，删除事件就会发生
                watcher.Deleted += new FileSystemEventHandler(OnChanged);
                //当由FileSystemWatcher所指定的路径中文件或目录被重命名时，重命名事件就会发生
                watcher.Renamed += new RenamedEventHandler(OnRenamed);
                //开始监视
                watcher.EnableRaisingEvents = true;
            }
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            watcherlist[0] = e.FullPath;
            watcherlist[1] = e.ChangeType.ToString();
            watcherlist[2] = DateTime.Now.ToString();
            flag = 1;
        }
        private void OnRenamed(object source, RenamedEventArgs e)
        {
            watcherlist[0] = e.FullPath;
            watcherlist[1] = e.ChangeType.ToString();
            watcherlist[2] = DateTime.Now.ToString();
            flag = 1;

        }

        //选择文件路径
        private string SelectPath()
        {
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            return path;
        }
        //选择文件路径
        private void click(object sender, EventArgs e)
        {
            filetree.Nodes.Clear(); // 清空
            string path = SelectPath();
            txt_path.Text = path;
            
        }
        //确认按钮，生成树，监视文件
        private void confirmpath(object sender, EventArgs e)
        {
            timer.Enabled = true;
            filetree.Nodes.Clear(); // 清空
            path = txt_path.Text;
            DirectoryInfo dir = new DirectoryInfo(path);
            TreeNode root = new TreeNode();
            root.Text = dir.Name;
            filetree.Nodes.Add(root);
            Tree(path, root);
            Filewatcher(path);
            if (flag == 1)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = watcherlist[0];
                lvi.SubItems.Add(watcherlist[1]);
                lvi.SubItems.Add(watcherlist[2]);
                lvi.SubItems.Add(watcherlist[3]);
                this.filechangelist.Items.Add(lvi);
            }
            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = watcherlist[0];
            //lvi.SubItems.Add(watcherlist[1]);
            //lvi.SubItems.Add(watcherlist[2]);
            //lvi.SubItems.Add(watcherlist[3]);
            //this.filechangelist.Items.Add(lvi);
        }

        //定时器
        private void Timer(object sender, EventArgs e)
        {
                confirmpath(null, null);
        }
        //修改定时器时间
        private void timer_change(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(txt_timer.Text);
            timer.Interval = time * 1000;
        }
        //判断是否输入数字
        private void timer_input(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))//如果不是输入数字就不让输入
            {
                e.Handled = true;
            }    
        }
    }
}
