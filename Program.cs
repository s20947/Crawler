using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
    class Program
    {
        static async Task Main(string[] args)
        { 
            if (args.Length < 1) throw new ArgumentNullException();
            var websiteUr1 = args[0];
            var list = new List<string>();
            var dictionary = new Dictionary<string, string>();
            var set = new HashSet<string>();

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(websiteUr1);
       

            var content = await response.Content.ReadAsStringAsync();

            var regex = new Regex(@"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+");

            var matchCollection = regex.Matches(content);

            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }



            
        }

    }
}
