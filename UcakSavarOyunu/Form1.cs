using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakSavarOyunu.Lib;


namespace UcakSavarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private Oyun oyun;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && oyun == null)
            {
                this.Controls.Clear();
                oyun = new Oyun(this);
                oyun.OyunaDevamEt();
               
            }
           
            else if (e.KeyCode == Keys.Left)
                oyun?.UcakSavar.HareketE(Yonler.Sola);  // ?. null degilse calıstır.
            else if (e.KeyCode == Keys.Right)
                oyun?.UcakSavar.HareketE(Yonler.Saga);  // ?. null degilse calıstır.
            else if (e.KeyCode == Keys.Space)
                oyun?.UcakSavar.AtesEt();
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult secenek = MessageBox.Show("Oyunu kaydetmek ister misiniz?", "Kayıt Penceresi", MessageBoxButtons.YesNo);
                if (secenek==DialogResult.Yes)
                {
                    oyun.OyunuKaydet();
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            oyun?.Resized(this);
        }
    }
}
