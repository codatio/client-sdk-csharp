
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
        public IBankingAccountBalancesSDK AccountBalances { get; }
        public IBankingAccountsSDK Accounts { get; }
        public IBankingCategorizedStatementSDK CategorizedStatement { get; }
        public IBankingTransactionCategoriesSDK TransactionCategories { get; }
        public IBankingTransactionsSDK Transactions { get; }
    }

    public class BankingSDK: IBankingSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "3.1.0";
        private const string _sdkGenVersion = "2.116.0";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IBankingAccountBalancesSDK AccountBalances { get; private set; }
        public IBankingAccountsSDK Accounts { get; private set; }
        public IBankingCategorizedStatementSDK CategorizedStatement { get; private set; }
        public IBankingTransactionCategoriesSDK TransactionCategories { get; private set; }
        public IBankingTransactionsSDK Transactions { get; private set; }

        public BankingSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            AccountBalances = new BankingAccountBalancesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Accounts = new BankingAccountsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CategorizedStatement = new BankingCategorizedStatementSDK(_defaultClient, _securityClient, _serverUrl, Config);
            TransactionCategories = new BankingTransactionCategoriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Transactions = new BankingTransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}