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
    using Codat.Sync.Payables.V1.Models.Shared;
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    
    public class PhoneNumber
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