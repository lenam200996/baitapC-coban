using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String string_kq ="" ;
            int num_n;
            if (txtN.Text == "") num_n = 0;
            else num_n = Convert.ToInt32(txtN.Text);
                for (int i = 1; i < num_n + 1; i++)
                {
                    if (isNgTo(i)) string_kq += (i.ToString() + " ");
                } 
                txtKQ.Text = string_kq;
            
           
            
        }

        private bool isNgTo(int number)
        {
            bool temp = false;
            if (number == 1 || number == 2) return true;
            else 
                for (int i = 2; i < number; i++) 
                {
                    if (number % i == 0)
                      return false;
                    else temp = true;
                }

            return temp;
        }

        private void txtKQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
