﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public interface IVurulabilir
    {
        // Bu interfaceten kalıtım alanlar sadece vur metodunu implement edebilir.
        int Vur();
    }
}
