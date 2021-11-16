using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tizen;

namespace jjangchin_kiosk
{
    class Utils
    {
        public static string Request(string url)
        {
            HttpClient client = new HttpClient();

            var response = client.GetAsync("http://mbs-b.com:25565" + url).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;

                // by calling .Result you are synchronously reading the result
                string responseString = responseContent.ReadAsStringAsync().Result;

                Log.Debug("owjs3901", $"Request Result {responseString}");
                return responseString;
            }
            return "";
        }

        public static string RequestPost(string url)
        {
            HttpClient client = new HttpClient();

            var response = client.PostAsync("http://mbs-b.com:25565" + url, null).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;

                // by calling .Result you are synchronously reading the result
                string responseString = responseContent.ReadAsStringAsync().Result;

                Log.Debug("owjs3901", $"Request Result {responseString}");
                return responseString;
            }
            return "";
        }
    }
}
