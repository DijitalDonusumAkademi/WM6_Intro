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
    public class FlashBombasi:Firlatilan
    {
        public FlashBombasi()
        {
            // Her bir nesnenin oluşturuldugu anda içerisinde olmasını istediğimiz özelliklerini constructor icerisinde tanımladık.
            this.Fiyat = 200;
            this.Hasar = 0;
            this.SilahResmi.Image = Properties.Resources.Flash;
            this.Ulke = "Almanya";
        }
        public override int Firlat()
        {
            // Bu metod cagırıldıgında calısacak kodlar:
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Flashbang);
            soundPlayer.Play();
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
