
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
    
    
    public class ListAccountingDirectIncomeAttachmentsRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; }
        
        /// <summary>
        /// Unique identifier for a direct income
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=directIncomeId")]
        public string DirectIncomeId { get; set; }
        
    }
    
}