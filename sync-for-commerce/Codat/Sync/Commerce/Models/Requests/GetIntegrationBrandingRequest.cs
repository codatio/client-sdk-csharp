//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Requests
{
    using Codat.Sync.Commerce.Utils;
    
    public class GetIntegrationBrandingRequest
    {

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=platformKey")]
        public string PlatformKey { get; set; } = default!;
    }
}