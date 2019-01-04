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
using System.Configuration;
using System.Diagnostics;
//重命名只能获取源文件已删除，修改时间，创建时间不变
namespace FinalWork_FileRead
{
    public partial class FinalWork_FileRead : Form
    {
        public int time_index;
        string path;
        int num_files;
        int index;
        public static FinalWork_FileRead pForm1 = null;
        //Dictionary<string, string> files_dict = new Dictionary<string, string>();

        public FinalWork_FileRead()
        {
            pForm1 = this;
            InitializeComponent();
            txt_folder.Text = "(default:C:\\)";
            //path = ConfigurationManager.AppSettings["path"];
            timer_check.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["0"]);
            timer_check.Enabled = false;
        }
        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            timer_check.Enabled = true;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                listbox_record.Items.Clear();
                path = folder.SelectedPath.ToString();
                txt_folder.Text = path;
                treeView_folder.Nodes.Clear();
                treeView_folder.Nodes.Add(new TreeNode(path));
                File_Load(path);
            }           
        }
        private void btn_traverse_Click(object sender, EventArgs e)
        {
            timer_check.Enabled = true;
            listbox_record.Items.Clear();
            treeView_folder.Nodes.Clear();
            path = ConfigurationManager.AppSettings["path"];
            txt_folder.Text = path;
            treeView_folder.Nodes.Add(new TreeNode(path));
            File_Load(path);
        }
        private void File_Load(string path)
        {
            num_files = 0;
            TreeNode root = new TreeNode();
            root.Text = path.ToString();
            root.ExpandAll();
            GetFiles(path, root);
            treeView_folder.Nodes.Add(root);
        }
        private void GetFiles(string filePath, TreeNode node)
        {
            DirectoryInfo folder = new DirectoryInfo(filePath);
            node.Text = folder.Name;
            node.Tag = folder.FullName;
            node.ExpandAll();
            try
            {
                FileInfo[] chldFiles = folder.GetFiles("*.*");
                foreach (FileInfo chlFile in chldFiles)
                {
                    TreeNode chldNode = new TreeNode();
                    chldNode.Text = chlFile.Name;
                    chldNode.Tag = chlFile.FullName;
                    num_files++;
                    node.Nodes.Add(chldNode);
                }
                DirectoryInfo[] chldFolders = folder.GetDirectories();
                foreach (DirectoryInfo chldFolder in chldFolders)
                {
                    TreeNode chldNode = new TreeNode();
                    chldNode.Text = folder.Name;
                    chldNode.Tag = folder.FullName;
                    node.Nodes.Add(chldNode);
                    GetFiles(chldFolder.FullName, chldNode);
                }
            }
            catch(Exception eGetFiles)
            {
                MessageBox.Show("eGetFiles   "+eGetFiles.Message);
            }
            
        }
        private void timer_check_Tick(object sender, EventArgs e)
        {
            timer_check.Enabled = false;
            timer_check.Interval = Convert.ToInt32(ConfigurationManager.AppSettings[time_index]);
            try
            {
                check_files();
            }
            catch(Exception eCheck)
            {
                MessageBox.Show("eCheck   "+eCheck.Data);
            }
            timer_check.Enabled = true;
        }
        private void check_files()
        {
            //MessageBox.Show(num_files.ToString());
            TreeNode root = treeView_folder.Nodes[1];
            DateTime currentTime=new DateTime(); 
            currentTime=System.DateTime.Now;
            string[,] r2 = new string[num_files + 10, 3];
            index = 0;
            record_files(root, ref r2, path,1);
            
            treeView_folder.Nodes.Clear();
            treeView_folder.Nodes.Add(new TreeNode(path));
            File_Load(path);
            
            root = treeView_folder.Nodes[1];
            record_files(root, ref r2, path,2);
            //MessageBox.Show("Done!");
            
            for (int i = 0; i < r2.Length/3; i++)
            {
                string str;
                if (r2[i,0] != "" && r2[i,1] == "" && r2[i,2] == "")
                {
                    str = r2[i, 0] + " was deleted "; 
                    listbox_record.Items.Add(str);   
                }
                else if (DateTime.Compare(Convert.ToDateTime(r2[i, 1]), currentTime.AddMilliseconds(-timer_check.Interval)) >= 0)
                //if (r2[i, 1].CompareTo(currentTime.AddMilliseconds(-timer_check.Interval).ToString()) == -1)
                {
                    str = r2[i, 0] + " : create at " + r2[i, 1];
                    listbox_record.Items.Add(str);
                }
                else if (DateTime.Compare(Convert.ToDateTime(r2[i, 2]), currentTime.AddMilliseconds(-timer_check.Interval)) > 0)
                //if (r2[i, 2].CompareTo(currentTime.AddMilliseconds(-timer_check.Interval).ToString()) == -1) //update later than build treeView
                {
                    str = r2[i, 0] + " : update at " + r2[i, 2];
                    listbox_record.Items.Add(str);                     
                }
            }
            
        }
        private void record_files(TreeNode node, ref string[,] arr,string file_path,int x)
        {
            path = path.TrimEnd('\\');
            file_path += "\\";
            //listbox_record.Items.Add(file_path);
            foreach (TreeNode n in node.Nodes)
            {
                //listbox_record.Items.Add(index);
                if (IsLastNode(n))
                {
                    FileInfo info = new FileInfo(file_path + n.Text);
                    if (x == 1 && !info.Exists)
                    {
                        arr[index, 0] = file_path + n.Text;
                        arr[index, 1] = "";
                        arr[index, 2] = "";
                        index++;
                    }
                    if(x == 2 && info.Exists)
                    {
                        arr[index, 0] = info.Name;
                        arr[index, 1] = info.CreationTime.ToString();
                        arr[index, 2] = info.LastWriteTime.ToString();
                        index++;
                    } 
                    
                }
                else
                {
                    if (Directory.Exists(file_path + n.Text))
                        record_files(n, ref arr, file_path + n.Text, x);
                }
            }
        }
        private void btn_set_Click(object sender, EventArgs e)
        {
            setting f2 = new setting();
            f2.Show();
        }
        static bool IsLastNode(TreeNode treeNode)
        {
            if (treeNode.Nodes.Count > 0)
                return false;
            else return true;
        }
        
    }
}
