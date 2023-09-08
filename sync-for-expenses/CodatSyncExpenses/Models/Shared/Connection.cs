
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
    using System.Collections.Generic;
    
    
    /// <summary>
    /// A connection represents a [company's](https://docs.codat.io/sync-for-expenses-api#/schemas/Company) connection to a data source and allows you to synchronize data (pull and/or push) with that source.
    /// 
    /// <remarks>
    /// 
    /// A company can have multiple data connections depending on the type of data source it is connecting to. For example, a single company can link to:
    /// 
    /// - [Accounting data](https://docs.codat.io/accounting-api/overview) - 1 active connection.
    /// - [Banking data](https://docs.codat.io/banking-api/overview) - Multiple active connections.
    /// - [Commerce data](https://docs.codat.io/commerce-api/overview) - Multiple active connections.
    /// Any combination of accounting, banking, and commerce data connections is allowed.
    /// 
    /// Before you can use a data connection to pull or push data, the company must grant you access to their business data by [linking the connection](https://docs.codat.io/auth-flow/overview).
    /// </remarks>
    /// </summary>
    public class Connection
    {
        [JsonProperty("additionalProperties")]
        public object? AdditionalProperties { get; set; }
        
        [JsonProperty("connectionInfo")]
        public Dictionary<string, string>? ConnectionInfo { get; set; }
        
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
        [JsonProperty("created")]
        public string Created { get; set; } = default!;
        
        [JsonProperty("dataConnectionErrors")]
        public List<DataConnectionError>? DataConnectionErrors { get; set; }
        
        /// <summary>
        /// Unique identifier for a company's data connection.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;
        
        /// <summary>
        /// A Codat ID representing the integration.
        /// </summary>
        [JsonProperty("integrationId")]
        public string IntegrationId { get; set; } = default!;
        
        /// <summary>
        /// A unique four-character ID that identifies the platform of the company's data connection. This ensures continuity if the platform changes its name in the future.
        /// </summary>
        [JsonProperty("integrationKey")]
        public string IntegrationKey { get; set; } = default!;
        
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
        [JsonProperty("lastSync")]
        public string? LastSync { get; set; }
        
        [JsonProperty("linkUrl")]
        public string LinkUrl { get; set; } = default!;
        
        [JsonProperty("platformName")]
        public string PlatformName { get; set; } = default!;
        
        /// <summary>
        /// A source-specific ID used to distinguish between different sources originating from the same data connection. In general, a data connection is a single data source. However, for TrueLayer, `sourceId` is associated with a specific bank and has a many-to-one relationship with the `integrationId`.
        /// </summary>
        [JsonProperty("sourceId")]
        public string SourceId { get; set; } = default!;
        
        /// <summary>
        /// The type of platform of the connection.
        /// </summary>
        [JsonProperty("sourceType")]
        public ConnectionSourceType SourceType { get; set; } = default!;
        
        /// <summary>
        /// The current authorization status of the data connection.
        /// </summary>
        [JsonProperty("status")]
        public DataConnectionStatus Status { get; set; } = default!;
        
    }
    
}