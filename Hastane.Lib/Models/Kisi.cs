using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public abstract class Kisi
    {
        // Tüm kisiler icin ortak olan özellikleri bu sınıfta tanımladık ve bu sınıftan instance alınmasını istemediğimiz icin abstract yaptık.
        public Guid Id { get; set; } = Guid.NewGuid(); // Her nesne üretildiğinde ona ozel bir uzun kod olusturuyor ve hepsi birbirinden farklı.

        // Herhangi bir validation islemi yapılmayacaksa field yazmadan sadece property yazabiliriz.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public override string ToString() => $"{this.Ad} {this.Soyad}";
        
    }
}
