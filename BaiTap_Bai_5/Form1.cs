using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Bai_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '+')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num_A1, num_A2, num_B1, num_B2;
            
            if (txtA1.Text == "") num_A1 = 0;
            else num_A1 = Convert.ToDouble(txtA1.Text);
            if (txtA2.Text == "") num_A2 = 0;
            else num_A2 = Convert.ToDouble(txtA2.Text);
            if (txtB1.Text == "") num_B1 = 0;
            else num_B1 = Convert.ToDouble(txtB1.Text);
            if (txtB2.Text == "") num_B2 = 0;
            else num_B2 = Convert.ToDouble(txtB2.Text);
            if ((num_B1 + num_B2) < 0)
            txtkQTong.Text = (num_A1 + num_A2).ToString() +  (num_B1 + num_B2).ToString() + "i";
            else txtkQTong.Text = (num_A1 + num_A2).ToString() +"+"+ (num_B1 + num_B2).ToString() + "i";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num_A1, num_A2, num_B1, num_B2;
            if (txtA1.Text == "") num_A1 = 0;
            else num_A1 = Convert.ToDouble(txtA1.Text);
            if (txtA2.Text == "") num_A2 = 0;
            else num_A2 = Convert.ToDouble(txtA2.Text);
            if (txtB1.Text == "") num_B1 = 0;
            else num_B1 = Convert.ToDouble(txtB1.Text);
            if (txtB2.Text == "") num_B2 = 0;
            else num_B2 = Convert.ToDouble(txtB2.Text);
            if ((num_B1 - num_B2) < 0 )
            txtKQHieu.Text = (num_A1 - num_A2).ToString() + (num_B1 - num_B2).ToString() + "i";
            else txtKQHieu.Text = (num_A1 - num_A2).ToString() +"+"+ (num_B1 - num_B2).ToString() + "i";
        }
    }
}
