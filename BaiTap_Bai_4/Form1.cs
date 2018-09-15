using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num_N;
            if (txtN.Text == "")
                num_N = 0;
            else num_N = Convert.ToDouble(txtN.Text);
            double num_kq = 0;
            for (int i = 0; i < num_N + 1; i++) 
            {
                num_kq += (1 / (2 * (double)i + 1));
            }
            txtKQ.Text = num_kq.ToString();
        }
    }
}
