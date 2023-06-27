
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
    
public class ReportComponent
{
    [JsonProperty("components")]
    public List<ReportComponent>? Components { get; set; }
    
    [JsonProperty("dimension")]
    public int? Dimension { get; set; }
    
    [JsonProperty("dimensionDisplayName")]
    public string? DimensionDisplayName { get; set; }
    
    [JsonProperty("item")]
    public int? Item { get; set; }
    
    [JsonProperty("itemDisplayName")]
    public string? ItemDisplayName { get; set; }
    
    [JsonProperty("measures")]
    public List<ReportComponentMeasure>? Measures { get; set; }
    
}
}