
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
    
    public class Links
    {

        [JsonProperty("current")]
        public HalRef Current { get; set; } = default!;

        [JsonProperty("next")]
        public HalRef? Next { get; set; }

        [JsonProperty("previous")]
        public HalRef? Previous { get; set; }

        [JsonProperty("self")]
        public HalRef Self { get; set; } = default!;
    }
}