using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPart1
{
    class Insan
    {
        /*
         * Erişim Belirleyiciler Access Modifiers
         * fields alanlar-Bir nesnenin içerisinde veri tutan alanlardır
         * constructors yapıcı metodlar
         * properties
         * metodlar fonksiyonlar
         * delege
         * event
         * destructos yıkıcı
         * *kalıtım-inheritance
         * *polymorphism- aynı görunuse farklı calısma
         */

        // Erisim Belirleyiciler Access Modifiers

        /*
         * private-aynı scop ve alt scop içinde erisimi yapılan nesnelerdir. Yani içten dışa erişim var ama dıstan içe yok. tanımlanan tüm degisken ve metodlar onune yazılmasa dahi private olarak calısırlar
         * 
         * internal-aynı namespace içerisinden erişime açıktır. class, interface, enum default degerleri internaldır.
         * 
         * public-farklı namespaceden erisim için kullanılır.
         * 
         * *protected
         * *protected internal
         */

        //internal int yas;

        
        private int _yas;       // Fieldlar bir nesne icerisinde veri tutan alanlardır. Field tanımlarken camelcase biçiminde basına _ karakteri yazmalıyız
        private DateTime _dogumTarihi;

        public Insan(int yas)   // Parametreli constructor
        {
            this._yas = yas; // this bulunduğu sınıfın referansını temsil eder. Aynı isim verilmiş olsaydı bir belirsizlik olcaktı. ınsan class ına ait field a ulaşmak icin burada ınsan._yas diyemeyeceğim için o anki referansına erişimde this i kullanmış oldum.
        }
        public Insan()  // Contructor. adı classla aynı olmalı. Aslında class donduren isimsiz bir metoddur. Insan tipinde bir nesne dondurecek. Paremetre alabilir. hatta imzaları farklı olacak sekilde overloading te yapabiliriz.
        {

        }

        // Encapsulation oldschool
        public void setYas(int yas)
        {
            if (yas <= 0)
                throw new Exception("Yas 0 dan buyuk olmalı");
            this._yas = yas;
        }
        public int getYas() => this._yas;
        //{
        //    return this._yas;
        //}



        // Property (ft. encapsulation)
        public int Yas  // PascalCase
        {
            /*get => this._yas;*/ // get {return this._yas;}
            //get { return DateTime.Now.Year - _dogumTarihi.Year; }

                // get ve set in onunde gorunmez bir public var onu da degistirebiliriz
            get { return this.YasHesapla(_dogumTarihi.Year); }
            set
            {
                if (value <= 0) // value keyword u dısarıdan gelen degeri tutar
                    throw new Exception("Yas 0 dan buyuk olmalı");
                this._yas = value;
            }
        }

        public DateTime DogumTarihi
        {
            set
            {
                if (DateTime.Now.Year - value.Year < 18)
                    throw new Exception("18 yasından kücükler sisteme kayıt olamaz");
                this._yas = this.YasHesapla(value.Year); /*DateTime.Now.Year - value.Year;*/
                this._dogumTarihi = value;
            }
        }
        private int YasHesapla(int year) => DateTime.Now.Year - year;


    }
}
