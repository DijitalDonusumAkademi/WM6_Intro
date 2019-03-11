using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakSavarOyunu.Lib.Abstracts;
using UcakSavarOyunu.Lib.Concrete;

namespace UcakSavarOyunu.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UcakSavar ucakSavar = new UcakSavar();
        Ucak ucak = new Ucak();
        Mermi mermi = new Mermi();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Controls.Add(ucakSavar.AracResmi);
                this.Controls.Add(ucak.AracResmi);
                timer1.Start();
            }
            else if (e.KeyCode == Keys.Right)
                ucakSavar.HareketEt(Yonler.Sag);
            else if (e.KeyCode == Keys.Left)
                ucakSavar.HareketEt(Yonler.Sol);
            else if (e.KeyCode == Keys.Space)
            {
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ucak.HareketEt(Yonler.Asagi);
            if (ucak.AracResmi.Bottom == ucakSavar.AracResmi.Top)
            {              
                timer1.Stop();
                MessageBox.Show("Yandınız");
            }
            else if (ucak.AracResmi.Bottom==mermi.AracResmi.Top)
            {
                timer1.Stop();
                this.Controls.Remove(ucak.AracResmi);               
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            AtesEt();
            mermi.HareketEt(Yonler.Yukarı);
            this.Controls.Add(mermi.AracResmi);
        }
        Point mermiKonum;
        public void AtesEt()
        {
            mermiKonum.X = ucakSavar.AracResmi.Location.X;
            mermiKonum.Y = mermi.AracResmi.Location.Y;
            mermi.AracResmi.Location = mermiKonum;
        }


    }
}
