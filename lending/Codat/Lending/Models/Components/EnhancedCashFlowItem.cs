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
    using Codat.Lending.Models.Components;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class EnhancedCashFlowItem
    {

        /// <summary>
        /// An array of transaction data.
        /// </summary>
        [JsonProperty("transactions")]
        public List<CashFlowTransaction>? Transactions { get; set; }
    }
}