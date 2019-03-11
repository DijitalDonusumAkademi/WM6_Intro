using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Randevu
    {
        //Randevu icin gerekli özellikleri tanımladık.
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }
        //public Servis Servis { get; set; }
        public int Saat { get; set; }
    }
}
