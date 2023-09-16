
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
    
    public class CompanyConfiguration
    {

        [JsonProperty("bankAccount")]
        public BankAccount BankAccount { get; set; } = default!;

        /// <summary>
        /// &amp;gt; View the coverage for customers in the &amp;lt;a className=&amp;quot;external&amp;quot; href=&amp;quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;amp;dataType=customers&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;Data coverage explorer&amp;lt;/a&amp;gt;.&lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// ## Overview<br/>
        /// <br/>
        /// A customer is a person or organisation that buys goods or services. From the Customers endpoints, you can retrieve a <a href="https://api.codat.io/swagger/index.html#/Customers/get_companies__companyId__data_customers">list of all the customers of a company</a>.<br/>
        /// <br/>
        /// Customers&apos; data links to accounts receivable <a href="https://docs.codat.io/accounting-api#/schemas/Invoice">invoices</a>.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; } = default!;

        /// <summary>
        /// &amp;gt; View the coverage for suppliers in the &amp;lt;a className=&amp;quot;external&amp;quot; href=&amp;quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;amp;dataType=suppliers&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;Data coverage explorer&amp;lt;/a&amp;gt;.&lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// ## Overview<br/>
        /// <br/>
        /// From the **Suppliers** endpoints, you can retrieve a list of <a href="https://docs.codat.io/accounting-api#/operations/list-suppliers">all the suppliers for a company</a>. Suppliers&apos; data links to accounts payable <a href="https://docs.codat.io/accounting-api#/schemas/Bill">bills</a>.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; } = default!;
    }
}