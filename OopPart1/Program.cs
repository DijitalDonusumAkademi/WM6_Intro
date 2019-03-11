using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Insan a = new Insan();  // instance alma(örnekleme)
            
            a.yas = 5;    // Farklı bir nesne icerisinde oldugu icin field dır      
            Insan b = new Insan();  // Insan() Constructor
            b.yas = 10;
                     
            a = b;      // İkisi de referance type olduğu icin esitlendiklerinde adresleri de esitlenecek ve a.yas ve b.yas  nın degeri de esitlemis olacak. ikisinden birinde yapılacak değişiklik diğerini de etkileyecek 
            //a.yas = b.yas;    // ikiside value type oldugu icin a.yasın degeri her ne kadar burada degisecek olsa bile bir alt satırda b.yas ın yeni degerini almayacak
            b.yas = 20;
            Console.WriteLine(a.yas);
            */

            Insan a = new Insan(5); // Bu satırdan sonra Ram üzerinde a nesnesinin bir adresi oluşacak ve erişim belirtecim izin verdiği takdirde nesne icerisindeki fiel, metod ve property lere erişebilecegim  
            Insan b = new Insan(10);
            a = b;
            try

            {
                a.Yas = 7;  // Yas degerini insan classındaki property e gonderiyor orada set kısmında kontrol sağlanıyor (egisiklikte  yapılabilir) eger yas 0 dan kucukse throw olduğu için program direk datetime a bakmadan catche dusüyor. ve aşagıda console.write ile yazdırılırken getteki return degeri donduruyor. eger buyukse alt satıra geciyor
                a.DogumTarihi = new DateTime(2000, 1, 1);   // burada sadece set leme islemi yapılıyor. dogumtarihi degerini property sine gonderiyor. orada degisiklikler yapılıyor. _dogumtarihinin yeni bir değeri oldugu için aşagıda tekrar yas propertysini cagırmasına ragmen getten farklı bir deger geliyor.
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(a.Yas);
            Console.ReadLine();
        }
    }
}
