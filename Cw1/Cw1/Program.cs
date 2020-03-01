using System;
using System.Net.Http;
using System.Text.RegularExpressions;

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
                var regex = new Regex("[a-z0-9]+@+[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);

                var matches = regex.Matches(html);

                foreach(var m in matches)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}
