using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavarOyunu.Lib.Concrete;

namespace UcakSavarOyunu.Lib.Abstracts
{
    public interface IHareketEdebilir
    {
        void HareketEt(Yonler yon);
    }
}
