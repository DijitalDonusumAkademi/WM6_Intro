using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public interface IAtama<T1,T2> where T1:Kisi where T2:Kisi  // Generic interface
        // T1 Doktor u, T2 de Hemsire yi temsil ediyor. Doktor a Hemsire atama durumunun kıyaslanmasında kolaylık olsun diye generic kullandık. 
    {
        void AtamaYap(T1 nereye, T2 neyi);
        void Cikart(T1 nereden, T2 neyi);
    }
}
