using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselKontroller
{
    public static class TextTools
    {
        public static string OkunusuGetir(this int sayi)    // int in basına eklediğimiz this keywordu bu metodu tüm integerlar icin extension metod olarak ekliyor. yani tüm integer degişkenlerde . dediğimizde bu metodu cagırabilecez.
        {
            if (sayi < 0 || sayi > 9999)
                throw new Exception("Sayi 0-9999 arsında olmalı");
            if (sayi == 0) return "sıfır";

            string[] basamak1 = { "", "bir", "iki", "üç", "dört", "bes", "altı", "yedi", "sekiz", "dokuz" };
            string[] basamak10 = { "", "on", "yirmi", "otuz", "kırk", "elli", "atmış", "yetmiş", "seksen", "doksan" };
            string basamak100 = "yüz";
            string basamak1000 = "bin";

            int birler = sayi % 10;             // Birler basamagındaki rakamı alıyor.
            int onlar = (sayi / 10) % 10;       // Onlar basamagındaki rakamı alıyor.
            int yuzler = (sayi / 100) % 10;     // Yüzler basamagındaki rakamı alıyor.
            int binler = (sayi / 1000) % 10;    // Binler basamagındaki rakamı alıyor.

            string okunus = string.Empty;

            if (binler>1)
                okunus += basamak1[binler] + basamak1000;
            else if (binler == 1)
                okunus += basamak1000;
            if(yuzler>1)
                okunus += basamak1[yuzler] + basamak100;
            else if(yuzler==1)
                okunus += basamak100;

            okunus += basamak10[onlar];
            okunus += basamak1[birler];
          
            return okunus;
        }
    }
}
