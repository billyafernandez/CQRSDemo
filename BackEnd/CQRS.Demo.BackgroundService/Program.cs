using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Demo.BackgroundService
{
    class Program
    {
        private const string Url = "http://localhost:8080/api/Twitter";

        static void Main(string[] args)
        {
            var t = new Timer(StartProcess, null, 0, 3000);
            Console.ReadLine();
        }

        private static void StartProcess(object o)
        {
            Process("marvel").Wait();
            Process("dccomics").Wait();
            //Process("memes").Wait();
            //Process("motivation").Wait();
            //Process("funnyimages").Wait();
        }

        private static async Task Process(string word)
        {
            var message = "";
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = Url + "?query=" + word;

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    await httpClient.GetAsync(url);

                    message = "process success: " + DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            Console.WriteLine(message);
        }
    }
}
