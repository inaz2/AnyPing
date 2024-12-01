using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AnyPing.utils
{
    internal class CustomHTTPClient
    {
        public static HttpClient Create(int timeoutMsec) {
            HttpClientHandler handler = new HttpClientHandler();

            if (Configuration.SendProxyCredential)
            {
                handler.DefaultProxyCredentials = new NetworkCredential(Configuration.ProxyUsername, Configuration.ProxyPassword);
            }

            HttpClient client = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromMilliseconds(timeoutMsec)
            };
            return client;
        }
    }
}
