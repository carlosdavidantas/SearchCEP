using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SearchCEP
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("CEP: ");
            string cep = Console.ReadLine();
            string url = $"http://viacep.com.br/ws/{cep}/json/";
            Console.WriteLine("=====");
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);
                var adress = JsonConvert.DeserializeObject<Adress>(json);
                Console.WriteLine(adress);
                Console.ReadKey();
            }
        }
    }
}
