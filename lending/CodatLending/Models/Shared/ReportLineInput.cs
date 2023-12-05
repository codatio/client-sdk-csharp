
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
    using System.Collections.Generic;
    
    public class ReportLineInput
    {

        /// <summary>
        /// Identifier for the account, unique for the company in the accounting platform.
        /// </summary>
        [JsonProperty("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// An array of ReportLine items.
        /// </summary>
        [JsonProperty("items")]
        public List<ReportLine>? Items { get; set; }

        /// <summary>
        /// Name of the report line item.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Numerical value of the line item.
        /// </summary>
        [JsonProperty("value")]
        public decimal Value { get; set; } = default!;
    }
}