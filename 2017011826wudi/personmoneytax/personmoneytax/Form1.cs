using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personmoneytax
{
    public partial class Form_Taxcalculator : Form
    {
        public Form_Taxcalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            double income;
            double stax;
            double amoney;
            string type;
            double trate = 0.00;
            income = double.Parse(TextBox_Totalmoney.Text);
            type = ComboBox_Taxtype.Text;
            if(type=="商业税")
            {
                trate = 0.03;
                stax = trate * income;
                amoney = income - stax;
                TextBox_Aftertaxmoney.Text = amoney.ToString();
                TextBox_Taxmoney.Text = stax.ToString();
            }
            else if (type == "个人所得税")
            {
                trate = 0.04;
                stax = trate * income;
                amoney = income - stax;
                TextBox_Aftertaxmoney.Text = amoney.ToString();
                TextBox_Taxmoney.Text = stax.ToString();
            }
            if (type == "增值税")
            {
                trate = 0.05;
                stax = trate * income;
                amoney = income - stax;
                TextBox_Aftertaxmoney.Text = amoney.ToString();
                TextBox_Taxmoney.Text = stax.ToString();
            }
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            TextBox_Totalmoney.Text = "";
            TextBox_Aftertaxmoney.Text = "";
            TextBox_Taxmoney.Text = "";
        }
    }
}
