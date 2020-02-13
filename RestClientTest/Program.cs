using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebClientTestRestApi;

namespace RestClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> urlList = new List<string>();
            using (StreamReader sr = new StreamReader("source.txt"))
            {
                while (!sr.EndOfStream)
                {
                    urlList.Add(sr.ReadLine());
                }
            }

            BasicAuthWebClientTest restApi = new BasicAuthWebClientTest(new BasicAuthUser("test","123456"));
            foreach (var url in urlList)
            {
                var res = restApi.GetRequest(url);
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}
