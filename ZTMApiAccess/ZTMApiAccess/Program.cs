using Microsoft.Extensions.Configuration;
using ZTMApiAccess.Models;

namespace ZTMApiAccess
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) 
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); 
            IConfiguration configuration = builder.Build();
            ServiceConfig config = new ServiceConfig(configuration);
            
            
            string url = "";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url); 
            }

        }
    }
}