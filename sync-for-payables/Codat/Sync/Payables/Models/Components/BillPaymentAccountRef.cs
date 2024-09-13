//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Components
{
    using Codat.Sync.Payables.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Reference to the bank account / credit card which you are using to pay the bill.
    /// </summary>
    public class BillPaymentAccountRef
    {

        /// <summary>
        /// Unique ID of the bank account / credit card
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;
    }
}