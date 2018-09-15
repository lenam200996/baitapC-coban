using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Bai_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnTong_Click(object sender, EventArgs e)
        {

            int tu_1;
            int tu_2;
            int mau_1;
            int mau_2;

            if (txtTuSo1.Text == "") tu_1 = 0;
            else tu_1 = Convert.ToInt32(txtTuSo1.Text);

            if (txtTuSo2.Text == "") tu_2 = 0;
            else tu_2 = Convert.ToInt32(txtTuSo2.Text);

            if (txtMauSo1.Text == "") mau_1 = 1;
            else mau_1 = Convert.ToInt32(txtMauSo1.Text);

            if (txtMauSo2.Text == "") mau_2 = 1;
            else mau_2 = Convert.ToInt32(txtMauSo2.Text);

            PhanSo ps_1 = new PhanSo(tu_1, mau_1);
            PhanSo ps_2 = new PhanSo(tu_2, mau_2);

            PhanSo ps_tong = new PhanSo((ps_1.TuSO*ps_2.MauSO)+(ps_2.TuSO*ps_1.MauSO), (ps_1.MauSO*ps_2.MauSO));

            txtTuSoTong.Text = ps_tong.TuSO.ToString();
            txtMauSoTong.Text = ps_tong.MauSO.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tu_1;
            int tu_2;
            int mau_1;
            int mau_2;

            if (txtTuSo1.Text == "") tu_1 = 0;
            else tu_1 = Convert.ToInt32(txtTuSo1.Text);

            if (txtTuSo2.Text == "") tu_2 = 0;
            else tu_2 = Convert.ToInt32(txtTuSo2.Text);

            if (txtMauSo1.Text == "") mau_1 = 1;
            else mau_1 = Convert.ToInt32(txtMauSo1.Text);

            if (txtMauSo2.Text == "") mau_2 = 1;
            else mau_2 = Convert.ToInt32(txtMauSo2.Text);

            PhanSo ps_1 = new PhanSo(tu_1, mau_1);
            PhanSo ps_2 = new PhanSo(tu_2, mau_2);

            PhanSo ps_hieu = new PhanSo((ps_1.TuSO * ps_2.MauSO) - (ps_2.TuSO * ps_1.MauSO), (ps_1.MauSO * ps_2.MauSO));

            txtTuSoHieu.Text = ps_hieu.TuSO.ToString();
            txtMauSoHieu.Text = ps_hieu.MauSO.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tu_1;
            int tu_2;
            int mau_1;
            int mau_2;

            if (txtTuSo1.Text == "") tu_1 = 0;
            else tu_1 = Convert.ToInt32(txtTuSo1.Text);

            if (txtTuSo2.Text == "") tu_2 = 0;
            else tu_2 = Convert.ToInt32(txtTuSo2.Text);

            if (txtMauSo1.Text == "") mau_1 = 1;
            else mau_1 = Convert.ToInt32(txtMauSo1.Text);

            if (txtMauSo2.Text == "") mau_2 = 1;
            else mau_2 = Convert.ToInt32(txtMauSo2.Text);

            PhanSo ps_1 = new PhanSo(tu_1, mau_1);
            PhanSo ps_2 = new PhanSo(tu_2, mau_2);

            PhanSo ps_tich = new PhanSo((ps_1.TuSO*ps_2.TuSO), (ps_1.MauSO * ps_2.MauSO));

            txtTuSoTich.Text = ps_tich.TuSO.ToString();
            txtMauSoTich.Text = ps_tich.MauSO.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tu_1;
            int tu_2;
            int mau_1;
            int mau_2;

            if (txtTuSo1.Text == "") tu_1 = 0;
            else tu_1 = Convert.ToInt32(txtTuSo1.Text);

            if (txtTuSo2.Text == "") tu_2 = 0;
            else tu_2 = Convert.ToInt32(txtTuSo2.Text);

            if (txtMauSo1.Text == "") mau_1 = 1;
            else mau_1 = Convert.ToInt32(txtMauSo1.Text);

            if (txtMauSo2.Text == "") mau_2 = 1;
            else mau_2 = Convert.ToInt32(txtMauSo2.Text);

            PhanSo ps_1 = new PhanSo(tu_1, mau_1);
            PhanSo ps_2 = new PhanSo(tu_2, mau_2);

            PhanSo ps_thuong = new PhanSo((ps_1.TuSO * ps_2.MauSO), (ps_1.MauSO * ps_2.TuSO));

            txtTuSoThuong.Text = ps_thuong.TuSO.ToString();
            txtMauSoThuong.Text = ps_thuong.MauSO.ToString();
        }
    }


    public class PhanSo 
    {
        private int tuSO;
        private int mauSO;


        public int TuSO
        {
            get { return tuSO; }
            set { tuSO = value; }
        }
        

        public int MauSO
        {
            get { return mauSO; }
            set { mauSO = value; }
        }

        public PhanSo(int _tu, int _mau) 
        {
            if (_mau == 0) _mau = 1;
            int ucln = uCLN(_tu, _mau);
            this.tuSO = _tu/ucln;
            this.mauSO = _mau/ucln;
        }



        int uCLN(int a, int b)
        {
            a = Math.Abs(a); // trị tuyệt đối cho số âm
            b = Math.Abs(b);  // trị tuyệt đối cho số âm
            if (a == 0 && b != 0)
            {
                return b;
            }
            else if (a != 0 && b == 0)
            {
                return a;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

    }
}
