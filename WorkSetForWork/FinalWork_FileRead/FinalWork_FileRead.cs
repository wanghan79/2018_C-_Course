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

namespace FinalWork_FileRead
{
    public partial class FinalWork_FileRead : Form
    {
        string path;

        public FinalWork_FileRead()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            timer_check.Enabled = false;
            //进行检查的函数
            timer_check.Enabled = true;
        }

        public void FindFile(string dirPath) //参数dirPath为指定的目录
        {
            int i = 0;
            //在指定目录及子目录下查找文件,在listBox1中列出子目录及文件
            DirectoryInfo Dir=new DirectoryInfo(dirPath);
            try
            {
                foreach(DirectoryInfo d in Dir.GetDirectories())//查找子目录 
                {
                    FindFile(Dir + "\\" + d.ToString() + "\\");
                    listbox_record.Items.Add(Dir + d.ToString() + ""); //listBox1中填加目录名
                }
                foreach(FileInfo f in Dir.GetFiles("*.---")) //查找文件
                {
                    listbox_record.Items.Add(Dir + f.ToString()+i++); //listBox1中填加文件名
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            } 
        }

        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                path = folder.SelectedPath.ToString();
            }
            txt_folder.Text = path;
            FindFile(path);
            
        }
    }
}
