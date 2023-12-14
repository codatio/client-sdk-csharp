
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds
{
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;



    /// <summary>
    /// Bank Feeds API: Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting platforms.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// A bank feed is a connection between a source bank account in your application and a target bank account in a supported accounting package.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/bank-feeds-api/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- | :- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Source accounts | Provide and manage lists of source bank accounts.   |<br/>
    /// | Transactions | Create new bank account transactions for a company&apos;s connections, and see previous operations. |<br/>
    /// | Account mapping | Extra functionality for building an account management UI |
    /// </remarks>
    /// </summary>
    public interface ICodatBankFeeds
    {

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompanies Companies { get; }

        /// <summary>
        /// Manage your companies&apos; data connections.
        /// </summary>
        public IConnections Connections { get; }

        /// <summary>
        /// Bank feed bank account mapping.
        /// </summary>
        public IAccountMapping AccountMapping { get; }

        /// <summary>
        /// Source accounts act as a bridge to bank accounts in accounting software.
        /// </summary>
        public ISourceAccounts SourceAccounts { get; }

        /// <summary>
        /// Transactions represent debits and credits from a source account.
        /// </summary>
        public ITransactions Transactions { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "https://api.codat.io",
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public int serverIndex = 0;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    /// <summary>
    /// Bank Feeds API: Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting platforms.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// A bank feed is a connection between a source bank account in your application and a target bank account in a supported accounting package.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/bank-feeds-api/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- | :- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Source accounts | Provide and manage lists of source bank accounts.   |<br/>
    /// | Transactions | Create new bank account transactions for a company&apos;s connections, and see previous operations. |<br/>
    /// | Account mapping | Extra functionality for building an account management UI |
    /// </remarks>
    /// </summary>
    public class CodatBankFeeds: ICodatBankFeeds
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "3.1.0";
        private const string _sdkGenVersion = "2.214.3";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 3.1.0 2.214.3 3.0.0 Codat.BankFeeds";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ICompanies Companies { get; private set; }
        public IConnections Connections { get; private set; }
        public IAccountMapping AccountMapping { get; private set; }
        public ISourceAccounts SourceAccounts { get; private set; }
        public ITransactions Transactions { get; private set; }

        public CodatBankFeeds(Security? security = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            SDKConfiguration = new SDKConfig()
            {
                serverUrl = _serverUrl
            };

            Companies = new Companies(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Connections = new Connections(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            AccountMapping = new AccountMapping(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            SourceAccounts = new SourceAccounts(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Transactions = new Transactions(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}