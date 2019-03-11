using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cs.Lib.Abstracts
{
    public abstract class Silah //Base classımız. Tüm sınıflarda ortak olacak ozelliklerin hepini burada tanımladık.
    {
        public string Ulke { get; protected set; }
        public decimal Fiyat { get; protected set; }
        public int Hasar { get; protected set; }
        public PictureBox SilahResmi { get; protected set; } = new PictureBox(); // PictureBox nesnesinden bir instance aldık. Eger instance almazsak bize nesne oluşturulamadı diye hata verebilir.
        protected Silah()   // Tüm hepsinde ortak olacak özellikleri burdaki constructor icerisinde tanımladık.
        {
            SilahResmi.Size = new Size(500, 400);
            SilahResmi.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public enum Silahlar: byte //:byte yazdıgımızda sınırlama getirmiş olduk, en fazla alacagı eleman sayısı 255 olacak. Silahlarımız belli oldugu icin sabit bir liste oluşturduk.
        {
            Bıçak,
            USP,
            Glock,
            DesertEagle,
            AK47,
            M4A1S,
            ElBombası,
            FlashBombası
        }
    }
}
