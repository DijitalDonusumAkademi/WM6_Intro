using Hastane.Lib.Business;
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
    public partial class DoktorEkleForm : EkleBaseForm
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
        }

        private List<Hemsire> hemsireler;   // Hemsireleri tutacak olan liste.
        private void DoktorEkleForm_Load(object sender, EventArgs e)
        {
            hemsireler = Form1.Context.Hemsireler;  // Form un loadında listemize contextteki hemsireler listemizi atıyoruz.
            cmbServis.DataSource = Enum.GetNames(typeof(Servis)); // Combobax ı enum degerleri ile dolduruyruz.
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combobx ın secili elamnı degiştiğinde olacaklar:
            Servis servis = (Servis)Enum.Parse(typeof(Servis), cmbServis.SelectedItem.ToString()); // type ı servis olan bir değişkenimize secili olan degeri atadık.
            lstDoktorlar.DataSource = Form1.Context.Doktorlar
                .Where(x => x.Servis == servis).ToList();   // DataSource un içini secilen serviste olan doktorlarla doldurduk.

        }

        private void btnHemsireleriGuncelle_Click(object sender, EventArgs e)
        {
            DoktorBusiness doktorBusiness = new DoktorBusiness();   // Atamayap ve cıkart fonksiyonları burada lazım olacagından ve onları doktorbusiness class ı içerisinde tanımladıgımızdan dolayı o classtan instance aldık.
            Doktor dr = lstDoktorlar.SelectedItem as Doktor;    // Doktorlar listesinden secilen doktoru bir degişkene atadık.
            for (var i = 0; i < chlstHemsire.Items.Count; i++)  // Düzenlene Hemsire listesini gezicez ve atanmaları kontrol edicez.
            {
                Hemsire hms = chlstHemsire.Items[i] as Hemsire; // sıra ile gelen hemsireleri bir değişkene atıyoruz ve atanma kontrolünü yapıyoruz.
                if (chlstHemsire.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (hms.AtandiMi) continue;
                    doktorBusiness.AtamaYap(dr, hms);   // Secili olan hemsireyi atar
                }
                else
                {
                    if (!hms.AtandiMi) continue;
                    doktorBusiness.Cikart(dr, hms); // Secili olan hemsireyi çıkartır.
                }
            }
            lstDoktorlar_SelectedIndexChanged(sender, e);

        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            Servis servis = (Servis)Enum.Parse(typeof(Servis), cmbServis.SelectedItem.ToString());
            var servisinHemsireleri = hemsireler
                .Where(x => x.Servis == servis)
                .OrderByDescending(x => x.AtandiMi)
                .ToList();  // Aynı servisteki hemşireleri atandımı sına göre sıralayarak servisHemsireleri listesine atadık.
            Doktor seciliDoktor = lstDoktorlar.SelectedItem as Doktor;
            List<Hemsire> gosterilecekHemsireler = new List<Hemsire>(); // aynı servisteki hemsirelerden secili doktorun hemsirelerini gostermek için boyle bir liste oluşturduk.

            foreach (Hemsire hemsire in servisinHemsireleri)
            {
                if (hemsire.AtandiMi)   // Eger hemsire atandıysa secili doktorun hemsiresiyse getir.
                {
                    if (seciliDoktor.Hemsireler.Any(x => x.Id == hemsire.Id))
                    {
                        gosterilecekHemsireler.Add(hemsire);
                    }
                }
                else  // atanmamışsa zaten getir.
                    gosterilecekHemsireler.Add(hemsire);
            }

            chlstHemsire.DataSource = gosterilecekHemsireler;

            for (int i = 0; i < gosterilecekHemsireler.Count; i++)
            {
                var hms = gosterilecekHemsireler[i];
                chlstHemsire.SetItemCheckState(i, hms.AtandiMi ? CheckState.Checked : CheckState.Unchecked);
            } // Gösterilecek hemsireler içerisinde atananları işaretli olarak getirecek.
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            Servis servis = (Servis)Enum.Parse(typeof(Servis), cmbServis.SelectedItem.ToString());
            List<Doktor> servisinDoktorlari = Form1.Context.Doktorlar.Where(x => x.Servis == servis).ToList();

            lstDoktorlar.DataSource = KisiHelper.Ara<Doktor>(servisinDoktorlari, txtAra.Text);
        }
    }
}

