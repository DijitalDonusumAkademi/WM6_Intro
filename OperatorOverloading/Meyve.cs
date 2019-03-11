﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public abstract class Meyve
    {
        public int Agirlik { get; set; }

        public Color Renk { get; set; }
        public int Fiyat { get; set; }

        // Kendi oluşturdugumuz nesneler arasında işlem yaptırmak icin operator overloading yapmalıyız. Tanımladıgımız bir operatorun tersinide muhakkak tanımlamalıyız yoksa hata alrız.
        public static int operator +(Meyve a,Meyve b)
        {
            return a.Agirlik + b.Agirlik;
        }
        public static int operator -(Meyve a, Meyve b)
        {
            return a.Agirlik - b.Agirlik;
        }
        public static decimal operator *(Meyve a, Meyve b)
        {
            return a.Fiyat * b.Fiyat;
        }
        public static decimal operator /(Meyve a, Meyve b)
        {
            return a.Fiyat * b.Fiyat;
        }
        public static bool operator ==(Meyve a,Meyve b)
        {
            return a.Fiyat == b.Fiyat && a.Agirlik == b.Agirlik;
        }
        public static bool operator !=(Meyve a, Meyve b)
        {
            return a.Fiyat != b.Fiyat && a.Agirlik == b.Agirlik;
        }
        //public static Meyve operator ++(Meyve a)
        //{
        //    a.Fiyat += 1;
        //    return  a;
        //}
        //public static Meyve operator --(Meyve a)
        //{
        //    a.Fiyat -= 1;
        //    return a;
        //}
    }
}
