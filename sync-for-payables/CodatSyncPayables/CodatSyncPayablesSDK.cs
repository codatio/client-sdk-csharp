
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables
{
    using CodatSyncPayables.Models.Shared;
    using CodatSyncPayables.Utils;
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
    public interface ICodatSyncPayablesSDK
    {

        /// <summary>
        /// Accounts
        /// </summary>
        public IAccountsSDK Accounts { get; }

        /// <summary>
        /// Bill credit notes
        /// </summary>
        public IBillCreditNotesSDK BillCreditNotes { get; }

        /// <summary>
        /// Bill payments
        /// </summary>
        public IBillPaymentsSDK BillPayments { get; }

        /// <summary>
        /// Bills
        /// </summary>
        public IBillsSDK Bills { get; }

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompaniesSDK Companies { get; }

        /// <summary>
        /// View company information fetched from the source platform.
        /// </summary>
        public ICompanyInfoSDK CompanyInfo { get; }

        /// <summary>
        /// Manage your companies&apos; data connections.
        /// </summary>
        public IConnectionsSDK Connections { get; }

        /// <summary>
        /// Journal entries
        /// </summary>
        public IJournalEntriesSDK JournalEntries { get; }

        /// <summary>
        /// Journals
        /// </summary>
        public IJournalsSDK Journals { get; }

        /// <summary>
        /// Asynchronously retrieve data from an integration to refresh data in Codat.
        /// </summary>
        public IManageDataSDK ManageData { get; }

        /// <summary>
        /// Payment methods
        /// </summary>
        public IPaymentMethodsSDK PaymentMethods { get; }

        /// <summary>
        /// Access create, update and delete operations made to an SMB&apos;s data connection.
        /// </summary>
        public IPushOperationsSDK PushOperations { get; }

        /// <summary>
        /// Suppliers
        /// </summary>
        public ISuppliersSDK Suppliers { get; }

        /// <summary>
        /// Tax rates
        /// </summary>
        public ITaxRatesSDK TaxRates { get; }

        /// <summary>
        /// Tracking categories
        /// </summary>
        public ITrackingCategoriesSDK TrackingCategories { get; }
    }
    
    public class SDKConfig
    {
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
    public class CodatSyncPayablesSDK: ICodatSyncPayablesSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "2.2.0";
        private const string _sdkGenVersion = "2.159.2";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.2.0 2.159.2 3.0.0 Codat.Sync.Payables";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountsSDK Accounts { get; private set; }
        public IBillCreditNotesSDK BillCreditNotes { get; private set; }
        public IBillPaymentsSDK BillPayments { get; private set; }
        public IBillsSDK Bills { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public ICompanyInfoSDK CompanyInfo { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public IJournalEntriesSDK JournalEntries { get; private set; }
        public IJournalsSDK Journals { get; private set; }
        public IManageDataSDK ManageData { get; private set; }
        public IPaymentMethodsSDK PaymentMethods { get; private set; }
        public IPushOperationsSDK PushOperations { get; private set; }
        public ISuppliersSDK Suppliers { get; private set; }
        public ITaxRatesSDK TaxRates { get; private set; }
        public ITrackingCategoriesSDK TrackingCategories { get; private set; }

        public CodatSyncPayablesSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatSyncPayablesSDK.ServerList[0];

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
            BillCreditNotes = new BillCreditNotesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BillPayments = new BillPaymentsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Bills = new BillsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CompanyInfo = new CompanyInfoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            JournalEntries = new JournalEntriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Journals = new JournalsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManageData = new ManageDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PaymentMethods = new PaymentMethodsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            PushOperations = new PushOperationsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Suppliers = new SuppliersSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TaxRates = new TaxRatesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TrackingCategories = new TrackingCategoriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}