//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Components
{
    using Codat.Sync.Payables.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Gets the latest basic info for a company.
    /// </summary>
    public class CompanyInformation
    {

        /// <summary>
        /// Name of the linked company.
        /// </summary>
        [JsonProperty("companyName")]
        public string? CompanyName { get; set; } = null;

        /// <summary>
        /// Currency set in the accounting software of the linked company. Used by the currency rate.
        /// </summary>
        [JsonProperty("baseCurrency")]
        public string? BaseCurrency { get; set; } = null;
    }
}