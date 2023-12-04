
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables
{
    using Codat.Sync.Payables.Models.Shared;
    using Codat.Sync.Payables.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;



    /// <summary>
    /// Sync for Payables: The API for Sync for Payables. <br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Payables is an API and a set of supporting tools built to help integrate with your customers&apos; accounting software, and keep their supplier information, invoices, and payments in sync.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/payables/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints            | Description                                                                                                |<br/>
    /// |:---------------------|:-----------------------------------------------------------------------------------------------------------|<br/>
    /// | Companies            | Create and manage your SMB users&apos; companies.                                                               |<br/>
    /// | Connections          | Create new and manage existing data connections for a company.                                             |<br/>
    /// | Accounts             | Get, create, and update Accounts                                                           |<br/>
    /// | Bills                | Get, create, and update Bills                                                                          |<br/>
    /// | Bill credit notes    | Get, create, and update Bill credit notes                                                              |<br/>
    /// | Bill payments        | Get, create, and update Bill payments                                                                  |<br/>
    /// | Journals             | Get, create, and update Journals                                                                       |<br/>
    /// | Journal entries      | Get, create, and update Journal entries                                                                |<br/>
    /// | Payment methods      | Get, create, and update Payment methods                                                                |<br/>
    /// | Suppliers            | Get, create, and update Suppliers                                                                      |<br/>
    /// | Tax rates            | Get, create, and update Tax rates                                                                      |<br/>
    /// | Tracking categories  | Get, create, and update Tracking categories                                                            |<br/>
    /// | Push operations      | View historic push operations                                                         |<br/>
    /// | Company info         | View company profile from the source platform.                                                             |<br/>
    /// | Manage data          | Control how data is retrieved from an integration.                                                         |
    /// </remarks>
    /// </summary>
    public interface ICodatSyncPayables
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
        /// Bills
        /// </summary>
        public IBills Bills { get; }

        /// <summary>
        /// Bill credit notes
        /// </summary>
        public IBillCreditNotes BillCreditNotes { get; }

        /// <summary>
        /// Bill payments
        /// </summary>
        public IBillPayments BillPayments { get; }

        /// <summary>
        /// Accounts
        /// </summary>
        public IAccounts Accounts { get; }

        /// <summary>
        /// Journal entries
        /// </summary>
        public IJournalEntries JournalEntries { get; }

        /// <summary>
        /// Journals
        /// </summary>
        public IJournals Journals { get; }

        /// <summary>
        /// Suppliers
        /// </summary>
        public ISuppliers Suppliers { get; }

        /// <summary>
        /// Asynchronously retrieve data from an integration to refresh data in Codat.
        /// </summary>
        public IManageData ManageData { get; }

        /// <summary>
        /// View company information fetched from the source platform.
        /// </summary>
        public ICompanyInfo CompanyInfo { get; }

        /// <summary>
        /// Payment methods
        /// </summary>
        public IPaymentMethods PaymentMethods { get; }

        /// <summary>
        /// Tax rates
        /// </summary>
        public ITaxRates TaxRates { get; }

        /// <summary>
        /// Tracking categories
        /// </summary>
        public ITrackingCategories TrackingCategories { get; }

        /// <summary>
        /// Access create, update and delete operations made to an SMB&apos;s data connection.
        /// </summary>
        public IPushOperations PushOperations { get; }
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
    /// Sync for Payables: The API for Sync for Payables. <br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Sync for Payables is an API and a set of supporting tools built to help integrate with your customers&apos; accounting software, and keep their supplier information, invoices, and payments in sync.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/payables/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints            | Description                                                                                                |<br/>
    /// |:---------------------|:-----------------------------------------------------------------------------------------------------------|<br/>
    /// | Companies            | Create and manage your SMB users&apos; companies.                                                               |<br/>
    /// | Connections          | Create new and manage existing data connections for a company.                                             |<br/>
    /// | Accounts             | Get, create, and update Accounts                                                           |<br/>
    /// | Bills                | Get, create, and update Bills                                                                          |<br/>
    /// | Bill credit notes    | Get, create, and update Bill credit notes                                                              |<br/>
    /// | Bill payments        | Get, create, and update Bill payments                                                                  |<br/>
    /// | Journals             | Get, create, and update Journals                                                                       |<br/>
    /// | Journal entries      | Get, create, and update Journal entries                                                                |<br/>
    /// | Payment methods      | Get, create, and update Payment methods                                                                |<br/>
    /// | Suppliers            | Get, create, and update Suppliers                                                                      |<br/>
    /// | Tax rates            | Get, create, and update Tax rates                                                                      |<br/>
    /// | Tracking categories  | Get, create, and update Tracking categories                                                            |<br/>
    /// | Push operations      | View historic push operations                                                         |<br/>
    /// | Company info         | View company profile from the source platform.                                                             |<br/>
    /// | Manage data          | Control how data is retrieved from an integration.                                                         |
    /// </remarks>
    /// </summary>
    public class CodatSyncPayables: ICodatSyncPayables
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "3.0.1";
        private const string _sdkGenVersion = "2.209.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 3.0.1 2.209.0 3.0.0 Codat.Sync.Payables";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ICompanies Companies { get; private set; }
        public IConnections Connections { get; private set; }
        public IBills Bills { get; private set; }
        public IBillCreditNotes BillCreditNotes { get; private set; }
        public IBillPayments BillPayments { get; private set; }
        public IAccounts Accounts { get; private set; }
        public IJournalEntries JournalEntries { get; private set; }
        public IJournals Journals { get; private set; }
        public ISuppliers Suppliers { get; private set; }
        public IManageData ManageData { get; private set; }
        public ICompanyInfo CompanyInfo { get; private set; }
        public IPaymentMethods PaymentMethods { get; private set; }
        public ITaxRates TaxRates { get; private set; }
        public ITrackingCategories TrackingCategories { get; private set; }
        public IPushOperations PushOperations { get; private set; }

        public CodatSyncPayables(Security? security = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
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
            Bills = new Bills(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            BillCreditNotes = new BillCreditNotes(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            BillPayments = new BillPayments(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Accounts = new Accounts(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            JournalEntries = new JournalEntries(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Journals = new Journals(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Suppliers = new Suppliers(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            ManageData = new ManageData(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            CompanyInfo = new CompanyInfo(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            PaymentMethods = new PaymentMethods(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            TaxRates = new TaxRates(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            TrackingCategories = new TrackingCategories(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            PushOperations = new PushOperations(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}