
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// When querying Codat&amp;apos;s data model, some data types return `validDatatypeLinks` metadata in the JSON response. This indicates where that object can be used as a reference—a _valid link_—when creating or updating other data.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// For example, `validDatatypeLinks` might indicate the following references:<br/>
    /// <br/>
    /// - Which tax rates are valid to use on the line item of a bill.<br/>
    /// - Which items can be used when creating an invoice. <br/>
    /// <br/>
    /// You can use `validDatatypeLinks` to present your SMB customers with only valid choices when selecting objects from a list, for example.<br/>
    /// <br/>
    /// ## `validDatatypeLinks` example<br/>
    /// <br/>
    /// The following example uses the `Accounting.Accounts` data type. It shows that, on the linked integration, this account is valid as the account on a payment or bill payment; and as the account referenced on the line item of a direct income or direct cost. Because there is no valid link to Invoices or Bills, using this account on those data types will result in an error.<br/>
    /// <br/>
    /// ```json validDatatypeLinks for an account<br/>
    /// {<br/>
    ///             &quot;id&quot;: &quot;bd9e85e0-0478-433d-ae9f-0b3c4f04bfe4&quot;,<br/>
    ///             &quot;nominalCode&quot;: &quot;090&quot;,<br/>
    ///             &quot;name&quot;: &quot;Business Bank Account&quot;,<br/>
    ///             #...<br/>
    ///             &quot;validDatatypeLinks&quot;: [<br/>
    ///                 {<br/>
    ///                     &quot;property&quot;: &quot;Id&quot;,<br/>
    ///                     &quot;links&quot;: [<br/>
    ///                         &quot;Payment.AccountRef.Id&quot;,<br/>
    ///                         &quot;BillPayment.AccountRef.Id&quot;,<br/>
    ///                         &quot;DirectIncome.LineItems.AccountRef.Id&quot;,<br/>
    ///                         &quot;DirectCost.LineItems.AccountRef.Id&quot;<br/>
    ///                     ]<br/>
    ///                 }<br/>
    ///             ]<br/>
    ///         }<br/>
    /// ```<br/>
    /// <br/>
    /// <br/>
    /// <br/>
    /// ## Support for `validDatatypeLinks`<br/>
    /// <br/>
    /// Codat currently supports `validDatatypeLinks` for some data types on our Xero, QuickBooks Online, QuickBooks Desktop, Exact (NL), and Sage Business Cloud integrations. <br/>
    /// <br/>
    /// If you&apos;d like us to extend support to more data types or integrations, suggest or vote for this on our &lt;a href=&quot;https://portal.productboard.com/codat/5-product-roadmap&quot;&gt;Product Roadmap&lt;/a&gt;.
    /// </remarks>
    /// </summary>
    public class AccountValidDataTypeLinks
    {

        /// <summary>
        /// Supported `dataTypes` that the record can be linked to.
        /// </summary>
        [JsonProperty("links")]
        public List<string>? Links { get; set; }

        /// <summary>
        /// The property from the account that can be linked.
        /// </summary>
        [JsonProperty("property")]
        public string? Property { get; set; }
    }
}