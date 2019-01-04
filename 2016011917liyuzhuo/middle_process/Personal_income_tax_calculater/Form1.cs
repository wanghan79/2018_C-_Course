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
namespace Personal_income_tax_calculater
{
    public partial class Form_PersonalIncomeTaxCalculator : Form
    {
        double income;
        public Form_PersonalIncomeTaxCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_PersonalIncomeTaxCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            txt_tax_TextChanged(null, null);
            txt_income_TextChanged(null,null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {     

        }
        

        public double txtConvertToDouble(string txt)
        {
            double result = 0;
            bool f = double.TryParse(txt, out result);
            return result;
        }
        

        private void txt_income_TextChanged(object sender, EventArgs e)
        {
            income = txtConvertToDouble(txt_amount.Text);
            double print=5000.0;
                print = Incomeoutput(income);
            txt_income.Text = print.ToString();
                
        }
        public double Type_Comprehensive(double income)
        {
            double p = 0.0;
            if (income <= 5000) p = 0.0;
            else if (income <= 36000.0) p = (income - 5000) * 0.03;
            else if (income > 36000 & income <= 144000) p = (income - 36000) * 0.1 + 31000 * 0.03;
            else if (income > 144000 & income <= 300000.0) p = (income - 144000) * 0.2 + (144000 - 36000) * 0.1 + 31000 * 0.03;
            else if ((income > 300000) & (income <= 420000)) p = (income - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 31000 * 0.03;
            else if ((income > 420000) & (income <= 660000)) p = (income - 420000) * 0.3 + (420000 - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 31000 * 0.03;
            else if ((income > 660000) & (income <= 960000)) p = (income - 660000) * 0.35 + (660000 - 420000) * 0.3 + (420000 - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 31000 * 0.03;
            else p = (income - 960000) * 0.45 + (960000 - 660000) * 0.35 + (660000 - 420000) * 0.3 + (420000 - 300000) * 0.25 + (300000 - 144000) * 0.2 + (144000 - 36000) * 0.1 + 31000 * 0.03;
            return p;
        }
        public double Type_Operating(double income)
        {
            double p = 0.0;
            if (income <= 5000) p = 0.0;
            else if (income <= 30000) p = (income - 5000) * 0.05;
            else if (income <= 90000) p = (income - 30000) * 0.1+25000 * 0.05;
            else if (income <= 300000) p = (income - 90000) * 0.2 +(9000-30000)*0.1 +25000 * 0.05;
            else if (income <= 500000) p = (income - 300000) * 0.25+(300000-90000)*0.2+60000*0.1 + 25000 * 0.05;
            else p = (income - 500000) * 0.3+200000*0.25+210000*0.2+60000*0.1 + 25000 * 0.05;
            return p;
        }
        public double Type_Others(double income)
        {
            double p = 0.0;
            p = income * 0.2;
            return p;
        }
        public double Taxoutput(double income)
        {
            double p=0.0;
            if (cmb_type.Text.ToString() == "综合所得") p = Type_Comprehensive(income);
            else if (cmb_type.Text.ToString() == "经营所得") p = Type_Operating(income);
            else p = Type_Others(income);
            return p;
        }
        public double Incomeoutput(double income)
        {
            double p = income;
            p = income - Taxoutput(income);
            return p;
        }
        private void txt_tax_TextChanged(object sender, EventArgs e)
        {
            income = txtConvertToDouble(txt_amount.Text);
            double print=0.0;
            print = Taxoutput(income);
            txt_tax.Text=print.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            String nullstr=" ";
            txt_amount.Text = nullstr.ToString();
            txt_tax.Text = nullstr.ToString();
            txt_income.Text = nullstr.ToString();
                
        }
        int temp = 30;
        int i = 0;
        private void timer_printtxt_Tick(object sender, EventArgs e)
        {
          
            i++;
            if(i==temp) 
            { 
                OpenFileDialog f = new OpenFileDialog();
                f.ShowDialog();

            }
        }

        private void btn_startTimer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
