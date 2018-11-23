using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class TaxCalculator : Form
    {
        public TaxCalculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Income_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Count(object sender, EventArgs e)
        {
            //TextBox_Give_Tax.Text = TextBox_Income_Total.Text;
            //TextBox_Tax_Income.Text = TextBox_Income_Total.Text;
            if (TextBox_Income_Total.Text == "")
            {
                MessageBox.Show("请输入数字");
                return;
            }
            double ans = Convert.ToDouble(TextBox_Income_Total.Text);
            double ans_tax = 0;
            if (ans <= 36000)
            {
                ans_tax = ans * 0.03;
            }
            else if (ans > 36000 && ans <= 144000)
            {
                ans_tax = 36000 * 0.03 + (ans - 36000) * 0.1;
            }
            else if (ans > 14000 && ans <= 300000)
            {
                ans_tax = 36000 * 0.03 + (144000 - 36000) * 0.1 + (ans - 144000) * 0.2;
            }
            else if (ans > 300000 && ans <= 420000)
            {
                ans_tax = 36000 * 0.03 + (144000 - 36000) * 0.1 + (300000 - 144000) * 0.2 + (ans - 300000) * 0.25;
            }
            else if (ans > 420000 && ans <= 660000)
            {
                ans_tax = 36000 * 0.03 + (144000 - 36000) * 0.1 + (300000 - 144000) * 0.2 + (420000 - 300000) * 0.25 + (ans - 420000) * 0.3;
            }
            else if (ans > 660000 && ans <= 960000)
            {
                ans_tax = 36000 * 0.03 + (144000 - 36000) * 0.1 + (300000 - 144000) * 0.2 + (420000 - 300000) * 0.25 + (660000 - 420000) * 0.3 + (ans - 660000) * 0.35;
            }
            else if (ans > 960000)
            {
                ans_tax = 36000 * 0.03 + (144000 - 36000) * 0.1 + (300000 - 144000) * 0.2 + (420000 - 300000) * 0.25 + (660000 - 420000) * 0.3 + (960000 - 660000) * 0.35 + (ans - 960000) * 0.45;
            }
            TextBox_Give_Tax.Text = ans_tax.ToString();
            TextBox_Tax_Income.Text = (ans - ans_tax).ToString();
        }

        private void Replay(object sender, EventArgs e)
        {
            TextBox_Give_Tax.Text = "";
            TextBox_Tax_Income.Text = "";
            TextBox_Income_Total.Text = "";
        }
    };
}
