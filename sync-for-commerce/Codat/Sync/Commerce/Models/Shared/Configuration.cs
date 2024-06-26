
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Shared
{
    using Codat.Sync.Commerce.Models.Shared;
    using Codat.Sync.Commerce.Utils;
    using Newtonsoft.Json;
    
    public class Configuration
    {

        /// <summary>
        /// The company name defined in the accounting platform.
        /// </summary>
        [JsonProperty("accountingSoftwareCompanyName")]
        public string? AccountingSoftwareCompanyName { get; set; }

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [JsonProperty("companyId")]
        public object? CompanyId { get; set; }

        [JsonProperty("configuration")]
        public CommerceConfiguration? ConfigurationValue { get; set; }

        /// <summary>
        /// True if Sync for Commerce has been configured for the company.
        /// </summary>
        [JsonProperty("configured")]
        public bool? Configured { get; set; }

        /// <summary>
        /// True if Sync for Commerce is enabled for the company.
        /// </summary>
        [JsonProperty("enable")]
        public bool? Enable { get; set; }

        [JsonProperty("schedule")]
        public SyncSchedule? Schedule { get; set; }
    }
}