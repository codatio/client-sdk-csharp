
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
    
    public class ListLoanTransactionsRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Data source type
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sourceType")]
        public ListLoanTransactionsSourceType SourceType { get; set; } = default!;
    }
}