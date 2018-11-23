using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PersonalTaxCalculator : Form
    {
        public PersonalTaxCalculator()
        {
            InitializeComponent();
        }
        double IncomeSum,TaxRate,TaxPayable,AfterTaxIncome;

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IncomeSum = Convert.ToDouble(textBox1_IncomeSum.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public double TaxRate_Calculate(string IncomeType)
        {
            double TaxRate=0;
            if (IncomeType=="收入类型1" )
                TaxRate = 0.1;
            if (IncomeType == "收入类型2")
                TaxRate = 0.2;
            if (IncomeType == "收入类型3")
                TaxRate = 0.3;
            if (IncomeType == "收入类型4")
                TaxRate = 0.4;
            return TaxRate;
        }

        public double TaxPayable_Calculate(double IncomeSum,double TaxRate)
        {
            TaxPayable = IncomeSum * TaxRate;
            return TaxPayable;
        }
        public void Reset()
        {
            comboBox1_IncomeTypeSelect.Text = "收入类型选择";
            textBox1_IncomeSum.Text = Convert.ToString("0");
            textBox2_TaxPayable.Text = Convert.ToString("");
            textBox3_AfterTaxIncome.Text = Convert.ToString("");
        }
        private void comboBox1_IncomeTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaxRate = TaxRate_Calculate(comboBox1_IncomeTypeSelect.Text);
            //comboBox1_IncomeTypeSelect.Text="收入类型选择";
        }
        private void button1_Calculate_MouseClick(object sender, MouseEventArgs e)
        {
            TaxPayable = TaxPayable_Calculate(IncomeSum, TaxRate);
            AfterTaxIncome = IncomeSum - TaxPayable;
            textBox2_TaxPayable.Text = Convert.ToString(TaxPayable);
            textBox3_AfterTaxIncome.Text = Convert.ToString(AfterTaxIncome);
        }
        private void button2_Reset_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();
        }
    }
}
