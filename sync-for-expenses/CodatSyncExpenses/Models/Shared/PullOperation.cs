
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Information about a queued, in progress or completed pull operation.
    /// 
    /// <remarks>
    /// *Formally called `dataset`*
    /// </remarks>
    /// </summary>
    public class PullOperation
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; } = default!;
        
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; } = default!;
        
        [JsonProperty("dataType")]
        public string DataType { get; set; } = default!;
        
        [JsonProperty("id")]
        public string Id { get; set; } = default!;
        
        [JsonProperty("isCompleted")]
        public bool IsCompleted { get; set; } = default!;
        
        [JsonProperty("isErrored")]
        public bool IsErrored { get; set; } = default!;
        
        [JsonProperty("progress")]
        public long Progress { get; set; } = default!;
        
        /// <summary>
        /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
        /// 
        /// <remarks>
        /// 
        /// ```
        /// 2020-10-08T22:40:50Z
        /// 2021-01-01T00:00:00
        /// ```
        /// 
        /// 
        /// 
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
        /// 
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
        /// - Unqualified local time: `2021-11-15T01:00:00`
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
        /// 
        /// > Time zones
        /// > 
        /// > Not all dates from Codat will contain information about time zones.  
        /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("requested")]
        public string Requested { get; set; } = default!;
        
        [JsonProperty("status")]
        public PullOperationStatus Status { get; set; } = default!;
        
    }
    
}