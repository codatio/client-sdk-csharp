
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
    
public class DataIntegrityDetails
{
    [JsonProperty("amount")]
    public float? Amount { get; set; }
    
    [JsonProperty("connectionId")]
    public string? ConnectionId { get; set; }
    
    [JsonProperty("currency")]
    public string? Currency { get; set; }
    
    [JsonProperty("date")]
    public string? Date { get; set; }
    
    [JsonProperty("description")]
    public string? Description { get; set; }
    
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("matches")]
    public IEnumerable<DataIntegrityMatch>? Matches { get; set; }
    
    [JsonProperty("type")]
    public string? Type { get; set; }
    
}
}