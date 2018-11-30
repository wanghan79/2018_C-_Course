using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_console
{
    public partial class time_Form : Form
    {
        int count = 3;
        public time_Form()
        {
            InitializeComponent();
            time_tbx.Text = count.ToString();
        }
        int a = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        /*System.Timers.Timer t = new System.Timers.Timer(3000);
        t.Elpsed += new System.Timers.ElapsedEventHandler(theout);
        true.AutoReset = true;
        true.Enabled = true;

        public void theout (object source, System.Timers.ElapsedEventArgs e)
        {
            MessageBox.Show("open failed");
        }*/


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
                event1_timer.Enabled = true;
        }

        private void event1_timer_Tick(object sender, EventArgs e)
        {
                
                time_tbx.Text = count.ToString();
                MessageBox.Show("open failed");
                event1_timer.Enabled = false;
                event1_timer.Stop();
        }

      
    }
}
