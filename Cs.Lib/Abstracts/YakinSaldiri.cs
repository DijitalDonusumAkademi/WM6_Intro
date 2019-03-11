using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class YakinSaldiri : Silah, IVurulabilir
    {
        // Sadece YakınSaldırı nesnelerine ait özellikleri burada tanımladık. O nesnelere ait Vurulabilir yetenegini de ınterfaceten implement ettik.
        protected int _vurusKatsayisi;    // YakınSaldırı sınıfına, ek olarak _vuruskatsayısı fieldını ekledik                                                                      

        public int VurusKatsayisi
        {
            get => _vurusKatsayisi;
        }
        public abstract int Vur();  // Override ı zorunlu kılmak için abstract yaptık.Boylece her nesne kendisi için bu metodu düzenlemek zorunda.

    }
}
