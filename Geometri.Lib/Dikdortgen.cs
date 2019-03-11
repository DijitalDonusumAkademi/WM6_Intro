using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    public class Dikdortgen:Sekil
    {
        public double Y { get; set; }   // İslemleri yapabilmek icin bir tane daha degiskene ihtiyac vardı. Bundan dolayı ve herhangi bir validation islemi yapmayacagım icin autoproperty tanımladık.

        // Aşagıdaki metodların sekil classından geldiği sekilde calısmasını ıstemedigim icin burada onları override ediyorum. Boylece buradaki gibi calısacak
        public override double AlanHesapla()
        {
            return X * Y;
        }
        public override double CevreHesapla()
        {
            return 2 * (X + Y);
        }
        public override double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
