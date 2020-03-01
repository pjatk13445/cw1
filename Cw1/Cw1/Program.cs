using System;
using System.Net.Http;

namespace Cw1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://pja.edu.pl");
            if (response.IsSuccessStatusCode)
            {
                string html = await response.Content.ReadAsStringAsync();

            }
        }
    }
}
