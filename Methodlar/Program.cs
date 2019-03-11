using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamlama();    // Void metodlar geriye bir değer döndürmez bu nedenle herhangi bir değiskene atayamayız.
            Selamlama();
            Selamlama();
            int toplam = Topla(3, 6);
            Console.WriteLine("toplam: " + toplam); // Sınıflar içerisinden metod çağırabiliyoruz. ***Console sınıfından writeline metodu.
            Console.WriteLine("Denklem: "+Disc(1,4,6));
            string[] isimler = { "Zülal", "Melike", "Efe" };
            Selamlama(isimler);
            toplam=Topla(2, 25, 34, 2, 3, 58, 64, 5, 3);
            Console.WriteLine("toplam: " + toplam);
            Console.Read();
        }
        /// <summary>
        /// Program her calıstıgında kullanıcıya selam verir.
        /// </summary>
        static void Selamlama()     
        {
            Console.WriteLine("Merhaba Method");
        }
        static void Selamlama1()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                return;     // void metod içerisine de return yazabiliriz ama geriye herhangi birşey döndurmemeli yani bos bir return yazmalıyız
            Console.WriteLine("Merhaba Method");
        }

        // metodlara parametre yazacaksak önce type ı sonra değişkenin ismi yazılır. Birden fazla parametre icin araya , konur.

        // Metod un ozet(summary) kısmı
        /// <summary>
        /// verilen iki tam sayıyı tolayan metod
        /// </summary>
        /// <param name="sayi1">toplama yapılacak birinci sayı</param>
        /// <param name="sayi2">toplama yapılacak ikinci sayı</param>
        /// <returns>iki sayının toplam degeri</returns>   
        static int Topla(int sayi1, int sayi2) // Parametrelerin olduğu alana metodun imzası denir.
        {
            int toplam = sayi1 + sayi2;
            return toplam;  // Methodun tipi ile döndürülen değerin tipi aynı olmak zorunda
        }

        static string Disc(int a, int b, int c)     // metodun type ı ile parametrelerin type ı aynı olmak zorunda değil. Geri donus degerinin type ı onemli
        {
            int sonuc = b * b - 4 * a * c;
            if (sonuc < 0)
                return "Denklemin reel kökü yoktur";
            else if (sonuc == 0)
                return "Denklemin 1 reel kökü vardır";
            return "Denklemin 2 reel koku vardır.";


        }

        static void Selamlama(string[] kisiler) // Metodu çağırırken once bir dizi oluşturmak zorundayız ve o dizinin ismini tek bir parametre olarak girmek zorundayız. Selamlama(isimler)
        {
            foreach (string kisi in kisiler)
            {
                Console.WriteLine("Hosgeldin "+kisi);
            }
        }

        static int Topla(int carpim, params int[] sayilar) // Dizi oluşturmadan n sayıda parametre girebiliriz. Topla(3,2,4,6,1,0,9)
        {
            int toplam = 0;
            for (int i = 1; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam * carpim;
        }

    }
}
