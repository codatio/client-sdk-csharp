//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Operations
{
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    
    public class ReplaceCompanyRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public CompanyRequestBody? CompanyRequestBody { get; set; }
    }
}