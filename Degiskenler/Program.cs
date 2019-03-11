using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            // PascalCase --> Nesneler, metodlar büyük harfle baslar
            // camelCase --> Parametre ve değişkenler küçük harfle yazılır.


            // İsimlendirme kuralları
            // İsimler rakam ile baslayamaz ama rakam bulundurabilirler
            // İsimler özel karakter barındıramaz. _ haric
            // Tanımlı komutların ismi tekrar kullanılamaz.
            // Aynı namespace üzerinde daha önce tanımlanmış bir değişken ismi tekrar tanımlanamaz.

            // TAD - Tip Ad = Deger;

            // Tamsayi tipler:

            byte degiskenByte = 255; // 0 ile 255 arası değerler alır. İsaretsiz 8 bit.
            sbyte degiskenSbyte = -128; // İşaretler olduğu için -128 ile 127 arasında değerler alır. İsaretli 8 bit.
            short degiskenShort = 3200; // İşaretli 16 bit.
            ushort degiskenUshort = 65535; // İşaretsiz 16 bit.
            int degiskenInt = int.MaxValue; // İsaretli 32 bit.
            uint degiskenUint = uint.MaxValue; // İsaretsiz 32 bit.
            long degiskenLong = long.MaxValue;  // İsaretli 64 bit.
            ulong degiskenUlong = ulong.MaxValue;   // İsaretsiz 64 bit.

            degiskenInt = degiskenShort; // Büyük değer içerisine küçük bir değer yazdığımızda sorun olmuyor ve otomatik dönüşüm saglanıyor.
            //degiskenShort = Convert.ToInt16(degiskenLong); // Long içerisine short sınırları içerisinde bir sayı yazarsak dönüşüm yapabiliriz. Fakat büyük bir değer yazarsak hata verecektir.


            // Ondalıklı tipler: 

            float degiskenFloat = 3.14f;
            double degiskenDouble = 3.14;
            decimal degiskenDecimal = 3.14m; // Daha cok para islemlerinde kullanıcaz.

            degiskenInt = 0b1011; // Değişkene binary değer atadık
            Console.WriteLine(degiskenInt*3);
            degiskenInt = 0x2e; // Değişkene hex değer atadık
            Console.WriteLine(degiskenInt);
            degiskenDouble = 3.01e10;
            Console.WriteLine(degiskenInt);


            // Metinsel ifadeler:
            char degiskenChar = 'a';
            string degiskenString = "Hello World";

            // Mantıksal ifade:
            bool dogruMu = true; //false

            DateTime suan = DateTime.Now;
            suan = new DateTime(2018, 11, 26); // Sisteme kendi belirlediğimiz tarihi atadık.

            // Tüm değişken türleri objectten türediği için object bu değişken türlerinin hepsini tutabilir.
            object degiskenObject = suan;
            degiskenObject = degiskenInt;
            degiskenObject = degiskenDouble;

            // var keyword ü içine atanılan değerin tipini alır. Kendi type ı yoktur.
            var query = suan;
            var query1 = degiskenFloat * degiskenDouble;
            var a = 1;
            var b = 2d;
            var c = 3m;
            var d = "merhaba";
        

            Console.Read();
        }
    }
}
