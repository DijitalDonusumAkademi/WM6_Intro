using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavarOyunu.Lib.Abstracts;

namespace UcakSavarOyunu.Lib.Concrete
{
    public class Mermi : OyunAraclari, IHareketEdebilir
    {
        Point yeniKonum;

        public Mermi()
        {
            AracResmi.Image = Properties.Resources.mermi1;
            AracResmi.Location = new Point(280, 420-AracResmi.Size.Height);
        }
        public void HareketEt(Yonler yon)
        {
            yeniKonum = AracResmi.Location;
            if (yon==Yonler.Yukarı)
            {
                yeniKonum.X = AracResmi.Location.X;
                yeniKonum.Y -= 5;
                AracResmi.Location = yeniKonum;

            }
        }
    }
}
