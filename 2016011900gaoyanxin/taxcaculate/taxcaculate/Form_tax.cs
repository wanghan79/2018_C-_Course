using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxcaculate
{
    public partial class Form_tax : Form
    {
        public double income;
        public string input ;
        //public double income= Convert.ToDouble(input);
        public int typeindex;
        public double income_after;
        public double tax_output;
        public int[][] domain = new int[2][]
        {
            new int[]{36000,144000,300000,420000,660000,960000,10000000},
            new int[]{30000,90000,300000,500000,1000000}
        };
        public double[][] tax_rate = new double[2][]
            {
                new double[]{0.03,0.1,0.2,0.25,0.3,0.35,0.45},
                new double[]{0.005,0.1,0.2,0.3,0.35}
            }; 
     
        public Form_tax()
        {
            InitializeComponent();
        }

        public void tax(ref double tax_output,ref double income_after)
        {
            int i,j;
            tax_output = 0;
            income_after = 0;
            income = Convert.ToDouble(txt_total.Text);
           // MessageBox.Show(Convert.ToString( tax_rate[typeindex].Length));
            for (i = tax_rate[typeindex].Length-1;i>=0 ; i--)
                
                if (income - domain[typeindex][i] > 0)
                {
                    tax_output = (income - domain[typeindex][i]) * tax_rate[typeindex][i+1];
                    break;
                }
                else
                {
                    if (i == 0)
                    {
                        tax_output = income * tax_rate[typeindex][0];
                        break;
                    }
                    else 
                    { continue; }

                }

            if (i > 0)
            {
                for (j = i; j >= 0; j--)
                {
                    MessageBox.Show(Convert.ToString(j), Convert.ToString(tax_output));
                    tax_output = tax_output + (domain[typeindex][i] - domain[typeindex][i - 1]) * tax_rate[typeindex][i];

                }
            }

            income_after = income - tax_output;
           
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            tax(ref tax_output, ref income_after);

            //income_after = Convert.ToInt32(txt_total.Text);
            txt_afertax.Text = Convert.ToString(income_after);
            txt_tax.Text = Convert.ToString(tax_output);  
        }

        private void btn_reset_click(object sender, EventArgs e)
        {
            txt_total.Text = Convert.ToString(null);
            txt_tax.Text = Convert.ToString(null);
            txt_afertax.Text = Convert.ToString(null);
        }

        private void com_click(object sender, EventArgs e)
        {
            
        }

        private void com_index_change(object sender, EventArgs e)
        {
            typeindex = com_type.Items.IndexOf(com_type.Text);
            //MessageBox.Show(com_type.Items[i].ToString());
           /* switch(typeindex)
            {
                case 0:
                    MessageBox.Show(com_type.Text);
                    break;
                case 1:
                    MessageBox.Show(com_type.Text);
                    break;
           
            }*/
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            //string input;
           // input = Console.ReadLine();
            //MessageBox.Show(txt_total.Text);
            /*income = Convert.ToDouble(txt_total.Text);
            //MessageBox.Show(Convert.ToString(income));
            */
               
        }

    }
}
