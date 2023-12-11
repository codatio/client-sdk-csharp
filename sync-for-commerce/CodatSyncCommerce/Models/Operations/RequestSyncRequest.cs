
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Operations
{
    using Codat.Sync.Commerce.Models.Shared;
    using Codat.Sync.Commerce.Utils;
    
    public class RequestSyncRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public SyncToLatestArgs? SyncToLatestArgs { get; set; }

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;
    }
}