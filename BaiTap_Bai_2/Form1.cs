using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double num_A_1, num_A_2, num_B_1, num_B_2, num_C_1, num_C_2;
            Double num_d, num_dx, num_dy;

            if (txtA1.Text == "")
            {
                num_A_1 = 0;
            }
            else
            {
                num_A_1 = Convert.ToDouble(txtA1.Text);
            }

            //-----------------------
            if (txtA2.Text == "")
            {
                num_A_2 = 0;
            }
            else
            {
                num_A_2 = Convert.ToDouble(txtA2.Text);
            }
            //---------------------

            if (txtB1.Text == "")
            {
                num_B_1 = 0;
            }
            else
            {
                num_B_1 = Convert.ToDouble(txtB1.Text);
            }

            //--------------------------

            if (txtB2.Text == "")
            {
                num_B_2 = 0;
            }
            else
            {
                num_B_2 = Convert.ToDouble(txtB2.Text);
            }

            //--------------------
            if (txtC1.Text == "")
            {
                num_C_1 = 0;
            }
            else
            {
                num_C_1 = Convert.ToDouble(txtC1.Text);
            }

            //--------------------------
            if (txtC2.Text == "")
            {
                num_C_2 = 0;
            }
            else
            {
                num_C_2 = Convert.ToDouble(txtC2.Text);
            }
            //--------------------

            num_d = num_A_1 * num_B_2 - num_A_2 * num_B_1;
            num_dx = num_C_1 * num_B_2 - num_C_2 * num_B_1;
            num_dy = num_A_1 * num_C_2 - num_A_2 * num_C_1;
            if (num_d != 0)
            {
                txtKQ_X.Text = (num_dx / num_d).ToString();
                txtKQ_Y.Text = (num_dy / num_d).ToString();
            }
            else
            {
                if (num_dx != 0)
                {
                    txtKQ_X.Text = "Hệ vô nghiệm";
                    txtKQ_Y.Text = "Hệ vô nghiệm";
                }
                else
                {
                    txtKQ_X.Text = "Hệ vô số nghiệm";
                    txtKQ_Y.Text = "Hệ vô số nghiệm";
                }
            }
        }

        private void txtKQ_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtKQ_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void txtB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void txtC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void txtA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void txtB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void txtC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }
    }
      
    
}
