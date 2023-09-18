
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
    /// Represents a variation of a product available for sale, for example an item of clothing that may be available for sale in multiple sizes and colors.&lt;br/&gt;
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class ProductVariant
    {

        /// <summary>
        /// Unique product number of the variant. This might be a barcode, UPC, ISBN, etc.
        /// </summary>
        [JsonProperty("barcode")]
        public string? Barcode { get; set; }

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
        [JsonProperty("createdDate")]
        public string? CreatedDate { get; set; }

        /// <summary>
        /// A unique, persistent identifier for this record
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Information about the total inventory as well as the locations inventory is in.
        /// </summary>
        [JsonProperty("inventory")]
        public ProductInventory? Inventory { get; set; }

        /// <summary>
        /// Whether sales taxes are enabled for this product variant.
        /// </summary>
        [JsonProperty("isTaxEnabled")]
        public bool? IsTaxEnabled { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Name of the product recorded in the commerce or point of sale platform.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Prices for the product variants in different currencies.
        /// </summary>
        [JsonProperty("prices")]
        public List<ProductPrice>? Prices { get; set; }

        /// <summary>
        /// Indicates whether or not the product requires physical delivery.
        /// </summary>
        [JsonProperty("shippingRequired")]
        public bool? ShippingRequired { get; set; }

        /// <summary>
        /// SKU (stock keeping unit) of the variant, as defined by the merchant.
        /// </summary>
        [JsonProperty("sku")]
        public string? Sku { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        [JsonProperty("status")]
        public ProductVariantStatus? Status { get; set; }

        /// <summary>
        /// Unit of measure for the variant, such as `kg` or `meters`.
        /// </summary>
        [JsonProperty("unitOfMeasure")]
        public string? UnitOfMeasure { get; set; }

        /// <summary>
        /// VAT rate for the product variant if sales taxes are enabled.
        /// </summary>
        [JsonProperty("vatPercentage")]
        public decimal? VatPercentage { get; set; }
    }
}