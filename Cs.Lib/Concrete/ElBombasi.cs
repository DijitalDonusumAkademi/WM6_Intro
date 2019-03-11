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
    public class ElBombasi : Firlatilan
    {
        public ElBombasi()
        {
            // Her bir nesnenin oluşturuldugu anda içerisinde olmasını istediğimiz özelliklerini constructor icerisinde tanımladık.
            this.Fiyat = 350;
            this.Hasar = 80;
            this.SilahResmi.Image = Properties.Resources.Bomba;
            this.Ulke = "Türkiye";
        }
        public override int Firlat()
        {
            // Bu metod cagırıldıgında calısacak kodlar:
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Bomb);
            soundPlayer.Play();
            Thread.Sleep(500);
            return Hasar;   // Sadece hasar degerini geri gonderdik.
        }
    }
}

