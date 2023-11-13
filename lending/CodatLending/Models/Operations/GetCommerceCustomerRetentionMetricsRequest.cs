
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
    using Codat.Lending.Models.Shared;
    using Codat.Lending.Utils;
    
    public class GetCommerceCustomerRetentionMetricsRequest
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
        /// Shows the dimensionDisplayName and itemDisplayName in measures to make the report data human-readable.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeDisplayNames")]
        public bool? IncludeDisplayNames { get; set; }

        /// <summary>
        /// The number of periods to return. There will be no pagination as a query parameter.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=numberOfPeriods")]
        public long NumberOfPeriods { get; set; } = default!;

        /// <summary>
        /// The number of months per period. E.g. 2 = 2 months per period.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=periodLength")]
        public long PeriodLength { get; set; } = default!;

        /// <summary>
        /// The period unit of time returned.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=periodUnit")]
        public PeriodUnit PeriodUnit { get; set; } = default!;

        /// <summary>
        /// The date in which the report is created up to. Users must specify a specific date, however the response will be provided for the full month.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=reportDate")]
        public string ReportDate { get; set; } = default!;
    }
}