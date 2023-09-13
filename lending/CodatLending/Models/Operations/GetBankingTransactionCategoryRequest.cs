
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Operations
{
    using CodatLending.Utils;
    
    
    public class GetBankingTransactionCategoryRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; } = default!;
        
        /// <summary>
        /// The unique identifier for a banking transaction category
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=transactionCategoryId")]
        public string TransactionCategoryId { get; set; } = default!;
        
    }
    
}