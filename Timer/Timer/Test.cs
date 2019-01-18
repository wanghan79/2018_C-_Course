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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("3秒到了");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer_check.Start();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            timer_check.Stop();
        }
    }
}
