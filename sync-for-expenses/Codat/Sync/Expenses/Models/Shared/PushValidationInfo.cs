
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
    using System.Collections.Generic;
    
    public class PushValidationInfo
    {

        [JsonProperty("information")]
        public List<PushFieldValidation>? Information { get; set; } = null;

        [JsonProperty("warnings")]
        public List<PushFieldValidation>? Warnings { get; set; } = null;
    }
}