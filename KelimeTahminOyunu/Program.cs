using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {


            do
            {
                Console.Clear();
                Random rnd = new Random();
                string[] kelimeler = { "bahçelievler", "arnavutköy", "başakşehir", "üsküdar","zeytinburnu","küçükçekmece","sultangazi" };
                
                int sayac = 6,tahminsayaci=0;
                double puan = 0;
                bool dogruMu = false;
                string secilenKelime = "";
               
                secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];
                string[] oyun = new string[secilenKelime.Length];

                //Console.WriteLine(secilenKelime);
                puan = secilenKelime.Length * 100;
                Console.WriteLine("Hakkınız: {0}\nPuanınız: {1}",sayac,puan);

                for (int i = 0; i < oyun.Length; i++)
                {
                    oyun[i] = "_";
                    Console.Write(oyun[i] + " ");
                }
                do
                {
                    Console.Write("\n\nTahmininizi yazınız: ");
                    string tahmin = Console.ReadLine();
                    dogruMu = false;
                    
                    if (tahmin.Length == 1)
                    {

                        for (int j = 0; j < secilenKelime.Length; j++)
                        {
                            
                            if (tahmin.ToLower() == secilenKelime[j].ToString())
                            {
                                oyun[j] = tahmin.ToLower();
                                tahminsayaci++;
                                dogruMu = true;
                            }                          
                            Console.Write(oyun[j]+" ");                         
                        }
                        if (tahminsayaci==secilenKelime.Length)
                        {
                            Console.WriteLine("\nTebrikler bildiniz.");
                            break;
                        }
                      
                    }                   
                    if (tahmin.Length == secilenKelime.Length)
                    {
                        if (tahmin == secilenKelime)
                        {
                            Console.WriteLine("\nTebrikler bildiniz.");
                            break;
                        }
                        else
                        {
                            dogruMu = false;
                        }
                    }
                    if (!dogruMu)
                    {
                        sayac--;
                        puan = puan - (puan * 0.15);
                        Console.WriteLine("\n\nKalan hakkınız: {0}\nKalan puanınız: {1}", sayac, puan);
                    }
                    
                    if (sayac == 0)
                        Console.WriteLine("Bilemediniz");
                } while (sayac > 0);

                Console.WriteLine("Tekrar oynamak icin e ye basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
           
        }
    }
}
