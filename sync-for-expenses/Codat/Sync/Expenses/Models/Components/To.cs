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
    
    public class To
    {

        /// <summary>
        /// Reference of the account you are transferring money to.
        /// </summary>
        [JsonProperty("accountRef")]
        public TransferTransactionRequestAccountReference AccountRef { get; set; } = default!;

        /// <summary>
        /// Amount that has been transferred to the account in the native currency of the account.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; } = default!;
    }
}