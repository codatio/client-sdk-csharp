
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
    using CodatSyncExpenses.Models.Shared;
    using CodatSyncExpenses.Utils;
    
    
    public class UpdateCustomerRequest
    {
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Customer? Customer { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; }
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=customerId")]
        public string CustomerId { get; set; }
        
        /// <summary>
        /// When updating data in the destination platform Codat checks the `sourceModifiedDate` against the `lastupdated` date from the accounting platform, if they're different Codat will return an error suggesting you should initiate another pull of the data. If this is set to `true` then the update will override this check.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=forceUpdate")]
        public bool? ForceUpdate { get; set; }
        
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=timeoutInMinutes")]
        public int? TimeoutInMinutes { get; set; }
        
    }
    
}