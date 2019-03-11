using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dısarıdan girilen sayı kadar * karakteri kullanılarak kare sekli cizme
            // a) Eger yanlıs bir giris olduysa program tekrar bir sayı girmesi için istekte bulunmalı
            // b) Çizim işlemi bittikten sonra tekrar calıştırmak istiyor musunuz? e/h diye bir soru sormalı cevap e ise tekrar bastan baslamalı
            // c) sekli içi boş cizsin
            // d) girilen sayı yuksekliğinde eşkenar ücgen çizsin
            // e) girişte bana üç farklı seçenek sunsun  1) kare, 2) iciboskare, 3) ucgen. Bu seçenekleri sectiğimde ona göre cizim yapsın

            /*
            bool durum = true;

            while (durum)
            {
                Console.Write("Lütfen şekil için bir seçim yapınız: 1)Kare, 2)İçiboşkare, 3)Uçgen \n");
                int secim = int.Parse(Console.ReadLine());
                Console.Write("Çizilecek kare için lütfen bir sayı giriniz: ");

                try
                {
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi <= 0)
                    {
                        throw new Exception("Lütfen 0'dan büyük bir sayı giriniz!");
                    }
                    switch (secim)
                    {
                        case 1:
                            for (int i = 0; i < sayi; i++)
                            {
                                for (int j = 0; j < sayi; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                                durum = false;
                            }
                            break;
                        case 2:
                            for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                if (i == 0 || i == x - 1 || j == 0 || j == x - 1)
                                    Console.Write("x");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                            break;
                        case 3:
                            for (int i = 0; i < sayi; i++)
                            {
                                for (int j = sayi; j > i; j--)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 0; k <= i * 2; k++)
                                {
                                    Console.Write("*");
                                }

                                Console.WriteLine();
                            }
                            break;
                        default:
                            break;
                    }
                
                    Console.WriteLine("Tekrar çalıştırmak ister misiniz? e/h");
                    char cevap = char.Parse(Console.ReadLine());
                    if (cevap=='e' || cevap=='E')
                    {
                        durum = true;
                    }
                    else if(cevap=='h' || cevap=='H')
                    {
                        durum = false;
                    }
                    else
                    {
                        throw new Exception("Doğru bir seçenek girmediniz.");                    
                    }
                }
                catch (Exception ex)
                {
                    durum = true;
                    Console.WriteLine(ex.Message);
                } 
            }
            */
            do // bir oyunluk dongu
            {
                Console.Clear();
                string secim = string.Empty;

                do
                {
                    Console.WriteLine("***SECENEKLER***");
                    Console.WriteLine("1) KARE CIZIMI");
                    Console.WriteLine("2) ICI BOS KARE CIZIMI\n3) UCGEN CIZIMI");
                    secim = Console.ReadLine();
                    if (secim == "1" || secim == "2" || secim == "3")
                        break;
                    Console.WriteLine("Lütfen 1-2-3 seceneklerinden birini seciniz");

                } while (true);

                int x = 0;

                do
                {
                    Console.Write("Uzunluğu giriniz: ");
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                        if (x <= 0)
                            throw new Exception("Lütfen  pozitif bir sayı giriniz.");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);
                switch (secim)
                {
                    case "1":
                        // Kare cizimi
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                Console.Write("x");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        // Icı bos kare cizimi
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                if (i == 0 || i == x - 1 || j == 0 || j == x - 1)
                                    Console.Write("x");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    default:
                        for (int i = 1; i < x; i++)
                        {
                            for (int j = 1; j <= i + x - 1; j++)
                            {
                                if (x - i >= j) Console.Write(" ");
                                else Console.Write("x");
                            }

                            Console.WriteLine();
                        }
                        break;
                }
                Console.WriteLine("Tekrar etmek icin e tusuna basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);

            Console.Read();
        }
    }
}
