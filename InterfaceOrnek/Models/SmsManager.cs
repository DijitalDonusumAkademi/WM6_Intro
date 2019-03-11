using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class SmsManager : INotificator
    {
        public MessageStates MessageStates { get; set; }

        public void Send(MessageBase message)
        {
            //sms ayarları yapılır
            MessageStates = MessageStates.Pending;
            try
            {
                SmsMessage sms = message as SmsMessage; // Formdaki sent metodu ile gelen mesaj messagebase tipinde oldugu icin burada bir donusum yaptık.
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
