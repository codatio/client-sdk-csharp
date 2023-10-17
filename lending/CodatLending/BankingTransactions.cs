
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending
{
    using CodatLending.Models.Operations;
    using CodatLending.Models.Shared;
    using CodatLending.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IBankingTransactionsSDK
    {

        /// <summary>
        /// Get bank transaction
        /// 
        /// <remarks>
        /// The *Get transaction* endpoint returns a single transaction for a given transactionId.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending-api#/schemas/Transaction">Transactions</a> provide an immutable source of up-to-date information on income and expenditure.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/banking?view=tab-by-data-type&amp;dataType=banking-transactions">coverage explorer</a> for integrations that support getting a specific transaction.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/lending-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetBankingTransactionResponse> GetAsync(GetBankingTransactionRequest? request = null);

        /// <summary>
        /// List transactions
        /// 
        /// <remarks>
        /// The *List transactions* endpoint returns a list of <a href="https://docs.codat.io/lending-api#/schemas/Transaction">transactions</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending-api#/schemas/Transaction">Transactions</a> provide an immutable source of up-to-date information on income and expenditure.<br/>
        /// <br/>
        /// Before using this endpoint, you must have <a href="https://docs.codat.io/lending-api#/operations/refresh-company-data">retrieved data for the company</a>.<br/>
        ///     
        /// </remarks>
        /// </summary>
        Task<ListBankingTransactionsResponse> ListAsync(ListBankingTransactionsRequest? request = null);
    }

    public class BankingTransactionsSDK: IBankingTransactionsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.3.0";
        private const string _sdkGenVersion = "2.159.2";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 4.3.0 2.159.2 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public BankingTransactionsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<GetBankingTransactionResponse> GetAsync(GetBankingTransactionRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-transactions/{transactionId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBankingTransactionResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.BankingTransaction = JsonConvert.DeserializeObject<BankingTransaction>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<ListBankingTransactionsResponse> ListAsync(ListBankingTransactionsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-transactions", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListBankingTransactionsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.BankingTransactions = JsonConvert.DeserializeObject<BankingTransactions>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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