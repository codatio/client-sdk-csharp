
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.Shared
{
    using Codat.Utils;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class DataIntegrityByAmount
{
    [JsonProperty("currency")]
    public string? Currency { get; set; }
    
    [JsonProperty("matchPercentage")]
    public float? MatchPercentage { get; set; }
    
    [JsonProperty("matched")]
    public float? Matched { get; set; }
    
    [JsonProperty("total")]
    public float? Total { get; set; }
    
    [JsonProperty("unmatched")]
    public float? Unmatched { get; set; }
    
}
}