using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManagementSystem
{
    public partial class DocumentManagement : Form
    {
        string Path;
        string[] process = new string[4] { "0", "0", "0", "user" };
        int toltime = 15, begin = 0;
        public DocumentManagement()
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
        private void ShowTree(string path,TreeNode node)
        {
            //找到目录中的子目录和名称
            DirectoryInfo mydir = new DirectoryInfo(@path);
            DirectoryInfo[] doc = mydir.GetDirectories();
            FileInfo[] file = mydir.GetFiles();
            if (doc.Length > 0)
            {
                foreach (DirectoryInfo dir in doc)
                {
                    string p1 = dir.FullName;
                    TreeNode node0 = new TreeNode();
                    node0.Text = dir.Name;
                    node.Nodes.Add(node0);
                    ShowTree(p1, node0);
                }
            }
            if(file.Length>0)
            {
                foreach( FileInfo file1 in file)
                {
                    TreeNode node1 = new TreeNode();
                    node1.Text = file1.Name;
                    node.Nodes.Add(node1);
                }
            }
            
        }
        private void Fuction()
        {
            Documenttree.Nodes.Clear();
            Path = textBox_pathsearch.Text;
            if(Path !=" ")
            {    //调用文件监视，看路径是否改变
                TestFileSystemWatcher(Path);
                //创建
                DirectoryInfo Mydir = new DirectoryInfo(@Path);
                TreeNode nodex = new TreeNode();
                nodex.Text = Mydir.Name;
                Documenttree.Nodes.Add(nodex);
                ShowTree(Path, nodex);
                String[] row = { process[1], process[2], process[3] };
                Processlist.Items.Add(process[0]).SubItems.AddRange(row);
                for (int i = 0; i < 3; i++)
                    process[i] = "0";
                process[3] = "localuser";

            }
            }
        private void DocumentManagement_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_pathsearch_Click(object sender, EventArgs e)
        {
            Fuction();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void subtimer_Tick(object sender, EventArgs e)
        {
            begin++;
            if (begin == toltime)
            {
                begin = 0;
                button_pathsearch_Click(null, null);
            }
        }

        private void button_timer_Click(object sender, EventArgs e)
        {
            toltime = Convert.ToInt32(textBox_timer.Text);
            begin = 0;
            button_pathsearch_Click(null, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
