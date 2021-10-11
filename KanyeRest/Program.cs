using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

    


namespace KanyeRest
{
    class Program
    {
        static void Main(string[] args)
           
        {
            var client = new HttpClient();
            var newQuote = new getQuote(client);

            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Kanye: { newQuote.kanyQt()}");
                Console.WriteLine($"Ron Swanson: {newQuote.ronQt()}");
            }
        }
    }
}
