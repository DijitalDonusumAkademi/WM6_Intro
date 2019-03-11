using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Ogretmen:Kisi
    {
        private int x = 0;  // SefOgretmen classı bu sınıftan türetilmesine ragmen bu field a private oldugu icin ulasamaz.
        public Ogretmen()
        {
            
            instanceDate = DateTime.Now;
        }
        public Ogretmen(string ad): base(ad)  // Kalıtılan sınıflarda oluşturduğumuz her farklı parametreli constructorların kalıtıldığı sınıflarda base kullandıgımızda karşılıgı olmalı
        {

            instanceDate = DateTime.Now;
        }
        //public Ogretmen(string ad,string soyad):base(ad,soyad)    // Kalıtıldıgı sınıfta karsılıgı olmadıgı icin base yazdıgımızda hata veriyor
        //{
        //    instanceDate = DateTime.Now;
        //}
      
        public Branslar Brans { get; set; } // Herhangi bir degisiklik(validation,encapsulation veya get set islemleri) yapmayacagımız icin bunu autoproperty olarak ekledik. Görünürde bir field ı olmasa bile arka planda tuttugu bir field ı var. Böylece bir field tanımlamak zorunda kalmadık.
        public decimal Maas { get; set; }
       
    }
}
