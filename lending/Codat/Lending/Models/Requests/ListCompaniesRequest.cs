//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Requests
{
    using Codat.Lending.Utils;
    
    public class ListCompaniesRequest
    {

        /// <summary>
        /// Page number. <a href="https://docs.codat.io/using-the-api/paging">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public int? Page { get; set; } = 1;

        /// <summary>
        /// Number of records to return in a page. <a href="https://docs.codat.io/using-the-api/paging">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public int? PageSize { get; set; } = 100;

        /// <summary>
        /// Codat query string. <a href="https://docs.codat.io/using-the-api/querying">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=query")]
        public string? Query { get; set; }

        /// <summary>
        /// Field to order results by. <a href="https://docs.codat.io/using-the-api/ordering-results">Read more</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Filter companies by tags using the &quot;equals&quot; (=), &quot;not equals&quot; (!=), and &quot;contains&quot; (~) operators with <a href="https://docs.codat.io/using-the-api/querying">Codat’s query language</a>.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=tags")]
        public string? Tags { get; set; }
    }
}