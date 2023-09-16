
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    
    public class Attachment
    {

        /// <summary>
        /// Unique ID of company in Codat
        /// </summary>
        [JsonProperty("companyId")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// Unique identifier of attachment
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Unique identifier of transaction
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }
    }
}