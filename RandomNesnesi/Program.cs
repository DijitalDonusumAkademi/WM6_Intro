using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNesnesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Rnd.Next(-10,10));
                Console.WriteLine(Rnd.Next());
                Console.WriteLine(Rnd.Next(1,10));
                Console.WriteLine(Rnd.Next(10));    // 0 ile 10 arası sayı 
            }

            // Dısarıdan 1 ile 6 arasında girilen sayı üzerinden bir zar oyunu oynanacak
            /* Girilen sayı icin cift zar kac denemede gelecek bunu bulan program
             * 5 
             * 16.denemede 5-5 bulundu
             * Tekrarı için sorulacak
             */

            // Program 0 ile 100 arasında bir sayı aklında tutacak ve kullanıcıdan bunu bilmesini isteyecek.Her tahminde kullanıcıya yukarı aşağı şeklinde ipucu verecek bildiğinde ise kac denemede bildiğini yazacak.Tekrarı için sorulacak
        }
    }
}
