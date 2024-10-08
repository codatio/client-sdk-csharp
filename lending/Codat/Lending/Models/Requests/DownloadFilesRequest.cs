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
    
    public class DownloadFilesRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Only download files uploaded on this date.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=date")]
        public string? Date { get; set; }
    }
}