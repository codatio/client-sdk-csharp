
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
    using Codat.Lending.Models.Errors;
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    using System;

    public interface IFinancialStatements
    {
        public ICodatLendingFinancialStatementsAccounts Accounts { get; }
        public IBalanceSheet BalanceSheet { get; }
        public ICashFlow CashFlow { get; }
        public IProfitAndLoss ProfitAndLoss { get; }
    }

    public class FinancialStatements: IFinancialStatements
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.4.0";
        private const string _sdkGenVersion = "2.319.7";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.4.0 2.319.7 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public ICodatLendingFinancialStatementsAccounts Accounts { get; private set; }
        public IBalanceSheet BalanceSheet { get; private set; }
        public ICashFlow CashFlow { get; private set; }
        public IProfitAndLoss ProfitAndLoss { get; private set; }

        public FinancialStatements(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            Accounts = new CodatLendingFinancialStatementsAccounts(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            BalanceSheet = new BalanceSheet(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            CashFlow = new CashFlow(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            ProfitAndLoss = new ProfitAndLoss(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}