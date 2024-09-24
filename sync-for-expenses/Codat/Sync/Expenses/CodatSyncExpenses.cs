//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses
{
    using Codat.Sync.Expenses.Hooks;
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Models.Errors;
    using Codat.Sync.Expenses.Utils.Retries;
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
    /// integrations with multiple accounting software through a standardized API.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/sync-for-expenses/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See our OpenAPI spec</a><br/>
    /// <br/>
    /// Not seeing the endpoints you&apos;re expecting? We&apos;ve <a href="https://docs.codat.io/updates/230901-new-products">reorganized our products</a>, and you may be using a <a href="https://docs.codat.io/sync-for-expenses-v1-api#/">different version of Sync for Expenses</a>.<br/>
    /// <br/>
    /// ---<br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Configuration | View and manage mapping configuration and defaults for expense transactions. |<br/>
    /// | Sync | Monitor the status of data syncs. |<br/>
    /// | Expenses | Create and update transactions that represent your customers&apos; spend. |<br/>
    /// | Transfers | Create and update transactions that represent the movement of your customers&apos; money. |<br/>
    /// | Reimbursements | Create and update transactions that represent your customers&apos; repayable spend. |<br/>
    /// | Attachments | Attach receipts to a transaction for a complete audit trail. |<br/>
    /// | Transaction status | Monitor the status of individual transactions in data syncs. |<br/>
    /// | Manage data | Control and monitor the retrieval of data from an integration. |<br/>
    /// | Push operations | View historic push operations. |<br/>
    /// | Accounts | Create accounts and view account schemas. |<br/>
    /// | Customers | Get, create, and update customers. |<br/>
    /// | Suppliers | Get, create, and update suppliers. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public interface ICodatSyncExpenses
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
        /// View and manage mapping configuration and defaults for expense transactions.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Get accounts, trackingCategories and taxRates that can be used in your create and update requests.
        /// </summary>
        public IMappingOptions MappingOptions { get; }

        /// <summary>
        /// Monitor the status of data syncs.
        /// </summary>
        public ISync Sync { get; }

        /// <summary>
        /// Monitor the status of individual transactions in data syncs.
        /// </summary>
        public ITransactionStatus TransactionStatus { get; }

        /// <summary>
        /// Create and update transactions that represent your customers&apos; spend.
        /// </summary>
        public IExpenses Expenses { get; }

        /// <summary>
        /// Create and update transactions that represent the movement of your customers&apos; money.
        /// </summary>
        public ITransfers Transfers { get; }

        /// <summary>
        /// Create transactions that represent your adjustments to your customers&apos; spend.
        /// </summary>
        public IAdjustments Adjustments { get; }

        /// <summary>
        /// Create and update transactions that represent your customers&apos; repayable spend.
        /// </summary>
        public IReimbursements Reimbursements { get; }

        /// <summary>
        /// Attach receipts to a transaction for a complete audit trail.
        /// </summary>
        public IAttachments Attachments { get; }

        /// <summary>
        /// Control and monitor the retrieval of data from an integration.
        /// </summary>
        public IManageData ManageData { get; }

        /// <summary>
        /// View historic push operations.
        /// </summary>
        public IPushOperations PushOperations { get; }

        /// <summary>
        /// Create accounts and view create account options.
        /// </summary>
        public IAccounts Accounts { get; }

        /// <summary>
        /// Create bank accounts and view create bank account options.
        /// </summary>
        public IBankAccounts BankAccounts { get; }

        /// <summary>
        /// Get, create, and update customers.
        /// </summary>
        public ICustomers Customers { get; }

        /// <summary>
        /// Get, create, and update suppliers.
        /// </summary>
        public ISuppliers Suppliers { get; }
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
    /// Sync for Expenses: The API for Sync for Expenses.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Expenses is an API and a set of supporting tools. It has been built to<br/>
    /// enable corporate card and expense management platforms to provide high-quality<br/>
    /// integrations with multiple accounting software through a standardized API.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/sync-for-expenses/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See our OpenAPI spec</a><br/>
    /// <br/>
    /// Not seeing the endpoints you&apos;re expecting? We&apos;ve <a href="https://docs.codat.io/updates/230901-new-products">reorganized our products</a>, and you may be using a <a href="https://docs.codat.io/sync-for-expenses-v1-api#/">different version of Sync for Expenses</a>.<br/>
    /// <br/>
    /// ---<br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Configuration | View and manage mapping configuration and defaults for expense transactions. |<br/>
    /// | Sync | Monitor the status of data syncs. |<br/>
    /// | Expenses | Create and update transactions that represent your customers&apos; spend. |<br/>
    /// | Transfers | Create and update transactions that represent the movement of your customers&apos; money. |<br/>
    /// | Reimbursements | Create and update transactions that represent your customers&apos; repayable spend. |<br/>
    /// | Attachments | Attach receipts to a transaction for a complete audit trail. |<br/>
    /// | Transaction status | Monitor the status of individual transactions in data syncs. |<br/>
    /// | Manage data | Control and monitor the retrieval of data from an integration. |<br/>
    /// | Push operations | View historic push operations. |<br/>
    /// | Accounts | Create accounts and view account schemas. |<br/>
    /// | Customers | Get, create, and update customers. |<br/>
    /// | Suppliers | Get, create, and update suppliers. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public class CodatSyncExpenses: ICodatSyncExpenses
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "6.1.0";
        private const string _sdkGenVersion = "2.422.6";
        private const string _openapiDocVersion = "prealpha";
        private const string _userAgent = "speakeasy-sdk/csharp 6.1.0 2.422.6 prealpha Codat.Sync.Expenses";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Sync.Expenses.Models.Components.Security>? _securitySource;
        public ICompanies Companies { get; private set; }
        public IConnections Connections { get; private set; }
        public IConfiguration Configuration { get; private set; }
        public IMappingOptions MappingOptions { get; private set; }
        public ISync Sync { get; private set; }
        public ITransactionStatus TransactionStatus { get; private set; }
        public IExpenses Expenses { get; private set; }
        public ITransfers Transfers { get; private set; }
        public IAdjustments Adjustments { get; private set; }
        public IReimbursements Reimbursements { get; private set; }
        public IAttachments Attachments { get; private set; }
        public IManageData ManageData { get; private set; }
        public IPushOperations PushOperations { get; private set; }
        public IAccounts Accounts { get; private set; }
        public IBankAccounts BankAccounts { get; private set; }
        public ICustomers Customers { get; private set; }
        public ISuppliers Suppliers { get; private set; }

        public CodatSyncExpenses(string? authHeader = null, Func<string>? authHeaderSource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
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

            if(authHeaderSource != null)
            {
                _securitySource = () => new Codat.Sync.Expenses.Models.Components.Security() { AuthHeader = authHeaderSource() };
            }
            else if(authHeader != null)
            {
                _securitySource = () => new Codat.Sync.Expenses.Models.Components.Security() { AuthHeader = authHeader };
            }
            else
            {
                throw new Exception("authHeader and authHeaderSource cannot both be null");
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


            MappingOptions = new MappingOptions(_client, _securitySource, _serverUrl, SDKConfiguration);


            Sync = new Sync(_client, _securitySource, _serverUrl, SDKConfiguration);


            TransactionStatus = new TransactionStatus(_client, _securitySource, _serverUrl, SDKConfiguration);


            Expenses = new Expenses(_client, _securitySource, _serverUrl, SDKConfiguration);


            Transfers = new Transfers(_client, _securitySource, _serverUrl, SDKConfiguration);


            Adjustments = new Adjustments(_client, _securitySource, _serverUrl, SDKConfiguration);


            Reimbursements = new Reimbursements(_client, _securitySource, _serverUrl, SDKConfiguration);


            Attachments = new Attachments(_client, _securitySource, _serverUrl, SDKConfiguration);


            ManageData = new ManageData(_client, _securitySource, _serverUrl, SDKConfiguration);


            PushOperations = new PushOperations(_client, _securitySource, _serverUrl, SDKConfiguration);


            Accounts = new Accounts(_client, _securitySource, _serverUrl, SDKConfiguration);


            BankAccounts = new BankAccounts(_client, _securitySource, _serverUrl, SDKConfiguration);


            Customers = new Customers(_client, _securitySource, _serverUrl, SDKConfiguration);


            Suppliers = new Suppliers(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}