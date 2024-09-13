//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds
{
    using Codat.BankFeeds.Hooks;
    using Codat.BankFeeds.Models.Errors;
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils.Retries;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Bank Feeds API: Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting software.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// A bank feed is a connection between a source bank account in your application and a target bank account in a supported accounting software.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/bank-feeds-api/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Source accounts | Provide and manage lists of source bank accounts. |<br/>
    /// | Account mapping | Extra functionality for building an account management UI. |<br/>
    /// | Company information | Get detailed information about a company from the underlying platform. |<br/>
    /// | Transactions | Create new bank account transactions for a company&apos;s connections, and see previous operations. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public interface ICodatBankFeeds
    {

        /// <summary>
        /// Create and manage your SMB users&apos; companies.
        /// </summary>
        public ICompanies Companies { get; }

        /// <summary>
        /// Create new and manage existing data connections for a company.
        /// </summary>
        public IConnections Connections { get; }

        /// <summary>
        /// Configure bank feeds for a company.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Monitor the status of data syncs.
        /// </summary>
        public ISync Sync { get; }

        /// <summary>
        /// Access bank accounts in an SMBs accounting software.
        /// </summary>
        public IBankAccounts BankAccounts { get; }

        /// <summary>
        /// Provide and manage lists of source bank accounts.
        /// </summary>
        public ISourceAccounts SourceAccounts { get; }

        /// <summary>
        /// Extra functionality for building an account management UI.
        /// </summary>
        public IAccountMapping AccountMapping { get; }

        /// <summary>
        /// Get detailed information about a company from the underlying accounting software.
        /// </summary>
        public ICompanyInformation CompanyInformation { get; }

        /// <summary>
        /// Create new bank account transactions for a company&apos;s connections, and see previous operations.
        /// </summary>
        public ITransactions Transactions { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.codat.io",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Bank Feeds API: Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting software.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// A bank feed is a connection between a source bank account in your application and a target bank account in a supported accounting software.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/bank-feeds-api/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Source accounts | Provide and manage lists of source bank accounts. |<br/>
    /// | Account mapping | Extra functionality for building an account management UI. |<br/>
    /// | Company information | Get detailed information about a company from the underlying platform. |<br/>
    /// | Transactions | Create new bank account transactions for a company&apos;s connections, and see previous operations. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public class CodatBankFeeds: ICodatBankFeeds
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "4.5.0";
        private const string _sdkGenVersion = "2.415.6";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 4.5.0 2.415.6 3.0.0 Codat.BankFeeds";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<Codat.BankFeeds.Models.Shared.Security>? _securitySource;
        public ICompanies Companies { get; private set; }
        public IConnections Connections { get; private set; }
        public IConfiguration Configuration { get; private set; }
        public ISync Sync { get; private set; }
        public IBankAccounts BankAccounts { get; private set; }
        public ISourceAccounts SourceAccounts { get; private set; }
        public IAccountMapping AccountMapping { get; private set; }
        public ICompanyInformation CompanyInformation { get; private set; }
        public ITransactions Transactions { get; private set; }

        public CodatBankFeeds(Codat.BankFeeds.Models.Shared.Security? security = null, Func<Codat.BankFeeds.Models.Shared.Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _client = client ?? new SpeakeasyHttpClient();

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }
            else
            {
                throw new Exception("security and securitySource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            Companies = new Companies(_client, _securitySource, _serverUrl, SDKConfiguration);


            Connections = new Connections(_client, _securitySource, _serverUrl, SDKConfiguration);


            Configuration = new Configuration(_client, _securitySource, _serverUrl, SDKConfiguration);


            Sync = new Sync(_client, _securitySource, _serverUrl, SDKConfiguration);


            BankAccounts = new BankAccounts(_client, _securitySource, _serverUrl, SDKConfiguration);


            SourceAccounts = new SourceAccounts(_client, _securitySource, _serverUrl, SDKConfiguration);


            AccountMapping = new AccountMapping(_client, _securitySource, _serverUrl, SDKConfiguration);


            CompanyInformation = new CompanyInformation(_client, _securitySource, _serverUrl, SDKConfiguration);


            Transactions = new Transactions(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}