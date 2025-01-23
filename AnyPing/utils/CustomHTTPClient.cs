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
        private static HttpClientHandler handler;
        private static HttpClient client;

        public static HttpClient GetInstance()
        {
            NetworkCredential defaultProxyCredential;
            if (Configuration.SendProxyCredential)
            {
                defaultProxyCredential = new NetworkCredential(Configuration.ProxyUsername, Configuration.ProxyPassword);
            }
            else
            {
                defaultProxyCredential = null;
            }

            TimeSpan timeout = TimeSpan.FromMilliseconds(Configuration.PingTimeoutMsec);

            if (client is null
                || defaultProxyCredential != handler.DefaultProxyCredentials
                || timeout != client.Timeout)
            {
                client?.Dispose();

                handler = new HttpClientHandler()
                {
                    DefaultProxyCredentials = defaultProxyCredential,
                };
                client = new HttpClient(handler)
                {
                    Timeout = timeout,
                };
            }

            return client;
        }
    }
}
