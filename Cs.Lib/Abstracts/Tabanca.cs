using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {
        // Sadece tabanca nesnelerine ait özellikleri burada tanımladık. Ates et yeniden doldur yeteneklerini de gerekli interface sınıflarından implemente ettik.

        protected int _sarjorKapasitesi, _kalanFisek;   // Sedece kalıtımmla aktarılmasını istediğimiz için protected yaptık

        public int SarjorKapasitesi { get => _sarjorKapasitesi; }   //sadece readonly yaptık.Böylece dısarıdan degistirilemeyecek

        public int KalanFisek { get => _kalanFisek; }   //sadece readonly yaptık.Böylece dısarıdan degistirilemeyecek

        public abstract int YenidenDoldur();    // Override ı zorunlu kılmak için abstract yaptık.Boylece her nesne kendisi için bu metodu düzenlemek zorunda.

        public abstract int AtesEt();
        
    }
}
