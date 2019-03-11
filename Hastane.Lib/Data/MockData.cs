using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Data
{
    public class MockData
    {   // Rastgele listeler oluşturmak icin böyle bir sınıf oluşturduk. Install-Package FakeData paketini yükledik.

        public Context Context{get;set;}
        // Constructor ile baslangıcta tüm veriler icin atama yapıyoruz.
        public MockData()
        {
            Context = new Context();

            for (int i = 0; i < 10; i++)
            {
                Context.Hastalar.Add(new Models.Hasta()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime()
                });
            }

            for (int i = 0; i < 10; i++)
            {
                Context.Doktorlar.Add(new Models.Doktor()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    Maas = FakeData.NumberData.GetNumber(4000, 10000),
                    Servis = FakeData.EnumData.GetElement<Servis>()
                });
            }

            for (int i = 0; i < 20; i++)
            {
                Context.Hemsireler.Add(new Models.Hemsire()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    Maas=FakeData.NumberData.GetNumber(3000,7000),
                    Servis = FakeData.EnumData.GetElement<Servis>()
                    
                });
            }
        }
    }
}
