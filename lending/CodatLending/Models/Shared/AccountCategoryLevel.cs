
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
    
    
    /// <summary>
    /// An object containing an ordered list of account category levels.
    /// </summary>
    public class AccountCategoryLevel
    {
        /// <summary>
        /// Confidence level of the category. This will only be populated where `status` is `Suggested`.
        /// </summary>
        [JsonProperty("confidence")]
        public decimal? Confidence { get; set; }
        
        /// <summary>
        /// Account category name.
        /// </summary>
        [JsonProperty("levelName")]
        public string? LevelName { get; set; }
        
    }
    
}