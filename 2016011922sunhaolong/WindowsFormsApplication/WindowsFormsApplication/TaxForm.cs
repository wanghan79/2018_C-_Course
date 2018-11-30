using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class personalTaxCalculater : Form
    {

            public int intType;
            public double doubleTax;
            public double doubleTotle;
            public int[][] gross = new int[4][] {
                new int[] { 960000, 660000, 420000, 300000, 144000, 36000, 0 },
                new int[] { 500000, 300000, 90000, 30000, 0 },
                new int[] { 100000, 60000, 30000, 15000, 0 },
                new int[] { 50000, 20000, 0 }
            };
            public double[][] theTax = new double[4][] {
                new double[] { 0.45, 0.35, 0.3, 0.25, 0.2, 0.1, 0.03 },
                new double[] { 0.35, 0.3, 0.2, 0.1, 0.05 },
                new double[] { 0.35, 0.3, 0.2, 0.1, 0.05 },
                new double[] { 0.32, 0.24, 0.16}
            };                   

        public personalTaxCalculater()
        {
            InitializeComponent();
            timer_alert.Start();
        }
        private void personalTaxCalculater_Load(object sender, EventArgs e)
        {
            com_chooseType.SelectedIndex = 0;
        }
        private void header_Click(object sender, EventArgs e)
        {

        }    
        private void btn_calculater_Click(object sender, EventArgs e)
        {
            doubleTotle = Convert.ToDouble(textBox_gross.Text);
            intType = com_chooseType.SelectedIndex;
            int i;
            for (i = 0; i < 7; i++)
            {
                if (doubleTotle >= gross[intType][i])
                {
                    doubleTax = doubleTotle * theTax[intType][i];
                    break;
                }
            }
            textBox_tax.Text = Convert.ToString(doubleTax);
            textBox_withoutTax.Text = Convert.ToString(doubleTotle - doubleTax);
        }

        private void lab_taxYuan_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox_tax.Text = "";
            textBox_withoutTax.Text = "";
            textBox_gross.Text = "";
        }

        private void com_chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personalTaxCalculater_Load()
        {

        }

        private void timer_alert_Tick(object sender, EventArgs e)
        {
            
            int flag = 0;
            if (flag == 0)
            {
                MessageBox.Show("30秒");
                flag = 1;
                timer_alert.Stop();
            }
        }
    }
}
