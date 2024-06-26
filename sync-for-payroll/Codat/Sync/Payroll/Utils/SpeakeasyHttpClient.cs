
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payroll.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public interface ISpeakeasyHttpClient
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }

    public class SpeakeasyHttpClient : ISpeakeasyHttpClient
    {
        private class HttpClient : ISpeakeasyHttpClient
        {
            private System.Net.Http.HttpClient client;

            public HttpClient()
            {
                client = new System.Net.Http.HttpClient();
            }

            public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
            {
                return await client.SendAsync(request);
            }
        }

        private ISpeakeasyHttpClient? client;

        internal SpeakeasyHttpClient(ISpeakeasyHttpClient? client = null)
        {
            if (client == null)
            {
                client = new HttpClient();
            }

            this.client = client;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return await client?.SendAsync(request);
        }
    }
}