
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Operations
{
    using CodatSyncPayroll.Utils;
    
    
    public class GetPullOperationRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;
        
        /// <summary>
        /// Unique ID of a dataset or pull operation.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=datasetId")]
        public string DatasetId { get; set; } = default!;
        
    }
    
}