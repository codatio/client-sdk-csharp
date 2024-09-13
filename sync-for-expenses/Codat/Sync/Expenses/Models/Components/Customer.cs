//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Components
{
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// &gt; View the coverage for customers in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=customers&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// A customer is a person or organisation that buys goods or services. From the Customers endpoints, you can retrieve a <a href="https://api.codat.io/swagger/index.html#/Customers/get_companies__companyId__data_customers">list of all the customers of a company</a>.<br/>
    /// <br/>
    /// Customers&apos; data links to accounts receivable <a href="https://docs.codat.io/sync-for-expenses-api#/schemas/Invoice">invoices</a>.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class Customer
    {

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Identifier for the customer, unique to the company in the accounting software.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the customer as recorded in the accounting system, typically the company name.
        /// </summary>
        [JsonProperty("customerName")]
        public string? CustomerName { get; set; } = null;

        /// <summary>
        /// Name of the main contact for the identified customer.
        /// </summary>
        [JsonProperty("contactName")]
        public string? ContactName { get; set; } = null;

        /// <summary>
        /// Email address the customer can be contacted by.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string? EmailAddress { get; set; } = null;

        /// <summary>
        /// The currency data type in Codat is the <a href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a> currency code, e.g. _GBP_.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// ## Unknown currencies<br/>
        /// <br/>
        /// In line with the ISO 4217 specification, the code _XXX_ is used when the data source does not return a currency for a transaction. <br/>
        /// <br/>
        /// There are only a very small number of edge cases where this currency code is returned by the Codat system.
        /// </remarks>
        /// </summary>
        [JsonProperty("defaultCurrency")]
        public string? DefaultCurrency { get; set; }

        /// <summary>
        /// Phone number the customer can be contacted by.
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; } = null;

        /// <summary>
        /// An array of Addresses.
        /// </summary>
        [JsonProperty("addresses")]
        public List<AccountingAddress>? Addresses { get; set; } = null;

        /// <summary>
        /// An array of Contacts.
        /// </summary>
        [JsonProperty("contacts")]
        public List<Contact>? Contacts { get; set; } = null;

        /// <summary>
        /// Company number. In the UK, this is typically the Companies House company registration number.
        /// </summary>
        [JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; } = null;

        /// <summary>
        /// Company tax number.
        /// </summary>
        [JsonProperty("taxNumber")]
        public string? TaxNumber { get; set; } = null;

        /// <summary>
        /// Status of customer.
        /// </summary>
        [JsonProperty("status")]
        public CustomerStatus Status { get; set; } = default!;

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

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
    }
}