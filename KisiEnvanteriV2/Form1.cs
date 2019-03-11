using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace KisiEnvanteriV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> kisiler = new List<Kisi>();
        List<Kisi> aramalar = new List<Kisi>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yenikisi = new Kisi();
            try
            {
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.Telefon = txtTelefon.Text;
                yenikisi.Email = txtEmail.Text;
                yenikisi.TCKN = txtTckn.Text;
                if (memoryStream.Length>0)
                {
                    yenikisi.Fotograf = memoryStream.ToArray();
                }
                kisiler.Add(yenikisi);
                FormuTemizle();
                lstKisiler.Items.AddRange(kisiler.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtAra")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is ListBox listBox)
                    listBox.Items.Clear();
                else if (control is PictureBox pBox)
                    pBox.Image=null;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;    // Adresler esitlendigi icin icindeki tüm degerlerde esitlenecek. Birinde yapılan degisiklik digerini de etkileyecek.
            try
            {
                seciliKisi.Ad = txtAd.Text; // secilikisi nesnesine text teki degeri atadıgımızda adresleri esit oldugu icin  listbox ta secilen nesnenin degeri de degisecek
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.TCKN = txtTckn.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstKisiler.Items.AddRange(kisiler.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstKisiler.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;

            if (seciliKisi.Fotograf!=null && seciliKisi.Fotograf.Length>0)
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(seciliKisi.Fotograf));
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Kisi>();

            kisiler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstKisiler.Items.AddRange(aramalar.ToArray());
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
            kisiler.Remove(seciliKisi);

            FormuTemizle();
            lstKisiler.Items.AddRange(kisiler.ToArray());
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir XML dosyası seçiniz";
            dosyaKaydet.Filter = "(XML Dosyası) | *.xml";
            dosyaKaydet.FileName = "Kişiler.xml";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(dosyaKaydet.ShowDialog()==DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter textWriter = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(textWriter, kisiler);
                textWriter.Close();
                textWriter.Dispose();
                MessageBox.Show($"XML Disari aktar basarılı {dosyaKaydet.FileName}");
            }
        }

        private void içeAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir XML dosyası seçiniz";
            dosyaAc.Filter = "(XML Dosyası) | *.xml";
            dosyaAc.FileName = "Kişiler.xml";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Kisi>));
                XmlReader reader = new XmlTextReader(dosyaAc.FileName);
                if (xmlserializer.CanDeserialize(reader))
                {
                    kisiler = xmlserializer.Deserialize(reader) as List<Kisi>;
                    MessageBox.Show($"{kisiler.Count} kisi sisteme basarıyla eklendi");
                    lstKisiler.Items.AddRange(kisiler.ToArray());
                    reader.Close();
                    reader.Dispose();
                }
                else
                {
                    MessageBox.Show("Lutfen dogru bir xml dosyasını seciniz");
                }
            }
        }

        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyası) | *.json";
            dosyaKaydet.FileName = "Kişiler.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(kisiler));
                writer.Close();
                writer.Dispose();
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.FileName = "Kişiler.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                    //kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List<Kisi>;
                    //kisiler = (List<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);
                    MessageBox.Show($"{kisiler.Count} kisi sisteme basarıyla eklendi");
                    lstKisiler.Items.Clear();
                    lstKisiler.Items.AddRange(kisiler.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata olustu: "+ex.Message);
                }
            }
        }
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        MemoryStream memoryStream = new MemoryStream(); // Bu nesne ile sectiğimiz fotografı form içerisine byte byte aktarıcaz
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir resim dosyası seçiniz";    // Dosya baslıgı
            dosyaAc.Filter = "JPG Dosyaları | *.jpg;*.png"; // Hangi türlerin görüntülenecegi. Burada kullanılan * karakteri .jpg nin onunde ne olursa olsun anlamında
            dosyaAc.FileName = string.Empty;    // Dosya ismi.
            dosyaAc.Multiselect = false;    // Birden fazla dosya secimi
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // Dosyanın baslangıc gosterim yeri(yolu)
            DialogResult sonuc = dosyaAc.ShowDialog();    // Diolog ekranı gelecek
            if (sonuc == DialogResult.OK)
            {
                // Amac: secilen dosyayı ram uzerinde tutacagımız bir stream hale getirmek
                FileStream dosya = File.Open(dosyaAc.FileName, FileMode.Open);  // Dosya islemlerinde fileStream kullanıyoruz.
                while (dosya.Read(resimArray, 0, bufferSize) != 0)  // Dosyanın read metodu her seferinde bir altsatıra gecer. Offset okuma yapar. Yani buradaki ornekte 64 64 okuyacak.
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);   // memorystream a de yazacak.
                }
                dosya.Close();  // dosyayı kapadık.
                dosya.Dispose(); //Garbage collector ı calıstırıp dosyanın ram den ucurulmasını saglar
                pictureBox1.Image = new Bitmap(memoryStream);
            }
        }
    }
}
