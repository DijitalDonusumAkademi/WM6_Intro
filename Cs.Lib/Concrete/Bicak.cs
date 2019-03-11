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
    public class Bicak: YakinSaldiri
    {
        public Bicak()
        {
            // Her bir nesnenin oluşturuldugu anda içerisinde olmasını istediğimiz özelliklerini constructor icerisinde tanımladık.
            this.Fiyat = 50;
            this.Hasar = 45;
            this.SilahResmi.Image = Properties.Resources.Bicak;
            this.Ulke = "Türkiye";
            this._vurusKatsayisi = 350;
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Bicak_Cikarma);
            soundPlayer.Play();
        }

        public override int Vur()
        {
            // Bu metod cagırıldıgında calısacak kodlar:
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Bicak_Saplama);
            soundPlayer.Play();
            Thread.Sleep(VurusKatsayisi);
            return Hasar;   // Sadece hasar degerini geri gonderdik.
        }
    }
}
