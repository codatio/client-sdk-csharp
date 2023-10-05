
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
    /// A connection represents a <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Company">company&apos;s</a> connection to a data source and allows you to synchronize data (pull and/or push) with that source.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// A company can have multiple data connections depending on the type of data source it is connecting to. For example, a single company can link to:<br/>
    /// <br/>
    /// - <a href="https://docs.codat.io/accounting-api/overview">Accounting data</a> - 1 active connection.<br/>
    /// - <a href="https://docs.codat.io/banking-api/overview">Banking data</a> - Multiple active connections.<br/>
    /// - <a href="https://docs.codat.io/commerce-api/overview">Commerce data</a> - Multiple active connections.<br/>
    /// Any combination of accounting, banking, and commerce data connections is allowed.<br/>
    /// <br/>
    /// Before you can use a data connection to pull or push data, the company must grant you access to their business data by <a href="https://docs.codat.io/auth-flow/overview">linking the connection</a>.
    /// </remarks>
    /// </summary>
    public class Connection
    {

        [JsonProperty("additionalProperties")]
        public object? AdditionalProperties { get; set; }

        [JsonProperty("connectionInfo")]
        public Dictionary<string, string>? ConnectionInfo { get; set; }

        /// <summary>
        /// In Codat&apos;s data model, dates and times are represented using the &lt;a class=&quot;external&quot; href=&quot;https://en.wikipedia.org/wiki/ISO_8601&quot; target=&quot;_blank&quot;&gt;ISO 8601 standard&lt;/a&gt;. Date and time fields are formatted as strings; for example:<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// ```<br/>
        /// 2020-10-08T22:40:50Z<br/>
        /// 2021-01-01T00:00:00<br/>
        /// ```<br/>
        /// <br/>
        /// <br/>
        /// <br/>
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:<br/>
        /// <br/>
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`<br/>
        /// - Unqualified local time: `2021-11-15T01:00:00`<br/>
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`<br/>
        /// <br/>
        /// &gt; Time zones<br/>
        /// &gt; <br/>
        /// &gt; Not all dates from Codat will contain information about time zones.  <br/>
        /// &gt; Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; } = default!;

        [JsonProperty("dataConnectionErrors")]
        public List<DataConnectionError>? DataConnectionErrors { get; set; }

        /// <summary>
        /// Unique identifier for a company&apos;s data connection.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A Codat ID representing the integration.
        /// </summary>
        [JsonProperty("integrationId")]
        public string IntegrationId { get; set; } = default!;

        /// <summary>
        /// A unique four-character ID that identifies the platform of the company&apos;s data connection. This ensures continuity if the platform changes its name in the future.
        /// </summary>
        [JsonProperty("integrationKey")]
        public string IntegrationKey { get; set; } = default!;

        /// <summary>
        /// In Codat&apos;s data model, dates and times are represented using the &lt;a class=&quot;external&quot; href=&quot;https://en.wikipedia.org/wiki/ISO_8601&quot; target=&quot;_blank&quot;&gt;ISO 8601 standard&lt;/a&gt;. Date and time fields are formatted as strings; for example:<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// ```<br/>
        /// 2020-10-08T22:40:50Z<br/>
        /// 2021-01-01T00:00:00<br/>
        /// ```<br/>
        /// <br/>
        /// <br/>
        /// <br/>
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:<br/>
        /// <br/>
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`<br/>
        /// - Unqualified local time: `2021-11-15T01:00:00`<br/>
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`<br/>
        /// <br/>
        /// &gt; Time zones<br/>
        /// &gt; <br/>
        /// &gt; Not all dates from Codat will contain information about time zones.  <br/>
        /// &gt; Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("lastSync")]
        public string? LastSync { get; set; }

        /// <summary>
        /// The link URL your customers can use to authorize access to their business application.
        /// </summary>
        [JsonProperty("linkUrl")]
        public string LinkUrl { get; set; } = default!;

        /// <summary>
        /// Name of integration connected to company.
        /// </summary>
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