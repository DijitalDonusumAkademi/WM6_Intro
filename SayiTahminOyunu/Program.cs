using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program 0 ile 100 arasında bir sayı aklında tutacak ve kullanıcıdan bunu bilmesini isteyecek.Her tahminde kullanıcıya yukarı aşağı şeklinde ipucu verecek bildiğinde ise kac denemede bildiğini yazacak.Tekrarı için sorulacak.

            do
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(1,100),tahmin=0,sayac=0;
                Console.WriteLine("1-100 arasında bir sayı tahmin edin");
                do  // Bilene kadar dönecek döngü
                {
                    try
                    {
                        sayac++;
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin < 1 || tahmin > 99)
                            throw new ArgumentException("Lütfen 1-100 arası giris yapınız.");
                        if (rastgele<tahmin)
                            Console.WriteLine("Asagı");
                        else if(rastgele>tahmin)
                            Console.WriteLine("Yukarı");
                        else
                        {
                            Console.WriteLine("Tebrikler "+sayac+". denemede bildiniz");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);

                Console.WriteLine("Tekrar oynamak için e yazınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
