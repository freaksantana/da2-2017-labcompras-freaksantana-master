﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DA2_2017_LABCOMPRAS.Models
{
    public static  class myHTTPClientCurrency
    {
        private static HttpClient client;

        private static string baseAddress = "http://193.137.46.2";

        public static HttpClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri(baseAddress);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new
                    MediaTypeWithQualityHeaderValue("application/json"));
                }
                return client;
            }
        }
    }
}

