
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Newtonsoft.Json;
    
    public class BillPaymentLineLink
    {

        /// <summary>
        /// Amount by which the balance of the linked entity is altered, in the currency of the linked entity.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// - A negative link amount reduces the outstanding amount on the accounts payable account.<br/>
        /// - A positive link amount increases the outstanding amount on the accounts payable account.
        /// </remarks>
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Rate to convert the total amount of the payment into the base currency for the company at the time of the payment.<br/>
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
        /// | **RUB**          | ₽20            | 0.015         | $0.30                      |<br/>
        /// <br/>
        /// <br/>
        /// ### Integration-specific details<br/>
        /// <br/>
        /// | Integration       | Scenario                                        | System behavior                                                                                                                                                      |<br/>
        /// |-------------------|-------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------|<br/>
        /// | QuickBooks Online | Transaction currency differs from base currency | If currency rate value is left `null`, a rate of 1 will be used by QBO by default. To override this, include the required currency rate in the expense transaction.  |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Unique identifier of the transaction represented by the link.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Types of links to bill payment lines.
        /// </summary>
        [JsonProperty("type")]
        public BillPaymentLineLinkType Type { get; set; } = default!;
    }
}