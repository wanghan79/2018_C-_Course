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
    public partial class 个人所得税计算器 : Form
    {
        public 个人所得税计算器()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        double deal1(double x)
        {
            if (x <= 5000) return 0.0;
            if (x <= 10000) return x * 0.03;
            if (x <= 20000) return x * 0.08;
            if (x >= 30000) return x * 0.12;
            if (x <= 50000) return x * 0.2;
            return x * 0.35;
        }
        double deal2(double x)
        {
            if (x <= 5000) return x;
            if (x <= 10000) return x - x * 0.03;
            if (x <= 20000) return x - x * 0.08;
            if (x >= 30000) return x - x * 0.12;
            if (x <= 50000) return x - x * 0.2;
            return x - x * 0.35;
        }
        private void button3_Click(object sender, EventArgs e)
        {
        //    this.bt_calculate.Click += new System.EventHandler(textBox3_TextChanged);
        //    this.bt_calculate.Click += new System.EventHandler(tb_After_tax_input_TextChanged);
            string str = tb_income_all.Text;
            double A;
            double.TryParse(str, out A);
            A = deal1(A);
            string S = Convert.ToString(A);
            this.tb_Tax_payable.Text = S;
            str = tb_income_all.Text;
            double.TryParse(str, out A);
            A = deal2(A);
            S = Convert.ToString(A);
            this.tb_After_tax_input.Text = S;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public object[] A { get; set; }

        private void tb_After_tax_input_TextChanged(object sender, EventArgs e)
        {
        }
        private void bt_reset_Click(object sender, EventArgs e)
        {
            //this.bt_reset.Click += new System.EventHandler(Function);
            tb_After_tax_input.Text = "0";
            tb_Tax_payable.Text = "0";
        }
    }
}
