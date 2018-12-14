using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_income_without_tax_calculator
{
    public partial class Personal_income_without_tax_calculator : Form
    {
        int m_int_kind;
        double m_double_income_total;
        double m_double_tax;
        int[][] limit = new int[5][] { new int[] { 0, 0, 0, 0, 0, 0, 0 },
                                       new int[] { 36000, 144000, 300000, 420000, 660000, 960000, 100000000 }, 
                                       new int[] { 0, 0, 30000, 90000, 300000, 500000, 100000000 }, 
                                       new int[] { 0, 0, 15000, 30000, 60000, 100000, 100000000 },
                                       new int[] { 0, 0, 0, 0, 20000, 50000, 100000000 } };

        double[][] percent = new double[5][] { new double[] { 0, 0, 0, 0, 0, 0, 0 },
                                               new double[] { 0.03, 0.1, 0.2, 0.25, 0.3, 0.35, 0.45 }, 
                                               new double[] { 0, 0, 0.05, 0.1, 0.2, 0.3, 0.35 }, 
                                               new double[] { 0, 0, 0.05, 0.1, 0.2, 0.3, 0.35 },
                                               new double[] { 0, 0, 0, 0, 0.2*0.8, 0.3*0.8, 0.4*0.8 } };

        public Personal_income_without_tax_calculator()
        {
            InitializeComponent();
        }

        private void cmb_type_TextChanged(object sender, EventArgs e)
        {
            m_int_kind = cmb_income_kind.SelectedIndex;
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            if (m_int_kind == 0 || txt_income_total.Text == "")
            {
                MessageBox.Show("Something is null!");
                reset();
            }
                
            else
            {
                calculator();
            }
        }

        private void calculator()
        {

            int len = 7;
            m_double_income_total = Convert.ToDouble(txt_income_total.Text);
            m_double_tax = 0;

            if (m_double_income_total < 0)
            {
                MessageBox.Show("income is neg!");

                reset();
            }
            else
            {
                for (int i = 0; i < len; i++)
                {
                    if (m_double_income_total <= limit[m_int_kind][i])
                    {
                        m_double_tax = percent[m_int_kind][i] * m_double_income_total;
                        break;
                    }
                }

                show();
            }
        }

        private void show()
        {
            txt_tax.Text = Convert.ToString(m_double_tax);
            txt_real_income.Text = Convert.ToString(m_double_income_total - m_double_tax);
        }

        private void reset()
        {
            txt_tax.Text = "";
            txt_real_income.Text = "";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            m_int_kind = 0;
            cmb_income_kind.Text = "";
            txt_income_total.Text = "";
            reset();
        }

        private void timer_limit_10_Tick(object sender, EventArgs e)
        {
            timer_limit_10.Enabled = false;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

          
        }


    }
}
