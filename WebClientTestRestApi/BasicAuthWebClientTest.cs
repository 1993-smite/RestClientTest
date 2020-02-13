using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public string GetRequest(string url)
        {
            string result;
            using (var client = new WebClient())
            {
                string credentials = _basicAuthUser.GetCredential;
                client.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;
                result = client.DownloadString(url);
            }

            return result;
        }
    }

}
