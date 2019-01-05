using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class Management : Form
    {
        string Path;
        string[] process = new string[4] { "0", "0", "0", "user" };
        int temp = 60, i = 0;

        public Management()
        {
            InitializeComponent();
        }


        private void trv_directory_file_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void liv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TestFileSystemWatcher(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = path;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            //设置监视文件的哪些修改行为
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;


            // watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;

        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            process[0] = e.FullPath;
            process[1] = e.ChangeType.ToString();
            process[2] = DateTime.Now.ToString();
        }
        private void OnRenamed(object source, RenamedEventArgs e)
        {

            process[0] = e.FullPath;
            process[1] = e.ChangeType.ToString();
            process[2] = DateTime.Now.ToString();
        }


        private void Tree(string path, TreeNode node)/*生成文件树*/
        {
            DirectoryInfo mydir = new DirectoryInfo(@path);
            //获取目录中的目录以及它们的名称
            DirectoryInfo[] d = mydir.GetDirectories();
            FileInfo[] f = mydir.GetFiles();
            //TreeNode node0 = Documenttree.Nodes.Add(mydir.Name);
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

            // 获取目录中的文件以及它们的名称
            if (f.Length > 0)
            foreach (FileInfo file in f)
            {
                TreeNode node2 = new TreeNode();
                node2.Text = file.Name;
                node.Nodes.Add(node2);
            }
        }

        private void Fuction()
        {
            trv_directory_file.Nodes.Clear();
            Path = txb_path.Text;
            if (Path != "")
            {
                TestFileSystemWatcher(Path);
                DirectoryInfo MYDIR = new DirectoryInfo(@Path);
                TreeNode node = new TreeNode();
                node.Text = MYDIR.Name;
                trv_directory_file.Nodes.Add(node);
                Tree(Path, node);
                string[] row1 = { process[1], process[2], process[3] };
                liv_process_list.Items.Add(process[0]).SubItems.AddRange(row1);
                for (int j = 0; j < 3; j++)
                    process[j] = "0";
                process[3] = "user";

            }
        }

        private void btn_path_confirm_Click(object sender, EventArgs e)
        {
            Fuction();
        }

        private void btn_time_confirm_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(txb_time.Text);
            i = 0;
            btn_path_confirm_Click(null, null);
        }

        private void tim_time_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == temp)
            {
                i = 0;
                btn_path_confirm_Click(null, null);
            }
        }

        private void txb_path_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
