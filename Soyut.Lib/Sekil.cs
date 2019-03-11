using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public abstract class Sekil
    {
        // Sekil classından bir örneklem alamamalıyım.Mantıken hatalı. Cünkü sekil dediğimiz burada soyut bir sey. Hangi sekilden bahsettigini bilemiyoruz. Bunun icin bu sınıfı absract yaptık.
        // abstract nesnelerin ornegi(instance) alınamaz.
        // icerisindeki abstract olmayan elemanlar kalıtımla aynen aktarılır.
        public double X { get; set; }

        public abstract double CevreHesapla(); // Abstract nesnenin body kısmı olmaz. Ve muhakkak kalıtılan sınıf tarafından override edilmeli.

        public abstract double AlanHesapla();

        public abstract double KosegenHesapla();
       

    }
}
