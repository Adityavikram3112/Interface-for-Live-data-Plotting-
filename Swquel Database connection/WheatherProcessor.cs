using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace Swquel_Database_connection
{
    public class WheatherProcessor
    {
        static List<double> Info = new List<double>();
        static List<double> WindInfo = new List<double>();
        static Wheatherdata.root Details = new Wheatherdata.root();
        public List<double> WheatherInfo(string city)//async Task<Wheatherdata.root>
        {
            //string url = $"q=mumbai&appid=3c4b8e2bbf7e42b8d1cfe1dcfab53fa5";
            string apirequest = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=3c4b8e2bbf7e42b8d1cfe1dcfab53fa5";
            var Info = new List<double>() ;
            var WindInfo = new List<double>();
            var Details = new Wheatherdata.root();


            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(apirequest);
                Details =   JsonConvert.DeserializeObject< Wheatherdata.root > (json);

                Info.Add(Details.main.temp_max);
                Info.Add(Details.main.temp_min);
                Info.Add(Details.wind.speed);
            }
            return Info;
            
            
        }
    }
}
