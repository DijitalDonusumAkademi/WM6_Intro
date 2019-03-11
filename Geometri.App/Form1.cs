using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometri.Lib;

namespace Geometri.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Classlar defaulta internal oldugu icin buradan farklı namespace e sahip Geometri.Lib in icindeki hiç bir nesneye erisemem. Ancak o classı ve ondan kalıtım alan classları public yaparsam erisebilirim
        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare(); // Sadece kare classını public yapmam yeterli gelmez. cunkü ilk olarak sekil classına gider bu nedenle onu da public yapmalıyım.
            kare.X = 5;
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.X = 3;
            dikdortgen.Y = 4;
            Dikucgen ucgen = new Dikucgen();
            ucgen.X = 5;
            ucgen.Y = 12;
            MessageBox.Show($"Karenin alanı: {kare.AlanHesapla()}");
            MessageBox.Show($"Dikdortgen alanı: {dikdortgen.AlanHesapla()}");
            MessageBox.Show($"Karenin alanı: {ucgen.AlanHesapla()}");
            

            //Sekil sekil = new Sekil();    // Bir sınıfı abstract yaparsak ondan instance alınmasını engellemis oluruz. abstract classlardaki nesneler kalıtımla aktarılır.
            //sekil.X = 10;
            //MessageBox.Show($"Sekil alan: {sekil.AlanHesapla()}");
        }
    }
}
