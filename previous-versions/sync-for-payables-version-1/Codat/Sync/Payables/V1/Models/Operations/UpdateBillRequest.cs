//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Operations
{
    using Codat.Sync.Payables.V1.Models.Shared;
    using Codat.Sync.Payables.V1.Utils;
    
    public class UpdateBillRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Bill? Bill { get; set; } = null;

        /// <summary>
        /// Unique identifier for a bill.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=billId")]
        public string BillId { get; set; } = default!;

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
        /// When updating data in the destination platform Codat checks the `sourceModifiedDate` against the `lastupdated` date from the accounting software, if they&apos;re different Codat will return an error suggesting you should initiate another pull of the data. If this is set to `true` then the update will override this check.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=forceUpdate")]
        public bool? ForceUpdate { get; set; } = false;

        /// <summary>
        /// Time limit for the push operation to complete before it is timed out.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=timeoutInMinutes")]
        public int? TimeoutInMinutes { get; set; }
    }
}