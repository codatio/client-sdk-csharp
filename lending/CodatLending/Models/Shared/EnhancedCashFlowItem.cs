
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
    using System.Collections.Generic;
    
    public class EnhancedCashFlowItem
    {

        /// <summary>
        /// An array of transaction data.
        /// </summary>
        [JsonProperty("transactions")]
        public List<EnhancedCashFlowTransaction>? Transactions { get; set; }
    }
}