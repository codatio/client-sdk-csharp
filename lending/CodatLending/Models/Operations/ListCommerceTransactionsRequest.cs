
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Operations
{
    using CodatLending.Utils;
    
    public class ListCommerceTransactionsRequest
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
        /// Field to order results by. <a href="https://docs.codat.io/using-the-api/ordering-results">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Page number. <a href="https://docs.codat.io/using-the-api/paging">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of records to return in a page. <a href="https://docs.codat.io/using-the-api/paging">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Codat query string. <a href="https://docs.codat.io/using-the-api/querying">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=query")]
        public string? Query { get; set; }
    }
}