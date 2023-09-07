
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    
    public class EnhancedReportAccountCategory
    {
        [JsonProperty("levels")]
        public List<AccountCategoryLevel>? Levels { get; set; }
        
        /// <summary>
        /// Returns a status of "Suggested" or "Confirmed". If an account has a confirmed category, it will replace any suggested category returned.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }
        
    }
    
}