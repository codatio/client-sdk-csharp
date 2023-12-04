
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

    public interface ICategorizedStatement
    {

        /// <summary>
        /// Get categorized bank statement
        /// 
        /// <remarks>
        /// &gt; **Categorization engine**<br/>
        /// &gt;<br/>
        /// &gt; The categorization engine uses machine learning and has been fully trained against Plaid and TrueLayer banking data sources. It is not fully trained against the Basiq banking data source.<br/>
        /// <br/>
        /// The _Get categorized bank statement_ endpoint provides a fully categorized list of banking transactions for a company. Accounts and transaction data are obtained from the company&apos;s banking data sources.
        /// </remarks>
        /// </summary>
        Task<GetCategorizedBankStatementResponse> GetAsync(GetCategorizedBankStatementRequest? request = null);
    }

    public class CategorizedStatement: ICategorizedStatement
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.1";
        private const string _sdkGenVersion = "2.209.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.1 2.209.0 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public CategorizedStatement(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetCategorizedBankStatementResponse> GetAsync(GetCategorizedBankStatementRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/reports/enhancedCashFlow/transactions", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetCategorizedBankStatementResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.EnhancedCashFlowTransactions = JsonConvert.DeserializeObject<EnhancedCashFlowTransactions>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 402) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 429) || (response.StatusCode == 500) || (response.StatusCode == 503))
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