using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            * 1 Dısarıdan bir veri girisi oldugunda(kullanıcı girisi)
            * 2 Dosya okuma islemi yapıldıgında
            * 3 Veri tabanı islemlerinde
            * 4 Web isteklerde
            * TRY-CATCH KULLANMAK ZORUNDASINIZ.!!
            * ERROR HANDLING - HATA YONETIMI
            */


            Console.Write("Merhaba isminiz nedir? : ");
            string ad=Console.ReadLine();
            Console.WriteLine("Hosgeldin: "+ ad);

            Console.Write("Yasınızı giriniz: ");
            //byte yas = Convert.ToByte(Console.ReadLine());
            try
            {
                byte yas = Convert.ToByte(Console.ReadLine());
                if (yas < 18)
                {
                    Console.WriteLine("Güle güle");
                }
                else
                {
                    Console.WriteLine("Sistemi kullanmaya devam edebilirsiniz.");
                }
            }
            catch 
            {

                Console.WriteLine("Yasınız sayı olmalı");
            }


            try
            {
                // try bloğunda yer alan hata sistemde kayıtlı olan hatalardan olduğu sürece ilgili catchler tarafından yakalanır.
                Console.Write("0-100 arasında bir sayı giriniz: ");
                int girilen = int.Parse(Console.ReadLine()); // Aşağıdaki kontroller dışında bir hata olduğunda Exceptions olan catch bloğuna geçer.
                if (girilen<0 || girilen>100)
                {
                    throw new Exception("0-100 arası bir sayı girmeliydin"); // Bu hata için Exception ın kendi mesajı yerine bizim burada yazdığımız mesajı gösterecek
                }
                if (girilen%2==1)
                {
                    // throw new Exception("Girilen sayı cift olmalı");
                    throw new ArgumentException();  // Hatayı argumentexception a gönderdik ve oradaki blok calıstı
                }
                double sonuc = girilen / girilen;   // Burada oluşan hata sistemde tanımlı olduğu için onun bulunduğu catch bloğuna gitti yani dividebyzeroexception. Ve oradaki orjinal mesajı değiştirdik.
                Console.WriteLine("Girilen bir sayı: "+ girilen);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Girilen sayı cift olmalı");
            }
            catch(DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message); Biz hata mesajımızı yazmasaydık sistem kendi hata mesajını bu kod ile gönderecekti
                Console.WriteLine("Sıfır girmemelisin"); // Kendimizde mesaj yazabiliriz.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Yeni bir Exception mesajı oluşturmadığımız sürece ex.Message: Bilgisayarın kendi verdiği hata mesajı
                
            }
            finally
            {
                Console.WriteLine("Ben her zaman calısırım"); // Hata olsa da olmasa da her zaman bu kod bloğu çalışır.
            }
            
            // Programın iki throw a yakalanma ihtimali yok


           
            Console.Read();
        }
    }
}
