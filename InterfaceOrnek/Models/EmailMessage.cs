using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class EmailMessage:MessageBase
    {
        public string Subject { get; set; }
        public string[] Ccs { get; set; }
        public string[] Bccs { get; set; }
        public byte[] Attachment { get; set; }  // Byte array bir dosyayı binary formata evirmede kullanılır.
    }
}
