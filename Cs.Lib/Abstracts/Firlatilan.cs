using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Firlatilan : Silah, IFirlatilabilen
    {
        // Sadece Fırlatılan nesnelerine ait özellikleri burada tanımladık. O nesnelere ait fırlatılabilen yetenegini de ınterfaceten implement ettik.
        public abstract int Firlat();   // Override ı zorunlu kılmak için abstract yaptık.Boylece her nesne kendisi için bu metodu düzenlemek zorunda.

    }
}
