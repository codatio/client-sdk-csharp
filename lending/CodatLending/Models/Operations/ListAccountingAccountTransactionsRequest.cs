
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
    
    
    public class ListAccountingAccountTransactionsRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;
        
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; } = default!;
        
        /// <summary>
        /// Field to order results by. [Read more](https://docs.codat.io/using-the-api/ordering-results).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=orderBy")]
        public string? OrderBy { get; set; }
        
        /// <summary>
        /// Page number. [Read more](https://docs.codat.io/using-the-api/paging).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public int? Page { get; set; }
        
        /// <summary>
        /// Number of records to return in a page. [Read more](https://docs.codat.io/using-the-api/paging).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public int? PageSize { get; set; }
        
        /// <summary>
        /// Codat query string. [Read more](https://docs.codat.io/using-the-api/querying).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=query")]
        public string? Query { get; set; }
        
    }
    
}