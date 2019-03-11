using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ogretmen ogretmen = new Ogretmen();

            SefOgretmen sefOgretmen = new SefOgretmen();    // SefOgretmen classından bir instance olusturdugumuzda önce {Kisi} classının contructor ı calışacak ve oradan bir nesne oluşacak sonra {ogretmen} sınıfının constructorı calışaccak ve nesne oluşacak en son {SefOgretmen} classının contructorı çalısacak ve nesne olusturulacak. Geriye dogru bir ayaga kaldırma islemi gerceklesiyor.

            //sefOgretmen.instanceDate şeklinde bir cagırım yapamıyoruz. cunku protected olaral tanımlandı ve sadece kalıtımla aktarıldı.
            
        }
    }
}
