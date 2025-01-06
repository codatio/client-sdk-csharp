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

    public interface IFinancialStatements
    {
        public IProfitAndLoss ProfitAndLoss { get; }
        public IBalanceSheet BalanceSheet { get; }
        public IAccounts Accounts { get; }
        public ICashFlow CashFlow { get; }
    }

    public class FinancialStatements: IFinancialStatements
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "9.0.2";
        private const string _sdkGenVersion = "2.486.1";
        private const string _openapiDocVersion = "3.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 9.0.2 2.486.1 3.0.0 Codat.Lending";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Codat.Lending.Models.Components.Security>? _securitySource;
        public IProfitAndLoss ProfitAndLoss { get; private set; }
        public IBalanceSheet BalanceSheet { get; private set; }
        public IAccounts Accounts { get; private set; }
        public ICashFlow CashFlow { get; private set; }

        public FinancialStatements(ISpeakeasyHttpClient client, Func<Codat.Lending.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
            ProfitAndLoss = new ProfitAndLoss(_client, _securitySource, _serverUrl, SDKConfiguration);
            BalanceSheet = new BalanceSheet(_client, _securitySource, _serverUrl, SDKConfiguration);
            Accounts = new Accounts(_client, _securitySource, _serverUrl, SDKConfiguration);
            CashFlow = new CashFlow(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}