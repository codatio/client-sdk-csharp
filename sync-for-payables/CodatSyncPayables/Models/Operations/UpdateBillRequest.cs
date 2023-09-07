
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
    using CodatSyncPayables.Models.Shared;
    using CodatSyncPayables.Utils;
    
    
    public class UpdateBillRequest
    {
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Bill? Bill { get; set; }
        
        /// <summary>
        /// Unique identifier for a bill
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=billId")]
        public string BillId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; }
        
        /// <summary>
        /// When updating data in the destination platform Codat checks the `sourceModifiedDate` against the `lastupdated` date from the accounting platform, if they're different Codat will return an error suggesting you should initiate another pull of the data. If this is set to `true` then the update will override this check.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=forceUpdate")]
        public bool? ForceUpdate { get; set; }
        
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=timeoutInMinutes")]
        public int? TimeoutInMinutes { get; set; }
        
    }
    
}