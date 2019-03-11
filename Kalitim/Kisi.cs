using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Kisi
    {
        // Ortak olan her nesne yi bu sınıfta topladık ve diger sınıfları  bu classtan türettik. Buna kalıtım deniyor. Diger sınıflar türetildikleri sınıfın her nesne, field ve metoduna private olmadıkça ulaşabilir.
        private string _ad, _soyad, _telefon, _email, _tckn;

        protected DateTime instanceDate; // protected ifadelere sadece kalıtım alan sınıflarca erisilir. erisimi metod, constructor veya property icerisindendir.

        public Kisi()       // Burada bos constructor olmasaydı kalıtılan sınıfların hepsi hata verecekti. Çünkü kalıtıldıkları sınıfın sadece parametreli constructorı oldugu icin onlarında aynı sayıda parametreli constructorları olması gerekecekti
        {
            instanceDate = DateTime.Now;
        }
        public Kisi(string ad)
        {
            this.Ad = ad;
            instanceDate = DateTime.Now;
        }
        public string Ad
        {
            get => this._ad;
            set
            {
                NameValid(value, "Ad");
                value = value.Trim();
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public String Soyad
        {
            get => this._soyad;
            set

            {
                NameValid(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public String Telefon
        {
            get => this._telefon;
            set
            {
                if (!value.StartsWith("0"))
                    throw new Exception("Telefon numarasi 0 ile baslamali");
                if (value.Length != 11)
                    throw new Exception("Telefon numaraniz 11 hane olmali");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("Telefon numaraniz sadece rakamlardan olusmalidir");
                }

                this._telefon = value;
            }
        }

        public String Email
        {
            get => this._email;
            set
            {
                Regex rgx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!rgx.IsMatch(value))
                    throw new Exception("Lutfen bir email adresi giriniz");
                this._email = value;
            }
        }

        public String TCKN
        {
            get => this._tckn;
            set
            {
                if (value.Length != 11)
                    throw new Exception("TCKN 11 haneli olmalidir");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TCKN sadece rakamlardan olusmalidir");
                }

                this._tckn = value;
            }
        }

        private void NameValid(string value, string propertyName)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception($"{propertyName} girisi sadece harf ve bosluklarla yapilmalidir.");

            }
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }   // Override ettigimiz string metodu kalıtım oldugu icin tum kalıtılan sınıflara aynı sekilde aktarılır.



    }
}
