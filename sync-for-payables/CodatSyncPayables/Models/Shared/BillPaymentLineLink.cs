
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
    
    
    public class BillPaymentLineLink
    {
        /// <summary>
        /// Amount by which the balance of the linked entity is altered, in the currency of the linked entity.
        /// 
        /// <remarks>
        /// 
        /// - A negative link amount reduces the outstanding amount on the accounts payable account.
        /// - A positive link amount increases the outstanding amount on the accounts payable account.
        /// </remarks>
        /// </summary>
        [JsonProperty("amount")]
        public float? Amount { get; set; }
        
        /// <summary>
        /// Rate to convert the total amount of the payment into the base currency for the company at the time of the payment.
        /// 
        /// <remarks>
        /// 
        /// Currency rates in Codat are implemented as the multiple of foreign currency units to each base currency unit.  
        /// 
        /// It is not possible to perform the currency conversion with two or more non-base currencies participating in the transaction. For example, if a company's base currency is USD, and it has a bill issued in EUR, then the bill payment must happen in USD or EUR.
        /// 
        /// Where the currency rate is provided by the underlying accounting platform, it will be available from Codat with the same precision (up to a maximum of 9 decimal places). 
        /// 
        /// For accounting platforms which do not provide an explicit currency rate, it is calculated as `baseCurrency / foreignCurrency` and will be returned to 9 decimal places.
        /// 
        /// ## Examples with base currency of GBP
        /// 
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (GBP) |
        /// | :--------------- | :------------- | :------------ | :------------------------- |
        /// | **USD**          | $20            | 0.781         | £15.62                     |
        /// | **EUR**          | €20            | 0.885         | £17.70                     |
        /// | **RUB**          | ₽20            | 0.011         | £0.22                      |
        /// 
        /// ## Examples with base currency of USD
        /// 
        /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (USD) |
        /// | :--------------- | :------------- | :------------ | :------------------------- |
        /// | **GBP**          | £20            | 1.277         | $25.54                     |
        /// | **EUR**          | €20            | 1.134         | $22.68                     |
        /// | **RUB**          | ₽20            | 0.015         | $0.30                      |
        /// </remarks>
        /// </summary>
        [JsonProperty("currencyRate")]
        public float? CurrencyRate { get; set; }
        
        /// <summary>
        /// Unique identifier of the transaction represented by the link.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// Types of links to bill payment lines.
        /// </summary>
        [JsonProperty("type")]
        public BillPaymentLineLinkType Type { get; set; }
        
    }
    
}