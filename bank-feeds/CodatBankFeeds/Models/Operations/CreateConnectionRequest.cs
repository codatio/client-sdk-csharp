
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds.Models.Operations
{
    using CodatBankFeeds.Utils;
    
    public class CreateConnectionRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public CreateConnectionRequestBody? RequestBody { get; set; }

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;
    }
}