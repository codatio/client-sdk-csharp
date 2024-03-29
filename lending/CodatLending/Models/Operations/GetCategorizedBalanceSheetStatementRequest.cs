
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Operations
{
    using Codat.Lending.Utils;
    
    public class GetCategorizedBalanceSheetStatementRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// The number of periods to return. If not provided, 12 periods will be used as the default value.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=numberOfPeriods")]
        public long? NumberOfPeriods { get; set; }

        /// <summary>
        /// The date in which the report is created up to. Users must specify a specific date, however the response will be provided for the full month.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=reportDate")]
        public string ReportDate { get; set; } = default!;
    }
}