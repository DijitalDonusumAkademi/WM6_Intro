using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public interface ISeriAtabilir
    {
        // Bu interfaceten kalıtım alanlar sadece atıskatsayısı propertysini implement edebilir.
        int AtisKatsayisi { get; }  // 
    }
}
