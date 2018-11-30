using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonTaxCalculate
{
    public partial class form_Person_Tax_Calculate : Form
    {
        int m_intIndex = 0;
        double m_doubleTotalIncmoe = 0, m_doubleParableTax, m_doubleAfterTax;

        public form_Person_Tax_Calculate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lab_Income_Type_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cmb_Income_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_intIndex = cmb_Income_Type.SelectedIndex;
        }

        private void text_Income_Total_TextChanged(object sender, EventArgs e)
        {
            string str = text_Income_Total.Text; 
            if (str.StartsWith("-"))
            {
                m_doubleTotalIncmoe = 0.0;
            }
            else m_doubleTotalIncmoe = Convert.ToDouble(str);
        }
        
        private double salary_Tax(double incomeTotal)
        {
            return 0.2 * incomeTotal;
        }

        private double reward_Tax(double incomeTotal)
        {
            return 0.05 * incomeTotal;
        }

        private double property_Tax(double incomeTotal)
        {
            return 0.1 * incomeTotal;
        }

        private void calculate_Tax()
        {
            switch (m_intIndex)
            {
                case 0:
                    m_doubleParableTax = salary_Tax(m_doubleTotalIncmoe);
                    break;
                case 1:
                    m_doubleParableTax = reward_Tax(m_doubleTotalIncmoe);
                    break;
                case 2:
                    m_doubleParableTax = property_Tax(m_doubleTotalIncmoe);
                    break;
            }
            m_doubleAfterTax = m_doubleTotalIncmoe - m_doubleParableTax;
            string str1 = Convert.ToString(m_doubleParableTax);
            string str2 = Convert.ToString(m_doubleAfterTax);
            this.text_Parable_Tax.Text = str1;
            this.text_After_Tax.Text = str2;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            calculate_Tax();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            
            m_doubleTotalIncmoe = m_doubleParableTax = m_doubleAfterTax = 0.0;
            this.text_Parable_Tax.Text = "0";
            this.text_After_Tax.Text = "0";
            this.text_Income_Total.Text = "0";
        }

        private void text_After_Tax_TextChanged(object sender, EventArgs e)
        {

        }

        private void tim_Tick(object sender, EventArgs e)
        {
            /**
             * OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
            }
            ***/
            this.tim_Open_File.Enabled = false;
            OpenFileDialog dailog = new OpenFileDialog();
            dailog.Multiselect = true;
            dailog.Title = "请选择文件夹";
            dailog.Filter = "所有文件（*.*）|*.*";
            if(dailog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dailog.FileName;
            }
        }
    }
}



/*

 * 配置文件
 * 
 
 
 */