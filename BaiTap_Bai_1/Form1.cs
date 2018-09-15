using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Bai_1
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Double num_A;
            Double num_B;
            if (txtA.Text == "")
            {
                num_A = 0;
            }else{
                num_A = Convert.ToDouble(txtA.Text);
            }

            if (txtB.Text == "")
            {
                num_B = 0;
            }
            else
            {
                num_B = Convert.ToDouble(txtB.Text);
            }

            if (num_A == 0)
            {
                if (num_B == 0)
                {
                    txtKQ.Text = "Phương trình có vô số nghiệm ";
                }
                else
                {
                    txtKQ.Text = "Phương trình vô nghiệm";
                }
            }
            else 
            {
                txtKQ.Text = "Phương trình có nghiệm x = " + (-num_B / num_A).ToString();
            }

        }
    }
}
