using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Personel : Kisi, IMaasAlabilen
    {
        public PersonelBrans Brans { get; set; }
        public decimal Maas { get; set; }
    }
    public enum PersonelBrans
    {
        Temizlik,
        Muhasebe,
        IdariIsler
    }
}
