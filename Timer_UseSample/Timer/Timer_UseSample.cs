using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer_UseSample : Form
    {

        public Timer_UseSample()
        {
            InitializeComponent();
        }

        int temp = 0;//指定的间隔秒数
        int pos = 0;//temp等0表示停止计时，等1表示开始计时
        int i=0;    //临时变量

        private void button1_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(textBox1.Text);  //获取间隔秒数
            i = 0;
            pos = 1;
            this.OutputBox.Items.Add("开始计时");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = 0;
            this.OutputBox.Items.Add("停止计时");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pos==1)
            {
                i++;
                if (i == temp)
                {
                    i = 0;
                    this.OutputBox.Items.Add("-------定时器归零------");
                    this.OutputBox.Items.Add("");
                }
                else
                    this.OutputBox.Items.Add("临时变量：" + i.ToString());
            }
        }

    }
}
