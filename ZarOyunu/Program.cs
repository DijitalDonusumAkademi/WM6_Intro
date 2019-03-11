using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dısarıdan 1 ile 6 arasında girilen sayı üzerinden bir zar oyunu oynanacak
            /* Girilen sayı icin cift zar kac denemede gelecek bunu bulan program
             * 5 
             * 16.denemede 5-5 bulundu
             * Tekrarı için sorulacak
             */

            do      // Bir oyunluk döngü
            {
                Random rnd = new Random();
                int giris = 0;
                int zar1 = 0, zar2 = 0, sayac = 0;
                bool dogruMu = false;
                Console.WriteLine("1-6 arasında bir sayı giriniz.");
                try
                {
                    giris = int.Parse(Console.ReadLine());
                    if (giris < 1 || giris > 6)
                        throw new ArgumentException("Lütfen 1-6 arası giris yapınız.");
                    dogruMu = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                while (dogruMu)     // Girilen sayı ciftini bulunana kadar zar atılacak
                {
                    sayac++;
                    zar1 = rnd.Next(1, 7);
                    zar2 = rnd.Next(1, 7);
                    Console.WriteLine(sayac + ". deneme " + zar1 + " - " + zar2);
                    if (zar1 == zar2 && zar1 == giris)
                        break;
                }
                if (dogruMu)
                    Console.WriteLine(sayac + ".denemede bulundu");
                Console.WriteLine("Tekrar oynamak için e yazınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
