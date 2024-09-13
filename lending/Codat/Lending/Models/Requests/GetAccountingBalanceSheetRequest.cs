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
    
    public class GetAccountingBalanceSheetRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Number of months defining the period of interest.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=periodLength")]
        public int PeriodLength { get; set; } = default!;

        /// <summary>
        /// Number of periods with `periodLength` to compare.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=periodsToCompare")]
        public int PeriodsToCompare { get; set; } = default!;

        /// <summary>
        /// The month the report starts from.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=startMonth")]
        public string? StartMonth { get; set; }
    }
}