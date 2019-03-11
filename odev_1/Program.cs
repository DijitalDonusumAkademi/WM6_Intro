using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program calıstıgında ekrana bir doktorun muayene saatlerini yazan program. 15 er dakika ara ile yazacak. mesai 09.00 ile 16.30 arası olacak.12.00 ile 13.00 ogle tatili.
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

            // ----> I

            /*
            DateTime muayene = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 45, 0);
            while (muayene.ToShortTimeString() != "16:30")
            {
                muayene = muayene.AddMinutes(15);
                if (muayene.Hour == 12)
                {
                    continue;
                }
                Console.WriteLine(muayene.ToShortTimeString());
            }
            */

            // ----> II

            for (int saat = 9; saat <= 16; saat++)
            {
                if (saat == 12)
                {
                    Console.WriteLine("*** Öğle Tatili ***");
                    continue;
                }
                for (int dakika = 0; dakika <= 45; dakika+=15)
                {
                    if (saat == 16 && dakika == 45) break;

                    Console.WriteLine(saat.ToString("00")+"."+dakika.ToString("00"));   // ToString metodu ile değişkenimizi iki basamaklı formatta yazdık.
                }
            }


            // ----> III

            /*
            TimeSpan muayeneBaslangıc = new TimeSpan(8, 45, 0);
            TimeSpan muayeneBitis = new TimeSpan(16, 30, 0);
            TimeSpan muayeneSuresi = new TimeSpan(0, 15, 0);

            for (TimeSpan i = muayeneBaslangıc; i < muayeneBitis; i += muayeneSuresi)
            {

                muayeneBaslangıc = muayeneBaslangıc.Add(muayeneSuresi);
                if (muayeneBaslangıc.Hours == 12)
                {
                    continue;
                }
                Console.WriteLine("\n" + muayeneBaslangıc.ToString());
            }
            */



            // ----> IV
            // Bunu while ile de yapabiliriz.
            DateTime baslangic = new DateTime(2000,1,1,9,0,0);
            do
            {
                if (baslangic.Hour == 12)
                {
                    Console.WriteLine("*** Öğle Tatili ***");
                    baslangic = baslangic.AddHours(1);
                    continue;
                }
                Console.WriteLine(baslangic.ToShortTimeString());
                baslangic=baslangic.AddMinutes(15);

            } while (!(baslangic.Hour==16 && baslangic.Minute==45));



            Console.Read();
        }
    }
}
