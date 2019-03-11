using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Data
{
    public class Context
    {
        // Tüm listelerimizi bir sınıf icerisinde tanımladık.
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public List<Randevu> Randevular { get; set; } = new List<Randevu>();
    }
}
