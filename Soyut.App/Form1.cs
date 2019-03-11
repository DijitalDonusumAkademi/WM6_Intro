using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soyut.Lib;

namespace Soyut.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sekil> sekiller = new List<Sekil>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.X = 10;
            //MessageBox.Show($"karenin alanı: {kare.AlanHesapla()}");

            // Object Initializer : Aynı constructor gibi tek satırda bir nesnenin instance ını almaya yarıyor. Constructordan sonra calısır.
            Dikdortgen dikdortgen = new Dikdortgen()
            {              
                X = 5,      // Burada bir validation kontrolü yapacaksak try catch kullanmalıyız.
                Y = 12      // Her bosluga bastıgımızda propertyleri getirecek ve degerleri burada hemen verebilecegiz.
            };
            //dikdortgen.X = 5; Object initializer yaptıgımızda tek tek propertylere boyle deger vermemize gerek kalmıyor.
            //MessageBox.Show($"dikdortgenin kosegeni: {dikdortgen.KosegenHesapla()}");

            sekiller.Add(kare);
            sekiller.Add(dikdortgen);

            Sekil dikdortgen2 = new Dikdortgen()    // Sekil diye bir tipi abstract oldugu icin newleyemesemde tip olarak kullanabiliyorum.
            {
                X = 2,
                Y = 3   // İnitialize yazmazsak Sekil tipinde oldugu icin dikdortgen2.Y gelmez.
            };

            //Sekil dikdortgen3 = new Dikdortgen(); // Sekil tipinde oldugu icin sadece sekil icerisindeki nesneleri getiriyor.

            Sekil kare2 = new Kare() { X = 5 };     // calısma bakımından sekile degilde ornek aldıgına bakıyor     
            sekiller.Add(dikdortgen2);
            sekiller.Add(kare2);
            // Her nesneyi tek bir tip altında toplayabildik.Görünüş olarak Sekiller ama calısma olarak kare veya dikdortgen
            foreach (Sekil sekil in sekiller)   // Hepsine sekil gözüyle bakıyoruz ama calısırken hepsi kendi orneklem aldıgı tipten calısıyor. Kare ise kare, dikdortgense dikdortgen
            {
                //if(sekil is Kare kk)  // List in Tipini object yaptıgımızda her sekil icin kontrol yapmalıydık.
                //    MessageBox.Show($"dikdortgenin kosegeni: {dikdortgen.KosegenHesapla()}");

                MessageBox.Show($"Seklin alani: {sekil.AlanHesapla()}");
            }
            // Kare ve dikdortgene ait ozel bir metod olsaydı gelmeyecekti ama ortakların hepsine ulasabiliriz



        }
    }
}
