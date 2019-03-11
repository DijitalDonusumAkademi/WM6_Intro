using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonServislerineBaglanma
{
    public class FourFactory
    {
        public const string clientID = "FGV3J3RYHCP03A1H3YY2AW03Z2LP0440J320YYWILLPU5JEN";
        public const string clientSecret = "JZQ3YHALS4KPONPHNI0XUBILF54GOWSWWZD5MPCGJG43JKYN";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public string categoryCode = "4f04af1f2fb6e1c99f3db0bb";
        public int radius = 2000;
        public string latitude = "41.044062";
        public string longitude = "29.0063537";

        string queryUrl = string.Empty;
        public string jsonString = string.Empty;

        public FourFactory()
        {
            queryUrl = apiUrl;
            queryUrl += "client_id=" + clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl += "&v=" + $"{DateTime.Now:yyyyMMdd}";
            queryUrl += $"&ll={latitude},{longitude}";
            queryUrl += "&radius=" + radius;
            queryUrl += "&categoryId=" + categoryCode;
            GetVenues(queryUrl);
        }
        private async void GetVenues(string query)
        {
            HttpClient client = new HttpClient();   
            try
            {
                jsonString = await client.GetStringAsync(query);
                //jsonString =client.GetStringAsync(query).Result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Four.Venue> Firmalar { get => FirmalariDoldur(); }

        public List<Four.Venue> FirmalariDoldur()
        {
            Four sonuc = JsonConvert.DeserializeObject<Four>(jsonString);
            return sonuc.response.venues.ToList();
        }
    }
}
