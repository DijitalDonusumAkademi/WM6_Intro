using InterfaceOrnek.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;

            INotificator notify;    // İnstance ı burada degil hangi nesne secildiyse orada alır

            switch (comboBox1.SelectedIndex)
            {
                // Amacımız secitiğimiz cb degerine göre mesaj gondermek. Bunun icin o türde bir Inotificator tipinde instance oluşturuyoruz(notify). Notify instance send metoduna sahive ve o metod MessageBase tipinde bir parametre alıyor. Onun için secitigimiz mesaj tipine göre(sms,mail,push) messageBase tipinde bir orneklem alıyoruz. 
                case 0: //sms
                    notify = new SmsManager();
                    MessageBase sms = new SmsMessage()  
                    {
                        // Polymorphism sayesinde istediğimiz degisiklikleri yapıyoruz.Yani sectiğimiz mesaj tipindeki propertylere ulaşıp degerlerini degiştirdik.
                        Body = "sms body",
                        Sender = "sms sender"
                    };
                    notify.Send(sms);   // Send metodu bizden messagebase tipinde bir degisken istiyor. onun icin yukarıda MessageBase tipinde smsMessage den orneklem aldık. Ve hangi tipte geldiyse o tipteki send metodu calısacak            
                    break;
                case 1: //Email
                    notify = new EmailManager();
                    MessageBase email = new EmailMessage()
                    {
                        Body = "email body",
                        Sender = "email sender",
                        Subject = "email subject"
                    };
                    notify.Send(email);
                    break;
                default:  // push
                    notify = new PushManager();
                    MessageBase push = new PushMessage()
                    {
                        Body = "push body",
                        Sender = "push sender",
                        Channel = "push channel"
                    };
                    notify.Send(push);
                    break;
            }

            if (notify.MessageStates == MessageStates.Sent)
                MessageBox.Show("Gonderildi");
        }
    }
}
