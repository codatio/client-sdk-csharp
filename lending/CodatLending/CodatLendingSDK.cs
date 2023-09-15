
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending
{
    using CodatLending.Models.Shared;
    using CodatLending.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatLendingSDK
    {
        public IAccountingBankDataSDK AccountingBankData { get; }
        public ICompaniesSDK Companies { get; }
        public ICompanyInfoSDK CompanyInfo { get; }
        public IConnectionsSDK Connections { get; }
        public IDataIntegritySDK DataIntegrity { get; }
        public IExcelReportsSDK ExcelReports { get; }
        public IFileUploadSDK FileUpload { get; }
        public ILiabilitiesSDK Liabilities { get; }
        public IAccountsPayableSDK AccountsPayable { get; }
        public IAccountsReceivableSDK AccountsReceivable { get; }
        public IBankingSDK Banking { get; }
        public IFinancialStatementsSDK FinancialStatements { get; }
        public IManageDataSDK ManageData { get; }
        public ISalesSDK Sales { get; }
        public ITransactionsSDK Transactions { get; }
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// Lending API: Our Lending API helps you make smarter credit decisions on small businesses by enabling you to pull your customers' latest data from accounting, banking, and commerce platforms they are already using. It also includes features to help providers verify the accuracy of data and process it more efficiently.
    /// 
    /// <remarks>
    /// 
    /// The Lending API is built on top of the latest accounting, commerce, and banking data, providing you with the most important data points you need to get a full picture of SMB creditworthiness and make a comprehensive assessment of your customers.
    /// 
    /// [Explore product](https://docs.codat.io/lending/overview) | [See OpenAPI spec](https://github.com/codatio/oas)
    /// 
    /// ---
    /// 
    /// ## Endpoints
    /// 
    /// | Endpoints            | Description                                                                                                |
    /// |:---------------------|:-----------------------------------------------------------------------------------------------------------|
    /// | Companies            | Create and manage your SMB users' companies.                                                               |
    /// | Connections          | Create new and manage existing data connections for a company.                                             |
    /// | Bank statements      | Retrieve banking data from linked bank accounts.                                                           |
    /// | Sales                | Retrieve standardized sales data from a linked commerce platform.                                          |
    /// | Financial statements | Financial data and reports from a linked accounting platform.                                              |
    /// | Liabilities          | Debt and other liabilities.                                                                                |
    /// | Accounts payable     | Data from a linked accounting platform representing money the business owes money to its suppliers.        |
    /// | Accounts receivable  | Data from a linked accounting platform representing money owed to the business for sold goods or services. |
    /// | Transactions         | Data from a linked accounting platform representing transactions.                                          |
    /// | Data integrity       | Match mutable accounting data with immutable banking data to increase confidence in financial data.        |
    /// | Company info         | View company profile from the source platform.                                                             |
    /// | Excel reports        | Download reports in Excel format.                                                                          |
    /// | Categories           | Manage Codat's automatic account categorization functionality.                                             |
    /// | Manage data          | Control how data is retrieved from an integration.                                                         |
    /// | File upload          | Endpoints to manage uploaded files.                                                                        |
    /// </remarks>
    /// </summary>
    public class CodatLendingSDK: ICodatLendingSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "2.3.0";
        private const string _sdkGenVersion = "2.113.0";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        /// <summary>
        /// Access bank transactions from an accounting platform.
        /// </summary>
        public IAccountingBankDataSDK AccountingBankData { get; private set; }
        /// <summary>
        /// Create and manage your Codat companies.
        /// </summary>
        public ICompaniesSDK Companies { get; private set; }
        /// <summary>
        /// View company information fetched from the source platform.
        /// </summary>
        public ICompanyInfoSDK CompanyInfo { get; private set; }
        /// <summary>
        /// Manage your companies' data connections.
        /// </summary>
        public IConnectionsSDK Connections { get; private set; }
        /// <summary>
        /// Match mutable accounting data with immutable banking data to increase confidence in financial data.
        /// </summary>
        public IDataIntegritySDK DataIntegrity { get; private set; }
        /// <summary>
        /// Download reports in Excel format.
        /// </summary>
        public IExcelReportsSDK ExcelReports { get; private set; }
        /// <summary>
        /// Endpoints to manage uploaded files.
        /// </summary>
        public IFileUploadSDK FileUpload { get; private set; }
        /// <summary>
        /// Debt and other liabilities.
        /// </summary>
        public ILiabilitiesSDK Liabilities { get; private set; }
        public IAccountsPayableSDK AccountsPayable { get; private set; }
        public IAccountsReceivableSDK AccountsReceivable { get; private set; }
        public IBankingSDK Banking { get; private set; }
        public IFinancialStatementsSDK FinancialStatements { get; private set; }
        public IManageDataSDK ManageData { get; private set; }
        public ISalesSDK Sales { get; private set; }
        public ITransactionsSDK Transactions { get; private set; }

        public CodatLendingSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatLendingSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            AccountingBankData = new AccountingBankDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CompanyInfo = new CompanyInfoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            DataIntegrity = new DataIntegritySDK(_defaultClient, _securityClient, _serverUrl, Config);
            ExcelReports = new ExcelReportsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            FileUpload = new FileUploadSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Liabilities = new LiabilitiesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            AccountsPayable = new AccountsPayableSDK(_defaultClient, _securityClient, _serverUrl, Config);
            AccountsReceivable = new AccountsReceivableSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Banking = new BankingSDK(_defaultClient, _securityClient, _serverUrl, Config);
            FinancialStatements = new FinancialStatementsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManageData = new ManageDataSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Sales = new SalesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Transactions = new TransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}