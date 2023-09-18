
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Operations
{
    using CodatSyncCommerce.Models.Shared;
    using CodatSyncCommerce.Utils;
    
    public class UpdateConnectionRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public UpdateConnection? UpdateConnection { get; set; }

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; } = default!;
    }
}