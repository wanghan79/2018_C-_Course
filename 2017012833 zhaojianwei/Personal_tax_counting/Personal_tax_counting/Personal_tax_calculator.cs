using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_tax_counting
{
   
    public partial class Form_calculcator : Form
    {
        static int N = 4;
    
        public Form_calculcator()
        {
            InitializeComponent();
       
        }
        private double Calculate(int type,double income)
        {
            double tax;
            double[][] a = new double[N][];
            double[][] b = new double[N][];
            a[0] = new double[7] { 0.03, 0.1, 0.2, 0.25, 0.3, 0.35, 0.45 };
            a[1] = new double[5] { 0.05, 0.1, 0.2, 0.3, 0.35 };
            a[2] = new double[5] { 0.05, 0.1, 0.2, 0.3, 0.35 };
            a[3] = new double[3] { 0.2, 0.3, 0.4 };
            b[0] = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
            b[1] = new double[5] { 0, 0, 0, 0, 0 };
            b[2] = new double[5] { 0, 750, 3750, 9750, 14750 };
            b[3] = new double[3] { 0, 2000, 7000 };
            int[][] income1 = new int[N][];
            income1[0] = new int[6] { 36000, 144000, 300000, 420000, 660000, 960000 };
            income1[1] = new int[4] { 30000, 90000, 300000, 500000 };
            income1[2] = new int[4] { 15000, 30000, 60000, 100000 };
            income1[3] = new int[2] { 16000, 37000 };
            int k = income1[type].Length ;
            int i;
            for (i = 0;i < income1[type].Length;i++)
            {
                if (income <= income1[type][i])
                {
                    k = i;
                    break;
                }
            }
            tax = income * a[type][k] - b[type][k]; 
            return tax;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int taxtype;
        private void cbx_income_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            taxtype = cbx_income_type.SelectedIndex;
        }

        private void btn_calculate_MouseClick(object sender, MouseEventArgs e)
        {
            double income = Convert.ToDouble(tbx_all_income.Text);
            double tax = Calculate(taxtype, income);
            double after_tax = income - tax;
            tbx_should_tax.Text = Convert.ToString(tax);
            tbx_after_tax_income.Text = Convert.ToString(after_tax);
        }

        private void btn_reset_MouseClick(object sender, MouseEventArgs e)
        {
            cbx_income_type.SelectedIndex = 0;
            cbx_income_type.Text = "请选择";
            tbx_after_tax_income.Text = "";
            tbx_all_income.Text = "";
            tbx_should_tax.Text = "";
        }

        private void Form_calculcator_Load(object sender, EventArgs e)
        {

        }
    }
}
