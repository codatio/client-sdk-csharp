
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

    public interface IBankingSDK
    {
        Task<GetBankingAccountResponse> GetBankAccountAsync(GetBankingAccountRequest? request = null);
        Task<GetBankingTransactionResponse> GetBankTransactionAsync(GetBankingTransactionRequest? request = null);
        Task<GetBankingTransactionCategoryResponse> GetBankTransactionCategoryAsync(GetBankingTransactionCategoryRequest? request = null);
        Task<GetCategorizedBankStatementResponse> GetCategorizedBankStatementAsync(GetCategorizedBankStatementRequest? request = null);
        Task<ListBankingAccountBalancesResponse> ListBankAccountBalancesAsync(ListBankingAccountBalancesRequest? request = null);
        Task<ListBankingAccountsResponse> ListBankAccountsAsync(ListBankingAccountsRequest? request = null);
        Task<ListBankingTransactionCategoriesResponse> ListBankTransactionCategoriesAsync(ListBankingTransactionCategoriesRequest? request = null);
        Task<ListBankingTransactionsResponse> ListBankTransactionsAsync(ListBankingTransactionsRequest? request = null);
    }

    public class BankingSDK: IBankingSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.3.1";
        private const string _sdkGenVersion = "2.107.3";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public BankingSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        /// <summary>
        /// Get account
        /// 
        /// <remarks>
        /// The *Get account* endpoint returns a single account for a given accountId.
        /// 
        /// [Accounts](https://docs.codat.io/banking-api#/schemas/Account) are financial accounts maintained by a bank or other financial institution.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/banking?view=tab-by-data-type&dataType=banking-accounts) for integrations that support getting a specific account.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetBankingAccountResponse> GetBankAccountAsync(GetBankingAccountRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-accounts/{accountId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBankingAccountResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.BankingAccount = JsonConvert.DeserializeObject<BankingAccount>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// Get bank transaction
        /// 
        /// <remarks>
        /// The *Get transaction* endpoint returns a single transaction for a given transactionId.
        /// 
        /// [Transactions](https://docs.codat.io/banking-api#/schemas/Transaction) provide an immutable source of up-to-date information on income and expenditure.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/banking?view=tab-by-data-type&dataType=banking-transactions) for integrations that support getting a specific transaction.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetBankingTransactionResponse> GetBankTransactionAsync(GetBankingTransactionRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-transactions/{transactionId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
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
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.BankingTransaction = JsonConvert.DeserializeObject<BankingTransaction>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// Get transaction category
        /// 
        /// <remarks>
        /// The *Get transaction category* endpoint returns a single transaction category for a given transactionCategoryId.
        /// 
        /// [Transaction categories](https://docs.codat.io/banking-api#/schemas/TransactionCategory) are associated with a transaction to provide greater contextual meaning to transaction activity.
        /// 
        /// Check out our [coverage explorer](https://knowledge.codat.io/supported-features/banking?view=tab-by-data-type&dataType=banking-transactionCategories) for integrations that support getting a specific transaction category.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
        /// 
        /// </remarks>
        /// </summary>
        public async Task<GetBankingTransactionCategoryResponse> GetBankTransactionCategoryAsync(GetBankingTransactionCategoryRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-transactionCategories/{transactionCategoryId}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBankingTransactionCategoryResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.BankingTransactionCategory = JsonConvert.DeserializeObject<BankingTransactionCategory>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// Get categorized bank statement
        /// 
        /// <remarks>
        /// > **Categorization engine**
        /// > 
        /// > The categorization engine uses machine learning and has been fully trained against Plaid and TrueLayer banking data sources. It is not fully trained against the Basiq banking data source.
        /// 
        /// The _Get categorized bank statement_ endpoint provides a fully categorized list of banking transactions for a company. Accounts and transaction data are obtained from the company's banking data sources.
        /// </remarks>
        /// </summary>
        public async Task<GetCategorizedBankStatementResponse> GetCategorizedBankStatementAsync(GetCategorizedBankStatementRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/reports/enhancedCashFlow/transactions", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
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
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.EnhancedCashFlowTransactions = JsonConvert.DeserializeObject<EnhancedCashFlowTransactions>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401) || (response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.ErrorMessage = JsonConvert.DeserializeObject<ErrorMessage>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        /// <summary>
        /// List account balances
        /// 
        /// <remarks>
        /// The *List account balances* endpoint returns a list of [account balances](https://docs.codat.io/banking-api#/schemas/AccountBalance) for a given company's connection.
        /// 
        /// [Account balances](https://docs.codat.io/banking-api#/schemas/AccountBalance) are balances for a bank account, including end-of-day batch balance or running balances per transaction.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
        ///     
        /// </remarks>
        /// </summary>
        public async Task<ListBankingAccountBalancesResponse> ListBankAccountBalancesAsync(ListBankingAccountBalancesRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-accountBalances", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListBankingAccountBalancesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.BankingAccountBalances = JsonConvert.DeserializeObject<BankingAccountBalances>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        /// <summary>
        /// List accounts
        /// 
        /// <remarks>
        /// The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/banking-api#/schemas/Account) for a given company's connection.
        /// 
        /// [Accounts](https://docs.codat.io/banking-api#/schemas/Account) are financial accounts maintained by a bank or other financial institution.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
        ///     
        /// </remarks>
        /// </summary>
        public async Task<ListBankingAccountsResponse> ListBankAccountsAsync(ListBankingAccountsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-accounts", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListBankingAccountsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.BankingAccounts = JsonConvert.DeserializeObject<BankingAccounts>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        /// <summary>
        /// List transaction categories
        /// 
        /// <remarks>
        /// The *List transaction categories* endpoint returns a list of [transaction categories](https://docs.codat.io/banking-api#/schemas/TransactionCategory) for a given company's connection.
        /// 
        /// [Transaction categories](https://docs.codat.io/banking-api#/schemas/TransactionCategory) are associated with a transaction to provide greater contextual meaning to transaction activity.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
        ///     
        /// </remarks>
        /// </summary>
        public async Task<ListBankingTransactionCategoriesResponse> ListBankTransactionCategoriesAsync(ListBankingTransactionCategoriesRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-transactionCategories", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListBankingTransactionCategoriesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.BankingTransactionCategories = JsonConvert.DeserializeObject<BankingTransactionCategories>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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
        

        /// <summary>
        /// List transactions
        /// 
        /// <remarks>
        /// The *List transactions* endpoint returns a list of [transactions](https://docs.codat.io/banking-api#/schemas/Transaction) for a given company's connection.
        /// 
        /// [Transactions](https://docs.codat.io/banking-api#/schemas/Transaction) provide an immutable source of up-to-date information on income and expenditure.
        /// 
        /// Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
        ///     
        /// </remarks>
        /// </summary>
        public async Task<ListBankingTransactionsResponse> ListBankTransactionsAsync(ListBankingTransactionsRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/companies/{companyId}/connections/{connectionId}/data/banking-transactions", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            
            
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
                if(Utilities.IsContentTypeMatch("application/json", response.ContentType))
                {
                    response.BankingTransactions = JsonConvert.DeserializeObject<BankingTransactions>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
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