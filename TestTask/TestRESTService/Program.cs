using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace TestRESTService
{
    class Program
    {
        public static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Запускаем owin host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Создаем HttpCient

                HttpClient client = new HttpClient();

                //логирование

                //var response = client.GetAsync(baseAddress + "api/client").Result;
                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}
