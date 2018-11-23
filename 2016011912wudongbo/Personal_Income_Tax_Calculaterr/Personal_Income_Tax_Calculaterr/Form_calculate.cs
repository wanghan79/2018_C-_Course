using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Income_Tax_Calculaterr
{
    public partial class Form_calculate : Form
    {
        public Form_calculate()
        {
            InitializeComponent();
            cmb_type.SelectedIndex = 0;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double amount;
            if (txt_amount.Text.Length == 0) amount = 0.0;
            else amount = System.Convert.ToDouble(txt_amount.Text);
            Calculator(amount);
        }
        private void Calculator(double amount)
        {
            double real_tax = 0.0;
            double real_income = 0.0;
            int line = cmb_type.SelectedIndex;
            int pos = 0;

            int[] num = new int[4] { 7, 5, 5, 3 };
            double[][] tax = new double[4][]{
            new double [] {0.0,36000.0,144000.0,300000.0,420000.0,660000.0,960000.0},
            new double [] {0.0,30000.0,90000.0,300000.0,500000.0},
            new double [] {0.0,15000.0,30000.0,60000.0,100000.0},
            new double [] {0.0,20000.0,500000.0}
            };
            double[][] tax_rate = new double[4][]{
            new double [] {0.03,0.1,0.2,0.25,0.3,0.35,0.45},
            new double [] {0.05,0.1,0.2,0.3,0.35},
            new double [] {0.05,0.1,0.2,0.3,0.35},
            new double [] {0.2,0.3,0.4}
            };
            for (pos = 0; pos < num[line] && amount > tax[line][pos];)
            {
                ++pos;
            }
            
            for (int i = 1; i < pos;++i)
            {
                real_tax += (tax[line][i] - tax[line][i - 1]) * tax_rate[line][i - 1];
            }
            if(pos > 1)
            real_tax += (amount - tax[line][pos - 1]) * tax_rate[line][pos - 1];
            real_income = amount - real_tax;
            txt_tax.Text = real_tax.ToString();
            txt_income.Text = real_income.ToString();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tax.Text = "0";
            txt_income.Text = "0";
            txt_amount.Text = "0";
        }

    }
}
