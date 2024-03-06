
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Operations
{
    using Codat.Platform.Utils;
    
    public class GetCustomDataTypeConfigurationRequest
    {

        /// <summary>
        /// Unique identifier for a custom data type.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=customDataIdentifier")]
        public string CustomDataIdentifier { get; set; } = default!;

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=platformKey")]
        public string PlatformKey { get; set; } = default!;
    }
}