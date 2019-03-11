using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class DesertEagle : Tabanca
    {
        public DesertEagle()
        {
            // Her bir nesnenin oluşturuldugu anda içerisinde olmasını istediğimiz özelliklerini constructor icerisinde tanımladık.
            this.Fiyat = 700;
            this.Ulke = "Israil";
            this._sarjorKapasitesi = 7;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.Deagle;
            this.Hasar = 80;
        }
        public override int AtesEt()    // Metod override e zorunlu kılınmıstı. Bu sınıfa uygun olacak sekilde metodumuzu düzenledik.
        {
            SoundPlayer soundPlayer;    // SoundPlayer nesnemizi oluşturduk.
            if (KalanFisek != 0)        // Mermi sayımızın durumunu kontrol ettik.
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Deagle_Ates);    // Nesnemizden instance aldık.
                soundPlayer.Play(); // Nesnemizin play metodunu cagırarak calısır hale getirdik.
                Thread.Sleep(600);  // İçerisine yazılan milisaniye kadar sonra diger kodu calıştırıyor.
                this._kalanFisek--; // her defasında bu metod kosul saglandıgında kalanfisek sayısını azaltacak
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Bitik_Mermi_Sesi);   // Kalanfisek sayısı 0 a eşitlendiğinde artık else kısmını calıştıracak.
                soundPlayer.Play();
                Thread.Sleep(250);
            }
            return this._kalanFisek;    // Metodumuz void olmadıgı icin bir deger dondurmek zorunda. Bizde kalan fisek sayısını geri gondermesini istiyoruz. 
        }

        public override int YenidenDoldur()
        {
            // Yeniden doldur metodu cagırıldıgıda  doldurma sesi calısacak ve kalan fisek sayısı baslangıctaki sarjorkapasitesine eşit olacak.
            new SoundPlayer(Properties.Resources.Deagle_Reload).Play();
            Thread.Sleep(1250);
            this._kalanFisek = this.SarjorKapasitesi;
            return KalanFisek;
        }
    }
}
