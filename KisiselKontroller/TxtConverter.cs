using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselKontroller
{
    public delegate void SinirAsimiHandler(string mesaj);
    public delegate void FalanHandler(object sender, EventArgs e);
    public partial class TxtConverter : UserControl
    {
        public TxtConverter()
        {
            InitializeComponent();
        }
        // Kendi oluşturdugumuz UserControl. İçine bir adet numericUpDown ve textBox koyduk. Bunu olşturduktan sonra projeyi build etmemiz gerekiyor. Böylece toolboxta artık oluşturdugumuz kalıbı gorebiliriz ve form design a surukle bırak ile aktarabilirz.
        public event SinirAsimiHandler SinirAsildi;
        public event FalanHandler FalanOldu;

        // Bu propertyler usercontrolü forma tasıdıgımızda yan tarafta çıkıyor. Aynı font,Size, visible... gibi
        public int Sayi { get; set; }
        public DateTime Tarih { get; set; }
        public bool AktifMi { get; set; }
        public Color Renk { get; set; }

        public decimal value
        {
            get => nuSayi.Value;
            set => nuSayi.Value = value;
        }
        
        public string ConvertedText => txtSayi.Text;    // Sadece get oldugu zamanda bu sekilde tanımlama yapabiliriz. ReadOnly Prop

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //txtSayi.Text = nuSayi.Value.ToString();
            //this.ParentForm.Text = txtSayi.Text;  // Form a erişebilmek icin iki yol var birincisi burdan oraya erişim. Onu da parentfrom ile saglıyoruz. Çünkü bu nesne illaki bir formda olacagı icin bulundugu form a bu sekilde bir yonlendirme yapabiliriz.

            // Formdan buraya erişim için de buraya property yazıyoruz. Boylece formdan gozukmesini saglıyoruz.

            int sayi = Convert.ToInt32(nuSayi.Value);   // NumericUpDown degistiğinde gelen sayıyı burada kontrol ediyor eger asagıdaki sartlar saglanıyorsa olusturulan SinirAsildi event ine mesajı gonderiyor ve oradan hata mesajını veriyor. Eger sartlar saglanmıyorsa okunusugetir metodunu cagırıyor.
            if (sayi < 0)
            {
                nuSayi.Value = 0;
                SinirAsildi?.Invoke("Sayi 0 dan kucuk olamaz"); // Belli bir degere geldiğinde event ı tetiklemiş olduk. ? işareti nesnenin null olup olmadıgını kontrol ediyor. eger nullsa devamını calıştırmıyor..Invoke cile cagırdık.
                return;
            }
            else if (sayi>9999)
            {
                nuSayi.Value = 9999;
                SinirAsildi?.Invoke("Sayi 9999 dan buyuk olamaz");
                return;
            }

            //txtSayi.Text = TextTools.OkunusuGetir(sayi);  // Texttooldaki metodu getirdik.
            txtSayi.Text = sayi.OkunusuGetir(); // sayı degişkenimi bir integer ve okunusugetir metodumuzda this kullandıgımız bir extension metod. Bu nedenle . ile cagırabildik.
        }
    }
}
