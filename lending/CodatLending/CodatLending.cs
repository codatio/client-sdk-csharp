
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;



    /// <summary>
    /// Lending API: Our Lending API helps you make smarter credit decisions on small businesses by enabling you to pull your customers&apos; latest data from accounting, banking, and commerce platforms they are already using. It also includes features to help providers verify the accuracy of data and process it more efficiently.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// The Lending API is built on top of the latest accounting, commerce, and banking data, providing you with the most important data points you need to get a full picture of SMB creditworthiness and make a comprehensive assessment of your customers.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/lending/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints            | Description                                                                                                |<br/>
    /// |:---------------------|:-----------------------------------------------------------------------------------------------------------|<br/>
    /// | Companies            | Create and manage your SMB users&apos; companies.                                                               |<br/>
    /// | Connections          | Create new and manage existing data connections for a company.                                             |<br/>
    /// | Bank statements      | Retrieve banking data from linked bank accounts.                                                           |<br/>
    /// | Sales                | Retrieve standardized sales data from a linked commerce platform.                                          |<br/>
    /// | Financial statements | Financial data and reports from a linked accounting platform.                                              |<br/>
    /// | Liabilities          | Debt and other liabilities.                                                                                |<br/>
    /// | Accounts payable     | Data from a linked accounting platform representing money the business owes money to its suppliers.        |<br/>
    /// | Accounts receivable  | Data from a linked accounting platform representing money owed to the business for sold goods or services. |<br/>
    /// | Transactions         | Data from a linked accounting platform representing transactions.                                          |<br/>
    /// | Data integrity       | Match mutable accounting data with immutable banking data to increase confidence in financial data.        |<br/>
    /// | Company info         | View company profile from the source platform.                                                             |<br/>
    /// | Excel reports        | Download reports in Excel format.                                                                          |<br/>
    /// | Categories           | Manage Codat&apos;s automatic account categorization functionality.                                             |<br/>
    /// | Manage data          | Control how data is retrieved from an integration.                                                         |<br/>
    /// | File upload          | Endpoints to manage uploaded files.                                                                        |
    /// </remarks>
    /// </summary>
    public interface ICodatLending
    {

        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompanies Companies { get; }

        /// <summary>
        /// Manage your companies&apos; data connections.
        /// </summary>
        public IConnections Connections { get; }
        public ITransactions Transactions { get; }

        /// <summary>
        /// Access bank transactions from an accounting platform.
        /// </summary>
        public ICodatLendingAccountingBankData AccountingBankData { get; }
        public IBanking Banking { get; }
        public IAccountsPayable AccountsPayable { get; }
        public ISales Sales { get; }

        /// <summary>
        /// View company information fetched from the source platform.
        /// </summary>
        public ICompanyInfo CompanyInfo { get; }
        public IAccountsReceivable AccountsReceivable { get; }

        /// <summary>
        /// Endpoints to manage uploaded files.
        /// </summary>
        public IFileUpload FileUpload { get; }
        public ILoanWriteback LoanWriteback { get; }
        public IFinancialStatements FinancialStatements { get; }
        public IManageData ManageData { get; }

        /// <summary>
        /// Debt and other liabilities.
        /// </summary>
        public ILiabilities Liabilities { get; }

        /// <summary>
        /// Match mutable accounting data with immutable banking data to increase confidence in financial data.
        /// </summary>
        public IDataIntegrity DataIntegrity { get; }

        /// <summary>
        /// Download reports in Excel format.
        /// </summary>
        public IExcelReports ExcelReports { get; }
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
    /// Lending API: Our Lending API helps you make smarter credit decisions on small businesses by enabling you to pull your customers&apos; latest data from accounting, banking, and commerce platforms they are already using. It also includes features to help providers verify the accuracy of data and process it more efficiently.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// The Lending API is built on top of the latest accounting, commerce, and banking data, providing you with the most important data points you need to get a full picture of SMB creditworthiness and make a comprehensive assessment of your customers.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/lending/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// ---<br/>
    /// <br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints            | Description                                                                                                |<br/>
    /// |:---------------------|:-----------------------------------------------------------------------------------------------------------|<br/>
    /// | Companies            | Create and manage your SMB users&apos; companies.                                                               |<br/>
    /// | Connections          | Create new and manage existing data connections for a company.                                             |<br/>
    /// | Bank statements      | Retrieve banking data from linked bank accounts.                                                           |<br/>
    /// | Sales                | Retrieve standardized sales data from a linked commerce platform.                                          |<br/>
    /// | Financial statements | Financial data and reports from a linked accounting platform.                                              |<br/>
    /// | Liabilities          | Debt and other liabilities.                                                                                |<br/>
    /// | Accounts payable     | Data from a linked accounting platform representing money the business owes money to its suppliers.        |<br/>
    /// | Accounts receivable  | Data from a linked accounting platform representing money owed to the business for sold goods or services. |<br/>
    /// | Transactions         | Data from a linked accounting platform representing transactions.                                          |<br/>
    /// | Data integrity       | Match mutable accounting data with immutable banking data to increase confidence in financial data.        |<br/>
    /// | Company info         | View company profile from the source platform.                                                             |<br/>
    /// | Excel reports        | Download reports in Excel format.                                                                          |<br/>
    /// | Categories           | Manage Codat&apos;s automatic account categorization functionality.                                             |<br/>
    /// | Manage data          | Control how data is retrieved from an integration.                                                         |<br/>
    /// | File upload          | Endpoints to manage uploaded files.                                                                        |
    /// </remarks>
    /// </summary>
    public class CodatLending: ICodatLending
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.1";
        private const string _sdkGenVersion = "2.209.0";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.1 2.209.0 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ICompanies Companies { get; private set; }
        public IConnections Connections { get; private set; }
        public ITransactions Transactions { get; private set; }
        public ICodatLendingAccountingBankData AccountingBankData { get; private set; }
        public IBanking Banking { get; private set; }
        public IAccountsPayable AccountsPayable { get; private set; }
        public ISales Sales { get; private set; }
        public ICompanyInfo CompanyInfo { get; private set; }
        public IAccountsReceivable AccountsReceivable { get; private set; }
        public IFileUpload FileUpload { get; private set; }
        public ILoanWriteback LoanWriteback { get; private set; }
        public IFinancialStatements FinancialStatements { get; private set; }
        public IManageData ManageData { get; private set; }
        public ILiabilities Liabilities { get; private set; }
        public IDataIntegrity DataIntegrity { get; private set; }
        public IExcelReports ExcelReports { get; private set; }

        public CodatLending(Security? security = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
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
            Transactions = new Transactions(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            AccountingBankData = new CodatLendingAccountingBankData(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Banking = new Banking(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            AccountsPayable = new AccountsPayable(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Sales = new Sales(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            CompanyInfo = new CompanyInfo(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            AccountsReceivable = new AccountsReceivable(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            FileUpload = new FileUpload(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            LoanWriteback = new LoanWriteback(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            FinancialStatements = new FinancialStatements(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            ManageData = new ManageData(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Liabilities = new Liabilities(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            DataIntegrity = new DataIntegrity(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            ExcelReports = new ExcelReports(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}