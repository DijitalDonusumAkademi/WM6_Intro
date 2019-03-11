using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public interface INotificator   // (Bildirim gonderen)
    {
        /*
         * Interfaceler I ile baslar.
         * Constructorları yoktur.
         * İcindeki her sey soyut oldugu icin onlerine abstract veya virtual keyword u almazlar
         * İcindeki nesneler kalıtım alan sınıflarca implement edilmek zorunda
         * Nesnelerin body kısmı yoktur
         * Bir class birden fazla ınterface den kalıtım alabilir.
         */

        // Bütün bildirimler bu tipten olacak
        MessageStates MessageStates { get; set; }
        void Send(MessageBase message); // messagebase i burada kalıtım yapmadan calıstırarak implement ettik

    }
}
