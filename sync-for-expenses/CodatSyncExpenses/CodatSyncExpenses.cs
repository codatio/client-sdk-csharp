
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses
{
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Sync for Expenses: The API for Sync for Expenses.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Expenses is an API and a set of supporting tools. It has been built to<br/>
    /// enable corporate card and expense management platforms to provide high-quality<br/>
    /// integrations with multiple accounting platforms through a standardized API.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/sync-for-expenses/overview">Read more...</a><br/>
    /// <br/>
    /// <a href="https://github.com/codatio/oas">See our OpenAPI spec</a><br/>
    /// <br/>
    /// Not seeing the endpoints you&apos;re expecting? We&apos;ve <a href="https://docs.codat.io/updates/230901-new-products">reorganized our products</a>, and you may be using a <a href="https://docs.codat.io/sync-for-expenses-v1-api#/">different version of Sync for Expenses</a>.
    /// </remarks>
    /// </summary>
    public interface ICodatSyncExpenses
    {

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompanies Companies { get; }

        /// <summary>
        /// Create and manage partner expense connection.
        /// </summary>
        public IConnections Connections { get; }

        /// <summary>
        /// Accounts
        /// </summary>
        public IAccounts Accounts { get; }

        /// <summary>
        /// Customers
        /// </summary>
        public ICustomers Customers { get; }

        /// <summary>
        /// Suppliers
        /// </summary>
        public ISuppliers Suppliers { get; }

        /// <summary>
        /// Asynchronously retrieve data from an integration to refresh data in Codat.
        /// </summary>
        public IManageData ManageData { get; }

        /// <summary>
        /// Access create, update and delete operations made to an SMB&apos;s data connection.
        /// </summary>
        public IPushOperations PushOperations { get; }

        /// <summary>
        /// Manage mapping options and sync configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Create expense datasets and upload receipts.
        /// </summary>
        public IExpenses Expenses { get; }

        /// <summary>
        /// Trigger and monitor expense syncs to accounting software.
        /// </summary>
        public ISync Sync { get; }

        /// <summary>
        /// Retrieve the status of transactions within a sync.
        /// </summary>
        public ITransactionStatus TransactionStatus { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.codat.io",
        };

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
    /// Sync for Expenses: The API for Sync for Expenses.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Expenses is an API and a set of supporting tools. It has been built to<br/>
    /// enable corporate card and expense management platforms to provide high-quality<br/>
    /// integrations with multiple accounting platforms through a standardized API.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/sync-for-expenses/overview">Read more...</a><br/>
    /// <br/>
    /// <a href="https://github.com/codatio/oas">See our OpenAPI spec</a><br/>
    /// <br/>
    /// Not seeing the endpoints you&apos;re expecting? We&apos;ve <a href="https://docs.codat.io/updates/230901-new-products">reorganized our products</a>, and you may be using a <a href="https://docs.codat.io/sync-for-expenses-v1-api#/">different version of Sync for Expenses</a>.
    /// </remarks>
    /// </summary>
    public class CodatSyncExpenses: ICodatSyncExpenses
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "5.2.0";
        private const string _sdkGenVersion = "2.286.2";
        private const string _openapiDocVersion = "prealpha";
        private const string _userAgent = "speakeasy-sdk/csharp 5.2.0 2.286.2 prealpha Codat.Sync.Expenses";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public ICompanies Companies { get; private set; }
        public IConnections Connections { get; private set; }
        public IAccounts Accounts { get; private set; }
        public ICustomers Customers { get; private set; }
        public ISuppliers Suppliers { get; private set; }
        public IManageData ManageData { get; private set; }
        public IPushOperations PushOperations { get; private set; }
        public IConfiguration Configuration { get; private set; }
        public IExpenses Expenses { get; private set; }
        public ISync Sync { get; private set; }
        public ITransactionStatus TransactionStatus { get; private set; }

        public CodatSyncExpenses(Security? security = null, Func<Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
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

            _defaultClient = new SpeakeasyHttpClient(client);

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
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            Companies = new Companies(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Connections = new Connections(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Accounts = new Accounts(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Customers = new Customers(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Suppliers = new Suppliers(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            ManageData = new ManageData(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            PushOperations = new PushOperations(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Configuration = new Configuration(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Expenses = new Expenses(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Sync = new Sync(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            TransactionStatus = new TransactionStatus(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}
