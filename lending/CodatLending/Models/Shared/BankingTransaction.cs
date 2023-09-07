
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// The Banking Transactions data type provides an immutable source of up-to-date information on income and expenditure.
    /// 
    /// <remarks>
    /// 
    /// Responses are paged, so you should provide `page` and `pageSize` query parameters in your request.
    /// 
    /// View the coverage for banking transactions in the [Data Coverage Explorer](https://knowledge.codat.io/supported-features/banking?view=tab-by-data-type&dataType=banking-transactions).
    /// </remarks>
    /// </summary>
    public class BankingTransaction
    {
        /// <summary>
        /// The unique identifier of the bank account.
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        
        /// <summary>
        /// The amount of the bank transaction.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }
        
        /// <summary>
        /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
        /// 
        /// <remarks>
        /// 
        /// ```
        /// 2020-10-08T22:40:50Z
        /// 2021-01-01T00:00:00
        /// ```
        /// 
        /// 
        /// 
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
        /// 
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
        /// - Unqualified local time: `2021-11-15T01:00:00`
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
        /// 
        /// > Time zones
        /// > 
        /// > Not all dates from Codat will contain information about time zones.  
        /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("authorizedDate")]
        public string? AuthorizedDate { get; set; }
        
        /// <summary>
        /// Code to identify the underlying transaction.
        /// </summary>
        [JsonProperty("code")]
        public TransactionCode? Code { get; set; }
        
        /// <summary>
        /// The currency of the bank transaction.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        /// <summary>
        /// The description of the bank transaction.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// The unique identifier of the bank transaction.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// The name of the merchant.
        /// </summary>
        [JsonProperty("merchantName")]
        public string? MerchantName { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        /// <summary>
        /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
        /// 
        /// <remarks>
        /// 
        /// ```
        /// 2020-10-08T22:40:50Z
        /// 2021-01-01T00:00:00
        /// ```
        /// 
        /// 
        /// 
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
        /// 
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
        /// - Unqualified local time: `2021-11-15T01:00:00`
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
        /// 
        /// > Time zones
        /// > 
        /// > Not all dates from Codat will contain information about time zones.  
        /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("postedDate")]
        public string? PostedDate { get; set; }
        
        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
        
        /// <summary>
        /// An object of bank transaction category reference data.
        /// </summary>
        [JsonProperty("transactionCategoryRef")]
        public TransactionCategoryRef? TransactionCategoryRef { get; set; }
        
    }
    
}