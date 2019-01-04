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

namespace FileRead
{
    public partial class Form1 : Form
    {
        TreeNode rootNode = new TreeNode();
        
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void butSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            
            string fileLoc = txtLoc.Text;
            //TreeNode rootNode = new TreeNode();
            rootNode.Text = fileLoc;
            treeView.Nodes.Add(rootNode);
            director(fileLoc,rootNode);
            WatcherStrat(fileLoc, "");
            listBox.Items.Add("修改类型         时间            文件名" );
            this.time.Enabled = true;
        }
        public void director(string dirs,TreeNode upNode)
        {
            
            //绑定到指定的文件夹目录
            DirectoryInfo dir = new DirectoryInfo(dirs);
            //检索表示当前目录的文件和子目录
            FileSystemInfo[] fsinfos = dir.GetFileSystemInfos();
            //遍历检索的文件和子目录
            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                //判断是否为空文件夹　　
                if (fsinfo is DirectoryInfo)
                {
                    //递归调用
                    TreeNode sonNode = new TreeNode();
                    sonNode.Text = fsinfo.FullName;
                    upNode.Nodes.Add(sonNode);
                    director(fsinfo.FullName, sonNode);
                }
                else
                {
                    TreeNode sonNode = new TreeNode();
                    sonNode.Text = fsinfo.FullName;
                    upNode.Nodes.Add(sonNode);
                    
                }
            }
        }
        private void WatcherStrat(string path, string filter)
       {
 
           FileSystemWatcher watcher = new FileSystemWatcher();
           watcher.Path = path;
           watcher.Filter = filter;
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
           if (e.ChangeType == WatcherChangeTypes.Created)
           {
               OnCreated(source, e);
           }
           else if (e.ChangeType == WatcherChangeTypes.Changed)
           {
               OnChanged(source, e);
           }
           else if (e.ChangeType == WatcherChangeTypes.Deleted)
           {
               OnDeleted(source, e);
           }
 
       }
        private void OnCreated(object source, FileSystemEventArgs e)
       {
           FileInfo f = new FileInfo(e.FullPath);
           string time = f.CreationTime.ToString();
           listBox.Items.Add("  新建    " + time + "    " + e.Name);
           this.time.Enabled = true;
           
       }
       private void OnChanged(object source, FileSystemEventArgs e)
       {
           FileInfo f = new FileInfo(e.FullPath);
           string time = f.LastWriteTime.ToString();
           listBox.Items.Add("  修改    " + time + "    "  +e.Name);
       }
        
       private void OnDeleted(object source, FileSystemEventArgs e)
       {
           string time = System.DateTime.Now.ToString();
           listBox.Items.Add("  删除    " + time + "    " + e.Name);
       }
        
       private void OnRenamed(object source, RenamedEventArgs e)
       {
           FileInfo f = new FileInfo(e.FullPath);
           string time = f.LastAccessTime.ToString();
           listBox.Items.Add("  重命名  " + time + "    " + e.Name);
       }
   
        private void time_Tick(object sender, EventArgs e)
        {
            string fileLoc = txtLoc.Text;
            //WatcherStrat(fileLoc, "");
           
        }
    }
}
