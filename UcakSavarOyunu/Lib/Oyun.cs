using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace UcakSavarOyunu.Lib
{
  
    public class Oyun
    {
        
        private Timer tmr_Roket, tmr_Uretici, tmr_Ucak, tmr_Kontrol;
        SaveFileDialog dosyaKaydet;
        OpenFileDialog dosyaAc;
        private ContainerControl container;
        public List<Ucak> Ucaklar { get; set; } = new List<Ucak>();
        public UcakSavar UcakSavar { get; set; }
        int skor = 0;
       
        public Oyun(ContainerControl container)
        {
            this.container = container;
            this.UcakSavar = new UcakSavar(container);

            tmr_Roket = new Timer()
            {
                Enabled = true,
                Interval = 5
            };
            tmr_Uretici = new Timer()
            {
                Enabled = true,
                Interval = 1200
            };
            tmr_Ucak = new Timer()
            {
                Enabled = true,
                Interval = 120
            };
            tmr_Kontrol = new Timer()
            {
                Enabled = true,
                Interval = 3
            };
            tmr_Uretici.Tick += Tmr_Uretici_Tick;
            tmr_Roket.Tick += Tmr_Roket_Tick;
            tmr_Ucak.Tick += Tmr_Ucak_Tick;
            tmr_Kontrol.Tick += Tmr_Kontrol_Tick;
        }

        public void Resized(ContainerControl container)
        {
            this.container = container;
            UcakSavar.Container = container;
            UcakSavar.Resim.Location = new Point(container.Size.Width / 2 - 41, container.Size.Height - 125);
            foreach (var ucak in Ucaklar)
            {
                ucak.Container = container;
            }
            foreach (Roket roket in UcakSavar.Roketler)
            {
                roket.Container = container;
            }
        }

        private void Tmr_Kontrol_Tick(object sender, EventArgs e)
        {
            foreach (Ucak ucak in Ucaklar)
            {
                Rectangle ru = new Rectangle();
                Rectangle rr = new Rectangle();
                if (ucak.Resim.Location.Y + ucak.Resim.Height > container.Height - 70)
                {
                    tmr_Kontrol.Stop();
                    tmr_Roket.Stop();
                    tmr_Ucak.Stop();
                    tmr_Uretici.Stop();
                    DialogResult secenek = MessageBox.Show($"Skorunuz: {skor}\nTekrar oynamak ister misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo);
                    if (secenek == DialogResult.Yes)
                        Application.Restart();
                    else
                        Application.Exit();

                }
                ru.Location = ucak.Resim.Location;
                ru.Width = ucak.Resim.Width;
                ru.Height = ucak.Resim.Height;
                bool vurduMu = false;
                foreach (Roket roket in UcakSavar.Roketler)
                {
                    rr.Location = roket.Resim.Location;
                    rr.Width = roket.Resim.Width;
                    rr.Height = roket.Resim.Width;

                    //if (ru.IntersectsWith(rr))
                    //{                       
                    //    vurduMu = true;
                    //    container.Controls.Remove(ucak.Resim);
                    //    container.Controls.Remove(roket.Resim);
                    //    Ucaklar.Remove(ucak);
                    //    UcakSavar.Roketler.Remove(roket);
                    //    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.bomb_small);
                    //    soundPlayer.Play();
                    //    break;
                    //}

                    if (roket.Resim.Bounds.IntersectsWith(ucak.Resim.Bounds))
                    {
                        vurduMu = true;
                        container.Controls.Remove(ucak.Resim);
                        container.Controls.Remove(roket.Resim);
                        Ucaklar.Remove(ucak);
                        UcakSavar.Roketler.Remove(roket);
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.bomb_small);
                        soundPlayer.Play();
                        skor++;
                        break;
                    }
                }
                if (vurduMu) break;
            }
            foreach (Roket roket in UcakSavar.Roketler)
            {
                if (roket.Resim.Location.Y < 0)
                {
                    UcakSavar.Roketler.Remove(roket);
                    
                    this.container.Controls.Remove(roket.Resim);
                    break;
                }
            }
        }

        Random rnd = new Random();
        private void Tmr_Uretici_Tick(object sender, EventArgs e)
        {          
            Point point = new Point(rnd.Next(20, container.Width - 70), 20);
            Ucak ucak = new Ucak(point, this.container);
            Ucaklar.Add(ucak);
        }

        private void Tmr_Ucak_Tick(object sender, EventArgs e)
        {
            foreach (IHareketEdebilir ucak in Ucaklar)
            {
                ucak.HareketE(Yonler.Asagi);
            }
        }

        private void Tmr_Roket_Tick(object sender, EventArgs e)
        {
            foreach (IHareketEdebilir roket in UcakSavar.Roketler)
            {
                roket.HareketE(Yonler.Yukari);
            }
        }

        public void OyunuKaydet()
        {
            tmr_Kontrol.Stop();
            tmr_Roket.Stop();
            tmr_Ucak.Stop();
            tmr_Uretici.Stop();
          
            XmlSerializer serializer = new XmlSerializer(typeof(Point));
            TextWriter textWriter = new StreamWriter("Oyun.xml");
            serializer.Serialize(textWriter, UcakSavar.Resim.Location);  
            textWriter.Close();
            textWriter.Dispose();        

        }
        
        public bool OyunaDevamEt()
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(Point));
            XmlReader reader = new XmlTextReader("Oyun.xml");
            if (xmlserializer.CanDeserialize(reader))
            {
                UcakSavar.Resim.Location = (Point)xmlserializer.Deserialize(reader);
              
                reader.Close();
                reader.Dispose();
            }
            else
            {
                MessageBox.Show("Lutfen dogru bir xml dosyasını seciniz");
            }
            return true;
        }

    }
}
