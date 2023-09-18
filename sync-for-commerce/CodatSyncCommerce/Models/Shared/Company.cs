
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// In Codat, a company represents a business sharing access to their data. Each company can have multiple &lt;a href=&quot;https://docs.codat.io/sync-for-commerce-api#/schemas/Connection&quot;&gt;connections&lt;/a&gt; to different data sources such as one connection to &lt;a href=&quot;https://docs.codat.io/integrations/accounting/xero/accounting-xero&quot;&gt;Xero&lt;/a&gt; for accounting data, two connections to &lt;a href=&quot;https://docs.codat.io/integrations/banking/plaid/banking-plaid&quot;&gt;Plaid&lt;/a&gt; for two bank accounts and a connection to &lt;a href=&quot;https://docs.codat.io/integrations/commerce/zettle/commerce-zettle&quot;&gt;Zettle&lt;/a&gt; for POS data.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// Typically each company is one of your customers.<br/>
    /// <br/>
    /// When you create a company, you can specify a `name` and we will automatically generate a unique `id` for the company. You can also add a `description` to store any additional information about the company.
    /// </remarks>
    /// </summary>
    public class Company
    {

        /// <summary>
        /// In Codat&amp;apos;s data model, dates and times are represented using the &amp;lt;a class=&amp;quot;external&amp;quot; href=&amp;quot;https://en.wikipedia.org/wiki/ISO_8601&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;ISO 8601 standard&amp;lt;/a&amp;gt;. Date and time fields are formatted as strings; for example:&lt;br/&gt;
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
        public string? Created { get; set; }

        [JsonProperty("createdByUserName")]
        public string? CreatedByUserName { get; set; }

        [JsonProperty("dataConnections")]
        public List<Connection>? DataConnections { get; set; }

        /// <summary>
        /// Additional information about the company. This can be used to store foreign IDs, references, etc.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// In Codat&amp;apos;s data model, dates and times are represented using the &amp;lt;a class=&amp;quot;external&amp;quot; href=&amp;quot;https://en.wikipedia.org/wiki/ISO_8601&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;ISO 8601 standard&amp;lt;/a&amp;gt;. Date and time fields are formatted as strings; for example:&lt;br/&gt;
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
        /// The name of the company
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// The `redirect` &lt;a href=&quot;https://docs.codat.io/auth-flow/authorize-hosted-link&quot;&gt;Link URL&lt;/a&gt; enabling the customer to start their auth flow journey for the company.
        /// </summary>
        [JsonProperty("redirect")]
        public string Redirect { get; set; } = default!;
    }
}