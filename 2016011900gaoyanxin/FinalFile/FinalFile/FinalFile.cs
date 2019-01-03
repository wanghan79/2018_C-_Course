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



namespace FinalFile
{
 
    public partial class FinalFile : Form
    {
        public static string p = "";
        public static string chosenPath="";
        public static string[] path;
        public static int flag=1;
        
        public FinalFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tree_directory_Layout(object sender, LayoutEventArgs e)
        {

        }
   
        private void FinalFile_Load(object sender, EventArgs e)
        {
            if (chosenPath == "")
            {

                TreeNode rootNode = new TreeNode();  //载入显示 选择显示
                rootNode.Tag = "我的电脑";                            //树节点数据
                rootNode.Text = "我的电脑";                           //树节点标签内容
                this.tree_directory.Nodes.Add(rootNode);               //树中添加根目录

                //显示MyDocuments(我的文档)结点
                var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //myDocuments = "E:";
                //MessageBox.Show(myDocuments );
                TreeNode DocNode = new TreeNode(myDocuments);
                DocNode.Tag = "我的文档";                            //设置结点名称
                DocNode.Text = "我的文档";

                rootNode.Nodes.Add(DocNode);                          //rootNode目录下加载节点
                DocNode.Nodes.Add("");

                //循环遍历计算机所有逻辑驱动器名称(盘符)
                foreach (string drive in Environment.GetLogicalDrives())
                {
                    //实例化DriveInfo对象 命名空间System.IO
                    var dir = new DriveInfo(drive);
                    switch (dir.DriveType)           //判断驱动器类型
                    {
                        case DriveType.Fixed:        //仅取固定磁盘盘符 Removable-U盘 
                            {
                                //Split仅获取盘符字母
                                TreeNode tNode = new TreeNode(dir.Name.Split(':')[0]);
                                tNode.Name = dir.Name;
                                tNode.Tag = tNode.Name;

                                tree_directory.Nodes.Add(tNode);                    //加载驱动节点
                                tNode.Nodes.Add("");
                            }
                            break;
                    }
                }
                rootNode.Expand();                  //展开树状视图
            }
         

        }

        private void tree_directory_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tree_directory_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }

        private void tree_directory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeViewItems.Add(e.Node);
        }
        public static class TreeViewItems
        {
            public static void Add(TreeNode e)
            {
                //try..catch异常处理
                //try..catch异常处理
                try
                {
                    //判断"我的电脑"Tag 上面加载的该结点没指定其路径
                    if (e.Tag.ToString() != "我的电脑")
                    {
                        e.Nodes.Clear();                               //清除空节点再加载子节点
                        TreeNode tNode = e;                            //获取选中\展开\折叠结点
                        string path = tNode.Name;                      //路径 
                        if(flag==1)
                        {
                            path = chosenPath + path;
                            flag = 0;
                        }
                        //MessageBox.Show();
                        //获取"我的文档"路径
                        if (e.Tag.ToString() == "我的文档")
                        {
                            path = Environment.GetFolderPath           //获取计算机我的文档文件夹
                                (Environment.SpecialFolder.MyDocuments);
                        }

                        //获取指定目录中的子目录名称并加载结点GetDirectories
                        string[] dics = Directory.GetFileSystemEntries(path);
                        foreach (string dic in dics)
                        {
                            TreeNode subNode = new TreeNode(new DirectoryInfo(dic).Name); //实例化
                            subNode.Name = new DirectoryInfo(dic).FullName;               //完整目录
                            subNode.Tag = subNode.Name;
                            
                            tNode.Nodes.Add(subNode);
                            subNode.Nodes.Add("");                               //加载空节点 实现+号
                        }
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);                   //异常处理
                }
            }
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
            ofd.ValidateNames = true;
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string strFileName = ofd.FileName;
                //其他代码
            }*/
            if (fBD.ShowDialog() == DialogResult.OK)
            {
                txt_show.Text = fBD.SelectedPath;
            }
          
        }

        private void txt_show_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
            chosenPath=txt_show.Text;
           // MessageBox.Show(path);
            if(chosenPath!="")
            {
                  this.tree_directory.Nodes.Clear();
                  path = chosenPath.Split('\\');
                  //MessageBox.Show(path[path.Length-1]);
                  TreeNode rNode = new TreeNode();  //载入显示 选择显示
                  if (path.Length == 2)
                  {
                      rNode.Text = path[0] + path[1];
                  }
                  else {
                      rNode.Text = path[path.Length - 1];
                  }
                  rNode.Tag = path[path.Length - 1];                            //树节点数据
                                            //树节点标签内容
                  this.tree_directory.Nodes.Add(rNode);               //树中添加根目录
                  //rNode.Nodes.Add(rNode);
                                          //rootNode目录下加载节点
                  rNode.Nodes.Add("");
                  rNode.Expand();
            }
        }

        private void lvw_show_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

     

        private void lvw_show_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btm_ok_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("OK");
               
        }

        private delegate void setLogTextDelegate(FileSystemEventArgs e);
       
        private void fileSystemWatcher_EventHandle(object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法
        {
            
            if (this.lvw_show.InvokeRequired)  //判断是否跨线程      
            {           
                this.lvw_show.Invoke(new setLogTextDelegate(setLogText), new object[] { e });   //使用委托将方法封送到UI主线程处理     
            }
            
            
        }
        
        private void tim_Tick(object sender, EventArgs e)
        {
            
            lvw_show.Items.Clear();
           
            FileSystemWatcher fsw = new FileSystemWatcher();
            
            fsw.Path = chosenPath;
            fsw.EnableRaisingEvents = true;  //启动监控
            //fsw.IncludeSubdirectories = true;
            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size;   //设置文件的文件名、文件写入及文件的大小改动会触发Changed事件 
            fsw.Created += new FileSystemEventHandler(this.fileSystemWatcher_EventHandle);  //绑定事件触发后处理数据的方法。 
            fsw.Deleted += this.fileSystemWatcher_EventHandle; 
            fsw.Changed += this.fileSystemWatcher_EventHandle;
            
            
            
           // MessageBox.Show(f.Path);
           

        }
        private void setLogText(FileSystemEventArgs e)  //更新UI界面
        {
            // FileInfo file = new FileInfo(e.FullPath);
            p = e.FullPath;

            FileInfo file = new FileInfo(p);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = e.Name;   //受影响的文件名       
            lvi.SubItems.Add(e.ChangeType.ToString());   //受影响文件的变动类型(可能为Created、Changed、Deleted）       
            lvi.SubItems.Add("" + file.LastWriteTime);                     //受影响的文件修改时间
            lvi.SubItems.Add(file.Extension);
            lvw_show.Items.Add(lvi);
           
            
        }

        private void fSW_Changed(object sender, FileSystemEventArgs e)
        {
           
        }
    }

}

