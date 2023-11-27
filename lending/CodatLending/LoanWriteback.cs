
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

    public interface ILoanWriteback
    {
        public IBankAccounts BankAccounts { get; }
        public IBankTransactions BankTransactions { get; }
        public ICodatLendingLoanWritebackAccounts Accounts { get; }
        public IDirectCosts DirectCosts { get; }
        public ICodatLendingPayments Payments { get; }
        public ICodatLendingSuppliers Suppliers { get; }
        public ITransfers Transfers { get; }
        public ICreateOperations CreateOperations { get; }
    }

    public class LoanWriteback: ILoanWriteback
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.0";
        private const string _sdkGenVersion = "2.195.2";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.0 2.195.2 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IBankAccounts BankAccounts { get; private set; }
        public IBankTransactions BankTransactions { get; private set; }
        public ICodatLendingLoanWritebackAccounts Accounts { get; private set; }
        public IDirectCosts DirectCosts { get; private set; }
        public ICodatLendingPayments Payments { get; private set; }
        public ICodatLendingSuppliers Suppliers { get; private set; }
        public ITransfers Transfers { get; private set; }
        public ICreateOperations CreateOperations { get; private set; }

        public LoanWriteback(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
            BankAccounts = new BankAccounts(_defaultClient, _securityClient, _serverUrl, Config);
            BankTransactions = new BankTransactions(_defaultClient, _securityClient, _serverUrl, Config);
            Accounts = new CodatLendingLoanWritebackAccounts(_defaultClient, _securityClient, _serverUrl, Config);
            DirectCosts = new DirectCosts(_defaultClient, _securityClient, _serverUrl, Config);
            Payments = new CodatLendingPayments(_defaultClient, _securityClient, _serverUrl, Config);
            Suppliers = new CodatLendingSuppliers(_defaultClient, _securityClient, _serverUrl, Config);
            Transfers = new Transfers(_defaultClient, _securityClient, _serverUrl, Config);
            CreateOperations = new CreateOperations(_defaultClient, _securityClient, _serverUrl, Config);
        }
        
    }
}