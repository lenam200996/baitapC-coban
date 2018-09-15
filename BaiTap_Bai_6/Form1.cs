using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kqInput = "";
            String kqSort = "";
            if (txtInput.Text != "")
            {

                String[] arr = txtInput.Text.Split(';');

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "")
                    {
                        arr[i] = "0";
                    }
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    kqInput += (arr[i] + " ");
                }
                txtKQ_Input.Text = kqInput;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (Convert.ToDouble(arr[i]) > Convert.ToDouble(arr[j]))
                        {
                            String temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }

                    }
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    kqSort += (arr[i] + " ");
                }
                txtKQ_Sort.Text = kqSort;
            }
            
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != ';')
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }
    }
}
