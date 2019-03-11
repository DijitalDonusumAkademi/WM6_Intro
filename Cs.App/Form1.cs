using Cs.Lib.Abstracts;
using Cs.Lib.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cs.Lib.Abstracts.Silah;

namespace Cs.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer seriTimer = new Timer();  // Seri tıklama icin bir timer oluşturduk.
        private Silah seciliSilah;  // Base class tipinde bir field oluşturduk. Polymorphisim yardımıyla her somut classımızdan aldığımız instance lar icin farklı calısacak.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Program calıstıgında formda güzükmesini istediğimiz seyleri nesnelerin visible özelliğinden ayarlayabiliriz.
            cmbSilahlar.Items.AddRange(Enum.GetNames(typeof(Silahlar)));    // Program calıstıgında cmb de enumını olusturdugum listenin eklenmesini istiyorum.Bir kerede enumdaki tüm elemnalrın gelmesini istediğim icin Addrange metodunu cagırdık. GetNames metodu bize string array donduruyor. Bu da cmb nin içini doldurmamız için gerekli seyi saglıyor. GetNames metodu bizden Type tipinde bir deger istiyor. Eger bir metod Type tipinde bir deger istiyorsa onu typeof ile cağırıyor ve icine tipi yazıyoruz.GetNames(typeof(Silahlar): typeof ile Silahlartipini cagırdık.---> Enumları kullanarak string array oluşturma.

            seriTimer.Tick += SeriTimer_Tick; // Tick Eventini oluşturduk.
        }

        private void SeriTimer_Tick(object sender, EventArgs e)
        {
            btnAtesEt.PerformClick();   // Buton için click event ini olusturuyor
        }

        private void cmbSilahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilahlar.SelectedIndex < 0) return; // Herhangi bir  şey secilmediğinde calısmayacak ama hata da vermmeyecek.
            // cmbye aktardıgım elemanları istediğim islemleri yapabilmek için Silahlar tipinde cagırmalıyım ama biz onları string türünde gonderdiğimiz için burada bir donusume ihtiyacımız olacak.Bunun icin parse metodunu kullandık. Parse metodu bizden typeof ile bir type ve string bir deger istiyor. Ve sonucu object olarak donduruyor. bunun icin cast islemi yaptık. yani basına(Silahlar) yazdık.
            Silahlar silah = (Silahlar)Enum.Parse(typeof(Silahlar), cmbSilahlar.SelectedItem.ToString());   // secili enumdan hangi enum oldugunu bulma. //1.yontem

            Silahlar silahb = (Silahlar)cmbSilahlar.SelectedIndex;  // enumların index numarası 0 dan baslayıp sıralı oldugu icin bu yontemide kullanabiliriz. cmb den secilen index i silahlar a cast edersek enum u verecektir.
            byte deger = (byte)silah;   // Boyle bir donusum yaparsakta enum degerini byte degere donuşturecektir.

            switch (silah)  // Hangi nesnenin üretilecegine cmb den gelen enum karar verecek.
            {
                case Silahlar.Bıçak:
                    seciliSilah = new Bicak(); // gelen deger tipindeki nesneyi üretiyoruz boylece null gelmesinin de önüne geçmiş oluyoruz.
                    break;
                case Silahlar.USP:
                    seciliSilah = new USP();
                    break;
                case Silahlar.Glock:
                    seciliSilah = new Glock();
                    break;
                case Silahlar.DesertEagle:
                    seciliSilah = new DesertEagle();
                    break;
                case Silahlar.AK47:
                    seciliSilah = new AK47();
                    break;
                case Silahlar.M4A1S:
                    seciliSilah = new M4A1S();
                    break;
                case Silahlar.ElBombası:
                    seciliSilah = new ElBombasi();
                    break;
                case Silahlar.FlashBombası:
                    seciliSilah = new FlashBombasi();
                    break;
                default:
                    break;
                   
            }
            panelSilah.Controls.Clear();
            panelSilah.Controls.Add(seciliSilah.SilahResmi);    // Olusturdugumuz panel e enumdan gelen nesnenin resmini ekliyoruz.
            seciliSilah.SilahResmi.Dock = DockStyle.Fill;   //Container icine bir nesne ekledigimizde fill oldugu icin bulundugu yeri kaplayacak.

            SilahBilgisiGoster(seciliSilah);

            gb_AtesliSilah.Visible = seciliSilah is IAtesEdebilen; //Buradan true gelmesi halinde gbAteslisilah gözükecek
            gBYakinSaldiri.Visible = seciliSilah is IVurulabilir;   //Buradan true gelmesi halinde gbYakinSaldiri gözükecek
            gbFirlatilan.Visible = seciliSilah is IFirlatilabilen;  //Buradan true gelmesi halinde gbFirlatilan gözükecek

        }

        private void SilahBilgisiGoster(Silah silah)    // Labellerde yazacak bilgiler icin metod oluşturduk.
        {
            lblDetay.Text = $"Ülke: {seciliSilah.Ulke}\nFiyat: {seciliSilah.Fiyat:c2}";
            if (silah is ISarjorlu sarjorSilah) // Parametreyle gelen silah sarjorlu ise onu sarjorsilah degişkenine atayıp sonrasında onunla ilgili bilgileri alacak
                lblDurum.Text = $"{sarjorSilah.KalanFisek} / {sarjorSilah.SarjorKapasitesi}";
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            btnAtesEt.Enabled = false;  // Butona basıldıgı belli olsun diye ilk basta butonun enabled özelligini false yapıyor
            (seciliSilah as IAtesEdebilen).AtesEt();    // Enumdan gelen secilli silahımız ın hangi interfacten  kalıtım oldugu yukarıda belli oldu ve ona göre bir grupbox cıktı.secilisilah atesedebilendir dedik ve o interface in metoduna boylece ulasabildik.metod secilisilahtan gelen type  gore calıştı.
            SilahBilgisiGoster(seciliSilah);    // Sonra bilgilerin güncellenmesi için her basıldıgında bu metodu da burada cagırdık.
            btnAtesEt.Enabled = true;   // Butona tekrar tıklanabilmesi için enabled ı true yaptık

            //if (seciliSilah is Tabanca tabanca)
            //{
            //    tabanca.AtesEt();
            //    lblDurum.Text = $"{tabanca.KalanFisek} / {tabanca.SarjorKapasitesi}";
            //}
            //else if (seciliSilah is Tufek tufek)
            //{
            //    tufek.AtesEt();
            //    lblDurum.Text = $"{tufek.KalanFisek} / {tufek.SarjorKapasitesi}";
            //}
        }
        private void btnYenidenDoldur_Click(object sender, EventArgs e)
        {
            btnYenidenDoldur.Enabled = false;
            (seciliSilah as ISarjorlu).YenidenDoldur(); // Gelen type göre yenıdendoldur metodu calısacak.
            SilahBilgisiGoster(seciliSilah);
            btnYenidenDoldur.Enabled = true;
        }

        private void btnFirlat_Click(object sender, EventArgs e)
        {
            btnFirlat.Enabled = false;
            (seciliSilah as IFirlatilabilen).Firlat();     // Gelen type göre firlat metodu calısacak. 
            btnFirlat.Enabled = true;
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            btnSaldir.Enabled = false;
            (seciliSilah as IVurulabilir).Vur();    // Gelen type göre vur metodu calısacak.
            btnSaldir.Enabled = true;
        }

        private void btnAtesEt_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliSilah is ISeriAtabilir seriSilah)
            {
                seriTimer.Interval = seriSilah.AtisKatsayisi;  
                seriTimer.Start();  // mouse down calıştıgında timer baslayacak ve her tick ettiğinde butonun ates et metodu calısacak ve boylece oradaki kodlarda calısacagı için mermi sayısında azalma meydana gelecek, sesler calısacak..
            }
        }

        private void btnAtesEt_MouseUp(object sender, MouseEventArgs e)
        {
            if (seciliSilah is ISeriAtabilir seriSilah)
            {               
                seriTimer.Stop();   // mouse up oldugunda da timer duracagı için butonateset in de tıklanması duracak. 
            }
        }

       
    }
}
