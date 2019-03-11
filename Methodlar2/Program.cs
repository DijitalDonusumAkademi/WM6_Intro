using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir kenarı 2 olan karenin alını: "+AlanHesapla(2)); // Verdiğimiz parametrelere en uygun metodu calıştırır.
            Console.WriteLine(AlanHesapla(2,5)); // int int metodu calısır.
            Console.WriteLine(AlanHesapla(2.4, 5.3)); // double double metodu calısır
            Console.WriteLine(AlanHesapla(2, 5.3)); // int double metodu calısır
            float a = 5;
            Console.WriteLine("Cemberin alanı: "+AlanHesapla(a)); // Tek bir parametre yazmış olsak bile defaultta pi değişkenine bir deger verdiğimiz için metod sorunsuz çalışacaktır ve defaulttaki pi degerini alacaktır.
            Console.WriteLine("Cemberin alani: " + AlanHesapla(a, 3)); // Burada gönderdiğimiz pi değerini alacaktır.
        }
        
        // Aynı ismli fakat imzaları farklı metodlar overload edilmiştir. Ve verdiğimiz parametre değerlerine göre en uygun metod calısır

        /// <summary>
        /// Kare alan hesabı
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int AlanHesapla(int a)
        {
            return a * a;
        }
        /// <summary>
        /// Dikdörtgen alan hesabı
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int AlanHesapla(int a,int b)
        {
            return a * b;
        }
        /// <summary>
        /// Dikdörtgen alan hesabı
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double AlanHesapla(double a, double b)
        {
            return a * b;
        }

        static double AlanHesapla(int a, double b)
        {
            return a * b;
        }

        static double AlanHesapla(float r, double pi=Math.PI)   // pi optinal parametre dir // Değişkenlerden birine baslangıcta deger verecksek o degiskeni imza kısmında en sona yazmalıyız.
        {
            double rr = Convert.ToDouble(r * r);
            return rr*pi;
        }
        //static float AlanHesapla(float a)
        //{
           
        //    return a*a;
        //}
    }
}
