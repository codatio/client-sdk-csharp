
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
    
    
    public class GetAccountingSupplierAttachmentRequest
    {
        /// <summary>
        /// Unique identifier for an attachment
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=attachmentId")]
        public string AttachmentId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; }
        
        /// <summary>
        /// Unique identifier for a supplier
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=supplierId")]
        public string SupplierId { get; set; }
        
    }
    
}