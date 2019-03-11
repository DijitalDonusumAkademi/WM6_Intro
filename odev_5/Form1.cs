using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_5
{
    public partial class Form1 : Form
    {
        string kucukEkran = "", tıklanan = "";
        double sayi = 0, sonuc = 0, alinan = 0;
        int islem;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "1";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "2";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "3";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "4";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "5";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "6";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "7";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "8";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "9";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;


        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += "0";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;

        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            tıklanan += ",";
            lblEkran.Text = tıklanan;
            kucukEkran = tıklanan;

        }

        private void btnToplama_Click(object sender, EventArgs e)
        {

            tıklanan += "+";
            lblKucukEkran.Text += tıklanan;
            tıklanan = "";
            sayi = double.Parse(lblEkran.Text);
            islem = 1;


        }

        private void btnCıkarma_Click(object sender, EventArgs e)
        {
            tıklanan += "-";
            lblKucukEkran.Text += tıklanan;
            tıklanan = "";
            sayi = double.Parse(lblEkran.Text);
            islem = 2;
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            tıklanan += "*";
            lblKucukEkran.Text += tıklanan;
            tıklanan = "";
            sayi = double.Parse(lblEkran.Text);
            islem = 3;

        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            tıklanan += "/";
            lblKucukEkran.Text += tıklanan;
            tıklanan = "";
            sayi = double.Parse(lblEkran.Text);
            islem = 4;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            tıklanan = "";
            alinan = double.Parse(lblEkran.Text);
            switch (islem)
            {
                case 1:
                    sonuc = sayi + alinan;
                    lblEkran.Text = sonuc.ToString();
                    lblKucukEkran.ResetText();
                    break;
                case 2:
                    sonuc = sayi - alinan;
                    lblEkran.Text = sonuc.ToString();
                    lblKucukEkran.ResetText();
                    break;
                case 3:
                    sonuc = sayi * alinan;
                    lblEkran.Text = sonuc.ToString();
                    lblKucukEkran.ResetText();
                    break;
                case 4:
                    sonuc = sayi / alinan;
                    lblEkran.Text = sonuc.ToString();
                    lblKucukEkran.ResetText();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "0";
            tıklanan = "";
            lblKucukEkran.ResetText();
        }
    }
}
