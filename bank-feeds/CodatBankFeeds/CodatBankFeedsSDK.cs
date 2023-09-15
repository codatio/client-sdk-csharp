
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds
{
    using CodatBankFeeds.Models.Shared;
    using CodatBankFeeds.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatBankFeedsSDK
    {
        public IAccountMappingSDK AccountMapping { get; }
        public ICompaniesSDK Companies { get; }
        public IConnectionsSDK Connections { get; }
        public ISourceAccountsSDK SourceAccounts { get; }
        public ITransactionsSDK Transactions { get; }
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// Bank Feeds API: Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting platforms.
    /// 
    /// <remarks>
    /// 
    /// A bank feed is a connection between a source bank account in your application and a target bank account in a supported accounting package.
    /// 
    /// [Explore product](https://docs.codat.io/bank-feeds-api/overview) | [See OpenAPI spec](https://github.com/codatio/oas)
    /// 
    /// ---
    /// 
    /// ## Endpoints
    /// 
    /// | Endpoints | Description |
    /// | :- | :- |
    /// | Companies | Create and manage your SMB users' companies. |
    /// | Connections | Create new and manage existing data connections for a company. |
    /// | Source accounts | Provide and manage lists of source bank accounts.   |
    /// | Transactions | Create new bank account transactions for a company's connections, and see previous operations. |
    /// | Account mapping | Extra functionality for building an account management UI |
    /// </remarks>
    /// </summary>
    public class CodatBankFeedsSDK: ICodatBankFeedsSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.8.0";
        private const string _sdkGenVersion = "2.113.0";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        /// <summary>
        /// Bank feed bank account mapping.
        /// </summary>
        public IAccountMappingSDK AccountMapping { get; private set; }
        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompaniesSDK Companies { get; private set; }
        /// <summary>
        /// Manage your companies' data connections.
        /// </summary>
        public IConnectionsSDK Connections { get; private set; }
        /// <summary>
        /// Source accounts act as a bridge to bank accounts in accounting software.
        /// </summary>
        public ISourceAccountsSDK SourceAccounts { get; private set; }
        /// <summary>
        /// Transactions represent debits and credits from a source account.
        /// </summary>
        public ITransactionsSDK Transactions { get; private set; }

        public CodatBankFeedsSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatBankFeedsSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            AccountMapping = new AccountMappingSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            SourceAccounts = new SourceAccountsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Transactions = new TransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}