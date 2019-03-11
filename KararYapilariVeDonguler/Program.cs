using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariVeDonguler
{
    class Program
    {
        public static object DataTime { get; private set; }

        static void Main(string[] args)
        {
            // Operatorler
            // Matematiksel operatorler

            int sayi1 = 5, sayi2 = 10;
            double sayi3 = 0;

            // = -> eşittir operatörü sağdaki işlemi sol tarafa atar.
            // + - * /

            sayi1 = sayi1 + sayi2;  // sağ ve sol taraftaki tip aynı olmak zorunda
            sayi1 += sayi2;
            sayi1++;
            Console.WriteLine(sayi1++);
            Console.WriteLine(sayi1);
            Console.WriteLine(++sayi1);

            sayi3 = sayi2 / (sayi1 + 0d);   // sayi2 yi sayi1 e böldügümde her iki değişkeninde tipi integer oldugundan bana gercek degeri göstermiyecek bu nedenle birini double a donusturmem lazım
            sayi3 = sayi2 / (sayi1 * 1d);
            sayi3 = sayi2 / Convert.ToDouble(sayi1);
            sayi3 = sayi2 / (double)sayi1;
            Console.WriteLine(sayi3);

            // Temp kullanmadan iki sayının yerini değiştirme 
            sayi1 = 5;
            sayi2 = 10;
            sayi1 = sayi1 + sayi2;
            sayi2 = sayi1 - sayi2;
            sayi1 = sayi1 - sayi2;

            // % mod(kalanlı bolme)

            sayi1 = sayi2 % 3;

            // + birlestirme özelligi
            // string ifadeyle int veya double ı toplarsak string verir.
            string sonuc = "Toplam: " + sayi3;
            Console.WriteLine(sonuc);
            Console.WriteLine("Sonuc: " + 3 + 6 + 9); // Hepsini yan yana yazar.
            Console.WriteLine("Sonuc: " + (3 + 6 + 9)); // Önce parantez içindeki toplama işlemini yapar sonra da yan yana yazar.

            // Karsılastırma operatorleri
            // < > <= => == != --- true/false

            bool cevap = sayi1 > sayi2;
            bool dogruMu = sayi1 == sayi2;
            dogruMu = !dogruMu;


            // Mantıksal operatorler
            // & | && ||

            dogruMu = sayi1 < sayi2 & sayi2 % 2 == 0;
            dogruMu = (sayi1 < 0 || sayi1 > 100) && sayi1 % 2 == 0;

            // if eger anlamında. eger icine yazılan ifade true ise if blogu değilse else blogu calısır.

            dogruMu = sayi1 % 2 == 0;
            if (dogruMu)
            {
                Console.WriteLine("Sayı1 çiftir.");
            }
            else
            {
                Console.WriteLine("Sayı1 tektir.");
            }


            Console.WriteLine("Sayi1 " + (dogruMu ? "cifttir" : "tektir")); // ternary if: ? karakterinden sonraki ilk ifade dogru ise, ikinci ifade yanlış ise calışır
            Console.WriteLine("Sayi1 " + (sayi1 % 2 == 0 ? "cifttir" : "tektir"));
            Console.WriteLine(sayi1 % 2 == 0 ? "sayi1 cifttir" : "sayi1 tektir");


            double notOrtalama = 55;
            if (notOrtalama < 50)
            {
                Console.WriteLine("Kaldınız.");
            }
            else if (notOrtalama < 90)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
            {
                Console.WriteLine("Üstün Başarı");
            }


            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun.DayOfWeek);

            DayOfWeek bugun = DateTime.Now.DayOfWeek;
            //if (bugun==DayOfWeek.Monday)
            //{
            //    Console.WriteLine("Bugun Pazartesi");
            //}
            switch (bugun)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Bugun Pazar");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Bugun Pazartesi");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Bugun Salı");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Bugun Carsamba");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Bugun Persembe");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Bugun Cuma");
                    break;
                default:
                    Console.WriteLine("Bugun Cumartesi");
                    break;
            }

            // Donguler

            while (DateTime.Now.Second > 30 && DateTime.Now.Second < 50)
            {
                Console.WriteLine(DateTime.Now);
            }

            while (true)
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now.Second < 30 || DateTime.Now.Second > 50)
                    break;  // Dönguden break keyword u ile cıkmayı sagladık
            }

            // Do-while in while dan farkı sart sağlanmasa bile en az bir kez calısır
            do
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now.Second < 30 || DateTime.Now.Second > 50)
                    break;
            } while (true);
            
            /* For calısma mantıgı:
             * 1)  int i=0;
             * 2)  i<10;
             * ->  islem;
             * 3)  i++;
             * 2)
             * ->
             * 3)
             * |
             * |
             * 3)
             * 2)
             * Bitir
            */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Read();
            // Ödev1: program calıstıgında ekrana bir doktorun muayene saatlerini yazan program. 15 er dakika ara ile yazacak. mesai 09.0 ile 16.30 arası olacak.12.00 ile 13.00 ogle tatili.
            /*
             *09.00
             *09.15
             *09.30
             *09.45
             *10.00
             *
             *11.45
             *13.00
             *
             *16.30
             */

           


        }
    }
}
