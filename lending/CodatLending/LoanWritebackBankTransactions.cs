
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

    public interface ILoanWritebackBankTransactionsSDK
    {

        /// <summary>
        /// Create bank account transactions
        /// 
        /// <remarks>
        /// The *Create bank account transactions* endpoint creates new <a href="https://docs.codat.io/lending-api#/schemas/BankTransactions">bank account transactions</a> for a given company&apos;s connection.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending-api#/schemas/BankTransactions">Bank account transactions</a> are records of money that has moved in and out of an SMB&apos;s bank account.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// Required data may vary by integration. To see what data to post, first call <a href="https://docs.codat.io/lending-api#/operations/get-create-bankTransactions-model">Get create bank transaction model</a>.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=bankTransactions">coverage explorer</a> for integrations that support creating a bank account transactions.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<CreateBankTransactionsResponse> CreateAsync(CreateBankTransactionsRequest? request = null);

        /// <summary>
        /// Get create bank account transactions model
        /// 
        /// <remarks>
        /// The *Get create bank account transactions model* endpoint returns the expected data for the request payload when creating <a href="https://docs.codat.io/lending-api#/schemas/BankTransactions">bank account transactions</a> for a given company and integration.<br/>
        /// <br/>
        /// <a href="https://docs.codat.io/lending-api#/schemas/BankTransactions">Bank account transactions</a> are records of money that has moved in and out of an SMB&apos;s bank account.<br/>
        /// <br/>
        /// **Integration-specific behaviour**<br/>
        /// <br/>
        /// See the *response examples* for integration-specific indicative models.<br/>
        /// <br/>
        /// Check out our <a href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=bankTransactions">coverage explorer</a> for integrations that support creating an bank transaction.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetCreateBankTransactionsModelResponse> GetCreateModelAsync(GetCreateBankTransactionsModelRequest? request = null);
    }

    public class LoanWritebackBankTransactionsSDK: ILoanWritebackBankTransactionsSDK
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

        public LoanWritebackBankTransactionsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<CreateBankTransactionsResponse> CreateAsync(CreateBankTransactionsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/push/bankAccounts/{accountId}/bankTransactions", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "AccountingCreateBankTransactions", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new CreateBankTransactionsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.AccountingCreateBankTransactionsResponse = JsonConvert.DeserializeObject<AccountingCreateBankTransactionsResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
        

        public async Task<GetCreateBankTransactionsModelResponse> GetCreateModelAsync(GetCreateBankTransactionsModelRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/options/bankAccounts/{accountId}/bankTransactions", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCreateBankTransactionsModelResponse
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
        
    }
}