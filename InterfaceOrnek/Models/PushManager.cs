using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class PushManager:INotificator
    {
        public MessageStates MessageStates { get; set; }

        public void Send(MessageBase message)
        {
            //push ayarları yapılır
            MessageStates = MessageStates.Pending;
            try
            {
                PushMessage push = message as PushMessage;
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
