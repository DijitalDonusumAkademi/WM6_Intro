using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class EmailManager:INotificator
    {
        public MessageStates MessageStates { get; set; }

        public void Send(MessageBase message)
        {
            //email ayarları yapılır
            MessageStates = MessageStates.Pending;
            try
            {
                EmailMessage email = message as EmailMessage;
                MessageStates = MessageStates.Sent;
            }
            catch (Exception ex)
            {
                MessageStates = MessageStates.Failed;
                throw ex;
            }
        }
    }
}
