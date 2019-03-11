using Hastane.Lib.Helpers;
using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            //Hastaları ve servisleri form acıldıgında dolduruyoruz.
            cmbServis.DataSource = Enum.GetNames(typeof(Servis));
            lstHastalar.DataSource = Form1.Context.Hastalar
                .OrderBy(x => x.Ad)
                .ThenBy(x => x.Soyad)
                .ToList();  // Ad ve soyad a göre sıralama.
        }

        private Hasta seciliHasta;
        private Servis seciliServis;
        private Doktor seciliDoktor;
        private Button seciliButton;

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem as Hasta == null) return;
            seciliHasta = lstHastalar.SelectedItem as Hasta;
            cmbServis.Visible = true;   // Bir hasta secildiğinde servislerin bulundugu combobox gorunecek.
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            lstHastalar.DataSource = KisiHelper.Ara<Hasta>(Form1.Context.Hastalar, txtAra.Text);
        }

        private void lstHastalar_KeyDown(object sender, KeyEventArgs e)
        {
            // Liste içerisindeyken de arama yapabilmek için bu kodları yazdık.
            txtAra.Focus();
            txtAra.Text = e.KeyCode.ToString();
            txtAra.SelectionStart = 1;  
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Servis secildiginde o servisteki doktorları getirecek
            seciliServis = (Servis)Enum.Parse(typeof(Servis), cmbServis.SelectedItem.ToString());
            cmbDoktor.DataSource = Form1.Context.Doktorlar
                .Where(x => x.Servis == seciliServis)
                .ToList();
            cmbDoktor.Visible = true;
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDoktor = cmbDoktor.SelectedItem as Doktor;
            flpSaatler.Visible = true;
            SaatleriDoldur();
            Renklendir();
            RandevulariDoldur();

            
        }
        private Color bosRenk = Color.MediumSpringGreen;
        private Color seciliRenk = Color.Tomato;
        private Color doluRenk = Color.DarkSlateGray;
        private void SaatleriDoldur()
        {
            // Butonları oluşturup flowpanel e ekledik.
            flpSaatler.Controls.Clear();
            var liste = RandevuHelper.Saatler;  // string bir liste yapmıştık saatleri orada tutmuştuk.
            for (int i = 0; i < liste.Count; i++)
            {
                Button btn = new Button()
                {
                    Text = liste[i],    // i. indexteki saati string olarak getiriyor.
                    Name="btn_"+i,
                    Font=new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size=new Size(70,50)
                };
                btn.Click += btnSaat_Click;
                flpSaatler.Controls.Add(btn);
            }
        }

        private void RandevulariDoldur()
        {
            var tumRandevular = Form1.Context.Randevular
                .Where(x => x.Doktor.Id == seciliDoktor.Id);    // secili doktorla aynı doktara sahip  randevuları getirdi.
            foreach (var randevu in tumRandevular)
            {
                Button kapatilacakButton = flpSaatler.Controls[randevu.Saat] as Button; // randevu alırken saat nesnesine br index deger atamıştık.o indexteki butonu kapalı hale getirdik. 
                kapatilacakButton.Enabled = false;
                kapatilacakButton.BackColor = doluRenk;
            }
        }

        private void btnSaat_Click(object sender, EventArgs e)
        {
            seciliButton = sender as Button;
            Renklendir(seciliButton);
            btnRandevuKaydet.Visible = true;
            
        }
        private void Renklendir(Button seciliButton)    // Secili buton için bir renklendirme işlemi
        {
            foreach (Button item in flpSaatler.Controls)
            {
                if (item.Enabled)
                    item.BackColor = item == seciliButton ? seciliRenk : bosRenk;
            }
        }
        private void Renklendir()   
        {
            foreach (Button item in flpSaatler.Controls)
            {
                item.BackColor = bosRenk;
            }
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            int saat = RandevuHelper.Saatler.IndexOf(seciliButton.Text);    // SeciliButondaki textin bulundugu index i saat degişkenine ata
            var durum = Form1.Context.Randevular   
                .FirstOrDefault(x => x.Hasta.Id == seciliHasta.Id && x.Saat == saat);   // Randevular içerisinde secilen hastayla aynı ıd ye sahip ve saatlerin aynı oldugu elemanı getir.
            if(durum!=null) // Eger nulldan farklıysa hastanın o saatte randevusu var demektir v bunun mesajını verdik.
            {
                string mesaj =
                    $"{seciliHasta} {seciliButton.Text}'da {durum.Doktor.Servis} servisde {durum.Doktor}'a randevusu bulunmaktadir";
                MessageBox.Show(mesaj);
                return;
            }

            Form1.Context.Randevular.Add(new Randevu()  // Değilsede listeye yeni bir randevu ekliyor.
            {
                Doktor = seciliDoktor,
                Hasta = seciliHasta,
                Saat = saat
            });
            Renklendir();
            RandevulariDoldur();
            btnRandevuKaydet.Visible = false;
        }
    }
}
