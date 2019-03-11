 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KisiEnvanteriV2
{
    public class Kisi
    {
        private string _ad, _soyad, _telefon, _email, _tckn;

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
        public string Soyad
        {
            get => this._soyad;
            set
            {
                NameValid(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public string Telefon
        {
            get => this._telefon;
            set
            {
                if (!(value.StartsWith("0")))
                    throw new Exception("Numaranız 0 ile başlamalı");
                if (!(value.Length == 11))
                    throw new Exception("Numaranız 11 rakamdan oluşmalı");
                foreach (char harf in value)
                {
                    if (!(char.IsDigit(harf)))
                        throw new Exception("Numaranız sadece rakamlardan oluşmalı");
                }
                this._telefon = value;
            }
        }
        public string Email
        {
            get => this._email;
            set
            {
                Regex rgx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!(rgx.IsMatch(value)))
                    throw new Exception("Lütfen bir mail adresi giriniz");
                this._email = value;
            }
        }
        public string TCKN
        {
            get => this._tckn;
            set
            {
                if (!(value.Length == 11))
                    throw new Exception("TCKN 11 rakamdan oluşmalı");
                foreach (char harf in value)
                {
                    if (!(char.IsDigit(harf)))
                        throw new Exception("TCKN sadece rakamlardan oluşmalı");
                }
                this._tckn = value;
            }
        }

        public byte[] Fotograf { get; set; }

        private void NameValid(string value, string propertyName)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception($"{propertyName} girisi sadece harf ve bosluk icerebilir");
            }
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}
