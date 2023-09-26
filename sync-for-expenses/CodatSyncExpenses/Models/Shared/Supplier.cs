
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
    /// &amp;gt; View the coverage for suppliers in the &amp;lt;a className=&amp;quot;external&amp;quot; href=&amp;quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;amp;dataType=suppliers&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;Data coverage explorer&amp;lt;/a&amp;gt;.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// From the **Suppliers** endpoints, you can retrieve a list of <a href="https://docs.codat.io/sync-for-expenses-api#/operations/list-suppliers">all the suppliers for a company</a>. Suppliers&apos; data links to accounts payable <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Bill">bills</a>.
    /// </remarks>
    /// </summary>
    public class Supplier
    {

        /// <summary>
        /// An array of Addresses.
        /// </summary>
        [JsonProperty("addresses")]
        public List<SupplierAccountingAddress>? Addresses { get; set; }

        /// <summary>
        /// Name of the main contact for the supplier.
        /// </summary>
        [JsonProperty("contactName")]
        public string? ContactName { get; set; }

        /// <summary>
        /// Default currency the supplier&amp;apos;s transactional data is recorded in.
        /// </summary>
        [JsonProperty("defaultCurrency")]
        public string? DefaultCurrency { get; set; }

        /// <summary>
        /// Email address that the supplier may be contacted on.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Identifier for the supplier, unique to the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Phone number that the supplier may be contacted on.
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Company number of the supplier. In the UK, this is typically the company registration number issued by Companies House.
        /// </summary>
        [JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Status of the supplier.
        /// </summary>
        [JsonProperty("status")]
        public SupplierStatus Status { get; set; } = default!;

        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. &lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. <a href="https://docs.codat.io/using-the-api/supplemental-data/overview">Learn more</a> about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplierSupplementalData? SupplementalData { get; set; }

        /// <summary>
        /// Name of the supplier as recorded in the accounting system, typically the company name.
        /// </summary>
        [JsonProperty("supplierName")]
        public string? SupplierName { get; set; }

        /// <summary>
        /// Supplier&amp;apos;s company tax number.
        /// </summary>
        [JsonProperty("taxNumber")]
        public string? TaxNumber { get; set; }
    }
}