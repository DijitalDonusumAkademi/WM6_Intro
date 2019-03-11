using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program 0 ile 100 arasında bir sayı aklında tutacak ve kullanıcıdan bunu bilmesini isteyecek.Her tahminde kullanıcıya yukarı aşağı şeklinde ipucu verecek bildiğinde ise kac denemede bildiğini yazacak.Tekrarı için sorulacak.

            do
            {
                Console.Clear();
                int sayac = 0,tahmin=0;
                Random rnd = new Random();
                int tutulansayi = rnd.Next(101);

                Console.WriteLine("1 ie 100 arasında bir sayı tuttum. ");
            
                do
                {                   
                    do
                    {
                        Console.Write("Tahmininiz: ");
                        try
                        {
                            tahmin = int.Parse(Console.ReadLine());
                            if (tahmin < 1 || tahmin > 100)
                            {
                                throw new Exception("Lütfen sayınız 1 ile 100 arasında olsun");
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        } 
                    } while (true);

                    sayac += 1;
                    if (tutulansayi > tahmin)
                        Console.WriteLine("Daha büyük bir sayı giriniz.");
                    else if (tutulansayi < tahmin)
                        Console.WriteLine("Daha küçük bir sayı giriniz.");
                    else
                    {
                        Console.WriteLine("Tuttuğum sayı: {0} \n{1}.denemede bildiniz.", tutulansayi, sayac);
                        break;
                    }
                } while (true);
                Console.WriteLine("Tekrar etmek icin e tusuna basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break; 
            } while (true);
        }
    }
}
