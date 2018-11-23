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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double tax, aftertax;
        private void button_add_MouseClick(object sender, MouseEventArgs e)
        {  
            int line = comboBox_type.SelectedIndex;
            double income = Convert.ToDouble(textBox_income.Text);
            if (line == 0)
            {
               if(income<=3000)
               {
                   tax = income * 0.03;
                   
               }
               else if(income>3000&&income<=12000)
               {
                   tax = 210 + (income - 3000) * 0.1;

               }
               else if (income > 12000 && income <=25000)
               {
                   tax = 1410 + (income - 12000) * 0.2;

               }
               else if (income > 25000 && income <= 35000)
               {
                   tax = 2660 + (income - 25000) * 0.25;

               }
               else if (income > 35000 && income <= 55000)
               {
                   tax = 4410 + (income - 35000) * 0.3;

               }
               else if (income > 55000 && income <=80000)
               {
                   tax = 7160+ (income - 55000) * 0.35;

               }
               else if (income >80000)
               {
                   tax = 15160 + (income - 80000) * 0.45;

               }
            }
            else if(line==1)
            {
                if(income<=30000)
                {
                    tax=income*0.05;
                }
                else if(income>30000&&income<=90000)
                {
                    tax=1500+(income-30000)*0.1;
                }
                 else if(income>90000&&income<=300000)
                {
                    tax=7500+(income-90000)*0.2;
                }
                else if(income>300000&&income<=500000)
                {
                    tax=49500+(income-300000)*0.3;
                }
                else if(income>500000)
                {
                    tax=109500+(income-500000)*0.35;
                }
            }
            else
            {
                if(income<=15000)
                {
                    tax=income*0.05;
                }
                else if(income>15000&&income<=30000)
                {
                    tax=750+(income-15000)*0.1;
                }
                else if(income>30000&&income<=60000)
                {
                    tax=3750+(income-15000)*0.2;
                }
                else if(income>60000&&income<=100000)
                {
                    tax=9750+(income-60000)*0.3;
                }
                else if(income>100000)
                {
                    tax=14750+(income-100000)*0.35;
                }
            }
            aftertax = income - tax;
        }

        private void button_count_MouseClick(object sender, MouseEventArgs e)
        {
           
            textBox_tax.Text = tax.ToString();
            textBox_aftertax.Text = aftertax.ToString();
        }

        private void button_reset_MouseClick(object sender, MouseEventArgs e)
        {
            double income = Convert.ToDouble(textBox_income.Text);
            tax = 0;
            aftertax = 0;
            income = 0;
            textBox_income.Text = income.ToString();
            textBox_tax.Text = tax.ToString();
            textBox_aftertax.Text = aftertax.ToString();
        }

        private void textBox_income_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
