//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Requests
{
    using Codat.Platform.Models.Components;
    using Codat.Platform.Utils;
    
    public class ConfigureCustomDataTypeRequest
    {

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=platformKey")]
        public string PlatformKey { get; set; } = default!;

        /// <summary>
        /// Unique identifier for a custom data type.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=customDataIdentifier")]
        public string CustomDataIdentifier { get; set; } = default!;

        /// <summary>
        /// Custom data type configuration for the specified platform.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public CustomDataTypeConfiguration? CustomDataTypeConfiguration { get; set; }
    }
}