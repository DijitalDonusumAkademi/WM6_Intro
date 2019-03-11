using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           *Onceden tanımlı kelimelerin bulundugu bir adam asmaca oyunu programlayınız
           * 6 hakkı olacak
           * puanlandırma sorudaki harf sayısı*100=maksimum puan
           * her yanlıs cevapta puanın %15 i azalacak
           * 2 cesit kullanıcı girisi olacak 
           * 1.si harf harf tahmin
           * 2.si kelime tahmini
           * 
           * 2 cesit oyun bitirme olacak
           * 1.cesit harfleri tek tek bilerek
           * 2.cesit kelime tahmini yaparak
           * - - - - - - arasında bosluk olacak
           * i
           * i - - - - - -
           * l
           * i - - - - - - - l
           * istanbul
           * tebrikler bildiniz tekrar oynamak ister misiniz.
           * 
           */


            do
            {
                int hak = 6, bilinen = 0;
                string[] sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayranbolu" };
                Random rnd = new Random();
                string seciliSoru = sorular[rnd.Next(sorular.Length)];
                double puan = seciliSoru.Length * 100;
                char[] ekran = new char[seciliSoru.Length];


                for (int i = 0; i < seciliSoru.Length; i++)
                    ekran[i] = '_';
                do
                {
                    foreach (char ee in ekran)
                        Console.Write(ee + " ");
                    string ozet = $"\n{seciliSoru.Length} harf. puan: {puan}. kalan hak: {hak}";
                    Console.WriteLine(ozet);
                    Console.WriteLine("Tahmininizi giriniz: ");
                    string tahmin = Console.ReadLine().ToLower();

                    if (tahmin.Length == 1)
                    {
                        bool bildiMi = false, girildiMi = false;
                        for (int k = 0; k < ekran.Length; k++)
                        {
                            if (ekran[k] == tahmin[0])
                            {
                                girildiMi = true;
                                break;
                            }
                        }
                        if (!girildiMi)
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {
                                if (seciliSoru[i] == tahmin[0])
                                {
                                    bildiMi = true;
                                    ekran[i] = tahmin[0];
                                    bilinen++;
                                }
                            }

                        if (!bildiMi)
                        {
                            hak--;
                            puan *= 0.85;
                        }
                    }
                    else
                    {
                        if (tahmin == seciliSoru)
                            break;
                        hak--;
                        puan *= 0.85;

                    }
                } while (hak > 0 && bilinen != seciliSoru.Length);

                Console.WriteLine(hak > 0 ? "Tebrikler bildiniz" : "Bilemediniz");
                Console.WriteLine("Tekrar oynamak icin e ye basınız");
                if (Console.ReadLine().ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
