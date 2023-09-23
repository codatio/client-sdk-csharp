
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses
{
    using CodatSyncExpenses.Models.Shared;
    using CodatSyncExpenses.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Sync for Expenses: The API for Sync for Expenses.&lt;br/&gt;
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
    /// Not seeing the endpoints you&apos;re expecting? We&apos;ve <a href="https://docs.codat.io/updates/230901-new-products">reorganized our products</a>, and you may be using a <a href="https://docs.codat.io/sync-for-expenses-v1-api#/">different version of Sync for Commerce</a>.
    /// </remarks>
    /// </summary>
    public interface ICodatSyncExpensesSDK
    {

        /// <summary>
        /// Accounts
        /// </summary>
        public IAccountsSDK Accounts { get; }

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompaniesSDK Companies { get; }

        /// <summary>
        /// Manage mapping options and sync configuration.
        /// </summary>
        public IConfigurationSDK Configuration { get; }

        /// <summary>
        /// Create and manage partner expense connection.
        /// </summary>
        public IConnectionsSDK Connections { get; }

        /// <summary>
        /// Customers
        /// </summary>
        public ICustomersSDK Customers { get; }

        /// <summary>
        /// Create expense datasets and upload receipts.
        /// </summary>
        public IExpensesSDK Expenses { get; }

        /// <summary>
        /// Asynchronously retrieve data from an integration to refresh data in Codat.
        /// </summary>
        public IManageDataSDK ManageData { get; }

        /// <summary>
        /// Access create, update and delete operations made to an SMB&amp;apos;s data connection.
        /// </summary>
        public IPushOperationsSDK PushOperations { get; }

        /// <summary>
        /// Suppliers
        /// </summary>
        public ISuppliersSDK Suppliers { get; }

        /// <summary>
        /// Trigger and monitor expense syncs to accounting software.
        /// </summary>
        public ISyncSDK Sync { get; }

        /// <summary>
        /// Retrieve the status of transactions within a sync.
        /// </summary>
        public ITransactionStatusSDK TransactionStatus { get; }
    }
    
    public class SDKConfig
    {
    }

    public class CodatSyncExpensesSDK: ICodatSyncExpensesSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "1.1.2";
        private const string _sdkGenVersion = "2.125.1";
        private const string _openapiDocVersion = "prealpha";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountsSDK Accounts { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public IConfigurationSDK Configuration { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public ICustomersSDK Customers { get; private set; }
        public IExpensesSDK Expenses { get; private set; }
        public IManageDataSDK ManageData { get; private set; }
        public IPushOperationsSDK PushOperations { get; private set; }
        public ISuppliersSDK Suppliers { get; private set; }
        public ISyncSDK Sync { get; private set; }
        public ITransactionStatusSDK TransactionStatus { get; private set; }

        public CodatSyncExpensesSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatSyncExpensesSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            Accounts = new AccountsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Configuration = new ConfigurationSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Customers = new CustomersSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Expenses = new ExpensesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManageData = new ManageDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PushOperations = new PushOperationsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Suppliers = new SuppliersSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Sync = new SyncSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TransactionStatus = new TransactionStatusSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}