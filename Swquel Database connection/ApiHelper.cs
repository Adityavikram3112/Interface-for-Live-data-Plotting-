using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Swquel_Database_connection
{
    public class ApiHelper
    {
        public static HttpClient  ApiClient { get; set; }
        //WebClient;
        public static void InitilizeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/weather?");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jason"));


        }

    }
}
