using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStringDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sistem üzerinde ön tanımlı methodlar vardır. En cok kullanılanları:

            Console.WriteLine(Math.Sign(Math.PI/2));    //math.sign(90) yazdıgımızda degeri radyan olarak tuttuğu için 1 degerini vermez
            Console.WriteLine(Math.Round(7.456, 2));    // Normal Yuvarlama,virgülden sonra iki basamak--> ceiling(yukarı yuvarlama), floor(asagı yuvarlama)
            Console.WriteLine(Math.Pow(3,5));
            Console.WriteLine(Math.Abs(3)); // Mutlak deger
            Console.WriteLine(Math.Sqrt(Math.Pow(3,2)+Math.Pow(4,2)));

            // Tarih fonksiyonları
            DateTime tarih = DateTime.Now;
            DateTime sonraki = tarih.AddHours(3);
            sonraki = tarih.AddDays(3);
            sonraki = tarih.AddMinutes(new Random().Next());
            Console.WriteLine(tarih.AddDays(95));

            TimeSpan fark = sonraki - tarih;
            Console.WriteLine($"Toplam {fark.TotalMinutes} dakika");

            // String fonksiyonları
            string a = "5";
            string b = "10";
            a = b;  // string ifadeler icin immutable ifadesi kullanılabilir. Yani muaf. Referrans type olmasına ragmen boyle bir degisim isleminde a nın degeri alt satırda degismiyor.
            b = "20";   // a nın değeri değişmedi.

            Console.WriteLine(a);

            string kelime = "Wissen akademi";
            bool varMi = kelime.Contains("Akademi"); // string ifademiz bunu iceriyor mu?
            //kelime.IndexOf('i');  // ilk karsılastıgı yerdekinin ındex numarasını getirir. Eger hiç yoksa -1 degeri dondurur.
            //kelime.LastIndexOf('i'); // sondan ilk karsılastıgı yerdekinin index numarasını verir.
            Console.WriteLine(kelime.Remove(6));

            string baslik = "  çin hükümeti otomotiv devlerinden anlık vei topluyor  ";
            baslik = baslik.ToLower();
            baslik = baslik.Trim(); // aradaki boşluklar hariç diğer boşlukları temizler.
            baslik = baslik.Replace(" ", "-");  // degisim yapar
            baslik = baslik.Replace("ç", "c");
            baslik = baslik.Replace("ü", "u");
            baslik = baslik.Replace("ı", "i");
            Console.WriteLine(baslik);


            string mailListesi = "asd@asd.com; asf@asf.com;asz@asz.com";
            string[] mailler = mailListesi.Split(';');  // verilen karaktere göre parcalama yapar

            kelime.Substring(0, 6); // 0. indisten 6. indise kadar olan kısmı alıyor. tek bir parametre kullanırsak ordan sonrasını alır.
        }
    }
}
