using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    public class Dikucgen:Dikdortgen
    {
        // Buradaki metodlarda kullanılacak islemlerde dikdortgen yeterli olacagı icin dikdortgenden kalıtım almamız sorun olmayacaktır. Fakat yinede islemlerde birkaç degisiklik gerekiyor bunun icin tekrar bir override yaptık.
        public override double AlanHesapla()
        {
            return base.AlanHesapla()/2;    // base ile kalıtım aldıgı sınıftaki alan hesaplamanın sonucunu getirir. o sonucu ikiye boldugumuzde dogru sonucu elde etmis olacagımız icin tekrar override etmemiz gerekecek.
        }
        public override double CevreHesapla()
        {
            return this.X+this.Y+this.KosegenHesapla(); // X sekil den, y de dikdortgenden kalıtımla geldi
        }
    }
}
