using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public interface ISarjorlu
    {
        // Bu interfaceten kalıtım alanlar sadece yenidendoldur metodunu, ve geri kala propertyleri implement edebilir.
        int SarjorKapasitesi { get; }
        int KalanFisek { get; }
        int YenidenDoldur();
    }
}
