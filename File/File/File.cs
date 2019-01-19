using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace File
{
    public partial class File : Form
    {
        string Path;
        string[] process = new string[4] { "0", "0", "0", "user" };
        int temp = 60, i = 0;
        private class IconIndexes
        {
            public const int MyComputer = 0;      //我的电脑  
            public const int ClosedFolder = 1;    //文件夹关闭  
            public const int OpenFolder = 2;      //文件夹打开  
            public const int FixedDrive = 3;      //磁盘盘符  
            public const int MyDocuments = 4;     //我的文档  
        }
        public File()
        {
            InitializeComponent();
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
        private void Pathtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tree(string path, TreeNode node)/*生成文件树*/
        {
            DirectoryInfo mydir = new DirectoryInfo(@path);
            //获取目录中的目录以及它们的名称
            DirectoryInfo[] d = mydir.GetDirectories();
            FileInfo[] f = mydir.GetFiles();
            //TreeNode node0 = directoryTree.Nodes.Add(mydir.Name);
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
            directoryTree.Nodes.Clear();
            Path = File_path.Text;
            if (Path != "")
            {
               TestFileSystemWatcher(Path);
                DirectoryInfo MYDIR = new DirectoryInfo(@Path);
                TreeNode node = new TreeNode();
                node.Text = MYDIR.Name;
                directoryTree.Nodes.Add(node);
                Tree(Path, node);
                string[] row1 = { process[1], process[2], process[3] };
                file_show.Items.Add(process[0]).SubItems.AddRange(row1);
                for (int j = 0; j < 3; j++)
                    process[j] = "0";
                process[3] = "user";

            }
        }
        

        private void choose_file(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               string path = dialog.SelectedPath;
            }
            File_path.Text = dialog.SelectedPath;
            Fuction();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void File_Load(object sender, EventArgs e)
        {

        }

        private void time_change_button(object sender, MouseEventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(text_time.Text);
            i = 0;
            Fuction();
        }

        private void File_Load_1(object sender, EventArgs e)
        {

        }

        private void check_time_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == temp)
            {
                i = 0;
                Fuction();
            }
        }
    }

}
