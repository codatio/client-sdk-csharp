
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
    
    
    /// <summary>
    /// Supplemental data is additional data you can include in our standard data types. 
    /// 
    /// <remarks>
    /// 
    /// It is referenced as a configured dynamic key value pair that is unique to the accounting platform. [Learn more](https://docs.codat.io/using-the-api/additional-data) about supplemental data.
    /// </remarks>
    /// </summary>
    public class CommerceOrderSupplementalData
    {
        [JsonProperty("content")]
        public Dictionary<string, Dictionary<string, object>>? Content { get; set; }
        
    }
    
}