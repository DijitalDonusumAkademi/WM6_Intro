using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Business
{
    public class DoktorBusiness : IAtama<Doktor, Hemsire>
    {
        // Generic interface te tanımladığımız iki tane metodun yapacagı işlemleri burada tanımladık.
        public void AtamaYap(Doktor nereye, Hemsire neyi)   // Atama yap metodu iki parametre alıyor biri Doktor tipinde bir nereye=doktor nesnesi, digeri hemsire tipinde bir neyi=hemsire nesnesi
        {
            if (neyi.AtandiMi)  // Hemsire class ımızda tanımladıgımız bir  AtandiMi bool prop u var. Eger bunun degeri true geliyorsa hemsire bir doktora atanmıs demektir. Bir hemsire tek bir doktor a atanacagı icin true geldiğinde buradan hata dönecek.
                throw new Exception("Bu hemsire daha önce baska bir doktara atanmıştır.");
            if (nereye.Servis != neyi.Servis)   // Hemsire ve doktorun servisleri aynı olmak zorunda  eger farklı ise de buradan hata dönecek
                throw new Exception("Doktor ve hemsire servisi aynı olmalıdır");
            neyi.AtandiMi = true;   // Eger her iki şartta saglanmıyorsa o zaman AtandiMi degeri false tur. yani hemsire herhaangi bir doktora atanmamış demektir ve ataması gerceklesebilir. atanınca da bool degeri true olmalı
            nereye.Hemsireler.Add(neyi); // Hemsirenin Doktorlar classında tanımlı hemsire listesinin içine ataması yapıldı.
        }

        public void Cikart(Doktor nereden, Hemsire neyi)    // Cikart metodu iki parametre alıyor biri Doktor tipinde bir nereden=doktor nesnesi, digeri hemsire tipinde bir neyi=hemsire nesnesi
        {
            neyi.AtandiMi = false;  //Çıkartmak istediğimiz hemsirenin degerini false yapıyoruz cunku sonrasında tekrar baska bir doktora atanabilir.
            nereden.Hemsireler.Remove(neyi);    // Ve hemsireyi atamasını yaptığımız listeden siliyoruz.
        }
    }
}
