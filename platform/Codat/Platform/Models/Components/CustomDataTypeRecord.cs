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
    
    public class CustomDataTypeRecord
    {

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Values from the source system for the properties defined in the custom data type configuration.
        /// </summary>
        [JsonProperty("content")]
        public Dictionary<string, Content>? Content { get; set; }

        [JsonProperty("modifiedDate")]
        public ModifiedDate? ModifiedDate { get; set; }
    }
}