//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Components
{
    using Codat.Sync.Commerce.Models.Components;
    using Codat.Sync.Commerce.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class FeesConfiguration
    {

        [JsonProperty("feesSupplier")]
        public FeesSupplier? FeesSupplier { get; set; }

        /// <summary>
        /// Boolean indicator to enable syncing fees.
        /// </summary>
        [JsonProperty("syncFees")]
        public bool? SyncFees { get; set; }

        [JsonProperty("accounts")]
        public Dictionary<string, AccountConfiguration>? Accounts { get; set; } = null;
    }
}