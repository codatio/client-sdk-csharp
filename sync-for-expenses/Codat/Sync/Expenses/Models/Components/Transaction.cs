//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    
    public class Transaction
    {

        /// <summary>
        /// Your unique idenfier of the transaction.
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; } = null;

        /// <summary>
        /// Status of the transaction.
        /// </summary>
        [JsonProperty("status")]
        public Models.Components.TransactionStatus? Status { get; set; } = null;

        /// <summary>
        /// Metadata such as validation errors or the resulting record created in the accounting software.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; } = null;

        /// <summary>
        /// Type of transaction that has been processed e.g. Expense or Bank Feed.
        /// </summary>
        [JsonProperty("integrationType")]
        public IntegrationType? IntegrationType { get; set; } = Codat.Sync.Expenses.Models.Components.IntegrationType.Expenses;
    }
}