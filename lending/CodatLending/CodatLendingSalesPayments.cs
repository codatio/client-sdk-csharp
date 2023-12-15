
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Models.Operations;
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatLendingSalesPayments
    {

        /// <summary>
        /// Get payment
        /// 
        /// <remarks>
        /// The *Get payment* endpoint returns a single payment for a given paymentId.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending-api#/schemas/Payment">Payments</a> contain details of all payments made by customers to the company.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&amp;dataType=commerce-payments">coverage explorer</a> for integrations that support getting a specific payment.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/lending-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCommercePaymentResponse> GetAsync(GetCommercePaymentRequest? request = null);

        /// <summary>
        /// List payments
        /// 
        /// <remarks>
        /// The *List payments* endpoint returns a list of <a href="https://docs.codat.io/lending-api#/schemas/Payment">payments</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending-api#/schemas/Payment">Payments</a> contain details of all payments made by customers to the company.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/lending-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        ///     
        /// </remarks>
        /// </summary>
        Task<ListCommercePaymentsResponse> ListAsync(ListCommercePaymentsRequest? request = null);
    }

    public class CodatLendingSalesPayments: ICodatLendingSalesPayments
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.2.0";
        private const string _sdkGenVersion = "2.214.3";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.2.0 2.214.3 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public CodatLendingSalesPayments(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetCommercePaymentResponse> GetAsync(GetCommercePaymentRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCommercePaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommercePayment = JsonConvert.DeserializeObject<CommercePayment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 409) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListCommercePaymentsResponse> ListAsync(ListCommercePaymentsRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/commerce-payments", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListCommercePaymentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CommercePayments = JsonConvert.DeserializeObject<CommercePayments>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 409) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}