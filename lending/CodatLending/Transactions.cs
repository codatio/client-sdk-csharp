
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

    public interface ITransactionsSDK
    {
        public ITransactionsAccountTransactionsSDK AccountTransactions { get; }
        public ITransactionsDirectCostsSDK DirectCosts { get; }
        public ITransactionsJournalEntriesSDK JournalEntries { get; }
        public ITransactionsJournalsSDK Journals { get; }
        public ITransactionsTransfersSDK Transfers { get; }
    }

    public class TransactionsSDK: ITransactionsSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "2.3.1";
        private const string _sdkGenVersion = "2.115.2";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ITransactionsAccountTransactionsSDK AccountTransactions { get; private set; }
        public ITransactionsDirectCostsSDK DirectCosts { get; private set; }
        public ITransactionsJournalEntriesSDK JournalEntries { get; private set; }
        public ITransactionsJournalsSDK Journals { get; private set; }
        public ITransactionsTransfersSDK Transfers { get; private set; }

        public TransactionsSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            AccountTransactions = new TransactionsAccountTransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            DirectCosts = new TransactionsDirectCostsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            JournalEntries = new TransactionsJournalEntriesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Journals = new TransactionsJournalsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Transfers = new TransactionsTransfersSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}