using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_MouseClick(object sender, MouseEventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox_total.Text);
            if (comboBox_type.Text == null)
            {
                if (a < 36000)
                {
                    b = a * 0.03;
                }
                else if (a < 144000)
                {
                    b = (a-36000) * 0.1+36000*0.03;
                }
                else if (a < 300000)
                {
                    b = (a-144000) * 0.2+(144000-36000)*0.1+36000*0.03;
                }
                else if (a < 420000)
                {
                    b = (a - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 36000 * 0.03;
                }
                else if (a < 660000)
                {
                    b = (a - 420000) * 0.3 + (420000 - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 36000 * 0.03;
                }
                else if (a < 960000)
                {
                    b = (a - 660000) * 0.35 + (660000 - 420000) * 0.3 + (420000 - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 36000 * 0.03;
                }
                else
                {
                    b = (a - 960000) * 0.45 + (960000 - 660000) * 0.35 + (660000 - 420000) * 0.3 + (420000 - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 36000 * 0.03;
                }
                c = a - b;
                textBox_tax.Text = Convert.ToString(b);
                textBox_income.Text = Convert.ToString(c);
            }
            else if (comboBox_type.Text == "特许权使用费所得")
            {
                if (a < 30000)
                {
                    b = a * 0.05;
                }
                else if (a < 90000)
                {
                    b = (a-30000) * 0.1+30000*0.05;
                }
                else if (a < 300000)
                {
                    b = (a-90000) * 0.2+(90000-30000)*0.1+30000*0.05;
                }
                else if (a < 500000)
                {
                    b = (a - 300000) * 0.3 + (300000 - 90000) * 0.2 + (90000 - 30000) * 0.1 + 30000 * 0.05;
                }
                else
                {
                    b = (a - 500000) * 0.35 + (500000 - 300000) * 0.3 + (300000 - 90000) * 0.2 + (90000 - 30000) * 0.1 + 30000 * 0.05;
                }
                c = a - b;
                textBox_tax.Text = Convert.ToString(b);
                textBox_income.Text = Convert.ToString(c);
            }
            else if (comboBox_type.Text == "对企业事业单位的所得" || comboBox_type.Text == "个体工商户生产所得" || comboBox_type.Text == "财产租赁所得")
            {
                if (a < 15000)
                {
                    b = a * 0.05;
                }
                else if (a < 30000)
                {
                    b = (a-15000) * 0.1+15000*0.05;
                }
                else if (a < 60000)
                {
                    b = (a-30000) * 0.2+(30000-15000)*0.1+15000*0.05;
                }
                else if (a < 100000)
                {
                    b = (a - 60000) * 0.3 + (60000 - 30000) * 0.2 + (30000 - 15000) * 0.1 + 15000 * 0.05;
                }
                else
                {
                    b = (a - 100000) * 0.35 + (100000 - 60000) * 0.3 + (60000 - 30000) * 0.2 + (30000 - 15000) * 0.1 + 15000 * 0.05;
                }
                c = a - b;
                textBox_tax.Text = Convert.ToString(b);
                textBox_income.Text = Convert.ToString(c);
            }
            else if (comboBox_type.Text == "劳务报酬所得")
            {
                if (a < 16000)
                {
                    b = a * 0.2;
                }
                else if (a < 37000)
                {
                    b = (a-16000) * 0.3+16000*0.2;
                }
                else 
                {
                    b = (a - 37000) * 0.4 + (37000 - 16000) * 0.3 + 16000 * 0.2;
                }
                c = a - b;
                textBox_tax.Text = Convert.ToString(b);
                textBox_income.Text = Convert.ToString(c);
            }
            
            
        }

        private void button_reset_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_income.Text = null;
            textBox_tax.Text = null;
            textBox_total.Text = null;
        }
    }
}
