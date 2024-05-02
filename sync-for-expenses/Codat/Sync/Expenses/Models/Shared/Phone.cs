
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    
    public class Phone
    {

        /// <summary>
        /// A phone number.
        /// </summary>
        [JsonProperty("number")]
        public string? Number { get; set; } = null;

        /// <summary>
        /// The type of phone number
        /// </summary>
        [JsonProperty("type")]
        public PhoneNumberType Type { get; set; } = default!;
    }
}