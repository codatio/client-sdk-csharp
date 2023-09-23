
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables
{
    using CodatSyncPayables.Models.Operations;
    using CodatSyncPayables.Models.Shared;
    using CodatSyncPayables.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Payment methods
    /// </summary>
    public interface IPaymentMethodsSDK
    {

        /// <summary>
        /// Get payment method
        /// 
        /// <remarks>
        /// The *Get payment method* endpoint returns a single payment method for a given `paymentMethodId`.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-payables-api#/schemas/PaymentMethod">Payment methods</a> are used to pay a Bill. Payment Methods are referenced on <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">Bill Payments</a> and <a href="https://docs.codat.io/sync-for-payables-api#/schemas/Payment">Payments</a>.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=paymentMethods">coverage explorer</a> for integrations that support getting a specific payment method.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetPaymentMethodResponse> GetAsync(GetPaymentMethodRequest? request = null);

        /// <summary>
        /// List payment methods
        /// 
        /// <remarks>
        /// The *List payment methods* endpoint returns a list of <a href="https://docs.codat.io/sync-for-payables-api#/schemas/PaymentMethod">payment methods</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-payables-api#/schemas/PaymentMethod">Payment methods</a> are used to pay a Bill. Payment Methods are referenced on <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">Bill Payments</a> and <a href="https://docs.codat.io/sync-for-payables-api#/schemas/Payment">Payments</a>.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        ///     
        /// </remarks>
        /// </summary>
        Task<ListPaymentMethodsResponse> ListAsync(ListPaymentMethodsRequest? request = null);
    }

    public class PaymentMethodsSDK: IPaymentMethodsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.2.1";
        private const string _sdkGenVersion = "2.125.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public PaymentMethodsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<GetPaymentMethodResponse> GetAsync(GetPaymentMethodRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/paymentMethods/{paymentMethodId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetPaymentMethodResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.PaymentMethod = JsonConvert.DeserializeObject<PaymentMethod>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListPaymentMethodsResponse> ListAsync(ListPaymentMethodsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/paymentMethods", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListPaymentMethodsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.PaymentMethods = JsonConvert.DeserializeObject<PaymentMethods>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}