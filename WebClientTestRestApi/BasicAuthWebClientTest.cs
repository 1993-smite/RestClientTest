using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebClientTestRestApi
{
    /// <summary>
    /// 
    /// </summary>
    public class BasicAuthWebClientTest
    {
        private BasicAuthUser _basicAuthUser;

        public BasicAuthWebClientTest(BasicAuthUser user)
        {
            _basicAuthUser = user;
        }

        private async Task<HttpResponseMessage> Request(string url)
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                string credentials = _basicAuthUser.GetCredential;
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials);
                response = await client.GetAsync(url);
            }

            return response;
        }

        public HttpResponseMessage GetRequest(string url)
        {
            var result = Request(url);

            return result.Result;
        }
    }

}
