using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Helpers
{
    public class KisiHelper
    {
        public static List<T> Ara<T>(List<T> dataSource,string param) where T:Kisi  //List tipinde bir deger döndürecek. Arama yapılacak listeyi ve textbox ın içine yazılan degerleri parametre olarak gonderecek
        {
            param = param.ToLower();   // Textbox tan gelen degerin tamamını kucuk harfe cevirdik.
            return dataSource.Where(x => x.Ad.ToLower().Contains(param) || x.Soyad.ToLower().Contains(param) || x.TCKN == param).ToList();  //Liste içindeki elemanların adı, soyadı veya tc si param degerini içeriyorsa onu gonderecek.
        }
    }
}
