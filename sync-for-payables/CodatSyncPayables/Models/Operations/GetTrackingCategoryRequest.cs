
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Operations
{
    using CodatSyncPayables.Utils;
    
    
    public class GetTrackingCategoryRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=trackingCategoryId")]
        public string TrackingCategoryId { get; set; }
        
    }
    
}