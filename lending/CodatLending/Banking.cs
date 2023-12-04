
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
    using Codat.Lending.Utils;
    using System;

    public interface IBanking
    {
        public IAccountBalances AccountBalances { get; }
        public ICodatLendingAccounts Accounts { get; }
        public ITransactionCategories TransactionCategories { get; }
        public ICodatLendingBankingTransactions Transactions { get; }
        public ICategorizedStatement CategorizedStatement { get; }
    }

    public class Banking: IBanking
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
        public IAccountBalances AccountBalances { get; private set; }
        public ICodatLendingAccounts Accounts { get; private set; }
        public ITransactionCategories TransactionCategories { get; private set; }
        public ICodatLendingBankingTransactions Transactions { get; private set; }
        public ICategorizedStatement CategorizedStatement { get; private set; }

        public Banking(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            AccountBalances = new AccountBalances(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Accounts = new CodatLendingAccounts(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            TransactionCategories = new TransactionCategories(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Transactions = new CodatLendingBankingTransactions(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            CategorizedStatement = new CategorizedStatement(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
        
    }
}