
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Operations
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Data types that support supplemental data
    /// </summary>
    public enum GetSupplementalDataConfigurationDataType
    {
        [JsonProperty("chartOfAccounts")]
        ChartOfAccounts,
        [JsonProperty("bills")]
        Bills,
        [JsonProperty("company")]
        Company,
        [JsonProperty("creditNotes")]
        CreditNotes,
        [JsonProperty("customers")]
        Customers,
        [JsonProperty("invoices")]
        Invoices,
        [JsonProperty("items")]
        Items,
        [JsonProperty("journalEntries")]
        JournalEntries,
        [JsonProperty("suppliers")]
        Suppliers,
        [JsonProperty("taxRates")]
        TaxRates,
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
        [JsonProperty("commerce-payments")]
        CommercePayments,
        [JsonProperty("commerce-paymentMethods")]
        CommercePaymentMethods,
        [JsonProperty("commerce-products")]
        CommerceProducts,
        [JsonProperty("commerce-productCategories")]
        CommerceProductCategories,
        [JsonProperty("commerce-taxComponents")]
        CommerceTaxComponents,
        [JsonProperty("commerce-transactions")]
        CommerceTransactions,
    }

    public static class GetSupplementalDataConfigurationDataTypeExtension
    {
        public static string Value(this GetSupplementalDataConfigurationDataType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetSupplementalDataConfigurationDataType ToEnum(this string value)
        {
            foreach(var field in typeof(GetSupplementalDataConfigurationDataType).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is GetSupplementalDataConfigurationDataType)
                    {
                        return (GetSupplementalDataConfigurationDataType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetSupplementalDataConfigurationDataType");
        }
    }
}