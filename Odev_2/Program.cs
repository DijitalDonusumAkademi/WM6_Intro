using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
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

            do
            {
                Console.Clear();
                int sayi = 0,zar1=0,zar2,sayac=1;
                Random rnd = new Random();
               
                do
                {
                    Console.Write("Lütfen zar oyunu için bir sayı giriniz: ");
                    try
                    {                      
                        sayi = int.Parse(Console.ReadLine());
                        if (sayi<1 || sayi>6)                      
                            throw new Exception("Girdiğiniz sayı 1 ile 6 arasında olmalı");                       
                        break;
                    }
                    catch (Exception ex)
                    {                        
                        Console.WriteLine(ex.Message);                      
                    }                   
                } while (true);
                
                do
                {
                    zar1 = rnd.Next(1, 7);
                    zar2 = rnd.Next(1, 7);
                    Console.WriteLine("{0}.atıs: {1}-{2}", sayac, zar1,zar2);
                    if (zar1==sayi && zar2==sayi)
                    {
                        Console.WriteLine("{0}.denemede {1}-{2} bulundu", sayac, zar1, zar2);
                        break;
                    }
                    else
                    {
                        sayac += 1;
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
