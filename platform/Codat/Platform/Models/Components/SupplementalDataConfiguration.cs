//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Components
{
    using Codat.Platform.Models.Components;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class SupplementalDataConfiguration
    {

        [JsonProperty("supplementalDataConfig")]
        public Dictionary<string, SupplementalDataSourceConfiguration>? SupplementalDataConfig { get; set; }
    }
}