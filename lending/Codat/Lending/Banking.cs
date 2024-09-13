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
    using Codat.Lending.Models.Components;
    using Codat.Lending.Models.Errors;
    using Codat.Lending.Utils;
    using System;

    public interface IBanking
    {
        public ICategorizedStatement CategorizedStatement { get; }
        public IAccountBalances AccountBalances { get; }
        public ICodatLendingBankingAccounts Accounts { get; }
        public ICodatLendingTransactions Transactions { get; }
        public ITransactionCategories TransactionCategories { get; }
    }

    public class Banking: IBanking
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "6.0.0";
        private const string _sdkGenVersion = "2.415.6";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 6.0.0 2.415.6 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Lending.Models.Components.Security>? _securitySource;
        public ICategorizedStatement CategorizedStatement { get; private set; }
        public IAccountBalances AccountBalances { get; private set; }
        public ICodatLendingBankingAccounts Accounts { get; private set; }
        public ICodatLendingTransactions Transactions { get; private set; }
        public ITransactionCategories TransactionCategories { get; private set; }

        public Banking(ISpeakeasyHttpClient client, Func<Codat.Lending.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            CategorizedStatement = new CategorizedStatement(_client, _securitySource, _serverUrl, SDKConfiguration);
            AccountBalances = new AccountBalances(_client, _securitySource, _serverUrl, SDKConfiguration);
            Accounts = new CodatLendingBankingAccounts(_client, _securitySource, _serverUrl, SDKConfiguration);
            Transactions = new CodatLendingTransactions(_client, _securitySource, _serverUrl, SDKConfiguration);
            TransactionCategories = new TransactionCategories(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}