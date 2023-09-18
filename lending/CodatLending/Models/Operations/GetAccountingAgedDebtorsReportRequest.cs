
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
    using NodaTime;
    
    public class GetAccountingAgedDebtorsReportRequest
    {

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Number of periods to include in the report.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=numberOfPeriods")]
        public int? NumberOfPeriods { get; set; }

        /// <summary>
        /// The length of period in days.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=periodLengthDays")]
        public int? PeriodLengthDays { get; set; }

        /// <summary>
        /// Date the report is generated up to.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=reportDate")]
        public LocalDate? ReportDate { get; set; }
    }
}