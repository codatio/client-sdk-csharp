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
    /// A collection of links for the company.
    /// </summary>
    public class CompanyReferenceLinks
    {

        /// <summary>
        /// Link to the company page in the portal.
        /// </summary>
        [JsonProperty("portal")]
        public string? Portal { get; set; }
    }
}