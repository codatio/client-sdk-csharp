//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class ConfigurationSchedule
    {

        /// <summary>
        /// The sync frequency.
        /// </summary>
        [JsonProperty("selectedFrequency")]
        public string? SelectedFrequency { get; set; }

        /// <summary>
        /// The available sync frequencies.
        /// </summary>
        [JsonProperty("frequencyOptions")]
        public List<string>? FrequencyOptions { get; set; }

        /// <summary>
        /// The datetime in UTC you want to start syncing from.
        /// </summary>
        [JsonProperty("startDate")]
        public string? StartDate { get; set; }

        /// <summary>
        /// The hour in which the sync is initiated.
        /// </summary>
        [JsonProperty("syncHourUtc")]
        public long? SyncHourUtc { get; set; }

        /// <summary>
        /// The <a href="https://www.iana.org/time-zones">IANA</a> time zone ID.
        /// </summary>
        [JsonProperty("timeZoneIanaId")]
        public string? TimeZoneIanaId { get; set; }
    }
}