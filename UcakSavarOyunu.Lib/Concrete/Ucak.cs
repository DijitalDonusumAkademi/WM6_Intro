using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakSavarOyunu.Lib.Abstracts;

namespace UcakSavarOyunu.Lib.Concrete
{
    public class Ucak : OyunAraclari, IHareketEdebilir
    {
        Point yeniKonum;
        Random rnd = new Random();
        public Ucak()
        {
            AracResmi.Image = Properties.Resources.ucak;
            AracResmi.Location = new Point(rnd.Next(600), 0);
        }
        public void HareketEt(Yonler yon)
        {   if(yon==Yonler.Asagi)
            {              
                yeniKonum.X = AracResmi.Location.X;
                yeniKonum.Y += 5;
                AracResmi.Location = yeniKonum;
            
            }                      
        }
    }
}
