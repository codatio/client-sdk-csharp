//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending
{
    using Codat.Lending.Hooks;
    using Codat.Lending.Models.Components;
    using Codat.Lending.Models.Errors;
    using Codat.Lending.Utils;
    using Codat.Lending.Utils.Retries;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Lending API: Our Lending API helps you make smarter credit decisions on small businesses by enabling you to pull your customers&apos; latest data from accounting, banking, and commerce software they are already using. It also includes features to help providers verify the accuracy of data and process it more efficiently.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// The Lending API is built on top of the latest accounting, commerce, and banking data, providing you with the most important data points you need to get a full picture of SMB creditworthiness and make a comprehensive assessment of your customers.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/lending/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Bank statements | Retrieve banking data from linked bank accounts. |<br/>
    /// | Sales | Retrieve standardized sales data from a linked commerce software. |<br/>
    /// | Financial statements | Financial data and reports from a linked accounting software. |<br/>
    /// | Liabilities | Debt and other liabilities. |<br/>
    /// | Accounts payable | Data from a linked accounting software representing money the business owes money to its suppliers. |<br/>
    /// | Accounts receivable | Data from a linked accounting software representing money owed to the business for sold goods or services. |<br/>
    /// | Transactions | Data from a linked accounting software representing transactions. |<br/>
    /// | Company info | View company information fetched from the source platform. |<br/>
    /// | Data integrity | Match mutable accounting data with immutable banking data to increase confidence in financial data. |<br/>
    /// | Excel reports | Download reports in Excel format. |<br/>
    /// | Manage data | Control how data is retrieved from an integration. |<br/>
    /// | File upload | Endpoints to manage uploaded files. |<br/>
    /// | Loan writeback | Implement the <a href="https://docs.codat.io/lending/guides/loan-writeback/introduction">loan writeback</a> procedure in your lending process to maintain an accurate position of a loan during the entire lending cycle. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public interface ICodatLending
    {

        /// <summary>
        /// Create and manage your SMB users&apos; companies.
        /// </summary>
        public ICompanies Companies { get; }

        /// <summary>
        /// Create new and manage existing data connections for a company.
        /// </summary>
        public IConnections Connections { get; }
        public IManageData ManageData { get; }

        /// <summary>
        /// Match mutable accounting data with immutable banking data to increase confidence in financial data.
        /// </summary>
        public IDataIntegrity DataIntegrity { get; }
        public IFinancialStatements FinancialStatements { get; }
        public IBanking Banking { get; }
        public IAccountsReceivable AccountsReceivable { get; }

        /// <summary>
        /// Debt and other liabilities.
        /// </summary>
        public ILiabilities Liabilities { get; }
        public ISales Sales { get; }

        /// <summary>
        /// Download reports in Excel format.
        /// </summary>
        public IExcelReports ExcelReports { get; }
        public ITransactions Transactions { get; }
        public IAccountsPayable AccountsPayable { get; }

        /// <summary>
        /// View company information fetched from the source platform.
        /// </summary>
        public ICompanyInfo CompanyInfo { get; }

        /// <summary>
        /// Access bank transactions from an accounting software.
        /// </summary>
        public IAccountingBankData AccountingBankData { get; }

        /// <summary>
        /// Endpoints to manage uploaded files.
        /// </summary>
        public IFileUpload FileUpload { get; }
        public ILoanWriteback LoanWriteback { get; }

        /// <summary>
        /// Retrieve banking data from linked bank accounts.
        /// </summary>
        public IBankStatements BankStatements { get; }

        /// <summary>
        /// Endpoints to manage generation of reports
        /// </summary>
        public IManageReports ManageReports { get; }
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
    /// Lending API: Our Lending API helps you make smarter credit decisions on small businesses by enabling you to pull your customers&apos; latest data from accounting, banking, and commerce software they are already using. It also includes features to help providers verify the accuracy of data and process it more efficiently.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// The Lending API is built on top of the latest accounting, commerce, and banking data, providing you with the most important data points you need to get a full picture of SMB creditworthiness and make a comprehensive assessment of your customers.<br/>
    /// <br/>
    /// <a href="https://docs.codat.io/lending/overview">Explore product</a> | <a href="https://github.com/codatio/oas">See OpenAPI spec</a><br/>
    /// <br/>
    /// &lt;!-- Start Codat Tags Table --&gt;<br/>
    /// ## Endpoints<br/>
    /// <br/>
    /// | Endpoints | Description |<br/>
    /// | :- |:- |<br/>
    /// | Companies | Create and manage your SMB users&apos; companies. |<br/>
    /// | Connections | Create new and manage existing data connections for a company. |<br/>
    /// | Bank statements | Retrieve banking data from linked bank accounts. |<br/>
    /// | Sales | Retrieve standardized sales data from a linked commerce software. |<br/>
    /// | Financial statements | Financial data and reports from a linked accounting software. |<br/>
    /// | Liabilities | Debt and other liabilities. |<br/>
    /// | Accounts payable | Data from a linked accounting software representing money the business owes money to its suppliers. |<br/>
    /// | Accounts receivable | Data from a linked accounting software representing money owed to the business for sold goods or services. |<br/>
    /// | Transactions | Data from a linked accounting software representing transactions. |<br/>
    /// | Company info | View company information fetched from the source platform. |<br/>
    /// | Data integrity | Match mutable accounting data with immutable banking data to increase confidence in financial data. |<br/>
    /// | Excel reports | Download reports in Excel format. |<br/>
    /// | Manage data | Control how data is retrieved from an integration. |<br/>
    /// | File upload | Endpoints to manage uploaded files. |<br/>
    /// | Loan writeback | Implement the <a href="https://docs.codat.io/lending/guides/loan-writeback/introduction">loan writeback</a> procedure in your lending process to maintain an accurate position of a loan during the entire lending cycle. |<br/>
    /// &lt;!-- End Codat Tags Table --&gt;
    /// </remarks>
    /// </summary>
    public class CodatLending: ICodatLending
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "9.0.2";
        private const string _sdkGenVersion = "2.486.1";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 9.0.2 2.486.1 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Lending.Models.Components.Security>? _securitySource;
        public ICompanies Companies { get; private set; }
        public IConnections Connections { get; private set; }
        public IManageData ManageData { get; private set; }
        public IDataIntegrity DataIntegrity { get; private set; }
        public IFinancialStatements FinancialStatements { get; private set; }
        public IBanking Banking { get; private set; }
        public IAccountsReceivable AccountsReceivable { get; private set; }
        public ILiabilities Liabilities { get; private set; }
        public ISales Sales { get; private set; }
        public IExcelReports ExcelReports { get; private set; }
        public ITransactions Transactions { get; private set; }
        public IAccountsPayable AccountsPayable { get; private set; }
        public ICompanyInfo CompanyInfo { get; private set; }
        public IAccountingBankData AccountingBankData { get; private set; }
        public IFileUpload FileUpload { get; private set; }
        public ILoanWriteback LoanWriteback { get; private set; }
        public IBankStatements BankStatements { get; private set; }
        public IManageReports ManageReports { get; private set; }

        public CodatLending(string? authHeader = null, Func<string>? authHeaderSource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
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
                _securitySource = () => new Codat.Lending.Models.Components.Security() { AuthHeader = authHeaderSource() };
            }
            else if(authHeader != null)
            {
                _securitySource = () => new Codat.Lending.Models.Components.Security() { AuthHeader = authHeader };
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


            ManageData = new ManageData(_client, _securitySource, _serverUrl, SDKConfiguration);


            DataIntegrity = new DataIntegrity(_client, _securitySource, _serverUrl, SDKConfiguration);


            FinancialStatements = new FinancialStatements(_client, _securitySource, _serverUrl, SDKConfiguration);


            Banking = new Banking(_client, _securitySource, _serverUrl, SDKConfiguration);


            AccountsReceivable = new AccountsReceivable(_client, _securitySource, _serverUrl, SDKConfiguration);


            Liabilities = new Liabilities(_client, _securitySource, _serverUrl, SDKConfiguration);


            Sales = new Sales(_client, _securitySource, _serverUrl, SDKConfiguration);


            ExcelReports = new ExcelReports(_client, _securitySource, _serverUrl, SDKConfiguration);


            Transactions = new Transactions(_client, _securitySource, _serverUrl, SDKConfiguration);


            AccountsPayable = new AccountsPayable(_client, _securitySource, _serverUrl, SDKConfiguration);


            CompanyInfo = new CompanyInfo(_client, _securitySource, _serverUrl, SDKConfiguration);


            AccountingBankData = new AccountingBankData(_client, _securitySource, _serverUrl, SDKConfiguration);


            FileUpload = new FileUpload(_client, _securitySource, _serverUrl, SDKConfiguration);


            LoanWriteback = new LoanWriteback(_client, _securitySource, _serverUrl, SDKConfiguration);


            BankStatements = new BankStatements(_client, _securitySource, _serverUrl, SDKConfiguration);


            ManageReports = new ManageReports(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}