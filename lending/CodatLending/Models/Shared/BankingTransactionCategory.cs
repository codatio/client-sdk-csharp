
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
    
    /// <summary>
    /// Status of the bank transaction category.
    /// </summary>
    public class BankingTransactionCategory
    {

        /// <summary>
        /// A Boolean indicating whether there are other bank transaction categories beneath this one in the hierarchy.
        /// </summary>
        [JsonProperty("hasChildren")]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// The unique identifier of the bank transaction category.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the bank transaction category.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the parent bank transaction category.
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// The status of the transaction category.
        /// </summary>
        [JsonProperty("status")]
        public TransactionCategoryStatus? Status { get; set; }
    }
}