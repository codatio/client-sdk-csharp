
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
    using System;
    
    public class CreateBillPaymentResponse
    {

        /// <summary>
        /// Contains a single entry that communicates which record has changed and the manner in which it changed. 
        /// </summary>
        [JsonProperty("changes")]
        public List<PushOperationChange>? Changes { get; set; }

        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("companyId")]
        public string CompanyId { get; set; } = default!;

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
        [JsonProperty("completedOnUtc")]
        public string? CompletedOnUtc { get; set; }

        /// <summary>
        /// &amp;gt; **Bill payments or payments?**  &lt;br/&gt;
        /// 
        /// <remarks>
        /// &gt; <br/>
        /// &gt; We distinguish between transactions where the company received money vs. paid money. If the transaction represents a company spending money (accounts payable) we call this a Bill payment.<br/>
        /// &gt;<br/>
        /// &gt; See <a href="https://docs.codat.io/accounting-api#/schemas/Payment">payments</a> for the accounts receivable equivalent of Bill payments, which covers <a href="https://docs.codat.io/accounting-api#/schemas/Invoice">invoices</a> and <a href="https://docs.codat.io/accounting-api#/schemas/CreditNote">credit notes</a>.<br/>
        /// <br/>
        /// &gt; View the coverage for bill payments in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=billPayments&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
        /// <br/>
        /// ## Overview<br/>
        /// <br/>
        /// Bill payments include all accounts payable transaction data (<a href="https://docs.codat.io/accounting-api#/schemas/Bill">bills</a> and <a href="https://docs.codat.io/accounting-api#/schemas/BillCreditNote">credit notes against bills</a>).<br/>
        /// <br/>
        /// A bill payment in Codat usually represents an allocation of money within any customer accounts payable account. This includes, but is not strictly limited to:<br/>
        /// <br/>
        /// - A payment made against a bill — for example, a credit card payment, cheque payment, or cash payment.<br/>
        /// - An allocation of a supplier&apos;s credit note to a bill or perhaps a refund.<br/>
        /// - A bill payment made directly to an accounts payable account. This could be an overpayment or a prepayment, or a refund of a payment made directly to an accounts payable account.<br/>
        /// <br/>
        /// Depending on the bill payments which are allowed by the underlying accounting package, some of these types may be combined. Please see the example data section for samples of what these cases look like.<br/>
        /// <br/>
        /// In Codat, a bill payment contains details of:<br/>
        /// <br/>
        /// - When the bill payment was recorded in the accounting system.<br/>
        /// - How much it is for and in the currency.<br/>
        /// - Who the payment has been paid to, the _supplier_.<br/>
        /// - The types of bill payments, the _line items_.  <br/>
        /// <br/>
        /// Some accounting platforms give a separate name to purchases where the payment is made immediately, such as something bought with a credit card or online payment. One example of this would be QuickBooks Online&apos;s _expenses_. You can find these types of transactions in our <a href="https://docs.codat.io/accounting-api#/schemas/DirectCost">Direct costs</a> data model.<br/>
        /// <br/>
        /// Bill payments is a child data type of <a href="https://docs.codat.io/accounting-api#/schemas/AccountTransaction">account transactions</a>.<br/>
        /// <br/>
        /// ---<br/>
        /// <br/>
        /// ## Bill payment types<br/>
        /// <br/>
        /// ### Payment of a bill<br/>
        /// <br/>
        /// A payment paying a single bill should have the following properties:<br/>
        /// <br/>
        /// - A `totalAmount` indicating the amount of the bill that was paid. This is always positive.<br/>
        /// - A `lines` array containing one element with the following properties:<br/>
        ///   - An `amount` equal to the `totalAmount` above.<br/>
        ///   - A `links` array containing one element with the following properties:<br/>
        ///     - A `type` indicating the type of link, in this case a `Bill`.<br/>
        ///     - An `id` containing the ID of the bill that was paid.<br/>
        ///     - An amount of `-totalAmount` (negative `totalAmount`), indicating that the entirety of the paid amount is allocated to the bill.<br/>
        /// <br/>
        /// ### Payment of multiple bills<br/>
        /// <br/>
        /// It is possible for one payment to pay multiple bills. This can be represented using two possible formats, depending on how the supplier keeps their books:<br/>
        /// <br/>
        /// 1. The payment has multiple entries in its **lines** array, one for each bill that is paid. Each line will follow the above example for paying a bill, and the rules detailed in the data model.<br/>
        /// 2. The payment has a line with multiple links to each bill. This occurs when the proportion of the original payment allocated to each bill is not available.<br/>
        /// <br/>
        /// Each line is the same as those described above, with the **amount** indicating how much of the payment is allocated to the bill. The **amount** on the lines sum to the **totalAmount** on the payment.<br/>
        /// <br/>
        /// &gt; Pushing batch payments to Xero<br/>
        /// &gt; <br/>
        /// &gt; When pushing a single bill payment to Xero to pay multiple bills, only the first format is supported—multiple entries in the payment **lines** array.<br/>
        /// <br/>
        /// ### Payments and refunds on account<br/>
        /// <br/>
        /// A payment on account, that is a payment that doesn’t pay a specific bill, has one entry in its lines array.<br/>
        /// <br/>
        /// The line has the following properties:<br/>
        /// <br/>
        /// - A **totalAmount** indicating the amount paid by a supplier or refunded to them by a company. A payment to the supplier is always negative. A refund is always positive.<br/>
        /// - A **links** array containing one element with the following properties:<br/>
        ///   - A **type** indicating the type of link. For a payment this is `PaymentOnAccount`. For a refund this is `Refund`.<br/>
        ///   - The **id** containing the ID of the supplier.<br/>
        ///   - An amount for the link is `0` **totalAmount** or the amount of the payment or refund.<br/>
        /// <br/>
        /// It is possible to have a payment that is part on account and part allocated to a bill. Each line should follow the examples above.<br/>
        /// <br/>
        /// ### Using a credit note to pay a bill<br/>
        /// <br/>
        /// The payment of a bill using a credit note has one entry in its `lines` array. This **line** has the following properties:<br/>
        /// <br/>
        /// - An **amount** indicating the amount of money moved, which in this case is `0`, as the credit note and bill allocation must balance each other.<br/>
        /// - A **links** array containing two elements:<br/>
        ///   - The first link has:<br/>
        ///     - A **type** indicating the type of link, in this case a `Bill`.<br/>
        ///     - An **id** containing the ID of the bill that was paid.<br/>
        ///   - The second link has:<br/>
        ///     - A **type** indicating the type of link, in this case a `CreditNote`.<br/>
        ///     - An **id** containing the ID of the credit note used by this payment.<br/>
        /// <br/>
        /// The **amount** field on the **line** equals the **totalAmount** on the payment.<br/>
        /// <br/>
        /// ### Refunding a credit note<br/>
        /// <br/>
        /// A bill payment refunding a credit note has one entry in its **lines** array. This line has the following properties:<br/>
        /// <br/>
        /// - An **amount** indicating the amount of the credit note that was refunded. This is always negative, indicating that it is a refund.<br/>
        /// - A **links** array containing one element with the following properties:<br/>
        ///   - A **type** indicating the type of `link`, in this case a `CreditNote`.<br/>
        ///   - An **id** containing the ID of the credit note that was refunded.<br/>
        /// <br/>
        /// The **totalAmount** field on the payment equals the line&apos;s **amount** field. These are both negative, as this is money leaving accounts payable.<br/>
        /// <br/>
        /// ### Refunding a payment<br/>
        /// <br/>
        /// If a payment is refunded, for example, when a company overpaid a bill and the overpayment is returned, there are two payment records: <br/>
        /// <br/>
        /// - One for the incoming overpayment.<br/>
        /// - Another for the outgoing refund.<br/>
        /// <br/>
        /// The payment issuing the refund is identified by the fact that the **totalAmount** is negative. This payment has one entry in its lines array that have the following properties:<br/>
        /// <br/>
        /// - An **amount** indicating the amount that was refunded. This is always negative.<br/>
        /// - A **links** array containing one element with the following properties:<br/>
        ///   - A **type** indicating the type of a the link, in this case a `BillPayment`.<br/>
        ///   - An **id** containing the ID of the payment that was refunded.<br/>
        /// <br/>
        /// The **amount** field on the line equals the **totalAmount** on the payment and is negative as this is money leaving accounts payable.<br/>
        /// <br/>
        /// The payment that was refunded can be identified as it has a line where the `amount` on its `line` is positive and the type of the link is `Refund`. This payment may have several entries in its **lines** array if it was partly used to pay an bill. For example, a £1,050 payment paying a £1,000 bill with a refund of £50 has two lines: <br/>
        /// <br/>
        /// - One for £1,000 linked to the bill that was paid<br/>
        /// - Another for £50 linked to the payment that refunded the over payment. This link is of type `Refund` but the ID corresponds to a bill payment.<br/>
        /// <br/>
        /// The line linked to the bill payment has the following properties:<br/>
        /// <br/>
        /// - An **amount** indicating the amount that was refunded. This is positive as its money that was added to accounts payable, but is balanced out by the negative amount of the refund.<br/>
        /// - A **links** array containing one element with the following properties:<br/>
        ///   - A **type** indicating the type of the link, in this case a `Refund`.<br/>
        ///   - An **id** containing the ID of the payment that refunded this line.<br/>
        /// <br/>
        /// &gt; Linked payments<br/>
        /// &gt; <br/>
        /// &gt; Not all accounting packages support linked payments in this way. In these platforms you may see a payment on account and a refund on account.<br/>
        /// <br/>
        /// ## Foreign currencies<br/>
        /// <br/>
        /// There are two types of currency rate that are detailed in the bill payments data type: <br/>
        /// <br/>
        /// Payment currency rate: <br/>
        /// <br/>
        /// - Base currency of the accounts payable account.<br/>
        /// - Foreign currency of the bill payment.<br/>
        /// <br/>
        /// Payment line link currency rate: <br/>
        /// <br/>
        /// - Base currency of the item that the link represents.<br/>
        /// - Foreign currency of the payment.<br/>
        /// <br/>
        /// These two rates allow the calculation of currency loss or gain for any of the transactions affected by the payment lines. The second rate is used when a bill payment is applied to an item in a currency that does not match either:<br/>
        /// <br/>
        /// - The base currency for the accounts payable account. <br/>
        /// - The currency of the item.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("data")]
        public BillPayment? Data { get; set; }

        /// <summary>
        /// Unique identifier for a company&amp;apos;s data connection.
        /// </summary>
        [JsonProperty("dataConnectionKey")]
        public string DataConnectionKey { get; set; } = default!;

        /// <summary>
        /// Available Data types
        /// </summary>
        [JsonProperty("dataType")]
        public DataType? DataType { get; set; }

        /// <summary>
        /// A message about the error.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted.
        /// </summary>
        [JsonProperty("pushOperationKey")]
        public string PushOperationKey { get; set; } = default!;

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
        [JsonProperty("requestedOnUtc")]
        public string RequestedOnUtc { get; set; } = default!;

        /// <summary>
        /// The current status of the push operation.
        /// </summary>
        [JsonProperty("status")]
        public PushOperationStatus Status { get; set; } = default!;

        /// <summary>
        /// Push status code.
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; } = default!;

        /// <summary>
        /// Number of minutes the push operation must complete within before it times out.
        /// </summary>
        [JsonProperty("timeoutInMinutes")]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Number of seconds the push operation must complete within before it times out.
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("timeoutInSeconds")]
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// A human-readable object describing validation decisions Codat has made when pushing data into the platform. If a push has failed because of validation errors, they will be detailed here.
        /// </summary>
        [JsonProperty("validation")]
        public Validation? Validation { get; set; }
    }
}