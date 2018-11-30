using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayTimerGame
{
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
            TimerGame.Interval = 3000; // 设置时间间隔为.3000ms，默认为100ms
            TimerGame.Start();  // 启动计时器, 默认不启动
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            TimerGame.Stop();
            MessageBox.Show("Hello World");
            Close(); // 最后关闭窗口
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
