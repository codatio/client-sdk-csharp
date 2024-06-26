
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Operations
{
    using Codat.Sync.Expenses.Models.Shared;
    using Codat.Sync.Expenses.Utils;
    
    public class CreateTransferTransactionRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public CreateTransferRequest? CreateTransferRequest { get; set; }

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// The unique identifier for your SMB&apos;s transaction.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=transactionId")]
        public string TransactionId { get; set; } = default!;
    }
}