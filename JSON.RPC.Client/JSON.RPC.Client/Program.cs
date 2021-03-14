using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace JSON.RPC.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string uri = @"http://37.57.197.116/method";
            while (true)
            {
                var requestBody = Console.ReadLine();

                var requestJson = new StringContent(
                    requestBody,
                    Encoding.UTF8,
                    "application/json");

                var httpClient = new HttpClient();
                var httpResponse = httpClient.PostAsync(uri, requestJson).Result;
                var responseContent = httpResponse.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);
            }
        }
    }
}
