//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Components
{
    using Codat.Lending.Models.Components;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class CommerceReportComponent
    {

        /// <summary>
        /// The component&apos;s dimension.
        /// </summary>
        [JsonProperty("dimension")]
        public long? Dimension { get; set; }

        /// <summary>
        /// The component&apos;s display name.
        /// </summary>
        [JsonProperty("dimensionDisplayName")]
        public string? DimensionDisplayName { get; set; }

        /// <summary>
        /// The component&apos;s item number.
        /// </summary>
        [JsonProperty("item")]
        public long? Item { get; set; }

        /// <summary>
        /// The component&apos;s item display name.
        /// </summary>
        [JsonProperty("itemDisplayName")]
        public string? ItemDisplayName { get; set; }

        [JsonProperty("measures")]
        public List<ReportComponentMeasure>? Measures { get; set; }

        [JsonProperty("components")]
        public List<CommerceReportComponent>? Components { get; set; }
    }
}