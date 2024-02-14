
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Available Data types
    /// </summary>
    public enum SchemaDataType
    {
        [JsonProperty("accountTransactions")]
        AccountTransactions,
        [JsonProperty("balanceSheet")]
        BalanceSheet,
        [JsonProperty("bankAccounts")]
        BankAccounts,
        [JsonProperty("bankTransactions")]
        BankTransactions,
        [JsonProperty("billCreditNotes")]
        BillCreditNotes,
        [JsonProperty("billPayments")]
        BillPayments,
        [JsonProperty("bills")]
        Bills,
        [JsonProperty("cashFlowStatement")]
        CashFlowStatement,
        [JsonProperty("chartOfAccounts")]
        ChartOfAccounts,
        [JsonProperty("company")]
        Company,
        [JsonProperty("creditNotes")]
        CreditNotes,
        [JsonProperty("customers")]
        Customers,
        [JsonProperty("directCosts")]
        DirectCosts,
        [JsonProperty("directIncomes")]
        DirectIncomes,
        [JsonProperty("invoices")]
        Invoices,
        [JsonProperty("itemReceipts")]
        ItemReceipts,
        [JsonProperty("items")]
        Items,
        [JsonProperty("journalEntries")]
        JournalEntries,
        [JsonProperty("journals")]
        Journals,
        [JsonProperty("paymentMethods")]
        PaymentMethods,
        [JsonProperty("payments")]
        Payments,
        [JsonProperty("profitAndLoss")]
        ProfitAndLoss,
        [JsonProperty("purchaseOrders")]
        PurchaseOrders,
        [JsonProperty("salesOrders")]
        SalesOrders,
        [JsonProperty("suppliers")]
        Suppliers,
        [JsonProperty("taxRates")]
        TaxRates,
        [JsonProperty("trackingCategories")]
        TrackingCategories,
        [JsonProperty("transfers")]
        Transfers,
        [JsonProperty("banking-accountBalances")]
        BankingAccountBalances,
        [JsonProperty("banking-accounts")]
        BankingAccounts,
        [JsonProperty("banking-transactionCategories")]
        BankingTransactionCategories,
        [JsonProperty("banking-transactions")]
        BankingTransactions,
        [JsonProperty("commerce-companyInfo")]
        CommerceCompanyInfo,
        [JsonProperty("commerce-customers")]
        CommerceCustomers,
        [JsonProperty("commerce-disputes")]
        CommerceDisputes,
        [JsonProperty("commerce-locations")]
        CommerceLocations,
        [JsonProperty("commerce-orders")]
        CommerceOrders,
        [JsonProperty("commerce-paymentMethods")]
        CommercePaymentMethods,
        [JsonProperty("commerce-payments")]
        CommercePayments,
        [JsonProperty("commerce-productCategories")]
        CommerceProductCategories,
        [JsonProperty("commerce-products")]
        CommerceProducts,
        [JsonProperty("commerce-taxComponents")]
        CommerceTaxComponents,
        [JsonProperty("commerce-transactions")]
        CommerceTransactions,
    }

    public static class SchemaDataTypeExtension
    {
        public static string Value(this SchemaDataType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemaDataType ToEnum(this string value)
        {
            foreach(var field in typeof(SchemaDataType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is SchemaDataType)
                    {
                        return (SchemaDataType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemaDataType");
        }
    }

}