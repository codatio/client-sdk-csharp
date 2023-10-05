
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
    public interface ICodatBankFeedsSDK
    {

        /// <summary>
        /// Bank feed bank account mapping.
        /// </summary>
        public IAccountMappingSDK AccountMapping { get; }

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompaniesSDK Companies { get; }

        /// <summary>
        /// Manage your companies&apos; data connections.
        /// </summary>
        public IConnectionsSDK Connections { get; }

        /// <summary>
        /// Source accounts act as a bridge to bank accounts in accounting software.
        /// </summary>
        public ISourceAccountsSDK SourceAccounts { get; }

        /// <summary>
        /// Transactions represent debits and credits from a source account.
        /// </summary>
        public ITransactionsSDK Transactions { get; }
    }
    
    public class SDKConfig
    {
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
    public class CodatBankFeedsSDK: ICodatBankFeedsSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "2.2.0";
        private const string _sdkGenVersion = "2.147.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.2.0 2.147.0 3.0.0 Codat.BankFeeds";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountMappingSDK AccountMapping { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public ISourceAccountsSDK SourceAccounts { get; private set; }
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