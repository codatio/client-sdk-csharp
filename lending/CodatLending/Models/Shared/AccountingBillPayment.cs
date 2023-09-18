
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
    public class AccountingBillPayment
    {

        /// <summary>
        /// Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.
        /// </summary>
        [JsonProperty("accountRef")]
        public AccountRef? AccountRef { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Rate to convert the total amount of the payment into the base currency for the company at the time of the payment.&lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// Currency rates in Codat are implemented as the multiple of foreign currency units to each base currency unit.  <br/>
        /// <br/>
        /// It is not possible to perform the currency conversion with two or more non-base currencies participating in the transaction. For example, if a company&apos;s base currency is USD, and it has a bill issued in EUR, then the bill payment must happen in USD or EUR.<br/>
        /// <br/>
        /// Where the currency rate is provided by the underlying accounting platform, it will be available from Codat with the same precision (up to a maximum of 9 decimal places). <br/>
        /// <br/>
        /// For accounting platforms which do not provide an explicit currency rate, it is calculated as `baseCurrency / foreignCurrency` and will be returned to 9 decimal places.<br/>
        /// <br/>
        /// ## Examples with base currency of GBP<br/>
        /// <br/>
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (GBP) |<br/>
        /// | :--------------- | :------------- | :------------ | :------------------------- |<br/>
        /// | **USD**          | $20            | 0.781         | £15.62                     |<br/>
        /// | **EUR**          | €20            | 0.885         | £17.70                     |<br/>
        /// | **RUB**          | ₽20            | 0.011         | £0.22                      |<br/>
        /// <br/>
        /// ## Examples with base currency of USD<br/>
        /// <br/>
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (USD) |<br/>
        /// | :--------------- | :------------- | :------------ | :------------------------- |<br/>
        /// | **GBP**          | £20            | 1.277         | $25.54                     |<br/>
        /// | **EUR**          | €20            | 1.134         | $22.68                     |<br/>
        /// | **RUB**          | ₽20            | 0.015         | $0.30                      |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public decimal? CurrencyRate { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; } = default!;

        /// <summary>
        /// Identifier for the bill payment, unique for the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An array of bill payment lines.
        /// </summary>
        [JsonProperty("lines")]
        public List<BillPaymentLine>? Lines { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Additional information associated with the payment.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

        [JsonProperty("paymentMethodRef")]
        public object? PaymentMethodRef { get; set; }

        /// <summary>
        /// Additional information associated with the payment.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Supplemental data is additional data you can include in our standard data types. &lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. <a href="https://docs.codat.io/using-the-api/supplemental-data/overview">Learn more</a> about supplemental data.
        /// </remarks>
        /// </summary>
        [JsonProperty("supplementalData")]
        public SupplementalData? SupplementalData { get; set; }

        [JsonProperty("supplierRef")]
        public SupplierRef? SupplierRef { get; set; }

        /// <summary>
        /// Amount of the payment in the payment currency. This value never changes and represents the amount of money that is paid into the supplier&amp;apos;s account.
        /// </summary>
        [JsonProperty("totalAmount")]
        public decimal? TotalAmount { get; set; }
    }
}