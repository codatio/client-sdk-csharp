//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Operations
{
    using Codat.Platform.Utils;
    
    public class GetWebhookRequest
    {

        /// <summary>
        /// Unique ID of the webhook or rule.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ruleId")]
        public string RuleId { get; set; } = default!;
    }
}