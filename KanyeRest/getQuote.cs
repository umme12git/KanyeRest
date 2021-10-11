using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeRest
{
    public class getQuote
    {
        private HttpClient  aClient;

        public getQuote(HttpClient  client)
        {
            aClient = client;
        }
        public string kanyQt()
        {
            var kanyeURL = "https://api.kanye.rest";
            

            var kanyeResponse = aClient.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            //Console.WriteLine(kanyeQuote);
            return   kanyeQuote;
        }

        public string ronQt()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = aClient.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Replace('"', ' ').Trim();
            return ronQuote;
        }

    }
}
