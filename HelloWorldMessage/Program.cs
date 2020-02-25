using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HelloWorldMessage.Services;

namespace HelloWorldMessage
{

    class Program
    {        
        static void Main(string[] args)
        {
            var config = LoadConfiguration();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            string message = client.GetStringAsync(new Uri(config["api:message_url"])).Result;

            WriteService destination = new WriteService();

            destination.WriteMessage(message);
        }



        public static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                           .AddJsonFile("appsettings.json", true, true);

            return builder.Build();
        }

    }
}
