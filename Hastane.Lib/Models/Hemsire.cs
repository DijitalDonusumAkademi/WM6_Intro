using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Hemsire : Kisi, IMaasAlabilen
    {
        public Servis Servis{get; set;}
        public bool AtandiMi { get; set; } // Bir doktara atanıp atanmadıgının kontrolu icin bool donduren bir property oluşturduk.
        public decimal Maas { get; set; }
    }
    public enum Servis
    {
        KBB,
        Göz,
        Dahiliye,
        Ortapedi
    }
}
