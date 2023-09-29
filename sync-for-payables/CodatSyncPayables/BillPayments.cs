
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
    /// Bill payments
    /// </summary>
    public interface IBillPaymentsSDK
    {

        /// <summary>
        /// Create bill payments
        /// 
        /// <remarks>
        /// The *Create bill payment* endpoint creates a new <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">bill payment</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">Bill payments</a> are an allocation of money within any customer accounts payable account.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// Required data may vary by integration. To see what data to post, first call <a href="https://docs.codat.io/sync-for-payables-api#/operations/get-create-billPayments-model">Get create bill payment model</a>.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=billPayments">coverage explorer</a> for integrations that support creating a bill payment.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<Models.Operations.CreateBillPaymentResponse> CreateAsync(CreateBillPaymentRequest? request = null);

        /// <summary>
        /// Delete bill payment
        /// 
        /// <remarks>
        /// The *Delete bill payment* endpoint allows you to delete a specified bill payment from an accounting platform.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">Bill payments</a> are an allocation of money within any customer accounts payable account.<br/>
        /// <br/>
        /// ### Process<br/>
        /// 1. Pass the `{billPaymentId}` to the *Delete bill payment* endpoint and store the `pushOperationKey` returned.<br/>
        /// 2. Check the status of the delete operation by checking the status of push operation either via<br/>
        ///    1. <a href="https://docs.codat.io/introduction/webhooks/core-rules-types#push-operation-status-has-changed">Push operation webhook</a> (advised),<br/>
        ///    2. <a href="https://docs.codat.io/sync-for-payables-api#/operations/get-push-operation">Push operation status endpoint</a>.<br/>
        /// <br/>
        ///    A `Success` status indicates that the bill payment object was deleted from the accounting platform.<br/>
        /// 3. (Optional) Check that the bill payment was deleted from the accounting platform.<br/>
        /// <br/>
        /// ### Effect on related objects<br/>
        /// Be aware that deleting a bill payment from an accounting platform might cause related objects to be modified.<br/>
        /// <br/>
        /// ## Integration specifics<br/>
        /// Integrations that support soft delete do not permanently delete the object in the accounting platform.<br/>
        /// <br/>
        /// | Integration | Soft Delete | Details                                                                                              |  <br/>
        /// |-------------|-------------|------------------------------------------------------------------------------------------------------|                                                        <br/>
        /// | Oracle NetSuite   | No          | See <a href="/integrations/accounting/netsuite/how-deleting-bill-payments-works">here</a> to learn more.  |<br/>
        /// | QuickBooks Online | No          | -                                                                                              |<br/>
        /// | Xero | Yes          | -                                                                                                          |<br/>
        /// <br/>
        /// &gt; **Supported integrations**<br/>
        /// &gt;<br/>
        /// &gt; This functionality is currently supported for our QuickBooks Online, Xero and Oracle NetSuite integrations.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<DeleteBillPaymentResponse> DeleteAsync(DeleteBillPaymentRequest? request = null);

        /// <summary>
        /// Get bill payment
        /// 
        /// <remarks>
        /// The *Get bill payment* endpoint returns a single bill payment for a given `billPaymentId`.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">Bill payments</a> are an allocation of money within any customer accounts payable account.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=billPayments">coverage explorer</a> for integrations that support getting a specific bill payment.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetBillPaymentsResponse> GetAsync(GetBillPaymentsRequest? request = null);

        /// <summary>
        /// Get create bill payment model
        /// 
        /// <remarks>
        /// The *Get create bill payment model* endpoint returns the expected data for the request payload when creating a <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">bill payment</a> for a given company and integration.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">Bill payments</a> are an allocation of money within any customer accounts payable account.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// See the *response examples* for integration-specific indicative models.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=billPayments">coverage explorer</a> for integrations that support creating a bill payment.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCreateBillPaymentModelResponse> GetCreateModelAsync(GetCreateBillPaymentModelRequest? request = null);

        /// <summary>
        /// List bill payments
        /// 
        /// <remarks>
        /// The *List bill payments* endpoint returns a list of <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">bill payments</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/sync-for-payables-api#/schemas/BillPayment">Bill payments</a> are an allocation of money within any customer accounts payable account.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        ///     
        /// </remarks>
        /// </summary>
        Task<ListBillPaymentsResponse> ListAsync(ListBillPaymentsRequest? request = null);
    }

    /// <summary>
    /// Bill payments
    /// </summary>
    public class BillPaymentsSDK: IBillPaymentsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "2.2.0";
        private const string _sdkGenVersion = "2.139.1";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.2.0 2.139.1 3.0.0 Codat.Sync.Payables";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public BillPaymentsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<Models.Operations.CreateBillPaymentResponse> CreateAsync(CreateBillPaymentRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/billPayments", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "BillPayment", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new Models.Operations.CreateBillPaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreateBillPaymentResponseValue = JsonConvert.DeserializeObject<Models.Shared.CreateBillPaymentResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<DeleteBillPaymentResponse> DeleteAsync(DeleteBillPaymentRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/billPayments/{billPaymentId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new DeleteBillPaymentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PushOperation = JsonConvert.DeserializeObject<PushOperation>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetBillPaymentsResponse> GetAsync(GetBillPaymentsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/billPayments/{billPaymentId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBillPaymentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.BillPayment = JsonConvert.DeserializeObject<BillPayment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetCreateBillPaymentModelResponse> GetCreateModelAsync(GetCreateBillPaymentModelRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/options/billPayments", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCreateBillPaymentModelResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PushOption = JsonConvert.DeserializeObject<PushOption>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListBillPaymentsResponse> ListAsync(ListBillPaymentsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/data/billPayments", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListBillPaymentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.BillPayments = JsonConvert.DeserializeObject<BillPayments>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 409))
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