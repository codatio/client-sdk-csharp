
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
    /// > View the coverage for customers in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers" target="_blank">Data coverage explorer</a>.
    /// 
    /// <remarks>
    /// 
    /// ## Overview
    /// 
    /// A customer is a person or organisation that buys goods or services. From the Customers endpoints, you can retrieve a [list of all the customers of a company](https://api.codat.io/swagger/index.html#/Customers/get_companies__companyId__data_customers).
    /// 
    /// Customers' data links to accounts receivable [invoices](https://docs.codat.io/accounting-api#/schemas/Invoice).
    /// 
    /// </remarks>
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// An array of Addresses.
        /// </summary>
        [JsonProperty("addresses")]
        public List<Items>? Addresses { get; set; }
        
        /// <summary>
        /// Name of the main contact for the identified customer.
        /// </summary>
        [JsonProperty("contactName")]
        public string? ContactName { get; set; }
        
        /// <summary>
        /// An array of Contacts.
        /// </summary>
        [JsonProperty("contacts")]
        public List<Contact>? Contacts { get; set; }
        
        /// <summary>
        /// Name of the customer as recorded in the accounting system, typically the company name.
        /// </summary>
        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }
        
        /// <summary>
        /// The currency data type in Codat is the [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code, e.g. _GBP_.
        /// 
        /// <remarks>
        /// 
        /// ## Unknown currencies
        /// 
        /// In line with the ISO 4217 specification, the code _XXX_ is used when the data source does not return a currency for a transaction. 
        /// 
        /// There are only a very small number of edge cases where this currency code is returned by the Codat system.
        /// </remarks>
        /// </summary>
        [JsonProperty("defaultCurrency")]
        public string? DefaultCurrency { get; set; }
        
        /// <summary>
        /// Email address the customer can be contacted by.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string? EmailAddress { get; set; }
        
        /// <summary>
        /// Identifier for the customer, unique to the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        /// <summary>
        /// Phone number the customer can be contacted by.
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }
        
        /// <summary>
        /// Company number. In the UK, this is typically the Companies House company registration number.
        /// </summary>
        [JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; }
        
        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
        
        /// <summary>
        /// Status of customer.
        /// </summary>
        [JsonProperty("status")]
        public CustomerStatus Status { get; set; } = default!;
        
        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. 
        /// 
        /// <remarks>
        /// 
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. [Learn more](https://docs.codat.io/using-the-api/supplemental-data/overview) about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplementalData? SupplementalData { get; set; }
        
        /// <summary>
        /// Company tax number.
        /// </summary>
        [JsonProperty("taxNumber")]
        public string? TaxNumber { get; set; }
        
    }
    
}