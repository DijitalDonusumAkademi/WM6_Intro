using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_6
{
    public partial class Form1 : Form
    {
        DateTime sabitTarih;
        TimeSpan sayac;
        TimeSpan temp;
        
        public Form1()
        {
            InitializeComponent();
            lblSayac.Text = "00:00:00:00";
           
           
        }

        private void btnBaslatDurdur_Click(object sender, EventArgs e)
        {
           
            sabitTarih = DateTime.Now;
            if (timer1.Enabled == false)
            {
                timer1.Start();
                btnBaslatDurdur.Text = "Durdur";              
            }
            else
            {
                temp = sayac;
                btnBaslatDurdur.Text = "Başlat";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac = temp + DateTime.Now.Subtract(sabitTarih);

            lblSayac.Text = $"{sayac.Hours.ToString("00")}:{sayac.Minutes.ToString("00")}:{sayac.Seconds.ToString("00")}:{(sayac.Milliseconds / 10).ToString("00")}";
          
            if (lblSayac.Text==dateTimePicker1.Text+":00" )
            {
                timer1.Stop();
                btnBaslatDurdur.Text = "Başlat";             
            }
                      
        }
        private void chbSecim_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSecim.Checked==true)
            {
                dateTimePicker1.Visible = true;
                progressBar1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
                progressBar1.Visible = false;
            }
           
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = dateTimePicker1.Value.ToString();
        }
        
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblSayac.Text = "00:00:00:00";
           temp = new TimeSpan(0, 0, 0, 0, 0);
            btnBaslatDurdur.Text = "Başlat";
        }


    }
}
