using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Tufek : Silah, IAtesEdebilen, ISarjorlu,ISeriAtabilir
    {
        // Sadece tufek nesnelerine ait özellikleri burada tanımladık. Ates et yeniden doldur yeteneklerini de gerekli interface sınıflarından implemente ettik. Tüfek sınıflarına ek olarak _atıskatsayısı field ını ekledık.

        protected int _sarjorKapasitesi, _kalanFisek,_atisKatsayisi;
        public int SarjorKapasitesi
        {
            get => this._sarjorKapasitesi;
        }

        public int KalanFisek
        {
            get => this._kalanFisek;
        }

        public int AtisKatsayisi
        {
            get => this._atisKatsayisi;
        }

        public abstract int AtesEt();   // Override ı zorunlu kılmak için abstract yaptık.Boylece her nesne kendisi için bu metodu düzenlemek zorunda.
        public abstract int YenidenDoldur();
        
    }
}
