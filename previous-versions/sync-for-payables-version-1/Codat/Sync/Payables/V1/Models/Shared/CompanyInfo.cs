//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Shared
{
    using Codat.Sync.Payables.V1.Models.Shared;
    using Codat.Sync.Payables.V1.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// &gt; View the coverage for company profile in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=cashFlowStatement&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Company info provides standard details about a linked company such as their address, phone number, and company registration.<br/>
    /// <br/>
    /// &gt; **Company information or companies?**<br/>
    /// &gt; <br/>
    /// &gt; Company profile is standard information that is held in the accounting software about a company. `Companies` is an endpoint that lists businesses in the Codat system that have linked and shared their data sources.
    /// </remarks>
    /// </summary>
    public class CompanyInfo
    {

        /// <summary>
        /// Identifier or reference for the company in the accounting software.
        /// </summary>
        [JsonProperty("accountingPlatformRef")]
        public string? AccountingPlatformRef { get; set; } = null;

        /// <summary>
        /// An array of Addresses.
        /// </summary>
        [JsonProperty("addresses")]
        public List<Address>? Addresses { get; set; } = null;

        /// <summary>
        /// Currency set in the accounting software of the linked company. Used by the currency rate.
        /// </summary>
        [JsonProperty("baseCurrency")]
        public string? BaseCurrency { get; set; } = null;

        /// <summary>
        /// Registered legal name of the linked company.
        /// </summary>
        [JsonProperty("companyLegalName")]
        public string? CompanyLegalName { get; set; } = null;

        /// <summary>
        /// Name of the linked company.
        /// </summary>
        [JsonProperty("companyName")]
        public string? CompanyName { get; set; } = null;

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
        [JsonProperty("createdDate")]
        public string? CreatedDate { get; set; }

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
        [JsonProperty("financialYearStartDate")]
        public string? FinancialYearStartDate { get; set; }

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
        [JsonProperty("ledgerLockDate")]
        public string? LedgerLockDate { get; set; }

        /// <summary>
        /// An array of phone numbers.
        /// </summary>
        [JsonProperty("phoneNumbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; } = null;

        /// <summary>
        /// Registration number given to the linked company by the companies authority in the country of origin. In the UK this is Companies House.
        /// </summary>
        [JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; } = null;

        /// <summary>
        /// URL addresses for the accounting source.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// For example, for Xero integrations two URLs are returned. These have many potential use cases, such as <a href="https://developer.xero.com/documentation/api-guides/deep-link-xero">deep linking</a>.
        /// </remarks>
        /// </summary>
        [JsonProperty("sourceUrls")]
        public Dictionary<string, string>? SourceUrls { get; set; } = null;

        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. <br/>
        /// 
        /// <remarks>
        /// <br/>
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting software. <a href="https://docs.codat.io/using-the-api/supplemental-data/overview">Learn more</a> about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplementalData? SupplementalData { get; set; }

        /// <summary>
        /// Company tax number.
        /// </summary>
        [JsonProperty("taxNumber")]
        public string? TaxNumber { get; set; } = null;

        /// <summary>
        /// An array of weblinks.
        /// </summary>
        [JsonProperty("webLinks")]
        public List<WebLink>? WebLinks { get; set; } = null;
    }
}