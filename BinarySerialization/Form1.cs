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

namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        MemoryStream memoryStream = new MemoryStream(); // Bu nesne ile sectiğimiz fotografı form içerisine byte byte aktarıcaz
        private void btnAc_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir resim dosyası seçiniz";    // Dosya baslıgı
            dosyaAc.Filter = "JPG Dosyaları | *.jpg;*.png"; // Hangi türlerin görüntülenecegi. Burada kullanılan * karakteri .jpg nin onunde ne olursa olsun anlamında
            dosyaAc.FileName = string.Empty;    // Dosya ismi.
            dosyaAc.Multiselect = false;    // Birden fazla dosya secimi
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // Dosyanın baslangıc gosterim yeri(yolu)
            DialogResult sonuc=dosyaAc.ShowDialog();    // Diolog ekranı gelecek
            if(sonuc== DialogResult.OK) // Tamam a basıldıgında if blogu içerisindeki işlemler calısacak. Aynı zamanda kosul dogru ise dosya secilmiştir diyebiliriz.
            {
                // Amac: secilen dosyayı ram uzerinde tutacagımız bir stream hale getirmek
                FileStream dosya = File.Open(dosyaAc.FileName, FileMode.Open);  // Dosya islemlerinde fileStream kullanıyoruz.
                while (dosya.Read(resimArray,0,bufferSize)!=0)  // Dosyanın read metodu her seferinde bir altsatıra gecer. Offset okuma yapar. Yani buradaki ornekte 64 64 okuyacak.
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);   // memorystream a de yazacak.
                }
                dosya.Close();  // dosyayı kapadık.
                dosya.Dispose(); //Garbage collector ı calıstırıp dosyanın ram den ucurulmasını saglar
                pbResim.Image = new Bitmap(memoryStream);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (memoryStream.Length==0)
            {
                MessageBox.Show("Ramda bir dosya bulunmamaktadır");
                return;
            }
            dosyaKaydet.Title = "Bir resim dosyası seçiniz";
            dosyaKaydet.Filter = "(*.jpg) | *.jpg;*.png";
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dosyaKaydet.ShowDialog()==DialogResult.OK)
            {
                FileStream dosya = File.Create(dosyaKaydet.FileName);   // Bu sefer kaydetme icin filestream olusturduk.
                memoryStream.Seek(0, SeekOrigin.Begin); // Memory stream in bastan sona taranmasını saglar.
                while (memoryStream.Read(resimArray, 0, bufferSize) != 0)   // Yukarıda dosyayı memory strema attıgımız icin bu sefer memory streamı okuyor.
                {
                   dosya.Write(resimArray, 0, resimArray.Length);   // Ve arraye tekrar atıyor.
                }
                dosya.Close();
                dosya.Dispose(); 
            }
           
        }
    }
}
