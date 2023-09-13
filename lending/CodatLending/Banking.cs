
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
    using CodatLending.Utils;
    using System;

    public interface IBankingSDK
    {
        public IBankingAccountBalancesSDK BankingAccountBalances { get; }
        public IBankingAccountsSDK BankingAccounts { get; }
        public IBankingCategorizedStatementSDK BankingCategorizedStatement { get; }
        public IBankingTransactionCategoriesSDK BankingTransactionCategories { get; }
        public IBankingTransactionsSDK BankingTransactions { get; }
    }

    public class BankingSDK: IBankingSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.1.0";
        private const string _sdkGenVersion = "2.109.1";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IBankingAccountBalancesSDK BankingAccountBalances { get; private set; }
        public IBankingAccountsSDK BankingAccounts { get; private set; }
        public IBankingCategorizedStatementSDK BankingCategorizedStatement { get; private set; }
        public IBankingTransactionCategoriesSDK BankingTransactionCategories { get; private set; }
        public IBankingTransactionsSDK BankingTransactions { get; private set; }

        public BankingSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            BankingAccountBalances = new BankingAccountBalancesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BankingAccounts = new BankingAccountsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BankingCategorizedStatement = new BankingCategorizedStatementSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BankingTransactionCategories = new BankingTransactionCategoriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            BankingTransactions = new BankingTransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}