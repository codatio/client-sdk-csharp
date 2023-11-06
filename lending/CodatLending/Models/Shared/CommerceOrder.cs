
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// Orders contain the transaction details for all products sold by the company, and include details of any payments, service charges, or refunds related to each order. You can use data from the Orders endpoints to calculate key metrics, such as gross sales values and monthly recurring revenue (MRR).<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Explore our <a href="https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&amp;dataType=commerce-orders">data coverage</a> for this data type.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class CommerceOrder
    {

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
        [JsonProperty("closedDate")]
        public string? ClosedDate { get; set; }

        /// <summary>
        /// The Codat country property is returned as it was provided in the underlying platform by the company without any formatting on our part.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// Depending on the platform the value of this property will either be an &lt;a href=&quot;https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes&quot; target=&quot;_blank&quot;&gt;ISO 3166&lt;/a&gt; code (2-alpha or 3-alpha) or free-form text returned as a string name in our model. <br/>
        /// <br/>
        /// For POST operations against platforms that demand a specific format for the country code, we have documented accepted values in the <a href="https://docs.codat.io/lending-api#/operations/get-companies-companyId-connections-connectionId-push">options</a> endpoint.
        /// </remarks>
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }

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

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Reference to the customer that placed the order.
        /// </summary>
        [JsonProperty("customerRef")]
        public CommerceCustomerRef? CustomerRef { get; set; }

        /// <summary>
        /// A unique, persistent identifier for this record
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Reference to the geographic location where the order was placed.
        /// </summary>
        [JsonProperty("locationRef")]
        public LocationRef? LocationRef { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        [JsonProperty("orderLineItems")]
        public List<OrderLineItem>? OrderLineItems { get; set; }

        /// <summary>
        /// Friendly reference for the order in the commerce or point of sale platform.
        /// </summary>
        [JsonProperty("orderNumber")]
        public string? OrderNumber { get; set; }

        [JsonProperty("payments")]
        public List<PaymentRef>? Payments { get; set; }

        [JsonProperty("serviceCharges")]
        public List<ServiceCharge>? ServiceCharges { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. <br/>
        /// 
        /// <remarks>
        /// <br/>
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. <a href="https://docs.codat.io/using-the-api/supplemental-data/overview">Learn more</a> about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplementalData? SupplementalData { get; set; }

        /// <summary>
        /// Total amount of the order, including discounts, refunds, and tax, but excluding gratuities.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Total amount of any discounts applied to the order, excluding tax. This is typically positive (for discounts which decrease the amount of the order), but can also be negative (for discounts which increase the amount of the order).
        /// </summary>
        [JsonProperty("totalDiscount")]
        public decimal? TotalDiscount { get; set; }

        /// <summary>
        /// Extra amount added to the order.
        /// </summary>
        [JsonProperty("totalGratuity")]
        public decimal? TotalGratuity { get; set; }

        /// <summary>
        /// Total amount of any refunds issued on the order, including discounts and tax, but excluding gratuities. This is always negative.
        /// </summary>
        [JsonProperty("totalRefund")]
        public decimal? TotalRefund { get; set; }

        /// <summary>
        /// Total amount of tax applied to the order.
        /// </summary>
        [JsonProperty("totalTaxAmount")]
        public decimal? TotalTaxAmount { get; set; }
    }
}