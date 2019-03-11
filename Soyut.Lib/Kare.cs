using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public class Kare : Sekil
    {
        public override double AlanHesapla()
        {
            return X * X;
        }

        public override double CevreHesapla()
        {
            return 4 * X;
        }

        public override double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
