
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
    /// ## Structure<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// Assess reports follow a consistent structure. Reports contain four sections of information:<br/>
    /// <br/>
    /// ### 1. Report definition<br/>
    /// <br/>
    /// Information such as:<br/>
    /// <br/>
    ///   1. The report info (e.g. enhanced_profit_and_loss).<br/>
    ///   2. The display name of the report (e.g. Enhanced Profit and Loss).<br/>
    ///   <br/>
    /// ### 2. Dimension info<br/>
    /// <br/>
    /// Information about the dimension contained in the reports such as:<br/>
    /// <br/>
    ///   1. The type of dimension (e.g. datetime, recordRef).<br/>
    ///   2. The display name of the dimension (e.g. Period, Category type, Category sub type).<br/>
    ///   3. The details about each item within the dimension (e.g. displayName:&quot;Jan 2022&quot;, start:&quot;...&quot;, end:&quot;...&quot;, id:&quot;...&quot;, name:&quot;...&quot;).<br/>
    /// <br/>
    /// ### 3. Measure info<br/>
    /// <br/>
    /// Information about the measures contained in the report such as:<br/>
    /// <br/>
    ///   1. The display name of the measure (e.g. value of account, percentage change).<br/>
    ///   2. The type of the measure (e.g. currency, percentage).<br/>
    ///   3. The unit of the measure (e.g. %, GBP).<br/>
    ///   <br/>
    /// ### 4. The data for the report<br/>
    /// <br/>
    /// When the *includeDisplayName* parameter is set to *true*, it shows the *dimensionDisplayName* and *itemDisplayName* to make the data human-readable. The default setting for *includeDisplayName* is *false*.<br/>
    /// <br/>
    /// <br/>
    /// ## Displaying the report<br/>
    /// <br/>
    /// Reports can be rendered as follows (ordering is implicit rather than explicit):<br/>
    /// <br/>
    /// !<a href="https://files.readme.io/1fa20ca-Report1.png">A table showing an example of how a report can be rendered</a><br/>
    /// <br/>
    /// # Data model<br/>
    /// <br/>
    /// ## Dimensions
    /// </remarks>
    /// </summary>
    public class CommerceReport
    {

        [JsonProperty("dimensions")]
        public List<CommerceReportDimension>? Dimensions { get; set; }

        [JsonProperty("errors")]
        public List<CommerceReportError>? Errors { get; set; }

        [JsonProperty("measures")]
        public List<CommerceReportMeasure>? Measures { get; set; }

        [JsonProperty("reportData")]
        public List<CommerceReportComponent>? ReportData { get; set; }

        [JsonProperty("reportInfo")]
        public Dictionary<string, string>? ReportInfo { get; set; }
    }
}