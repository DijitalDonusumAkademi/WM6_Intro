using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // a ve b degiskenleri value type oldugundan a=b gibi bir eşitleme yapmamız sonucu birinde yapılan değişiklik digerini etkilemeyecektir
            int a = 5;      
            int b = 10;
            a = b;
            b = 20;
            Console.WriteLine(a);   // a nın son degeri 10 olacaktır.

            // string ifadelerde referans olmasına ragmen eşitleme sonucu yapılan degişiklikler birbirini etkilemeyecktir.
            string x = "5";
            string y = "10";
            x = y;
            y = "20";
            Console.WriteLine(x); // x in son degeri 10 olacaktır

            //int[] dizi1 = null; // Böyle bir nesne var ama adresi olmadığı için içindeki bir özelliğe ulaşmak istediğimizde hata nullreferance exception hatası veriyor.
            //Console.WriteLine(dizi1.Length); 

            int[] dizi1 = new int[5];
            dizi1[0] = 5;
            int[] dizi2 = new int[3];
            dizi2[0] = 10;

            dizi1 = dizi2;  // Dizi1 artık dizi2 nin adresini alıyor. ve içindeki değerlerde dizi2 in değerlerini alıyor.  Ayrıca adresler esitlendiği için boyutlarıda eşitleniyor. yani dizi1 in boyutu artık 3 oluyor.
            dizi2[0] = 20;  // Adresler eşitlendiği için dizi2 nin değişen değeri dizi1 için de değişir.
            Console.WriteLine(dizi1[0]);

            int sayi =5;
            RefTest(ref sayi);  // sayi degerini ref kullanmadan metoda gönderseydik orada hesaplayıp 25 bulsa bile value type oldugu icin degerini degistirmeyecekti
            Console.WriteLine(sayi); // cıktı 25. ref kullanmasaydık cıktı 5 olacaktı.

            string sx = "5";
            RefStringTest(ref sx);  // string ifadeleri de ceviremediğimiz icin ref kullanarak degisikligi sagladık
            Console.WriteLine(sx);

            Array.Resize(ref dizi1, 5); // dizi1 in referansını alıyor içindeki degerleri koruyarak boyutunu 5 yapıyor

            int girilen=10; //herhangi bir deger vermek zorunda degiliz cunku metodun icerisinden donen degeri gelecek. sadece tanımlsakta yeterli.
            if (SayiMi(out girilen))    // out kullandıgımız icin girilen degiskeni hem giris hem de cıkıs parametresidir
            {
                Console.WriteLine(girilen * girilen);
            }
           

            if (int.TryParse(Console.ReadLine(),out girilen))   // string bir ifadeyi integer a cevirmeyi dener. ceviremezse hata mesajı vermez ve islemi yapmadan devam eder
            {
                Console.WriteLine(girilen*girilen);
            }
            Console.Read();
        }

        static bool SayiMi(out int sayi)    // hem sayi degiskeninin degerini hem de return den dönen degeri gönderiyor out sayesinde
        {
            try
            {
                sayi = int.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sayi = 0;
            return false;
        }
       
        static void RefStringTest(ref string x)
        {
            x += "2";
        }

        static void RefTest(ref int a)
        {
            a*=a;
        }
        
    }
}
