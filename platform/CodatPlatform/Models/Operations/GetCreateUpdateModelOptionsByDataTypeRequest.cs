
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Operations
{
    using CodatPlatform.Models.Shared;
    using CodatPlatform.Utils;
    
    
    public class GetCreateUpdateModelOptionsByDataTypeRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; } = default!;
        
        /// <summary>
        /// The key of a Codat data type
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=dataType")]
        public DataType DataType { get; set; } = default!;
        
    }
    
}