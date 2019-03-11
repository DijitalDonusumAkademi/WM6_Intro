using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    // Bir klasor altında iki farklı proje açtık. Biri form digeri class library(classları bir arada tutan proje) projeleri. ikisininde namespaceleri farklı bunun için kullanacagımız erisim belirteclerine dikkat etmemiz lazım
   public abstract class Sekil
    {
        /*
         * virtual keyword u override edebilmemizi saglamakta eger override edilmezse base classta yazıldıgı gibi calısır. Override edildikten sonra, override edilmis classtan kalıtım alınırsa kalıtım alan class override edilmis halini kalıtım alır. İsterse kendisi tekrar override eder.
         */
        public double X { get; set; } // Tüm alt sınıflarda kullanılabilecek olan bir degiskenin propertysi. Herhangi bir valıdation yapmayacagımız icin autoproperty olarak yazdık.

        // Tüm alt sınıflarda kullanabilecegimiz metodlar. Alt sınıflarda bu metodlarla ilgili herhangi bir degisiklik yapılmadıgında buradaki sekilde aktarılacaktır. Alt sınıflarda bu sekilde calısması istenmediginde orada override edilir. Ama burada da bir metodun override edilmesini saglayan virtual keywor u yazılmalıdır.
        public virtual double CevreHesapla()
        {
            return 4 * X;
        }
        public virtual double  AlanHesapla()
        {
            return Math.Pow(X, 2);
        }
        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
