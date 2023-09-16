
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
    
    public class GetAccountingProfitAndLossRequest
    {

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

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=startMonth")]
        public string? StartMonth { get; set; }
    }
}