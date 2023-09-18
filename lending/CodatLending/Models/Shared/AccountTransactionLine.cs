
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
    
    public class AccountTransactionLine
    {

        /// <summary>
        /// Amount in the bill payment currency.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Description of the account transaction.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Links the current record to the underlying record or data type that created it. &lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// For example, if a journal entry is generated based on an invoice, this property allows you to connect the journal entry to the underlying invoice in our data model. 
        /// </remarks>
        /// </summary>
        [JsonProperty("recordRef")]
        public RecordRef? RecordRef { get; set; }
    }
}