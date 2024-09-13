//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Requests
{
    using Codat.Sync.Payables.Utils;
    
    public class ListSuppliersRequest
    {

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
        /// Retrieve the next page of results using the continuation token from the previous response.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=continuationToken")]
        public string? ContinuationToken { get; set; }

        /// <summary>
        /// Codat query string allows you to filter by `sourceModifiedDate` or if a supplier is `Active` or `Archived` in the accounting software. Learn more about Codat&apos;s query string <a href="https://docs.codat.io/using-the-api/querying">here</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=query")]
        public string? Query { get; set; }
    }
}