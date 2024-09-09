//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    
    public class UpdateBillResponseWithholdingTax
    {

        /// <summary>
        /// Amount of tax withheld.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; } = default!;

        /// <summary>
        /// Name assigned to withheld tax.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
    }
}