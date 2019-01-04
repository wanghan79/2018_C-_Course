using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork_FileRead
{
    public partial class setting : Form
    {
        int time_index;
        public setting()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            FinalWork_FileRead.pForm1.time_index = this.time_index;
            FinalWork_FileRead.pForm1.Show();
            this.Close();
        }

        private void comboBox_time_TextChanged(object sender, EventArgs e)
        {
            time_index = comboBox_time.SelectedIndex;
        }
    }
}
