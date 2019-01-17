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

namespace fileReader
{
    
    public partial class fileReader : Form
    {
        string Path;
        string[] process = new string[4] { "0", "0", "0","0" };
        int temp = 5;
        int i = 0;
        public fileReader()
        {
            InitializeComponent();
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            String rootFile = fileTxt.Text.ToString().Trim();
            if (!Directory.Exists(rootFile))
            {
                MessageBox.Show("文件夹位置错误！");
            }
            else
            {
                //根节点
                TreeNode rootNode = new TreeNode();
                rootNode.Text = rootFile;
                //递归创建节点
                createNodes(rootFile, rootNode);
                //TreeView
                treeView.Nodes.Add(rootNode);
                treeView.ExpandAll();
            }
            creatCol();
        }
        private void createNodes(String rootFile, TreeNode rootNode)
        {
            DirectoryInfo dInfo = new DirectoryInfo(rootFile);
            //遍历当前文件系统下的所有文件和文件夹
            foreach (FileSystemInfo info in dInfo.GetFileSystemInfos())
            {
                TreeNode node = new TreeNode();
                node.Text = info.Name;
                rootNode.Nodes.Add(node);
                //文件夹
                String file = info.FullName;
                if(Directory.Exists(file))
                {
                    createNodes(file, node);
                }
            }
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            fileTxt.Text = folderDlg.SelectedPath;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WatcherStart(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.Changed += new FileSystemEventHandler(OnProcess);
            watcher.Created += new FileSystemEventHandler(OnProcess);
            watcher.Deleted += new FileSystemEventHandler(OnProcess);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            watcher.IncludeSubdirectories = true;

        }
        private void OnProcess(object source, FileSystemEventArgs e)
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

        private void creatCol()
        {
            Path = fileTxt.Text;
            WatcherStart(Path);
            if (Path != "")
            {
                if (process[0] != "0")
                {
                    string[] row1 = { process[1], process[2], process[3] };
                    listView.Items.Add(process[0]).SubItems.AddRange(row1);
                    for (int j = 0; j < 4; j++)
                        process[j] = "0";
                }
                
            }
            
        }

        private void timeBtn_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(timeTxt.Text);
        }

        private void timerWatcher_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == temp)
            {
                i = 0;
                fileBtn.PerformClick();
            }
        }
    }
}
