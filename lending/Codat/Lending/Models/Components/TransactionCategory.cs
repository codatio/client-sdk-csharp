//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class TransactionCategory
    {

        /// <summary>
        /// Returns the aggregate confidence of the suggested category for the transaction. The value is between 0 and 100.
        /// </summary>
        [JsonProperty("confidence")]
        public decimal? Confidence { get; set; }

        /// <summary>
        /// An ordered array of category level confidences where each element is the confidence of the corresponding item in the `levels` array.
        /// </summary>
        [JsonProperty("confidences")]
        public List<decimal>? Confidences { get; set; }

        /// <summary>
        /// The suggested category is an ordered array of category levels where each element (or level) is a subcategory of the previous element (or level).
        /// </summary>
        [JsonProperty("levels")]
        public List<string>? Levels { get; set; }
    }
}