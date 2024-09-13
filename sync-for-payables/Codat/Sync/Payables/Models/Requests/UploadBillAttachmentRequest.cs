//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Requests
{
    using Codat.Sync.Payables.Models.Components;
    using Codat.Sync.Payables.Utils;
    
    public class UploadBillAttachmentRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for a connection.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for a bill.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=billId")]
        public string BillId { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=multipart/form-data")]
        public AttachmentUpload? AttachmentUpload { get; set; }
    }
}