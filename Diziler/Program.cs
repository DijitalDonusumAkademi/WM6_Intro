using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array: Aynı tip verilerin tek bir degiskende saklanması icin kullanılır.

            int degisken = 5;

            int[] sayilar = new int[5]; // İçine 5 adet sayı eklenebilir.
            //index 0 dan baslar

            sayilar[0] = 5;
            sayilar[1] = 55;
            sayilar[2] = 513;
            sayilar[3] = 34;
            sayilar[4] = 2;

            for (int i = 0; i < sayilar.Length; i++)
            {
                int gelen = sayilar[i];
                Console.WriteLine(gelen);
                //Console.WriteLine(sayilar[i]);
            }

            foreach (int gelen in sayilar)  // her bir eleman için gezen bir döngü. sayilar dizisinin içerisindeki sayilar[i] elemanı gelen değişkenine atıyor. 
            {
                Console.WriteLine(gelen);
            }

            string[] kisiler = new[] { "zülal", "melike", "esra" };
            string[] kisiler1 = { "zülal", "melike", "esra" };

            double[,] matris = new double[2, 2];    // İki boyutlu dizi. Boyutları , ile ayırıyoruz.

            matris[0, 0] = 3.14;
            matris[0, 1] = 4;
            matris[1, 0] = 6;
            matris[1, 1] = 83;

            for (int i = 0; i < matris.GetLength(0); i++)   // GetLength(0) 1.boyutu
            {
                for (int j = 0; j < matris.GetLength(1); j++)   // GetLength(1) 2. boyutu
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }

            double[,,] matris1 = new double[2, 2, 2];    // Üc boyutlu dizi

            string isim = "Kamil";
            char aa = isim[0];


            Random rnd = new Random();

            matris = new double[10, 4];

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.NextDouble();    // NextDouble metodu 0-1 arası sayı üretir.
                }
            }

            for (int i = 0; i < matris.GetLength(0); i++)   //satır boyutu
            {
                for (int j = 0; j < matris.GetLength(1); j++)   //sütun boyutu
                {
                    Console.Write(matris[i, j] + " - ");
                }
                Console.WriteLine();
            }

            ArrayList liste = new ArrayList();  // Sistem.Collections içerisinde yer alıyor. Onun için bu kütüphaneyi de yukarıda tanımlamalıyız. İçerisine object türünden her değeri alır. Elemanları add metodu ile ekliyoruz.
            liste.Add(5);
            liste.Add("Kamil");
            liste.Add(true);
            liste.Add(3.14);

            // int a = liste[0];

            List<int> listem = new List<int>(); // <> arasına istediğimiz bir tip veriyoruz ve içerisine eklediğimiz tüm değerler bu tipte olmak zorunda 
            listem.Add(5);
            listem.Add(8);
            listem.Add(10);
            
            listem.Remove(0);

            List<int> listem1 = new List<int>() // Farklı bir gösterim
            {
                3,4,5,8
            };


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

            Console.Read();
        }
    }
}
