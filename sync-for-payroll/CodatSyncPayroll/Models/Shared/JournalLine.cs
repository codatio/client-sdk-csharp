
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Shared
{
    using Newtonsoft.Json;
    
    public class JournalLine
    {

        /// <summary>
        /// Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.
        /// </summary>
        [JsonProperty("accountRef")]
        public AccountRef? AccountRef { get; set; }

        /// <summary>
        /// Currency for the journal line item.
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Description of the journal line item.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Amount for the journal line. Debit entries are considered positive, and credit entries are considered negative.
        /// </summary>
        [JsonProperty("netAmount")]
        public decimal NetAmount { get; set; } = default!;

        /// <summary>
        /// List of record refs associated with the tracking information for the line (eg to a Tracking Category, or customer etc.)
        /// </summary>
        [JsonProperty("tracking")]
        public JournalLineTracking? Tracking { get; set; }
    }
}