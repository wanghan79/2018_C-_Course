using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace person_tax_cal
{

    public partial class person_tax_calculate : Form
    {
        int kind = 0;
        double[][] tax_rate = new double[4][]{new double[]{0.03,0.1,0.2,0.25,0.3,0.35,0.45},
                                              new double[]{0,0,0.05,0.1,0.2,0.3,0.35},
                                              new double[]{0,0,0.05,0.1,0.2,0.3,0.35},
                                              new double[]{0,0,0,0,0.2*0.8,0.3*0.8,0.4*0.8}};
        int[][] limit = new int[4][]{new int[] {36000,144000,300000,420000,660000,960000,100000000},
                                     new int[] {0,0,30000,90000,300000,500000,100000000},
                                     new int[] {0,0,1500,30000,60000,100000,100000000},
                                     new int[] {0,0,0,0,20000,50000,100000000}};
        double income;
        double tax_demand=1000;
        double incount_after_tax=500;
        public person_tax_calculate()
        {
            InitializeComponent();
        }
        private void txt_incount_all_TextChanged(object sender, EventArgs e)
        {
            income = Convert.ToDouble(txt_incount_all.Text);

        }

        private void cmb_incount_type_TextChanged(object sender, EventArgs e)
        {
            //收入类型
            kind = cmb_incount_type.SelectedIndex;

        }

        private void but_calculate_Click(object sender, EventArgs e)
        {
            calculate();
            show();
        }
        private void calculate()
        {
            int index = 0;
            for (int i = 0; i < 7;i++)
            {
                if (income > limit[kind][i] && income < limit[kind][i + 1])
                    {
                        index = i;
                    }
            }
            tax_demand = income * tax_rate[kind][index];
            incount_after_tax = income - tax_demand;
        }
        private void show()
        {
            txt_tax_demand.Text = Convert.ToString(tax_demand);
            txt_incount_after_tax.Text = Convert.ToString(incount_after_tax);
        }    
    }
}
