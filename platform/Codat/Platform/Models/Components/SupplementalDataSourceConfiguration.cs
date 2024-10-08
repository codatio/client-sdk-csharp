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
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// The client&apos;s defined name for the object.
    /// </summary>
    public class SupplementalDataSourceConfiguration
    {

        /// <summary>
        /// The underlying endpoint of the source system which the configuration is targeting. 
        /// </summary>
        [JsonProperty("dataSource")]
        public string? DataSource { get; set; }

        /// <summary>
        /// The additional properties that are required when pulling records.
        /// </summary>
        [JsonProperty("pullData")]
        public Dictionary<string, string>? PullData { get; set; }

        /// <summary>
        /// The additional properties that are required to create and/or update records.
        /// </summary>
        [JsonProperty("pushData")]
        public Dictionary<string, string>? PushData { get; set; }
    }
}