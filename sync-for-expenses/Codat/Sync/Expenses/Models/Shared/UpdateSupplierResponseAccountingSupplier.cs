
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Shared
{
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// &gt; View the coverage for suppliers in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=suppliers&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// From the **Suppliers** endpoints, you can retrieve a list of <a href="https://docs.codat.io/sync-for-expenses-api#/operations/list-suppliers">all the suppliers for a company</a>. Suppliers&apos; data links to accounts payable <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Bill">bills</a>.
    /// </remarks>
    /// </summary>[Obsolete("This will be removed in a future release, please migrate away from it as soon as possible.")]
    public class UpdateSupplierResponseAccountingSupplier
    {

        /// <summary>
        /// An array of Addresses.
        /// </summary>
        [JsonProperty("addresses")]
        public List<Items>? Addresses { get; set; } = null;

        /// <summary>
        /// Name of the main contact for the supplier.
        /// </summary>
        [JsonProperty("contactName")]
        public string? ContactName { get; set; } = null;

        /// <summary>
        /// Default currency the supplier&apos;s transactional data is recorded in.
        /// </summary>
        [JsonProperty("defaultCurrency")]
        public string? DefaultCurrency { get; set; } = null;

        /// <summary>
        /// Email address that the supplier may be contacted on.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string? EmailAddress { get; set; } = null;

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
        public string? Phone { get; set; } = null;

        /// <summary>
        /// Company number of the supplier. In the UK, this is typically the company registration number issued by Companies House.
        /// </summary>
        [JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; } = null;

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Status of the supplier.
        /// </summary>
        [JsonProperty("status")]
        public SupplierStatus Status { get; set; } = default!;

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
        /// Name of the supplier as recorded in the accounting system, typically the company name.
        /// </summary>
        [JsonProperty("supplierName")]
        public string? SupplierName { get; set; } = null;

        /// <summary>
        /// Supplier&apos;s company tax number.
        /// </summary>
        [JsonProperty("taxNumber")]
        public string? TaxNumber { get; set; } = null;
    }
}