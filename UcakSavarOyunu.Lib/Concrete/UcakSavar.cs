using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavarOyunu.Lib.Abstracts;

namespace UcakSavarOyunu.Lib.Concrete
{
    public class UcakSavar : OyunAraclari, IHareketEdebilir
    {
        Point yeniKonum;

        public UcakSavar()
        {
            AracResmi.Image = Properties.Resources.ucaksavar;
            AracResmi.Location = new Point(280,420);
        }
        public void HareketEt(Yonler yon)
        {
            yeniKonum = AracResmi.Location;
            if (yon == Yonler.Sag)
            {
                yeniKonum.X += 5;
                yeniKonum.Y = AracResmi.Location.Y;
                AracResmi.Location = yeniKonum;
            }
            else if (yon == Yonler.Sol)
            {
                yeniKonum.X -= 5;
                yeniKonum.Y = AracResmi.Location.Y;
                AracResmi.Location = yeniKonum;
            }
        }
       
    }
}
