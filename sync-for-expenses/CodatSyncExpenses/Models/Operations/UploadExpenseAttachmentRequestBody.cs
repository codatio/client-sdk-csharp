
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Operations
{
    using CodatSyncExpenses.Utils;
    
    
    public class UploadExpenseAttachmentRequestBody
    {
        [SpeakeasyMetadata("multipartForm:content")]
        public byte[] Content { get; set; }
        
        [SpeakeasyMetadata("multipartForm:name=requestBody")]
        public string RequestBody { get; set; }
        
    }
    
}