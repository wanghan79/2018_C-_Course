using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Come from wangweixi

namespace WindowsFormsApplication2
{
    public partial class JSQ : Form
    {
        public JSQ()
        {
            InitializeComponent();
        }

        private void click_reset(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            txt_afterTax.Text = "";
            txt_income.Text = "";
            txt_toPay.Text = "";
        }
        private double calculate(int type, double income)
        {
            double tax=0;
            int[] rate = { 0, 36000, 144000, 300000, 420000, 660000, 960000 };
            double[] percent = { 0.03, 0.10, 0.20, 0.25, 0.30, 0.35, 0.45 };

            for (int i = 0; i < 6;i++ )
            {
                if(income<=rate[i+1])
                {
                    tax += (income - rate[i]) * percent[i];
                    break;
                }
                if(income>=rate[i+1])
                {
                    tax += (rate[i + 1] - rate[i]) * percent[i];
                }
                if(i == 5)
                {
                    if(income > rate[6])
                    {
                        tax += (income - rate[6]) * percent[i];
                    }
                }
                
            }
            return tax;
        }

        private void click_calculate(object sender, EventArgs e)
        {
            if(txt_income.Text =="")
            {
                MessageBox.Show("请输入收入总额");
                reset();
                return;
            }
            double tax = 0;
            double income = double.Parse(txt_income.Text);
            tax = calculate(cmb_type.SelectedIndex, income);
            double afterTax = income - tax;
            txt_toPay.Text = tax.ToString();
            txt_afterTax.Text = afterTax.ToString();
        }
    }
}
