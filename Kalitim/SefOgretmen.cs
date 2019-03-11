using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class SefOgretmen:Ogretmen   // Sefogretmen sınıfı ogretmenden, ogretmen sınıfıda kisiden türetildiği icin sefogratmen sınıfı hem ogretmen hemde kisi sınıfının nesnelerine erisebilir.
    {
        public SefOgretmen()
        {
            instanceDate = DateTime.Now;
            
        }
       
        //public SefOgretmen(int x,int y)
        //{
        //      base yapmadıkca kalıtıldıgı sınıflaraki bos constructorları calıstıracaktır 
        //}
        public double Katsayi { get; set; }
    }
}
