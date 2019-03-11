using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public abstract class MessageBase
    {
        // Tüm mesajlar bu tipten olacak
        // Bildirim gonderme mimarisi
        protected MessageBase()
        {
            this.MessageDate = DateTime.Now;
        }
        public virtual string Sender { get; set; }
        public virtual string Body { get; set; }

        public DateTime MessageDate { get; private set; }   // Dısarıdan set edilemez ama sınıf icerisinden set edilebilir
    }
}
