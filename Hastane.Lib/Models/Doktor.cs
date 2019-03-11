using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Doktor : Kisi, IMaasAlabilen
    {
        public Servis Servis { get; set; }
        public decimal Maas { get; set; } // İnterfaceten gelen maas ı implement ettik
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>(); // null degeri gelmesin diye burada new ledik.
    }
}
